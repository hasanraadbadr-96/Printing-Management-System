using BusinessLayeres; // نستدعي طبقة الـ Business حتى نستخدم كلاس الأشخاص clsPersons.
using ETEZAN2024.forms_And_Contrls.Persons.form; // نستدعي فورمات الأشخاص (مثل frmAddAndUpdate).
using ETEZAN2024.Presenters;
using EtezanPrinting_Shared.PersonDTO;
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
        clsPersons person = new clsPersons();
        public frmPersonsList() // كونستركتر للفورم.
        {
            InitializeComponent(); // يهيئ مكونات الفورم (الأدوات).

            _PersonPresenter = new clsPersonPresenters(); // إنشاء كائن من كلاس العروض.
        }

        private int _PersonID; // متغير يخزن معرف الشخص المختار.
        private string _FilterColumn; // يخزن اسم العمود اللي نبحث بيه.
        private DataTable _dtPersonsList; // جدول يخزن كل الأشخاص.
        private DataView _dvPersonsList; // View للجدول حتى نطبق عليه الفلاتر.
        private clsPersonPresenters _PersonPresenter; // كائن من كلاس العروض.
        private int _RowsNumber = 10; // عدد الصفوف لكل صفحة.
                                      // دالة لتحميل صفحة من الأشخاص.

        private void LoadPersonsPage(int StartPersonID, int rowsNumber, string direction)
        {
            // 1. جلب البيانات من البرزنتير
            List<PersonDTO> personsList = _PersonPresenter.LoadPersonsPaged(StartPersonID, rowsNumber, direction);

            // 2. التحقق من وجود بيانات لتجنب الـ NullReference
            if (personsList == null || personsList.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لعرضها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. خزن البيانات في المتغير العام حتى نكدر نفلترها لاحقاً بالكومبو بوكس
            _mainPersonsList = personsList;

            // 4. ربط القائمة بالـ DataGridView
            dgvAllPersons.DataSource = null; // تصفير القديم لضمان التحديث
            dgvAllPersons.DataSource = _mainPersonsList;

            // 5. --- مرحلة التعريب (Professional Localization) ---
            dgvAllPersons.Columns["personID"].HeaderText = "رقم المعرف";
            dgvAllPersons.Columns["full_name"].HeaderText = "الاسـم الكامل";
            dgvAllPersons.Columns["phone_number"].HeaderText = "رقم الهاتف";
            dgvAllPersons.Columns["order_count"].HeaderText = "عدد الطلبات";
            dgvAllPersons.Columns["address"].HeaderText = "العنوان";
            dgvAllPersons.Columns["gendor"].HeaderText = "الجنس";
            dgvAllPersons.Columns["notes"].HeaderText = "ملاحظات";

            // 6. --- مرحلة تنظيف الواجهة (UI Cleaning) ---
            // نخفي الأعمدة اللي ما يحتاجها الموظف بس يحتاجها المبرمج
            if (dgvAllPersons.Columns.Contains("city_id")) dgvAllPersons.Columns["city_id"].Visible = false;
            if (dgvAllPersons.Columns.Contains("persons_status_id")) dgvAllPersons.Columns["persons_status_id"].Visible = false;
            if (dgvAllPersons.Columns.Contains("ImagePath")) dgvAllPersons.Columns["ImagePath"].Visible = false;

            // 7. تحديث العداد وتفعيل الأدوات
            lbPersonsCount.Text = personsList.Count.ToString();
            ctmsPersonsManagement.Enabled = true;
            cmboFilterBY.Enabled = true;
        }



















        private void _LoadPersonsPagedPresenters() // دالة لتحديث قائمة الأشخاص.
        {
            // نعرض أول صفحة من الأشخاص.
            LoadPersonsPage(0, _RowsNumber, "Next");

           
        }

        private void _FillComboBox()
        {
            cmboFilterBY.Items.Clear();
            cmboFilterBY.Items.Add("لاشئ");
            cmboFilterBY.Items.Add("رقم المعرف");
            cmboFilterBY.Items.Add("الاسـم");
            cmboFilterBY.Items.Add("رقم الهاتف");
            cmboFilterBY.Items.Add("عدد الطلبات");
        }
        private void _LoadData() // دالة تحميل البيانات الأساسية للفورم.
        {
            _LoadPersonsPagedPresenters(); // نعرض كل الأشخاص.
            _FillComboBox(); // نملئ الكومبو بوكس بالأعمدة.
            cmboFilterBY.SelectedIndex = 0; // نخلي الافتراضي "لاشئ".
        }

        private List<PersonDTO> _mainPersonsList; // قائمة البيانات الأصلية

        private void _ApplyPersonFilter(string FilterValue)
        {
            // إذا كان البحث فارغاً، نعيد عرض القائمة الأصلية كاملة
            if (string.IsNullOrEmpty(FilterValue) || _FilterColumn == "لاشئ")
            {
                dgvAllPersons.DataSource = _mainPersonsList;
                return;
            }

            // فلترة القائمة باستخدام LINQ حسب الخيار المختار في الكومبو بوكس
            IEnumerable<PersonDTO> filteredData;

            switch (_FilterColumn)
            {
                case "رقم المعرف":
                    filteredData = _mainPersonsList.Where(p => p.personID.ToString().StartsWith(FilterValue));
                    break;
                case "الاسـم":
                    filteredData = _mainPersonsList.Where(p => p.full_name.ToLower().Contains(FilterValue.ToLower()));
                    break;
                case "رقم الهاتف":
                    filteredData = _mainPersonsList.Where(p => p.phone_number.Contains(FilterValue));
                    break;
                case "عدد الطلبات":
                    filteredData = _mainPersonsList.Where(p => p.order_count.ToString() == FilterValue);
                    break;
                default:
                    filteredData = _mainPersonsList;
                    break;
            }

            dgvAllPersons.DataSource = filteredData.ToList();
        }
        private void frmPersonsManagement_Load(object sender, EventArgs e) // لما يشتغل الفورم.
        {
            _LoadData(); // نحمل البيانات.
        }

        private void pBoxAddPerson_Click(object sender, EventArgs e) // إضافة شخص جديد.
        {
            frmAddAndUpdatePerson frmAddAndUpdate = new frmAddAndUpdatePerson(); // نفتح فورم الإضافة.
            frmAddAndUpdate.ShowDialog(); // نظهره كمربع حوار.
            _LoadPersonsPagedPresenters(); // نحدث القائمة بعد الإضافة.
        }

        private void ctmsEidtPerson_Click(object sender, EventArgs e) // تعديل شخص من القائمة.
        {
            _PersonID = (int)dgvAllPersons.CurrentRow.Cells[0].Value; // ناخذ ID للشخص.

            frmAddAndUpdatePerson frmAddAndUpdate = new frmAddAndUpdatePerson(_PersonID); // نفتح فورم التعديل مع ID.
            frmAddAndUpdate.ShowDialog();
            _LoadPersonsPagedPresenters(); // نحدث القائمة بعد التعديل.
        }

        private void ctmsAddPerson_Click(object sender, EventArgs e) // إضافة شخص من القائمة (كليك يمين).
        {
            frmAddAndUpdatePerson frmAddAndUpdate = new frmAddAndUpdatePerson();
            frmAddAndUpdate.ShowDialog();
            _LoadPersonsPagedPresenters();
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
                if (person.DeletePersonById(_PersonID)) // إذا نجح الحذف.
                {
                    _LoadPersonsPagedPresenters();
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
            _ApplyPersonFilter(tbFilterValue.Text); // نطبق الفلترة حسب القيمة.
        }


        private void PboxNext_Click(object sender, EventArgs e)
        // حدث الضغط على زر "التالي" للتنقل بين صفحات الأشخاص
        {
  

            int StartPersonID = Convert.ToInt32(dgvAllPersons.Rows[dgvAllPersons.Rows.Count - 1].Cells[0].Value);
            // الحصول على معرف آخر شخص موجود في الصفحة الحالية (Paging)
            LoadPersonsPage(StartPersonID, _RowsNumber, "Next");
            lbPersonsCount.Text = dgvAllPersons.Rows.Count.ToString();
            // تحديث عداد الأشخاص بالعدد الجديد
        }


private void PboxPrevious_Click(object sender, EventArgs e)
    {
        // 1. التأكد أن الجدول ليس فارغاً
        if (dgvAllPersons.Rows.Count == 0)
        {
            MessageBox.Show("لا توجد بيانات للعرض");
            return;
        }

        // 2. الوصول لأول ID في الصفحة الحالية
        // بما أن الـ DataSource أصبح List، الوصول للقيم صار أسهل وأضمن
        int firstPersonID = ((PersonDTO)dgvAllPersons.Rows[0].DataBoundItem).personID;

        // 3. طلب البيانات السابقة من البرزنتير (يرجع List حالياً)
        List<PersonDTO> previousList = _PersonPresenter.LoadPersonsPaged(firstPersonID, _RowsNumber, "Previous");

        // 4. التحقق من وجود بيانات
        if (previousList == null || previousList.Count == 0)
        {
            MessageBox.Show("وصلت لبداية الصفحة الأولى", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // 5. الترتيب باستخدام LINQ (بدل دوخة الـ DataView والـ Sort)
        // نقوم بترتيب القائمة تصاعدياً حسب الـ ID لضمان عرضها بشكل صحيح
        var sortedList = previousList.OrderBy(p => p.personID).ToList();

        // 6. عرض البيانات وتحديث العداد
        dgvAllPersons.DataSource = sortedList;
        lbPersonsCount.Text = sortedList.Count.ToString();
    }
}

}
