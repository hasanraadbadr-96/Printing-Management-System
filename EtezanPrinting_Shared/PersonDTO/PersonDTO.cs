using System;
using System.Collections.Generic;
using System.Text;

namespace EtezanPrinting_Shared.PersonDTO
{
    public  class PersonDTO
    {
      
            // هذن الخصائص مال الكلاس.. يعني المعلومات اللي راح نشيلها ونفتر بيها
            public int personID { get; set; } // رقم الرجال (المفتاح اللي ما يتكرر)
            public int order_count { get; set; } // شكم طلبية مسوي هذا الشخص؟
            public string full_name { get; set; } // اسمه الثلاثي واللقب
            public int city_id { get; set; } // بيا مدينة كاعد؟ (رقم المدينة)
            public string phone_number { get; set; } // رقم موبايله حتى ندق عليه
            public string notes { get; set; } // إذا عندنا ملاحظة "غثة" عليه نكتبها هنا
            public int persons_status_id { get; set; } // هذا الشخص بعده ويانا لو طردناه؟ (فعال/غير فعال)
            public string address { get; set; } // وين ساكن بالضبط؟
            public string gendor { get; set; } // ولد لو بنية؟
            public string ImagePath { get; set; } // درب الصورة وين مخزونة بالحاسبة


        // 1. أضف هذا المنشئ الفارغ ضروري جداً للـ API
        public PersonDTO() { }


        // هذا "الكونستركتر".. يعني السيارة اللي تحمل البضاعة وتوزعها للخصائص الفوق
        public PersonDTO(int personID, string full_name, string phone_number,
              string address, int order_count, string notes,
              int persons_status_id, string gendor, int city_id, string imagePath)
            {
                this.personID = personID; // استلم الرقم وخليه بمكانه
                this.order_count = order_count; // اخذ عدد الطلبيات وصفطهن
                this.full_name = full_name; // الاسم يجي هنا
                this.city_id = city_id; // رقم المدينة يتحول هنا
                this.phone_number = phone_number; // الموبايل همين
                this.notes = notes; // الملاحظات لا تنساها
                this.persons_status_id = persons_status_id; // الحالة مالته
                this.address = address; // العنوان يثبت هنا
                this.gendor = gendor; // الجنس يتخزن
                this.ImagePath = imagePath; // ومسار الصورة أخر شي
            }
        



    }
}
