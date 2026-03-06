using Microsoft.Office.Core;
using System;
using System.Diagnostics;
using System.IO; // مهمة جداً للتعامل مع مسارات الملفات
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
namespace ETEZAN2024.Presenters.DocumentAutomationService
{
    // استخدم اسم واحد للكلاس حتى لا يتشتت البرنامج
    public class clsDocumentAutomationService
    {
        // استدعاء دالة من نظام الويندوز لجلب أي نافذة للمقدمة غصبن عليها
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        // 1. دالة لفتح مستند وورد موجود أصلاً بالحاسبة
        public void CreateAndShowNewWord( )
        {


            Word.Application wordApp = null;
            Word.Document myDoc = null;

            try
            {
                wordApp = new Word.Application();
                wordApp.Visible = true;

                myDoc = wordApp.Documents.Add();

                Word.Paragraph para = myDoc.Paragraphs.Add();

                // 1. تفعيل الوورد برمجياً
                wordApp.Activate();

                // 2. تكبير النافذة حتى تغطي الشاشة
                wordApp.WindowState = Word.WdWindowState.wdWindowStateMaximize;

                // 3. السر النهائي: نجيب رقم النافذة (Handle) ونكول للويندوز طلعها للمقدمة
                IntPtr wordHwnd = (IntPtr)wordApp.ActiveWindow.Hwnd;
                SetForegroundWindow(wordHwnd);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ: " + ex.Message);
            }
        }
        // 1. فتح إكسل وإنشاء شيت جديد (بالمقدمة)
        public void CreateAndShowNewExcel()
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();

                // جلب النافذة للمقدمة
                IntPtr excelHwnd = (IntPtr)excelApp.Hwnd;
                SetForegroundWindow(excelHwnd);
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Excel Error: " + ex.Message); }
        }

        // 2. فتح باوربوينت وإنشاء عرض جديد (بالمقدمة)
        public void CreateAndShowNewPowerPoint()
        {
            try
            {
                PowerPoint.Application pptApp = new PowerPoint.Application();
                pptApp.Visible = MsoTriState.msoTrue;
                PowerPoint.Presentations pres = pptApp.Presentations;
                pres.Add(MsoTriState.msoTrue);

                // جلب النافذة للمقدمة
                IntPtr pptHwnd = (IntPtr)pptApp.HWND;
                SetForegroundWindow(pptHwnd);
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("PPT Error: " + ex.Message); }
        }

        // 3. فتح فوتوشوب (نظام الـ Process لأنك تحتاج البرنامج نفسه)
        public void LaunchPhotoshop()
        {
            try
            {
                // ملاحظة: ويندوز سيعرف مسار Photoshop تلقائياً إذا كان منصب
                ProcessStartInfo startInfo = new ProcessStartInfo("photoshop.exe") { UseShellExecute = true };
                Process.Start(startInfo);
            }
            catch { System.Windows.Forms.MessageBox.Show("تأكد من تنصيب فوتوشوب على الجهاز"); }
        }

        // 4. فتح كورل درو (CorelDraw)
        public void LaunchCorelDraw()
        {
            try
            {
                // نستخدم اسم الملف التنفيذي لكورل درو
                Process.Start(new ProcessStartInfo("CorelDRW.exe") { UseShellExecute = true });
            }
            catch { System.Windows.Forms.MessageBox.Show("تأكد من تنصيب كورل درو على الجهاز"); }
        }
    
}
}