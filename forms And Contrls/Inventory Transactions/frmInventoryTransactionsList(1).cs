using BusinessLayeres;
using ETEZAN2024.forms_And_Contrls.Inventory_Transactions;
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
    public partial class frmInventoryTransactionsList : Form
    {
        string _ColumnName = ""; // نخزن بيه اسم العمود اللي نفلتر عليه
        DataTable _dtInventoryTransactionsList; // نخزن كل البيانات اللي تجي من الداتابيس
        DataView _dvInventoryTransactionsList; // نخلي نسخه من الداتا جدول حتى نكدر نسوي عليها فلترة

        public frmInventoryTransactionsList()
        {
            InitializeComponent(); // يبدي يشتغل النموذج ويهيئ العناصر
        }

        private void _RefershInventoryTransactionsList() // دالة تحديث قائمة حركات الجرد
        {
            // 1. جلب كل الحركات وربطها بالـ DataGridView
            dgvAllInventoryTransactions.DataSource = clsInventoryTransactions.GetAll();

            // 2. التحقق إن كان الجدول فارغ لتجنب الأخطاء
            if (dgvAllInventoryTransactions.Rows.Count == 0)
            {
                // تعطيل الكونتكس مينو لأنه لا توجد سجلات
                ctmsInventoryTransactionsManagement.Enabled = false;

                // تعطيل الفلتر لأنه لا توجد بيانات
                cmbFilterInventoryTransactionsInfo.Enabled = false;

                // تعيين عداد السجلات إلى صفر
                lbInventoryTransactionsCount.Text = "0";

                // الخروج من الدالة لتجنب الوصول لأعمدة غير موجودة
                return;
            }

            // 3. تعديل أعمدة الجدول بشكل آمن (فقط إذا كانت موجودة فعلاً)
            if (dgvAllInventoryTransactions.Columns.Count > 0)
                dgvAllInventoryTransactions.Columns[0].Width = 100; // عرض العمود الأول

            if (dgvAllInventoryTransactions.Columns.Count > 1)
                dgvAllInventoryTransactions.Columns[1].Width = 140; // عرض العمود الثاني

            if (dgvAllInventoryTransactions.Columns.Count > 2)
                dgvAllInventoryTransactions.Columns[2].Width = 140; // عرض العمود الثالث

            if (dgvAllInventoryTransactions.Columns.Count > 3)
                dgvAllInventoryTransactions.Columns[3].Width = 80;  // عرض العمود الرابع

            if (dgvAllInventoryTransactions.Columns.Count > 4)
                dgvAllInventoryTransactions.Columns[4].Width = 120; // عرض العمود الخامس (صحيح – عدلت التكرار)

            // 4. تحديث عداد السجلات في الواجهة
            lbInventoryTransactionsCount.Text = dgvAllInventoryTransactions.RowCount.ToString();

            // 5. تفعيل الكونتكس مينو لوجود بيانات
            ctmsInventoryTransactionsManagement.Enabled = true;

            // 6. تفعيل الفلتر لأن البيانات موجودة
            cmbFilterInventoryTransactionsInfo.Enabled = true;
        }

        private void _FillcomboxByInventoryTransactionInfo()
        {
            cmbFilterInventoryTransactionsInfo.Items.Clear(); // نفرغ القائمة القديمة

            cmbFilterInventoryTransactionsInfo.Items.Add("لاشيئ"); // خيار بدون فلترة
            cmbFilterInventoryTransactionsInfo.Items.Add("رقم الحركة"); // فلترة حسب رقم الحركة
            cmbFilterInventoryTransactionsInfo.Items.Add("اسم المنتج"); // فلترة حسب اسم المنتج
            cmbFilterInventoryTransactionsInfo.Items.Add("رقم عنصر الطلب"); // فلترة حسب الكمية
            cmbFilterInventoryTransactionsInfo.Items.Add("نوع الحركة"); // فلترة حسب نوع الحركة
            cmbFilterInventoryTransactionsInfo.Items.Add("الكمية"); // فلترة حسب الكمية
            cmbFilterInventoryTransactionsInfo.Items.Add("التاريخ"); // فلترة حسب التاريخ
        }


        private void _ApplyFillterTypeInventoryTransactionInfo(string ColumnName, string filterValue)
        {
            tbFilterValue.Visible = false; // نخفي صندوق النص لأن الفلترة صارت بالكومبوبوكس فقط

            if (_dvInventoryTransactionsList == null) // إذا الداتا فيو بعده ما متكون
                return;

            if (string.IsNullOrEmpty(filterValue)) // إذا الفلتر فارغ
                return;

            if (filterValue == "الكل") // إذا اختار "الكل"
            {
                _dvInventoryTransactionsList.RowFilter = ""; // نلغي الفلترة
                lbInventoryTransactionsCount.Text = _dvInventoryTransactionsList.Count.ToString(); // نحدث العداد
                return;
            }

            _dvInventoryTransactionsList.RowFilter = $"[{ColumnName}] = '{filterValue}'"; // نطبق فلترة النوع

            lbInventoryTransactionsCount.Text = _dvInventoryTransactionsList.Count.ToString(); // نرجع عدد السجلات بعد الفلترة
        }

        private void _ApplyFilterInventoryTransactionInfo(string ColumnName, string Value)
        {
            _ColumnName = ColumnName; // نخزن اسم العمود المطلوب فلترته
            _dtInventoryTransactionsList = clsInventoryTransactions.GetAll(); // نجيب كل البيانات من جديد
            _dvInventoryTransactionsList = new DataView(_dtInventoryTransactionsList); // نسوي DataView للفلترة

            if (string.IsNullOrEmpty(Value) && ColumnName == "لاشيئ") // إذا المستخدم اختار "لاشيء"
            {
                tbFilterValue.Visible = false; // نخفي صندوق النص
                tbFilterValue.Text = ""; // نفرغه
                _dvInventoryTransactionsList.RowFilter = ""; // نلغي الفلترة

                cmbTypeInventoryTransactions.SelectedIndex = 0; // نرجع الكومبوبوكس لأول خيار

                return;
            }

            switch (ColumnName)
            {
                case "رقم الحركة":
                case "رقم عنصر الطلب":
                case "الكمية":
                case "التاريخ":
                    {
                        cmbTypeInventoryTransactions.Visible = false; // نخفي كومبوبوكس الأنواع
                        tbFilterValue.Visible = true; // نظهر صندوق النص

                        _dvInventoryTransactionsList.RowFilter =
                            $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // نطبق فلترة تحتوي على قيمة الإدخال

                        lbInventoryTransactionsCount.Text = _dvInventoryTransactionsList.Count.ToString(); // تحديث العدد
                        break;
                    }

                case "نوع الحركة":
                    {
                        cmbTypeInventoryTransactions.Visible = true; // نظهر كومبوبوكس الأنواع
                        tbFilterValue.Visible = true; // نظهر صندوق النص (رغم إنه ما مستخدمين النص هنا)

                        _ApplyFillterTypeInventoryTransactionInfo("نوع الحركة",
                                                                   cmbTypeInventoryTransactions.Text); // نطبق فلترة نوع الحركة

                        lbInventoryTransactionsCount.Text = _dvInventoryTransactionsList.Count.ToString(); // تحديث العدد

                        break;
                    }

                default:
                    {
                        cmbTypeInventoryTransactions.Visible = false; // نخفي كومبوبوكس الأنواع
                        tbFilterValue.Visible = true; // نعرض صندوق النص

                        _dvInventoryTransactionsList.RowFilter =
                            $"Convert([{ColumnName}], 'System.String') LIKE '%{Value}%'"; // فلترة عامة

                        lbInventoryTransactionsCount.Text = _dvInventoryTransactionsList.Count.ToString(); // تحديث العداد
                        break;
                    }
            }

            dgvAllInventoryTransactions.DataSource = _dvInventoryTransactionsList; // نعرض النتيجة بعد الفلترة
        }

        private void frmInventoryTransactionsList_Load(object sender, EventArgs e)
        {
            _RefershInventoryTransactionsList(); // نعرض البيانات أول ما يفتح الفورم
            _FillcomboxByInventoryTransactionInfo(); // نملأ قائمة الفلاتر
            clsGlobal.FillComboBoxTypeInventoryTransactionInfo(cmbTypeInventoryTransactions); // نملأ قائمة نوع الحركة
            cmbTypeInventoryTransactions.Items.Add("الكل"); // نضيف عرض كل الأنواع  للكمبو بوكس مال انواع الحركات
           //جبنه اخر عنصر بلكمبو بوكس الي هوه اخر واحد ضفناه يمثل  عنصر الكل
            int LastIndexOf = cmbTypeInventoryTransactions.Items.Count - 1;

            cmbTypeInventoryTransactions.SelectedIndex = LastIndexOf; // نخلي الافتراضي "الكل"
            cmbFilterInventoryTransactionsInfo.SelectedIndex = 0; // نخلي الافتراضي "لاشيء"
        }

        private void ctmsEidtInventoryTransactions_Click(object sender, EventArgs e)
        {
            frmAddAndEditInventoryTransactions frmUpdate =
                new frmAddAndEditInventoryTransactions((int)dgvAllInventoryTransactions.CurrentRow.Cells[0].Value); // نجيب رقم الحركة من أول عمود

            frmUpdate.ShowDialog(); // افتح شاشة التعديل
            _RefershInventoryTransactionsList(); // رجّع البيانات بعد التعديل
        }

        private void ctmsAddInventoryTransactions_Click(object sender, EventArgs e)
        {
            frmAddAndEditInventoryTransactions frmUpdate =
                new frmAddAndEditInventoryTransactions(); // نفتح النموذج بدون ID لإضافة جديدة

            frmUpdate.ShowDialog(); // عرض النافذة
            _RefershInventoryTransactionsList(); // تحديث الجدول
        }

        private void pBoxAddInventoryTransactions_Click(object sender, EventArgs e)
        {
            frmAddAndEditInventoryTransactions frmUpdate =
                new frmAddAndEditInventoryTransactions(); // إضافة جديدة

            frmUpdate.ShowDialog();
            _RefershInventoryTransactionsList();
        }

        private void ctmsDetailInventoryTransactions_Click(object sender, EventArgs e)
        {
            frmShowInventoryTransactionsDetials frmUpdate =
                new frmShowInventoryTransactionsDetials((int)dgvAllInventoryTransactions.CurrentRow.Cells[0].Value); // نعرض تفاصيل الحركة

            frmUpdate.ShowDialog();
            _RefershInventoryTransactionsList();
        }

        private void ctmsDeleteInventoryTransactions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف الجرد", "حذف",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // نطلع رسالة تأكيد
            {
                if (clsInventoryTransactions.Delete((int)dgvAllInventoryTransactions.CurrentRow.Cells[0].Value)) // إذا الحذف نجح
                {
                    _RefershInventoryTransactionsList(); // نرجع القائمة
                }
                else // إذا ما نجح الحذف
                {
                    MessageBox.Show("   لم يتم حذف هذا الجرد بسب ارتباطه بطلب زبون",
                        "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض خطأ
                    return;
                }
            }
        }

        private void cmbFilterInventoryTransactionsInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterInventoryTransactionsInfo.Text == "لاشيئ") // إذا المستخدم ما يريد فلترة
            {
                tbFilterValue.Visible = false; // نخفي صندوق النص
                cmbTypeInventoryTransactions.Visible = false; // نخفي الكومبوبوكس الثاني
                tbFilterValue.Text = ""; // نفرغ النص
                return;
            }

            if (cmbFilterInventoryTransactionsInfo.Text == "نوع الحركة") // إذا يريد الفلترة حسب نوع الحركة
            {
                tbFilterValue.Visible = false; // نخفي النص
                cmbTypeInventoryTransactions.Visible = true; // نظهر قائمة الأنواع
            }

            _ApplyFilterInventoryTransactionInfo(cmbFilterInventoryTransactionsInfo.Text,
                                                 tbFilterValue.Text); // نطبق الفلترة
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilterInventoryTransactionInfo(cmbFilterInventoryTransactionsInfo.Text,
                                                 tbFilterValue.Text); // نطبق الفلترة بمجرد ما يكتب المستخدم
        }

        private void cmbTypeInventoryTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFillterTypeInventoryTransactionInfo("نوع الحركة",
                                                      cmbTypeInventoryTransactions.Text); // نطبق الفلترة حسب نوع الحركة
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterInventoryTransactionsInfo.Text == "الكمية" ||
                cmbFilterInventoryTransactionsInfo.Text == "رقم عنصر الطلب" ||
                cmbFilterInventoryTransactionsInfo.Text == "رقم الحركة" ||
                cmbFilterInventoryTransactionsInfo.Text == "التاريخ") // إذا الفلترة رقمية
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar)) // نمنع النصوص
                {
                    e.Handled = true; // نمنع الإدخال
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة تنبيه
                }
            }
        }
    }
}
