using BusinessLayeres; // نستدعي طبقة الأعمال حتى نستخدم الكلاسات اللي تتعامل ويا البيانات
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution
{
    public partial class frmOrderCashBoxsDistributionList : Form
    {
        int _OrderCashBoxsDistributionID = -1; // نخزن رقم توزيع الكاش، -1 يعني بعده ما مختار سجل
        clsOrderBoxCashDistribution _OrderBoxCashDistribution; // كائن يمثل عملية توزيع معينة
        DataTable _dtOrderBoxsCashDistributionList; // جدول نخزن بيه كل البيانات اللي تجي من قاعدة البيانات
        DataView _dvOrderBoxsCashDistributionList; // نستخدمه للفلترة والعرض داخل الجدول (DataGridView)

        public decimal CalculateTotalAmount
        {
            get { return _CalculateTotalAmount(); }
        }
        public frmOrderCashBoxsDistributionList()
        {
            InitializeComponent(); // نجهز مكونات الفورم
        }

        private decimal _CalculateTotalAmount()
        {
            decimal total = 0; // نبدأ المجموع من الصفر

            // نمر على كل صف داخل DataGridView
            foreach (DataGridViewRow row in dgvAllOrderCashBoxsDistribution.Rows)
            {
                // نتأكد إن الخلية مو فارغة أو DBNull
                if (row.Cells["المبلغ"].Value != null && row.Cells["المبلغ"].Value != DBNull.Value)
                {
                    // نحول القيمة إلى رقم ونجمعها
                    total += Convert.ToDecimal(row.Cells["المبلغ"].Value);
                }
            }

            // نعرض الناتج داخل الليبل مع تنسيق الأرقام + د.ع
            lbTotalAmount.Text = $"{total:N0} د.ع";
            return total;
        }

        private void _RefreshOrderCashBoxsDistributionList() // دالة تحديث بيانات توزيع الصندوق
        {
            // 1. جلب البيانات من الطبقة الوسطى وربطها بالـ DataGridView
            dgvAllOrderCashBoxsDistribution.DataSource = clsOrderBoxCashDistribution.GetAll();

            // 2. التحقق من وجود بيانات قبل التعديل على الأعمدة
            if (dgvAllOrderCashBoxsDistribution.Rows.Count == 0)
            {
                // تعطيل الكونتكس مينو لأنه لا توجد عناصر حدفع/تحرير
                ctmsOrderCashBoxsDistributionManagement.Enabled = false;

                // تعطيل الفلتر لعدم وجود بيانات
                cmbFilterOrderCashBoxDistributionInfo.Enabled = false;

                // عدد السجلات = صفر
                lbOrderCashBoxsDistributionCount.Text = "0";

                // تحديث مجموع المبلغ إلى صفر
                lbOrderCashBoxsDistributionCount.Text = "0 د.ع";

                // الخروج من الدالة لتجنب الوصول لأعمدة غير موجودة
                return;
            }

            // 3. تعديل الأعمدة بشكل آمن بحسب عدد الأعمدة الفعلي
            if (dgvAllOrderCashBoxsDistribution.Columns.Count > 4)
                dgvAllOrderCashBoxsDistribution.Columns[4].Width = 150; // عرض العمود الخامس

            if (dgvAllOrderCashBoxsDistribution.Columns.Count > 5)
                dgvAllOrderCashBoxsDistribution.Columns[5].Width = 150; // عرض العمود السادس

            // 4. تحديث عداد السجلات
            lbOrderCashBoxsDistributionCount.Text = dgvAllOrderCashBoxsDistribution.RowCount.ToString();

            // 5. حساب المجموع وتحديثه داخل اللابل
            lbOrderCashBoxsDistributionCount.Text =
                _CalculateTotalAmount().ToString("N0") + " د.ع"; // تنسيق الرقم فقط

            // 6. تفعيل الكونتكس مينو لوجود بيانات
            ctmsOrderCashBoxsDistributionManagement.Enabled = true;

            // 7. تفعيل الفلتر لوجود بيانات
            cmbFilterOrderCashBoxDistributionInfo.Enabled = true;
        }

        private void _FillComboBoxByFilterInfo() // دالة تعبئة الكومبوبوكس الخاص بالفلترة (حسب الأعمدة)
        {
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("لاشيء"); // أول خيار يعني بدون فلترة
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("رقم المعرف"); // فلترة حسب رقم المعرف
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("رقم الطلب"); // فلترة حسب رقم الطلب
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("المبلغ"); // فلترة حسب المبلغ
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("تاريخ الإضافة"); // فلترة حسب تاريخ الإضافة
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("آخر تحديث"); // فلترة حسب آخر تحديث
            cmbFilterOrderCashBoxDistributionInfo.Items.Add("الحالة"); // فلترة حسب الحالة (تم الترحيل / قيد الترحيل)
        }

        private void _FillComboBoxByStatusInfo() // دالة تعبئة الكومبوبوكس الثاني (حالة الترحيل)
        {
            OrderCashBoxsDistributionStatus.Items.Add("الكل"); // نعرض الكل
            OrderCashBoxsDistributionStatus.Items.Add("تم الترحيل"); // نعرض فقط اللي تم ترحيله
            OrderCashBoxsDistributionStatus.Items.Add("قيد الترحيل"); // نعرض اللي بعده قيد التنفيذ
        }

        private void _ApplyFilter(string ColumnName, string Value) // دالة تطبق الفلترة حسب العمود والقيمة
        {
            _dtOrderBoxsCashDistributionList = clsOrderBoxCashDistribution.GetAll(); // نجيب كل البيانات
            _dvOrderBoxsCashDistributionList = new DataView(_dtOrderBoxsCashDistributionList); // نحولها إلى DataView للفلترة
            if (_dtOrderBoxsCashDistributionList == null) return; // إذا ماكو بيانات نطلع
            if (string.IsNullOrEmpty(ColumnName)) return; // إذا العمود فارغ نطلع

            // نحدد شلون نفلتر حسب اسم العمود
            switch (ColumnName)
            {
                case "لاشيء":
                    _dvOrderBoxsCashDistributionList.RowFilter = ""; // ما نسوي أي فلترة
                    break;

                case "رقم المعرف":
                case "رقم الطلب":
                    _dvOrderBoxsCashDistributionList.RowFilter = $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // نبحث عن القيمة داخل العمود
                    break;

                case "تاريخ الإضافة":
                    _dvOrderBoxsCashDistributionList.RowFilter = $"Convert([تاريخ الإضافة], 'System.String') LIKE '%{Value}%'"; // نفلتر حسب التاريخ
                    break;

                case "آخر تحديث":
                    _dvOrderBoxsCashDistributionList.RowFilter = $"Convert([آخر تحديث], 'System.String') LIKE '%{Value}%'"; // نفلتر حسب تاريخ التحديث
                    break;

                case "الحالة":
                    _ApplyFilterByStatus(OrderCashBoxsDistributionStatus.Text); // نستخدم دالة ثانية خاصة بالحالة
                    break;

                default:
                    _dvOrderBoxsCashDistributionList.RowFilter = $"[{ColumnName}] LIKE '%{Value}%'"; // فلترة عامة
                    break;
            }

            // نحدث العداد ونربط الجدول بعد الفلترة

            lbOrderCashBoxsDistributionCount.Text = _dvOrderBoxsCashDistributionList.Count.ToString();
            dgvAllOrderCashBoxsDistribution.DataSource = _dvOrderBoxsCashDistributionList;
        }

        private void _ApplyFilterByStatus(string StatusText) // دالة فلترة حسب الحالة فقط
        {
            if (_dtOrderBoxsCashDistributionList == null) return; // إذا الجدول فارغ نطلع
            if (string.IsNullOrEmpty(StatusText)) return; // إذا النص فارغ نطلع

            switch (StatusText)
            {
                case "الكل":
                    _dvOrderBoxsCashDistributionList.RowFilter = ""; // نعرض الكل بدون فلترة
                    break;

                case "تم الترحيل":
                    _dvOrderBoxsCashDistributionList.RowFilter = "[الحالة] = 'تم الترحيل'"; // نعرض بس اللي حالته تم الترحيل
                    break;

                case "قيد الترحيل":
                    _dvOrderBoxsCashDistributionList.RowFilter = "[الحالة] = 'قيد الترحيل'"; // نعرض بس اللي بعده قيد الترحيل
                    break;
            }

            lbOrderCashBoxsDistributionCount.Text = _dvOrderBoxsCashDistributionList.Count.ToString(); // نعرض عدد النتائج بعد الفلترة
        }

        private void frmOrderCashBoxsDistributionList_Load(object sender, EventArgs e)
        {
            _RefreshOrderCashBoxsDistributionList(); // نحدث الجدول أول ما يفتح الفورم
            _FillComboBoxByFilterInfo(); // نعبي الكومبوبوكس الأول (الفلترة)
            _FillComboBoxByStatusInfo(); // نعبي الكومبوبوكس الثاني (الحالة)
            cmbFilterOrderCashBoxDistributionInfo.SelectedIndex = 0; // نخلي الخيار الافتراضي "لاشيء"
            OrderCashBoxsDistributionStatus.SelectedIndex = 0; // نخلي الافتراضي "الكل"
        }

        private void cmbFilterOrderCashBoxDistributionInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // هنا نتحكم بشنو يبين حسب اختيار المستخدم
            if (cmbFilterOrderCashBoxDistributionInfo.Text == "الحالة")
            {
                tbFilterValue.Visible = false; // نخفي حقل النص
                OrderCashBoxsDistributionStatus.Visible = true; // ونظهر كومبوبوكس الحالة
            }
            else if (cmbFilterOrderCashBoxDistributionInfo.Text == "لاشيء")
            {
                tbFilterValue.Visible = false; // نخفي الكل
                OrderCashBoxsDistributionStatus.Visible = false;
            }
            else
            {
                tbFilterValue.Visible = true; // نظهر حقل النص
                OrderCashBoxsDistributionStatus.Visible = false; // ونخفي الحالة
            }

            _ApplyFilter(cmbFilterOrderCashBoxDistributionInfo.Text, tbFilterValue.Text); // نطبق الفلترة حسب الاختيار
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter(cmbFilterOrderCashBoxDistributionInfo.Text, tbFilterValue.Text); // نفلتر بمجرد المستخدم يكتب بالنص
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // نتحقق إذا العمود رقمي، نسمح فقط بالأرقام
            if (cmbFilterOrderCashBoxDistributionInfo.Text == "رقم المعرف" || cmbFilterOrderCashBoxDistributionInfo.Text == "رقم الطلب"
                || cmbFilterOrderCashBoxDistributionInfo.Text == "المبلغ")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // إذا مو رقم أو مفتاح تحكم
                {
                    e.Handled = true; // نمنع الإدخال
                    MessageBox.Show("يرجى إدخال أرقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            // نتحقق إذا الفلترة بالتاريخ، نسمح بالأرقام و "/"
            if (cmbFilterOrderCashBoxDistributionInfo.Text == "تاريخ الإضافة" || cmbFilterOrderCashBoxDistributionInfo.Text == "آخر تحديث")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void OrderCashBoxsDistributionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter(cmbFilterOrderCashBoxDistributionInfo.Text, tbFilterValue.Text); // نحدث الفلترة حسب تغيير الحالة
        }

        private void pBoxAddOrderCashBoxsDistribution_Click(object sender, EventArgs e)
        {
            frmSendOrderFundsToCashBox frmAdd = new frmSendOrderFundsToCashBox();
            frmAdd.ShowDialog();
            _RefreshOrderCashBoxsDistributionList();
        }

        private void ctmsAddCashOrderCashBoxsDistribution_Click(object sender, EventArgs e)
        {
            frmSendOrderFundsToCashBox frmAdd = new frmSendOrderFundsToCashBox();
            frmAdd.ShowDialog();
            _RefreshOrderCashBoxsDistributionList();
        }

        private void ctmsEidtOrderCashBoxsDistribution_Click(object sender, EventArgs e)
        {
            frmAddAndEditOrderCashBoxsDistribution frmAddAndEdit = new frmAddAndEditOrderCashBoxsDistribution((int)dgvAllOrderCashBoxsDistribution.CurrentRow.Cells[0].Value);
            frmAddAndEdit.ShowDialog();
            _RefreshOrderCashBoxsDistributionList();
        }

        private void ctmsDetailOrderCashBoxsDistribution_Click(object sender, EventArgs e)
        {
            frmShowOrderCashBoxsDistributionDetials Detials = new frmShowOrderCashBoxsDistributionDetials((int)dgvAllOrderCashBoxsDistribution.CurrentRow.Cells[0].Value);
            Detials.ShowDialog();
            _RefreshOrderCashBoxsDistributionList();
        }
    }
}
