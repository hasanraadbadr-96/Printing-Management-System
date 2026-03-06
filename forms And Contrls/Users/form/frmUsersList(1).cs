using BusinessLayeres; // نستدعي الطبقة الي بيها عمليات المستخدمين
using ETEZAN2024.forms_And_Contrls.Users.form; // نستدعي النماذج الخاصة بإضافة وتعديل المستخدم
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة للتحقق من المدخلات
using System.Data; // مكتبة التعامل مع البيانات
using System.Drawing; // مكتبة الرسومات
using System.Linq; // مكتبة LINQ
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام
using System.Windows.Forms; // مكتبة الواجهات الرسومية

namespace ETEZAN2024.forms_And_Contrls.Users // مساحة الأسماء الخاصة بالمستخدمين
{
    public partial class frmUsersList : Form // كلاس يمثل نافذة عرض المستخدمين
    {
        private DataTable _dtUsersList; // جدول يخزن كل بيانات المستخدمين
        private DataView _dvUsersList; // DataView حتى نطبق الفلترة
        public frmUsersList() // كونستركتر للفورم
        {
            InitializeComponent(); // تهيئة المكونات
        }

        private void _RefreshUsersList() // دالة تحديث كل المستخدمين
        {
            // 1. جلب بيانات المستخدمين من الطبقة التجارية
            _dtUsersList = clsUsers.GetAllUsersList();

            // 2. ربط البيانات بـ DataGridView
            dgvAllUsers.DataSource = _dtUsersList;

            // 3. التحقق من أن البيانات فارغة أو غير موجودة
            if (dgvAllUsers.DataSource == null || dgvAllUsers.Rows.Count == 0)
            {
                // عرض عدد المستخدمين = صفر
                lbUsersCount.Text = "0";

                // تعطيل قائمة السياق لأنها تعتمد على وجود بيانات
                ctmsUsersManagement.Enabled = false;

                // تعطيل الفلتر لأنه لا فائدة منه بدون بيانات
                cmboFilterBY.Enabled = false;

                // الخروج لتجنب الوصول إلى بيانات غير موجودة
                return;
            }

            // 4. تحديث عدد المستخدمين بعد التأكد من وجود بيانات
            lbUsersCount.Text = dgvAllUsers.RowCount.ToString();

            // 5. تفعيل قائمة السياق لأنها الآن تحتوي عناصر يمكن التعامل معها
            ctmsUsersManagement.Enabled = true;

            // 6. تفعيل الفلتر لأن البيانات أصبحت جاهزة للبحث
            cmboFilterBY.Enabled = true;
        }

        private void _FillComboBoxFillterByUserInfo() // دالة تعبئة ComboBox بخيارات الفلترة حسب معلومات المستخدم
        {
            cmboFilterBY.Items.Add("لاشئ"); // فلتر فارغ
            cmboFilterBY.Items.Add("معرف المستخدم"); // فلترة حسب ID
            cmboFilterBY.Items.Add("معرف الشخص"); // فلترة حسب رقم الشخص
            cmboFilterBY.Items.Add("اسم المستخدم"); // فلترة حسب الاسم
            cmboFilterBY.Items.Add("نشط"); // فلترة حسب حالة النشاط
        }

        private void _FillComboBoxFillterByIsActive() // دالة تعبئة ComboBox الخاص بحالة النشاط
        {
            cmbIsActive.Items.Add("الكل"); // عرض الكل
            cmbIsActive.Items.Add("نعم"); // عرض النشطين فقط
            cmbIsActive.Items.Add("لا"); // عرض الغير نشطين فقط
        }

        private void frmUsersList_Load(object sender, EventArgs e) // عند تحميل الفورم
        {
            _RefreshUsersList(); // نعرض كل المستخدمين
            _FillComboBoxFillterByUserInfo(); // نملئ ComboBox الفلترة
            _FillComboBoxFillterByIsActive(); // نملئ ComboBox حالة النشاط
            cmboFilterBY.SelectedIndex = 0; // نحدد الخيار الأول
            cmbIsActive.SelectedIndex = 0; // نحدد الخيار الأول
        }

        private void _ApplyUserIFilter(string filterColumn, string filterValue) // دالة تطبق الفلترة
        {
            _dtUsersList = clsUsers.GetAllUsersList(); // نجيب كل المستخدمين
            _dvUsersList = new DataView(_dtUsersList); // نخليهم داخل DataView

            if (string.IsNullOrEmpty(filterValue) && filterColumn == "لاشئ") // اذا ماكو قيمة وماكو فلتر
            {
                tbFilterValue.Visible = false; // نخفي TextBox
                cmbIsActive.Visible = false; // نخفي ComboBox
                _RefreshUsersList(); // نعرض الكل
                return;
            }

            switch (filterColumn) // نحدد نوع الفلترة
            {
                case "معرف المستخدم": // فلترة حسب رقم المستخدم
                    {
                        tbFilterValue.Visible = true; // نظهر TextBox
                        cmbIsActive.Visible = false; // نخفي ComboBox
                        _dvUsersList.RowFilter = $"Convert(UserID, 'System.String') LIKE '%{filterValue}%'"; // فلترة بالرقم
                        lbUsersCount.Text = _dvUsersList.Count.ToString(); // تحديث العدد
                        break;
                    }

                case "معرف الشخص": // فلترة حسب رقم الشخص
                    {
                        tbFilterValue.Visible = true;
                        cmbIsActive.Visible = false;
                        _dvUsersList.RowFilter = $"Convert(PersonID, 'System.String') LIKE '{filterValue}%'"; // فلترة بالرقم
                        lbUsersCount.Text = _dvUsersList.Count.ToString();
                        break;
                    }

                case "اسم المستخدم": // فلترة حسب اسم المستخدم
                    {
                        tbFilterValue.Visible = true;
                        cmbIsActive.Visible = false;
                        _dvUsersList.RowFilter = $"UserName like '%{filterValue}%'"; // فلترة بالاسم
                        lbUsersCount.Text = _dvUsersList.Count.ToString();
                        break;
                    }

                case "نشط": // فلترة حسب حالة النشاط
                    {
                        tbFilterValue.Visible = false;
                        cmbIsActive.Visible = true;
                        if (cmbIsActive.Text == "نعم") // اذا نختار نعم
                        {
                            _dvUsersList.RowFilter = "isActive = true"; // يجيب بس النشطين
                        }
                        else if (cmbIsActive.Text == "لا") // اذا نختار لا
                        {
                            _dvUsersList.RowFilter = "isActive = false"; // يجيب الغير نشطين
                        }
                        else if (cmbIsActive.Text == "الكل") // اذا نختار الكل
                        {
                            _dvUsersList.RowFilter = ""; // يجيب الكل
                        }
                        lbUsersCount.Text = _dvUsersList.Count.ToString();
                        break;
                    }

                default: // اذا مابيه شي
                    {
                        break;
                    }
            }

            dgvAllUsers.DataSource = _dvUsersList; // نعرض النتيجة بالجدول
        }

        private void pBoxAddUser_Click(object sender, EventArgs e) // حدث الضغط على اضافة مستخدم
        {
            frmAddAndUpdateUser frmAddUser = new frmAddAndUpdateUser(); // نفتح نافذة اضافة
            frmAddUser.ShowDialog(); // نعرضها
            _RefreshUsersList(); // نحدث القائمة
        }

        private void ctmsEidtUser_Click(object sender, EventArgs e) // تعديل مستخدم
        {
            frmAddAndUpdateUser frmUpdateUser = new frmAddAndUpdateUser((int)dgvAllUsers.CurrentRow.Cells[0].Value); // نفتح نافذة تعديل حسب ID
            frmUpdateUser.ShowDialog();
            _RefreshUsersList();
        }

        private void ctmsDetailUser_Click(object sender, EventArgs e) // تفاصيل مستخدم
        {
            frmUserInfo UserInfo = new frmUserInfo((int)dgvAllUsers.CurrentRow.Cells[0].Value); // نفتح نافذة التفاصيل
            UserInfo.ShowDialog();
            _RefreshUsersList();
        }

        private void ctmsAddUser_Click(object sender, EventArgs e) // اضافة مستخدم من القائمة
        {
            frmAddAndUpdateUser frmAddUser = new frmAddAndUpdateUser();
            frmAddUser.ShowDialog();
            _RefreshUsersList();
        }

        private void ctmsDeleteUser_Click(object sender, EventArgs e) // حذف مستخدم
        {
            if (MessageBox.Show("هل انت متاكد من حذف هذا المستخدم", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // تأكيد
            {
                if (clsUsers.DeleteUserById((int)dgvAllUsers.CurrentRow.Cells[0].Value)) // اذا نجح الحذف
                {
                    _RefreshUsersList();
                }
                else // اذا فشل الحذف
                {
                    MessageBox.Show(" لم يتم حذف هذا المستخدم", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void cmboFilterBY_SelectedIndexChanged(object sender, EventArgs e) // تغيير خيار الفلترة
        {
            _ApplyUserIFilter(cmboFilterBY.Text, tbFilterValue.Text);
        }

        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e) // تغيير حالة النشاط
        {
            _ApplyUserIFilter(cmboFilterBY.Text, tbFilterValue.Text);
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // تغيير نص البحث
        {
            _ApplyUserIFilter(cmboFilterBY.Text, tbFilterValue.Text);
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // حدث الضغط على TextBox
        {
            if (e.KeyChar == (char)13) // اذا ضغط انتر
            {
                // ممكن نسوي بحث مباشر (فارغ حاليا)
            }

            if (cmboFilterBY.Text == "معرف المستخدم" || cmboFilterBY.Text == "معرف الشخص") // اذا البحث ارقام فقط
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // نمنع غير الارقام
        }
    }
}
