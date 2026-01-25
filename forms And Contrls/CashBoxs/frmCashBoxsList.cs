using BusinessLayeres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.CashBoxs
{
    public partial class frmCashBoxsList : Form
    {
        int _CashBoxID = -1; // متغير يخزن رقم الدين، -1 يعني بعده ما مختار شي
        clsCashBoxs _CashBoxs; // كائن يمثل الدين
        DataTable _dtCashBoxsList; // جدول نخزن بيه بيانات الديون
        DataView _dvCashBoxsList; // DataView نستخدمه للفلترة والعرض
        public frmCashBoxsList()
        {
            InitializeComponent();
        }
        private decimal _CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            // نجيب كل بيانات الصناديق من الطبقة الوسطى (BLL)
            _dtCashBoxsList = clsCashBoxs.GetAllCashBoxsList();

            // نمر على كل صف داخل الجدول
            foreach (DataRow row in _dtCashBoxsList.Rows)
            {
                // نتحقق إذا العمود ما فارغ (مو DBNull)
                if (row["رصيد الصندوق"] != DBNull.Value)
                {
                    // نجمع الرصيد من كل صندوق
                    totalAmount += decimal.Parse(row["رصيد الصندوق"].ToString().Trim());
                }
            }

            // نرجع المجموع النهائي
            return totalAmount;
        }  //حساب مجموع الاموال في جميع صناديق
        private bool _isEmptyMessageShown = false; // علم لتجنب تكرار الرسالة

        private void _RefreshCashBoxsList()
        {
            dgvAllCashBoxs.DataSource = clsCashBoxs.GetAllCashBoxsList();

            if (dgvAllCashBoxs.Rows.Count == 0)
            {
                cmbFilterCashBoxInfo.Enabled = false;
                ctmsCashBoxsManagement.Enabled = false;
                lbCashBoxsCount.Text = "0";
                lbTotalAmount.Text = "0 د.ع";

                // عرض الرسالة مرة واحدة فقط
                if (!_isEmptyMessageShown)
                {
                    MessageBox.Show("القائمة فارغة لاتوجد معلومات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _isEmptyMessageShown = true; // علم يمنع الرسالة من الظهور مرة أخرى
                }

                return;
            }

            _isEmptyMessageShown = false; // إعادة ضبط العلم عند وجود بيانات

            if (dgvAllCashBoxs.Columns.Count > 6) dgvAllCashBoxs.Columns[6].Width = 120;
            if (dgvAllCashBoxs.Columns.Count > 7) dgvAllCashBoxs.Columns[7].Width = 120;

            lbCashBoxsCount.Text = dgvAllCashBoxs.RowCount.ToString();
            lbTotalAmount.Text = _CalculateTotalAmount().ToString("N0") + " د.ع";

            ctmsCashBoxsManagement.Enabled = true;
            cmbFilterCashBoxInfo.Enabled = true;
        }
        private void _FillComboBoxByCashBoxsInfo() // دالة تملأ ComboBox الخاص بالفلترة حسب الأعمدة
        {
            cmbFilterCashBoxInfo.Items.Add("لاشيئ"); // بدون فلترة
            cmbFilterCashBoxInfo.Items.Add("معرف الصندوق"); // فلترة حسب رقم الدين
            cmbFilterCashBoxInfo.Items.Add("اسم الصندوق"); // فلترة حسب الاسم
            cmbFilterCashBoxInfo.Items.Add("تاريخ الإيداع"); // فلترة حسب التاريخ
            cmbFilterCashBoxInfo.Items.Add("تاريخ السحب"); // فلترة حسب التاريخ
            cmbFilterCashBoxInfo.Items.Add("رقم الطلب"); // فلترة حسب رقم الدين

        }
        private void _ApplyFillterCashBoxInfo(string ColumnName, string Value) // دالة فلترة حسب العمود والقيمة
        {
            _dtCashBoxsList = clsCashBoxs.GetAllCashBoxsList(); // نجيب البيانات من BLL
            _dvCashBoxsList = new DataView(_dtCashBoxsList); // نخليها DataView للفلترة

            if (string.IsNullOrEmpty(Value) && ColumnName == "لاشيئ") // اذا فلترة فارغة
            {
                tbFilterValue.Text = ""; // نفرغ التكست
                _dvCashBoxsList.RowFilter = ""; // ماكو فلترة
                return;
            }

            switch (ColumnName) // نفحص العمود
            {
                case "معرف الصندوق": // فلترة برقم الطلب
                case "رقم الطلب":
                    tbFilterValue.Visible = true; // نظهر التكست
                    _dvCashBoxsList.RowFilter = $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // فلترة
                    lbCashBoxsCount.Text = _dvCashBoxsList.Count.ToString();
                    break;

                case "تاريخ السحب":
                    tbFilterValue.Visible = true; // نظهر التكست
                    _dvCashBoxsList.RowFilter = $"Convert([تاريخ السحب], 'System.String') LIKE '%{Value}%'";
                    lbCashBoxsCount.Text = _dvCashBoxsList.Count.ToString();

                    break;

                case "تاريخ الإيداع":
                    tbFilterValue.Visible = true; // نظهر التكست
                    _dvCashBoxsList.RowFilter = $"Convert([تاريخ الإيداع], 'System.String') LIKE '%{Value}%'";
                    lbCashBoxsCount.Text = _dvCashBoxsList.Count.ToString();

                    break;



                default: // باقي الحالات
                    tbFilterValue.Visible = true;
                    _dvCashBoxsList.RowFilter = $"[{ColumnName}] like '%{Value}%'";
                    lbCashBoxsCount.Text = _dvCashBoxsList.Count.ToString();
                    break;
            }

            dgvAllCashBoxs.DataSource = _dvCashBoxsList; // نعرض النتائج بالجدول
        }

        private void frmCashBoxsList_Load(object sender, EventArgs e)
        {
            _RefreshCashBoxsList();
            _FillComboBoxByCashBoxsInfo();
            cmbFilterCashBoxInfo.SelectedIndex = 0;
        }

        private void cmbFilterCashBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterCashBoxInfo.Text == "لاشيئ")
            {
                tbFilterValue.Visible = false;
                tbFilterValue.Clear();
                _RefreshCashBoxsList();

            }
            else
            {
                tbFilterValue.Visible = true;
            }
            _ApplyFillterCashBoxInfo(cmbFilterCashBoxInfo.Text,tbFilterValue.Text);
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFillterCashBoxInfo(cmbFilterCashBoxInfo.Text, tbFilterValue.Text);

        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterCashBoxInfo.Text == "معرف الصندوق" || cmbFilterCashBoxInfo.Text == "رقم الطلب")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
                {
                    e.Handled = true;
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (cmbFilterCashBoxInfo.Text == "تاريخ الإيداع" || cmbFilterCashBoxInfo.Text == "تاريخ السحب")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // نسمح بس بالأرقام و /
                {
                    e.Handled = true;
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void ctmsDetailCashBox_Click(object sender, EventArgs e)
        {
            frmShowCashBoxDdetials boxDdetials = new frmShowCashBoxDdetials((int)dgvAllCashBoxs.CurrentRow.Cells[0].Value);
            boxDdetials.ShowDialog();
            _RefreshCashBoxsList();
        }

        private void pBoxAddCashBox_Click(object sender, EventArgs e)
        {
            frmAddAndEditCashBox frmAddCashBox = new frmAddAndEditCashBox();
            frmAddCashBox.ShowDialog();
            _RefreshCashBoxsList();

        }

        private void ctmsAddCashBox_Click(object sender, EventArgs e)
        {
            frmAddAndEditCashBox frmAddCashBox = new frmAddAndEditCashBox();
            frmAddCashBox.ShowDialog();
            _RefreshCashBoxsList();
        }

        private void ctmsEidtCashBox_Click(object sender, EventArgs e)
        {
            frmAddAndEditCashBox frmEditCashBox = new frmAddAndEditCashBox((int)dgvAllCashBoxs.CurrentRow.Cells[0].Value);
            frmEditCashBox.ShowDialog();
            _RefreshCashBoxsList();
        }

        private void ctmsDeleteCashBox_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("هل انت متاكد من الصندوق", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // رسالة تأكيد
            //{
            //    if (clsCashBoxs.Delete((int)dgvAllCashBoxs.CurrentRow.Cells[0].Value)) // اذا الحذف نجح
            //    {
            //        _RefreshCashBoxsList(); // تحديث القائمة
            //    }
            //    else // اذا فشل الحذف
            //    {
            //        MessageBox.Show("  لم يتم حذف هذا الصندوق ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
            //        return;
            //    }
            }

        
    }
}
