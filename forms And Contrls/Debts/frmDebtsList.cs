
using BusinessLayeres;
using ETEZAN2024.forms_And_Contrls.Debts; // نستدعي النيمسبيس اللي يحتوي على فورم تفاصيل الديون
using EtezanPrinting_Shared.Depts;
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
        clsDebts _Debt = new clsDebts(); // كائن يمثل الدين
        DataTable _dtDebtsList; // جدول نخزن بيه بيانات الديون
        DataView _dvDebtsList; // DataView نستخدمه للفلترة والعرض
        List<DebtDTO> debtsList = new List<DebtDTO> ();
        public frmDebtsList() // كونستركتر للفورم
        {
            InitializeComponent(); // تهيئة مكونات الفورم
        }

        private void _RefreshDebtsList() // دالة لتحديث بيانات جدول الديون
        {
            // 1. جلب البيانات من خلال أوبجكت (Object) من كلاس الديون
            // تأكد من عمل static للدالة أو _Debt = new clsDebts() في Load
            debtsList = _Debt.GetAllDebtsList();
            dgvAllDebts.DataSource = debtsList;

            // 2. التحقق من وجود بيانات لتجنب أي أخطاء عند تعديل الأعمدة
            if (dgvAllDebts.Rows.Count == 0)
            {
                ctmsDebtsManagement.Enabled = false;
                cmbFilterDebtInfo.Enabled = false;
                lbDebtsCount.Text = "0";
                return;
            }

            // --- تعريب أسماء الأعمدة نفس الصورة بالضبط ---
            if (dgvAllDebts.Columns.Count > 0)
            {
                // تعريب العناوين
                dgvAllDebts.Columns["DebtID"].HeaderText = "معرف الدين";
                dgvAllDebts.Columns["DebtorName"].HeaderText = "اسم المدين";
                dgvAllDebts.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
                dgvAllDebts.Columns["DebtAmount"].HeaderText = "مبلغ الدين";
                dgvAllDebts.Columns["Address"].HeaderText = "العنوان";
                dgvAllDebts.Columns["DebtDate"].HeaderText = "تاريخ الدين";
                dgvAllDebts.Columns["OrdersID"].HeaderText = "رقم الطلب";
                dgvAllDebts.Columns["IsActive"].HeaderText = "نشاط الدين";

                // إخفاء الأعمدة التي لا تظهر في الصورة (المعرفات الداخلية)
                if (dgvAllDebts.Columns.Contains("UsersID")) dgvAllDebts.Columns["UsersID"].Visible = false;
                if (dgvAllDebts.Columns.Contains("PersonsID")) dgvAllDebts.Columns["PersonsID"].Visible = false;

                // --- ضبط العرض (Width) للأعمدة ---
                dgvAllDebts.Columns["DebtorName"].Width = 150;
                dgvAllDebts.Columns["Address"].Width = 150;
                dgvAllDebts.Columns["PhoneNumber"].Width = 120;
            }

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

        private void _ApplyFillterIsActiveDebtInfo(string Status)
        {
            if (debtsList == null) return;

            List<DebtDTO> filtered;

            switch (Status)
            {
                case "نشط":
                    filtered = debtsList.Where(x => x.IsActive == true).ToList();
                    break;
                case "غير نشط":
                    filtered = debtsList.Where(x => x.IsActive == false).ToList();
                    break;
                default: // "الكل"
                    filtered = debtsList;
                    break;
            }

            dgvAllDebts.DataSource = filtered;
            lbDebtsCount.Text = filtered.Count.ToString();
        }
        private void _ApplyFillterDebtInfo(string ColumnName, string Value)
        {
            // 1. نبدأ بالقائمة الكاملة
            var filteredData = debtsList.AsEnumerable();

            if (string.IsNullOrEmpty(Value) || ColumnName == "لاشيئ")
            {
                dgvAllDebts.DataSource = debtsList;
                lbDebtsCount.Text = debtsList.Count.ToString();
                return;
            }

            // 2. الفلترة الذكية (حتى لو حرف أو رقم واحد)
            switch (ColumnName)
            {
                case "معرف الدين":
                    // نحول الرقم لنص ونشوف إذا "يحتوي" على الرقم المكتوب
                    filteredData = filteredData.Where(x => x.DebtID.ToString().Contains(Value));
                    break;

                case "رقم الطلب":
                    // نفس الشيء هنا، نحول رقم الطلب لنص ونبحث بداخله
                    // استخدمنا ?. للتأكد إذا كان رقم الطلب Null حتى لا يضرب البرنامج
                    filteredData = filteredData.Where(x => x.OrdersID.ToString().Contains(Value));
                    break;

                case "اسم المدين":
                    filteredData = filteredData.Where(x => x.DebtorName.ToLower().Contains(Value.ToLower()));
                    break;

                case "رقم الهاتف":
                    filteredData = filteredData.Where(x => x.PhoneNumber != null && x.PhoneNumber.Contains(Value));
                    break;

                case "العنوان":
                    filteredData = filteredData.Where(x => x.Address != null && x.Address.ToLower().Contains(Value.ToLower()));
                    break;

                case "تاريخ الدين":
                    filteredData = filteredData.Where(x => x.DebtDate.ToString().Contains(Value));
                    break;

                case "نشاط الدين":
                    cmbIsDebtStatus.Visible = true;
                    _ApplyFillterIsActiveDebtInfo(cmbIsDebtStatus.Text);
                    return;
            }

            // 3. عرض النتائج
            var result = filteredData.ToList();
            dgvAllDebts.DataSource = result;
            lbDebtsCount.Text = result.Count.ToString();
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