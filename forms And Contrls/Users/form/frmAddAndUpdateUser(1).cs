using BusinessLayeres; // استدعاء طبقة الاعمال (Business Layer) الي بيها الكلاسات المسؤولة عن منطق النظام
using ETEZAN2024.forms_And_Contrls.Persons.Control; // استدعاء الكنترول الخاص بعرض بيانات الشخص
using System; // مكتبة الاساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة خاصة بالـ Events وعمليات الـ Validation
using System.Data; // مكتبة التعامل مع البيانات
using System.Drawing; // مكتبة التعامل مع الرسومات
using System.Linq; // مكتبة الاستعلامات LINQ
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة التعامل مع الـ Tasks
using System.Windows.Forms; // مكتبة واجهات الويندوز فورمز

namespace ETEZAN2024.forms_And_Contrls.Users.form // مساحة الاسماء الخاصة بالنماذج الخاصة بالمستخدمين
{
    public partial class frmAddAndUpdateUser : Form // كلاس الفورم المسؤول عن اضافة وتحديث المستخدم
    {
        enum enMode // تعريف ENUM حتى نحدد وضع الفورم (اضافة او تعديل)
        {
            Add = 0, Update = 1  // Add = اضافة , Update = تعديل
        }
        enMode _mode; // متغير خاص يخزن الوضع الحالي
        private int _userID; // يخزن رقم المستخدم (في حالة التحديث)
        private clsUsers _clsUsers; // كائن يمثل المستخدم (من الكلاس clsUsers)

        public frmAddAndUpdateUser() // الكونستركتر الاول للفورم (اضافة)
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _mode = enMode.Add; // نحدد الوضع على انه اضافة
        }

        public frmAddAndUpdateUser(int userID) // الكونستركتر الثاني للفورم (تعديل)
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _userID = userID; // نخزن رقم المستخدم حتى نجيبه من قاعدة البيانات
            _mode = enMode.Update; // نحدد الوضع على انه تعديل
        }

        private void _ResetDefualtValues() // دالة مسؤولة عن تهيئة القيم الافتراضية
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                lbAddAndEdit.Text = "اضافة مستخدم"; // نغير العنوان
                tpLoginInfo.Enabled = false; // نعطل تاب تسجيل الدخول
                _clsUsers = new clsUsers(); // ننشئ مستخدم جديد
                return; // نطلع من الدالة
            }
            else // اذا الوضع تعديل
            {
                lbAddAndEdit.Text = "تحديث معلومات المستخدم"; // نغير العنوان
                lbUserID.Text = "####"; // نخلي ID مبدئي
                tbUserName.Text = ""; // نفرغ التكست بوكس الخاص باليوزر
                tbPasswerd.Text = ""; // نفرغ الباسوورد
                tbConfirmPasswerd.Text = ""; // نفرغ تاكيد الباسوورد
                chkboxActive.Checked = true; // نفعل خيار فعال
            }
        }

        private void _LoadData() // دالة تحميل بيانات المستخدم في حالة التعديل
        {
            _clsUsers = clsUsers.FindUserById(_userID); // نجيب بيانات المستخدم حسب الـ ID
            if (_clsUsers == null) // اذا ما لكيناه
            {
                MessageBox.Show("لم يتم العثور علئ هذا المستخدم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ

                this.Close(); // نغلق الفورم
                return;
            }
            ctrlPersonCardWithFilter1.FillterEnable = false; // نعطل الفلترة بالكنترول

            lbUserID.Text = _clsUsers.UserID.ToString(); // نعرض رقم المستخدم
            tbUserName.Text = _clsUsers.UserName; // نعرض اسم المستخدم
            tbPasswerd.Text = _clsUsers.Password; // نعرض الباسوورد
            tbConfirmPasswerd.Text = _clsUsers.Password; // نعرض تاكيد الباسوورد
            chkboxActive.Checked = _clsUsers.isActive; // نعرض حالة التفعيل
            ctrlPersonCardWithFilter1.LoadPersonInfo(_clsUsers.PersonID); // نعرض بيانات الشخص المرتبط
        }

        private void frmAddAndUpdateUser_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _ResetDefualtValues(); // نهيئ القيم الافتراضية
            if (_mode == enMode.Update) // اذا كان تعديل
            {
                _LoadData(); // نجيب البيانات
            }
            ctrlPersonCardWithFilter1.FoucsTextBoxFilterPersonValue(); // نخلي الفوكس على مربع البحث
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e) // التحقق من اسم المستخدم
        {
            if (string.IsNullOrEmpty(tbUserName.Text)) // اذا الحقل فارغ
            {
                e.Cancel = true; // نمنع الانتقال
                errorProviderUser.SetError(tbUserName, " الرجاء قم بادخال  اسم المستخدم "); // نعرض رسالة خطأ
                return;
            }
            else
            {
                e.Cancel = false; // نسمح بالانتقال
                errorProviderUser.SetError(tbUserName, ""); // نخفي الخطأ
            }

            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                if (clsUsers.isExitsUserByUserName(tbUserName.Text.Trim())) // اذا الاسم موجود مسبقا
                {
                    e.Cancel = true;
                    errorProviderUser.SetError(tbUserName, " هذاالاسم موجود بالفعل الرجاء قم بادخال  اسم المستخدم اخر ");
                }
                else
                {
                    e.Cancel = false;
                    errorProviderUser.SetError(tbUserName, "");
                }
            }
            else // اذا تعديل
            {
                if (_clsUsers.UserName != tbUserName.Text.Trim()) // اذا غيرنا الاسم
                {
                    if (clsUsers.isExitsUserByUserName(tbUserName.Text.Trim())) // اذا الاسم الجديد موجود
                    {
                        e.Cancel = true;
                        errorProviderUser.SetError(tbUserName, " الرجاء قم بادخال  اسم المستخدم ");
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProviderUser.SetError(tbUserName, "");
                    }
                }
            }
        }

        private void tbPasswerd_Validating(object sender, CancelEventArgs e) // التحقق من كلمة المرور
        {
            if (string.IsNullOrEmpty(tbPasswerd.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderUser.SetError(tbPasswerd, " الرجاء قم بادخال  رمز المستخدم ");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(tbPasswerd, "");
            }
        }

        private void tbConfirmPasswerd_Validating(object sender, CancelEventArgs e) // التحقق من تاكيد كلمة المرور
        {
            if (string.IsNullOrEmpty(tbConfirmPasswerd.Text)) // اذا فارغ
            {
                e.Cancel = true;
                errorProviderUser.SetError(tbConfirmPasswerd, " الرجاء قم بادخال تاكيد رمز المستخدم ");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(tbConfirmPasswerd, "");
            }
            if (tbConfirmPasswerd.Text != tbPasswerd.Text) // اذا ما متطابق
            {
                e.Cancel = true;
                errorProviderUser.SetError(tbConfirmPasswerd, " الرجاء قم بادخال كرر رمز المستخدم بشكل صحيح ");
            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(tbConfirmPasswerd, "");
            }
        }

        private void btnSaveUserInfo_Click(object sender, EventArgs e) // حدث زر الحفظ
        {
            if (!this.ValidateChildren()) // التحقق من كل المدخلات
            {
                MessageBox.Show("بعض الحقول غير صحيحة!, ضع الماوس فوق الأيقونة الحمرة لترئ الخطأ", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _clsUsers.UserName = tbUserName.Text; // نخزن اسم المستخدم
            _clsUsers.Password = tbPasswerd.Text; // نخزن الباسوورد
            _clsUsers.Password = tbConfirmPasswerd.Text; // نخزن التاكيد
            _clsUsers.isActive = chkboxActive.Checked; // نخزن حالة التفعيل
            _clsUsers.PersonID = ctrlPersonCardWithFilter1.PersonID; // نخزن رقم الشخص المرتبط
            _clsUsers.PermissionID = 1; // نخلي صلاحية افتراضية
            if (_clsUsers.Save()) // اذا الحفظ نجح
            {
                lbUserID.Text = _clsUsers.UserID.ToString(); // نعرض رقم المستخدم
                lbAddAndEdit.Text = "تحديث معلومات المستخدم"; // نغير العنوان
                _mode = enMode.Update; // نغير الوضع الى تعديل
                MessageBox.Show("تم حفظ معلومات هذا الشخص", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // اذا فشل
            {
                MessageBox.Show(" لم يتم حفظ معلومات هذا الشخص", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btaCansel2_Click(object sender, EventArgs e) // زر الالغاء
        {
            this.Close(); // نغلق الفورم
        }

        private void btNext_Click(object sender, EventArgs e) // زر التالي
        {
            if (_mode == enMode.Update) // اذا تعديل
            {
                tpLoginInfo.Enabled = true; // نفعل التاب
                btnSave.Enabled = true; // نفعل الحفظ
                tpPersonInfo1.SelectedTab = tpLoginInfo; // ننتقل الى التاب
            }

            if (ctrlPersonCardWithFilter1.PersonID != -1) // اذا الشخص موجود
            {
                if (clsUsers.isExitsUserByPersnID(ctrlPersonCardWithFilter1.PersonID)) // اذا عنده مستخدم
                {
                    MessageBox.Show("هذا المستخدم  موجود بالفعل قم بالبحث عن شخص اخر او اضافه شخص جديد", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tpLoginInfo.Enabled = true;
                    btnSave.Enabled = true;
                    tpPersonInfo1.SelectedTab = tpLoginInfo;
                    ctrlPersonCardWithFilter1.FoucsTextBoxFilterPersonValue();
                }
            }
            else // اذا ما مختار شخص
            {
                MessageBox.Show("من فضلك قم بالبحث عن الشخص بمربع البحث بلا اعلئ ثم قم با اضافه المستخدم", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FoucsTextBoxFilterPersonValue();
            }
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddAndUpdateUser_Activated(object sender, EventArgs e)
        {
            // هذا الحدث يشتغل كل مرة النموذج (الفورم) يصير هو النشط، يعني المستخدم رجع عليه بعد ما كان فاتح شي ثاني.
            // الغرض من هذا الكود إنه يحدد مكان الكتابة تلقائياً داخل مربع البحث الموجود داخل الكنترول "ctrlPersonCardWithFilter1".
            // يعني أول ما الفورم يصير فعال، المؤشر (Cursor) يروح على TextBox الخاص بالبحث عن الشخص حتى المستخدم يقدر يكتب مباشرة بدون ما ينقر الماوس.

            ctrlPersonCardWithFilter1.FoucsTextBoxFilterPersonValue(); // نستدعي دالة داخل الكنترول تخلي التركيز على TextBox الخاص بالبحث.
        }
    }
}
