// هنا جاي نكول للحاسبة: "يا الله، بلشي جهزي أغراض المشروع" (مثل ما تفتح باب المطبعة الصبح)
var builder = WebApplication.CreateBuilder(args);

// جاي نكول للنظام: "سجل عندك تره راح نستخدم نظام الـ Controllers" (مثل ما تحدد منو الموظف المسؤول عن الاستلام)
builder.Services.AddControllers();

// هاي القطعتين علمود "Swagger" اللي هو الدفتر اللي يسجل كل الروابط (API) مالتنا حتى نجربها بسهولة
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// هنا جاي نسوي "قائمة سماح" (CORS) - منو مسموح له يتصل بالمطبعة مالتنا؟
builder.Services.AddCors(options =>
{
    // سمينا السياسة باسم مطبعتنا حتى نعرفها
    options.AddPolicy("EtezanPrinting_WebAPIApiCorsPolicy", policy =>
    {
        policy
            .WithOrigins(
                "https://localhost:7032", // مسموح بس لهذا الرابط يحجي ويانا
                "http://localhost:5023"   // وهذا هم مسموح له
            )
            .AllowAnyHeader() // مسموح يدز أي نوع من المعلومات (مثل رقم الوصل، اسم الزبون)
            .AllowAnyMethod(); // مسموح يسوي أي عملية (حذف، إضافة، تعديل)
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

// أي واحد يجينا بـ http عادي، نحوله على الـ https الأمين (مثل ما تكول للزبون "تعال من الباب الرئيسي أأمن لك")
app.UseHttpsRedirection();

// تفعيل قائمة السماح اللي سويناها فوك (الـ CORS)
app.UseCors("EtezanPrinting_WebAPIApiCorsPolicy");

// تفعيل نظام "الصلاحيات" (يعني مو أي واحد يطب يعدل بكيفه، لازم عنده إذن)
app.UseAuthorization();

// ربط المسارات بالـ Controllers (مثل ما توزع الشغل: "أنت يا وصل روح لقسم الطباعة")
app.MapControllers();

// شغل المحرك وخلي المشروع يستلم طلبات!
app.Run();