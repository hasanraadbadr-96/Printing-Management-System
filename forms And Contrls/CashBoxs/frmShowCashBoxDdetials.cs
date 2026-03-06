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
    public partial class frmShowCashBoxDdetials : Form
    {
        int _CashBoxID = -1;
        clsCashBoxs _CashBox;
        public frmShowCashBoxDdetials(int CashBoxID)
        {
            InitializeComponent();
            _CashBoxID = CashBoxID;

        }
        private void _ResetDefualtValues() // دالة تفرغ الحقول وتخلي قيم افتراضية
        {
            lbCashBoxID.Text                = "####"; // نخلي علامات مكان رقم الدين
            lbOrderID.Text                 = "####"; // نخلي علامات مكان اسم المدين
            lbbox_name.Text                 = "####"; // نخلي علامات مكان العنوان
            lbbox_balance.Text               = "####"; // نخلي علامات مكان الهاتف
            lbpartnership_percentage.Text  = "####"; // نخلي علامات مكان اسم المستخدم
            lbdeposited_amount.Text         = "####"; // نخلي علامات مكان التاريخ
            lbwithdrawn_amount.Text         = "####"; // نخلي علامات مكان المبلغ
            lbdeposit_date.Text            = "####"; // نخلي علامات مكان حالة الدين
            lbwithdrawal_date.Text          = "####"; // نخلي علامات مكان المبلغ
        }
        private void _FillCashBoxInfo() // دالة تملأ البيانات من الكائن _Debt
        {
             lbCashBoxID.Text            =_CashBox.CashBoxID.ToString() ;
            lbOrderID.Text               =_CashBox.orders_id.ToString() ;
            lbbox_name.Text              =_CashBox.box_name ;
            lbbox_balance.Text           =_CashBox .box_balance.ToString();
            lbpartnership_percentage.Text=_CashBox .partnership_percentage.ToString()+" %";
            lbdeposited_amount.Text      =_CashBox.deposited_amount.ToString();
            lbwithdrawn_amount.Text      =_CashBox .withdrawn_amount.ToString();
            lbdeposit_date.Text          =_CashBox.deposit_date.ToString();
            lbwithdrawal_date.Text       =_CashBox .withdrawal_date.ToString();
        }
        private void _LoadData(int CashBoxID) // دالة تجيب البيانات من القاعدة
        {
            _CashBoxID = CashBoxID ;
            _CashBox = clsCashBoxs.Find(_CashBoxID); // نبحث عن الدين بهذا الـ ID

            if (_CashBox == null) // إذا ما لكينا بيانات
            {
                _ResetDefualtValues(); // نفرغ الحقول بالقيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا الصندوق", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                this.Close(); // نغلق الفورم
                return; // نوقف الدالة
            }

            _FillCashBoxInfo(); // إذا لكينا البيانات نعرضها بالفورم
        }

        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowCashBoxDdetials_Load(object sender, EventArgs e)
        {
            _LoadData(_CashBoxID);
        }

        private void lnkEditCashBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEditCashBox editCashBox = new frmAddAndEditCashBox(_CashBoxID);
            editCashBox.ShowDialog();
            _LoadData(_CashBoxID);
        }
    }
}
