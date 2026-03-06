using BusinessLayeres; // نستدعي الطبقة الوسيطة (Business Layer) حتى نستخدم كلاس clsOrderBoxCashDistribution
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution
{
    public partial class frmShowOrderCashBoxsDistributionDetials : Form
    {
        clsOrderBoxCashDistribution _orderBoxCashDistribution; // كائن يمثل عملية توزيع الصندوق
        int _orderBoxCashDistributionID = -1; // رقم العملية، نخزنه حتى نعرف أي سجل نعرضه

        public frmShowOrderCashBoxsDistributionDetials(int orderBoxCashDistributionID)
        {
            InitializeComponent(); // تهيئة مكونات الفورم
            _orderBoxCashDistributionID = orderBoxCashDistributionID; // نخزن رقم العملية اللي وصل من الفورم السابق
        }

        private void _ResetDefualtValues() // دالة ترجع القيم الافتراضية للفورم (يعني تفرغ الحقول)
        {
            // نخلي كل الحقول بقيم افتراضية بالبداية
            lbOrderCashBoxsDistributionLID.Text = "####"; // رقم التوزيع الافتراضي
            lbOrderID.Text = "####"; // رقم الطلب الافتراضي
            tbAmount.Text = ""; // نفرغ حقل المبلغ
            dtpAdded.Text = ""; // نفرغ التاريخ
            dtpPending.Text = ""; // نفرغ تاريخ التحديث
            rbPending.Checked = true; // نخلي الحالة الافتراضية "قيد الترحيل"
        }

        private void _FillOrderBoxCashDistributionInfo() // دالة تملأ الحقول بالمعلومات الحقيقية من قاعدة البيانات
        {
            lbOrderCashBoxsDistributionLID.Text = _orderBoxCashDistribution.OrderFundDistributionID.ToString(); // نعرض رقم العملية
            lbOrderID.Text = _orderBoxCashDistribution.OrderID.ToString(); // نعرض رقم الطلب
            tbAmount.Text = _orderBoxCashDistribution.Amount.ToString(); // نعرض المبلغ

            // نتحقق من الحالة، إذا 1 يعني تم الترحيل، غيرها يعني بعده قيد الترحيل
            if (_orderBoxCashDistribution.status == 1)
                rbAdded.Checked = true; // نخلي خيار "تم الترحيل"
            else
                rbPending.Checked = true; // نخلي خيار "قيد الترحيل"

            dtpAdded.Value = _orderBoxCashDistribution.CreatedDate; // نعرض تاريخ الإنشاء
            dtpPending.Value = _orderBoxCashDistribution.UpdatedDate; // نعرض آخر تحديث
        }

        private void _LoadData() // دالة تحميل البيانات من قاعدة البيانات
        {
            // نستدعي دالة Find من الطبقة الوسيطة حتى نجيب سجل التوزيع حسب الرقم
            _orderBoxCashDistribution = clsOrderBoxCashDistribution.Find(_orderBoxCashDistributionID);

            if (_orderBoxCashDistribution == null) // إذا ماكو بيانات للرقم المدخل
            {
                _ResetDefualtValues(); // نفرغ الحقول
                MessageBox.Show("تعذر تحميل بيانات الترحيل المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                this.Close(); // نغلق الفورم
                return;
            }

            _FillOrderBoxCashDistributionInfo(); // إذا نجحنا بالتحميل، نعرض المعلومات داخل الحقول
        }

        private void frmShowOrderCashBoxsDistributionDetials_Load(object sender, EventArgs e)
        {
            _LoadData(); // أول ما يفتح الفورم، نحمل بيانات التوزيع
        }

        private void lnkEditProductPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // نفتح فورم التعديل على نفس السجل
            frmAddAndEditOrderCashBoxsDistribution frmAddAndEdit = new frmAddAndEditOrderCashBoxsDistribution(_orderBoxCashDistributionID);
            frmAddAndEdit.ShowDialog(); // نعرض الفورم بشكل Dialog (يعني المستخدم لازم يغلقه أولاً)
            _LoadData(); // بعد ما يرجع من التعديل، نحدث البيانات بالواجهة الحالية
        }
    }
}
