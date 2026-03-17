using System; // جيبلي الأساسيات مالت اللغة، لا ندوخ بيها.
using System.Collections.Generic; // هاي علمود القوائم واللستات إذا ردنا نسوي "كيمية" بيانات.
using System.Text; // هاي للسوالف مالت النصوص والترتيب مالتها.

namespace EtezanPrinting_Shared.AuthDTO // هذا "العنوان" أو البيت مالتنا اللي حاطين بي الشغل.
{
    public class TokenResponse // هذا "القالب" اللي راح نستخدمه لما نرجع جواب التوكن.
    {
        public string AccessToken { get; set; } // هذا "المفتاح" الرئيسي اللي يخليك تفوت وتشتغل.

        public string RefreshToken { get; set; } // وهذا "الاحتياط"، إذا خلص وكت المفتاح الأول، هذا يجدده إلك.
    }
}