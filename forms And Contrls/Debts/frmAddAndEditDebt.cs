using BusinessLayeres; // نستدعي الطبقة اللي تحتوي على الكلاسات التجارية (Business Layer) — رحمة لوالديك
using DVLD_ProjecteForms.FORMS; // نستدعي فورمات من مشروع ثاني (لو عندك روابط) — رحمة لوالديك
using ETEZAN2024.forms.Persons; // نستدعي فورم الشخصيات عشان نستخدم الكنترول مال الشخص — رحمة لوالديك
using ETEZAN2024.forms_And_Contrls.Orders; // نستدعي فورمات الطلبيات والكنترولات المتعلقة بيها — رحمة لوالديك
using System; // مكتبة الأساسيات (DateTime, EventArgs, الخ) — رحمة لوالديك
using System.Collections.Generic; // لو نحتاج مجموعات متقدمة (List, Dictionary) — رحمة لوالديك
using System.ComponentModel; // يستخدم للـ INotify و CancelEventArgs لو احتجنا — رحمة لوالديك
using System.Data; // للعمل مع DataTable و DataView — رحمة لوالديك
using System.Drawing; // للعمل ويا الالوان والـ Graphics لو احتجنا — رحمة لوالديك
using System.Linq; // LINQ للفلترة والتحويلات — رحمة لوالديك
using System.Text; // للتعامل ويا النصوص المتقدمة — رحمة لوالديك
using System.Threading.Tasks; // اذا نريد تاسكات غير متزامنة — رحمة لوالديك
using System.Windows.Forms; // مكتبة الفورمز — رحمة لوالديك

namespace ETEZAN2024.forms_And_Contrls.Debts // مساحة الاسم مالت الفورمات الخاصة بالديون — رحمة لوالديك
{
    public partial class frmAddAndEditDebt : Form // تعريف الكلاس مالت الفورم اللي يضيف ويعدل الدين — رحمة لوالديك
    {
        enum enMode // نعرف نوعان: اضافة ولا تعديل — رحمة لوالديك
        {
            Add = 1, Update = 2 // قيمة 1 للاضافة و2 للتعديل — رحمة لوالديك
        }
        enMode _mode; // متغير يخزن المود الحاضر (Add او Update) — رحمة لوالديك
        private int _DebtID = 1; // متغير خاص يخزن رقم الدين، افتراضياً 1 — رحمة لوالديك
        private clsDebts _Debt;
        clsOrders _OrderInfo; // متغير كائن من كلاس الديون اللي نشتغل وياه — رحمة لوالديك
        public frmAddAndEditDebt() // الكونستركتور الافتراضي للفورم (وضع اضافة) — رحمة لوالديك
        {
            InitializeComponent(); // يهيء كل عناصر الفورم المصمم — رحمة لوالديك
            _mode = enMode.Add; // نخلي الوضع اضافة لان ما جابتنا ID — رحمة لوالديك
        }
        public frmAddAndEditDebt(int DebtID) // كونستركتور اذا نريد نفتح للتعديل مع ID — رحمة لوالديك
        {
            InitializeComponent(); // نهيء عناصر الفورم — رحمة لوالديك
            _DebtID = DebtID; // نخزن الـ ID اللي اجانا — رحمة لوالديك
            _mode = enMode.Update; // نخلي الوضع تعديل — رحمة لوالديك
        }
        private void _ResetDefualtValues() // دالة تفرغ الحقول وتخلي قيم افتراضية — رحمة لوالديك
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة — رحمة لوالديك

            {
                lbAddAndEdit.Text = "اضافة مدين"; // نغير عنوان الجزء الى اضافة — رحمة لوالديك
                tpDeptInfo.Enabled = false; // نخلي تاب الديون مغلق لحد ما نختار شخص — رحمة لوالديك
                _Debt = new clsDebts(); // ننشئ كائن دين جديد عشان نخزن بيه — رحمة لوالديك
                return; // نخرج من الدالة — رحمة لوالديك
            }


            lbDebtID.Text = "####"; // نخلي علامات مكان رقم الدين — رحمة لوالديك
            lbOrderID.Text = "####"; // نخلي علامات مكان رقم الطلب المرتبط — رحمة لوالديك
            lbDebtorName.Text = "####"; // نخلي علامات مكان اسم المدين — رحمة لوالديك
            lbAdress.Text = "####"; // نخلي علامات مكان العنوان — رحمة لوالديك
            lbPhone.Text = "####"; // نخلي علامات مكان الهاتف — رحمة لوالديك
            lbUserName.Text = "####"; // نخلي علامات مكان اسم المستخدم — رحمة لوالديك
            dtpDebtDate.Text = "####"; // نخلي علامات مكان التاريخ (يعتمد على كونترول التاريخ) — رحمة لوالديك
            tbDebtAmount.Text = "####"; // نخلي علامات مكان المبلغ — رحمة لوالديك
            chkboxIsActive.Text = "####"; // نخلي علامات مكان حالة الدين — رحمة لوالديك
        }
        private void _FillDebtInfo() // دالة تملأ البيانات من الكائن _Debt — رحمة لوالديك
        {
            ctrlPersonCardWithFilter1.LoadPersonInfo(_Debt.persons_id); // نحمّل معلومات الشخص بالكنترول حسب الـ persons_id — رحمة لوالديك

            lbDebtID.Text = _Debt.DebtID.ToString(); // نعرض رقم الدين — رحمة لوالديك
            lbOrderID.Text = _Debt.orders_id.ToString(); // نعرض رقم الطلب المُربوط — رحمة لوالديك
            lbDebtorName.Text = ctrlPersonCardWithFilter1.selectPersonInfo.full_name; // نعرض اسم المدين من الكنترول — رحمة لوالديك
            lbAdress.Text = ctrlPersonCardWithFilter1.selectPersonInfo.address; // نعرض العنوان من الكنترول — رحمة لوالديك
            lbPhone.Text = ctrlPersonCardWithFilter1.selectPersonInfo.phone_number; // نعرض رقم الهاتف من الكنترول — رحمة لوالديك
            lbUserName.Text = _Debt.UserInfo.UserName; // نعرض اسم المستخدم المرتبط من كلاس الـ Debt — رحمة لوالديك
            dtpDebtDate.Text = _Debt.debt_date.ToString(); // نعرض تاريخ الدين كنص — رحمة لوالديك
            tbDebtAmount.Text = _Debt.debt_amount.ToString(); // نعرض مبلغ الدين — رحمة لوالديك
            if (_Debt.isActive) // إذا كان الدين فعال — رحمة لوالديك
            {
                chkboxIsActive.Checked = true; // نعلم الـ CheckBox — رحمة لوالديك
            }
            else // إذا غير فعال — رحمة لوالديك
            {
                chkboxIsActive.Checked = false; // نلغي العلامة — رحمة لوالديك
            }
        }
        private void _LoadData() // دالة تجيب البيانات من القاعدة حسب _DebtID — رحمة لوالديك
        {
            _Debt = clsDebts.Find(_DebtID); // نبحث عن الدين بهذا الـ ID — رحمة لوالديك

            if (_Debt == null) // إذا ما لكينا بيانات — رحمة لوالديك
            {
                _ResetDefualtValues(); // نفرغ الحقول بالقيم الافتراضية — رحمة لوالديك
                MessageBox.Show("لم يتم العثور علئ هذا المدين", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ — رحمة لوالديك
                this.Close(); // نغلق الفورم لان ماكو بيانات نعرضها — رحمة لوالديك
                return; // نوقف الدالة — رحمة لوالديك
            }

            _FillDebtInfo(); // إذا لكينا البيانات نعرضها بالفورم — رحمة لوالديك
        }

        private void frmAddDebt_Load(object sender, EventArgs e) // حدث تحميل الفورم — رحمة لوالديك
        {
            if (_mode == enMode.Update) // اذا جينا للتعديل — رحمة لوالديك
            {
                _LoadData(); // نجيب البيانات ونملأها — رحمة لوالديك
            }
            else
            {
                _ResetDefualtValues(); // لا، وضع اضافة فارغ القيم — رحمة لوالديك
            }
        }

        private void tpDeptInfo_Click(object sender, EventArgs e) // حدث نصفي لو احتجت تتعامل مع النقر على التاب — رحمة لوالديك
        {

        }

        private void btaCansel2_Click(object sender, EventArgs e) // زر الغاء — رحمة لوالديك
        {
            this.Close(); // نغلق الفورم — رحمة لوالديك
        }

        private void btnSaveDebtInfo_Click(object sender, EventArgs e) // زر الحفظ — رحمة لوالديك
        {
            if (!this.ValidateChildren()) // اذا الحقول فيها خطأ (Validators) — رحمة لوالديك
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ — رحمة لوالديك
                return; // نوقف الحفظ — رحمة لوالديك
            }
            _Debt.debtor_name = ctrlPersonCardWithFilter1.selectPersonInfo.full_name; // نخزن اسم المدين من الكنترول — رحمة لوالديك
            _Debt.address = ctrlPersonCardWithFilter1.selectPersonInfo.address; // نخزن العنوان من الكنترول — رحمة لوالديك
            _Debt.phone_number = ctrlPersonCardWithFilter1.selectPersonInfo.phone_number; // نخزن الهاتف من الكنترول — رحمة لوالديك
            _Debt.debt_date = dtpDebtDate.Value; // نخزن التاريخ من الكونترول — رحمة لوالديك
            _Debt.debt_amount = decimal.Parse(tbDebtAmount.Text); // نحول النص الى decimal ونخزنه — رحمة لوالديك
            _Debt.persons_id = ctrlPersonCardWithFilter1.PersonID; // نخزن PersonID من الكنترول — رحمة لوالديك
            _Debt.users_id = clsGlobal.CurrentUser.UserID; // نخزن اليوزر الحالي اللي عامل العملية — رحمة لوالديك
            if (chkboxIsActive.Checked) // إذا كان الدين فعال — رحمة لوالديك
            {
                _Debt.isActive = true; // نخليه فعال — رحمة لوالديك
            }
            else // اذا مو مفعل — رحمة لوالديك
            {
                _Debt.isActive = false; // نخليه غير فعال — رحمة لوالديك
            }
            if (clsOrders.isExistByPersonID(_Debt.persons_id)) // اذا الشخص عنده طلب مرتبط — رحمة لوالديك
            {
                _Debt.orders_id = _Debt.OrderInfo.orderID; // نحط رقم الطلب بالـ Debt (يرجع من CurrentOrderInfo) — رحمة لوالديك
                lbDebtID.Text = _Debt.DebtID.ToString(); // نعرض رقم الدين (لو موجود) — رحمة لوالديك
                lbOrderID.Text = _Debt.orders_id.ToString(); // نعرض رقم الطلب — رحمة لوالديك
                lbDebtorName.Text = _Debt.debtor_name; // نعرض اسم المدين — رحمة لوالديك
                lbAdress.Text = _Debt.address; // نعرض العنوان — رحمة لوالديك
                lbPhone.Text = _Debt.phone_number; // نعرض الهاتف — رحمة لوالديك
                lbUserName.Text = _Debt.UserInfo.UserName; // نعرض اسم المستخدم اللي سجل الدين — رحمة لوالديك
            }
            else // اذا ماكو طلب للشخص — رحمة لوالديك
            {
                if (MessageBox.Show("  لم يتم العثور على طلب لهذا الشخص  !! هل تريد اضافه طلب لهذا الشخص ووضع الدين عليه ",
                    "خطاء", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) // نسأل المستخدم — رحمة لوالديك
                {
                    frmAddAndEditOrders frmAdd = new frmAddAndEditOrders(); // نفتح شاشة اضافة الطلب — رحمة لوالديك

                    frmAdd.PersonID = ctrlPersonCardWithFilter1.PersonID; // نمرر الـ PersonID للفورم الجديد — رحمة لوالديك
                    frmAdd.PersonCardWithFilter = this.ctrlPersonCardWithFilter1; // نمرر الكنترول نفسه حتى يبقى متزامن — رحمة لوالديك

                    frmAdd.ShowDialog(); // نعرض الفورم كحوار modal — رحمة لوالديك

                }

            }


            if (_Debt.Save()) // نحاول نحفظ الـ Debt — رحمة لوالديك
            {
                lbDebtID.Text = _Debt.DebtID.ToString(); // نعرض رقم الدين بعد الحفظ — رحمة لوالديك
                lbAddAndEdit.Text = "تعديل معلومات الدين"; // نغير النص لان الحين الوضع تعديل — رحمة لوالديك
                _mode = enMode.Update; // نحول المود لتعديل — رحمة لوالديك
                MessageBox.Show("تم حفظ معلومات الدين", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information); // رسالة نجاح — رحمة لوالديك
            }
            else
            {
                MessageBox.Show("  لم يتم حفظ المعلومات اضغط علئ كلمه حفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning); // رسالة فشل — رحمة لوالديك
            }
        }

        private void lnkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // لو يريد يعدل بيانات الشخص المرتبط — رحمة لوالديك
        {
            frmAddAndUpdatePerson editPerson = new frmAddAndUpdatePerson(ctrlPersonCardWithFilter1.PersonID); // نفتح فورم تعديل الشخص مع الـ PersonID — رحمة لوالديك
            editPerson.ShowDialog(); // نظهر الفورم كحوار — رحمة لوالديك
            _LoadData(); // نعيد تحميل البيانات بعد التعديل — رحمة لوالديك
        }

        private void btNext_Click(object sender, EventArgs e) // زر التالي ليننتقل لتبويب بيانات الدين — رحمة لوالديك
        {
            if (_mode == enMode.Add) // اذا نريد اضافة — رحمة لوالديك
            {
                if (ctrlPersonCardWithFilter1.selectPersonInfo == null) // اذا ما تم اختيار شخص — رحمة لوالديك
                {
                    tpDeptInfo.Enabled = false; // نخلي تاب الديون معطل
                    MessageBox.Show("من فضلك ابحث عن شخص أو اضفه أولاً", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نطلب اختيار شخص — رحمة لوالديك
                    return; // نرجع — رحمة لوالديك
                }
                else
                {
                    _OrderInfo = clsOrders.FindOrderByPersonID(ctrlPersonCardWithFilter1.PersonID);
                    
                    lbDebtorName.Text = ctrlPersonCardWithFilter1.selectPersonInfo.full_name; // نعرض اسم المدين
                    lbAdress.Text = ctrlPersonCardWithFilter1.selectPersonInfo.address; // نعرض العنوان
                    lbPhone.Text = ctrlPersonCardWithFilter1.selectPersonInfo.phone_number; // نعرض رقم الهاتف
                     lbUserName.Text = clsGlobal.CurrentUser.UserName; // 
                    tpDeptInfo.Enabled = true; // نفعل تاب الديون — رحمة لوالديك
                    tpDebtsInfo.SelectedTab = tpDeptInfo; // نختار التاب مال الديون — رحمة لوالديك

                    if (_OrderInfo == null)
                    {
                        lbOrderID.Text = "لايوجد لديه طلب"; // نعرض رقم الدين
                        return;
                    }
                    lbOrderID.Text = _OrderInfo.orderID.ToString(); // نعرض رقم الدين
                }

            }
            else
            {
                tpDeptInfo.Enabled = true; // اذا تعديل نخليه مفعل — رحمة لوالديك
                tpDebtsInfo.SelectedTab = tpDeptInfo; // ونختاره — رحمة لوالديك
            }


        }



        private void tbDebtAmount_KeyPress(object sender, KeyPressEventArgs e) // نمنع حروف غير الارقام في حقل المبلغ — رحمة لوالديك
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // اذا الحرف مو رقم ولا زر تحكم — رحمة لوالديك
            {
                e.Handled = true; // نمنعه — رحمة لوالديك
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة تنبيه — رحمة لوالديك
            }
        }

        private void tpDeptInfo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbDebtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDebtAmount.Text))
            {
                e.Cancel = true;
                errorProviderDebts.SetError(tbDebtAmount, "من فضلك ادخل مبلغ الدين");
            }
            else
                errorProviderDebts.SetError(tbDebtAmount, "");
        }

        private void frmAddAndEditDebt_Activated(object sender, EventArgs e)
        {
            // هذا الحدث يشتغل كل مرة النموذج (الفورم) يصير هو النشط، يعني المستخدم رجع عليه بعد ما كان فاتح شي ثاني.
            // الغرض من هذا الكود إنه يحدد مكان الكتابة تلقائياً داخل مربع البحث الموجود داخل الكنترول "ctrlPersonCardWithFilter1".
            // يعني أول ما الفورم يصير فعال، المؤشر (Cursor) يروح على TextBox الخاص بالبحث عن الشخص حتى المستخدم يقدر يكتب مباشرة بدون ما ينقر الماوس.

            ctrlPersonCardWithFilter1.FoucsTextBoxFilterPersonValue(); // نستدعي دالة داخل الكنترول تخلي التركيز على TextBox الخاص بالبحث.
        }

    }
}
