using BusinessLayeres; // نستدعي طبقة الأعمال حتى نكدر نستخدم الدوال اللي تتعامل ويا البيانات
using ETEZAN2024.forms_And_Contrls.Orders.From; // نستدعي الفورمات الخاصة بالـ Orders (شاشات عرض التفاصيل)
using ETEZAN2024.FormsAndControls.GlobalClasses; // نستدعي الكلاسات العامة مثل clsOrderNotifier و clsGlobal
using System; // نستدعي مكتبة النظام الأساسية (تواريخ، استثناءات، الخ)
using System.Collections.Generic; // مكتبة تحتوي أنواع مثل List و Dictionary
using System.ComponentModel; // مكتبة خاصة بمكونات الفورم (الـ CancelEventArgs وغيرها)
using System.Data; // مكتبة خاصة بالتعامل ويا الجداول DataTable و DataRow
using System.Drawing; // مكتبة الألوان والرسم (Color)
using System.Linq; // مكتبة توفر دوال فلترة وترتيب (LINQ) لو احتجنا
using System.Text; // مكتبة للتعامل ويا النصوص و StringBuilder
using System.Threading.Tasks; // مكتبة للعمليات غير المتزامنة (async/await)
using System.Windows.Forms; // مكتبة واجهات المستخدم الفورمات (Buttons, DataGridView...)

// نفرّغ سطر علشان نفصّل الشرح
// هذا الفايل يحتوي فورم يعرض الطلبات النشطة ويا الوقت المتبقي

namespace ETEZAN2024.forms_And_Contrls.Orders // مساحة الأسماء تنظم الكلاسات حسب مكانها بالمشروع
{ // بداية namespace
    public partial class frmActiveOrdersWithRemainingTimeList : Form // تعريف الكلاس مالت الفورم، يرث من Form
    { // بداية الكلاس
        private int _LastNotifiedMinute = -1;

        clsOrders OrderInfo; // متغير من نوع clsOrders يخزن بيانات الطلب المحدد (راح نستخدمه وقت الحاجة)
        public frmActiveOrdersWithRemainingTimeList() // الكونستركتر ينفذ أول ما انسوي كائن من الفورم
        { // بداية الكونستركتر
            InitializeComponent(); // ينشئ كل عناصر الفورم (تصميم الواجهة وما يحتاج تكتبه)
        } // نهاية الكونستركتر

        private void _RefreshActiveOrdersWithRemainingTimeList() // دالة لتحديث الطلبات النشطة مع الوقت المتبقي
        {
            int activeCount;               // يخزن عدد الطلبات النشطة
            string nearestBooking;         // يخزن أقرب موعد حجز

            // 1. جلب البيانات من الدالة المركزية
            var dt = clsGlobal.GetActiveOrdersWithRemainingTime(out activeCount, out nearestBooking);

            // 2. ربط البيانات بالـ DataGridView
            dgvAllActiveOrdersWithRemainingTime.DataSource = dt;

            // 3. إذا لا توجد بيانات → نعالج الموقف بأمان
            if (dt == null || dt.Rows.Count == 0)
            {
                // عرض عدد الطلبات = صفر
                lbOrdersCount.Text = "عدد الطلبات الغير مكتملة : 0";

                // عرض أقرب موعد = لا يوجد
                lblNearestBooking.Text = "أقرب موعد حجز : -";

                // تعطيل الفلتر لأنه لا بيانات
                cmbFilterProductInventorieInfo.Enabled = false;

                // تعطيل قائمة السياق
                ctmsActiveOrdersManagement.Enabled = false;

                return; // الخروج لمنع الوصول لأعمدة غير موجودة
            }

            // 4. تفعيل الفلتر بعد وجود بيانات
            cmbFilterProductInventorieInfo.Enabled = true;

            // 5. تعديل الأعمدة بشكل آمن
            if (dgvAllActiveOrdersWithRemainingTime.Columns.Count > 1)
                dgvAllActiveOrdersWithRemainingTime.Columns[1].Width = 200;

            if (dgvAllActiveOrdersWithRemainingTime.Columns.Count > 2)
                dgvAllActiveOrdersWithRemainingTime.Columns[2].Width = 170;

            if (dgvAllActiveOrdersWithRemainingTime.Columns.Count > 3)
                dgvAllActiveOrdersWithRemainingTime.Columns[3].Width = 170;

            if (dgvAllActiveOrdersWithRemainingTime.Columns.Count > 4)
                dgvAllActiveOrdersWithRemainingTime.Columns[4].Width = 150;

            // 6. تحديث الليبلات
            lbOrdersCount.Text = $"عدد الطلبات الغير مكتملة  : {activeCount}";
            lblNearestBooking.Text = $"أقرب موعد حجز : {nearestBooking}";

            // 7. تلوين الصفوف حسب الوقت المتبقي
            foreach (DataGridViewRow row in dgvAllActiveOrdersWithRemainingTime.Rows)
            {
                // فحص وجود العمود "الوقت المتبقي"
                if (!dgvAllActiveOrdersWithRemainingTime.Columns.Contains("الوقت المتبقي"))
                    break;

                // قراءة قيمة الخلية بشكل آمن
                var cellValue = row.Cells["الوقت المتبقي"].Value;
                if (cellValue == null)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    continue;
                }

                string remainingStr = cellValue.ToString();

                // شرط: باقي ساعة فقط → أصفر
                if (remainingStr.Contains("0ي") && remainingStr.Contains("1س"))
                    row.DefaultCellStyle.BackColor = Color.LightYellow;

                // شرط: باقي دقائق فقط → أحمر
                else if (remainingStr.Contains("0ي") && remainingStr.Contains("0س"))
                    row.DefaultCellStyle.BackColor = Color.LightCoral;

                // غيرها → أخضر (وضع طبيعي)
                else
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }

            // 8. تفعيل أو تعطيل قائمة السياق حسب وجود طلبات نشطة
            ctmsActiveOrdersManagement.Enabled = activeCount > 0;
        }

        private void frmActiveOrdersWithRemainingTime_Load(object sender, EventArgs e) // حدث ينفذ أول ما الفورم يفتح
        { // بداية الحدث
            _RefreshActiveOrdersWithRemainingTimeList(); // ننادي الدالة حتى نعرض البيانات أول ما تنفتح الشاشة
           // clsTimerBookingNotifierService.Start();


        } // نهاية الحدث

        private void ctmsDetailOrder_Click(object sender, EventArgs e) // حدث اختيار "تفاصيل الطلب" من القايمة
        { // بداية الحدث
            // نفتح نافذة جديدة تعرض تفاصيل الطلب، ونمرر رقم الطلب من الخلية الاولى للصف المحدد
            frmShowOrderDetials frmShow = new frmShowOrderDetials((int)dgvAllActiveOrdersWithRemainingTime.CurrentRow.Cells[0].Value); // نحضر الفورم ونعطيه الـ OrderItemID
            frmShow.ShowDialog(); // نظهر الفورم كحوار modal حتى يغلق المستخدم قبل العودة
            _RefreshActiveOrdersWithRemainingTimeList(); // نحدث اللستة بعد ما يسكر فورم التفاصيل (لأي تغيير محتمل)
        } // نهاية الحدث

        private void ctmsWhatsappPerson_Click(object sender, EventArgs e) // حدث زر إرسال واتساب لشخص
        { // بداية الحدث
            int OrderID = (int)dgvAllActiveOrdersWithRemainingTime.CurrentRow.Cells[0].Value; // نجيب رقم الطلب من الصف المحدد
            OrderInfo = clsOrders.FindOrder(OrderID); // نجيب تفاصيل الطلب من الطبقة التجارية (BusinessLayer)
            // ارسال رسالة بسيطة للزبون عبر واتساب (دالة موجودة في clsGlobal)
            clsGlobal.SendMessageToWhatsapp(OrderInfo.PersonsInfo.phone_number, "الــســلام عــلــيــكــم "); // نرسل رسالة ترحيبية
        } // نهاية الحدث

        private void ctmsCancelOrder_Click(object sender, EventArgs e) // حدث إلغاء الطلب من القائمة
        { // بداية الحدث
            int OrderIdD = (int)dgvAllActiveOrdersWithRemainingTime.CurrentRow.Cells[0].Value; // نجيب رقم الطلب من الصف الحالي

            // نطلب تأكيد من المستخدم قبل الإلغاء (Yes/No)
            if (MessageBox.Show("هل انت متاكد من اللغاء رقم الطلب  " + $" {OrderIdD} ", "اللغاء طلب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { // اذا اختار نعم
                clsGlobal.CanselOrderByOrderStatus(OrderIdD); // نستدعي دالة عامة تلغي الطلب بتحديث الحالة في الداتا
                _RefreshActiveOrdersWithRemainingTimeList(); // نحدث اللستة حتى تختفي او يتغير لون الصف الملغي
            } // نهاية الشرط
        } // نهاية الحدث


        private void ctmsOrderInProgressingNow_Click(object sender, EventArgs e) // حدث تحويل الطلب الى "قيد التنفيذ الآن"
        { // بداية الحدث
            int OrderID = (int)dgvAllActiveOrdersWithRemainingTime.CurrentRow.Cells[0].Value; // نجيب رقم الطلب من الصف المحدد
            clsOrderNotifier.Order order = new clsOrderNotifier.Order(OrderID); // نسوي مصدر حدث جديد للطلب ونمرره الـ ID
            clsOrderNotifier.WhatsappServiec whatsapp = new clsOrderNotifier.WhatsappServiec("  يجري تنفيذ طلبكم حاليًا… نشكركم على انتظاركم "); // ننشئ خدمة واتساب مع نص الرسالة
            clsOrderNotifier.SaveToDataBase saveToDataBase = new clsOrderNotifier.SaveToDataBase(); // ننشئ خدمة الحفظ بالقاعدة

            saveToDataBase.Subscribe(order); // نشترك بخدمة الحفظ حتى يتم تنفيذها لما ينطلق الحدث
            whatsapp.Subscribe(order); // نشترك بخدمة واتساب حتى تنرسل رسالة للمشترك

            // هنا نبيّن حالة الطلب كـ "قيد التنفيذ" ونطلق الحدث
            byte orderStatus = 1; // نحدد كود الحالة 1 يعني "قيد التنفيذ" حسب تعريفكم
            order.CreateOrder(orderStatus); // نطلق الحدث ونمرر الحالة الجديدة حتى المشتركين يتعاملون ويحدثون الداتا ويرسلون اشعارات
            _RefreshActiveOrdersWithRemainingTimeList(); // نحدث اللستة بعد التغيير حتى ينعكس على الواجهة
        } // نهاية الحدث ctmsOrderInProgressingNow

        private void ctmsPendingOrder_Click(object sender, EventArgs e)
        {
            // بداية الحدث
            int OrderID = (int)dgvAllActiveOrdersWithRemainingTime.CurrentRow.Cells[0].Value; // نجيب رقم الطلب من الصف المحدد
            clsOrderNotifier.Order order = new clsOrderNotifier.Order(OrderID); // نسوي مصدر حدث جديد للطلب ونمرره الـ ID
            clsOrderNotifier.WhatsappServiec whatsapp = new clsOrderNotifier.WhatsappServiec(" اهلا , العفو تم تأجيل طلبكم . بس يكمل الطلب انشاللة نبلغكم "); // ننشئ خدمة واتساب مع نص الرسالة
            clsOrderNotifier.SaveToDataBase saveToDataBase = new clsOrderNotifier.SaveToDataBase(); // ننشئ خدمة الحفظ بالقاعدة

            saveToDataBase.Subscribe(order); // نشترك بخدمة الحفظ حتى يتم تنفيذها لما ينطلق الحدث
            whatsapp.Subscribe(order); // نشترك بخدمة واتساب حتى تنرسل رسالة للمشترك

            // هنا نبيّن حالة الطلب كـ "موجل" ونطلق الحدث
            byte orderStatus = 2; // نحدد كود الحالة 1 يعني "قيد التنفيذ" حسب تعريفكم
            order.CreateOrder(orderStatus); // نطلق الحدث ونمرر الحالة الجديدة حتى المشتركين يتعاملون ويحدثون الداتا ويرسلون اشعارات
            _RefreshActiveOrdersWithRemainingTimeList(); // نحدث اللستة بعد التغيير حتى ينعكس على الواجهة
        }

        private void cmstCompletedOrder_Click(object sender, EventArgs e)
        {
            // بداية الحدث
            int OrderID = (int)dgvAllActiveOrdersWithRemainingTime.CurrentRow.Cells[0].Value; // نجيب رقم الطلب من الصف المحدد
            clsOrderNotifier.Order order = new clsOrderNotifier.Order(OrderID); // نسوي مصدر حدث جديد للطلب ونمرره الـ ID
            clsOrderNotifier.WhatsappServiec whatsapp = new clsOrderNotifier.WhatsappServiec("بكل سرور ،  إن طلبكم اكتمل وتم تجهيزه بالكامل. نورتونا!");
            clsOrderNotifier.SaveToDataBase saveToDataBase = new clsOrderNotifier.SaveToDataBase(); // ننشئ خدمة الحفظ بالقاعدة

            saveToDataBase.Subscribe(order); // نشترك بخدمة الحفظ حتى يتم تنفيذها لما ينطلق الحدث
            whatsapp.Subscribe(order); // نشترك بخدمة واتساب حتى تنرسل رسالة للمشترك

            // هنا نبيّن حالة الطلب كـ "مكتمل" ونطلق الحدث
            byte orderStatus = 3; // نحدد كود الحالة 1 يعني "قيد التنفيذ" حسب تعريفكم
            order.CreateOrder(orderStatus); // نطلق الحدث ونمرر الحالة الجديدة حتى المشتركين يتعاملون ويحدثون الداتا ويرسلون اشعارات
            _RefreshActiveOrdersWithRemainingTimeList(); // نحدث اللستة بعد التغيير حتى ينعكس على الواجهة
            frmAddAndEditOrders.SendOrderAmountToCashBoxDistribution(clsGlobal.CurrentOrderInfo); // ارسال المبلغ الى شاشة توزيع الصندوق


        }

        private void dgvAllActiveOrdersWithRemainingTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    } // نهاية الكلاس frmActiveOrdersWithRemainingTimeList
} // نهاية namespace
