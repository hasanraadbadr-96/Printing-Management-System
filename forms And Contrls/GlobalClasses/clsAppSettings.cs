using System; // 🛠️ نستخدم المكتبات الأساسية للـ C#
using System.Collections.Generic; // 📚 لو نحتاج نستخدم القوائم (List)
using System.Linq; // 🔍 لو نحتاج نستخدم استعلامات LINQ
using System.Text; // ✏️ للتعامل مع النصوص والترميزات
using System.Threading.Tasks; // ⏳ لو نحتاج نستخدم البرمجة المتزامنة (Tasks)
using System.Runtime.Serialization.Json; // 📦 للتعامل مع JSON ونسوي سيرياليز للملفات

namespace ETEZAN2024.forms_And_Contrls.GlobalClasses // 📂 ننظم الكود بمكان خاص بالـ Global Classes
{
    [Serializable] // 💾 نحدد انه هذا الكلاس يقدر يتحفظ ويقرأ (سيرياليز)
    public class clsAppSettings // 🏗️ هذا كلاس لتخزين إعدادات البرنامج
    {
        public int ModeIndex { get; set; } // 🔄 يخزن رقم الوضع الحالي (مثلاً 0, 1, 2...)
    }
}
