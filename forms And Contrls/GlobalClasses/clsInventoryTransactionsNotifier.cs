using BusinessLayeres; // هاي حتى نقدر نستخدم الدوال والكلاسات من طبقة البيزنس
using System; // هاي مكتبة اساسية للغة السي شارب
using System.Collections.Generic; // هاي حتى نقدر نستخدم الليست والقوائم
using System.Linq; // هاي حتى نستخدم الدوال اللي تخص الاستعلامات
using System.Text; // هاي حتى نشتغل على النصوص
using System.Threading.Tasks; // هاي للدوال اللي تشتغل بشكل غير متزامن
using System.Windows.Forms;
using static ETEZAN2024.forms_And_Contrls.GlobalClasses.clsInventoryTransactionsNotifier;
using static ETEZAN2024.FormsAndControls.GlobalClasses.clsOrderNotifier;
namespace ETEZAN2024.forms_And_Contrls.GlobalClasses // تعريف مساحة الاسماء
{
    public class clsInventoryTransactionsNotifier // هذي كلاس للتنبيهات لما يصير حركة بالمخزون
    {
        public class InventoryTransactionsEventArgs : EventArgs // هذي كلاس تعرف الخصائص اللي نرسلها بالحدث
        {
            public int transaction_id { get; set; } // رقم العملية
            public int product_id { get; set; } // رقم المنتج
            public string type { get; set; } // نوع الحركة (اضافة، خصم، الخ..)
            public int quantity { get; set; } // الكمية المتأثرة
            public DateTime date { get; set; } // تاريخ العملية
            public int OrderItemID { get; set; } // رقم الطلبية

            // هذا الكونستركتور يسوي تهيئة لكل الخصائص
            public InventoryTransactionsEventArgs(int transaction_id, int product_id, string type, int quantity, DateTime date, int orderItemID)
            {
                this.transaction_id = transaction_id; // نخزن رقم العملية
                this.product_id = product_id; // نخزن رقم المنتج
                this.type = type; // نخزن نوع الحركة
                this.quantity = quantity; // نخزن الكمية
                this.date = date; // نخزن التاريخ
                OrderItemID = orderItemID; // نخزن رقم الطلبية
            }
        }

        public class InventoryTransactions // هذي كلاس تتعامل و تراقب حركة المخزون
        {
            public int _OrderItemID; // رقم الطلبية الخاص بهاي العملية

            public InventoryTransactions(int OrderID) // كونستركتور ياخذ رقم الطلبية
            {
                _OrderItemID = OrderID; // نخزن رقم الطلبية
            }

            public EventHandler<InventoryTransactionsEventArgs> OnInventoryTransaction; // الحدث اللي يطلق لمن تصير حركة بالمخزون

            // دالة احترافية حتى تطلق الحدث وتبلغ الكل
            protected virtual void TriggerInventoryEvent(InventoryTransactionsEventArgs inventoryTransaction)
            {
                OnInventoryTransaction?.Invoke(this, inventoryTransaction); // هذا يطلق الحدث اذا احد مسجل بالـ Event
            }

            // دالة احترافية حتى تسوي حركة جديدة بالمخزون
            public void CreateInventoryTransaction()
            {

                clsGlobal.CurrentInventoryTransactionInfo.Order_ItemID = _OrderItemID;
                // نطلق الحدث ونرسل كل البيانات اللي تخص الحركة
                TriggerInventoryEvent(new InventoryTransactionsEventArgs(
                              clsGlobal.CurrentInventoryTransactionInfo.transaction_id,
                              clsGlobal.CurrentInventoryTransactionInfo.product_id,
                              clsGlobal.CurrentInventoryTransactionInfo.type,
                              clsGlobal.CurrentInventoryTransactionInfo.quantity,
                          clsGlobal.CurrentInventoryTransactionInfo.date, // تاريخ العملية الحالي
                             clsGlobal.CurrentInventoryTransactionInfo.Order_ItemID));
           

    




                }
        
        
        
        
        }
        public class WhatsappServiec
        {
            // دالة للاشتراك بالحدث، حتى من تصير حركة مخزنية ينفذ دالة الارسال
            public void Subscribe(InventoryTransactions inventoryTransactionInfo)
            {
                // هنا نربط الحدث OnInventoryTransaction بدالة HandleInventoryTransactionInfo
                inventoryTransactionInfo.OnInventoryTransaction += HandleInventoryTransactionInfo;
            }

            // دالة لإلغاء الاشتراك بالحدث حتى يبطل يرسل الرسائل
            public void UnSubscribe(InventoryTransactions inventoryTransactionInfo)
            {
                // هنا نفصل الدالة عن الحدث
                inventoryTransactionInfo.OnInventoryTransaction -= HandleInventoryTransactionInfo;
            }

            // هاي الدالة تنفذ بشكل أوتوماتيكي من يصير حدث حركة مخزنية
            public void HandleInventoryTransactionInfo(object sender, InventoryTransactionsEventArgs e)
            {

                // تأكد انو event args مو فارغ
                if (e == null) return; // ماكو بيانات نرجع

                // هنا نسوي نص رسالة جاهزة نرسلها للواتساب
                string inventoryMessage =
                  $"🔔 *تفاصيل حركة المخزون*\n\n" +
                  $"🆔 *رقم عنصر الطلب:* {clsGlobal.CurrentInventoryTransactionInfo.Order_ItemID}\n" +
                  $"📦 *اسم المنتج:* {clsGlobal.CurrentInventoryTransactionInfo.ProductInfo.productName}\n" +
                  $"🔄 *نوع الحركة:* {clsGlobal.CurrentInventoryTransactionInfo.type}\n" +
                  $"🔢 *الكمية:* {clsGlobal.CurrentInventoryTransactionInfo.quantity}\n" +
                  $"📅 *التاريخ:* {DateTime.Now:yyyy-MM-dd HH:mm}\n\n" +
                  $"تم تسجيل الحركة بنجاح ✔️";

                // هنا نرسل الرسالة للرقم المخزن داخل بيانات المستخدم الحالي
                clsGlobal.SendMessageToWhatsapp(clsGlobal.CurrentUser.PersonInfo.phone_number, inventoryMessage);
            }
        }
        public class SaveToDataBase
        {
            // دالة للاشتراك بالحدث حتى من تصير حركة مخزنية نخزنها بقاعدة البيانات
            public void Subscribe(InventoryTransactions inventoryTransactionInfo)
            {
                // ربط الحدث مع الدالة الي تخزن البيانات
                inventoryTransactionInfo.OnInventoryTransaction += HandleInventoryTransactionInfo;
            }

            // دالة لإلغاء الاشتراك من الحدث
            public void UnSubscribe(InventoryTransactions inventoryTransactionInfo)
            {
                // هنا نفصل الارتباط بين الحدث والدالة
                inventoryTransactionInfo.OnInventoryTransaction -= HandleInventoryTransactionInfo;
            }

            // هاي الدالة تنفذ أوتوماتيكياً من يصير الحدث
            public void HandleInventoryTransactionInfo(object sender, InventoryTransactionsEventArgs e)
            {
                // تأكد انو event args مو فارغ
                if (e == null) return; // ماكو بيانات نرجع
                // هنا نجهز اوبجكت جديد حتى نخزن البيانات بيه
                clsGlobal.CurrentInventoryTransactionInfo = new clsInventoryTransactions();

                // نخزن رقم المنتج الي اجانا من الحدث
                clsGlobal.CurrentInventoryTransactionInfo.product_id = e.product_id;

                // نخزن نوع الحركة (إضافة – حذف – تعديل)
                clsGlobal.CurrentInventoryTransactionInfo.type = e.type;

                // نخزن الكمية
                clsGlobal.CurrentInventoryTransactionInfo.quantity = e.quantity;

                // نخزن التاريخ
                clsGlobal.CurrentInventoryTransactionInfo.date = e.date;

                // نخزن رقم الطلب
                clsGlobal.CurrentInventoryTransactionInfo.Order_ItemID = e.OrderItemID;

                // نحاول نسجل البيانات بالقاعدة – دالة Save ترجع true اذا نجح
                if (clsGlobal.CurrentInventoryTransactionInfo.Save())
                {
                    // اذا نجح الحفظ: ما نسوي شي حالياً
                }
                else
                {
                    // اذا فشل: نطلع رسالة خطأ للمستخدم
                    MessageBox.Show("لم يتم حفظ  معلومات جرد حركة المخزون", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
