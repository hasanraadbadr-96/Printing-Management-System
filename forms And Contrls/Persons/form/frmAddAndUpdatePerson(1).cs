using BusinessLayeres; // نستدعي طبقة الـ Business Layer حتى نستخدم كلاس الأشخاص clsPersons
using ETEZAN2024.Properties; // نستدعي الموارد Resources (صور ذكر/أنثى مثلاً)
using System; // الأساسيات
using System.Collections.Generic;
using System.ComponentModel; // حتى نستخدم CancelEventArgs للتحقق من النصوص
using System.Data;
using System.Drawing; // الرسومات (صور، ألوان...)
using System.IO; // للتعامل مع الملفات (نسخ/حذف صور)
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // عناصر الفورم

namespace ETEZAN2024.forms.Persons
{
    public partial class frmAddAndUpdatePerson : Form // تعريف فورم إضافة/تعديل شخص
    {
        public delegate void OnselectedPerson(object sender, int personID); // تعريف Delegate يرجع رقم الشخص
        public event OnselectedPerson DataBack; // حدث يشتغل بعد الحفظ ويرجع الرقم للفورم المستدعي

        // نمط تشغيل الفورم: إضافة أو تعديل
        public enum enMode
        {
            Add = 1, Update = 2
        }

        // تحديد الجنس (ذكر/أنثى)
        public enum enGonder
        {
            Male = 0, Famel = 1
        }

        enMode _mode; // يخزن وضع الفورم الحالي (إضافة أو تعديل)
        private int _personID; // رقم الشخص
        private clsPersons _persons; // كائن من كلاس الأشخاص

        public frmAddAndUpdatePerson() // كونستركتر للإضافة
        {
            InitializeComponent(); // تحميل العناصر
            _mode = enMode.Add;  // وضع الفورم إضافة
        }

        public frmAddAndUpdatePerson(int personId) // كونستركتر للتعديل
        {
            InitializeComponent();
            _personID = personId; // نخزن رقم الشخص
            _mode = enMode.Update; // وضع الفورم تعديل
        }

        private bool _HandlePersonImageSimple() // دالة لحفظ الصورة في مجلد محلي
        {
            if (pBoxPerson.ImageLocation == null) // إذا ما مختار صورة
                return true;

            string newImagePath = pBoxPerson.ImageLocation; // مسار الصورة الأصلي

            try
            {
                string folderPath = Application.StartupPath + @"\Images\"; // مجلد الصور داخل المشروع
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath); // إذا ماكو مجلد ننشئه

                string fileName = Path.GetFileName(newImagePath); // نجيب اسم الصورة
                string destPath = Path.Combine(folderPath, fileName); // المسار الجديد
                File.Copy(newImagePath, destPath, true); // نسخ الصورة

                pBoxPerson.ImageLocation = destPath; // عرض الصورة من المسار الجديد
                return true;
            }
            catch
            {
                MessageBox.Show("ما قدرنا ننسخ الصورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void _FillComboBoxByCitiesList() // ملئ الكومبو بكس بالمدن
        {
            cmbCities.DataSource = clsCities.GetAllCitiesList(); // مصدر البيانات
            cmbCities.DisplayMember = "CityName"; // النص الظاهر
            cmbCities.ValueMember = "CityId";     // القيمة الحقيقية
        }

        private void _ResetDefualtValues() // إرجاع القيم الافتراضية
        {
            _FillComboBoxByCitiesList(); // تحميل المدن
            if (_mode == enMode.Add)
            {
                lbAddAndEdit1.Text = "اضافة شخص";
                _persons = new clsPersons(); // كائن جديد
            }
            else
            {
                lbAddAndEdit1.Text = "تعديل الشخص";
            }

            // تحميل صورة افتراضية حسب الجنس
            if (rbMale.Checked)
                pBoxPerson.Image = Resources.male;
            else
                pBoxPerson.Image = Resources.famle;

            lnkDeletePhoto.Visible = (pBoxPerson.ImageLocation != null);
            cmbCities.SelectedIndex = cmbCities.FindString("البصره"); // افتراضياً البصرة
            tbAddress.Text = "";
            tbNotes.Text = "";
            tbFullName.Text = "";
            tbPhone.Text = "";
            mtbOrderCount.Text = "";
            rbMale.Checked = true;
        }

        private void _LoadData() // تحميل بيانات الشخص عند التعديل
        {
            _persons = clsPersons.FindPersonById(_personID);
            if (_persons == null)
            {
                MessageBox.Show("لم يتم العثور علئ هذا الشخص", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // نملأ الحقول من الكائن
            lbPersonID.Text = _personID.ToString();
            tbFullName.Text = _persons.full_name;
            tbAddress.Text = _persons.address;
            tbNotes.Text = _persons.notes;
            mtbOrderCount.Text = _persons.order_count.ToString();
            tbPhone.Text = _persons.phone_number;

            if (_persons.gendor == "ذكر")
                rbMale.Checked = true;
            else
                rbFamel.Checked = true;

            cmbCities.SelectedIndex = cmbCities.FindString(_persons.CityInfo.Cityname);
            if (_persons.ImagePath != "")
                pBoxPerson.ImageLocation = _persons.ImagePath;

            lnkDeletePhoto.Visible = (pBoxPerson.ImageLocation != null);
        }

        private void frmAddAndUpdate_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues(); // نعيد الافتراضي
            if (_mode == enMode.Update)
                _LoadData(); // إذا تعديل نجيب البيانات
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pBoxPerson.ImageLocation == null)
                pBoxPerson.Image = Resources.male;
        }

        private void rbFamel_CheckedChanged(object sender, EventArgs e)
        {
            if (pBoxPerson.ImageLocation == null)
                pBoxPerson.Image = Resources.famle;
        }

        private void lnkAddPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileAddPhoto.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileAddPhoto.FileName;
                pBoxPerson.ImageLocation = imagePath; // نعرض الصورة
                _persons.ImagePath = imagePath; // نخزن المسار بالكائن
                lnkDeletePhoto.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) // زر الحفظ
        {
            if (!this.ValidateChildren()) // التحقق من المدخلات
            {
                MessageBox.Show("بعض الحقول غير صحيحة!, ضع الماوس فوق الأيقونة الحمرة لترئ الخطأ", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cityID = (cmbCities.SelectedValue != null) ? Convert.ToInt32(cmbCities.SelectedValue) : 0;
            _persons.city_id = cityID;
            _persons.full_name = tbFullName.Text.Trim();
            _persons.notes = tbNotes.Text.Trim();
            _persons.phone_number = tbPhone.Text.Trim();

            int orderCount;
            if (!int.TryParse(mtbOrderCount.Text.Trim(), out orderCount))
                orderCount = 0;
            _persons.order_count = orderCount;

            _persons.ImagePath = pBoxPerson.ImageLocation;
            _persons.address = tbAddress.Text.Trim();

            // إذا الطلبات أقل من 3 نخليه Active مثلاً
            if (_persons.order_count < 3)
                _persons.persons_status_id = 1;
            else
                _persons.persons_status_id = 2;

            if (rbMale.Checked)
                _persons.gendor = "ذكر";
            else
                _persons.gendor = "انثئ";

            if (_persons.Save()) // إذا الحفظ نجح
            {
                lbPersonID.Text = _persons.personID.ToString();
                lbAddAndEdit1.Text = "اضافة شخص";
                _mode = enMode.Update;
                DataBack?.Invoke(this, _persons.personID); // نرجع الرقم للفورم اللي ناداه
                MessageBox.Show("تم حفظ معلومات هذا الشخص", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" لم يتم حفظ معلومات هذا الشخص", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkDeletePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBoxPerson.ImageLocation = "";
            if (rbMale.Checked)
                pBoxPerson.Image = Resources.male;
            else
                pBoxPerson.Image = Resources.famle;

            lnkDeletePhoto.Visible = false;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e) // تحقق الحقول الفارغة
        {
            TextBox temp = (TextBox)sender;
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                btnSave.Enabled = false;
                errorProvider.SetError(temp, "رجاء ادخل النص المطلوب");
            }
            else
            {
                e.Cancel = false;
                btnSave.Enabled = true;
                errorProvider.SetError(temp, "");
            }
        }

        private void mtbOrderCount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(mtbOrderCount.Text))
            {
                e.Cancel = true;
                btnSave.Enabled = false;
                errorProvider.SetError(mtbOrderCount, "رجاء ادخل العدد المطلوب");
            }
            else
            {
                e.Cancel = false;
                btnSave.Enabled = true;
                errorProvider.SetError(mtbOrderCount, "");
            }
        }
    }
}
