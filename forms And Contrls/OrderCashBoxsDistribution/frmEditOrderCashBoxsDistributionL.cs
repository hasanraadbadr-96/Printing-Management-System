using BusinessLayeres;
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
    public partial class frmAddAndEditOrderCashBoxsDistribution : Form
    {
        public enum enMode // نعرف نوع بيانات (تعداد) يحدد وضع الفورم
        {
            Add = 1, // وضع اضافة
            Update = 2 // وضع تعديل
        }
        enMode _mode;
        clsOrderBoxCashDistribution _orderBoxCashDistribution;
        int _orderBoxCashDistributionID = -1;
        int _OrderID =-1;
        public int OrderID
        {
            get { return _OrderID; }
            set {
                _OrderID = value; }
        }
        clsOrders _orders;
        public void SaveOrderBoxCashDistributionInfo( clsOrders orders)
        {
            //ذا لكيت نفس طلب موجود اخرج الان ما اخزن نفس طلب مرتين مره وحده لكل طلب ينضاف هنا
            if (clsOrderBoxCashDistribution.isExistOrderID(orders.orderID))
            {
                return;
            }
            _orderBoxCashDistribution = new clsOrderBoxCashDistribution();
            _orderBoxCashDistribution.OrderID = orders.orderID;            // رقم الطلب
            _orderBoxCashDistribution.Amount = orders.orderPrice;          // مبلغ الطلب
            _orderBoxCashDistribution.status = 0;                              // الحالة معلقة بالبداية
          //  _orderBoxCashDistribution.CashBoxID = 15;                           // رقم الصندوق (تقدر تغيره لاحقاً)
            _orderBoxCashDistribution.CreatedDate = orders.orderDate;              // تاريخ الإنشاء
            _orderBoxCashDistribution.UpdatedDate = orders.orderDate;              // تاريخ التحديث
                                                                               //if (cashBoxDistribution.Save())
            if (_orderBoxCashDistribution.Save())
            {
                _mode = enMode.Update;
                lbAddAndEdit.Text = "تعديل ترحيل"; // نخلي النص اضافة
                lbOrderCashBoxsDistributionLID.Text = _orderBoxCashDistribution.OrderFundDistributionID.ToString();
                lbOrderID.Text = _orderBoxCashDistribution.OrderID.ToString();

            //    MessageBox.Show("تم حفظ بيانات الترحيل بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء ترحيل اموال الطلبات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                                    //{
                                                                                 //    // MessageBox.Show("تم ترحيل مبلغ الطلب إلى الصندوق بنجاح ✅",
                                                                                 //       "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                 //}
                                                                                 //else
                                                                                 //{
                                                                                 //    MessageBox.Show("حدث خطأ أثناء ترحيل مبلغ الطلب!",
                                                                                 //                    "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                 //}

            //  btnSave_Click(btnSave, null);
            // _LoadDataByOrderID( OrderItemID);




        }

        public frmAddAndEditOrderCashBoxsDistribution()
        {
            InitializeComponent();
            _mode = enMode.Add;

        }
        public frmAddAndEditOrderCashBoxsDistribution(int orderBoxCashDistributionID)
        {
            InitializeComponent();
            _orderBoxCashDistributionID = orderBoxCashDistributionID;

            _mode = enMode.Update;

        }

        private void _ResetDefualtValues() // دالة ترجع القيم الافتراضية للفورم
        {
            if (_mode == enMode.Add) // اذا الوضع اضافة
            {
                lbAddAndEdit.Text = "اضافة ترحيل"; // نخلي النص اضافة
                _orderBoxCashDistribution = new clsOrderBoxCashDistribution(); // ننشئ كائن جديد
                return; // نطلع من الدالة
            }
            // اذا الوضع تعديل نفرغ الحقول
            lbOrderCashBoxsDistributionLID.Text = "####";
            lbOrderID.Text = "####";
            tbAmount.Text = "";
            dtpAdded.Text = "";
            dtpPending.Text = "";
            rbPending.Checked = true;
        }
        private void _FillOrderBoxCashDistributionInfo() // دالة تملأ الحقول بمعلومات المنتج
        {
            lbOrderCashBoxsDistributionLID.Text = _orderBoxCashDistribution.OrderFundDistributionID.ToString();
            lbOrderID.Text = _orderBoxCashDistribution.OrderID.ToString();
            tbAmount.Text = _orderBoxCashDistribution.Amount.ToString();

            if (_orderBoxCashDistribution.status == 1)
                rbAdded.Checked = true;
            else
                rbPending.Checked = true;

            dtpAdded.Value = _orderBoxCashDistribution.CreatedDate;
            dtpPending.Value = _orderBoxCashDistribution.UpdatedDate;
        }

        private void frmAddAndEditOrderCashBoxsDistribution_Load(object sender, EventArgs e)
        {
            // في حالة تعديل، نعرض البيانات
            if (_mode==enMode.Update)
            {
                _LoadData();
            }
            else
            {
                _ResetDefualtValues();
            }
        }

        // 🟧 دالة تعبئة البيانات في حالة التعديل
        private void _LoadData()
        {
            _orderBoxCashDistribution = clsOrderBoxCashDistribution.Find(_orderBoxCashDistributionID);
            if (_orderBoxCashDistribution == null)
            {
                _ResetDefualtValues();
                MessageBox.Show("تعذر تحميل بيانات الترحيل المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _FillOrderBoxCashDistributionInfo();
        }

        private void _LoadDataByOrderID(int OrderID)
        {
            _OrderID = OrderID;
            _orderBoxCashDistribution = clsOrderBoxCashDistribution.FindByOrderID(_OrderID);
            if (_orderBoxCashDistribution == null)
            {
                _ResetDefualtValues();
                MessageBox.Show("تعذر تحميل بيانات الترحيل المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
           
            _FillOrderBoxCashDistributionInfo();
        }

        // 🟩 زر الحفظ
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // اذا الحقول بيها خطأ
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نوقف العملية
            }



            // تعبئة البيانات من الواجهة
          // _orderBoxCashDistribution.CashBoxID = 15;
            _orderBoxCashDistribution.OrderID = 39;
            _orderBoxCashDistribution.Amount = Convert.ToDecimal(tbAmount.Text);
            _orderBoxCashDistribution.status = rbAdded.Checked ? (byte)1 : (byte)0;
            _orderBoxCashDistribution.CreatedDate = dtpAdded.Value;
            _orderBoxCashDistribution.UpdatedDate = dtpPending.Value;

            

            if (_orderBoxCashDistribution.Save())
            {
                _mode = enMode.Update;
                lbAddAndEdit.Text = "تعديل ترحيل"; // نخلي النص اضافة
                lbOrderCashBoxsDistributionLID.Text = _orderBoxCashDistribution.OrderFundDistributionID.ToString();
                lbOrderID.Text = _orderBoxCashDistribution.OrderID.ToString();

                MessageBox.Show("تم حفظ بيانات الترحيل بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🟦 زر الإلغاء
        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // 🟫 منع إدخال حروف في خانة المبلغ
        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("يرجى إدخال أرقام فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 🟪 التحقق عند مغادرة خانة المبلغ
        private void tbAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                errorProviderOrderCashBoxsDistribution.SetError(tbAmount, "المبلغ لا يمكن أن يكون فارغاً");
                e.Cancel = true;
            }
            else
            {
                errorProviderOrderCashBoxsDistribution.SetError(tbAmount, "");
            }
        }

        // 🟧 أحداث اختيار الحالة
      


    }

}
