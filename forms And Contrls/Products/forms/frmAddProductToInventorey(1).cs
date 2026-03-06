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

namespace ETEZAN2024.forms_And_Contrls.Products.forms
{
    public partial class frmAddProductToInventorey : Form
    {
        clsProducts _product; // كائن المنتج اللي بنضيفه للمخزون
        clsInventories _clsInventory; // كائن مخزون المنتج
        public frmAddProductToInventorey(clsProducts product)
        {
            InitializeComponent();
            _product = product; // نخزن المنتج اللي بنضيفه للمخزون

        }

        private void _FillProductsInventoryInfo() // دالة تملأ الحقول بمعلومات المنتج
        {
            if (_product == null) return; // اذا المنتج فارغ نطلع من الدالة
            cmbProdectName.Text = _product.productName; // نعرض اسم المنتج
            tbAvailableQuantity.Text = _product .Quantity.ToString(); // نعرض الكمية المتوفرة
        }

        private void frmAddProductToInventorey_Load(object sender, EventArgs e)
        {
            _clsInventory = new clsInventories(); // نهيئ كائن مخزون المنتج
            _FillProductsInventoryInfo(); // نملأ معلومات المنتج
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // اذا الحقول بيها خطأ
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نوقف العملية
            }

            int availableQty = int.Parse(tbAvailableQuantity.Text); // نحول النصوص لعدد
            decimal _PurchasePrice = decimal.Parse(tbPurchase_price.Text); // سعر الشراء
            decimal _SellingPrice = decimal.Parse(tbSelling_price.Text); // سعر البيع
            int _MinStockAlert = int.Parse(tbMin_stock_alert.Text); // الحد الادنى

            _clsInventory.product_id = _product.productID; // نخزن البيانات بالكائن
            _clsInventory.available_quantity = availableQty;
            _clsInventory.purchase_price = _PurchasePrice;
            _clsInventory.selling_price = _SellingPrice;
            _clsInventory.min_stock_alert = _MinStockAlert;
            _clsInventory.vendor_name = tbVendor_name.Text;
            _clsInventory.last_purchase_date = dtpLast_purchase_date.Value;



            if (_clsInventory.Save()) // اذا حفظنا البيانات
            {
                lbInventoryID.Text = _clsInventory.ID.ToString(); // نعرض رقم المنتج
                lbAddAndEdit.Text = " تعديل منتج المخزن"; // نغير النص لتعديل


                MessageBox.Show("تم حفظ معلومات  المنتج", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); // رسالة نجاح
                this.Close(); // نغلق الفورم

            }
            else
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة فشل
                this.Close(); // نغلق الفورم

            }
        }

        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close(); // نغلق الفورم
        }

        private void tbPurchase_price_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPurchase_price.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbPurchase_price, "من فضلك سعر شراء المنتج");
            }
            else
                errorProviderProductsInventory.SetError(tbPurchase_price, "");
        }

        private void tbSelling_price_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbSelling_price.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbSelling_price, "من فضلك سعر بيع المنتج");
            }
            else
                errorProviderProductsInventory.SetError(tbSelling_price, "");

    }

        private void tbMin_stock_alert_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbMin_stock_alert.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbMin_stock_alert, "من فضلك رقم اقل عدد قطع المنتج لتنبيهك");
            }
            else
                errorProviderProductsInventory.SetError(tbMin_stock_alert, "");

    }

        private void tbVendor_name_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbVendor_name.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbVendor_name, "من فضلك اسم المورد");
            }
            else
                errorProviderProductsInventory.SetError(tbVendor_name, "");

    }

        private void tbPurchase_price_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        

    }

        private void tbSelling_price_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        

    }

        private void tbMin_stock_alert_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
        }

    }
}
}
