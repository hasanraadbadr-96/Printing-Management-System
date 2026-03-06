using BusinessLayeres; // نستدعي طبقة الاعمال (Business Layer) حتى نستخدم الكلاسات اللي تدير البيانات
using ETEZAN2024.forms_And_Contrls.Persons.Control; // نستدعي فورم/كنترول خاص بالأشخاص
using ETEZAN2024.forms_And_Contrls.Products.forms;
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة للأحداث مثل Validating
using System.Data; // مكتبة للتعامل مع الداتا
using System.Diagnostics.Eventing.Reader;
using System.Drawing; // مكتبة للرسم والتصميم
using System.Linq; // مكتبة للعمليات على المجموعات
using System.Text; // مكتبة للنصوص
using System.Threading.Tasks; // مكتبة للمهام
using System.Windows.Forms; // مكتبة لواجهات الفورمات

namespace ETEZAN2024.forms_And_Contrls.Products // نيم سبيس خاص بالفورمات والمنتجات
{
    public partial class frmAddAndEidtProduct : Form // تعريف فورم اسمه frmAddAndEidtProduct
    {
        enum enMode // نعرف Enum يحدد وضع الفورم
        {
            Add = 1, Update = 2 // اما اضافة او تعديل
        }
        enMode _mode ; // متغير داخلي يمثل الوضع الحالي، افتراضياً اضافة
        private int _ProductID; // خزن رقم المنتج الداخلي
        private clsProducts _Product; // خزن بيانات المنتج من الكلاس
        public int ProductID // خاصية عامة تعرض رقم المنتج
        {
            get { return _ProductID; } // دالة get ترجع قيمة رقم المنتج
        }
        public clsProducts ProductInfo // خاصية عامة تعرض معلومات المنتج كاملة
        {
            get { return _Product; } // ترجع الكائن مال المنتج
        }
        public frmAddAndEidtProduct() // كونستركتر اول (لما يكون اضافة)
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _mode = enMode.Add; // نخلي الوضع اضافة
        }
        public frmAddAndEidtProduct(int ProductID) // كونستركتر ثاني (لما يكون تعديل)
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _ProductID = ProductID; // نخزن رقم المنتج اللي نريد نعدله
            _mode = enMode.Update; // نخلي الوضع تعديل
        }
        private void _ResetDefualtValues() // دالة تعيين القيم الافتراضية للفورم
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                lbAddAndEdit.Text = "اضافة منتج"; // نخلي النص يبين انه اضافة
                _Product = new clsProducts(); // نهيئ منتج جديد
                return; // نطلع من الدالة
            }
            lbProductID.Text = "####"; // نخلي ID placeholder
            tbProductName.Text = ""; // نفرغ حقل الاسم
            tbProduct_type.Text = ""; // نفرغ السعر
            tbSize.Text = ""; // نفرغ السعر
            tbWeight.Text = ""; // نفرغ السعر
            tbQuantity.Text = ""; // نفرغ السعر


        }
        private void _FillProductInfo() // دالة تملأ بيانات المنتج لما يكون تعديل
        {
            lbAddAndEdit.Text = "تعديل منتج"; // نخلي النص تعديل
            lbProductID.Text = _Product.productID.ToString(); // نعرض رقم المنتج
            tbProductName.Text = _Product.productName; // نعرض الاسم
            tbProduct_type.Text = _Product.productType.ToString(); // نعرض السعر
            tbSize.Text = _Product.Size; // نعرض الاسم
            tbWeight.Text = _Product.Weight; // نعرض الاسم
            tbQuantity.Text = _Product.Quantity.ToString(); // نعرض الاسم

        }
        private void _LoadData() // دالة تحميل بيانات المنتج من قاعدة البيانات
        {
            _Product = clsProducts.FindProduct(ProductID); // نجيب المنتج حسب ID
            if (_Product == null) // اذا رجع منتج
            {
                _ResetDefualtValues(); // نفرغ القيم (هنا خطأ منطقي المفروض العكس)
                MessageBox.Show("لم يتم العثور علئ هذا المنتج", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                this.Close(); // نغلق الفورم
                return; // نطلع
            }
            _FillProductInfo(); // نعرض البيانات
        }
        private void frmAddAndEidtProduct_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            if (_mode == enMode.Update) // اذا تعديل
            {
                _LoadData(); // نجيب البيانات
            }
            else
            {
                _ResetDefualtValues(); // نفرغ الحقول

            }

        }
        private void tbProductName_Validating(object sender, CancelEventArgs e) // تحقق من اسم المنتج
        {
            if (string.IsNullOrEmpty(tbProductName.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderProducts.SetError(tbProductName, "من فضلك ادخل اسم المنتج"); // نعرض خطأ
            }
            else
                errorProviderProducts.SetError(tbProductName, ""); // نخلي فارغ
            if (_mode == enMode.Add)
            {
                if (clsProducts.isExistByproductName(tbProductName.Text)) // اذا الاسم موجود مسبقاً
                {
                    MessageBox.Show("  هذا المنتج موجود بقائمه المنتجات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); // تحذير
                    e.Cancel = true; // نوقف الانتقال
                    errorProviderProducts.SetError(tbProductName, " هذا المنتج موجود "); // نعرض خطأ
                }
                else
                    errorProviderProducts.SetError(tbProductName, ""); // ماكو خطأ 
            }
            else
            {
                if (tbProductName.Text != _Product.productName) // اذا الاسم موجود مسبقاً
                {
                    if (clsProducts.isExistByproductName(tbProductName.Text)) // اذا الاسم موجود مسبقاً
                    {
                        MessageBox.Show("  هذا المنتج موجود بقائمه المنتجات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning); // تحذير
                        e.Cancel = true; // نوقف الانتقال
                        errorProviderProducts.SetError(tbProductName, " هذا المنتج موجود "); // نعرض خطأ
                    }
                    else
                        errorProviderProducts.SetError(tbProductName, ""); // ماكو خطأ 
                }
            }
        }

        private void _AddProductTOInventorey() // دالة اضافة المنتج للمخزون
        {
            frmAddProductToInventorey frm = new frmAddProductToInventorey(_Product); // نهيئ الفورم مع تمرير المنتج
            frm.ShowDialog(); // نعرض الفورم كـ مودال
        }
        private void btnSaveOrderInfo_Click(object sender, EventArgs e) // حدث زر الحفظ
        {
            if (!this.ValidateChildren()) // اذا الحقول بيها خطأ
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نوقف
            }

            _Product.productName = tbProductName.Text; // نخزن الاسم
            _Product.productType = tbProduct_type.Text; // نخزن السعر كـ decimal

            //=====================================================
            //  المتغيرات الجديدة (إضافة فقط بدون أي تعديل آخر)
            //=====================================================
            _Product.productType = tbProduct_type.Text;
            _Product.Size = tbSize.Text;
            _Product.Weight = tbWeight.Text;
            _Product.Quantity = int.Parse(tbQuantity.Text);
            //=====================================================

    

            if (_Product.Save()) // اذا انحفظ
            {
          
                lbProductID.Text = _Product.productID.ToString(); // نعرض رقم المنتج

  

                lbAddAndEdit.Text = "تعديل منتج"; // نغير النص لتعديل
                _mode = enMode.Update; // نخلي الوضع تعديل
                MessageBox.Show("تم حفظ معلومات المنتج", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); // رسالة نجاح
                _AddProductTOInventorey(); // نضيف المنتج للمخزون


            }
            else
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة فشل
            }
        }

        private void btaCansel2_Click(object sender, EventArgs e) // حدث زر الالغاء
        {
            this.Close(); // نغلق الفورم
        }


        private void tbProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text)) // اذا فارغ
            {
                e.Cancel = true; // نوقف الانتقال
                errorProviderProducts.SetError(tbQuantity, "من فضلك اي رقم"); // نعرض خطأ
            }
            else
                errorProviderProducts.SetError(tbQuantity, "");
            // نخلي فارغ
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }// بس ارقام

        }
    } 
}
