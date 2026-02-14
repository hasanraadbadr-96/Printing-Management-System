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
        clsPersons Person = new clsPersons();
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

        private bool _HandlePersonImageSimple()
        {
            // 1. إذا المستخدم ما مختار صورة أصلاً، نطلع ونعتبر الأمور تمام
            if (string.IsNullOrEmpty(pBoxPerson.ImageLocation))
                return true;

            // 2. إذا الصورة هي نفسها المحفوظة سابقاً بالمشروع (ما غيرها المستخدم)، نطلع
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            if (pBoxPerson.ImageLocation.StartsWith(imagesFolder))
            {
                return true;
            }

            // 3. التجهيز: نحدد المسار والمجلد
            string sourceFile = pBoxPerson.ImageLocation;
            string ext = Path.GetExtension(sourceFile); // الامتداد (.jpg, .png)

            // نتأكد المجلد موجود
            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            // 4. السحر هنا: نعطي الصورة اسم جديد يعتمد على الوقت الحالي
            // مثلاً الصورة راح يصير اسمها: Image_20240212103055.jpg
            // هذا يضمن أن الاسم مستحيل يتكرر، فالويندوز ما راح يعترض أبداً
            string newName = "Img_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ext;
            string destFile = Path.Combine(imagesFolder, newName);

            try
            {
                // 5. ننسخ الصورة للمسار الجديد
                File.Copy(sourceFile, destFile, true);

                // 6. نمسح الصورة القديمة من المتغير (اختياري للنظافة) ونخلي الجديد
                pBoxPerson.ImageLocation = destFile;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("صار خطأ بنسخ الصورة: " + ex.Message);
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
            // 1. السيطرة النوعية: نشيك الحقول قبل ما نتحرك
            if (!this.ValidateChildren())
            {
                MessageBox.Show("بعض الحقول غير صحيحة!, ضع الماوس فوق الأيقونة الحمراء لترى الخطأ", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. سحب البيانات من الواجهة (UI) صبها في الكائن (Object Mapping)
            int cityID = (cmbCities.SelectedValue != null) ? Convert.ToInt32(cmbCities.SelectedValue) : 0;

            _persons.city_id = cityID;
            _persons.full_name = tbFullName.Text.Trim();
            _persons.notes = tbNotes.Text.Trim();
            _persons.phone_number = tbPhone.Text.Trim();
            _persons.address = tbAddress.Text.Trim();
            _persons.ImagePath = pBoxPerson.ImageLocation; // خزن مسار الصورة

            // 3. تحديد الجنس (Gender)
            _persons.gendor = rbMale.Checked ? "ذكر" : "أنثى";

            // 4. منطق "مطبعة الاتزان" للطلبات والحالة
            if (_mode == enMode.Add)
            {
                _persons.order_count = 0; // الزبون الجديد يبدي من الصفر
                _persons.persons_status_id = 1; // حالة "جديد" أو "نشط"
            }
            else
            {
                // بالتعديل، نحافظ على عدد طلباته السابقة
                // والحالة تتحدث تلقائياً حسب عدد طلباته (مثل ما سويت إنت بالفكر الذكي)
                _persons.persons_status_id = (_persons.order_count < 3) ? 1 : 2;
            }

            // 5. لحظة الحقيقة: استدعاء دالة الـ Save الذكية
            // الـ Save هي اللي راح تقرر تروح لـ _AddNewPerson لو _UpdatePerson بناءً على الـ Mode
            if (_persons.Save())
            {
                // إذا نجح الحفظ، نحدث الواجهة
                lbPersonID.Text = _persons.personID.ToString();
                lbAddAndEdit1.Text = "تعديل معلومات الشخص";
                _mode = enMode.Update; // نحول الوضعية لتعديل حتى إذا ضغط حفظ مرة ثانية ما يكرر الإدخال

                // نرجع الـ ID للفورم الأساسي (مثل قائمة الزبائن) حتى تتحدث القائمة
                DataBack?.Invoke(this, _persons.personID);

                MessageBox.Show("تم حفظ معلومات الشخص بنجاح في قاعدة بيانات مطبعة الاتزان", "نجاح الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("عذراً، لم يتم حفظ البيانات. ", "فشل الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


     
    }
}
