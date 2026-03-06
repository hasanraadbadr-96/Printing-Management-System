using BusinessLayeres; // نستدعي طبقة الـ Business حتى نستخدم كلاس الأشخاص clsPersons.
using ETEZAN2024.forms_And_Contrls.Persons.form; // نستدعي فورمات الأشخاص (مثل frmAddAndUpdate).
using System; // مكتبة الأساسيات.
using System.Collections.Generic; // مكتبة القوائم.
using System.ComponentModel; // مكتبة خصائص الكومبوننت.
using System.Data; // مكتبة للتعامل مع الجداول والداتا.
using System.Data.Common; // مكتبة للتعامل مع قواعد البيانات بشكل عام.
using System.Drawing; // مكتبة الرسوميات (ألوان/صور).
using System.Linq; // مكتبة LINQ.
using System.Text; // مكتبة النصوص.
using System.Threading.Tasks; // مكتبة العمليات غير المتزامنة.
using System.Windows.Forms; // مكتبة تصميم الواجهات Windows Forms.

namespace ETEZAN2024.forms.Persons // مساحة الاسم الخاصة بالفورمات للأشخاص.
{
    public partial class frmPersonsList : Form // تعريف الفورم frmPersonsList يرث من Form.
    {
        public frmPersonsList() // كونستركتر للفورم.
        {
            InitializeComponent(); // يهيئ مكونات الفورم (الأدوات).
        }

        private int _PersonID; // متغير يخزن معرف الشخص المختار.
        private string _FilterColumn; // يخزن اسم العمود اللي نبحث بيه.
        private DataTable _dtPersonsList; // جدول يخزن كل الأشخاص.
        private DataView _dvPersonsList; // View للجدول حتى نطبق عليه الفلاتر.

        private void _RefreashAllPersonsList() // دالة لتحديث قائمة الأشخاص.
        {
            // 1. جلب البيانات من الطبقة التجارية وربطها بالـ DataGridView
            dgvAllPersons.DataSource = clsPersons.GetAllPersonsList();

            // 2. التحقق من أن البيانات NULL أو لا تحتوي على صفوف
            if (dgvAllPersons.DataSource == null || dgvAllPersons.Rows.Count == 0)
            {
                // تعطيل قائمة السياق لأنه لا توجد عناصر لإدارتها
                ctmsPersonsManagement.Enabled = false;

                // تعطيل الفلتر لأنه لا يوجد شيء للبحث فيه
                cmboFilterBY.Enabled = false;

                // عرض عدد الأشخاص = صفر
                lbPersonsCount.Text = "0";

                // خروج آمن من الدالة
                return;
            }

            // 3. تحديث عداد الأشخاص بعد التأكد من وجود بيانات
            lbPersonsCount.Text = dgvAllPersons.RowCount.ToString();

            // 4. تفعيل قائمة السياق لأنها تحتاج بيانات لتعمل
            ctmsPersonsManagement.Enabled = true;

            // 5. تفعيل الفلتر
            cmboFilterBY.Enabled = true;
        }

        private void _FillComboBox() // دالة تعبئة ComboBox بعناوين الأعمدة.
        {
            cmboFilterBY.Items.Add("لاشئ"); // نخلي خيار أولي "لاشئ".

            _dtPersonsList = (DataTable)dgvAllPersons.DataSource; // نخزن مصدر الداتا بجدول.
            foreach (DataColumn column in _dtPersonsList.Columns) // نمر على كل الأعمدة.
            {
                cmboFilterBY.Items.Add(column.ColumnName); // نضيف اسم العمود بالكومبو بوكس.
            }
        }

        private void _LoadData() // دالة تحميل البيانات الأساسية للفورم.
        {
            _RefreashAllPersonsList(); // نعرض كل الأشخاص.
            _FillComboBox(); // نملئ الكومبو بوكس بالأعمدة.
            cmboFilterBY.SelectedIndex = 0; // نخلي الافتراضي "لاشئ".
        }

        private void _ApllyPersonFillter(string FilterValue) // دالة تطبيق الفلترة.
        {
            if (string.IsNullOrEmpty(FilterValue) && _FilterColumn == "لاشئ") // إذا ماكو فلتر وما مختارين عمود.
            {
                tbFilterValue.Visible = false; // نخفي حقل البحث.
                _RefreashAllPersonsList(); // نعرض كل الأشخاص من جديد.
                return;
            }

            _dtPersonsList = clsPersons.GetAllPersonsList(); // نجيب الأشخاص من جديد.
            _dvPersonsList = new DataView(_dtPersonsList); // نخليهم بـ DataView حتى نفلتر.

            switch (_FilterColumn) // نتحقق أي عمود مختارين.
            {
                case "رقم المعرف": // إذا بحثنا بالـ ID.
                    {
                        int number;
                        if (int.TryParse(FilterValue, out number)) // نحاول نحوله رقم.
                        {
                            tbFilterValue.Visible = true; // نظهر خانة البحث.
                            _dvPersonsList.RowFilter = $"[{_FilterColumn}] = {number}"; // نفلتر على الرقم.
                            lbPersonsCount.Text = _dvPersonsList.Count.ToString(); // نعرض العدد.
                        }
                        break;
                    }
                case "عدد الطلبات": // إذا بحثنا بعدد الطلبات.
                    {
                        int number;
                        if (int.TryParse(FilterValue, out number)) // إذا هو رقم.
                        {
                            tbFilterValue.Visible = true;
                            _dvPersonsList.RowFilter = $"[{_FilterColumn}] = {number}"; // فلترة على العدد.
                            lbPersonsCount.Text = _dvPersonsList.Count.ToString();
                        }
                        break;
                    }
                default: // أي عمود ثاني نصي.
                    {
                        tbFilterValue.Visible = true;
                        _dvPersonsList.RowFilter = $"[{_FilterColumn}] LIKE '{FilterValue}%'"; // نفلتر نص يبدأ بالقيمة.
                        lbPersonsCount.Text = _dvPersonsList.Count.ToString();
                        break;
                    }
            }
            dgvAllPersons.DataSource = _dvPersonsList; // نعرض النتيجة بالـ DataGridView.
        }

        private void frmPersonsManagement_Load(object sender, EventArgs e) // لما يشتغل الفورم.
        {
            _LoadData(); // نحمل البيانات.
        }

        private void pBoxAddPerson_Click(object sender, EventArgs e) // إضافة شخص جديد.
        {
            frmAddAndUpdatePerson frmAddAndUpdate = new frmAddAndUpdatePerson(); // نفتح فورم الإضافة.
            frmAddAndUpdate.ShowDialog(); // نظهره كمربع حوار.
            _RefreashAllPersonsList(); // نحدث القائمة بعد الإضافة.
        }

        private void ctmsEidtPerson_Click(object sender, EventArgs e) // تعديل شخص من القائمة.
        {
            _PersonID = (int)dgvAllPersons.CurrentRow.Cells[0].Value; // ناخذ ID للشخص.

            frmAddAndUpdatePerson frmAddAndUpdate = new frmAddAndUpdatePerson(_PersonID); // نفتح فورم التعديل مع ID.
            frmAddAndUpdate.ShowDialog();
            _RefreashAllPersonsList(); // نحدث القائمة بعد التعديل.
        }

        private void ctmsAddPerson_Click(object sender, EventArgs e) // إضافة شخص من القائمة (كليك يمين).
        {
            frmAddAndUpdatePerson frmAddAndUpdate = new frmAddAndUpdatePerson();
            frmAddAndUpdate.ShowDialog();
            _RefreashAllPersonsList();
        }

        private void ctmsDetailPerson_Click(object sender, EventArgs e) // عرض تفاصيل شخص.
        {
            _PersonID = (int)dgvAllPersons.CurrentRow.Cells[0].Value; // ناخذ ID الشخص.

            frmShowPersonInfo frmPersonCard = new frmShowPersonInfo(_PersonID); // نفتح فورم التفاصيل.
            frmPersonCard.ShowDialog();
        }

        private void ctmsDeletePerson_Click(object sender, EventArgs e) // حذف شخص.
        {
            _PersonID = (int)dgvAllPersons.CurrentRow.Cells[0].Value; // ناخذ ID الشخص.
            if (MessageBox.Show("هل انت متاكد من حذف هذا الشخص", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPersons.DeletePersonById(_PersonID)) // إذا نجح الحذف.
                {
                    _RefreashAllPersonsList();
                }
                else // إذا ما انحذف.
                {
                    MessageBox.Show(" لم يتم حذف هذا الشخص", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void cmboFilterBY_SelectedIndexChanged(object sender, EventArgs e) // تغيير خيار الفلترة.
        {
            tbFilterValue.Text = string.Empty; // نفرغ حقل البحث.
            _FilterColumn = cmboFilterBY.Text; // نخزن العمود المختار.
            if (cmboFilterBY.Text == "لاشئ") // إذا مختارين لاشيء.
            {
                tbFilterValue.Clear();
                tbFilterValue.Visible = false; // نخفي الحقل.
            }
            else
            {
                tbFilterValue.Visible = true; // نعرض الحقل.
            }
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // لما نكتب بالبحث.
        {
            if (e.KeyChar == (char)13) // إذا ضغط Enter.
            {
                // هنا ممكن نسوي بحث مباشر بالـ Enter (فارغ حالياً).
            }

            if (cmboFilterBY.Text == "رقم المعرف" || cmboFilterBY.Text == "عدد الطلبات") // إذا البحث رقمي.
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // نمنع أي كتابة غير أرقام أو أزرار تحكم.
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // إذا تغير النص بحقل البحث.
        {
            _ApllyPersonFillter(tbFilterValue.Text); // نطبق الفلترة حسب القيمة.
        }
    }
}
