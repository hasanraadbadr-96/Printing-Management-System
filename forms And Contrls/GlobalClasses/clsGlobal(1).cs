using ETEZAN2024.FormsAndControls.GlobalClasses;
using Microsoft.Win32;
using System; // نستدعي مكتبة الأساسيات مثل (Console, Exception, String ...)
using System.Collections.Generic; // مكتبة خاصة بالقوائم والمجاميع (مو مستخدمة هنا بس ممكن نحتاجها).
using System.Data;
using System.IO; // مكتبة التعامل ويا الملفات (StreamReader, StreamWriter, File).
using System.Linq; // مكتبة LINQ (مو مستخدمة هنا).
using System.Text; // مكتبة التعامل ويا النصوص (مو مستخدمة هنا).
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms; // مكتبة خاصة بالـ Tasks (مو مستخدمة هنا).

namespace BusinessLayeres // فضاء الأسماء اللي يحتوي الكود مال طبقة الـ Business.
{
    public static class clsGlobal // كلاس ثابت (static) ينخزن بيه متغيرات وإعدادات عامة.
    {
        public static clsUsers CurrentUser; // متغير عام من نوع clsUsers يمثل المستخدم الحالي للبرنامج.
        public static clsOrders CurrentOrderInfo;//معلومات الطلب 
        public static TimeSpan RemainingBookingTime;//متغير لتخزين الوقت المتبقي لاكمال الطلب
        public static clsOrders NearestBookingOrderInfo; //معلومات اقرب موعد حجز للطلب
        public static clsOrderItems CurrentOrderItemInfo; //معلومات اصناف الطلب
        public static TimeSpan NearestBookingRemainingTime;//متغير لتخزين وقت اقرب حجز للطلب
        public static int NearestBookingOrderID = -1; // يخزن رقم  معرف الطلب الأقرب للحجز
        public static clsInventoryTransactions CurrentInventoryTransactionInfo;
        // دالة ترجع جدول بيه كل الطلبات النشطه (الي بعد ما مكتملت وما ملغيه)
        // وتعرض شكد باقي وقت لاكمال كل طلب
        // دالة تعرض الطلبات النشطة (الي بعد ما مكتملت وما ملغيه)
        // وتعرض عداد بعدد الطلبات + أقرب موعد حجز
        // دالة ترجع جدول بيه كل الطلبات النشطه (الي بعد ما مكتملت وما ملغيه)
        // وتعرض الوقت المتبقي بشكل ذكي حسب نوع الفرق (ايام / ساعات / دقايق)
        public static DataTable GetActiveOrdersWithRemainingTime(out int activeCount, out string nearestBooking)
        {
            // نجيب كل الطلبات من قاعدة البيانات
            DataTable allOrders =   clsOrders.GetAllOrdersList();

            // نسوي جدول جديد خاص بالطلبات النشطه فقط ننسخ طلبات من جدول للاصلي
            DataTable summaryTable = new DataTable();

            // نضيف الاعمده الاساسيه للعرض
            summaryTable.Columns.Add("رقم الطلب", typeof(int));
            summaryTable.Columns.Add("تاريخ الحجز", typeof(DateTime));
            summaryTable.Columns.Add("الوقت المتوقع للإكمال الطلب", typeof(DateTime));
            summaryTable.Columns.Add("الوقت المتبقي", typeof(string));
            summaryTable.Columns.Add("الحالة", typeof(string));

            // نخزن اقصر وقت متبقي حتى نعرف اقرب موعد حجز
             NearestBookingRemainingTime = TimeSpan.MaxValue;

            // عداد للطلبات النشطه
            activeCount = 0;

            foreach (DataRow row in allOrders.Rows)
            {
                // نخزن حالة الطلب
                string status = row["حالة الطلب"].ToString();

                // اذا الطلب مو مكتمل ولا ملغي
                if (status != "مكتمل" && status != "ملغي")
                {
                    activeCount++; // نزيد العداد

                    int orderID = Convert.ToInt32(row["معرف الطلب"]);
                    DateTime orderDate = Convert.ToDateTime(row["تاريخ الطلب"]);
                    DateTime estimateTime = Convert.ToDateTime(row["الوقت المتوقع للإكمال الطلب"]);

                    // نحسب الوقت الباقي بين الوقت المتوقع والوقت الحالي
                    TimeSpan RemainingBookingTime = estimateTime - DateTime.Now;


                    // هنا نسوي تنسيق ذكي حسب المده
                    string remainingText;

                    if (RemainingBookingTime.Days > 0)
                    {
                        // اذا بيه ايام نعرض الكل
                        remainingText = $"{RemainingBookingTime.Days} يوم / {RemainingBookingTime.Hours} ساعه / {RemainingBookingTime.Minutes} دقيقة";
                    }
                    else if (RemainingBookingTime.Hours > 0)
                    {
                        // اذا ما بيه ايام بس بيه ساعات
                        remainingText = $"{RemainingBookingTime.Hours} ساعه / {RemainingBookingTime.Minutes} دقيقة";
                    }
                    else
                    {
                        // اذا الفرق كله دقايق فقط
                        remainingText = $"{RemainingBookingTime.Minutes} دقيقة";
                    }

                    // نضيف الصف للجدول النهائي
                    summaryTable.Rows.Add(orderID, orderDate, estimateTime, remainingText, status);

                    // نخزن اقصر وقت متبقي حتى نعرف اقرب موعد
                    if (RemainingBookingTime > TimeSpan.Zero && RemainingBookingTime < NearestBookingRemainingTime)
                    {
                        //جلب وقت اقرب موعد حجز للطلب ونخزنه بمتغير عام بكلاس غلوبل علمود نستخدمه باي داله نحتاجها بعدين
                        NearestBookingRemainingTime = RemainingBookingTime;
                        //جلب رقم معرف اقرب موعد حجز للطلب ونخزنه بمتغير عام بكلاس غلوبل علمود نستخدمه باي داله نحتاجها بعدين
                        NearestBookingOrderID = orderID;
                        //جلب معلومات اقرب موعد حجز للطلب
                         NearestBookingOrderInfo = clsOrders.FindOrder(orderID);
                    }
                }
            }

            // نرجع اقرب موعد حجز نصياً بشكل مفهوم
            // هذا الكود يحسب نص أقرب حجز ويخزنه بمتغير nearestBooking
            if (NearestBookingRemainingTime != TimeSpan.MaxValue)
            {
                // هنا ندقق: إذا الوقت المتبقي مو (أكبر قيمة)، يعني أكو طلب قريب بعده ما مكمل

                if (NearestBookingRemainingTime.Days > 0)
                    // إذا باقي وقت بالأيام → نعرض الأيام + الساعات + الدقائق
                    nearestBooking = $"{NearestBookingRemainingTime.Days} يوم و {NearestBookingRemainingTime.Hours} ساعه و {NearestBookingRemainingTime.Minutes} دقيقة";

                else if (NearestBookingRemainingTime.Hours > 0)
                    // إذا ماكو أيام بس باقي وقت بالساعات → نعرض الساعات + الدقائق فقط
                    nearestBooking = $"{NearestBookingRemainingTime.Hours} ساعه و {NearestBookingRemainingTime.Minutes} دقيقة";

                else
                    // إذا ماكو لا أيام ولا ساعات → يعني باقي بس دقائق
                    nearestBooking = $"{NearestBookingRemainingTime.Minutes} دقيقة";
            }
            else
            {
                // هنا إذا الوقت يساوي (أكبر قيمة) → يعني ماكو أي طلبات نشطة
                nearestBooking = "لايوجد طلبات نشطه";
            }



            // نرجع الجدول النهائي
            return summaryTable;
        }


        // دالة تخزن اسم المستخدم والباسورد بالريجستري بدون تشفير بلمستقبل يفضل نستخدم تشفير لأمان اكثر ومحد يكدر يفتح حساب
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            // هذا مسار المفتاح بالريجستري اللي راح نخزن بيه البيانات
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\ETEZAN24";

            // اسم القيمة اللي راح تنخزن داخل المفتاح
            string valueName = "RememberUsernameAndPassword";

            // نجمع اليوزر ويه الباسورد ونفصلهم حتى نكدر نرجعهم بعدين
            string valueData = Username + "|" + Password;

            try
            {
                // نخزن البيانات داخل الريجستري
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

                // نرجع true لأن العملية نجحت
                return true;
            }
            catch (Exception ex)
            {
                // نطبع الخطأ إذا صار شي
                Console.WriteLine($"An error occurred: {ex.Message}");

                // نرجع false لأن العملية فشلت
                return false;
            }
        }
        // داله تقرا اليوزر والباسورد من الريجستري مخزنه بدون تشفير علئ نضام الويندوز
        public static bool GetUsernameAndPassword(ref string Username, ref string Password)
        {
            // مسار المفتاح بالريجستري اللي خزنّاه سابقاً
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\ETEZAN24";

            // اسم القيمة اللي خزنّا بيها اليوزر والباسورد
            string valueName = "RememberUsernameAndPassword";

            try
            {
                // قراءة القيمة من الريجستري وتحويلها إلى string
                string value = Registry.GetValue(keyPath, valueName, null) as string;

                // التأكد إذا البيانات موجودة أو لا
                if (!string.IsNullOrEmpty(value))
                {
                    // تقسيم البيانات حسب الفاصل "|"
                    string[] parts = value.Split('|');

                    // التأكد إن البيانات صحيح مقسمة إلى جزئين: Username و Password
                    if (parts.Length == 2)
                    {
                        // الجزء الأول هو اليوزر
                        Username = parts[0];

                        // الجزء الثاني هو الباسورد
                        Password = parts[1];

                        // ترجع true لأن العملية نجحت
                        return true;
                    }
                    else
                    {
                        // ترجع false لأن البيانات المخزنة مو بصيغة صحيحة
                        return false;
                    }
                }
                else
                {
                    // ترجع false لأن ماكو بيانات مخزنة
                    return false;
                }
            }
            catch (Exception ex)
            {
                // طباعة الخطأ إذا حدثت مشكلة
                Console.WriteLine($"An error occurred: {ex.Message}");

                // ترجع false لأن العملية فشلت
                return false;
            }
        }

        // داله ارساله رساله للواتساب
        public static void SendMessageToWhatsapp(string phoneNumber, string message)
        {

            // إزالة أي فراغات أو علامة + من رقم الهاتف
            string cleanNumber = Regex.Replace(phoneNumber, @"\s+|\+", "");
            // هنا نخلي الرسالة صالحة للـ URL، يعني لو بيها مسافات او رموز خاصه تتحول لصيغة يقدر الواتساب يفهمها
            message = Uri.EscapeDataString(message);

            // هنا نكوّن رابط الواتساب مع رقم الموبايل والرسالة، هذا الرابط يفتح المحادثة مباشرة
            string whatsappUrl = $"https://wa.me/{cleanNumber}?text={message}";

            // هس يجي الجزء اللي يفتح الرابط على المتصفح او تطبيق الواتساب
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                // هنا نحدّد الرابط اللي راح ينفتح
                FileName = whatsappUrl,

                // لازم نخلّيها true حتى يفتح الرابط باستخدام المتصفح الافتراضي
                UseShellExecute = true
            });
        }

        //داله تعرض تفاصيل الطلب للطباعه او ارسالها للزبون او عرضها علئ الشاشه

        // دالة عامة ترجع نص ملخّص للطلب وتستقبل كائن الطلب وعنوان تريده يظهر فوق الملخّص
        public static string GenerateOrderSummaryText(clsOrders order, string title)
        {
            if (order == null)
                return "❌ لا توجد معلومات للطلب";

             RemainingBookingTime = TimeSpan.Zero;
            string remainingText = "0 يوم / 0 ساعة / 0 دقيقة";

            if (order.orderStatus != 3 && order.orderStatus != 4)
            {
                if (order.EstimateTime != null && order.orderDate != null)
                {
                    RemainingBookingTime = order.EstimateTime - DateTime.Now;

                    if (RemainingBookingTime.Days > 0)
                        remainingText = $"{RemainingBookingTime.Days} يوم / {RemainingBookingTime.Hours} ساعة / {RemainingBookingTime.Minutes} دقيقة";
                    else if (RemainingBookingTime.Hours > 0)
                        remainingText = $"{RemainingBookingTime.Hours} ساعة / {RemainingBookingTime.Minutes} دقيقة";
                    else
                        remainingText = $"{RemainingBookingTime.Minutes} دقيقة";
                }
            }

            StringBuilder sb = new StringBuilder();
            switch (GetStatusText(order.orderStatus))
            {
                case "جديد":
                    {
                        sb.AppendLine($" {title}"); // عنوان التقرير
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                        // نعرض رقم الطلب
                        sb.AppendLine($"🆔 رقم الطلب : {order.orderID}");

                        // نعرض اسم الزبون أو نكتب "غير محدد" إذا ما موجود
                        sb.AppendLine($"👤 اسم الزبون : {order.PersonsInfo?.full_name ?? "غير محدد"}");

                        // نعرض رقم الموبايل أو نكتب "غير متوفر" إذا ما موجود
                        sb.AppendLine($"📱 رقم الموبايل : {order.PersonsInfo?.phone_number ?? "غير متوفر"}");

                        // نعرض العنوان
                        sb.AppendLine($"📌 العنوان : {order.PersonsInfo?.address ?? "غير متوفر"}");

                        // نعرض اسم المنتج
                        sb.AppendLine($"🛍️ المنتج : {order.OrderItemsInfo.ProductInfo.productName ?? "غير معروف"}");

                        // نعرض السعر مع فوارز للألوف بدون أرقام عشرية
                        //السعر الطلب مع التوصيل
                        if (order.includesDelivery)
                        {
                            order.orderPrice = GetFinalOrderPrice(order, 5000);
                            sb.AppendLine($"💰 السعر : {order.orderPrice.ToString("N0")} د.ع" + " _____ مع التوصيل ");
                        }
                        //السعر الطلب بدون التوصيل
                        else
                        {
                            order.orderPrice = GetFinalOrderPrice(order, 0);
                            sb.AppendLine($"💰 السعر : {order.orderPrice.ToString("N0")} د.ع" + " _____ بدون توصيل ");
                        }

                        // نعرض العربون مع فوارز بنفس التنسيق
                        sb.AppendLine($"💰 تم دفع العربون : {order.paidAmount.ToString("N0")} د.ع");

                        sb.AppendLine($"💰المبلغ المتبقي : {(order.orderPrice - order.paidAmount).ToString("N0")} د.ع");

                        // نعرض تاريخ الطلب
                        sb.AppendLine($"📅 تاريخ الطلب : {order.orderDate}");

                        // نعرض حالة الطلب
                        sb.AppendLine($"📌 حالة الطلب : {GetStatusText(order.orderStatus)}");

                        // نعرض الملاحظات
                        sb.AppendLine($"📝 ملاحظات : {order.Notes}");

                        // نعرض الوقت المتبقي
                        sb.AppendLine($"⌛ الوقت المتبقي : {remainingText}");

                        // نعرض اسم الموظف
                        sb.AppendLine($"👨‍💼 الموظف : {order.UsersInfo.UserName}");

                        // نتحقق من وقت الإكمال
                        if (order.FinishTime != null)
                            sb.AppendLine($"✅ الإكمال الفعلي : {order.FinishTime}");
                        else
                            sb.AppendLine($"⚙️ لم يكتمل الطلب بعد");

                        // سطر فاصل نهائي
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        break;
                    }
                case "قيد التنفيذ":  {

                       

                        sb.AppendLine($" {title}"); // عنوان التقرير
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                        // نعرض رقم الطلب
                        sb.AppendLine($"# رقم طلبك : {order.orderID}");
                        // نعرض الوقت المتبقي
                        sb.AppendLine($"# الوقت المتبقي : {remainingText}");
                        // نتحقق من وقت الإكمال
                        if (order.FinishTime != null)
                            sb.AppendLine($"# الإكمال الفعلي : {order.FinishTime}");
                        else
                            sb.AppendLine($"# لم يكتمل الطلب بعد");

                        // سطر فاصل نهائي
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        break;
                    }
                case "موجل":
                    {
                        sb.AppendLine($" {title}"); // عنوان التقرير
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                        // نعرض رقم الطلب
                        sb.AppendLine($"# رقم طلبك : {order.orderID}");
                        // نعرض الوقت المتبقي
                        sb.AppendLine($"# الوقت المتبقي : {remainingText}");
                        // نتحقق من وقت الإكمال
                        if (order.FinishTime != null)
                            sb.AppendLine($"# الإكمال الفعلي : {order.FinishTime}");
                        else
                            sb.AppendLine($"# لم يكتمل الطلب بعد");

                        // سطر فاصل نهائي
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        break;
                    }
                case "مكتمل":
                    {
                        sb.AppendLine($" {title}"); // عنوان التقرير
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                        // نعرض رقم الطلب
                        sb.AppendLine($"🆔 رقم الطلب : {order.orderID}");

                        // نعرض اسم الزبون أو نكتب "غير محدد" إذا ما موجود
                        sb.AppendLine($"👤 اسم الزبون : {order.PersonsInfo?.full_name ?? "غير محدد"}");

                        // نعرض رقم الموبايل أو نكتب "غير متوفر" إذا ما موجود
                        sb.AppendLine($"📱 رقم الموبايل : {order.PersonsInfo?.phone_number ?? "غير متوفر"}");

                        // نعرض العنوان
                        sb.AppendLine($"📌 العنوان : {order.PersonsInfo?.address ?? "غير متوفر"}");

                        // نعرض اسم المنتج
                        sb.AppendLine($"🛍️ المنتج : {order .OrderItemsInfo.ProductInfo.productName ?? "غير معروف"}");

                        // نعرض السعر مع فوارز للألوف بدون أرقام عشرية
                        //السعر الطلب مع التوصيل
                        if (order.includesDelivery)
                        {
                            order.orderPrice = GetFinalOrderPrice(order, 5000);
                            sb.AppendLine($"💰 السعر : {order.orderPrice.ToString("N0")} د.ع" + " _____ مع التوصيل ");
                        }
                        //السعر الطلب بدون التوصيل
                        else
                        {
                            order.orderPrice = GetFinalOrderPrice(order, 0);
                            sb.AppendLine($"💰 السعر : {order.orderPrice.ToString("N0")} د.ع" + " _____ بدون توصيل ");
                        }

                        // نعرض العربون مع فوارز بنفس التنسيق
                        sb.AppendLine($"💰 تم دفع العربون : {order.paidAmount.ToString("N0")} د.ع");

                        sb.AppendLine($"💰المبلغ المتبقي : {(order.orderPrice - order.paidAmount).ToString("N0")} د.ع");

                        // نعرض تاريخ الطلب
                        sb.AppendLine($"📅 تاريخ الطلب : {order.orderDate}");

                        // نعرض حالة الطلب
                        sb.AppendLine($"📌 حالة الطلب : {GetStatusText(order.orderStatus)}");

                        // نعرض الملاحظات
                        sb.AppendLine($"📝 ملاحظات : {order.Notes}");

                        // نعرض الوقت المتبقي

                        // نعرض اسم الموظف
                        sb.AppendLine($"👨‍💼 الموظف : {order.UsersInfo.UserName}");

         

                        // سطر فاصل نهائي
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        break;
                    }
                case "ملغي":
                    {
                        sb.AppendLine($" {title}"); // عنوان التقرير
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

                        // نعرض رقم الطلب
                        sb.AppendLine($"# رقم طلبك : {order.orderID}");
                        

                        // سطر فاصل نهائي
                        sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                        break;
                    }


            }

            return sb.ToString();
        }

        // دالة مساعدة تحول كود الحالة لنص مفهوم بالعربي
        private static string GetStatusText(byte status)
            {
                // نرجع نص حسب قيمة الحالة
                switch (status)
                {
                    case 0: return "جديد"; // حالة رقم 0 نعتبرها جديد
                    case 1: return "قيد التنفيذ"; // حالة رقم 0 نعتبرها قيد التنفيذ
                    case 2: return "موجل"; // حالة رقم 2 نعتبرها موجل
                    case 3: return "مكتمل"; // حالة رقم 1 = مكتمل
                    case 4: return "ملغي"; // حالة رقم 2 = ملغي
                    default: return "غير معروف"; // لو الكود غير معروف نرجع نص افتراضي
                }
            
        }

        //لحساب سعر الطلب بدون توصيل او مع توصيل
        private static decimal GetFinalOrderPrice(clsOrders order, decimal DeliveryPrice)
        {
            decimal _TotalPrice = 0;
            decimal  paidAmount = 0;



            if (order.includesDelivery) // اذا ويا توصيل
                _TotalPrice = order.orderPrice + DeliveryPrice;
            else// اذا بدون توصيل
                _TotalPrice = order.orderPrice;

            decimal remaining = _TotalPrice - paidAmount; // الباقي
       

            return _TotalPrice;
        }

       //اللغاء الطلب
       public static void CanselOrderByOrderStatus(int orderID)
        {
            CurrentOrderInfo = clsOrders.FindOrder(orderID);
            if (CurrentOrderInfo == null)
            {
                return;
            }

           CurrentOrderInfo.orderDate = CurrentOrderInfo.orderDate; // نخزن التاريخ
           CurrentOrderInfo.orderStatus = 4; //  //كنسلنه طلب
           CurrentOrderInfo.Notes = CurrentOrderInfo.Notes; // نخزن الملاحظات
            CurrentOrderInfo.UsersInfo.UserName = clsGlobal.CurrentUser.UserName; // نخزن اسم المستخدم
           CurrentOrderInfo.userID = clsGlobal.CurrentUser.UserID; // نخزن رقم المستخدم
           CurrentOrderInfo.personID = CurrentOrderInfo.personID; // نخزن رقم الشخص
            CurrentOrderInfo.OrderItemsInfo.ProductInfo.productID = CurrentOrderInfo.OrderItemsInfo.ProductInfo.productID; // نخزن رقم المنتج
            CurrentOrderInfo.OrderItemsInfo.ProductInfo.productName = CurrentOrderInfo.OrderItemsInfo.ProductInfo.productName; // نخزن اسم المنتج
           CurrentOrderInfo.EstimateTime = CurrentOrderInfo.EstimateTime;
            CurrentOrderInfo.FinishTime = CurrentOrderInfo.FinishTime;
            if (CurrentOrderInfo.Save()) // نحفظ
            {

            }
            else
            {
            }


            // 🔹 نخلق حدث جديد للطلب حتى نربطه بالواتساب
            clsOrderNotifier.Order orderEventSource = new clsOrderNotifier.Order(CurrentOrderInfo.orderID);

            // 🔹 نجهز رسالة الواتساب اللي راح توصل للزبون
            clsOrderNotifier.WhatsappServiec whatsapp = new clsOrderNotifier.WhatsappServiec(" نعتذر عن إلغاء طلبكم ونتمنّى نخدمكم بأفضل شكل بالطلبات الجاية.  \r\nمطبعة اتزان ");


            // 🔹 نربط خدمة الواتساب بالطلب حتى يرسل الرسالة تلقائياً
            whatsapp.Subscribe(orderEventSource);
            //هنا خلينه حاله الطلب ملغي
            byte orderStatus = 4;
            // 🔹 نستدعي الدالة CreateOrder ونمرر كل تفاصيل الطلب الحالي
            // 🟩 تنفيذ العملية
            orderEventSource.CreateOrder(orderStatus);
        }


        //داله لملئ الكمبو بوكس بنوع الحركه هدر او تلف وغير للحركة او جرد الحركة المخزون
        public static void FillComboBoxTypeInventoryTransactionInfo(ComboBox comboBox)
        {
            comboBox.Items.Clear(); // نفرغ العناصر القديمة

            // نضيف انواع الحركات الافتراضية
           comboBox.Items.Add("إضافة إلى المخزن");
           comboBox.Items.Add("صرف إلى الإنتاج");
           comboBox.Items.Add("صرف للزبون");
           comboBox.Items.Add("هدر / تالف");
           comboBox.Items.Add("خصم");
           comboBox.Items.Add("هبة / استلام مجاني");
           comboBox.Items.Add("إرجاع من الإنتاج");
            comboBox.Items.Add("تسوية مخزنية");
        }




    }

}

    
    
    
    





