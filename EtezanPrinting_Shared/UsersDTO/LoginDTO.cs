using System;
using System.Collections.Generic;
using System.Text;

namespace EtezanPrinting_Shared.UsersDTO
{
    // هذي هي "الوجبة الجاهزة" اللي تمثل بيانات الدخول
    public class LoginDTO
    {
        // اسم المستخدم اللي راح يكتبه بالـ Login
        public string UserName { get; set; }

        // الرمز السري اللي راح يكتبه (وهذا راح يتشيك ويه المشفر بالداتابيز)
        public string Password { get; set; }
    }
}