using BusinessLayeres;
using EtezanPrinting_Shared.UsersDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data;
using System.Xml.Linq;

namespace EtezanPrinting_WebAPI.Controllers
{
    [Route("api/Users")]
    [ApiController]
    [Authorize] // <--- هذا هو النقص! هسة الـ UsersController صار محمي وما يفتح إلا بتوكن
    public class UsersController : ControllerBase
    {
        UsersDTO usersDTO = new UsersDTO();
        clsUsers users = new clsUsers();

       
    [HttpGet("All", Name = "GetAllUsersList")]
    [Authorize(Roles = "SuperAdmin")] // هنا القفل: إذا التوكن ما بيه SuperAdmin راح يعطي 403 فوراً
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)] // ضفنا هذا الرد المتوقع
    public ActionResult<IEnumerable<UsersDTO>> GetAllUsersList()
        {
            // لزيادة الأمان (كود المحترفين): نشيك داخل الدالة أيضاً
            if (!User.IsInRole("SuperAdmin"))
            {
                return Forbid("دخول ممنوع! يجب أن تكون SuperAdmin لعرض هذه البيانات."); // طرد يدوي إذا عبر من الـ Attribute
            }

            try
            {
                var userList = users.GetAllUsersList();
                if (userList == null || !userList.Any()) return NotFound("قائمة المستخدمين فارغة");
                return Ok(userList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // باقي الدوال (Add, Update, Delete) تبقى عليها [Authorize(Roles = "SuperAdmin")] كما هي في كودك



        [HttpGet("FindBy/{id}", Name = "GetUserByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)] // ضفنا هذا لأننا قد نمنع المستخدم
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UsersDTO> GetUserByID(int id)
        {
            // 1. فحص الأرقام السالبة
            if (id <= 0)
            {
                return BadRequest("من فضلك ادخل قيمة صحيحة اكبر من صفر");
            }

            // --- [الحارس الأمني المحترف] ---
            // نسحب المعرف مالت الشخص اللي جاي يطلب البيانات من التوكن
            var currentUserIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);

            if (currentUserIdClaim == null) return Unauthorized(); // إذا ماكو توكن أصلاً

            int currentUserId = int.Parse(currentUserIdClaim.Value);
            bool isSuperAdmin = User.IsInRole("SuperAdmin");

            // القاعدة: إذا مو سوبر أدمن، وما جاي يطلب الـ ID مالته نفسه.. اطرده!
            if (!isSuperAdmin && currentUserId != id)
            {
                return StatusCode(403, new
                {
                    message = "عذراً، لا يمكنك عرض بيانات مستخدم آخر. هذه الصلاحية للمدراء فقط."
                });
            }
            // ------------------------------

            try
            {
                // 2. نبحث عن المستخدم في طبقة البزنس
                var user = clsUsers.FindUserById(id);

                // 3. الحارس (Guard Clause): إذا طلع null نرجع 404 فوراً
                if (user == null)
                {
                    return NotFound($"لم يتم العثور على المستخدم رقم معرفه {id}");
                }

                // 4. فقط وفقط إذا لگيناه، نطلب الـ DTO
                return Ok(user.UsersDTO);
            }
            catch (Exception ex)
            {
                // 5. في حال وجود خطأ تقني غير متوقع
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [Authorize(Roles = "SuperAdmin")] // الحذف حصراً للسوبر أدمن
        [HttpPost("ADD", Name = "AddNewUser")] // 1. حولناه إلى Post لأننا نرسل بيانات
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UsersDTO> AddNewUser(UsersDTO NewUser)
        {
            // الفحوصات مالتك ممتازة.. تبقى مثل ما هي
            if (string.IsNullOrWhiteSpace(NewUser.UserName))
                return BadRequest("خطأ: يجب إدخال اسم المستخدم.");

            if (string.IsNullOrWhiteSpace(NewUser.Password) || NewUser.Password.Length < 6)
                return BadRequest("خطأ: كلمة المرور ضعيفة.");

            if (NewUser.PersonID <= 0 || NewUser.UsersPermissionID <= 0)
                return BadRequest("خطأ: تأكد من أرقام الشخص والصلاحية.");

            try
            {
                // 2. إنشاء كائن البزنس
                clsUsers user = new clsUsers(NewUser, clsUsers.enMode.Add);

                if (user.Save())
                {
                    // 3. الربط الصحيح: نرسل الـ ID الجديد اللي انخلق بالداتابيز
                    // "GetUserByID" هو اسم الدالة اللي تسوي Find بالـ API مالتك
                    return CreatedAtRoute("GetUserByID", new { id = user.UserID }, user.UsersDTO);
                }
                else
                {
                    return BadRequest("لم يتم الحفظ، ربما اسم المستخدم موجود مسبقاً.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [Authorize(Roles = "SuperAdmin")] // الحذف حصراً للسوبر أدمن
        // 1. تحديد نوع الطلب: استخدمنا HttpPost (أو HttpPut) لأننا جاي نرسل بيانات جديدة للتعديل
        [HttpPut("UpdateBy/{ID}", Name = "UpdateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<UpdateUserDTO> UpdateUser(int ID, UpdateUserDTO UpdateUser)
        {
            // --- مرحلة الفحص (Validation) ---
            // إذا الاسم فارغ، نرجع BadRequest (كود 400)
            if (string.IsNullOrWhiteSpace(UpdateUser.UserName))
                return BadRequest("خطأ: يجب إدخال اسم المستخدم.");

            // فحص طول كلمة المرور (أمنياً لازم ما تقل عن 6)
            if (string.IsNullOrWhiteSpace(UpdateUser.Password) || UpdateUser.Password.Length < 6)
                return BadRequest("خطأ: كلمة المرور ضعيفة.");

            // فحص المعرفات (لازم تكون أرقام حقيقية مو صفر أو سالب)
            if (UpdateUser.PersonID <= 0 || UpdateUser.UsersPermissionID <= 0)
                return BadRequest("خطأ: تأكد من أرقام الشخص والصلاحية.");

            try
            {
                // 2. "البحث": قبل ما نحدث، لازم نتأكد هذا المستخدم أصلاً موجود عدنا؟
                clsUsers user = clsUsers.FindUserById(ID);

                if (user == null)
                {
                    // إذا ما لكيناه، نرجع NotFound (كود 404)
                    return NotFound($"لم يتم العثور على المستخدم رقم معرفه {ID}");
                }
                else
                {
                    // 3. "نقل البيانات": نفرغ المعلومات الجاية من الـ DTO بداخل كائن البزنس (user)
                    user.UserName = UpdateUser.UserName;
                    user.Password = UpdateUser.Password;
                    user.PersonID = UpdateUser.PersonID;
                    user.PermissionID = UpdateUser.UsersPermissionID;
                    user.isActive = UpdateUser.IsActive;

                    // 4. "الحفظ": نستدعي دالة الـ Save اللي هي راح تسوي الـ Update بالداتابيز
                    if (user.Save())
                    {
                        // إذا نجح الحفظ، نرجع رسالة نجاح (كود 200)
                        return Ok("تم الحفظ بنجاح");
                    }
                    else
                    {
                        // إذا فشل (مثلاً اليوزر نيم مكرر)، نرجع BadRequest
                        return BadRequest("لم يتم الحفظ، ربما اسم المستخدم موجود مسبقاً.");
                    }
                }
            }
            catch (Exception ex)
            {
                // 5. "خط الدفاع الأخير": إذا صار أي خطأ غير متوقع بالسيرفر
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [Authorize(Roles = "SuperAdmin")] // الحذف حصراً للسوبر أدمن
        // 1. تحديد نوع الطلب: HttpDelete هو الأنسب لعمليات الحذف (المقّص)
        [HttpDelete("DeleteBy/{ID}", Name = "DeleteUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // ملاحظة: غيرنا النوع الراجع لـ string لأننا نرجع رسالة نجاح مو DTO كامل
        public ActionResult DeleteUser(int ID)
        {
            // فحص أولي: إذا الزبون دز رقم صفر أو سالب، نكله "العب غيرها"
            if (ID <= 0)
                return BadRequest("خطأ: يجب إدخال رقم المعرف اكبر من صفر.");

            try
            {
                // 2. "الفحص المسبق": قبل ما نحذف، نشيك الرادار.. هذا الشخص موجود أصلاً؟
                if (!users.isExistUser(ID))
                {
                    // إذا ماكو، نرجع 404 ونكله "تعبت نفسك، هو أصلاً ما موجود"
                    return NotFound($"لم يتم العثور على المستخدم رقم معرفه {ID}");
                }
                else
                {
                    // 3. "التنفيذ": بما إنه موجود، هسه نكدر نحذفه بقلب قوي
                    if (users.DeleteUserById(ID))
                    {
                        // إذا انمسح من الداتابيز، نرجع كود 200 ورسالة حلوة
                        return Ok("تم الحذف بنجاح");
                    }
                    else
                    {
                        // إذا فشل (مثلاً مرتبط ببيانات ثانية)، نكله "ماكدرنا نمسحه حالياً"
                        return BadRequest("لم يتم الحذف، ربما هذا المستخدم مرتبط ببيانات أخرى أو تم حذفه مسبقاً.");
                    }
                }
            }
            catch (Exception ex)
            {
                // إذا السيرفر وكع أو صارت مشكلة تقنية
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
