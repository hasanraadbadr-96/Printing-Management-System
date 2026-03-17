using System;
using System.Collections.Generic;
using System.Text;

namespace EtezanPrinting_Shared.LoginLogDTO
{
    public class LoginLogDTO
    {
        // 1. الخصائص (Properties): الأعمدة اللي نريد ننقلها بالنت
        public int? UserID { get; set; }           // رقم المستخدم (ممكن يكون null إذا الدخول فشل)
        public string UserName { get; set; }       // الاسم اللي حاول يدخل بيه
        public string ActionType { get; set; }     // (Login, Logout, Refresh)
        public string Status { get; set; }         // (Success, Failed)
        public string IPAddress { get; set; }      // عنوان جهاز الموظف
        public DateTime LogDate { get; set; }      // وكت العملية


        // 2. الكونستركتر الافتراضي (Default Constructor)
        // ضروري جداً حتى الـ Serializer يكدر يحول الـ JSON لكائن برمجبي
        public LoginLogDTO()
        {
            this.LogDate = DateTime.Now; // نعطيه تاريخ اليوم كقيمة افتراضية
        }


        // 3. كونستركتر التمرير (Parameterized Constructor)
        // هذا يفيدك بالبزنس لير حتى تملي البيانات بـ "سطر واحد" بدل ما تملي عمود عمود
        public LoginLogDTO(int? userID, string userName, string actionType, string status, string ipAddress)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.ActionType = actionType;
            this.Status = status;
            this.IPAddress = ipAddress;
            this.LogDate = DateTime.Now;
        }
    }
}
