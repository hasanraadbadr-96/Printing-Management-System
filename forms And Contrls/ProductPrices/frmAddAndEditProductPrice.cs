using BusinessLayeres; // نستورد الطبقة الخاصة بالمنطق التجاري (Business Layeres) حتى نكدر نتعامل ويا الكلاسات المرتبطة بالمنتجات
using System; // مكتبة الاساسيات
using System.Collections.Generic; // مكتبة للتعامل ويا الـ Lists و الـ Collections
using System.ComponentModel; // مكتبة للتحقق من المدخلات (Validation) وغيره
using System.Data; // مكتبة للتعامل ويا الجداول (DataTable)
using System.Drawing; // مكتبة للرسم والتحكم بالتصميم
using System.Linq; // مكتبة للاستعلامات LINQ
using System.Text; // مكتبة للتعامل ويا النصوص
using System.Threading.Tasks; // مكتبة للبرمجة الغير متزامنة
using System.Windows.Forms; // مكتبة الواجهات (Windows Forms)

namespace ETEZAN2024.forms_And_Contrls.ProductPrices // نحدد مساحة الأسماء (namespace) للمشروع
{
    public partial class frmAddAndEditProductPrice : Form // تعريف الفورم الرئيسي الخاص بإضافة وتعديل أسعار المنتجات
    {
        public enum enMode // نعرف نوع خاص يحدد وضع الفورم (إضافة أو تعديل)
        {
            Add = 1, // وضع إضافة
            Update = 2 // وضع تعديل
        }
        enMode _mode; // متغير داخلي يخزن وضع الفورم الحالي
        private int _PriceID = 1; // نخزن رقم السعر (ID)
        private clsProductPrices _ProductPrices; // كائن يمثل بيانات السعر للمنتج
        private string _ValueSize; // نخزن حجم المنتج
        public int PriceID // خاصية عامة ترجع رقم السعر
        {
            get { return _PriceID; }
        }
        public clsProductPrices productPricesInfo // خاصية عامة ترجع الكائن اللي يحتوي بيانات السعر
        {
            get { return _ProductPrices; }
        }
        public frmAddAndEditProductPrice() // كونستركتر للفورم بوضع إضافة
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _mode = enMode.Add; // نخلي الوضع إضافة
        }
        public frmAddAndEditProductPrice(int PriceID) // كونستركتر للفورم بوضع تعديل
        {
            InitializeComponent(); // تهيئة المكونات
            _mode = enMode.Update; // نخلي الوضع تعديل
            _PriceID = PriceID; // نخزن رقم السعر المراد تعديله
        }

        private void _ResetDefualtValues() // دالة ترجع القيم الافتراضية
        {
            if (_mode == enMode.Add)
            { // إذا الوضع إضافة
                lbAddAndEdit.Text = "اضافة سعر المنتج"; // نخلي النص اضافة
                _ProductPrices = new clsProductPrices(); // ننشئ كائن جديد للسعر
                return; // نطلع من الدالة
            }
            // اذا كان تعديل نفرغ الحقول
            lbProductPriceID.Text = "####";
            cmbProductName.Text = "";
            cmbProductSizes.Text = "";
            tbProductPrice.Text = "";
            tbOptions.Text = "";
            chkIsActive.Checked = false;
        }
        private void _FillProductPricesInfo() // دالة تملأ الحقول بمعلومات السعر
        {
            lbAddAndEdit.Text = "تعديل سعر المنتج"; // نخلي النص تعديل
            lbProductPriceID.Text = _ProductPrices.PriceID.ToString(); // نعرض رقم السعر
            cmbProductName.Text = _ProductPrices.productInfo.productName; // نعرض اسم المنتج
            cmbProductSizes.Text = _ProductPrices.Size; // نعرض الحجم
            tbProductPrice.Text = _ProductPrices.Price.ToString(); // نعرض السعر
            tbOptions.Text = _ProductPrices.Options; // نعرض الخيارات
            chkIsActive.Checked = _ProductPrices.IsActive; // نعرض حالة التفعيل
            tbQuantity.Text = _ProductPrices.Quantity.ToString(); // نعرض الكمية
        }
        private void _FillComboBoxByProductName() // دالة تملأ الكمبوبوكس باسماء المنتجات
        {
            DataTable dtProducts = clsProducts.GetAllProductsList(); // نجيب كل المنتجات من قاعدة البيانات
            cmbProductName.DataSource = dtProducts; // نخلي مصدر البيانات هو الجدول
            cmbProductName.DisplayMember = "اسم المنتج"; // نخلي العرض باسم المنتج
            cmbProductName.ValueMember = "رقم معرف المنتج"; // نخلي القيمة الداخلية رقم المنتج
        }
        private void _FillComboBoxByProductSize() // دالة تملأ الكمبوبوكس بالأحجام
        {
            cmbProductSizes.Items.Clear(); // نفرغ العناصر

            cmbProductSizes.Items.Add("صغير"); // نضيف صغير
            cmbProductSizes.Items.Add("وسط"); // نضيف وسط
            cmbProductSizes.Items.Add("كبير"); // نضيف كبير
            cmbProductSizes.Items.Add("مخصص 'ستيكرات'"); // نضيف مخصص
        }
        private void _FillComboBoxByStickerSize() // دالة تملأ كمبوبوكس بقياسات الستكرات
        {
            comboBoxStickerSizes.Items.Clear(); // نفرغ العناصر

            comboBoxStickerSizes.Items.Add("A5");
            comboBoxStickerSizes.Items.Add("A4");
            comboBoxStickerSizes.Items.Add("A3");
            comboBoxStickerSizes.Items.Add("رولة 30 سم × 12 متر");
            comboBoxStickerSizes.Items.Add("رولة 45 سم × 3 متر");
            comboBoxStickerSizes.Items.Add("رولة 60 سم × 3 متر");
            comboBoxStickerSizes.Items.Add("رولة 60 سم × 5 متر");
            comboBoxStickerSizes.Items.Add("رولة 60 سم × 10 متر");
            comboBoxStickerSizes.Items.Add("رولة 90 سم × 5 متر");
            comboBoxStickerSizes.Items.Add("رولة 100 سم × 5 متر");
            comboBoxStickerSizes.Items.Add("رولة 120 سم × 5 متر");
        }
        private void _ApplyFillterProductSize(string columnName) // دالة تحدد شنو نعرض من الكمبوبوكس
        {
            if (columnName == "مخصص 'ستيكرات'") // إذا اختار مخصص
            {
                comboBoxStickerSizes.Visible = true; // نظهر الكمبوبوكس مال الستكرات
                _ValueSize = comboBoxStickerSizes.Text; // نخزن القيمة
            }
            else
            {
                comboBoxStickerSizes.Visible = false; // نخفي الكمبوبوكس
                _ValueSize = cmbProductSizes.Text; // نخزن القيمة العادية
            }
        }
        private void _LoadData() // دالة تحميل بيانات السعر
        {
            _ProductPrices = clsProductPrices.Find(_PriceID); // نجيب بيانات السعر حسب الـ ID
            if (_ProductPrices == null) // إذا ما لكينا شي
            {
                _ResetDefualtValues(); // نفرغ القيم
                MessageBox.Show("لم يتم العثور علئ هذا المنتج", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                this.Close(); // نغلق الفورم
                return; // نطلع
            }
            _FillProductPricesInfo(); // نملأ البيانات بالفورم
        }
        private void btaCansel2_Click(object sender, EventArgs e) // زر إلغاء
        {
            this.Close(); // نغلق الفورم
        }

        private void tbProductPrice_KeyPress(object sender, KeyPressEventArgs e) // حدث لمن المستخدم يكتب بسعر المنتج
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }

        private void tbProductPrice_Validating(object sender, CancelEventArgs e) // تحقق من الحقل اذا فارغ
        {
            if (string.IsNullOrEmpty(tbProductPrice.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderProductPrices.SetError(tbProductPrice, "من فضلك ادخل سعر المنتج"); // نعرض خطأ
            }
            else
                errorProviderProductPrices.SetError(tbProductPrice, ""); // نخلي فارغ
        }

        private void btnSave_Click(object sender, EventArgs e) // حدث زر الحفظ
        {
            if (!this.ValidateChildren()) // اذا الحقول بيها خطأ
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نوقف
            }
            _ProductPrices.Price = decimal.Parse(tbProductPrice.Text); // نخزن السعر
            _ProductPrices.Size = _ValueSize; // نخزن الحجم
            _ProductPrices.IsActive = chkIsActive.Checked; // نخزن حالة التفعيل
            _ProductPrices.Options = tbOptions.Text; // نخزن الخيارات
            _ProductPrices.Quantity = int.Parse(tbQuantity.Text); // نخزن الكمية
            _ProductPrices.ProductID = Convert.ToInt32(cmbProductName.SelectedValue);  // يجيب ProductID
            if (_ProductPrices.Save()) // اذا انحفظ
            {
                lbProductPriceID.Text = _ProductPrices.PriceID.ToString(); // نعرض رقم المنتج
                lbAddAndEdit.Text = "تعديل سعر المنتج"; // نغير النص لتعديل
                _mode = enMode.Update; // نخلي الوضع تعديل
                MessageBox.Show("تم حفظ معلومات سعر المنتج", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); // رسالة نجاح
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة فشل
            }
        }

        private void frmAddAndEditProductPrice_Load(object sender, EventArgs e) // عند تحميل الفورم
        {
            _FillComboBoxByProductName(); // نملأ اسماء المنتجات
            _FillComboBoxByProductSize(); // نملأ الاحجام
            _FillComboBoxByStickerSize(); // نملأ قياسات الستكرات
            cmbProductName.SelectedIndex = 0; // نحدد اول عنصر
            cmbProductSizes.SelectedIndex = 0; // نحدد اول عنصر
            comboBoxStickerSizes.SelectedIndex = 0; // نحدد اول عنصر
            if (_mode == enMode.Update) // اذا تعديل
            {
                _LoadData(); // نحمل البيانات
            }
            else
            {
                _ResetDefualtValues(); // نفرغ الحقول
            }
        }

        private void cmbProductSizes_SelectedIndexChanged(object sender, EventArgs e) // حدث تغيير الحجم
        {
            _ApplyFillterProductSize(cmbProductSizes.Text); // نطبق الفلتر
        }

        private void comboBoxStickerSizes_SelectedIndexChanged(object sender, EventArgs e) // حدث تغيير حجم الستكر
        {
            _ApplyFillterProductSize(cmbProductSizes.Text); // نطبق الفلتر
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // اذا مو رقم
            {
                e.Handled = true; // نمنع الكتابة
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
            }
        }
    }
}
