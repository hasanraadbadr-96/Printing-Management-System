using System; // هاي المكتبة الأساسية، يعني "الخبزة" مالت السي شارب.
using System.Collections.Generic; // علمود المجموعات، خاف نحتاج نجمع كومة بيانات بمكان واحد.
using System.Text; // هاي مالت "الجرجرة" والنصوص، إذا ردنا نعدل عالحجي.

namespace EtezanPrinting_Shared.AuthDTO // هذا اسم "المنطقة" أو الفولدر اللي ضامين بي أغراضنا.
{
    public class RefreshRequest // هذا "الماعون" اللي راح ندز بي طلب تحديث التوكن.
    {
        // هذا هو "التوكن القديم" اللي انتهى مفعوله ونريد نبدله بواحد جديد.
        public string RefreshToken { get; set; }

        // وهذا "اسم المستخدم"، حتى السيرفر يتأكد منو كاعد يدق الباب.
        public string UserName { get; set; }
    }
}