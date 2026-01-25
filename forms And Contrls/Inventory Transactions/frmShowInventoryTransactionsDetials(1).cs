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

namespace ETEZAN2024.forms_And_Contrls.Inventory_Transactions
{
    public partial class frmShowInventoryTransactionsDetials : Form
    {
        clsInventoryTransactions _InventoryTransaction;
        int _transactionID=-1;
        public frmShowInventoryTransactionsDetials(int transactionID)
        {
            InitializeComponent();
            _transactionID = transactionID;
        }
        private void _ResetDefualtValues()
        {
          
       

            // اذا الوضع تعديل، نفضي الحقول
            lbInventoryID.Text = "####"; // نص افتراضي لرقم الحركة
            lbProdectName.Text = "####"; // نفرغ اسم المنتج
            lbTypeInventoryTransaction.Text = "####"; // نفرغ نوع الحركة
            lbQuantity.Text = ""; // نفرغ الكمية
            lbdate.Text = "####"; // نرجع التاريخ للصفر
            lbOrderItemID.Text = "####"; //
        }

        private void _FillLabelsByInventoryTransactionInfo()
        {
            lbInventoryID.Text = _InventoryTransaction.transaction_id.ToString(); // نعرض رقم الحركة
            lbProdectName.Text = _InventoryTransaction.ProductInfo.productName; // نعرض اسم المنتج
            lbTypeInventoryTransaction.Text = _InventoryTransaction.type; // نعرض نوع الحركة
            lbQuantity.Text = _InventoryTransaction.quantity.ToString(); // نعرض الكمية
            lbdate.Text = _InventoryTransaction.date.ToString(); // نعرض التاريخ
            lbOrderItemID.Text = _InventoryTransaction.Order_ItemID.ToString(); // نعرض التاريخ

        }


        // دالة لتحميل بيانات الحركة عند التعديل
        private void _LoadData()
        {
            _InventoryTransaction = clsInventoryTransactions.Find(_transactionID); // نجيب الحركة من قاعدة البيانات
            if (_InventoryTransaction == null) // اذا ما موجودة
            {
                _ResetDefualtValues(); // نعيد القيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا الجرد", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                this.Close(); // نقفل الفورم
                return;
            }
            _FillLabelsByInventoryTransactionInfo(); // نملأ الحقول بالبيانات
        }
        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowInventoryTransactionsDetials_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void lnkEditProductPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEditInventoryTransactions frmUpdate = new frmAddAndEditInventoryTransactions(_transactionID);
            frmUpdate.ShowDialog();
            _LoadData();

        }
    }
}
