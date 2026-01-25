

using BusinessLayeres;
using ETEZAN2024.forms_And_Contrls.GlobalClasses;
using ETEZAN2024.FormsAndControls.GlobalClasses;
//using Microsoft.Toolkit.Uwp.Notifications; // from NuGet
using System;
using System.Windows.Forms;

public static class clsTimerBookingNotifierService
{


    private static Timer _timer = new Timer(); // هاي تايمر يشتغل كل فترة محددة
    private static int _LastNotifiedMinute = -1; // يحفظ آخر دقيقة تم اشعار المستخدم بيها
    private static string _SoundPath = ""; // مسار الصوت اللي يشتغل لما يطلع تنبيه
    public static void Start() // هذا الدالة تشغل الخدمة
    {
        _timer.Interval = 1000;  // كل ثانية نفحص الطلبات
        _timer.Tick += Timer_Tick; // كل مرة يشتغل التايمر ينادي دالة Timer_Tick
        _timer.Start(); // نشغل التايمر
    }
    private static void Timer_Tick(object sender, EventArgs e) // هاي الدالة تنفذ كل ثانية حسب التايمر
    {
        int activeCount = -1; string nearestBooking = ""; // نخلي عداد الطلبات والنص الاقرب
        clsGlobal.GetActiveOrdersWithRemainingTime(out activeCount, out nearestBooking); // نستدعي دالة تجيب الطلبات النشطة ووقت اقرب طلب
        NotifyNearestBooking(); // ننادي دالة تنبه على اقرب طلب
    }
    private static void NotifyNearestBooking() // دالة تشوف اذا لازم تطلع تنبيه على اقرب طلب
    {
        if (clsGlobal.NearestBookingRemainingTime == TimeSpan.MaxValue) // اذا مافي طلبات توقف هنا
            return;

        int minutes = (int)clsGlobal.NearestBookingRemainingTime.TotalMinutes; // نحول الوقت المتبقي الى دقائق

        if (minutes == _LastNotifiedMinute) // اذا نفس الدقيقة اللي اشعرنا بيها قبل، ما نسوي شي
            return;

        string messageShort = ""; // هنا نخزن الرسالة المناسبة

        switch (minutes) // نشوف الوقت المتبقي ونقرر نطلع تنبيه على حسب الوقت
        {
            case 59:
                messageShort = $" ({clsGlobal.NearestBookingOrderID}). باقي ساعة تقريباً على تنفيذ الطلب رقم ";
                break;
            case 30:
                messageShort = $"  ({clsGlobal.NearestBookingOrderID}). باقي نصف ساعة على تنفيذ الطلب رقم ";
                break;
            case 15:
                messageShort = $"({clsGlobal.NearestBookingOrderID}). باقي ربع ساعة على تنفيذ الطلب رقم ";
                break;
            case 0:
                messageShort = $" ({clsGlobal.NearestBookingOrderID}). انتهى وقت الحجز للطلب رقم";
                break;
        }

        if (!string.IsNullOrEmpty(messageShort)) // اذا الرسالة موجودة
        {
            _LastNotifiedMinute = minutes; // نخزن الدقيقة حتى ما نكرر التنبيه
            ShowMessageAndHandleOrder(messageShort); // ننادي دالة الرسالة
            clsGlobal.NearestBookingRemainingTime = TimeSpan.MaxValue; // نوقف التنبيهات لحد ما يتغير الطلب
        }
    }
    private static void ShowMessageAndHandleOrder(string text) // دالة تطلع رسالة للمستخدم وتشغل الصوت
    {
        string _SoundPath = @"D:\ETEZAN2024\Sounds\MOT.mp3"; // مسار الصوت اللي راح يشتغل
        clsAlertSoundPlayer.PlayMp3(_SoundPath); // نشغل الصوت

        // نطلع رسالة للمستخدم ونسأله هل يريد تنفيذ الطلب الآن
        if (MessageBox.Show(
            text + "\nهل تريد تنفيذ هذا الطلب الآن؟",
            "!! تــنــبــيــه",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            // المستخدم ضغط نعم، نجهز الكلاسات اللازمة للتنفيذ
            clsOrderNotifier.Order order = new clsOrderNotifier.Order(clsGlobal.NearestBookingOrderID); // نسوي طلب جديد
            clsOrderNotifier.WhatsappServiec whatsapp = new clsOrderNotifier.WhatsappServiec("يجري تنفيذ طلبكم حاليًا… نشكركم على انتظاركم"); // نص رسالة واتساب
            clsOrderNotifier.SaveToDataBase saveToDataBase = new clsOrderNotifier.SaveToDataBase(); // كلاس يحفظ البيانات بقاعدة البيانات

            saveToDataBase.Subscribe(order); // نخلي saveToDataBase يتابع الطلب
            whatsapp.Subscribe(order); // نخلي خدمة واتساب تتابع الطلب

            byte orderStatus = 1; // حالة الطلب = قيد التنفيذ
            order.CreateOrder(orderStatus); // ننفذ العملية على الطلب
        }

        clsAlertSoundPlayer.Stop(); // نوقف الصوت بعد ما يخلص
    }





}
