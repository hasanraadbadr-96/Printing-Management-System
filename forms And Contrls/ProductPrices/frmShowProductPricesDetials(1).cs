using BusinessLayeres; // نستدعي الطبقة المسؤولة عن منطق العمل (Business Layer)
using System; // مكتبة الأساسيات
using System.Collections.Generic; // مكتبة القوائم
using System.ComponentModel; // مكتبة عناصر التحكم
using System.Data; // مكتبة التعامل مع الجداول
using System.Drawing; // مكتبة الرسوميات
using System.Linq; // مكتبة LINQ
using System.Text; // مكتبة النصوص
using System.Threading.Tasks; // مكتبة المهام
using System.Windows.Forms; // مكتبة الفورم

namespace ETEZAN2024.forms_And_Contrls.ProductPrices // نيمسبيس خاص بالفورم مال عرض تفاصيل سعر المنتج
{
    public partial class frmShowProductPricesDetials : Form // تعريف الكلاس المربوط بالفورم
    {
        private int _PriceID = 1; // متغير خاص ID للسعر الافتراضي يبدأ 1
        private clsProductPrices _ProductPrices; // كائن من كلاس سعر المنتجات

        public frmShowProductPricesDetials(int PriceID) // الكونستركتر ويا ID
        {
            InitializeComponent(); // تهيئة عناصر الفورم
            _PriceID = PriceID; // نخزن رقم السعر القادم من الاستدعاء
        }

        private void _ResetDefualtValues() // دالة تفرغ الحقول بالقيم الافتراضية
        {
            lbProductPriceID.Text = "####"; // نخلي علامات بدال الـ ID
            lbProductName.Text = "####"; // نخلي علامات بدال اسم المنتج
            lbProductSizes.Text = "####"; // نخلي علامات بدال الحجم
            lbProductPrice.Text = "####"; // نخلي علامات بدال السعر
            lbOptions.Text = "####"; // نخلي علامات بدال الخيارات
            lbQuantity.Text = "####"; // نخلي علامات بدال الكمية
            lbIsActive.Text = "####"; // نخلي علامات بدال حالة التفعيل
        }

        private void _FillProductPricesInfo() // دالة تملأ بيانات السعر من الكائن
        {
            lbAddAndEdit.Text = "تعديل سعر المنتج"; // نغير النص للتوضيح
            lbProductPriceID.Text = _ProductPrices.PriceID.ToString(); // نعرض رقم السعر
            lbProductName.Text = _ProductPrices.productInfo.productName; // نعرض اسم المنتج المرتبط
            lbProductSizes.Text = _ProductPrices.Size; // نعرض الحجم
            lbProductPrice.Text = _ProductPrices.Price.ToString(); // نعرض السعر
            lbOptions.Text = _ProductPrices.Options; // نعرض الخيارات

            if (_ProductPrices.IsActive) // اذا كان نشط
            {
                lbIsActive.Text = "نعم"; // نعرض "نعم"
            }
            else
            {
                lbIsActive.Text = "لا"; // نعرض "لا"
            }

            lbQuantity.Text = _ProductPrices.Quantity.ToString(); // نعرض الكمية
        }

        private void _LoadData(int PriceID) // دالة تجيب البيانات من قاعدة البيانات
        {
            _PriceID = PriceID; // نخزن ID اللي اجانا
            _ProductPrices = clsProductPrices.Find(_PriceID); // نبحث عن السعر من خلال ID

            if (_ProductPrices == null) // اذا ماكو بيانات
            {
                _ResetDefualtValues(); // نفرغ الحقول (ملاحظة: هنانة خطأ منطقي لأن المفروض يجي بعد نجاح مو فشل)
                MessageBox.Show("لم يتم العثور علئ هذا المنتج", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // نعرض رسالة خطأ
                this.Close(); // نغلق الفورم
                return; // نطلع من الدالة
            }

            _FillProductPricesInfo(); // اذا لكينا البيانات نملأ الحقول
        }

        private void frmShowProductPricesDetials_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _LoadData(_PriceID); // ننفذ تحميل البيانات
        }

        private void lnkEditProductPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // حدث الضغط على رابط التعديل
        {
            frmAddAndEditProductPrice frmEdit = new frmAddAndEditProductPrice(_PriceID); // نفتح فورم التعديل ونرسل ID
            frmEdit.ShowDialog(); // نعرض فورم التعديل
            _LoadData(_PriceID); // نعيد تحميل البيانات بعد التعديل
        }

        private void btaCansel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
