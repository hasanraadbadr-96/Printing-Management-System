using BusinessLayeres; // نستدعي طبقة الأعمال (BLL) حتى نشتغل على بيانات الديون
using ETEZAN2024.forms_And_Contrls.Debts; // نستدعي النيمسبيس اللي يحتوي على فورم تفاصيل الديون
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة خصائص الواجهة
using System.Data; // مكتبة التعامل مع الجداول والداتا
using System.Drawing; // مكتبة الرسومات والألوان
using System.Linq; // مكتبة الاستعلامات LINQ
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام غير المتزامنة
using System.Windows.Forms; // مكتبة عناصر الفورم

namespace ETEZAN2024 // النيمسبيس الرئيسي للتطبيق
{
    public partial class frmDebtsList : Form // تعريف فورم يعرض قائمة الديون
    {
        int _DebtID = -1; // متغير يخزن رقم الدين، -1 يعني بعده ما مختار شي
        clsDebts _Debts; // كائن يمثل الدين
        DataTable _dtDebtsList; // جدول نخزن بيه بيانات الديون
        DataView _dvDebtsList; // DataView نستخدمه للفلترة والعرض

        public frmDebtsList() // كونستركتر للفورم
        {
            InitializeComponent(); // تهيئة مكونات الفورم
        }

        private void _RefreshDebtsList() // دالة لتحديث بيانات جدول الديون
        {
            // 1. جلب البيانات من طبقة BLL وربطها بالـ DataGridView
            dgvAllDebts.DataSource = clsDebts.GetAllDebtsList();

            // 2. التحقق من وجود بيانات لتجنب أي أخطاء عند تعديل الأعمدة
            if (dgvAllDebts.Rows.Count == 0)
            {
                // تعطيل الكونتكس مينو لأنه لا توجد صفوف لتعديلها أو عرض تفاصيلها
                ctmsDebtsManagement.Enabled = false;
                cmbFilterDebtInfo.Enabled = false;
                // تحديث اللابل لتوضيح أن عدد الصفوف صفر
                lbDebtsCount.Text = "0";

                // الخروج من الدالة لتجنب الوصول لأعمدة غير موجودة
                return;
            }

            // 3. تعديل أعمدة الجدول بشكل آمن
            if (dgvAllDebts.Columns.Count > 1)
                dgvAllDebts.Columns[1].Width = 150; // تغيير عرض العمود الثاني فقط إذا موجود
            if (dgvAllDebts.Columns.Count > 2)
                dgvAllDebts.Columns[2].Width = 120; // تغيير عرض العمود الثالث فقط إذا موجود

            // 4. تحديث اللابل لعرض عدد الصفوف الحالية
            lbDebtsCount.Text = dgvAllDebts.RowCount.ToString();

            // 5. تفعيل أو تعطيل الكونتكس مينو حسب وجود البيانات
            ctmsDebtsManagement.Enabled = dgvAllDebts.RowCount > 0;
            cmbFilterDebtInfo.Enabled = true;

        }

        private void _FillComboBoxByIsActiveDebtInfo() // دالة تملأ ComboBox الخاص بحالة الدين
        {
            cmbIsDebtStatus.Items.Add("الكل"); // نضيف خيار الكل
            cmbIsDebtStatus.Items.Add("نشط"); // نضيف خيار نشط
            cmbIsDebtStatus.Items.Add("غير نشط"); // نضيف خيار غير نشط
        }

        private void _FillComboBoxByDebtsInfo() // دالة تملأ ComboBox الخاص بالفلترة حسب الأعمدة
        {
            cmbFilterDebtInfo.Items.Add("لاشيئ"); // بدون فلترة
            cmbFilterDebtInfo.Items.Add("معرف الدين"); // فلترة حسب رقم الدين
            cmbFilterDebtInfo.Items.Add("اسم المدين"); // فلترة حسب الاسم
            cmbFilterDebtInfo.Items.Add("رقم الهاتف"); // فلترة حسب رقم الهاتف
            cmbFilterDebtInfo.Items.Add("العنوان"); // فلترة حسب العنوان
            cmbFilterDebtInfo.Items.Add("تاريخ الدين"); // فلترة حسب التاريخ
            cmbFilterDebtInfo.Items.Add("رقم الطلب"); // فلترة حسب رقم الطلب
            cmbFilterDebtInfo.Items.Add("نشاط الدين"); // فلترة حسب حالة النشاط
        }

        private void _ApplyFillterIsActiveDebtInfo(string ColumnName) // دالة فلترة حسب حالة النشاط
        {
            if (_dtDebtsList == null) return; // اذا ماكو بيانات نرجع
            if (string.IsNullOrEmpty(ColumnName)) return; // اذا العمود فارغ نرجع

            switch (ColumnName) // نفحص النص
            {
                case "الكل": // اذا اختار الكل
                    _dvDebtsList.RowFilter = ""; // ماكو فلترة
                    lbDebtsCount.Text = _dvDebtsList.Count.ToString(); // نعرض العدد
                    break;
                case "نشط": // اذا نشط
                    _dvDebtsList.RowFilter = "[نشاط الدين] = 'نشط'"; // نعرض النشط فقط
                    lbDebtsCount.Text = _dvDebtsList.Count.ToString();
                    break;
                case "غير نشط": // اذا غير نشط
                    _dvDebtsList.RowFilter = "[نشاط الدين] = 'غير نشط'"; // نعرض الغير نشط فقط
                    lbDebtsCount.Text = _dvDebtsList.Count.ToString();
                    break;
                default: // افتراضي
                    _dvDebtsList.RowFilter = ""; // نعرض الكل
                    break;
            }
        }

        private void _ApplyFillterDebtInfo(string ColumnName, string Value) // دالة فلترة حسب العمود والقيمة
        {
            _dtDebtsList = clsDebts.GetAllDebtsList(); // نجيب البيانات من BLL
            _dvDebtsList = new DataView(_dtDebtsList); // نخليها DataView للفلترة

            if (string.IsNullOrEmpty(Value) && ColumnName == "لاشيئ") // اذا فلترة فارغة
            {
                tbFilterValue.Text = ""; // نفرغ التكست
                _dvDebtsList.RowFilter = ""; // ماكو فلترة
                return;
            }

            switch (ColumnName) // نفحص العمود
            {
                case "معرف الدين": // فلترة بالـ ID
                case "رقم الطلب": // فلترة برقم الطلب
                    tbFilterValue.Visible = true; // نظهر التكست
                    cmbIsDebtStatus.Visible = false; // نخفي الكومبوبوكس
                    _dvDebtsList.RowFilter = $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // فلترة
                    lbDebtsCount.Text = _dvDebtsList.Count.ToString();
                    break;

                case "تاريخ الدين": // فلترة بالتاريخ
                    tbFilterValue.Visible = true;
                    cmbIsDebtStatus.Visible = false;
                    _dvDebtsList.RowFilter = $"Convert([تاريخ الدين], 'System.String') LIKE '%{Value}%'";
                    lbDebtsCount.Text = _dvDebtsList.Count.ToString();
                    break;

                case "نشاط الدين": // فلترة حسب النشاط
                    tbFilterValue.Visible = false;
                    cmbIsDebtStatus.Visible = true;
                    _ApplyFillterIsActiveDebtInfo(cmbIsDebtStatus.Text);
                    break;

                default: // باقي الحالات
                    tbFilterValue.Visible = true;
                    cmbIsDebtStatus.Visible = false;
                    _dvDebtsList.RowFilter = $"[{ColumnName}] like '%{Value}%'";
                    lbDebtsCount.Text = _dvDebtsList.Count.ToString();
                    break;
            }

            dgvAllDebts.DataSource = _dvDebtsList; // نعرض النتائج بالجدول
        }

        private void frmDebtsList_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _RefreshDebtsList(); // نحدث القائمة
            _FillComboBoxByDebtsInfo(); // نملأ الكومبوبوكس للفلترة
            _FillComboBoxByIsActiveDebtInfo(); // نملأ الكومبوبوكس للنشاط
            cmbFilterDebtInfo.SelectedIndex = 0; // الافتراضي "لاشيئ"
            cmbIsDebtStatus.SelectedIndex = 0; // الافتراضي "الكل"
        }

        private void pBoxAddDebt_Click(object sender, EventArgs e) // حدث عند الضغط على زر الإضافة
        {
            frmAddAndEditDebt frmAdd = new frmAddAndEditDebt();
            frmAdd.ShowDialog();
            _RefreshDebtsList(); // نحدث البيانات بعد ما ينسد
                             }

        private void ctmsDetailDebt_Click(object sender, EventArgs e) // حدث عند فتح تفاصيل الدين
        {
            frmDebtDetials detials = new frmDebtDetials((int)dgvAllDebts.CurrentRow.Cells[0].Value); // نجيب ID الصف الحالي
            detials.ShowDialog(); // نعرض الفورم
            _RefreshDebtsList(); // نحدث البيانات بعد ما ينسد
        }

        private void cmbFilterDebtInfo_SelectedIndexChanged(object sender, EventArgs e) // حدث تغيير الفلترة
        {
            if (cmbFilterDebtInfo.Text == "لاشيئ")
            {
                tbFilterValue.Visible = false;
                cmbIsDebtStatus.Visible = false;
            }
            else
            {
                tbFilterValue.Visible = true;
            }
            _ApplyFillterDebtInfo(cmbFilterDebtInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // حدث الكتابة في TextBox
        {
            if (cmbFilterDebtInfo.Text == "معرف الدين" || cmbFilterDebtInfo.Text == "رقم الطلب")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
                {
                    e.Handled = true;
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (cmbFilterDebtInfo.Text == "تاريخ الدين")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // نسمح بس بالأرقام و /
                {
                    e.Handled = true;
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // حدث تغيير النص بالـ TextBox
        {
            _ApplyFillterDebtInfo(cmbFilterDebtInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void cmbIsDebtStatus_SelectedIndexChanged(object sender, EventArgs e) // حدث تغيير الكومبوبوكس للنشاط
        {
            _ApplyFillterDebtInfo(cmbFilterDebtInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void ctmsAddDebt_Click(object sender, EventArgs e)
        {
            frmAddAndEditDebt frmAdd = new frmAddAndEditDebt();
            frmAdd.ShowDialog();
            _RefreshDebtsList(); // نحدث البيانات بعد ما ينسد

        }

        private void ctmsEidtDebt_Click(object sender, EventArgs e)
        {
            frmAddAndEditDebt frmAdd = new frmAddAndEditDebt((int)dgvAllDebts.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
            _RefreshDebtsList(); // نحدث البيانات بعد ما ينسد
        }
    }
}
