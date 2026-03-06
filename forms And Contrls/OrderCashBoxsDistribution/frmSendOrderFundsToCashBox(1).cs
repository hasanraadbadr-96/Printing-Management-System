using BusinessLayeres; // نستدعي الطبقة الخاصة بالأعمال (Business Layer)
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
    public partial class frmSendOrderFundsToCashBox : Form
    {
        clsCashBoxs _CashBox; // كائن يمثل الصندوق
        clsOrderBoxCashDistribution _cashBoxDistribution; // كائن يمثل عملية التوزيع
        DataTable dtOrderBoxCashDistributionList; // جدول عمليات التوزيع
        DataTable _dtCashBox; // جدول الصناديق من الداتا بيز
        int _OrderBoxCashDistributionID = -1; // معرف العملية الحالية

        // خريطة تربط اسم الصندوق (مثل الموجود بالداتا بيس) بالليبلات الخاصة بالـ UI
        // لو اسم الصندوق موجود بالماب -> نحدث واجهة المستخدم
        private Dictionary<string, CashBoxUIMap> _cashBoxMap;

        // صف/كلاس صغير يخزن مراجع الليبلات لكل صندوق
        private class CashBoxUIMap
        {
            public Label IdLabel { get; set; }
            public Label NameLabel { get; set; }
            public Label PercentageLabel { get; set; }
            public Label BalanceLabel { get; set; }
        }

        public frmSendOrderFundsToCashBox()
        {
            InitializeComponent(); // نهيئ مكونات الفورم

            // هنا نأسوي الماب بين أسماء الصناديق (مثل اللي كانوا بالسويتش) والليبلات
            // **اذا تضيف صندوق جديد فالداتا بيس وما يكدر يطلع بالواجهة، لسه راح ينحسب ويتخزن.**
            _cashBoxMap = new Dictionary<string, CashBoxUIMap>(StringComparer.OrdinalIgnoreCase)
            {
                // ملاحظة: المفاتيح هي اسم الصندوق كما هو محفوظ في جدول الصناديز بالداتا بيس
                // حسّي عدل اذا عندك اختلاف املائي بالأسماء في الداتا بيس
                { "ادخار", new CashBoxUIMap { IdLabel = lbSavingCashBoxID, NameLabel = lbboxSaving, PercentageLabel = lbSavingPartnership_percentage, BalanceLabel = lbboxSaving_balance } },
                { "الطوارئ", new CashBoxUIMap { IdLabel = lbEmergencyCashBoxID, NameLabel = lbEmergencyName, PercentageLabel = lbEmergencyPartnership_percentage, BalanceLabel = lbEmergency_balance } },
                { "الاستثمار", new CashBoxUIMap { IdLabel = lbInvestmentCashBoxID, NameLabel = lbInvestmentName, PercentageLabel = lbInvestmentPartnership_percentage, BalanceLabel = lbInvestment_balance } },
                { "المنتجات", new CashBoxUIMap { IdLabel = lbProductsCashBoxID, NameLabel = lbProductsName, PercentageLabel = lbProductsPartnership_percentage, BalanceLabel = lbProducts_balance } },
                { "صيانة الأجهزة", new CashBoxUIMap { IdLabel = lbMaintenanceCashBoxID, NameLabel = lbMaintenanceName, PercentageLabel = lbMaintenancePartnership_percentage, BalanceLabel = lbMaintenance_balance } },
                { "الصدقات", new CashBoxUIMap { IdLabel = lbDonationCashBoxID, NameLabel = lbDonationName, PercentageLabel = lbDonationPartnership_percentage, BalanceLabel = lbDonation_balance } },
                { "المال الشخصي", new CashBoxUIMap { IdLabel = lbPersonalCashBoxID, NameLabel = lbPersonalName, PercentageLabel = lbPersonalPartnership_percentage, BalanceLabel = lbPersonal_balance } },
                { "التسويق", new CashBoxUIMap { IdLabel = lbMarktingCashBoxID, NameLabel = lbMarktinglName, PercentageLabel = lbMarktingPartnership_percentage, BalanceLabel = lbMarkting_balance } }
            };
        }

        private void _UpdateCashDistributionStatusToDeliveredByID(int OrderBoxCashDistributionID)
        {
            _cashBoxDistribution = new clsOrderBoxCashDistribution();
            _cashBoxDistribution = clsOrderBoxCashDistribution.Find(OrderBoxCashDistributionID);

            if (_cashBoxDistribution == null)
            {
                MessageBox.Show("لم يتم العثور على هذا الطلب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // نحافظ على القيم الحالية للـ OrderID و Amount
            _cashBoxDistribution.OrderID = _cashBoxDistribution.OrderID;
            _cashBoxDistribution.Amount = _cashBoxDistribution.Amount;

            _cashBoxDistribution.status = 1; // نغير الحالة الى تم الترحيل
            _cashBoxDistribution.CreatedDate = _cashBoxDistribution.CreatedDate;
            _cashBoxDistribution.UpdatedDate = DateTime.Now;

            if (_cashBoxDistribution.Save())
            {
                // تم الحفظ بنجاح — ما نعرض رسالة
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء تحديث حالة الطلب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal _CalculateTotalAmount()
        {
            decimal total = 0;
            dtOrderBoxCashDistributionList = clsOrderBoxCashDistribution.GetAll();

            foreach (DataRow row in dtOrderBoxCashDistributionList.Rows)
            {
                // نتحقق من وجود المبلغ وان الحالة هي "قيد الترحيل"
                if (row["المبلغ"] != DBNull.Value && row["الحالة"].ToString().Trim() == "قيد الترحيل")
                {
                    if (decimal.TryParse(row["المبلغ"].ToString(), out decimal amount))
                    {
                        total += amount;
                    }
                }
            }

            return total;
        }

        private bool _UpdateOrderCashDistributionStatus()
        {
            bool StatusToDelivered = true;
            dtOrderBoxCashDistributionList = clsOrderBoxCashDistribution.GetAll();

            foreach (DataRow row in dtOrderBoxCashDistributionList.Rows)
            {
                _OrderBoxCashDistributionID = int.Parse(row["رقم المعرف"].ToString());

                if (row["الحالة"].ToString().Trim() == "قيد الترحيل")
                {
                    StatusToDelivered = false;
                    _UpdateCashDistributionStatusToDeliveredByID(_OrderBoxCashDistributionID);
                }
            }

            return StatusToDelivered;
        }

        private void _FillCashBoxInfoByID(string lbCashBoxID, string lbCashBoxBalance)
        {
            _CashBox = new clsCashBoxs();

            int CashBoxID = int.Parse(lbCashBoxID);
            _CashBox = clsCashBoxs.Find(CashBoxID);

            if (_CashBox == null)
            {
                MessageBox.Show("لم يتم علئ الصندوق", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // نخلي القيم زي ما هي لكن نحط المبلغ المودع
            _CashBox.box_name = _CashBox.box_name;
            _CashBox.partnership_percentage = _CashBox.partnership_percentage;
            _CashBox.deposited_amount = decimal.Parse(lbCashBoxBalance);
            _CashBox.box_balance += _CashBox.deposited_amount;
            _CashBox.withdrawn_amount = 0;
            _CashBox.deposit_date = dTPDepositDate.Value;
            _CashBox.withdrawal_date = dTPDepositDate.Value;
           // _CashBox.orders_id = 39; // مؤقت
        }

        private void _SendOrderFundsToCashBox()
        {
            if (_CashBox.Save())
            {
                // تم الحفظ
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _HandleCashBoxs()
        {
            decimal totalAmount = _CalculateTotalAmount(); // نحسب المجموع الكلي
            _dtCashBox = clsCashBoxs.GetAllCashBoxsList(); // نجيب كل الصناديق من الداتا بيس

            // ننفذ لكل صندوق موجود بالداتا بيس — حتى لو ماكو ماب للـ UI نقوم بالحفظ
            foreach (DataRow row in _dtCashBox.Rows)
            {
                try
                {
                    // نحصل على المعرف والاسم والنسبة
                    string idString = row["معرف الصندوق"]?.ToString().Trim();
                    string boxName = row["اسم الصندوق"]?.ToString().Trim() ?? string.Empty;
                    string percentString = row["نسبة الصندوق من الأموال"]?.ToString().Trim() ?? "0";

                    // نظف علامة % اذا موجودة
                    percentString = percentString.Replace("%", "").Trim();

                    // نحاول نحول القيم
                    if (!decimal.TryParse(percentString, out decimal percentage))
                    {
                        percentage = 0;
                    }

                    decimal calculatedAmount = totalAmount * (percentage / 100); // نحسب المبلغ للصندوق

                    // اذا الrow فيها معرف صندوق نستخدمه للحفظ
                    if (int.TryParse(idString, out int cashBoxId))
                    {
                        // لو لقينا الماب خاص بالاسم نحدث الليبلات بالواجهة
                        if (!string.IsNullOrEmpty(boxName) && _cashBoxMap.TryGetValue(boxName, out CashBoxUIMap uiMap))
                        {
                            // نحدث الليبلات بالواجهة
                            uiMap.IdLabel.Text = cashBoxId.ToString(); // معرف الصندوق
                            uiMap.NameLabel.Text = boxName; // اسم الصندوق من الداتا بيس
                            uiMap.PercentageLabel.Text = $"{percentage}%"; // النسبة
                            uiMap.BalanceLabel.Text = $"{calculatedAmount:N0}"; // المبلغ بعد الفورمات
                        }

                        // **مهما اذا كان الصندوق مربوط بالواجهة ام لا، نجهز كائن الصندوق ونحفظه**
                        // نمرر المعرف والمبلغ للحفظ
                        _FillCashBoxInfoByID(cashBoxId.ToString(), calculatedAmount.ToString()); // نحط المبلغ بالداتا بيس
                        _SendOrderFundsToCashBox(); // ونحفظ التغيرات
                    }
                    else
                    {
                        // ماكو معرف صندوق صالح — بس نقدر نعرضه بالـ UI لو كان ماب متوفر بالاسم
                        if (!string.IsNullOrEmpty(boxName) && _cashBoxMap.TryGetValue(boxName, out CashBoxUIMap uiMapNoId))
                        {
                            uiMapNoId.NameLabel.Text = boxName;
                            uiMapNoId.PercentageLabel.Text = $"{percentage}%";
                            uiMapNoId.BalanceLabel.Text = $"{calculatedAmount:N0}";
                        }

                        // ما نقدر نحفظ بدون معرف صالح، فننهي هالحالة بسلام
                    }
                }
                catch (Exception ex)
                {
                    // لو صار خطأ مع صندوق واحد، نكمل على بقية الصناديق
                    MessageBox.Show($"خطأ أثناء توزيع صندوق: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // بعد التوزيع نحدث حالة الطلبات
            if (_UpdateOrderCashDistributionStatus())
            {
                MessageBox.Show("لايوجد اموال طلبات جديد لترحيلها لصناديق", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void frmSendOrderFundsToCashBox_Load(object sender, EventArgs e)
        {
            _HandleCashBoxs(); // نبدأ التوزيع من أول ما يفتح الفورم
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close(); // يغلق الفورم
        }

        private void label26_Click(object sender, EventArgs e)
        {
            // حدث خاص بالليبل — لو تريد تضيف شي حطّه هنا
        }
    }
}
