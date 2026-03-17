using System; // هاي المكتبة الأم، ضرورية بكل "ماعون" كود نسوي.
using System.Collections.Generic; // خاف نحتاج نسوي لستة بأسماء الحسابات الطالعة.
using System.Text; // مالت ترتيب الحروف والكلمات، خاف اكو تشفير أو شي.

namespace EtezanPrinting_Shared.AuthDTO // هذا العنوان البريدي اللي يعرف السيرفر وين يلكه هذا الكود.
{
    public class LogoutRequest // هذا "كتاب التسريح"، يعني لما المستخدم يقرر يطلع ويسد الباب وراه.
    {
        // هنا نكول للسيرفر "يا مستخدم" اللي يريد يطلع، حتى يعرف منو هو.
        public string UserName { get; set; }

        // وهاي نرفق وياها "وصل الأمان" (التوكن) حتى السيرفر يحرقه وما يخلي أحد يستخدمه وراه.
        public string RefreshToken { get; set; }
    }
}