using BusinessLayeres; // نستدعي الطبقة الخاصة بالـ Business Layer حتى نستخدم الكلاسات والدوال بيها
using DVLD_ProjecteForms.FORMS; // نستدعي النماذج (Forms) من مشروع DVLD
using ETEZAN2024.forms.Persons; // نستدعي الكلاسات أو الفورمات الخاصة بالأشخاص
using System; // مكتبة أساسية تحتوي أنواع البيانات والدوال العامة
using System.Collections.Generic; // مكتبة تحتوي على القوائم (List) والمجموعات
using System.ComponentModel; // مكتبة خاصة بخصائص الـ Components مثل Events
using System.Data; // مكتبة التعامل مع الجداول (DataTable و DataSet)
using System.Drawing; // مكتبة الرسم والتعامل مع الصور والألوان
using System.Linq; // مكتبة لتسهيل التعامل مع المصفوفات والقوائم باستعمال LINQ
using System.Text; // مكتبة لمعالجة النصوص
using System.Threading.Tasks; // مكتبة خاصة بالمهام (Tasks) والبرمجة غير المتزامنة
using System.Windows.Forms; // المكتبة الرئيسية لتصميم واجهة المستخدم (WinForms)

namespace ETEZAN2024.forms_And_Contrls.Persons.Control // نحدد الـ namespace اللي يجمع هذا الكود
{
    public partial class ctrlPersonCardWithFilter : UserControl // كلاس يمثل UserControl مخصص لعرض بيانات الشخص مع فلترة
    {
        public Action<int> selectPerson; // نعرف حدث (Event) يستدعي Action ويرجع ID الشخص

        protected virtual void OnselectPerson(int personID) // دالة مسؤولة عن تنفيذ الحدث selectPerson
        {
            Action<int> handler = selectPerson; // نخزن الحدث المؤقت
            if (handler != null) // إذا كان الحدث مو فارغ
            {
                handler(personID); // نستدعيه ونمرر رقم الشخص
            }
        }

        public ctrlPersonCardWithFilter() // الكونستركتر الافتراضي
        {
            InitializeComponent(); // دالة تنشئ المكونات (Components) الخاصة بالواجهة
        }

        private bool _ShowAddPersn = true; // متغير يحدد إذا نعرض زر إضافة شخص أو لا
        public bool ShowAddPersn // خاصية عامة للسيطرة على زر الإضافة
        {
            get { return _ShowAddPersn; } // إرجاع القيمة
            set
            {
                _ShowAddPersn = value; // نخزن القيمة
                pBoxAddPerson.Visible = _ShowAddPersn; // نغير حالة ظهور الأيقونة
            }
        }

        private bool _FillterEnable = true; // متغير يحدد إذا الفلترة مفعلة
        public bool FillterEnable // خاصية عامة للفلترة
        {
            get { return _FillterEnable; } // إرجاع القيمة
            set
            {
                _FillterEnable = value; // نخزن القيمة
                gbPersonFilter.Enabled = _FillterEnable; // نظهر أو نخفي الـ GroupBox
            }
        }

        private int _personID = -1; // متغير يخزن رقم الشخص (افتراضي -1)
        public int PersonID // خاصية لإرجاع رقم الشخص
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        private string _FullName; // متغير يخزن الاسم الكامل
        public string fullName // خاصية لإرجاع الاسم
        {
            get { return _FullName; }
        }

        private void _FillComboBox() // دالة تملأ ComboBox بخيارات البحث
        {
            cmbFilterBy.Items.Add("معرف الشخص"); // نضيف خيار البحث برقم الشخص
            cmbFilterBy.Items.Add("الاسم الكامل"); // نضيف خيار البحث بالاسم الكامل
        }

        public clsPersons selectPersonInfo // خاصية ترجع بيانات الشخص المختار
        {
            get { return ctrlPersonCard1.SelectPersonInfo; } // ترجع بيانات من كنترول داخلي
        }
        // شرح باللهجة العراقية — رحمة لوالديك
        public ctrlPersonCard ctrlPersonCard // خاصية ترجع الكنترول اللي يمثل بطاقة الشخص
        {
            get { return ctrlPersonCard1; } // ترجع العنصر الداخلي ctrlPersonCard1 للّي يقرأ الخاصية
            set
            {
                // لما أحد يعيّن الخاصية (set) نريد ننفّذ شوية شغلات — ملاحظة: قيمة الـ 'value' هنا ما نستخدمها صراحة
                // نسوي نداء للدالة اللي تتصرف مثل الضغط على أيقونة البحث
                // يعني نريد نعمل نفس شغل الزر حتى يصير البحث أو التحضير للعرض
                pBoxFindPerson_Click(pBoxFindPerson, EventArgs.Empty);

                // بعدين نحمّل بيانات الشخص بالكنترول حسب المتغيّر _personID
                // يعني نعرض معلومات الشخص اللي رقم معرّفه مخزون ب _personID
                ctrlPersonCard1.LoadPersonInfoByID(_personID);

            }
        }
        public void FindNow() // دالة مسؤولة عن البحث
        {
            FoucsTextBoxFilterPersonValue();
            switch (cmbFilterBy.Text) // نحدد البحث حسب نوع الفلترة
            {
                case "معرف الشخص":
                    {
                        ctrlPersonCard1.LoadPersonInfoByID(int.Parse(tbFilterPerson.Text)); // نبحث بالـ ID
              
                        break;

                    }
                case "الاسم الكامل":
                    {
                        ctrlPersonCard1.LoadPersonInfoByFullName(tbFilterPerson.Text); // نبحث بالاسم


                        break;
                    }
                default:
                    {
                        break;
                    }


            }
            if (selectPerson != null && FillterEnable) // إذا الحدث موجود والفلترة مفعلة
            {
                OnselectPerson(PersonID); // نستدعي الحدث
            }
        }

        public void LoadPersonInfo(int personID) // دالة لتحميل بيانات شخص حسب ID
        {
            cmbFilterBy.SelectedIndex = 0; // نخلي الفلترة بالاسم
            tbFilterPerson.Text = personID.ToString(); // نخزن ID داخل TextBox
            FindNow(); // ننفذ البحث

         
        }

        public void FoucsTextBoxFilterPersonValue()
        {
            tbFilterPerson.Focus();
        }
        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e) // حدث عند تحميل الكنترول
        {
            _FillComboBox(); // نملأ الكومبوبوكس
            cmbFilterBy.SelectedIndex = 0; // نخلي الافتراضي أول خيار
           
        }

        private void pBoxFindPerson_Click(object sender, EventArgs e) // حدث عند الضغط على زر البحث
        {
            if (!this.ValidateChildren()) // إذا الفورم بيه أخطاء
            {
                MessageBox.Show(" حقل البحث فارغ!, ضع الماوس فوق الأيقونة الحمرة لترئ الخطأ", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // نعرض رسالة خطأ
                return; // نوقف الكود
            }
            if (cmbFilterBy.Text == "معرف الشخص")
            {
                // نفحص إذا القيمة مو رقم
                if (!int.TryParse(tbFilterPerson.Text, out int personID))
                {
                    tbFilterPerson.Clear(); // نفرغ النص
                    MessageBox.Show("من فضلك ادخل رقم معرف الشخص فقط",
                        "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // نوقف الكود
                }

                // إذا كان رقم صحيح، تكمل باقي كود الفلترة هنا
            }

            FindNow(); // ننفذ البحث
       
        }

        public void DataBackEvent(object sender, int personID) // دالة تسترجع بيانات الشخص بعد الإضافة
        {
            cmbFilterBy.SelectedIndex = 0; // نخلي الفلترة على ID
            tbFilterPerson.Text = personID.ToString(); // نعرض ID داخل التكست
            ctrlPersonCard1?.LoadPersonInfoByID(personID); // نحمل بيانات الشخص
        }

        private void pBoxAddPerson_Click(object sender, EventArgs e) // حدث الضغط على زر إضافة شخص
        {
            frmAddAndUpdatePerson frm = new frmAddAndUpdatePerson(); // نفتح فورم الإضافة
            frm.DataBack += DataBackEvent; // نربط الفورم مع حدث DataBack
            frm.ShowDialog(); // نعرض الفورم كنافذة حوارية
        }

        private void tbFilterPerson_Validating(object sender, CancelEventArgs e) // التحقق من صحة الإدخال
        {
            if (string.IsNullOrEmpty(tbFilterPerson.Text.Trim())) // إذا الحقل فارغ
            {
                e.Cancel = true; // نوقف الإجراء
                MessageBox.Show(" من فضلك ادخل بيانات الشخص الذي تريد البحث عنه اولا", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(tbFilterPerson, "رجاء ادخل بيانات الشخص الذي تريد البحث عنه"); // نعرض خطأ
            }
            else
            {
                e.Cancel = false; // نخلي الإدخال صحيح
                errorProvider1.SetError(tbFilterPerson, ""); // نمسح الخطأ

            }

        }

        private void tbFilterPerson_KeyPress(object sender, KeyPressEventArgs e) // حدث عند الضغط على أي مفتاح داخل TextBox
        {
            if (e.KeyChar == (char)13) // إذا المفتاح المضغوط هو Enter
            {
                // ممكن نضيف هنا كود بحث مباشر
            }

            if (cmbFilterBy.Text == "معرف الشخص") // إذا البحث بالـ ID
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            // نمنع أي شي غير الأرقام وأزرار التحكم
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void gbPersonFilter_Enter(object sender, EventArgs e)
        {

        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFilterPerson_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
