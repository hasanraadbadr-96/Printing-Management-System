using BusinessLayeres; // نستدعي طبقة الـ BusinessLayeres الي تحتوي الكلاسات الخاصة بالمستخدمين
using System; // مكتبة الاساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة للـ Events وعمليات التحقق
using System.Data; // مكتبة التعامل مع البيانات
using System.Drawing; // مكتبة الرسومات
using System.Linq; // مكتبة LINQ للاستعلامات
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة الـ Tasks
using System.Windows.Forms; // مكتبة واجهات Windows Forms

namespace ETEZAN2024.forms_And_Contrls.Users.control // مساحة الاسماء الخاصة بالكنترول الخاص بالمستخدمين
{
    public partial class ctrlUserCard : UserControl // كلاس يمثل UserControl لعرض بيانات المستخدم
    {
        private int _UserID; // متغير خاص يخزن رقم المستخدم
        private clsUsers _clsUsers; // كائن من كلاس clsUsers حتى نخزن بيه معلومات المستخدم

        public int UserID // خاصية (Property) ترجع رقم المستخدم
        {
            get { return _UserID; } // نرجع رقم المستخدم المخزون
        }

        public ctrlUserCard() // الكونستركتر للفورم
        {
            InitializeComponent(); // تهيئة مكونات الواجهة
        }

        private void _ResetDefualtValues() // دالة تعيين القيم الافتراضية
        {
            lbUserID.Text = "####"; // نخلي ID بشكل افتراضي
            lbUserName.Text = "####"; // نخلي اسم المستخدم فارغ
            lbIsAtive.Text = "####"; // نخلي حالة التفعيل فارغة
        }

        private void _FillUserInfo() // دالة تملئ بيانات المستخدم داخل اللابلز
        {
            lbUserID.Text = _clsUsers.UserID.ToString(); // نعرض رقم المستخدم
            lbUserName.Text = _clsUsers.UserName; // نعرض اسم المستخدم
            if (_clsUsers.isActive) // اذا المستخدم فعال
            {
                lbIsAtive.Text = "نعم"; // نعرض نعم
            }
            else // اذا غير فعال
            {
                lbIsAtive.Text = "لا"; // نعرض لا
            }
            ctrlPersonCard1.LoadPersonInfoByID(_clsUsers.PersonID); // نعرض بيانات الشخص المرتبط بالمستخدم
        }

        public void LoadUserInfo(int userID) // دالة عامة لتحميل بيانات مستخدم حسب ID
        {
            _clsUsers = clsUsers.FindUserById(userID); // نبحث عن المستخدم حسب ID
            if (_clsUsers == null) // اذا ما موجود
            {
                _ResetDefualtValues(); // نرجع القيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا المستخدم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                return; // نوقف العملية
            }
            _UserID = userID; // نخزن رقم المستخدم
            _FillUserInfo(); // نملئ بيانات المستخدم
        }

        private void ctrlUserCard_Load(object sender, EventArgs e) // حدث تحميل الكنترول
        {
            // حاليا فارغ، ممكن نستخدمه للتهيئة اذا نحتاج
        }

        private void groupBox2_Enter(object sender, EventArgs e) // حدث دخول على GroupBox
        {
            // ما مستخدم حاليا
        }

        private void lbUserName_Click(object sender, EventArgs e) // حدث ضغط على Label الخاص بالاسم
        {
            // فارغ، ممكن نضيف اكشن مستقبلا
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
