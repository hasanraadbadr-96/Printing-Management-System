using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETEZAN2024.forms_And_Contrls.GlobalClasses
{
    // تعريف الكلاس clsEventLog الذي يرث من EventLog
    public class clsEventLog : EventLog
    {
        // تعريف تعداد (enum) لتحديد أنواع السجلات
        public enum enLogName { Application = 1, Security = 2, Setup = 3, System = 4, ForwardedEvents = 5 };

        // متغير ثابت لتخزين اسم السجل الحالي
        private static string LogName;

        // دالة خاصة لاسترجاع اسم السجل كنص بناءً على التعداد
        private static string GetLogName(enLogName enLogName)
        {
            switch (enLogName) // استخدام switch لتحديد النص المناسب لكل قيمة
            {
                case enLogName.Application: // إذا كان نوع السجل Application
                    return "Application";   // إرجاع النص "Application"
                case enLogName.System:      // إذا كان نوع السجل System
                    return "System";        // إرجاع النص "System"
                case enLogName.Security:    // إذا كان نوع السجل Security
                    return "Security";      // إرجاع النص "Security"
                case enLogName.ForwardedEvents: // إذا كان نوع السجل ForwardedEvents
                    return "Forwarded Events";   // إرجاع النص "Forwarded Events"
                case enLogName.Setup:       // إذا كان نوع السجل Setup
                    return "Setup";         // إرجاع النص "Setup"
                default:                    // أي حالة أخرى
                    return "";              // إرجاع نص فارغ
            }
        }

        // دالة عامة لكتابة حدث في سجل الأحداث
        public static void WriteEvent(string SourceName, string Message, enLogName logName, EventLogEntryType eventype)
        {
            // تحويل التعداد (enum) إلى اسم سجل Windows Event Log مثل: Application, System...
            LogName = GetLogName(logName);

            // التحقق هل الـ Event Source موجود مسبقًا في النظام
            // مصدر الحدث يمثل "اسم التطبيق" داخل السجل، ويجب إنشاؤه مرة واحدة فقط
            if (!EventLog.SourceExists(SourceName))
            {
                // تجهيز بيانات إنشاء الـ Event Source وتحديد السجل الذي سيكتب فيه
                EventSourceCreationData data = new EventSourceCreationData(SourceName, LogName);

                // إنشاء الـ Event Source في Windows (يتطلب صلاحيات Administrator)
                EventLog.CreateEventSource(data);
            }

            // كتابة الحدث فعليًا في السجل باستخدام الـ SourceName
            EventLog.WriteEntry(SourceName, Message, eventype);
        }
    }

}
