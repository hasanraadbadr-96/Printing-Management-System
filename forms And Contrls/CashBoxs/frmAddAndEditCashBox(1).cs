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
    public partial class frmAddAndEditCashBox : Form
    {
        public enum enMode // نعرف نوع بيانات (تعداد) يحدد وضع الفورم
        {
            Add = 1, // وضع اضافة
            Update = 2 // وضع تعديل
        }
        enMode _mode; // متغير خاص لتخزين الوضع الحالي للفورم
        private int _CashBoxID = 1; // متغير يخزن معرف المنتج (ID)، اولياً 1
        private clsCashBoxs _CashBox; // كائن يمثل المنتج من كلاس المخازن
        public frmAddAndEditCashBox()
        {
            InitializeComponent();
            _mode = enMode.Add;
        }
        public frmAddAndEditCashBox(int CashBoxID)
        {
            InitializeComponent();
            _CashBoxID = CashBoxID;
            _mode = enMode.Update;
        }
        private void _ResetDefualtValues() // دالة ترجع القيم الافتراضية للفورم
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                lbAddAndEdit.Text = "اضافة صندوق"; // نخلي النص اضافة
                _CashBox = new clsCashBoxs(); // ننشئ كائن جديد
                return; // نطلع من الدالة
            }
            // اذا الوضع تعديل نفرغ الحقول
            lbCashBoxID.Text =             "####";
            tbbox_name.Text =               "";
            tbbox_balance.Text =             "";
            cmbPartnership_percentage.Text =  "";
            tbdeposited_amount.Text =             "";
            ltbwithdrawn_amount.Text =           "";
            dtpDeposit_date.Text =                 "";
            dtpWithdrawal_date.Text =              "";

        }
        private void _FillCashBoxInfo() // دالة تملأ الحقول بمعلومات المنتج
        {
            lbAddAndEdit.Text = "تعديل معلومات الصندوق";
            lbCashBoxID.Text =               _CashBox.CashBoxID.ToString();
            tbbox_name.Text =                _CashBox.box_name;
            tbbox_balance.Text =             _CashBox.box_balance.ToString();
            cmbPartnership_percentage.Text = _CashBox.partnership_percentage.ToString();
             tbdeposited_amount.Text =       _CashBox.deposited_amount.ToString();
            ltbwithdrawn_amount.Text =       _CashBox.withdrawn_amount.ToString();
             dtpDeposit_date.Value =          _CashBox.deposit_date;
             dtpWithdrawal_date.Value =       _CashBox.withdrawal_date;

        }
        private void _FillComboBoxByCashBoxInfo()
        {
            for (int i = 0; i <= 100; i++)
            {
                cmbPartnership_percentage.Items.Add("% " + i);
            }
        }
        private void _LoadData() // دالة تحميل البيانات
        {
            _CashBox = clsCashBoxs.Find(_CashBoxID); // نبحث عن المنتج بالـ ID
            if (_CashBox == null) // اذا ما لكينا
            {
                _ResetDefualtValues(); // نفرغ الحقول
                MessageBox.Show("لم يتم العثور علئ هذا الصندوق", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                this.Close(); // نسد الفورم
                return; // نطلع
            }
            _FillCashBoxInfo(); // نملأ الحقول
        }

        private void frmAddAndEditCashBox_Load(object sender, EventArgs e)
        {
            _FillComboBoxByCashBoxInfo();
            cmbPartnership_percentage.SelectedIndex = 0;
            if (_mode == enMode.Update)
            {
                _LoadData();
            }
            else
            {
                _ResetDefualtValues();
            }

        }

        private void tbbox_balance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbdeposited_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void ltbwithdrawn_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbbox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbbox_name.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderCashBoxes.SetError(tbbox_name, "من فضلك ادخل اسم الصندوق"); // نخلي رسالة خطأ
            }
            else
                errorProviderCashBoxes.SetError(tbbox_name, ""); // اذا صحيح نخلي فارغ
        }

        private void tbbox_balance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbbox_balance.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderCashBoxes.SetError(tbbox_balance, "من فضلك ادخل رصيد الصندوق"); // نخلي رسالة خطأ
            }
            else
                errorProviderCashBoxes.SetError(tbbox_balance, ""); // اذا صحيح نخلي فارغ
        }

        private void tbdeposited_amount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbdeposited_amount.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderCashBoxes.SetError(tbdeposited_amount, "من فضلك ادخل مبلغ الايداع "); // نخلي رسالة خطأ
            }
            else
                errorProviderCashBoxes.SetError(tbdeposited_amount, ""); // اذا صحيح نخلي فارغ
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // اذا الحقول بيها خطأ
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نوقف العملية
            }

            _CashBox.box_name = tbbox_name.Text;
            _CashBox.box_balance= decimal.Parse( tbbox_balance.Text);
            string text = cmbPartnership_percentage.Text.Replace("%", "").Trim();
            _CashBox.partnership_percentage = decimal.Parse(text);
            _CashBox.deposited_amount= decimal.Parse(tbdeposited_amount.Text); ;
            _CashBox.withdrawn_amount= decimal.Parse(ltbwithdrawn_amount.Text); ;
            _CashBox.deposit_date = dtpDeposit_date.Value;
            _CashBox.withdrawal_date =dtpWithdrawal_date.Value;
            _CashBox.orders_id = 39;
            if (_CashBox.Save()) // اذا حفظنا البيانات
            {
                lbCashBoxID.Text = _CashBox.CashBoxID.ToString(); // نعرض رقم المنتج
                lbAddAndEdit.Text = " تعديل معلومات الصندوق"; // نغير النص لتعديل
                _mode = enMode.Update; // نخلي الوضع تحديث
                MessageBox.Show("تم حفظ معلومات  الصندوق", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); // رسالة نجاح
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة فشل
            }
        }

        private void ltbwithdrawn_amount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ltbwithdrawn_amount.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderCashBoxes.SetError(ltbwithdrawn_amount, "من فضلك ادخل المبلغ المسحوب"); // نخلي رسالة خطأ
            }
            else
                errorProviderCashBoxes.SetError(ltbwithdrawn_amount, ""); // اذا صحيح نخلي فارغ
        }

        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
