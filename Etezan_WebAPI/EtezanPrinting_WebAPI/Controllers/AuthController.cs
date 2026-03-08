using BusinessLayeres; // جلب طبقة الشغل مالتنا
using EtezanPrinting_Shared.UsersDTO; // جلب الوجبات الجاهزة (DTOs)
using Microsoft.AspNetCore.Mvc; // جلب أدوات الـ API
using Microsoft.IdentityModel.Tokens; // أدوات الحماية والتوكن
using System.IdentityModel.Tokens.Jwt; // صانع التوكنات الـ JWT
using System.Security.Claims; // جلب نظام "الهويات" بداخل التوكن
using System.Text; // مجهز نصوص

namespace EtezanPrinting_WebAPI.Controllers
{
    [Route("api/Authentication")] // العنوان اللي يوصلنا لباب الاستعلامات
    [ApiController] // نكول للحاسبة تره هذا كونترولر مال API مو مال واجهات
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration; // مخزن الإعدادات (البيه المفتاح السري)

        // نسحب الإعدادات ونخليها بالكونترولر أول ما يشتغل
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")] // دالة الدخول، تستلم المعلومات من نوع POST
        public IActionResult Login([FromBody] LoginDTO request)
        {
            // إذا الزبون دز ورقة فارغة، نكول له "عيني املي معلوماتك أول"
            if (request == null || string.IsNullOrEmpty(request.UserName))
                return BadRequest("بيانات الدخول غير مكتملة");

            // 1. "دوري بالسجلات": نروح نشوف اكو مستخدم بهذا الاسم بالداتابيز؟
            var user = clsUsers.FindUserByUserName(request.UserName);

            // إذا ما لكينا الاسم، نكول له "يا اسمك غلط يا رمزك غلط" (للأمان ما نكول منو الغلط بيهم)
            if (user == null)
                return Unauthorized("اسم المستخدم أو كلمة المرور غير صحيحة");

            // 2. "فحص الرمز": نستخدم BCrypt حتى نشيك الرمز اللي دزه ويه الرمز المشفر العدنا
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);

            // إذا الرمز طلع "فيك" ومو نفسه، نطرده بكلمة Unauthorized
            if (!isValidPassword)
                return Unauthorized("اسم المستخدم أو كلمة المرور غير صحيحة");

            // 3. "جيب الختم": نسحب المفتاح السري من ملف appsettings.json
            var keyString = _configuration["Jwt:Key"];
            if (string.IsNullOrEmpty(keyString))
                return StatusCode(500, "JWT Key is missing in settings");

            // 4. "اصعد للسطح": معلوماته صحيحة، هسه نسوي له "باج" (توكن) يطب بيه للسيستم
            var token = GenerateJwtToken(user, keyString);

            // نرجع له التوكن ونكول له "عاشت إيدك، اتفضل فوت"
            return Ok(new { token = token });
        }

        // دالة خاصة تسوي لنا "الباج" (التوكن) - صالحة لـ 30 دقيقة
        private string GenerateJwtToken(clsUsers user, string keyString)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // هذا هو "الموظف" اللي يطبع التوكن

            // نحول المفتاح السري من نص إلى بايتات حتى الحاسبة تفتهمه
            var key = Encoding.ASCII.GetBytes(keyString);

            // وصف التوكن: شنو راح نكتب بداخل الباج؟
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // الـ Claims: يعني معلومات الموظف اللي راح نكبسها بداخل التوكن
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()), // رقمه الفريد
                    new Claim(ClaimTypes.Name, user.UserName), // اسمه
                    new Claim("PermissionID", user.PermissionID.ToString()) // صلاحيته بالمطبعة
                }),

                // وكت انتهاء الباج: ورا 30 دقيقة يذبه بالزبل وما يشتغل بعد
                Expires = DateTime.UtcNow.AddMinutes(30),

                // الختم والتشفير: نوقع التوكن بالمفتاح السري وبخوارزمية قوية (HmacSha256)
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                ),

                // منو انطى الباج (المطبعة) ومنو مسموح له يشوفه
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"]
            };

            // اصنع الباج الفعلي بناءً على الوصف الفوك
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // حول الباج من "كائن برمجبي" إلى "نص طويل" حتى نكدر نرسله بالنت
            return tokenHandler.WriteToken(token);
        }
    }
}