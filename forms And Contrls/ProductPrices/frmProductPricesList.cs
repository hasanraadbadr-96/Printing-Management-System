using BusinessLayeres; // نستدعي الطبقة اللي بيها المنطق (Business Layeres) للتعامل ويا البيانات
using ETEZAN2024.forms_And_Contrls.ProductPrices; // نستدعي النيمسبيس الخاص بالنماذج والسيطرات مالت اسعار المنتجات
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة مكونات الفورم
using System.Data; // مكتبة الجداول والـ DataTable
using System.Drawing; // مكتبة الرسومات
using System.Linq; // مكتبة الاستعلامات LINQ
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام
using System.Windows.Forms; // مكتبة عناصر الفورم

namespace ETEZAN2024.forms_And_Contrls.PricesProduct // تعريف النيمسبيس
{
    public partial class frmProductPricesList : Form // تعريف كلاس للفورم اللي يعرض اسعار المنتجات
    {
        int ProductPriceID = -1; // متغير يخزن رقم سعر المنتج، بالبداية -1 يعني ما مختار
        clsProducts _clsProducts; // كائن يمثل كلاس المنتجات
        DataTable _dtProductPricesList; // جدول نخزن بيه البيانات
        DataView _dvProductPricesList; // عرض بيانات الجدول بشكل قابل للفلترة

        public frmProductPricesList() // كونستركتر الفورم
        {
            InitializeComponent(); // تهيئة مكونات الفورم
        }

        private void _RefreshProductPricesList() // دالة لتحديث جدول الأسعار
        {
            // 1. جلب بيانات الأسعار من الطبقة التجارية وربطها بالـ DataGridView
            dgvAllProductPrices.DataSource = clsProductPrices.GetAllProductPricesList();

            // 2. التحقق إن كانت البيانات فارغة (NULL أو بلا صفوف)
            if (dgvAllProductPrices.DataSource == null || dgvAllProductPrices.Rows.Count == 0)
            {
                // تعطيل قائمة السياق لأنه لا توجد بيانات
                ctmsProductPricesManagement.Enabled = false;

                // تعطيل الفلتر لأنه لا توجد بيانات
                cmbFilterProductPricesInfo.Enabled = false;

                // عرض الصفر
                lbProductPricesCount.Text = "0";

                // الخروج من الدالة لتجنب أخطاء الوصول للأعمدة
                return;
            }

            // 3. ضبط عرض الأعمدة بشكل آمن (بعد التحقق من عدد الأعمدة)
            if (dgvAllProductPrices.Columns.Count > 1)
                dgvAllProductPrices.Columns[1].Width = 150; // العمود الثاني

            if (dgvAllProductPrices.Columns.Count > 2)
                dgvAllProductPrices.Columns[2].Width = 120; // العمود الثالث

            if (dgvAllProductPrices.Columns.Count > 3)
                dgvAllProductPrices.Columns[3].Width = 80;  // العمود الرابع

            if (dgvAllProductPrices.Columns.Count > 4)
                dgvAllProductPrices.Columns[4].Width = 150; // العمود الخامس

            // 4. تحديث عداد عدد الصفوف
            lbProductPricesCount.Text = dgvAllProductPrices.RowCount.ToString();

            // 5. تفعيل قائمة السياق لأن البيانات موجودة
            ctmsProductPricesManagement.Enabled = true;

            // 6. تفعيل الفلتر
            cmbFilterProductPricesInfo.Enabled = true;
        }

        private void _FillComboBoxByProdcutPriceInfo() // دالة تملأ ComboBox حسب نوع الفلترة
        {
            cmbFilterProductPricesInfo.Items.Add("لاشيئ"); // فلترة فارغة
            cmbFilterProductPricesInfo.Items.Add("معرف السعر"); // فلترة حسب ID
            cmbFilterProductPricesInfo.Items.Add("اسم المنتج"); // فلترة حسب الاسم
            cmbFilterProductPricesInfo.Items.Add("نشط"); // فلترة حسب حالة التوفر
        }

        private void _FillComboBoxByIsActiveProductPriceInfo() // دالة تملأ ComboBox مال التوفر
        {
            cmbIsActiveProductPrices.Items.Add("الكل"); // عرض الكل
            cmbIsActiveProductPrices.Items.Add("نعم"); // عرض المنتجات المتوفرة
            cmbIsActiveProductPrices.Items.Add("لا"); // عرض الغير متوفرة
        }

        private void _ApplyFillterIsActiveProductPriceInfo(string ColumnName) // دالة فلترة حسب حالة التوفر
        {
            switch (ColumnName) // نفحص النص
            {
                case "الكل": // اذا الكل
                    _dvProductPricesList.RowFilter = ""; // ماكو فلترة
                    lbProductPricesCount.Text = _dvProductPricesList.Count.ToString(); // تحديث العدد
                    break;

                case "نعم": // اذا نعم
                    _dvProductPricesList.RowFilter = "[نشط] = 'نعم'"; // فلترة بس على المتوفر
                    lbProductPricesCount.Text = _dvProductPricesList.Count.ToString();
                    break;

                case "لا": // اذا لا
                    _dvProductPricesList.RowFilter = "[نشط] = 'لا'"; // فلترة على الغير متوفر
                    lbProductPricesCount.Text = _dvProductPricesList.Count.ToString();
                    break;

                default:
                    _dvProductPricesList.RowFilter = ""; // الحالة الافتراضية
                    break;
            }
        }

        private void _ApplyFillterProductPriceInfo(string ColumnName, string Value) // دالة فلترة حسب العمود والقيمة
        {
            _dtProductPricesList = clsProductPrices.GetAllProductPricesList(); // نجيب البيانات من قاعدة البيانات
            _dvProductPricesList = new DataView(_dtProductPricesList); // نخزنها داخل DataView

            if (string.IsNullOrEmpty(Value) && ColumnName == "لاشيئ") // اذا الفلترة فارغة
            {
                tbFilterValue.Text = ""; // نفرغ النص
                return; // نطلع من الدالة
            }

            switch (ColumnName) // حسب نوع العمود
            {
                case "معرف السعر":
                    tbFilterValue.Visible = true; // نظهر التكست
                    cmbIsActiveProductPrices.Visible = false; // نخفي الكومبوبوكس
                    _dvProductPricesList.RowFilter = $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // فلترة بالـ ID
                    lbProductPricesCount.Text = _dvProductPricesList.Count.ToString();
                    break;

                case "اسم المنتج":
                    tbFilterValue.Visible = true;
                    cmbIsActiveProductPrices.Visible = false;
                    _dvProductPricesList.RowFilter = $"[{ColumnName}] like '%{Value}%'"; // فلترة بالاسم
                    lbProductPricesCount.Text = _dvProductPricesList.Count.ToString();
                    break;

                case "نشط":
                    tbFilterValue.Visible = false; // نخفي التكست
                    cmbIsActiveProductPrices.Visible = true; // نظهر الكومبوبوكس
                    _ApplyFillterIsActiveProductPriceInfo(cmbIsActiveProductPrices.Text); // نفلتر حسب حالة التوفر
                    break;

                default:
                    break;
            }

            dgvAllProductPrices.DataSource = _dvProductPricesList; // نعرض النتائج بعد الفلترة
        }

        private void frmProductPricesList_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _RefreshProductPricesList(); // تحديث القائمة
            _FillComboBoxByProdcutPriceInfo(); // نملأ الكومبوبوكس الاول
            _FillComboBoxByIsActiveProductPriceInfo(); // نملأ الكومبوبوكس الثاني
            cmbFilterProductPricesInfo.SelectedIndex = 0; // نخلي الافتراضي "لاشيئ"
            cmbIsActiveProductPrices.SelectedIndex = 0; // نخلي الافتراضي "الكل"
        }

        private void pBoxAddProductPrices_Click(object sender, EventArgs e) // حدث ضغط زر الاضافة
        {
            frmAddAndEditProductPrice frmAdd = new frmAddAndEditProductPrice(); // نفتح فورم الاضافة
            frmAdd.ShowDialog();
            _RefreshProductPricesList(); // تحديث القائمة بعد الاضافة
        }

        private void ctmsAddProductPrices_Click(object sender, EventArgs e) // من القائمة السياقية اضافة
        {
            frmAddAndEditProductPrice frmAdd = new frmAddAndEditProductPrice();
            frmAdd.ShowDialog();
            _RefreshProductPricesList();
        }

        private void ctmsEidtProductPrices_Click(object sender, EventArgs e) // تعديل عنصر
        {
            frmAddAndEditProductPrice frmEdit = new frmAddAndEditProductPrice((int)dgvAllProductPrices.CurrentRow.Cells[0].Value); // نجيب الـ ID من الصف الحالي
            frmEdit.ShowDialog();
            _RefreshProductPricesList();
        }

        private void ctmsDeleteProductPrices_Click(object sender, EventArgs e) // حذف عنصر
        {
            if (MessageBox.Show("هل انت متاكد من حذف سعرالمنتج", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // رسالة تأكيد
            {
                if (clsProductPrices.Delete((int)dgvAllProductPrices.CurrentRow.Cells[0].Value)) // اذا الحذف نجح
                {
                    _RefreshProductPricesList(); // تحديث القائمة
                }
                else // اذا فشل الحذف
                {
                    MessageBox.Show("   لم يتم حذف هذا المنتج بسب ارتباطه بطلب زبون", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                    return;
                }
            }
        }

        private void ctmsDetailProductPrices_Click(object sender, EventArgs e) // عرض تفاصيل السعر
        {
            frmShowProductPricesDetials ProductPricesDetials = new frmShowProductPricesDetials((int)dgvAllProductPrices.CurrentRow.Cells[0].Value); // نفتح فورم التفاصيل
            ProductPricesDetials.ShowDialog();
            _RefreshProductPricesList();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // فلترة على حسب كتابة المستخدم
        {
            if (cmbFilterProductPricesInfo.Text == "معرف السعر") // اذا الفلترة على الـ ID
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // اذا مو رقم
                {
                    e.Handled = true; // نمنع الكتابة
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة خطأ
                }
            }
        }

        private void cmbFilterProductPricesInfo_SelectedIndexChanged(object sender, EventArgs e) // حدث تغيير قيمة الكومبوبوكس
        {
            if (cmbFilterProductPricesInfo.Text == "لاشيئ") // اذا الفلترة "لاشيئ"
            {
                tbFilterValue.Visible = false; // نخفي التكست
                cmbIsActiveProductPrices.Visible = false; // نخفي الكومبوبوكس
            }
            else
            {
                tbFilterValue.Visible = true; // نظهر التكست
            }
            _ApplyFillterProductPriceInfo(cmbFilterProductPricesInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // حدث تغيير النص
        {
            _ApplyFillterProductPriceInfo(cmbFilterProductPricesInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void cmbIsActiveProductPrices_SelectedIndexChanged(object sender, EventArgs e) // حدث تغيير حالة التوفر
        {
            _ApplyFillterProductPriceInfo(cmbFilterProductPricesInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }
    }
}
