using BusinessLayeres; // نستدعي الطبقة الوسيطة (BLL) حتى نستخدم كلاس المخازن
using ETEZAN2024.forms_And_Contrls.ProductPrices;
using System; // مكتبة الاساسيات
using System.Collections.Generic; // حتى نستخدم قوائم وجنريك
using System.ComponentModel; // يخص خصائص الكمبوننتات
using System.Data; // للتعامل مع DataTable, DataView
using System.Drawing; // للتحكم بالرسومات والالوان
using System.Linq; // حتى نستخدم LINQ
using System.Text; // للتعامل مع النصوص
using System.Threading.Tasks; // للبرمجة غير المتزامنة
using System.Windows.Forms; // حتى نستخدم واجهة النوافذ

namespace ETEZAN2024.forms_And_Contrls.Inventories // مساحة اسم خاصة بالفورم مال المخازن
{
    public partial class frmInventoriesList : Form // تعريف الفورم
    {
        int _InventoriesID = -1; // متغير يخزن رقم المخزن، بالبداية -1 يعني بعده ما مختار
        clsInventories _Inventories; // كائن من كلاس المخازن حتى نشتغل عليه
        DataTable _dtProductsInventoryList; // جدول نخزن بيه كل بيانات المخازن
        DataView _dvProductsInventoryList; // DataView حتى نعرض البيانات بشكل قابل للفلترة

        public frmInventoriesList() // الكونستركتر
        {
            InitializeComponent(); // تهيئة مكونات الفورم
        }

        private void _RefreshProductsInventoryList() // دالة تحديث بيانات المخازن
        {
            // 1. جلب البيانات من BLL وربطها بالـ DataGridView
            dgvAllProductInventories.DataSource = clsInventories.GetAllInventoriesList();

            // 2. إذا الجدول فارغ نوقف كل شيء لتجنب الأخطاء
            if (dgvAllProductInventories.Rows.Count == 0)
            {
                // تعطيل الكونتكس مينو لأنه لا توجد عناصر لإدارتها
                ctmsProductsInventoriesManagement.Enabled = false;

                // تعطيل الفلتر
                cmbFilterProductInventorieInfo.Enabled = false;

                // عرض "0" في عداد المخازن
                lbProductInventoriesCount.Text = "0";

                // الخروج من الدالة لتجنب الوصول لأعمدة غير موجودة لاحقًا
                return;
            }

            // 3. تعديل عرض الأعمدة بشكل آمن — فقط إذا كانت الأعمدة موجودة فعلاً
            if (dgvAllProductInventories.Columns.Count > 1)
                dgvAllProductInventories.Columns[1].Width = 110; // العمود الثاني

            if (dgvAllProductInventories.Columns.Count > 6)
                dgvAllProductInventories.Columns[6].Width = 120; // العمود السابع

            // 4. تحديث عداد عدد سجلات المخازن
            lbProductInventoriesCount.Text = dgvAllProductInventories.RowCount.ToString();

            // 5. تفعيل الكونتكس مينو لأن البيانات موجودة بالفعل
            ctmsProductsInventoriesManagement.Enabled = true;

            // 6. تفعيل الفلتر الآن بعد التأكد من وجود بيانات
            cmbFilterProductInventorieInfo.Enabled = true;
        }

        private void _FillComboBoxByProductsInventoryInfo() // دالة تملأ ComboBox الخاص بالفلترة
        {
            cmbFilterProductInventorieInfo.Items.Clear();

            cmbFilterProductInventorieInfo.Items.Add("لاشيئ");
            cmbFilterProductInventorieInfo.Items.Add("رقم المخزون");
            cmbFilterProductInventorieInfo.Items.Add("اسم المنتج");
            cmbFilterProductInventorieInfo.Items.Add("اسم المورد");
            cmbFilterProductInventorieInfo.Items.Add("تاريخ آخر شراء");
            //  cmbFilterProductInventorieInfo.Items.Add("متوفر");
            //   cmbFilterProductInventorieInfo.Items.Add("سعر الشراء");
            //   cmbFilterProductInventorieInfo.Items.Add("سعر البيع");
            //  cmbFilterProductInventorieInfo.Items.Add("الكمية المتوفرة");
            // cmbFilterProductInventorieInfo.Items.Add("حد أقل تنبيه");


        }

        private void _FillComboBoxByAvailableProductsInventoryInfo() // دالة تملأ ComboBox مال التوفر
        {
            cmbIsProductStatus.Items.Add("الكل"); // نعرض الكل
            cmbIsProductStatus.Items.Add("نعم"); // المنتجات المتوفرة
            cmbIsProductStatus.Items.Add("لا"); // المنتجات الغير متوفرة
        }

        private void _ApplyFillterAvailableProductsInventoryInfo(string ColumnName) // دالة فلترة حسب حالة التوفر
        {
            if (_dtProductsInventoryList == null)
                return; // ماكو بيانات للفلترة

            if (string.IsNullOrEmpty(ColumnName))
                return; // العمود ما متزود صحيح
            switch (ColumnName) // نفحص القيمة
            {
                case "الكل": // اذا الكل
                    _dvProductsInventoryList.RowFilter = ""; // بدون فلترة
                    lbProductInventoriesCount.Text = _dvProductsInventoryList.Count.ToString(); // نعرض العدد
                    break;

                case "نعم": // اذا نعم
                    _dvProductsInventoryList.RowFilter = "[متوفر] = 'نعم'"; // نعرض بس المتوفر
                    lbProductInventoriesCount.Text = _dvProductsInventoryList.Count.ToString();
                    break;

                case "لا": // اذا لا
                    _dvProductsInventoryList.RowFilter = "[متوفر] = 'لا'"; // نعرض الغير متوفر
                    lbProductInventoriesCount.Text = _dvProductsInventoryList.Count.ToString();
                    break;

                default: // حالة افتراضية
                    _dvProductsInventoryList.RowFilter = "";
                    break;
            }
        }

        private void _ApplyFillterProductsInventoryInfo(string ColumnName, string Value) // دالة فلترة حسب عمود معين وقيمة
        {
            _dtProductsInventoryList = clsInventories.GetAllInventoriesList(); // نجيب البيانات من BLL
            _dvProductsInventoryList = new DataView(_dtProductsInventoryList); // نخليها DataView للفلترة

            if (string.IsNullOrEmpty(Value) && ColumnName == "لاشيئ") // اذا الفلترة فارغة
            {
                tbFilterValue.Text = ""; // نفرغ التكست
                _dvProductsInventoryList.RowFilter = ""; // ماكو فلترة
                return; // نطلع
            }

            switch (ColumnName) // نحدد حسب العمود
            {
                case "رقم المخزون": // فلترة حسب رقم المخزن
                    tbFilterValue.Visible = true; // نظهر TextBox
                   // cmbIsProductStatus.Visible = false; // نخفي ComboBox
                    _dvProductsInventoryList.RowFilter = $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // فلترة بالـ ID
                    lbProductInventoriesCount.Text = _dvProductsInventoryList.Count.ToString();
                    break;

                case "اسم المنتج":
                case "اسم المورد":// فلترة حسب الاسم
                    tbFilterValue.Visible = true;
                  //  cmbIsProductStatus.Visible = false;
                    _dvProductsInventoryList.RowFilter = $"[{ColumnName}] like '%{Value}%'"; // فلترة بالاسم
                    lbProductInventoriesCount.Text = _dvProductsInventoryList.Count.ToString();
                    break;

                case "تاريخ آخر شراء":
                    tbFilterValue.Visible = true; // نظهر TextBox

                    _dvProductsInventoryList.RowFilter = $"Convert([تاريخ آخر شراء], 'System.String') LIKE '%{Value}%'";
                    break;

                default:
                    break;
            }

            dgvAllProductInventories.DataSource = _dvProductsInventoryList; // نعرض النتائج بالجدول
        }

        private void frmInventoriesList_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _RefreshProductsInventoryList(); // نحدث الجدول
            _FillComboBoxByProductsInventoryInfo(); // نملأ ComboBox الفلترة
            _FillComboBoxByAvailableProductsInventoryInfo(); // نملأ ComboBox التوفر
            cmbFilterProductInventorieInfo.SelectedIndex = 0; // اول خيار افتراضي
            cmbIsProductStatus.SelectedIndex = 0; // اول خيار افتراضي
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // لما المستخدم يغير النص
        {
            _ApplyFillterProductsInventoryInfo(cmbFilterProductInventorieInfo.Text, tbFilterValue.Text); // نطبق فلترة
        }

        private void cmbFilterProductInventorieInfo_SelectedIndexChanged(object sender, EventArgs e) // تغيير الفلترة
        {
            if (cmbFilterProductInventorieInfo.Text == "لاشيئ") // اذا لاشيئ
            {
                tbFilterValue.Visible = false; // نخفي التكست
                cmbIsProductStatus.Visible = false; // نخفي الكومبوبوكس
            }
            else
            {
                tbFilterValue.Visible = true; // نظهر التكست
            }
            _ApplyFillterProductsInventoryInfo(cmbFilterProductInventorieInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void cmbIsProductStatus_SelectedIndexChanged(object sender, EventArgs e) // تغيير حالة التوفر
        {
            _ApplyFillterProductsInventoryInfo(cmbFilterProductInventorieInfo.Text, tbFilterValue.Text); // نطبق الفلترة
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // حدث الضغط على الكيبورد
        {
            if (cmbFilterProductInventorieInfo.Text == "رقم المخزون" || cmbFilterProductInventorieInfo.Text == "تاريخ آخر شراء") // اذا الفلترة على ID
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // اذا مو رقم
                {
                    e.Handled = true; // نمنع الادخال
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // نعرض رسالة
                }
            }
        }

        private void pBoxAddProductInventories_Click(object sender, EventArgs e)
        {
            frmAddAndEditProductsInventory frmAdd = new frmAddAndEditProductsInventory();
            frmAdd.ShowDialog();
            _RefreshProductsInventoryList();
        }

        private void ctmsAddProduct_Click(object sender, EventArgs e)
        {
            frmAddAndEditProductsInventory frmAdd = new frmAddAndEditProductsInventory();
            frmAdd.ShowDialog();
            _RefreshProductsInventoryList();
        }

        private void ctmsEidtProduct_Click(object sender, EventArgs e)
        {
            frmAddAndEditProductsInventory frmAdd = new frmAddAndEditProductsInventory((int)dgvAllProductInventories.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
            _RefreshProductsInventoryList();
        }

        private void ctmsDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف سعرالمنتج", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // رسالة تأكيد
            {
                if (clsInventories.Delete((int)dgvAllProductInventories.CurrentRow.Cells[0].Value)) // اذا الحذف نجح
                {
                    _RefreshProductsInventoryList(); // تحديث القائمة
                }
                else // اذا فشل الحذف
                {
                    MessageBox.Show("   لم يتم حذف هذا المنتج بسب ارتباطه بطلب زبون", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                    return;
                }
            }
        }

        private void ctmsDetailProduct_Click(object sender, EventArgs e)
        {
            frmShowtProductInventoryDetials frmAdd = new frmShowtProductInventoryDetials((int)dgvAllProductInventories.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
            _RefreshProductsInventoryList();
        }
    }
}
