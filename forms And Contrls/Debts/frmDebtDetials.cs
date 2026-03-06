using BusinessLayeres; // نستدعي طبقة الـ Business حتى نستعمل الكلاس clsDebts
using ETEZAN2024.forms_And_Contrls.Inventories; // نستدعي فورمات خاصة بالمخازن (ممكن نحتاجها)
using EtezanPrinting_Shared.Depts;
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة خاصة بالـ Components
using System.Data; // مكتبة للتعامل ويا الـ DataTable
using System.Drawing; // مكتبة للرسم والتحكم بالألوان
using System.Linq; // مكتبة الاستعلامات
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام المتزامنة
using System.Windows.Forms; // مكتبة النوافذ (Windows Forms)

namespace ETEZAN2024.forms_And_Contrls.Debts // فضاء الأسماء للفورمات الخاصة بالديون
{
    public partial class frmDebtDetials : Form // تعريف فورم عرض تفاصيل الدين
    {
        private int _DebtID = 1; // متغير خاص يخزن رقم الدين، افتراضياً 1
        private clsDebts _Debt; // متغير كائن من كلاس الديون
     //   clsDebts debts = new clsDebts();
        public frmDebtDetials(int DebtID) // كونستركتر يستلم ID
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _DebtID = DebtID; // نخزن ID المرسل بالفورم
        }

        private void _ResetDefualtValues() // دالة تفرغ الحقول وتخلي قيم افتراضية
        {
            lbDebtID.Text = "####"; // نخلي علامات مكان رقم الدين
            lbDebtorName.Text = "####"; // نخلي علامات مكان اسم المدين
            lbAdress.Text = "####"; // نخلي علامات مكان العنوان
            lbPhone.Text = "####"; // نخلي علامات مكان الهاتف
            lbUserName.Text = "####"; // نخلي علامات مكان اسم المستخدم
            lbDebtDate.Text = "####"; // نخلي علامات مكان التاريخ
            lbDebtAmount.Text = "####"; // نخلي علامات مكان المبلغ
            lbIsActive.Text = "####"; // نخلي علامات مكان حالة الدين
        }

        private void _FillDebtInfo() // دالة تملأ البيانات من الكائن _Debt
        {
            lbDebtID.Text = _Debt.DebtID.ToString(); // نعرض رقم الدين
            lbOrderID.Text = _Debt.orders_id.ToString(); // نعرض رقم الدين

            lbDebtorName.Text = _Debt.debtor_name; // نعرض اسم المدين
            lbAdress.Text = _Debt.address; // نعرض العنوان
            lbPhone.Text = _Debt.phone_number; // نعرض رقم الهاتف
            lbUserName.Text = _Debt.UserInfo.UserName; // نعرض اسم المستخدم المرتبط
            lbDebtDate.Text = _Debt.debt_date.ToString(); // نعرض تاريخ الدين
            lbDebtAmount.Text = _Debt.debt_amount.ToString(); // نعرض مبلغ الدين
            if (_Debt.isActive) // إذا كان الدين فعال
            {
                lbIsActive.Text = "نشط"; // نكتب "نشط"
            }
            else // إذا غير فعال
            {
                lbIsActive.Text = "لا"; // نكتب "لا"
            }
        }
        // شلنا الـ static حتى نشتغل على النسخة الحالية

        private void _LoadData(int DebtID)
        {
            // 1. خزن الـ ID
            _DebtID = DebtID;

            // 2. الاستدعاء الصحيح (استخدم اسم الكلاس مباشرة إذا كانت الدالة Static)
            // لاحظ هنا استخدمنا اسم الكلاس clsDebts مو اسم الكائن debts
            _Debt = clsDebts.Find(_DebtID);

            // 3. الفحص الدفاعي (Defensive Check)
            if (_Debt == null)
            {
                _ResetDefualtValues();
                MessageBox.Show("عذراً، لم يتم العثور على هذا السجل (ID: " + _DebtID + ") في قاعدة البيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // 4. إذا عبرت لهنا، معناها البيانات موجودة وآمنة 100%
            _FillDebtInfo();
        }
        private void frmDebtDetials_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _LoadData(_DebtID); // نستدعي تحميل البيانات عند تشغيل الفورم
        }

        private void lnkEditProductPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // حدث عند الضغط على رابط التعديل
        {
            frmAddAndEditDebt frmEdit = new frmAddAndEditDebt(_DebtID); // ننشئ فورم التعديل ونرسل له الـ ID
            frmEdit.ShowDialog(); // نعرض فورم التعديل بشكل نافذة حوارية
            _LoadData(_DebtID); // بعد ما نكمل التعديل نعيد تحميل البيانات
        }
    }
}
