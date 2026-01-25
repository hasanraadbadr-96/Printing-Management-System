using BusinessLayeres;                 // استدعاء طبقة البزنس حتى نستخدم الكلاسات الجاهزة
using System;                          // مكتبة الأساسيات مثل DateTime و Action
using System.Collections.Generic;      // مكتبة القوائم
using System.Diagnostics;              // مكتبة تشغيل البرامج الخارجية مثل Process
using System.Drawing;                  // مكتبة الرسم وإنشاء الصور
using System.Drawing.Imaging;          // مكتبة صيغ الصور مثل PNG
using System.Drawing.Printing;
using System.IO;                       // مكتبة التعامل ويا الملفات والمسارات
using System.Linq;                     // مكتبة LINQ
using System.Text;                     // مكتبة التعامل ويا النصوص
using System.Text.RegularExpressions;  // مكتبة الـ Regex لتنظيف النصوص
using System.Threading.Tasks;          // مكتبة المهام
using System.Web;                      // مكتبة الويب
using System.Windows.Forms;

using static ETEZAN2024.FormsAndControls.GlobalClasses.clsOrderNotifier; // استدعاء كلاس الإشعارات
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath; // استدعاء أدوات الرسم
namespace ETEZAN2024.forms_And_Contrls.GlobalClasses // مساحة الاسم الخاصة بالكلاسات العامة
{
    // كلاس ثابت مسؤول عن تصدير وطباعة فواتير الطلبات
    public static class clsOrderInvoiceExporter
    {
        // متغير خاص نخزن بيه بيانات الطلب الحالي
        private static clsOrders _Order;

        // حدث يتم استدعاؤه بعد ما تنحفظ أو تتصدر الفاتورة
        public static Action<clsOrders> OnInvoiceExported;

        // متغير عام لتخزين الصورة
        public static Bitmap bitmap;

        // دالة لطباعة الفاتورة (حالياً فاضية)
        public static void PrintInvoice(clsOrders _Order)
        {
            // نحول الفاتورة إلى صورة
            Bitmap invoiceImage = ConvertInvoiceTextToImage(_Order);

            // ننشئ مستند طباعة
            PrintDocument printDoc = new PrintDocument();

            // نربط حدث الطباعة
            printDoc.PrintPage += (sender, e) =>
            {
                // نحدد مكان الرسم داخل الصفحة
                Rectangle printArea = e.MarginBounds;

                // نرسم صورة الفاتورة على الورقة
                e.Graphics.DrawImage(
                    invoiceImage,
                    printArea
                );

                // نكول ماكو صفحة ثانية
                e.HasMorePages = false;
            };

            // نفتح نافذة اختيار الطابعة
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            // إذا المستخدم وافق على الطباعة
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }

            // نحرر الذاكرة
            invoiceImage.Dispose();
        }



        // دالة لحفظ الفاتورة كصورة على سطح المكتب
        public static void SaveInvoiceAsImage(clsOrders _Order)
        {
            // نحول بيانات الطلب (النص) إلى صورة Bitmap
            Bitmap bitmap = ConvertInvoiceTextToImage(_Order);

            // ننشئ نافذة اختيار مكان الحفظ مال ويندوز
            SaveFileDialog saveDialog = new SaveFileDialog();

            // نحدد عنوان النافذة
            saveDialog.Title = "حفظ الفاتورة كصورة";

            // نحدد نوع الملف المسموح
            saveDialog.Filter = "PNG Image (*.png)|*.png";

            // نحدد الامتداد الافتراضي
            saveDialog.DefaultExt = "png";

            // نحدد اسم افتراضي للملف
            saveDialog.FileName = $"رقم_الفاتوره_{_Order.orderID}";

            // نحدد مكان افتراضي (سطح المكتب)
            saveDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // نعرض نافذة الحفظ وإذا المستخدم ضغط حفظ
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // نحفظ الصورة بالمكان اللي اختاره المستخدم
                bitmap.Save(
                    saveDialog.FileName,
                    System.Drawing.Imaging.ImageFormat.Png
                );
            }

            // نحرر الذاكرة بعد الانتهاء
            bitmap.Dispose();
        }

        // دالة تحفظ الفاتورة داخل مجلد (فواتير) وترجع المسار
        public static string SaveInvoiceTempImage(clsOrders _Order)
        {
            // نحول نص الفاتورة إلى صورة
            Bitmap bitmap = ConvertInvoiceTextToImage(_Order);

            // نجيب مسار سطح المكتب
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // نحدد مسار مجلد فواتير
            string invoicesFolder = Path.Combine(desktopPath, "فواتير");

            // إذا المجلد مو موجود
            if (!Directory.Exists(invoicesFolder))
            {
                // ننشئ المجلد
                Directory.CreateDirectory(invoicesFolder);
            }

            // نحدد اسم ومسار ملف الصورة
            string imagePath = Path.Combine(
                invoicesFolder,
                $"_رقم_فاتوره_الطلب{_Order.orderID}.png"
            );

            // نخزن الصورة بصيغة PNG
            bitmap.Save(imagePath, ImageFormat.Png);

            // نحرر الذاكرة
            bitmap.Dispose();

            // نرجع مسار الصورة
            return imagePath;
        }

        // دالة تحول بيانات الطلب إلى صورة Bitmap
        public static Bitmap ConvertInvoiceTextToImage(clsOrders _Order)
        {
            // نحدد عرض الصورة
            int width = 800;

            // نحدد ارتفاع الصورة
            int height = 2000;

            // ننشئ صورة جديدة بالحجم المحدد
            // دالة تحول بيانات الطلب إلى صورة Bitmap public static Bitmap ConvertInvoiceTextToImage(clsOrders _Order) { // نحدد عرض الصورة int width = 800;

        

            // ننشئ صورة جديدة بالحجم المحدد
            Bitmap bitmap = new Bitmap(width, height);

            // ننشئ كائن رسم مرتبط بالصورة
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // نخلي الرسم ناعم
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // نخلي تكبير وتصغير الصورة بجودة عالية
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // نخلي إزاحة البيكسلات بجودة عالية
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                // نخلي النص يطلع ناعم
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                // نخلي خلفية الصورة سوداء
                g.Clear(Color.Black);

                // فرشاة وقلم ذهبي للتصميم
                Brush goldBrush = new SolidBrush(Color.FromArgb(212, 175, 55)); // ذهبي احترافي
                Pen goldPen = new Pen(Color.FromArgb(212, 175, 55), 4);        // إطار ذهبي رفيع

              // نرسم إطار ذهبي حول الفاتورة مع مسافة أمان من الحواف
                int margin = 25; // تقريباً نص سم
                Rectangle borderRect = new Rectangle(
                    margin,
                    margin,
                    width - (margin * 2),
                    height - (margin * 2)
                );
                g.DrawRectangle(goldPen, borderRect);


                // نجيب صورة اللوجو من الموارد
                Image logo = Properties.Resources.logo;

                // نحدد عرض اللوجو
                int logoWidth = 500;

                // نحدد ارتفاع اللوجو
                int logoHeight = 500;

                // نحسب مكان اللوجو بالمنتصف
                int logoX = (width - logoWidth) / 2;

                // نحدد مكان اللوجو من الأعلى
                int logoY = 20;

                // نرسم اللوجو
                g.DrawImage(logo, logoX, logoY, logoWidth, logoHeight);

                // نحدد خط عنوان الفاتورة
                Font titleFont = new Font("Arial", 32, FontStyle.Bold);

                // نحدد خط العناوين
                Font labelFont = new Font("Arial", 28, FontStyle.Bold);

                // نحدد خط القيم
                Font valueFont = new Font("Arial", 28, FontStyle.Regular);

                // خط تسويقي احترافي
                Font marketingFont = new Font("Segoe UI Semibold", 22, FontStyle.Bold);

                // نحدد لون الكتابة أبيض
                Brush brush = Brushes.White;

                // نحدد أول نقطة رسم بعد اللوجو
                float currentY = logoY + logoHeight + 60;

                // تنسيق للنص بالمنتصف
                StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center };

                // نرسم عنوان الفاتورة
                g.DrawString("فاتورة طلب", titleFont, brush, new RectangleF(0, currentY, width, 50), centerFormat);

                // ننزل سطر
                currentY += 80;

                // نرسم خط فاصل
                g.DrawString("------------------------------------------------------------", labelFont, brush, new RectangleF(0, currentY, width, 40), centerFormat);

                // ننزل سطر
                currentY += 60;

                // دالة داخلية لرسم صفين (قيمة يسار + عنوان يمين)
                void DrawRow(string label, string value)
                {
                    float padding = 60;

                    // نرسم القيمة (يسار)
                    g.DrawString(value, valueFont, brush, new PointF(padding, currentY));

                    // نرسم العنوان (يمين)
                    g.DrawString(label, labelFont, brush, new PointF(width - padding - 300, currentY));

                    // ننزل سطر
                    currentY += 60;
                }

                // رسم معلومات الطلب
                DrawRow(": رقم الطلب ", _Order.orderID.ToString());
                DrawRow(": اسم الزبون", _Order.PersonsInfo?.full_name ?? "غير محدد");
                DrawRow(": رقم الموبايل", _Order.PersonsInfo?.phone_number ?? "غير متوفر");
                DrawRow(": العنوان", _Order.PersonsInfo?.address ?? "غير متوفر");
                DrawRow(": المنتج", _Order.OrderItemsInfo?.ProductInfo?.productName ?? "غير معروف");

                decimal finalPrice = _Order.includesDelivery
                    ? clsGlobal.GetFinalOrderPrice(_Order, 5000)
                    : clsGlobal.GetFinalOrderPrice(_Order, 0);

                string deliveryText = _Order.includesDelivery ? "مع التوصيل" : "بدون توصيل";

                DrawRow(": السعر", $"{finalPrice:N0} د.ع - {deliveryText}");
                DrawRow(": تم دفع العربون", $"{_Order.paidAmount:N0} د.ع");
                DrawRow(": المبلغ المتبقي", $"{(finalPrice - _Order.paidAmount):N0} د.ع");
                DrawRow(": تاريخ الطلب", _Order.orderDate.ToString("g"));
                DrawRow(": حالة الطلب", clsGlobal.GetStatusText(_Order.orderStatus));
                DrawRow(": الملاحظات", _Order.Notes ?? "لا توجد ملاحظات");
                DrawRow(": الموظف", _Order.UsersInfo?.UserName ?? "غير محدد");

                currentY += 40;

                // نرسم خط فاصل أخير
                g.DrawString("------------------------------------------------------------", labelFont, brush, new RectangleF(0, currentY, width, 40), centerFormat);

                currentY += 60;

                // نرسم رسالة شكر
                g.DrawString("شكراً لتعاملكم ويانة", labelFont, brush, new RectangleF(0, currentY, width, 50), centerFormat);

                currentY += 80;
                // ===== الباركود =====
                Image barcode = Properties.Resources.Barcode; // صورة الباركود
                int barcodeWidth = 200;
                int barcodeHeight = 200;
                int barcodeX = (width - barcodeWidth) / 2;


                // خلفية بيضاء خلف الباركود
                Rectangle barcodeBg = new Rectangle(barcodeX - 30, (int)currentY - 30, barcodeWidth + 50, barcodeHeight + 50);
                g.FillRectangle(Brushes.White, barcodeBg);


                // نرسم الباركود
                g.DrawImage(barcode, barcodeX, (int)currentY, barcodeWidth, barcodeHeight);


                currentY += barcodeHeight + 40;
                // نرسم ظل خفيف للنص التسويقي
                g.DrawString(
                     "صورة طلبك تُنشر بعد الإنجاز تابعنا على إنستغرام",
                    marketingFont,
                    Brushes.White,
                    new RectangleF(0, currentY + 2, width, 40),
                    centerFormat
                );
                // نرسم النص الأبيض فوق الظل
                g.DrawString(
                      "صورة طلبك تُنشر بعد الإنجاز تابعنا على إنستغرام",
                    marketingFont,
                    Brushes.Gold, // هنا غيرنا اللون
                    new RectangleF(0, currentY, width, 40),
                    centerFormat
                );

            }

            // نرجع الصورة النهائية
            return bitmap;

        }


        // دالة ترسل الفاتورة للواتساب
        public static void SendInvoiceToWhatsapp(string phoneNumber, string message, clsOrders _Order)
        {
            // نحفظ الفاتورة ونجيب مسارها المؤقت
            string imagePath = SaveInvoiceTempImage(_Order);

            // نشيل المسافات فقط
            string cleanNumber = Regex.Replace(phoneNumber, @"\s+", "");

            // إذا الرقم يبدأ بصفر (رقم محلي)
            if (cleanNumber.StartsWith("0"))
            {
                // نشيل الصفر ونضيف رمز العراق
                cleanNumber = "964" + cleanNumber.Substring(1);
            }
            // إذا يبدأ بـ +964
            else if (cleanNumber.StartsWith("+964"))
            {
                // نشيل +
                cleanNumber = cleanNumber.Substring(1);
            }

            // نجهز نص الرسالة للواتساب
            string encodedMessage = Uri.EscapeDataString(message);

            // نكوّن رابط الواتساب
            string whatsappUrl = $"https://wa.me/{cleanNumber}?text={encodedMessage}";

            // نفتح الواتساب
            Process.Start(new ProcessStartInfo
            {
                FileName = whatsappUrl,
                UseShellExecute = true
            });

            // نفتح ملف الصورة بمكانه حتى المستخدم يرسلها
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = $"/select,\"{imagePath}\"",
                UseShellExecute = true
            });
        }

        // دالة مستقبلية لتصدير الفاتورة PDF
        public static void ExportInvoiceAsPDF()
        {
            // كود PDF لاحقاً
        }
    }
}
