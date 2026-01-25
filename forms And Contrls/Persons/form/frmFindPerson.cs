using System;  // نستدعي مكتبة الأساسيات (تحتوي على الكلاسات الأساسية مثل DateTime و Math وغيرها).
using System.Collections.Generic; // نستدعي مكتبة القوائم والقواميس (List, Dictionary).
using System.ComponentModel; // نستدعي مكتبة توفر خصائص للأدوات (Component).
using System.Data; // مكتبة للتعامل مع الجداول والـ DataSet.
using System.Drawing; // مكتبة للتحكم بالرسوميات مثل الألوان والخطوط.
using System.Linq; // مكتبة LINQ للبحث والتصفية والتعامل مع البيانات.
using System.Text; // مكتبة التعامل مع النصوص والـ Encoding.
using System.Threading.Tasks; // مكتبة العمليات غير المتزامنة (Asynchronous).
using System.Windows.Forms; // مكتبة تصميم الواجهات (Windows Forms).

namespace ETEZAN2024.forms_And_Contrls.Persons.form // نعرّف الـ Namespace اللي يجمع الفورم داخل المشروع.
{
    public partial class frmFindPerson : Form // نعرّف كلاس الفورم "frmFindPerson" وهو يرث من الكلاس الأساسي Form.
    {
        public delegate void DataBackHalnder(object sender, int personID);
        // هنا مسوي Delegate (ممثل) حتى نرجّع قيمة (personID) من هذا الفورم للفورم الثاني.

        public event DataBackHalnder onDataBackHalnder;
        // هذا حدث (Event) يعتمد على الـ Delegate أعلاه حتى نستدعيه عند الحاجة.

        public frmFindPerson() // دالة البناء (Constructor) للفورم.
        {
            InitializeComponent();
            // تستدعي الدالة الخاصة بتهيئة مكونات الفورم (تُنشأ أوتوماتيكياً من المصمم).
        }

        private void frmPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            // هذا الحدث يشتغل من يتحمل الفورم أول مرة، حالياً فارغ.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            onDataBackHalnder?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
            // من ينضغط زر "إغلاق" يستدعي الحدث onDataBackHalnder ويرجع الـ PersonID للفورم الثاني.

            this.Close();
            // يغلق الفورم الحالي بعد ما يرجع القيمة.
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
