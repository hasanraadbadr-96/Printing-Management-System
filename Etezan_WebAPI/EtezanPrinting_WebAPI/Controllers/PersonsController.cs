using BusinessLayeres; // استدعاء المكتبة المشتركة اللي سويتها
using EtezanPrinting_Shared.PersonDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace EtezanPrinting_WebAPI.Controllers
{
    [Route("api/Person")]
    [ApiController]
    [Authorize] // <--- أضف هذا السطر هنا
    public class PersonsController : ControllerBase
    {

        clsPersons person = new clsPersons(); // استخدم الدالة الـ static أفضل


        // إذا كنت تستخدم الطريقة التقليدية (بدون حقن تبعية حالياً للتبسيط)
        // تأكد أنك لا تستدعي دالة غير ستاتيك بدون عمل new


        [HttpGet("{lastPersonID}/{rowsNumber}/{direction}")] // غيرت الكوما إلى سلاش للـ Routing الصح
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<PersonDTO>> LoadPersonsPaged(int lastPersonID, int rowsNumber, string direction)
        {
            try
            {
                // استدعي الدالة مباشرة من كلاس جديد لضمان التهيئة
                var persons = person.GetPersonsPaged(lastPersonID, rowsNumber, direction);

                if (persons == null || persons.Count == 0)
                {
                    return NotFound("لا توجد بيانات حالياً");
                }

                return Ok(persons);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet("{ID}", Name = "GetPersonByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PersonDTO> GetPersonByID(int ID)
        {
            if (ID <= 0) return BadRequest("رقم المعرف غير منطقي");

            // استدعي الدالة مباشرة بشكل Static إذا جنت معرفها هيج، أو من نسخة وحدة
            person = person.GetPersonById(ID);
            if (person == null)
            {
                return NotFound($"لم يتم العثور على الشخص رقم: {ID}");
            }

            // ارجع الـ DTO الجاهز اللي سويناه سوية
            return Ok(person.personDto);
        }

        [HttpPost("ADD", Name = "AddNewPerson")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult AddNewPerson(PersonDTO Newperson)
        {
            // 1. شيك الاسم الكامل (ما يصير فارغ)
            if (string.IsNullOrEmpty(Newperson.full_name))
            {
                return BadRequest("خطأ: الاسم الكامل مطلوب ولا يمكن تركه فارغاً.");
            }

            // 2. شيك رقم الموبايل (ما يصير فارغ)
            if (string.IsNullOrEmpty(Newperson.phone_number))
            {
                return BadRequest("خطأ: رقم الهاتف مطلوب للتواصل مع الزبون.");
            }

            // 3. شيك العنوان
            if (string.IsNullOrEmpty(Newperson.address))
            {
                return BadRequest("خطأ: يرجى إدخال عنوان الزبون.");
            }

            // 4. شيك الجنس (لازم يحدد ذكر أو أنثى)
            if (string.IsNullOrEmpty(Newperson.gendor))
            {
                return BadRequest("خطأ: يرجى تحديد جنس الشخص (ذكر/أنثى).");
            }

            // 5. شيك رقم المدينة (لازم يكون أكبر من 0 لأن الـ IDs تبدأ من 1)
            if (Newperson.city_id <= 0)
            {
                return BadRequest("خطأ: رقم المدينة غير صحيح، يرجى اختيار مدينة صالحة.");
            }

            // 6. شيك حالة الشخص
            if (Newperson.persons_status_id <= 0)
            {
                return BadRequest("خطأ: يرجى تحديد حالة الشخص (نشط/غير نشط).");
            }

            // إذا عبر كل هاي السيطرات، هسة نبدي عملية الحفظ
            try
            {
                // سوينا كائن جديد من كلاس الـ Business وحولنا الـ DTO اللي جاينا
                 person = new clsPersons(new PersonDTO(
                    Newperson.personID,
                    Newperson.full_name,
                    Newperson.phone_number,
                    Newperson.address,
                    Newperson.order_count,
                    Newperson.notes,
                    Newperson.persons_status_id,
                    Newperson.gendor,
                    Newperson.city_id,
                    Newperson.ImagePath));

                // استدعاء دالة الحفظ اللي كتبناها سابقاً
                if (person.Save())
                {
                    Newperson.personID = person.personID;
                    return CreatedAtRoute("GetPersonByID", new { ID = Newperson.personID }, Newperson);
                }
                else
                {
                    return BadRequest("فشلت عملية الحفظ في قاعدة البيانات، تأكد من صحة البيانات المرسلة.");
                }
            }
            catch (Exception ex)
            {
                // في حال صار خطأ غير متوقع بالسيستم
                return StatusCode(500, $"حدث خطأ داخلي: {ex.Message}");
            }
        }


        [HttpPut("{id}", Name = "UpdatePerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdatePerson(int id, UpdatePersonDTO Updateperson)
        {
            // 1. السيطرة النوعية على المدخلات (Validation)
            if (string.IsNullOrEmpty(Updateperson.full_name))
                return BadRequest("خطأ: الاسم الكامل مطلوب.");

            if (string.IsNullOrEmpty(Updateperson.phone_number))
                return BadRequest("خطأ: رقم الهاتف مطلوب.");

            if (string.IsNullOrEmpty(Updateperson.address))
                return BadRequest("خطأ: العنوان مطلوب.");

            if (Updateperson.city_id <= 0)
                return BadRequest("خطأ: رقم المدينة غير صحيح.");
            if (Updateperson.persons_status_id <= 0)
                return BadRequest("خطأ: رقم حالة الشخص غير صحيح.");

            try
            {
                // 2. نحاول نجيب الشخص من قاعدة البيانات باستخدام الـ ID
                person = person.GetPersonById(id);
                if (person == null)
                {
                    return NotFound($"لم يتم العثور على هذا الشخص رقم معرفه: {id}");
                }

                // 3. تحديث خصائص الكائن بالبيانات الجديدة اللي جتي من الـ DTO
                person.full_name = Updateperson.full_name;
                person.phone_number = Updateperson.phone_number;
                person.address = Updateperson.address;
                person.order_count = Updateperson.order_count;
                person.notes = Updateperson.notes;
                person.persons_status_id = Updateperson.persons_status_id;
                person.gendor = Updateperson.gendor;
                person.city_id = Updateperson.city_id;
                person.ImagePath = Updateperson.ImagePath;

                // 4. 🔥 الخطوة الأهم: استدعاء دالة الـ Save
                // الـ Save راح تعرف إن الـ Mode هو Update وتروح تشغل البروسيجر SP_UpdatePerson
                if (person.Save())
                {
                    // نرجع الشخص المحدث مع كود 200 OK
                    return Ok("تم التعديل بنجاح");
                }
                else
                {
                    // إذا الـ Save رجعت false (مثلاً مشكلة بالاتصال أو بالبروسيجر)
                    return StatusCode(500, "فشلت عملية التحديث في قاعدة البيانات.");
                }
            }
            catch (Exception ex)
            {
                // تسجيل الخطأ وإرجاع كود 500
                return StatusCode(500, $"حدث خطأ داخلي: {ex.Message}");
            }
        

    }


        [HttpDelete("{id}", Name = "DeletePerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult DeletePerson(int id)
        {
            // 1. نشيك الـ ID إذا مو منطقي (أصغر من 1) نرجع خطأ فوراً
            if (id < 1)
            {
                return BadRequest($"المعرف {id} غير صالح، يرجى إدخال رقم صحيح.");
            }

            try
            {

                if (!person.isExistPersonByID(id))
                {
                    return NotFound($"عذراً، لم يتم العثور على شخص يحمل المعرف {id} لحذفه.");

                }
                // 2. نستدعي دالة الحذف الثابتة (Static) من كلاس البزنس
                // لاحظ استخدمنا اسم الكلاس clsPersons مباشرة لأن الدالة Static
                if (!person.DeletePersonById(id))
                {
                    return StatusCode(500, "فشلت عملية الحذف داخل قاعدة البيانات");

                }

            }
            catch (Exception ex)
            {
                // في حال صار خطأ غير متوقع بالسيرفر أو القاعدة، نرجع كود 500 مع تفاصيل الخطأ
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"حدث خطأ أثناء محاولة الحذف: {ex.Message}");
            }

            // إذا نجح الحذف، نرجع رسالة نجاح
            return Ok($"تم حذف الشخص صاحب المعرف {id} بنجاح من قاعدة بيانات المطبعة.");


        }




    }


    }
