using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

// هنا جاي نكول للحاسبة: "يا الله، بلشي جهزي أغراض المشروع" (مثل ما تفتح باب المطبعة الصبح)
var builder = WebApplication.CreateBuilder(args);

// --- [تعديل التحقق]: نجهز السيرفر حتى يعرف يقرأ الهوية (التوكن) اللي دزيناه من الـ AuthController ---
var jwtSettings = builder.Configuration.GetSection("Jwt");
var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

// جاي نكول للنظام: "سجل عندك تره راح نستخدم نظام الـ Controllers" (مثل ما تحدد منو الموظف المسؤول عن الاستلام)
builder.Services.AddControllers();

// هاي القطعتين علمود "Swagger" اللي هو الدفتر اللي يسجل كل الروابط (API) مالتنا
builder.Services.AddEndpointsApiExplorer();

// --- [تعديل Swagger]: ضفنا كود حتى يظهر زر "القفل" ونكدر ندخل التوكن من داخل المتصفح ---
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "ادخل التوكن  هنا"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new string[] {}
        }
    });
});

// هنا جاي نسوي "قائمة سماح" (CORS) - منو مسموح له يتصل بالمطبعة مالتنا؟
builder.Services.AddCors(options =>
{
    options.AddPolicy("EtezanPrinting_WebAPIApiCorsPolicy", policy =>
    {
        policy
            .WithOrigins(
                "https://localhost:7032",
                "http://localhost:5023"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// هنا خلصنا "تجهيز" الأغراض، وهسه راح نكول للحاسبة: "ابني المشروع وشغليه!"
var app = builder.Build();

// إذا كنا بعدنا بمرحلة "التصليح والتطوير" (مو نشر حقيقي)، طلع لنا دفتر الـ Swagger حتى نفحص
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// أي واحد يجينا بـ http عادي، نحوله على الـ https الأمين
app.UseHttpsRedirection();

// تفعيل قائمة السماح اللي سويناها فوك (الـ CORS)
app.UseCors("EtezanPrinting_WebAPIApiCorsPolicy");

// --- [تعديل مهم]: تفعيل "سيطرة التفتيش" قبل "الصلاحيات" ---
app.UseAuthentication(); // السيطرة: "طلع هويتك (التوكن) حتى اعرفك"

// تفعيل نظام "الصلاحيات" (يعني مو أي واحد يطب يعدل بكيفه، لازم عنده إذن)
app.UseAuthorization(); // الصلاحية: "بعد ما عرفتك، مسموح لك تدخل لو لا؟"

// ربط المسارات بالـ Controllers (مثل ما توزع الشغل: "أنت يا وصل روح لقسم الطباعة")
app.MapControllers();

// شغل المحرك وخلي المشروع يستلم طلبات!
app.Run();