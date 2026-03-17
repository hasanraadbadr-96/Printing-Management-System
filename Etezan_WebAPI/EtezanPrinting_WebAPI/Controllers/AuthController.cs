using BusinessLayeres; // جلب طبقة الشغل مالتنا
using EtezanPrinting_Shared.AuthDTO; // جلب الوجبات الجديدة (TokenResponse)
using EtezanPrinting_Shared.UsersDTO; // جلب الوجبات الجاهزة (DTOs)
using Microsoft.AspNetCore.Mvc; // جلب أدوات الـ API
using Microsoft.IdentityModel.Tokens; // أدوات الحماية والتوكن
using System.IdentityModel.Tokens.Jwt; // صانع التوكنات الـ JWT
using System.Security.Claims; // جلب نظام "الهويات" بداخل التوكن
using System.Security.Cryptography; // مكتبة التشفير لتوليد باج التجديد
using System.Text; // مجهز نصوص
using Microsoft.AspNetCore.Authorization;
// --- [إضافة محمد أبو هدهود]: مكتبة درع الحماية ---
using Microsoft.AspNetCore.RateLimiting;

namespace EtezanPrinting_WebAPI.Controllers
{
    [Route("api/Authentication")] // العنوان اللي يوصلنا لباب الاستعلامات
    [ApiController] // نكول للحاسبة تره هذا كونترولر مال API مو مال واجهات
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration; // مخزن الإعدادات (البيه المفتاح السري)

        private readonly ILogger<AuthController> _logger;

        public AuthController(IConfiguration configuration, ILogger<AuthController> logger)
        {
            _configuration = configuration;
            _logger = logger; // هذا هو المحرك اللي يطلع الكتابة الملونة بالكونسل
        }









        [HttpPost("login")] // دالة الدخول، تستلم المعلومات من نوع POST
                            // --- [إضافة محمد أبو هدهود]: تفعيل درع الحماية على الدخول ---
        [EnableRateLimiting("AuthLimiter")]
        public IActionResult Login([FromBody] LoginDTO request)
        {
            // جلب الـ IP الحقيقي للجهاز اللي جاي يحاول يدخل
            string ip = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";

            // إذا الزبون دز ورقة فارغة، نكول له "عيني املي معلوماتك أول"
            if (request == null || string.IsNullOrEmpty(request.UserName))
                return BadRequest("بيانات الدخول غير مكتملة");

            // 1. "دوري بالسجلات": نروح نشوف اكو مستخدم بهذا الاسم بالداتابيز؟
            var user = clsUsers.FindUserByUserName(request.UserName);

            // إذا ما لكينا الاسم، نكول له "يا اسمك غلط يا رمزك غلط" (للأمان ما نكول منو الغلط بيهم)
            if (user == null)
            {
                // --- [إضافة محمد أبو هدهود لظهور التنبيه بالكونسل] ---
                _logger.LogWarning("Failed login attempt (user not found). UserName={User}, IP={IP}", request.UserName, ip);

                // [سجل لوك]: محاولة دخول باسم مستخدم غير موجود
                _RegisterLoginLog(null, request.UserName, "Login", "Failed", ip, "User not found");
                return Unauthorized("اسم المستخدم أو كلمة المرور غير صحيحة");
            }

            // 2. "فحص الرمز": نستخدم BCrypt حتى نشيك الرمز اللي دزه ويه الرمز المشفر العدنا
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);

            // إذا الرمز طلع "فيك" ومو نفسه، نطرده بكلمة Unauthorized
            if (!isValidPassword)
            {
                // --- [إضافة محمد أبو هدهود لظهور التنبيه بالكونسل] ---
                _logger.LogWarning("Failed login attempt (bad password). UserName={User}, IP={IP}", request.UserName, ip);

                // [سجل لوك]: محاولة دخول بكلمة سر خاطئة
                _RegisterLoginLog(user.UserID, user.UserName, "Login", "Failed", ip, "Wrong password");
                return Unauthorized("اسم المستخدم أو كلمة المرور غير صحيحة");
            }

            // 3. "جيب الختم": نسحب المفتاح السري من ملف appsettings.json
            var keyString = _configuration["Jwt:Key"];
            if (string.IsNullOrEmpty(keyString))
                return StatusCode(500, "JWT Key is missing in settings");

            // 4. "اصعد للسطح": معلوماته صحيحة، هسه نسوي له "باج" (توكن) يطب بيه للسيستم
            var accessToken = GenerateJwtToken(user, keyString);

            // --- [إضافة محمد أبو هدهود]: توليد باج التجديد (Refresh Token) ---
            var refreshToken = GenerateRefreshToken();

            // خزن هاش الباج بالداتابيز (لازم تضيف الحقول بالبزنس لير والداتابيز)
            user.RefreshTokenHash = BCrypt.Net.BCrypt.HashPassword(refreshToken);
            user.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(7);
            user.Save();

            // --- [إضافة محمد أبو هدهود لتسجيل النجاح بالكونسل] ---
            _logger.LogInformation("Successful login. UserName={User}, IP={IP}", user.UserName, ip);

            // [سجل لوك]: نجاح عملية الدخول
            _RegisterLoginLog(user.UserID, user.UserName, "Login", "Success", ip, "Login via Web API");

            // نرجع الاثنين سوه بالماعون الجديد (TokenResponse)
            return Ok(new TokenResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            });
        }

        // دالة مساعدة خاصة بداخل الكنترولر لحفظ اللوكات
        private void _RegisterLoginLog(int? userId, string username, string action, string status, string ip, string reason)
        {
            try
            {
                clsLoginLogs log = new clsLoginLogs();
                log.usersId = userId;
                log.username = username;
                log.ActionType = action;
                log.Status = status;
                log.IPAddress = ip;
                log.FailureReason = reason;
                log.loginDate = DateTime.Now;
                log.Save();
            }
            catch { /* فشل تسجيل اللوك لا يجب أن يوقف عملية الدخول */ }
        }

        // --- [دالة توليد باج التجديد الآمنة] ---
        private static string GenerateRefreshToken()
        {
            var bytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        [HttpPost("refresh")]
        // --- [إضافة محمد أبو هدهود]: تفعيل درع الحماية على التجديد ---
        [EnableRateLimiting("AuthLimiter")]
        public IActionResult Refresh([FromBody] RefreshRequest request)
        {
            var user = clsUsers.FindUserByUserName(request.UserName);

            // إذا اليوزر ماكو، أو الباج محروق أصلاً، اطرده
            if (user == null || user.RefreshTokenRevokedAt != null)
                return Unauthorized("طلب غير صالح");

            // --- [الفحص الحاسم]: هل باج الاحتياط المرسل يطابق المشفر بالداتابيز؟ ---
            bool isTokenValid = BCrypt.Net.BCrypt.Verify(request.RefreshToken, user.RefreshTokenHash);

            if (!isTokenValid || user.RefreshTokenExpiresAt < DateTime.UtcNow)
                return Unauthorized("باج التجديد غير صالح أو منتهي");
            // -----------------------------------------------------------------------

            // إذا عبر كل الفحوصات، نصدر باج جديد
            var keyString = _configuration["Jwt:Key"];
            var newAccessToken = GenerateJwtToken(user, keyString);
            var newRefreshToken = GenerateRefreshToken();

            // تدوير الباج (Rotation): نحرق القديم ونخزن الجديد
            user.RefreshTokenHash = BCrypt.Net.BCrypt.HashPassword(newRefreshToken);
            user.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(7);
            user.Save();

            return Ok(new TokenResponse { AccessToken = newAccessToken, RefreshToken = newRefreshToken });
        }

        [HttpPost("logout")]
        [Authorize] // لازم يكون لابس باج حتى يكدر يسجل خروج
        public IActionResult Logout([FromBody] LogoutRequest request)
        {
            // 1. نسحب الـ ID الحقيقي من داخل التوكن (اللي مشفر ومحد يكدر يزوره)
            var currentUserIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (currentUserIdClaim == null) return Unauthorized();

            int currentUserId = int.Parse(currentUserIdClaim.Value);

            // 2. نبحث عن اليوزر اللي بالداتابيز بالاسم اللي دزه بالطلب
            var user = clsUsers.FindUserByUserName(request.UserName);

            // 3. الفحص الجوهري: هل اليوزر اللي بالداتابيز هو نفسه صاحب التوكن؟
            if (user == null || user.UserID != currentUserId)
            {
                // نرجع "تم" للتمويه بس ما نسوي شي بالداتابيز
                return Ok("تم تسجيل الخروج");
            }

            // 4. إذا طلع هو فعلاً، نحرق الباج بالداتابيز رسمياً
            user.RefreshTokenRevokedAt = DateTime.UtcNow;
            user.Save();

            return Ok("تم تسجيل الخروج بنجاح");
        }
        // دالة خاصة تسوي لنا "الباج" (التوكن) - صالحة لـ 30 دقيقة
        private string GenerateJwtToken(clsUsers user, string keyString)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // هذا هو "الموظف" اللي يطبع التوكن

            // نحول المفتاح السري من نص إلى بايتات حتى الحاسبة تفتهمه
            var key = Encoding.ASCII.GetBytes(keyString);

            // --- [المكان الصحيح للقطعة اللي طلبتها] ---
            // تأكد من هذه الحسبة بدقة
            string userRole = "User"; // الكل يوزرات بالبداية

            if (user.PermissionID == 3) // هل أنت متأكد أن 3 هو السوبر أدمن فقط؟
            {
                userRole = "SuperAdmin";
            }
            else if (user.PermissionID == 1)
            {
                userRole = "Admin";
            }
            // إذا كان PermissionID لليوزر العادي هو 3، فسيراه السيستم SuperAdmin!
            // ------------------------------------------

            // وصف التوكن: شنو راح نكتب بداخل الباج؟
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                // الـ Claims: يعني معلومات الموظف اللي راح نكبسها بداخل التوكن
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()), // رقمه الفريد
                    new Claim(ClaimTypes.Name, user.UserName), // اسمه
                    new Claim(ClaimTypes.Role, userRole), // الرتبة اللي حددناها فوك
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