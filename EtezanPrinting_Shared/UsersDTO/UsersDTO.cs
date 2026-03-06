


using System;
using System.Collections.Generic;

using System.Text;



namespace EtezanPrinting_Shared.UsersDTO

{
    public class UsersDTO
    {
        // 1. المتغيرات (Properties)
        public int UserID { get; set; } // الآيدي التلقائي من القاعدة
        public string UserName { get; set; } // اسم المستخدم للـ Login
        public string Password { get; set; } // الرمز السري (يفضل يكون مشفر مستقبلاً)
        public int PersonID { get; set; } // الربط ويه جدول الأشخاص (FK)
        public int UsersPermissionID { get; set; } // الصلاحيات (Admin, User, etc)
        public bool IsActive { get; set; } // هل الحساب شغال لو معطل

        // 2. الكونستركتر الافتراضي (Default Constructor)
        // نحتاجه للـ Serializer بالـ API حتى يكدر يقرأ البيانات
        public UsersDTO() { }

        // 3. كونستركتر التمرير (Parameterized Constructor)
        // نستخدمه بالـ Business Layer حتى نترس البيانات بسرعة
        public UsersDTO(int userID, string userName, string password, int personID, int permissionID, bool isActive)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.Password = password;
            this.PersonID = personID;
            this.UsersPermissionID = permissionID;
            this.IsActive = isActive;
        }
    }
}