using BusinessLayeres; // نستدعي طبقة الأعمال حتى نستخدم دوال التخاطب ويا الداتا
using System; // نستدعي مكتبة النظام الأساسية (تواريخ، استثناءات، الخ)
using System.Collections.Generic; // إذا نحتاج قوائم (List) أو قواميس (Dictionary)
using System.ComponentModel; // مكونات الفورم (موترز أو خصائص عند التصميم)
using System.Data; // للتعامل وياه DataTable و DataRow
using System.Drawing; // مكتبة الألوان والرسم للفورم
using System.Linq; // دوال LINQ للفلترة والترتيب (اختياري)
using System.Text; // مكتبة تعالج سلاسل النصوص
using System.Threading.Tasks; // للعمليات ال async / await لو احتجنا
using System.Windows.Forms; // نحتاجها لأن هذي ويندوز فورمز

namespace ETEZAN2024.FormsAndControls.GlobalClasses // نحدد المساحة النمطية حتى ننظم الكلاسات
{
    public class clsOrderNotifier // الكلاس الرئيسي لنظام اشعارات الطلبات
    {

        // كلاس يحوي بيانات الحدث (اللي تنرسل للمشتركين)
        public class OrderEventArgs : EventArgs
        {
            public int OrderID { get; } // رقم الطلب
            public string ProductName { get; } // اسم المنتج
            public int ProductID { get; } // رقم المنتج (مهم للربط بقاعدة البيانات)
            public decimal Price { get; } // سعر المنتج
            public bool IncludesDelivery { get; } // هل يشمل التوصيل
            public DateTime OrderDate { get; } // تاريخ انشاء الطلب
            public byte OrderStatus { get; } // حالة الطلب (كود)
            public string Notes { get; } // ملاحظات على الطلب
            public decimal PaidAmount { get; } // قيمة المدفوعة من العميل
            public string PersonName { get; } // اسم الشخص المرتبط بالطلب
            public int PersonID { get; } // رقم الشخص في النظام
            public string Phone { get; } // رقم التلفون
            public string Address { get; } // عنوان التوصيل

            public string UserName { get; } // اسم المستخدم الي سوّى العملية
            public int UserID { get; } // رقم المستخدم داخل النظام
            public DateTime EstimateTime { get; } // الوقت المتوقع لاكمال الطلب
            public DateTime? FinishTime { get; } // وقت الانتهاء لو اكتمل (ممكن يكون null)

            // الكونستركتر يملي كل الخصائص عند خلق كائن الحدث
            public OrderEventArgs(
                int orderID,
                string productName,
                int productID,
                decimal price,
                bool includesDelivery,
                DateTime orderDate,
                byte orderStatus,
                string notes,
                decimal paidAmount,
                string personName,
                int personID,
                string phone,
                string address,
                string userName,
                int userID,
                DateTime estimateTime,
                DateTime? finishTime)
            {
                OrderID = orderID; // نخزن رقم الطلب
                ProductName = productName; // نخزن اسم المنتج
                ProductID = productID; // نخزن رقم المنتج
                Price = price; // نخزن السعر
                IncludesDelivery = includesDelivery; // نخزن اذا بيه توصيل
                OrderDate = orderDate; // نخزن تاريخ الطلب
                OrderStatus = orderStatus; // نخزن حالة الطلب
                Notes = notes; // نخزن الملاحظات
                PaidAmount = paidAmount; // نخزن المبلغ المدفوع
                PersonName = personName; // نخزن اسم الشخص
                PersonID = personID; // نخزن رقم الشخص
                Phone = phone; // نخزن رقم التلفون
                Address = address; // نخزن العنوان
                UserName = userName; // نخزن اسم المستخدم الي نفّذ العملية
                UserID = userID; // نخزن رقم المستخدم
                EstimateTime = estimateTime; // نخزن الوقت المتوقع للاكمال
                FinishTime = finishTime; // نخزن وقت الانتهاء اذا موجود
            }
        }

        // كلاس يمثل المصدر (الذي يولد الحدث)
        public class Order
        {
            int _OrderID = -1;
           public Order(int OrderID)
            {
                _OrderID = OrderID;
            }
            public event EventHandler<OrderEventArgs> OnNewOrder; // الحدث اللي المشتركين يسمعون له

            // دالة محلية تطلق الحدث (لو في مشتركين)
            protected virtual void OnOrderCreated(OrderEventArgs e)
            {
                OnNewOrder?.Invoke(this, e); // اذا اكو مشتركين نرسل الحدث ويا الداتا
            }

            // تستدعيها وقت تريد تسجل او تولد طلب جديد (ترسل البيانات للمشتركين)
            public void CreateOrder(byte IndexorderStatus)
         
            {
                clsGlobal.CurrentOrderInfo = clsOrders.FindOrder(_OrderID);
                clsGlobal.CurrentOrderItemInfo = clsOrderItems.FindOrderItemsByOrderID(_OrderID);
                // ننشئ كائن OrderEventArgs ونمرره لدالة الإطلاق
                // إذا حصلنا الطلب فعلاً (يعني مو null)
                if (clsGlobal.CurrentOrderInfo != null && clsGlobal.CurrentOrderItemInfo != null)
                {

                    OnOrderCreated(new OrderEventArgs(clsGlobal.CurrentOrderInfo.orderID, clsGlobal.CurrentOrderItemInfo.ProductInfo.productName, clsGlobal.CurrentOrderItemInfo.productID, clsGlobal.CurrentOrderInfo.orderPrice, clsGlobal.CurrentOrderInfo.includesDelivery,
                   clsGlobal.CurrentOrderInfo.orderDate, IndexorderStatus, clsGlobal.CurrentOrderInfo.Notes, clsGlobal.CurrentOrderInfo.paidAmount, clsGlobal.CurrentOrderInfo.PersonsInfo.full_name, clsGlobal.CurrentOrderInfo.personID, clsGlobal.CurrentOrderInfo.PersonsInfo.phone_number, clsGlobal.CurrentOrderInfo.PersonsInfo.address,
                   clsGlobal.CurrentUser.UserName, clsGlobal.CurrentUser.UserID, clsGlobal.CurrentOrderInfo.EstimateTime, clsGlobal.CurrentOrderInfo.FinishTime));

               
                
                
                
                }

                else
                {
                    return;
                }
                
            }
        }

        // خدمة واتساب: راح تشترك بالحدث حتى تبعث رسالة للعميل او للادارة
        // 🔰 كلاس خاص بخدمة الواتساب
        public class WhatsappServiec
        {
            private string _MesseageTexet = ""; // متغير يخزن نص الرسالة اللي نريد نرسلها

            // 🔹 الكونستركتر (الدالة اللي تنفذ أول ما نكوّن كائن من الكلاس)
            public WhatsappServiec(  string MesseageTexet)
            {
                _MesseageTexet = MesseageTexet; // نخزن نص الرسالة بالمتغير الداخلي
            }

            // 🔹 دالة الاشتراك بالحدث (حتى نربط الكلاس مع الحدث OnNewOrder)
            public void Subscribe(Order order)
            {
                order.OnNewOrder += OnOrderReceived; // نشترك بالحدث حتى ينفذ HandleOrderInfo لما يصير حدث جديد
            }

            // 🔹 دالة لإلغاء الاشتراك بالحدث
            public void Unsubscribe(Order order)
            {
                order.OnNewOrder -= OnOrderReceived; // نلغّي الاشتراك حتى ما تنفذ الرسالة بعدين
            }

            // 🔹 الدالة اللي تتنفذ لما يصير حدث جديد
            private void OnOrderReceived(object sender, OrderEventArgs e)
            {
                if (e == null) return;

                // ننفذ الدالة اللي تعالج الطلب وترسل اشعار الواتساب بشكل async
                _ = ProcessOrderAndSendWhatsAppNotificationAsync(e);
            }

            // 🔹 دالة async تعالج الطلب وترسل اشعار الواتساب
            public async Task ProcessOrderAndSendWhatsAppNotificationAsync(OrderEventArgs e)
            {
 
                await Task.Delay(4000); // ننتظر 4 ثواني  ونرسل الاشعار للواتساب async)

                clsGlobal.SendMessageToWhatsapp(
                    e.Phone,
                    clsGlobal.GenerateOrderSummaryText(clsGlobal.CurrentOrderInfo, _MesseageTexet)
                ); // نرسل رسالة الواتساب للعميل
            }


        }
        // 💬 كلاس خاص بخدمة التيلغرام
        public class TelegramServiec
        {


            private string _MesseageTexet = ""; // متغير يخزن نص الرسالة اللي نريد نرسلها

            // 🔹 الكونستركتر (الدالة اللي تنفذ أول ما نكوّن كائن من الكلاس)
            public TelegramServiec( string MesseageTexet)
            {
                _MesseageTexet = MesseageTexet; // نخزن نص الرسالة بالمتغير الداخلي
            }
            // 🔹 دالة الاشتراك بالحدث
            public void Subscribe(Order order)
            {
                order.OnNewOrder += HandleOrderInfo; // نربط الكلاس مع الحدث OnNewOrder
            }

            // 🔹 دالة إلغاء الاشتراك بالحدث
            public void Unsubscribe(Order order)
            {
                order.OnNewOrder -= HandleOrderInfo; // نلغّي الاشتراك حتى نوقف التفاعل
            }

            // 🔹 الدالة اللي تتنفذ لما يصير حدث جديد
            public void HandleOrderInfo(object sender, OrderEventArgs e)
            {
                // تأكد انو event args مو فارغ
                if (e == null) return; // ماكو بيانات نرجع
                                       // نجيب بيانات الطلب الحالي من خلال الـ ID


            }
        }
        // 📸 كلاس خاص بخدمة الإنستغرام
        public class InstagramServiec
        {
            private string _MesseageTexet = ""; // متغير يخزن نص الرسالة اللي نريد نرسلها

            public InstagramServiec( string MesseageTexet)
            {
                _MesseageTexet = MesseageTexet; // نخزن نص الرسالة بالمتغير الداخلي
            }
            // 🔹 دالة الاشتراك بالحدث
            public void Subscribe(Order order)
            {
                order.OnNewOrder += HandleOrderInfo; // نربط الحدث OnNewOrder مع المعالجة
            }

            // 🔹 دالة إلغاء الاشتراك بالحدث
            public void Unsubscribe(Order order)
            {
                order.OnNewOrder -= HandleOrderInfo; // نلغّي الاشتراك من الحدث
            }

            // 🔹 الدالة اللي تتنفذ لما يصير حدث جديد
            public void HandleOrderInfo(object sender, OrderEventArgs e)
            {
                // تأكد انو event args مو فارغ
                if (e == null) return; // ماكو بيانات نرجع

                                       // 🟢 هنا نضيف كود إرسال الرسالة عبر إنستغرام
                                       // ممكن مستقبلاً تستخدم API Instagram Graph وتخلي هنا كود الإرسال
                                       // مثل: InstagramAPI.SendMessage(userId, messageText);

                // نجيب بيانات الطلب الحالي من خلال الـ ID

            }
        }



        // كلاس لعرض الطلب بالشاشة (مثلاً نافذة تذكير او لوحة)
        public class DisplyScreen
        {
            public void Subscribe(Order order)
            {
                order.OnNewOrder += HandleOrderInfo; // نشترك حتى نعرض المعلومات
            }

            public void Unsubscribe(Order order)
            {
                order.OnNewOrder -= HandleOrderInfo; // نلغّي الاشتراك
            }

            public void HandleOrderInfo(object sender, OrderEventArgs e)
            {
                // تأكد انو event args مو فارغ
                if (e == null) return; // ماكو بيانات نرجع
                // هنا تحط كود تحديث الداتا جريد او فتح نافذة تعرض تفاصيل الطلب
                // مثال: ShowPopup(e.OrderItemID, e.ProductName, e.EstimateTime);
            }
        }

        // كلاس مسؤول عن الحفظ بقاعدة البيانات
        public class SaveToDataBase
        {
            public void Subscribe(Order order)
            {
                order.OnNewOrder += HandleOrderInfo; // نشترك حتى يتم الحفظ آلياً
            }

            public void Unsubscribe(Order order)
            {
                order.OnNewOrder -= HandleOrderInfo; // نلغّي الاشتراك اذا ما نريد الحفظ
            }

            public void HandleOrderInfo(object sender, OrderEventArgs e)
            {
                // تأكد انو event args مو فارغ
                if (e == null) return; // ماكو بيانات نرجع
                clsGlobal.CurrentOrderInfo.orderDate = e.OrderDate; // نخزن تاريخ الطلب
               clsGlobal.CurrentOrderInfo.orderStatus = e.OrderStatus; // نخزن حالة الطلب (مثلاً مكتمل، ملغي، قيد التنفيذ)
               clsGlobal.CurrentOrderInfo.Notes = e.Notes; // نخزن الملاحظات الخاصة بالطلب
               clsGlobal.CurrentOrderInfo.UsersInfo.UserName = e.UserName; // نخزن اسم المستخدم اللي أنشأ الطلب
               clsGlobal.CurrentOrderInfo.userID = e.UserID; // نخزن رقم المستخدم
               clsGlobal.CurrentOrderInfo.personID = e.PersonID; // نخزن رقم الشخص (الزبون)
               clsGlobal.CurrentOrderInfo.OrderItemsInfo.productID = e.ProductID; // نخزن رقم المنتج المرتبط بالطلب
               clsGlobal.CurrentOrderInfo.OrderItemsInfo.ProductInfo.productName = e.ProductName; // نخزن اسم المنتج
               clsGlobal.CurrentOrderInfo.EstimateTime = e.EstimateTime; // نخزن الوقت المتوقع لإكمال الطلب
                clsGlobal.CurrentOrderInfo.FinishTime = e.FinishTime; // نخزن وقت إكمال الطلب (إذا مكتمل)

                if (clsGlobal.CurrentOrderInfo.Save()) // نحفظ
                {
                  
                  //  MessageBox.Show($" تم الحفظ والمدة المتبقية لاأكمال الطلب:   ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                else
                {
                    MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
