using System;
using System.Collections.Generic;
using System.Text;

namespace EtezanPrinting_Shared.Depts

{
    public class DebtDTO
    {
        // --- المتغيرات (Properties) ---

        public int DebtID { get; set; }           // المعرف مال الدين، هذا الأساس
        public string DebtorName { get; set; }    // اسم الرجال المطلوب (المدين)
        public string PhoneNumber { get; set; }   // رقم تليفونه حتى ندك عليه ونطالب بالفلوس
        public decimal DebtAmount { get; set; }   // شكد نطلبه؟ (استخدمت decimal للدقة المالية)
        public string Address { get; set; }       // وين كاعد؟ عنوانه بالتفصيل
        public DateTime DebtDate { get; set; }    // شوكت صار هذا الدين؟ التاريخ والوقت
        public int? OrdersID { get; set; }        // رقم الطلبية المرتبطة بهذا الدين (إذا موجودة)
        public int? UsersID { get; set; }         // يا مستخدم (موظف) هو السجل هذا الدين
        public int? PersonsID { get; set; }       // رابط إضافي لمعرف الشخص بقاعدة البيانات
        public bool IsActive { get; set; }        // هذا الدين بعده شغال لو انغلق (صاير False)؟

        // --- المشيد (Constructor) الفارغ ---
        // هذا تحتاجه إذا ردت تسوي كائن وتترسه بيانات بعدين براحتك
        public DebtDTO() { }

        // --- المشيد (Constructor) الكامل ---
        // هذا ياخذهن كلهن "شلع قلع" وما يعكّب ولا واحد
        public DebtDTO(
            int debtID,
            string debtorName,
            string phoneNumber,
            decimal debtAmount,
            string address,
            DateTime debtDate,
            int? ordersID,
            int? usersID,
            int? personsID,
            bool isActive)
        {
            this.DebtID = debtID;           // ثبتنا آيدي الدين
            this.DebtorName = debtorName;   // ثبتنا اسم المدين
            this.PhoneNumber = phoneNumber; // ثبتنا رقم التليفون
            this.DebtAmount = debtAmount;   // ثبتنا المبلغ المطلوبه
            this.Address = address;         // ثبتنا العنوان
            this.DebtDate = debtDate;       // ثبتنا تاريخ الدين
            this.OrdersID = ordersID;       // ثبتنا آيدي الطلبية
            this.UsersID = usersID;         // ثبتنا آيدي المستخدم
            this.PersonsID = personsID;     // ثبتنا آيدي الشخص
            this.IsActive = isActive;       // ثبتنا حالة القيد (شغال لو لا)
        }
    }
}