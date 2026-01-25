using BusinessLayeres; // نستدعي الطبقة الخاصة بالعمليات التجارية (Business Layer)
using ETEZAN2024.forms_And_Contrls.Products.forms; // نستدعي الفورمات الخاصة بالمنتجات
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة مكونات النماذج
using System.Data; // مكتبة التعامل مع قواعد البيانات والجداول
using System.Drawing; // مكتبة الرسومات
using System.Linq; // مكتبة الاستعلامات LINQ
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام المتزامنة
using System.Windows.Forms; // مكتبة النماذج (Windows Forms)

namespace ETEZAN2024.forms_And_Contrls.Products // فضاء الأسماء الخاص بالمنتجات
{
    public partial class frmcProductsList : Form // كلاس الفورم الرئيسي لعرض المنتجات
    {
        DataTable _dtProductList; // جدول يخزن المنتجات كلها
        DataView _dvProductList; // عرض بيانات قابل للتصفية (فلترة)
        public frmcProductsList() // كونستركتر للفورم
        {
            InitializeComponent(); // تهيئة المكونات
        }
        private void _RefreshProductsList() // دالة تحديث قائمة المنتجات
        {
            // 1. جلب قائمة المنتجات من الطبقة التجارية وربطها بالـ DataGridView
            dgvAllProducts.DataSource = clsProducts.GetAllProductsList();

            // 2. التحقق من أن الجدول فارغ (لا بيانات أو NULL)
            if (dgvAllProducts.DataSource == null || dgvAllProducts.Rows.Count == 0)
            {
                // تعطيل قائمة السياق لأنه لا توجد عناصر لإدارتها
                ctmsProductsManagement.Enabled = false;

                // تعطيل الفلتر لأنه لا توجد بيانات للبحث
                cmbFilterProductInfo.Enabled = false;

                // عرض عدد المنتجات = صفر
                lbProductsCount.Text = "0";

                // الخروج من الدالة لتجنب أخطاء الوصول للأعمدة
                return;
            }

            // 3. ضبط عرض الأعمدة بعد التأكد من وجودها
            if (dgvAllProducts.Columns.Count > 0)
                dgvAllProducts.Columns[0].Width = 150; // العمود الأول

            if (dgvAllProducts.Columns.Count > 1)
                dgvAllProducts.Columns[1].Width = 200; // العمود الثاني

            if (dgvAllProducts.Columns.Count > 2)
                dgvAllProducts.Columns[2].Width = 150; // العمود الثالث

            if (dgvAllProducts.Columns.Count > 3)
                dgvAllProducts.Columns[3].Width = 150; // العمود الرابع

            if (dgvAllProducts.Columns.Count > 4)
                dgvAllProducts.Columns[4].Width = 150; // العمود الخامس

            // 4. تحديث عداد عدد المنتجات
            lbProductsCount.Text = dgvAllProducts.RowCount.ToString();

            // 5. تفعيل قائمة السياق الآن لأن البيانات موجودة
            ctmsProductsManagement.Enabled = true;

            // 6. تفعيل الفلتر
            cmbFilterProductInfo.Enabled = true;
        }
        private void _FillComboBoxByProdcutInfo() // دالة تملأ ComboBox حسب نوع المعلومات
        {
            cmbFilterProductInfo.Items.Add("لاشيئ"); // بدون فلترة
            cmbFilterProductInfo.Items.Add("معرف المنتج"); // الفلترة حسب ID
            cmbFilterProductInfo.Items.Add("اسم المنتج"); // الفلترة حسب الاسم
            cmbFilterProductInfo.Items.Add("نوع المنتج"); // الفلترة حسب نوع
            cmbFilterProductInfo.Items.Add("الحجم"); // الفلترة حسب حجم
            cmbFilterProductInfo.Items.Add("الوزن"); // الفلترة حسب وجود طلب
        }
        private void _FillComboBoxByIsAvailableProductInfo() // نملأ ComboBox للتوفر
        {
            cmbIsAvailableProduct.Items.Add("الكل"); // عرض الكل
            cmbIsAvailableProduct.Items.Add("نعم"); // عرض المتوفر
            cmbIsAvailableProduct.Items.Add("لا"); // عرض الغير متوفر
        }
        private void _FillComboBoxByHasDemandProductInfo() // نملأ ComboBox للطلب
        {
            cmbHasDemandProduct.Items.Add("الكل"); // عرض الكل
            cmbHasDemandProduct.Items.Add("نعم"); // عرض المنتجات المطلوبة
            cmbHasDemandProduct.Items.Add("لا"); // عرض الغير مطلوبة
        }

        private void _ApplyFillterIsAvailableProductInfo(string ColumnName) // دالة الفلترة حسب التوفر
        {
            switch (ColumnName) // نفحص قيمة الخيار
            {
                case "الكل":
                    {
                        _dvProductList.RowFilter = ""; // بدون فلترة
                        lbProductsCount.Text = _dvProductList.Count.ToString(); // تحديث العدد
                        break;
                    }

                case "نعم":
                    {
                        _dvProductList.RowFilter = "[متوفر] = 'نعم'"; // فلترة على المتوفر
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }
                case "لا":
                    {
                        _dvProductList.RowFilter = "[متوفر] = 'لا'"; // فلترة على الغير متوفر
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }

                default:
                    {
                        _dvProductList.RowFilter = ""; // الحالة الافتراضية
                        break;
                    }
            }
        }
        private void _ApplyFillterHasDemandProductInfo(string ColumnName) // دالة الفلترة حسب الطلب
        {
            switch (ColumnName)
            {
                case "الكل":
                    {
                        _dvProductList.RowFilter = ""; // عرض الكل
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }

                case "نعم":
                    {
                        _dvProductList.RowFilter = "[عليه طلب] = 'نعم'"; // فلترة على المنتجات المطلوبة
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }
                case "لا":
                    {
                        _dvProductList.RowFilter = "[عليه طلب] = 'لا'"; // فلترة على الغير مطلوبة
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }

                default:
                    {
                        _dvProductList.RowFilter = ""; // الحالة الافتراضية
                        break;
                    }
            }
        }

        private void _ApplyFillterProductInfo(string ColumnName, string Value) // دالة الفلترة حسب العمود
        {
            _dtProductList = clsProducts.GetAllProductsList(); // نجلب كل المنتجات
            _dvProductList = new DataView(_dtProductList); // نخزنها في DataView
            if (string.IsNullOrEmpty(Value) && ColumnName == "لاشيئ") // اذا ماكو قيمة
            {
                tbFilterValue.Text = ""; // نفرغ النص
                cmbIsAvailableProduct.SelectedIndex = 0; // نرجع اول خيار
                cmbHasDemandProduct.SelectedIndex = 0;
                return;
            }
            switch (ColumnName)
            {
                case "معرف المنتج":
                    {
                        tbFilterValue.Visible = true; // نظهر مربع النص
                        _dvProductList.RowFilter = $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // فلترة حسب ID
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }

                case "اسم المنتج":
                case "نوع المنتج":
                case "الحجم":
                case "الوزن":
                    {
                        tbFilterValue.Visible = true;
                        cmbIsAvailableProduct.Visible = false;
                        cmbHasDemandProduct.Visible = false;
                        _dvProductList.RowFilter = $"[{ColumnName}] like '%{Value}%'"; // فلترة بالاسم
                        lbProductsCount.Text = _dvProductList.Count.ToString();
                        break;
                    }
  
                default:
                    {
                        break;
                    }
            }
            dgvAllProducts.DataSource = _dvProductList; // نعرض البيانات بعد الفلترة
        }
        private void frmcProductsList_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _RefreshProductsList(); // تحديث القائمة
            _FillComboBoxByProdcutInfo(); // تعبئة ComboBox المعلومات
            _FillComboBoxByIsAvailableProductInfo(); // تعبئة ComboBox التوفر
            _FillComboBoxByHasDemandProductInfo(); // تعبئة ComboBox الطلب
            cmbFilterProductInfo.SelectedIndex = 0; // اول خيار افتراضي
            cmbIsAvailableProduct.SelectedIndex = 0;
            cmbHasDemandProduct.SelectedIndex = 0;
        }

        private void pBoxAddProduct_Click(object sender, EventArgs e) // حدث الضغط على اضافة منتج
        {
            frmAddAndEidtProduct frmAdd = new frmAddAndEidtProduct(); // فتح نافذة اضافة
            frmAdd.ShowDialog(); // عرضها كحوار
            _RefreshProductsList(); // تحديث القائمة
            cmbIsAvailableProduct.SelectedIndex = 0;
            cmbHasDemandProduct.SelectedIndex = 0;
        }

        private void ctmsAddProduct_Click(object sender, EventArgs e) // اضافة من القائمة
        {
            frmAddAndEidtProduct frmAdd = new frmAddAndEidtProduct();
            frmAdd.ShowDialog();
            _RefreshProductsList();
            cmbIsAvailableProduct.SelectedIndex = 0;
            cmbHasDemandProduct.SelectedIndex = 0;
        }

        private void ctmsEidtProduct_Click(object sender, EventArgs e) // تعديل المنتج
        {
            frmAddAndEidtProduct frmAdd = new frmAddAndEidtProduct((int)dgvAllProducts.CurrentRow.Cells[0].Value); // نمرر ID
            frmAdd.ShowDialog();
            _RefreshProductsList();
            cmbIsAvailableProduct.SelectedIndex = 0;
            cmbHasDemandProduct.SelectedIndex = 0;
        }

        private void ctmsDeleteProduct_Click(object sender, EventArgs e) // حذف المنتج
        {
            if (MessageBox.Show("هل انت متاكد من حذف هذا المنتج", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // رسالة تأكيد
            {
                if (clsProducts.DeleteProduct((int)dgvAllProducts.CurrentRow.Cells[0].Value)) // اذا انحذف
                {
                    _RefreshProductsList(); // تحديث القائمة
                }
                else // اذا فشل الحذف
                {
                    MessageBox.Show("   لم يتم حذف هذا المنتج بسب ارتباطه بطلب زبون", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                    return;
                }
                cmbIsAvailableProduct.SelectedIndex = 0;
                cmbHasDemandProduct.SelectedIndex = 0;
            }
        }

        private void ctmsDetailProduct_Click(object sender, EventArgs e) // عرض تفاصيل المنتج
        {
            frmShowProductDeitals showProductDeitals = new frmShowProductDeitals((int)dgvAllProducts.CurrentRow.Cells[0].Value); // نفتح الفورم
            showProductDeitals.ShowDialog();
            _RefreshProductsList();
            cmbIsAvailableProduct.SelectedIndex = 0;
            cmbHasDemandProduct.SelectedIndex = 0;
        }

        private void cmbFilterProductInfo_SelectedIndexChanged(object sender, EventArgs e) // تغيير اختيار الفلترة
        {
            if (cmbFilterProductInfo.Text == "لاشيئ") // اذا اختار لاشيء
            {
                tbFilterValue.Visible = false;
                cmbIsAvailableProduct.Visible = false;
                cmbHasDemandProduct.Visible = false;
                tbFilterValue.Text = ""; // نفرغه
            }
            else
            {
                tbFilterValue.Visible = true; // نظهر النص
            }
            _ApplyFillterProductInfo(cmbFilterProductInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // تغيير النص
        {
            _ApplyFillterProductInfo(cmbFilterProductInfo.Text, tbFilterValue.Text); // فلترة مباشرة
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // التحقق من النص المدخل
        {
            if (cmbFilterProductInfo.Text == "معرف المنتج" ) // اذا اختار رقم 
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // اذا مو رقم
                {
                    e.Handled = true; // نمنع الإدخال
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
                }
            }
        }

        private void cmbIsAvailableProduct_SelectedIndexChanged(object sender, EventArgs e) // تغيير حالة التوفر
        {
            _ApplyFillterIsAvailableProductInfo(cmbIsAvailableProduct.Text); // نطبق الفلترة
        }

        private void cmbHasDemandProduct_SelectedIndexChanged(object sender, EventArgs e) // تغيير حالة الطلب
        {
            _ApplyFillterHasDemandProductInfo(cmbHasDemandProduct.Text); // نطبق الفلترة
        }
    }
}
