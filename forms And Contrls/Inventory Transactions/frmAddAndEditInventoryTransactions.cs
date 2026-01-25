using BusinessLayeres; // نستدعي الطبقة التجارية (Business Layer) اللي تحتوي على الكلاسات الي تدير البيانات
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // نستدعي مكتبة الفورمز لإنشاء واجهات المستخدم

namespace ETEZAN2024.forms_And_Contrls.Inventory_Transactions
{
    // تعريف الفورم الخاص بإضافة وتعديل حركة المخزون
    public partial class frmAddAndEditInventoryTransactions : Form
    {
        clsInventoryTransactions _InventoryTransaction; // كلاس يمثل حركة المخزون الحالية
        int _InventoryTransactionID = -1; // رقم تعريف الحركة، -1 يعني جديدة

        // تعريف الوضعية الحالية للفورم (اضافة أو تعديل)
        public enum enMode
        {
            Add = 1, // وضع إضافة
            Update = 2 // وضع تعديل
        }

        enMode _mode; // المتغير اللي يخزن وضع الفورم الحالي

        // الكونستركتور الافتراضي للفورم (وضع اضافة)
        public frmAddAndEditInventoryTransactions()
        {
            InitializeComponent(); // تهيئة الفورم وعناصره
            _mode = enMode.Add; // نحدد الوضع الافتراضي إضافة
        }

        // الكونستركتور للفورم مع تحديد ID للحركة (وضع تعديل)
        public frmAddAndEditInventoryTransactions(int InventoryTransactionID)
        {
            InitializeComponent(); // تهيئة الفورم وعناصره
            _InventoryTransactionID = InventoryTransactionID; // نحفظ رقم الحركة
            _mode = enMode.Update; // نحدد الوضع تعديل
        }

        // دالة لإعادة ضبط القيم الافتراضية للفورم
        private void _ResetDefualtValues()
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                _InventoryTransaction = new clsInventoryTransactions(); // نعمل كائن جديد
                lbAddAndEdit.Text = "اضافة جرد لحركة المخزون"; // نغير عنوان الفورم
                return; // نرجع بدون تنفيذ الباقي
            }

            // اذا الوضع تعديل، نفضي الحقول
            lbInventoryID.Text = "####"; // نص افتراضي لرقم الحركة
            cmbProdectName.Text = ""; // نفرغ اسم المنتج
            cmbTypeInventoryTransaction.Text = ""; // نفرغ نوع الحركة
            tbQuantity.Text = ""; // نفرغ الكمية
            tbQuantity.Text = ""; // نفرغ الكمية

            dtpdate.Value = DateTime.MinValue; // نرجع التاريخ للصفر
        }

        // دالة لملء الحقول بالمعلومات من الكائن الحالي
        private void _FillTexetBoxsByInventoryTransactionInfo()
        {
            lbAddAndEdit.Text = "تعديل معلومات جرد لحركة المخزون"; // نغير العنوان
            lbInventoryID.Text = _InventoryTransaction.transaction_id.ToString(); // نعرض رقم الحركة
            cmbProdectName.Text = _InventoryTransaction.ProductInfo.productName; // نعرض اسم المنتج
            cmbTypeInventoryTransaction.Text = _InventoryTransaction.type; // نعرض نوع الحركة
            tbQuantity.Text = _InventoryTransaction.quantity.ToString(); // نعرض الكمية
            dtpdate.Value = _InventoryTransaction.date; // نعرض التاريخ
            tbOrderItemID.Text = _InventoryTransaction.Order_ItemID.ToString(); // نعرض الكمية

        }

        // دالة لملء قائمة المنتجات في الكمبوبوكس
        private void _FillComboBoxByProdcutsName()
        {
            cmbProdectName.Items.Clear(); // نفرغ العناصر القديمة

            cmbProdectName.DataSource = clsProducts.GetAllProductsList(); // نجيب كل المنتجات
            cmbProdectName.DisplayMember = "اسم المنتج"; // العرض يكون الاسم
            cmbProdectName.ValueMember = "معرف المنتج"; // القيمة تكون ID المنتج
        }

        // دالة لملء نوع الحركة في الكمبوبوكس

        // دالة لتحميل بيانات الحركة عند التعديل
        private void _LoadData()
        {
            _InventoryTransaction = clsInventoryTransactions.Find(_InventoryTransactionID); // نجيب الحركة من قاعدة البيانات
            if (_InventoryTransaction == null) // اذا ما موجودة
            {
                _ResetDefualtValues(); // نعيد القيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا الجرد", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                this.Close(); // نقفل الفورم
                return;
            }
            _FillTexetBoxsByInventoryTransactionInfo(); // نملأ الحقول بالبيانات
        }

        // الحدث عند تحميل الفورم
        private void frmAddAndEditInventoryTransactions_Load(object sender, EventArgs e)
        {
            _FillComboBoxByProdcutsName(); // نملأ قائمة المنتجات
          clsGlobal .FillComboBoxTypeInventoryTransactionInfo(cmbTypeInventoryTransaction); // نملأ قائمة نوع الحركة
            if (cmbProdectName.Items.Count > 0)
            {
                cmbProdectName.SelectedIndex = 0;
            }
            if (cmbTypeInventoryTransaction.Items.Count > 0)
            {
                cmbTypeInventoryTransaction.SelectedIndex = 2; // نحدد نوع الحركة الافتراضي
            }

            if (_mode == enMode.Update) // اذا الوضع تعديل
            {
                _LoadData(); // نجيب بيانات الحركة
            }
            else // اذا الوضع اضافة
            {
                _ResetDefualtValues(); // نعيد القيم الافتراضية
            }
        }

        // زر إلغاء
        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close(); // نقفل الفورم
        }

        // زر الحفظ
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // اذا الحقول غير صالحة
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // نرجع بدون حفظ
            }

            // نحول قيمة المنتج من الكمبوبوكس بشكل آمن
            if (cmbProdectName.SelectedValue == null ||
                !int.TryParse(cmbProdectName.SelectedValue.ToString(), out int productID))
            {
                MessageBox.Show("الرجاء اختيار منتج صالح", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // نحول قيمة الكمية بشكل آمن
            if (!int.TryParse(tbQuantity.Text, out int qty))
            {
                MessageBox.Show("الرجاء إدخال كمية رقمية صحيحة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbOrderItemID.Text, out int OrderItemID))
            {
                MessageBox.Show("الرجاء إدخال كمية رقمية صحيحة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // حفظ القيم في الكائن
            _InventoryTransaction.product_id = productID; // رقم المنتج
            _InventoryTransaction.type = cmbTypeInventoryTransaction.Text; // نوع الحركة
            _InventoryTransaction.quantity = qty; // الكمية
            _InventoryTransaction.date = dtpdate.Value; // التاريخ
            _InventoryTransaction.Order_ItemID = OrderItemID;
            if (_InventoryTransaction.Save()) // اذا تم الحفظ
            {
                lbInventoryID.Text = _InventoryTransaction.transaction_id.ToString(); // نعرض رقم الحركة
                lbAddAndEdit.Text = "تعديل معلومات جرد لحركة المخزون"; // نغير العنوان
                _mode = enMode.Update; // نخلي الوضع تعديل
                MessageBox.Show("تم حفظ معلومات الحركة", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // اذا ما تم الحفظ
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // التحقق من صحة حقل الكمية عند الخروج منه
        private void tbQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال للحقل التالي
                errorProviderProductsInventory.SetError(tbQuantity, "من فضلك ادخل عدد الكمية المتاثرة"); // نعرض رسالة خطأ
            }
            else
                errorProviderProductsInventory.SetError(tbQuantity, ""); // نزيل رسالة الخطأ
        }

        // الحدث لمنع إدخال أي شيء غير أرقام
        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbOrderID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOrderItemID.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال للحقل التالي
                errorProviderProductsInventory.SetError(tbOrderItemID, "من فضلك ادخل رقم الطب"); // نعرض رسالة خطأ
            }
            else
                errorProviderProductsInventory.SetError(tbOrderItemID, ""); // نزيل رسالة الخطأ

            if (!int.TryParse(tbOrderItemID.Text, out int OrderItemID))
            {
                MessageBox.Show("الرجاء إدخال كمية رقمية صحيحة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //نتحقق من رقم اذا ماموجود نطلعلة رساله ما موجود لازم يدخل طلب موجود
            if (!clsOrderItems.isExist(OrderItemID))
            {
                    e.Cancel = true; // نوقف الانتقال للحقل التالي
                    errorProviderProductsInventory.SetError(tbOrderItemID, "هذا الطلب غير موجود , من فضلك ادخل رقم طلب موجود مسبقا"); // نعرض رسالة خطأ
                MessageBox.Show("هذا عنصر الطلب غير موجود , من فضلك ادخل رقم عنصر طلب موجود مسبقا", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
                errorProviderProductsInventory.SetError(tbOrderItemID, ""); // نزيل رسالة الخطأ
        }

        private void tbOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }

        }
    }
}
