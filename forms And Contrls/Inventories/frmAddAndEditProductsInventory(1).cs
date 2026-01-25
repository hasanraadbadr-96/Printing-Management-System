using BusinessLayeres; // نستدعي الطبقة اللي تحتوي الكلاسات الخاصة بالمنطق
using ETEZAN2024.forms_And_Contrls.Products; // نستدعي الفورمات والكنترولز الخاصة بالمنتجات
using System; // مكتبة الاساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة تساعدنا بالتحقق من القيم مثل Validating
using System.Data; // مكتبة التعامل مع الجداول
using System.Drawing; // مكتبة الرسوميات
using System.Linq; // مكتبة LINQ للاستعلامات
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة العمليات غير المتزامنة
using System.Windows.Forms; // مكتبة واجهة الويندوز فورمز

namespace ETEZAN2024.forms_And_Contrls.Inventories // فضاء الاسماء الخاص بالمشروع
{
    public partial class frmAddAndEditProductsInventory : Form // تعريف الفورم
    {
        public enum enMode // نعرف نوع بيانات (تعداد) يحدد وضع الفورم
        {
            Add = 1, // وضع اضافة
            Update = 2 // وضع تعديل
        }
        enMode _mode; // متغير خاص لتخزين الوضع الحالي للفورم
        private int _InventoryID = 1; // متغير يخزن معرف المنتج (ID)، اولياً 1
        private clsInventories _clsInventory; // كائن يمثل المنتج من كلاس المخازن

        public frmAddAndEditProductsInventory() // كونستركتر بدون باراميترات
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _mode = enMode.Add; // نخلي الوضع افتراضياً اضافة
        }

        public frmAddAndEditProductsInventory(int InventoryID) // كونستركتر ويا باراميتر
        {
            InitializeComponent(); // تهيئة المكونات
            _mode = enMode.Update; // نخلي الوضع تحديث
            _InventoryID = InventoryID; // نخزن الـ ID اللي اجا من الاستدعاء
        }
        private void _FillComboBoxByProdectName() // دالة تملي ComboBox بأسماء المنتجات
        {
            DataTable dtProducts = clsProducts.GetAllProductsList(); // نجيب كل المنتجات من قاعدة البيانات
            cmbProdectName.DataSource = dtProducts; // نخلي مصدر البيانات هو الجدول
            cmbProdectName.DisplayMember = "اسم المنتج"; // نخلي العرض باسم المنتج
            cmbProdectName.ValueMember = "معرف المنتج"; // نخلي القيمة الداخلية هي ProductID

        }
        private void _FillTexetAvailableQuantityBoxByProdectQuantity(int ProductID) // دالة تجيب سعر المنتج
        {
            if (cmbProdectName.SelectedItem == null || cmbProdectName.SelectedValue == null) // اذا ما مختار منتج
                return; // نوقف الدالة

            if (_clsInventory == null) // اذا بعد ماكو كائن للطلب
                _clsInventory = new clsInventories(); // ننشئ كائن جديد
            clsProducts product = clsProducts.FindProduct(ProductID); // نجيب معلومات المنتج حسب الـ ID

            if (product == null) // اذا المنتج ما موجود
            {
                tbAvailableQuantity.Text = ""; // نفرغ حقل الكمية
                MessageBox.Show("هذا المنتج غير موجود او نافذ ", "خطاء",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning); // رسالة تحذير
                return; // نوقف الدالة
            }

            tbAvailableQuantity.Text = product.Quantity.ToString("N0"); // نعرض الكمية بصيغة مرتبة
        }


        private void _ResetDefualtValues() // دالة ترجع القيم الافتراضية للفورم
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                lbAddAndEdit.Text = "اضافة منتج للمخزن"; // نخلي النص اضافة
                _clsInventory = new clsInventories(); // ننشئ كائن جديد
                lnkAddProduct.Enabled = true; // نخلي رابط اضافة منتج شغال
                return; // نطلع من الدالة
            }

            lbInventoryID.Text = "###"; // نرجع المعرف ###
            cmbProdectName.SelectedIndex = 0; // نرجع الكومبو للاول

            tbAvailableQuantity.Text = ""; // نفرغ الحقول
            tbPurchase_price.Text = "";
            tbSelling_price.Text = "";
            tbMin_stock_alert.Text = "";
            tbVendor_name.Text = "";

            dtpLast_purchase_date.Value = DateTime.Now; // نرجع التاريخ لتاريخ اليوم
        }

        private void _FillProductsInventoryInfo() // دالة تملأ الحقول بمعلومات المنتج
        {
            lbAddAndEdit.Text = "تعديل منتج المخزن"; // نخلي النص تعديل
            lbInventoryID.Text = _clsInventory.ID.ToString(); // نعرض معرف المنتج
            cmbProdectName.Text = _clsInventory.ProductInfo.productName; // نعرض اسم المنتج
            tbAvailableQuantity.Text = _clsInventory.available_quantity.ToString(); // نعرض الكمية المتوفرة
            tbPurchase_price.Text = _clsInventory.purchase_price.ToString(); // نعرض سعر الشراء
            tbSelling_price.Text = _clsInventory.selling_price.ToString(); // نعرض سعر البيع
            tbMin_stock_alert.Text = _clsInventory.min_stock_alert.ToString(); // نعرض الحد الادنى
            dtpLast_purchase_date.Text = _clsInventory.last_purchase_date.ToString(); // نعرض تاريخ اخر شراء
            tbVendor_name.Text = _clsInventory.vendor_name.ToString(); // نعرض اسم المورد
            lnkAddProduct.Enabled = false; // نغلق رابط اضافة منتج
        }

        private void _LoadData() // دالة تحميل البيانات
        {
            _clsInventory = clsInventories.Find(_InventoryID); // نبحث عن المنتج بالـ ID
            if (_clsInventory == null) // اذا ما لكينا
            {
                _ResetDefualtValues(); // نفرغ الحقول
                MessageBox.Show("لم يتم العثور علئ هذا المنتج", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                this.Close(); // نسد الفورم
                return; // نطلع
            }
            _FillProductsInventoryInfo(); // نملأ الحقول
        }

        private void frmAddAndEditProductsInventory_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _FillComboBoxByProdectName(); // نعرض اسم المنتج داله
            // نحدد اول عنصر بالكومبو بوكس
            if (cmbProdectName.Items.Count > 0)
            {
                cmbProdectName.SelectedIndex = 0;
            }


            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue); // نحول القيمة المحددة الى ID
            _FillTexetAvailableQuantityBoxByProdectQuantity(ProductID); // نعرض الكمية

            if (_mode == enMode.Update) // اذا الوضع تحديث
                _LoadData(); // نجيب البيانات
            else
                _ResetDefualtValues(); // نخلي قيم افتراضية
        }

        private void tbProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // حالياً ماكو شرط خاص للكتابة داخل اسم المنتج
        }

        private void tbAvailableQuantity_KeyPress(object sender, KeyPressEventArgs e) // حدث للكتابة داخل التكست
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbProductName_Validating(object sender, CancelEventArgs e) // تحقق من الحقل
        {
            // التعليقات مؤقتة، مو مفعلين حالياً
        }

        private void tbAvailableQuantity_Validating(object sender, CancelEventArgs e) // تحقق من الكمية المتوفرة
        {
            // التعليقات مؤقتة، مو مفعلين حالياً
        }

        private void tbUsedQuantity_Validating(object sender, CancelEventArgs e)
        {
            int availableQuantity = 0;
            int usedQuantity = 0;

            if (!int.TryParse(tbAvailableQuantity.Text, out availableQuantity)) // اذا الكمية غير صالحة
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderProductsInventory.SetError(tbAvailableQuantity, "الكمية المتوفرة غير صحيحة"); // رسالة خطأ
                return;
            }
            else
                errorProviderProductsInventory.SetError(tbAvailableQuantity, ""); // نرجع فارغ اذا صحيح

            if (string.IsNullOrEmpty(tbMin_stock_alert.Text) || !int.TryParse(tbMin_stock_alert.Text, out usedQuantity)) // التحقق من عدد القطع المستعملة
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbMin_stock_alert, "من فضلك ادخل عدد قطع المنتج بصيغة صحيحة");
                return;
            }
            else
                errorProviderProductsInventory.SetError(tbMin_stock_alert, "");

            if (usedQuantity > availableQuantity) // اذا تجاوز المستعمل المتوفر
            {
                e.Cancel = true;
                MessageBox.Show("عدد قطع المستخدمه اكبر من القطع المتوفره", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                errorProviderProductsInventory.SetError(tbMin_stock_alert, "عدد قطع المستخدمه اكبر من القطع المتوفره");
            }
            else
                errorProviderProductsInventory.SetError(tbMin_stock_alert, "");
        }

        private void btaCansel2_Click(object sender, EventArgs e) // زر الغاء
        {
            this.Close(); // نسد الفورم
        }

        private void btnSave_Click(object sender, EventArgs e) // زر الحفظ
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
            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue); // نحول المنتج الى معرف

            _clsInventory.product_id = ProductID; // نخزن البيانات بالكائن
            _clsInventory.available_quantity = availableQty;
            _clsInventory.purchase_price = _PurchasePrice;
            _clsInventory.selling_price = _SellingPrice;
            _clsInventory.min_stock_alert = _MinStockAlert;
            _clsInventory.vendor_name = tbVendor_name.Text;
            _clsInventory.last_purchase_date = dtpLast_purchase_date.Value;

            if (_mode == enMode.Add) // اذا وضع اضافة
            {
                if (clsInventories.isExistByProductID(_clsInventory.product_id)) // اذا موجود
                {
                    MessageBox.Show(" هذا المنتج موجود بالمخزن!! من فضلك اختر اسم منتج اخر", "خطاء",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProviderProductsInventory.SetError(cmbProdectName, " هذا المنتج موجود بالمخزن!! من فضلك اختر اسم منتج اخر");
                    return;
                }
                else
                    errorProviderProductsInventory.SetError(cmbProdectName, "");
            }

            if (_clsInventory.Save()) // اذا حفظنا البيانات
            {
                lbInventoryID.Text = _clsInventory.ID.ToString(); // نعرض رقم المنتج
                lbAddAndEdit.Text = " تعديل منتج المخزن"; // نغير النص لتعديل
                if (_mode == enMode.Update)
                    lnkAddProduct.Enabled = false; // نغلق رابط اضافة
                else
                    lnkAddProduct.Enabled = true; // نفتح رابط اضافة

                _mode = enMode.Update; // نخلي الوضع تحديث
                MessageBox.Show("تم حفظ معلومات  المنتج", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); // رسالة نجاح
            }
            else
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة فشل
        }

        private void tbPurchase_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbSelling_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbMin_stock_alert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbPurchase_price_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPurchase_price.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbPurchase_price, "من فضلك سعر شراء المنتج");
            }
            else
                errorProviderProductsInventory.SetError(tbPurchase_price, "");
        }

        private void tbSelling_price_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSelling_price.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderProductsInventory.SetError(tbSelling_price, "من فضلك سعر بيع المنتج");
            }
            else
                errorProviderProductsInventory.SetError(tbSelling_price, "");
        }

        private void tbMin_stock_alert_Validating(object sender, CancelEventArgs e)
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

        private void lnkAddProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEidtProduct frmAdd = new frmAddAndEidtProduct(); // فتح نافذة اضافة
            frmAdd.ShowDialog(); // عرضها كحوار
            _FillComboBoxByProdectName(); // نعيد ملئ الكومبو بوكس

            if (cmbProdectName.Items.Count > 0) // اذا عدنه عناصر
                cmbProdectName.SelectedIndex = cmbProdectName.Items.Count - 1; // نحدد اخر عنصر
        }

        private void cmbProdectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdectName.SelectedValue == null) // اذا لا قيمة مختارة
                return;

            if (cmbProdectName.SelectedValue is DataRowView) // تجاهل اذا DataRowView
                return;

            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue); // نحول القيمة الى ID

            if (_mode == enMode.Add) // اذا وضع اضافة
            {
                if (clsInventories.isExistByProductID(ProductID)) // اذا موجود
                    errorProviderProductsInventory.SetError(cmbProdectName, " هذا المنتج موجود بالمخزن!! من فضلك اختر اسم منتج اخر");
                else
                    errorProviderProductsInventory.SetError(cmbProdectName, "");
            }
            else // وضع تعديل
            {
                if (clsInventories.isExistByProductID(ProductID) && _clsInventory.product_id != ProductID)
                    errorProviderProductsInventory.SetError(cmbProdectName, $"هذا المنتج موجود بالمخزن!!\nمن فضلك اختر اسم المنتج :- [{_clsInventory.ProductInfo.productName}]");
                else
                    errorProviderProductsInventory.SetError(cmbProdectName, "");
            }

            _FillTexetAvailableQuantityBoxByProdectQuantity(ProductID); // نعرض الكمية
        }

        private void cmbProdectName_Validating(object sender, CancelEventArgs e)
        {
            if (cmbProdectName.SelectedValue == null)
                return;

            if (cmbProdectName.SelectedValue is DataRowView)
                return;

            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue);

            if (_mode == enMode.Update)
            {
                if (clsInventories.isExistByProductID(ProductID) && _clsInventory.product_id != ProductID)
                {
                    MessageBox.Show($"هذا المنتج موجود بالمخزن!!\nمن فضلك اختر اسم المنتج :- [{_clsInventory.ProductInfo.productName}]", "خطاء",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    errorProviderProductsInventory.SetError(cmbProdectName, $"هذا المنتج موجود بالمخزن!!\nمن فضلك اختر اسم المنتج :- [{_clsInventory.ProductInfo.productName}]");
                }
                else
                    errorProviderProductsInventory.SetError(cmbProdectName, "");
            }
            else
            {
                if (clsInventories.isExistByProductID(ProductID))
                    errorProviderProductsInventory.SetError(cmbProdectName, " هذا المنتج موجود بالمخزن!! من فضلك اختر اسم منتج اخر");
                else
                    errorProviderProductsInventory.SetError(cmbProdectName, "");
            }
        }
    }
}
