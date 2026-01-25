using BusinessLayeres;   // نستدعي طبقة البزنس اللي تسوّي العمليات مال الداتا
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ETEZAN2024.forms_And_Contrls.Orders.control
{
    public partial class ctrlOrderCard : UserControl
    {
        int _OrderID = -1;                // نخزّن رقم الطلب هنا، نخليه -1 بالبداية يعني بعده ما متحدد
        decimal _DeliveryPrice = 5000;    // نخزّن سعر التوصيل، ثابت 5000
        clsOrders _Orders;                // كائن حتى نخزن بيه معلومان الطلب اللي تجينا من الداتابيس
        clsOrderItems _OrderItems;      // كائن حتى نخزن بيه معلومات اصناف الطلب
        public int OrderID                // بروبرتي حتى نرجّع رقم الطلب
        {
            get { return _OrderID; }      // يرجّع قيمة رقم الطلب
        }

        public clsOrders OrderInfo        // بروبرتي ترجع كل معلومات الطلب
        {
            get { return _Orders; }       // يرجع كائن معلومات الطلب المخزون
        }

        public ctrlOrderCard()
        {
            InitializeComponent();        // يسوي تهيئة للمكونات مالت الواجهة
        }

        private void _ResetDefualtValues()
        {
            // هنا نخلي قيم افتراضية فارغة قبل لا نعرض تفاصيل طلب
            lbOrderID.Text = "####";
            lbPersonName.Text = "####";
            lbProdectName.Text = "####";
            lbProductPrice.Text = "####";
            lbPaidAmount.Text = "####";

            lbOrderStatus.Text = "####";
            lbUserName.Text = "####";
            lnkEditOrder.Visible = false;     // نخفي رابط التعديل لحد ما يتحمّل طلب فعلاً
            lbTotalPrice.Text = "####";
            lbOrderDate.Text = "####";
            lbOrderType.Text = "####"; 
        }

        private void _FillOrderInfo()
        {
            // هنا نعرض معلومات الطلب بكل اللابلز
            lbOrderID.Text = _Orders.orderID.ToString();                           // رقم الطلب
            lbPersonName.Text = _Orders.PersonsInfo.full_name;                     // اسم الزبون
            lbProdectName.Text = _Orders.OrderItemsInfo.ProductInfo. productName;                              // اسم المنتج
            lbProductPrice.Text = _Orders.orderPrice.ToString("N0");               // سعر الطلب
            lbPaidAmount.Text = _Orders.paidAmount.ToString("N0");                     // المبلغ المدفوع
            lbUserName.Text = _Orders.UsersInfo.UserName;                                    // اسم الموظف اللي سجل الطلب
            lbOrderType.Text = _Orders.OrderType;
            lbOrderDate.Text = _Orders.orderDate.ToString();                       // تاريخ الطلب
            // اذا الطلب يشمل توصيل
            if (_Orders.includesDelivery)
            {
                lbIncludesDelivery.Text = "نعم";                                   // نعم يشمل توصيل
                lbTotalPrice.Text = (_Orders.orderPrice + _DeliveryPrice).ToString("N0"); // نحسب المجموع ويا التوصيل
          
            }
            else
            {
                lbIncludesDelivery.Text = "لا";                                    // لا ما يشمل توصيل
                lbTotalPrice.Text = _Orders.orderPrice.ToString("N0");             // نعرض فقط سعر الطلب
            }

            lbRemainingAmount.Text = (decimal .Parse( lbTotalPrice.Text )- _Orders.paidAmount).ToString("N0");//المبلغ المتبقي علئ الزبون

            // نحدد حالة الطلب حسب الرقم المخزون بالداتابيس
            switch (_Orders.orderStatus)
            {
                case 0:
                    lbOrderStatus.Text = "جديد";                                  // حالة الطلب جديد
                    break;

                case 1:
                    lbOrderStatus.Text = "قيد التنفيذ";                            // الطلب دا يشتغلون عليه
                    break;

                case 2:
                    lbOrderStatus.Text = "مؤجل";                                   // الطلب مأجّل حالياً
                    break;

                case 3:
                    lbOrderStatus.Text = "مكتمل";                                 // الطلب اكتمل
                    break;

                case 4:
                    lbOrderStatus.Text = "ملغي";                                   // الطلب تم إلغاءه
                    break;

                default:
                    break;
            }

        }

        public void LoadOrderInfo(int orderID)
        {
            _OrderID = orderID;                     // نخزن رقم الطلب اللي نريده
            _Orders = clsOrders.FindOrder(_OrderID); // نجيب معلومات الطلب من الداتابيس

            if (_Orders == null)                    // اذا ما لكينا طلب بهذا الرقم
            {
                _ResetDefualtValues();              // نرجع القيم الافتراضية
                return;
            }

            _FillOrderInfo();                       // نعرض معلومات الطلب
            
            
            //اذا الطلب مكتمل  او ملغي اخفي شريط النك مال تعدديل طلب
            if (_Orders.orderStatus == 3 || _Orders.orderStatus == 4)
            {

                lnkEditOrder.Enabled = false;
            }
            else
            {
                lnkEditOrder.Enabled = true;
            }

        }

        private void ctrlOrderCard_Load(object sender, EventArgs e)
        {
 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();                     // من يضغط اغلاق، يسد البرنامج كله
        }

        private void lnkEditOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // نفتح فورم تعديل الطلب ونمرر له رقم الطلب حتى يعرف شنو يعدل
            frmAddAndEditOrders frmAddAnd = new frmAddAndEditOrders(_OrderID);

            frmAddAnd.ShowDialog();                 // نعرض الفورم
            LoadOrderInfo(_OrderID);                // بعد ما يكمّل التعديل، نرجّع نحمّل معلومات الطلب من جديد
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // حدث فارغ — ما مسوي شي
        }
    }
}
