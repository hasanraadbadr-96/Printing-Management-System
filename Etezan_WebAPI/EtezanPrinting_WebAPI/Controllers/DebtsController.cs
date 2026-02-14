using BusinessLayeres; // استدعاء طبقة الشغل مالتنا (BLL) حتى نوصل للدوال
using EtezanPrinting_Shared.Depts; // استدعاء الـ DTO اللي سويناه حتى ننقل بيه البيانات
using Microsoft.AspNetCore.Http; // مكتبة خاصة بالـ HTTP حتى نعرف الـ Status Codes
using Microsoft.AspNetCore.Mvc; // المكتبة الأساسية لبناء الـ API والـ Controllers

namespace EtezanPrinting_WebAPI.Controllers
{
    [Route("api/Debets")] // هذا هو "العنوان" أو الطريق اللي يوصلنا لهذا الكنترولر بالمتصفح
    [ApiController] // نكول للـ ASP.NET ترى هذا الكلاس هو API مو صفحة ويب عادية
    public class DebtsController : ControllerBase
    {
        // سوينا نسخة (Object) من كلاس الديون حتى نكدر نستخدم دواله
        clsDebts debt = new clsDebts();

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
    }
}