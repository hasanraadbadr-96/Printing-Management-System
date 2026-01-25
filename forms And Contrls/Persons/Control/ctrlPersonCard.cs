using BusinessLayeres; // نستدعي طبقة الاعمال حتى نستخدم الكلاسات الخاصة بالمنطق
using DVLD_ProjecteForms.FORMS; // نستدعي الفورمات الخاصة بالمشروع
using ETEZAN2024.forms.Persons; // نستدعي النماذج الخاصة بالاشخاص
using ETEZAN2024.Properties; // نستدعي الموارد Resources مثل الصور
using System; // مكتبة الاساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // حتى نستخدم خصائص التحكم مثل خاصية التصميم
using System.Data; // مكتبة البيانات
using System.Drawing; // مكتبة الرسومات
using System.Linq; // حتى نستخدم دوال الاستعلام على الكولكشن
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام الغير متزامنة
using System.Windows.Forms; // مكتبة الواجهات

namespace ETEZAN2024.forms_And_Contrls.Persons.Control // مساحة الاسم حتى نرتب الكود
{
    public partial class ctrlPersonCard : UserControl // تعريف كنترول مخصص يرث من UserControl
    {
        private int _PersonID; // متغير يخزن رقم الشخص
        private clsPersons _Persons; // كائن من كلاس الاشخاص حتى نخزن بيانات الشخص

        private string _fullName ;
        public string fullName { 
            get {return _fullName;}}


        public ctrlPersonCard() // الكونستركتر مال الكنترول
        {
            InitializeComponent(); // تهيئة مكونات الفورم
        }

        public int PersonID // خاصية للقراءة فقط ترجع رقم الشخص
        {
            get { return _PersonID; } // ترجع قيمة المتغير الخاص برقم الشخص
        }

        public clsPersons SelectPersonInfo // خاصية للقراءة فقط ترجع كائن الشخص
        {
            get { return _Persons; } // ترجع بيانات الشخص
        }

        public void ResetPersonInfo() // دالة ترجع القيم الافتراضية
        {
            lnkEditPerson.Visible = false; // نخفي رابط التعديل
            lbPersonID.Text = "####"; // نخلي النص فارغ بشكل رمزي
            lbFullName.Text = "####";
            lbCity.Text = "####";
            lbGonder.Text = "####";
            lbNotes.Text = "####";
            lbOrderCount.Text = "####";
            lbPhone.Text = "####";
            lbAddress.Text = "####";
            lbNationalNo.Visible = false; // نخفي الرقم الوطني
        }

        private void _LoadPersonImage() // دالة تعرض صورة الشخص
        {
            if (_Persons.gendor == "ذكر") // اذا الشخص ذكر
            {
                pBoxPerson.Image = Resources.male; // نعرض صورة افتراضية للذكر
            }
            else if (_Persons.gendor == "انثئ") // اذا انثى
            {
                pBoxPerson.Image = Resources.famle; // نعرض صورة افتراضية للانثى
            }
            if (_Persons.ImagePath != "") // اذا عنده صورة مرفوعة
            {
                pBoxPerson.Load(_Persons.ImagePath); // نحمل الصورة من المسار
            }
        }

        private void _FillPersonInfo() // دالة تملأ البيانات داخل الليبلات
        {
            lnkEditPerson.Visible = true; // نظهر رابط التعديل
            lbPersonID.Text = _Persons.personID.ToString(); // نخزن رقم الشخص
            lbFullName.Text = _Persons.full_name; // نخزن الاسم الكامل
            lbCity.Text = _Persons.CityInfo.Cityname; // نخزن اسم المدينة
            lbGonder.Text = _Persons.gendor; // نخزن الجنس
            lbNotes.Text = _Persons.notes; // نخزن الملاحظات
            lbOrderCount.Text = _Persons.order_count.ToString(); // عدد الطلبات
            lbPhone.Text = _Persons.phone_number; // نخزن رقم الهاتف
            lbAddress.Text = _Persons.address; // نخزن العنوان
            lbNationalNo.Visible = false; // نخفي الرقم الوطني
            _LoadPersonImage(); // نستدعي تحميل الصورة
        }

        public void LoadPersonInfoByID(int personID) // دالة تحميل بيانات شخص معين
        {
            _PersonID = personID; // نخزن رقم الشخص
            _Persons = clsPersons.FindPersonById(_PersonID); // نبحث عن بيانات الشخص
            
            if (_Persons == null) // اذا ماكو بيانات
            {
                ResetPersonInfo(); // نرجع للقيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا الشخص", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نطلع من الدالة
            }
            _FillPersonInfo(); // اذا موجود نعرض بياناته
        }

        public void LoadPersonInfoByFullName(string Name)
        {

            _fullName = Name;
            _Persons = clsPersons.FindPersonByFullName(_fullName);
            if (_Persons == null)
            {
                ResetPersonInfo(); // نرجع للقيم الافتراضية
                MessageBox.Show("لم يتم العثور علئ هذا الشخص", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نطلع من الدالة
            }
            _FillPersonInfo();
            _PersonID = _Persons.personID;

        }
        

        
        private void ctrlPersonCard_Load(object sender, EventArgs e) // حدث تحميل الكنترول
        {
            // حالياً فارغ
        }

        private void btnClose_Click(object sender, EventArgs e) // حدث الضغط على زر الاغلاق
        {
            this.ParentForm.Close(); // نغلق الفورم الرئيسي
        }

        private void lnkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // حدث الضغط على رابط التعديل
        {
            frmAddAndUpdatePerson frmEdit = new frmAddAndUpdatePerson(_PersonID); // نفتح فورم التعديل ونمرر رقم الشخص
            frmEdit.ShowDialog(); // نعرضه كـ Dialog
            LoadPersonInfoByID(_PersonID); // نعيد تحميل البيانات بعد التعديل
        }
    }
}
