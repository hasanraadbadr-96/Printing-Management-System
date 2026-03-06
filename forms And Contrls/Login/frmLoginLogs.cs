using BusinessLayeres; // نستدعي طبقة البيزنس حتى نقدر نتعامل ويا الكلاسات اللي تتعامل ويه قاعدة البيانات
using System; // مكتبة الاساسيات مالت سي شارب (مثل التاريخ والأرقام)
using System.Collections.Generic; // حتى نستخدم القوائم (List<T>) والمجموعات
using System.ComponentModel; // لدعم الفاليديشن والخصائص بالواجهة
using System.Data; // للتعامل ويه الجداول DataTable و DataSet
using System.Drawing; // للألوان والتصاميم بالواجهة
using System.Linq; // للتعامل ويا البيانات بشكل سلس بواسطة LINQ
using System.Text; // لمعالجة النصوص والسلاسل النصية
using System.Threading.Tasks; // لدعم العمليات الغير متزامنة (Async/Await)
using System.Windows.Forms; // مكتبة الفورمز، نحتاجها للأزرار والنصوص وكل أدوات الواجهة

namespace ETEZAN2024.forms_And_Contrls.Login // هذي مساحة الاسم مال الفورم، تنظم المشروع
{
    public partial class frmLoginLogs : Form // تعريف الفورم مال تسجيل الدخول Logs
    {
        clsLoginLogs _loginLog; // هذا المتغير راح يخزن بيانات كل تسجيل دخول

        public frmLoginLogs() // الكونستركتر مال الفورم
        {
            InitializeComponent(); // تهيئة كل عناصر الفورم (الازرار، الجدول، إلخ)
        }

        private void _RefereshLoginLogList() // دالة تحدث بيانات جدول السجلات
        {
            dgvAllLoginLogs.DataSource = clsLoginLogs.GetAllLoginLogsList(); // نجيب كل السجلات ونحطها بالجدول
            lbLoginLogsCount.Text = dgvAllLoginLogs.RowCount.ToString(); // نعرض عدد السجلات
            dgvAllLoginLogs.Columns[1].Width = 110; // نحدد عرض العمود الثاني
            dgvAllLoginLogs.Columns[2].Width = 110; // نحدد عرض العمود الثالث
            dgvAllLoginLogs.Columns[3].Width = 140; // نحدد عرض العمود الرابع
        }

        public class clsLoggger // كلاس داخلي يستخدم Delegate لتسجيل الدخول
        {
            public delegate void Actoin(clsLoginLogs loginLog); // تعريف ديليغيت (نوع ميثود تاخذ clsLoginLogs)
            Actoin _actoin; // نخزن الميثود اللي رح تمرر للديليغيت

            public clsLoggger(Actoin actoin) // الكونستركتر ياخذ الميثود ويربطه مع الديليغيت
            {
                _actoin = actoin; // نخزن الميثود داخل الكلاس
            }

            public void Log(clsLoginLogs loginLog) // دالة تنفذ الميثود اللي مررناها
            {
                _actoin(loginLog); // نستدعي الميثود فعلياً ونمرر البيانات
            }
        }

        private void frmLoginLogs_Load(object sender, EventArgs e) // حدث التحميل مال الفورم
        {
            _RefereshLoginLogList(); // نحدث الجدول بالسجلات لما الفورم يفتح
        }
    }
}
