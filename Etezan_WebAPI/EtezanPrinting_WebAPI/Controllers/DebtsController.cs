using BusinessLayeres; // استدعاء طبقة الشغل مالتنا (BLL) حتى نوصل للدوال
using EtezanPrinting_Shared.DebtDTO;
using EtezanPrinting_Shared.Depts; // استدعاء الـ DTO اللي سويناه حتى ننقل بيه البيانات
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http; // مكتبة خاصة بالـ HTTP حتى نعرف الـ Status Codes
using Microsoft.AspNetCore.Mvc; // المكتبة الأساسية لبناء الـ API والـ Controllers

namespace EtezanPrinting_WebAPI.Controllers
{
    [Route("api/Debets")] // هذا هو "العنوان" أو الطريق اللي يوصلنا لهذا الكنترولر بالمتصفح
    [ApiController] // نكول للـ ASP.NET ترى هذا الكلاس هو API مو صفحة ويب عادية
    [Authorize] // <--- أضف هذا السطر هنا
    public class DebtsController : ControllerBase
    {
        // سوينا نسخة (Object) من كلاس الديون حتى نكدر نستخدم دواله
        clsDebts debt = new clsDebts();
        DebtDTO debtDTO = new DebtDTO();
        // هذا الـ Endpoint نوعه GET وبيه اسم خاص للوصول السريع
        [HttpGet("All", Name = "GetAllDebtsList")]

        // هنا نحدد شنو الاحتمالات اللي ترجع (إذا نجح نرجع 200 وإذا فشل أو ماكو نرجع 404)
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<DebtDTO>> GetAllDebtsList()
        {
            // نروح نجيب لستة الديون كلها من طبقة الـ Business ونخزنها بالمتغير
            var DebetsList = debt.GetAllDebtsList();


            // نفحص.. إذا اللستة فارغة أو null يعني ماكو بيانات بقاعدة البيانات
            if (DebetsList == null)
            {
                // نرجع رسالة "NotFound" وياها نص عربي يوضح السالفة
                return NotFound("لايوجد بيانات لعرضها");
            }

            // إذا الأمور طيبة والبيانات موجودة، نرجعها ونكول للبرنامج "Ok" (حملت بنجاح)
            return Ok(DebetsList);
        }

        [HttpGet("GetDeptBy{ID}", Name = "GetDeptByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DebtDTO> GetDeptByID(int ID)
        {

            try
            {
                // نتأكد أن الآيدي مو سالب، لأن ماكو هيج رقم بقاعدة البيانات
                if (ID <= 0)
                {
                    return BadRequest("، أدخل رقم معرف (ID) صحيح ومو صفر أو سالب");
                }

                // ندور على الدين بقاعدة البيانات عن طريق الآيدي
                 debt = clsDebts.Find(ID);

                // إذا ما لكينا شي، نكول للمستخدم ترى هذا الرقم ما مسجل عدنا
                if (debt == null)
                {
                    return NotFound($"لم يتم العثور علئ أي دين مسجل بهذا الرقم: {ID}");
                }

                // --- هنا تبدي عملية ترس البيانات من الداتابيز للـ DTO ---

                // نثبت رقم الدين الأساسي
                debtDTO.DebtID = debt.DebtID;

                // نحط اسم الشخص المطلوب الفلوس (المدين)
                debtDTO.DebtorName = debt.debtor_name;

                // نسجل رقم تليفونه حتى نكدر نتواصل وياه
                debtDTO.PhoneNumber = debt.phone_number;

                // نثبت مبلغ الدين، واستخدمنا دسمال حتى الحساب يطلع مضبوط
                debtDTO.DebtAmount = debt.debt_amount;

                // نسجل عنوان سكنه أو محله وين صاير
                debtDTO.Address = debt.address;

                // نثبت التاريخ والوقت اللي صار بيه هذا الدين
                debtDTO.DebtDate = debt.debt_date;

                // إذا جان هذا الدين تابع لطلبية معينة، نثبت رقم الطلبية
                debtDTO.OrdersID = debt.orders_id;

                // نسجل آيدي الموظف اللي دخل هاي البيانات بالنظام
                debtDTO.UsersID = debt.users_id;

                // نربطه بمعرف الشخص بقاعدة بيانات الأشخاص العامة
                debtDTO.PersonsID = debt.persons_id;

                // نحدد إذا هذا الدين بعده "مطلوب" لو تسدد وانغلق (Active)
                debtDTO.IsActive = debt.isActive;

            }
            catch (Exception )
            {
                // إذا صارت مشكلة غير متوقعة، نكدر نسجل الخطأ هنا
                return StatusCode(500, "صارت مشكلة داخلية بالسيرفر، يرجى التأكد من الكود");
            }

            // أخيراً نرجع البيانات كاملة ومتروسة بالـ DTO
            return Ok(debtDTO);
        }




        [HttpPost("ADD", Name = "AddNewDebt")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult AddNewDebt(DebtDTO NewDebtDTO)
        {
            // 1. التأكد من اسم المدين
            if (string.IsNullOrWhiteSpace(NewDebtDTO.DebtorName))
            {
                return BadRequest("أخوي، لازم تذكر اسم الرجال المطلوب (المدين)");
            }

            // 2. التأكد من المبلغ (ما يصير نطلب واحد صفر أو بالسالب!)
            if (NewDebtDTO.DebtAmount <= 0)
            {
                return BadRequest("المبلغ لازم يكون أكبر من صفر، ما يصير تسجل دين فارغ");
            }

            // 3. التأكد من هوية الشخص المرتبط بالدين
            if (NewDebtDTO.PersonsID == null || NewDebtDTO.PersonsID <= 0)
            {
                return BadRequest("من فضلك أرسل رقم معرف الشخص (PersonsID) بشكل صحيح");
            }

            // 4. التأكد من المستخدم اللي جاي يسجل العملية
            if (NewDebtDTO.UsersID == null || NewDebtDTO.UsersID <= 0)
            {
                return BadRequest("لازم نعرف يا موظف جاي يسجل هذا الدين (UsersID مطلوب)");
            }

            try
            {
                // نحول الـ DTO إلى كائن بزنس (Business Object) حتى نكدر نحفظه
                // استخدمنا المشيد اللي رتبناه فوك حتى نمرر كل البيانات مو بس الاسم
                // سوينا كائن البزنس ومررنا له الـ DTO بتسلسل المتغيرات الصحيح
                clsDebts debt = new clsDebts(new DebtDTO(
                    NewDebtDTO.DebtID,                          // الـ DebtID (نرسل 0 لأن الإضافة تولد آيدي تلقائي)
                    NewDebtDTO.DebtorName,      // اسم المدين
                    NewDebtDTO.PhoneNumber,     // رقم التليفون
                    NewDebtDTO.DebtAmount,      // مبلغ الدين
                    NewDebtDTO.Address,         // العنوان
                    DateTime.Now,               // التاريخ (نمرر وقت اللحظة الحالية)
                    NewDebtDTO.OrdersID,        // آيدي الطلبية
                    NewDebtDTO.UsersID,         // آيدي المستخدم
                    NewDebtDTO.PersonsID,       // آيدي الشخص
                    NewDebtDTO.IsActive                        // حالة القيد (Active)

                ),clsDebts.enMode.AddNew);

                if (debt.Save())
                {
                    // تحديث الـ DTO بالـ ID الجديد اللي رجع من الداتابيز
                    NewDebtDTO.DebtID = debt.DebtID;

                    // نرجع استجابة 201 مع البيانات المحدثة
                    return CreatedAtRoute("GetDeptByID", new { ID = NewDebtDTO.DebtID }, NewDebtDTO);
                }
                else
                {
                    return StatusCode(500, "فشلت عملية الحفظ داخل قاعدة البيانات، راجع مبرمج السيرفر");
                }
            }
            catch (Exception ex)
            {
                // نسجل الخطأ ونرجع رسالة واضحة
                return StatusCode(500, $"صارت مشكلة داخلية بالسيرفر: {ex.Message}");
            }
        }


        [HttpPut("UPDATE", Name = "UpdateDebtByID")]
        [ProducesResponseType(StatusCodes.Status200OK)] // التحديث يرجع 200 عادةً مو 201
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateDebtByID(int id, UpdateDebtDTO updateDebt)
        {
            // نتأكد أن المعرف (ID) مو صفر أو سالب حتى لا ندوخ قاعدة البيانات
            if (id <= 0)
            {
                return BadRequest("من فضلك ادخل قيمة صحيحة أكبر من صفر لمعرف الدين");
            }

            // 1. التأكد من اسم المدين (ما يصير نحدث ونعوف الاسم فارغ)
            if (string.IsNullOrWhiteSpace(updateDebt.DebtorName))
            {
                return BadRequest("أخوي، لازم تذكر اسم الرجال المطلوب (المدين)");
            }

            // 2. التأكد من المبلغ (التحديث لازم يكون بمبلغ حقيقي)
            if (updateDebt.DebtAmount <= 0)
            {
                return BadRequest("المبلغ لازم يكون أكبر من صفر، ما يصير تسجل دين فارغ");
            }

            // 3. التأكد من هوية الشخص المرتبط بالدين
            if (updateDebt.PersonsID == null || updateDebt.PersonsID <= 0)
            {
                return BadRequest("من فضلك أرسل رقم معرف الشخص (PersonsID) بشكل صحيح");
            }

            // 4. التأكد من المستخدم اللي جاي يعدل البيانات (الموظف المسؤول)
            if (updateDebt.UsersID == null || updateDebt.UsersID <= 0)
            {
                return BadRequest("لازم نعرف يا موظف جاي يعدل هذا الدين (UsersID مطلوب)");
            }

            try
            {
                // ندور على الدين الأصلي بقاعدة البيانات قبل ما نعدل عليه
                debt = clsDebts.Find(id);

                // إذا ما لكينا السجل، نكول للمستخدم ترى هذا الدين ما موجود
                if (debt == null)
                {
                    return NotFound($"لم يتم العثور على أي دين مسجل بالرقم: {id}");
                }

                // --- نبدي نحدث بيانات كائن البزنس من الـ DTO اللي وصلنا من الـ API ---

                // نحدث اسم المدين
                debt.debtor_name = updateDebt.DebtorName;

                // نحدث رقم التلفون
                debt.phone_number = updateDebt.PhoneNumber;

                // نحدث مبلغ الدين
                debt.debt_amount = updateDebt.DebtAmount;

                // نحدث العنوان
                debt.address = updateDebt.Address;

                // نحدث تاريخ الدين (أو نبقيه نفسه حسب حاجة المطبعة)
                debt.debt_date = updateDebt.DebtDate;

                // نحدث رقم الطلبية المرتبطة
                debt.orders_id = updateDebt.OrdersID ?? -1;

                // نحدث آيدي المستخدم المسؤول عن التعديل
                debt.users_id = updateDebt.UsersID ?? -1;

                // نحدث آيدي الشخص بالسيستم
                debt.persons_id = updateDebt.PersonsID ?? -1;

                // نحدث حالة النشاط (فعال لو تسدد)
                debt.isActive = updateDebt.IsActive;

                // نستدعي دالة الـ Save اللي راح تشغل الـ Update بالداتابيز
                if (!debt.Save())
                {
                    // إذا الـ Save رجعت False معناها اكو مشكلة بالحفظ
                    return StatusCode(500, "فشلت عملية الحفظ داخل قاعدة البيانات");
                }
            }
            catch (Exception ex)
            {
                // في حال صار خطأ غير متوقع بالسيرفر نرجعه حتى نعرف السبب
                return StatusCode(500, $"حدثت مشكلة داخلية بالسيرفر: {ex.Message}");
            }

            // إذا وصل الكود لهنا، يعني كلشي تمام والتعديل صار
            return Ok("تم التعديل بنجاح");
        }




        // "Endpoint" خاص بحذف دين معين من خلال الـ ID الخاص به باستخدام HTTP DELETE
        [HttpDelete("DeleteBy{ID}", Name = "DeleteDebtByID")]
        [ProducesResponseType(StatusCodes.Status200OK)] // في حال النجاح
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // في حال كان الـ ID غير منطقي
        [ProducesResponseType(StatusCodes.Status404NotFound)] // في حال السجل غير موجود
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] // في حال حدوث خطأ بالسيرفر
        public ActionResult DeleteDebtByID(int ID)
        {
            // أول خطوة: نتأكد إن الـ ID الجاي من المستخدم هو رقم موجب وصحيح [cite: 2026-02-21]
            if (ID <= 0)
            {
                return BadRequest("من فضلك ادخل قيمة صحيحة أكبر من صفر لمعرف الدين");
            }

            try
            {
                // 🚀 لمسة المحترفين: نستخدم isExist للتحقق السريع من وجود السجل [cite: 2026-01-26, 2026-02-21]
                // هاي الطريقة أسرع بمرات من استخدام Find لأنها ما تحمل بيانات السجل كاملة [cite: 2026-02-21]
                if (!debt.isExist(ID))
                {
                    // إذا السجل أصلاً ما موجود، نرجع 404 ونختصر الوقت [cite: 2026-02-21]
                    return NotFound($"لم يتم العثور على أي دين مسجل بالرقم: {ID}");
                }

                // بما إننا تأكدنا إنه موجود، هسة ننفذ أمر الحذف الفعلي [cite: 2026-02-21]
                if (!debt.Delete(ID))
                {
                    // في حال فشل الحذف لسبب تقني بقاعدة البيانات أو وجود قيود (Constraints) [cite: 2026-02-21]
                    return StatusCode(500, "فشلت عملية الحذف داخل قاعدة البيانات");
                }
            }
            catch (Exception ex)
            {
                // إذا صار أي خطأ غير متوقع، نرجعه بـ 500 حتى نعرف الخلل وين بالضبط [cite: 2026-02-21]
                return StatusCode(500, $"حدثت مشكلة داخلية بالسيرفر: {ex.Message}");
            }

            // إذا الأمور طيبة، نرجع رسالة نجاح للمستخدم [cite: 2026-02-21]
            return Ok("تم الحذف بنجاح");
        }
    }
}