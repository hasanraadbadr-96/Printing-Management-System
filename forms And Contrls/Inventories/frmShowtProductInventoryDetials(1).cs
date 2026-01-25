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

namespace ETEZAN2024.forms_And_Contrls.Inventories
{
    public partial class frmShowtProductInventoryDetials : Form
    {
        private int _InventoryID = 1; // متغير خاص ID للسعر الافتراضي يبدأ 1
        private clsInventories _clsInventory;
        public frmShowtProductInventoryDetials(int InventoryID)
        {
            InitializeComponent();
            _InventoryID = InventoryID;
        }

        private void _ResetDefualtValues() // دالة تفرغ الحقول بالقيم الافتراضية
        {
            lbInventoryID.Text = "####"; // نخلي علامات بدال الـ ID
            lbProductName.Text = "####"; // نخلي علامات بدال اسم المنتج
            lbPurchase_price.Text = "####"; // نخلي علامات بدال الحجم
            lbSelling_price.Text = "####"; // نخلي علامات بدال السعر
            lbAvaibleProduct.Text = "####"; // نخلي علامات بدال الخيارات

            lbMin_stock_alert.Text = "####";
            lbVendor_name.Text = "####";

            lbLast_purchase_date.Text = "####";





        }

        private void _FillProductInventoryInfo() // دالة تملأ بيانات السعر من الكائن
        {
            lbAddAndEdit.Text = "تعديل منتج المخزن"; // نخلي النص تعديل
            lbInventoryID.Text = _clsInventory.ID.ToString(); // نعرض معرف المنتج
            lbProductName.Text = _clsInventory.ProductInfo.productName;
            lbAvaibleProduct.Text = _clsInventory.available_quantity.ToString(); // نعرض الكمية المتوفرة
            lbPurchase_price.Text = _clsInventory.purchase_price.ToString(); // نعرض الكمية المستعملة
            lbSelling_price.Text = _clsInventory.selling_price.ToString(); // نعرض الكمية المستعملة
            lbMin_stock_alert.Text = _clsInventory.min_stock_alert.ToString(); // نعرض الكمية المستعملة
            lbLast_purchase_date.Text = _clsInventory.last_purchase_date.ToString(); // نعرض الكمية المستعملة
            lbVendor_name.Text = _clsInventory.vendor_name.ToString(); // نعرض الكمية المستعملة
        }

        private void _LoadData(int InventoryID) // دالة تجيب البيانات من قاعدة البيانات
        {
            _InventoryID = InventoryID; // نخزن ID اللي اجانا
            _clsInventory = clsInventories.Find(_InventoryID); // نبحث عن السعر من خلال ID

            if (_clsInventory == null) // اذا ماكو بيانات
            {
                _ResetDefualtValues(); // نفرغ الحقول (ملاحظة: هنانة خطأ منطقي لأن المفروض يجي بعد نجاح مو فشل)
                MessageBox.Show("لم يتم العثور علئ هذا المنتج", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                this.Close(); // نغلق الفورم
                return; // نطلع من الدالة
            }

            _FillProductInventoryInfo(); // اذا لكينا البيانات نملأ الحقول
        }


        private void frmShowtProductInventoryDetials_Load(object sender, EventArgs e)
        {
            _LoadData(_InventoryID);
        }

        private void lnkEditProductPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEditProductsInventory frmAdd = new frmAddAndEditProductsInventory(_InventoryID);
            frmAdd.ShowDialog();
            _LoadData(_InventoryID);
        }

        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
