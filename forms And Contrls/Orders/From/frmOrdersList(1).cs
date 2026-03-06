using BusinessLayeres; // نستدعي الطبقة التجارية اللي تحتوي الكلاسات مالت الداتا واللوجيك
using ETEZAN2024.forms_And_Contrls.Orders.From;
using System; // نستخدم أساسيات اللغة (DateTime, Exception الخ)
using System.Collections.Generic; // لو حنستخدم قوايم List وهايج
using System.ComponentModel; // مكتبة مكونات النوافذ والتحقق
using System.Data; // نتعامل ويا DataTable و DataView
using System.Drawing; // للرسومات والألوان بحالات الفورم
using System.Linq; // لو احتجنا لــ LINQ (ما نستخدمه هنا بس ضايفينه)
using System.Text; // للتعامل وي النصوص لو احتجنا
using System.Threading.Tasks; // للـ async/task لو احتجنا بعدين
using System.Windows.Forms; // نستخدم عناصر الفورم والكنترولز

namespace ETEZAN2024.forms_And_Contrls.Orders // هاي مساحة الاسم لهذا الفورم وحته المرتبطة بالطلبات
{
    public partial class frmOrdersList : Form // تعريف الفورم اللي يعرض قائمة الطلبات
    {
        DataTable _dtOrderList; // جدول يحتفظ بكل البيانات للطلبات
        DataView _dvOrderList; // عرض قابل للفلترة من الـ DataTable
        string _ColumnName = "";
        public frmOrdersList() // الكونستركتر للفورم
        {
            InitializeComponent(); // يهيئ عناصر الفورم ويجهزها
        }

        private void _RefreshOrdersList() // دالة تحديث جدول الطلبات
        {
            // 1. جلب كل الطلبات من الطبقة التجارية وتخزينها داخل DataTable
            _dtOrderList =  clsOrders.GetAllOrdersList();

            // 2. التحقق من نتيجة الدالة: هل رجعت NULL (فشل/لا توجد بيانات)؟
            if (_dtOrderList == null || _dtOrderList.Rows.Count == 0)
            {
                // عرض رسالة تنبيه لمرة واحدة فقط بأن القائمة فارغة
                MessageBox.Show("لا توجد طلبات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // تعطيل الكونتكس مينو لأن لا توجد بيانات
                ctmsOrdersManagement.Enabled = false;
                cmbFilterOrderInfo.Enabled = false;
                // عرض صفر بعدد الطلبات
                lbOrdersCount.Text = "0";

                // مسح الجدول من الواجهة لتجنب بيانات قديمة
                dgvAllOrders.DataSource = null;

                return; // الخروج لمنع الوصول للأعمدة
            }

            // 3. ربط البيانات بالـ DataGridView بعد التأكد من وجود بيانات
            dgvAllOrders.DataSource = _dtOrderList;

            // 4. ضبط عرض الأعمدة بشكل آمن (نعمل فحص قبل الوصول حتى نتجنب OutOfRange)
            if (dgvAllOrders.Columns.Count > 0)
                dgvAllOrders.Columns[0].Width = 70;  // معرف الطلب

            if (dgvAllOrders.Columns.Count > 1)
                dgvAllOrders.Columns[1].Width = 120; // عمود 2

            if (dgvAllOrders.Columns.Count > 2)
                dgvAllOrders.Columns[2].Width = 80;  // عمود 3

            if (dgvAllOrders.Columns.Count > 3)
                dgvAllOrders.Columns[3].Width = 120; // عمود 4

            if (dgvAllOrders.Columns.Count > 4)
                dgvAllOrders.Columns[4].Width = 50;  // عمود 5

            if (dgvAllOrders.Columns.Count > 5)
                dgvAllOrders.Columns[5].Width = 120; // عمود 6

            if (dgvAllOrders.Columns.Count > 12)
                dgvAllOrders.Columns[12].Width = 40; // عمود 13

            if (dgvAllOrders.Columns.Count > 13)
                dgvAllOrders.Columns[13].Width = 60; // عمود 14

            if (dgvAllOrders.Columns.Count > 14)
                dgvAllOrders.Columns[14].Width = 40; // عمود 15

            // 5. تحديث عداد عدد الطلبات
            lbOrdersCount.Text = dgvAllOrders.RowCount.ToString();

            // 6. تفعيل الكونتكس مينو لأن البيانات موجودة الآن
            ctmsOrdersManagement.Enabled = true;
            cmbFilterOrderInfo.Enabled = true;

        }

        private void _FillcomboxByOrderInfo() // تملى قائمة الفلترة بالاعمدة المتاحة
        {
            cmbFilterOrderInfo.Items.Add("لاشيئ"); // خيار ماكو فلتر
            cmbFilterOrderInfo.Items.Add("معرف الطلب"); // فلتر حسب المعرف
            cmbFilterOrderInfo.Items.Add("اسم الزبون"); // فلتر حسب اسم الزبون
            cmbFilterOrderInfo.Items.Add("اسم المنتج"); // فلتر حسب اسم المنتج
            cmbFilterOrderInfo.Items.Add("تاريخ الطلب"); // فلتر حسب التاريخ
            cmbFilterOrderInfo.Items.Add("حالة الطلب"); // فلتر حسب الحالة
            cmbFilterOrderInfo.Items.Add("رقم الهاتف"); // فلتر حسب رقم الهاتف
            cmbFilterOrderInfo.Items.Add("العنوان"); // فلتر حسب العنوان
            cmbFilterOrderInfo.Items.Add("المدينة"); // فلتر حسب المدينة
        }

        private void _FillcomboxByOrderStuats() // تملى ComboBox بحالات الطلب الجاهزة
        {
            cmbIsOrderStutas.Items.Add("الكل"); // كل الحالات
            cmbIsOrderStutas.Items.Add("جديد"); // حالة جديد
            cmbIsOrderStutas.Items.Add("قيد التنفيذ"); // حالة قيد التنفيذ
            cmbIsOrderStutas.Items.Add("مؤجل"); // حالة مؤجل
            cmbIsOrderStutas.Items.Add("مكتمل"); // حالة مكتمل
            cmbIsOrderStutas.Items.Add("ملغي"); // حالة ملغي
        }

        private void _ApplyFilterOrderStatus(string OrdrSatutsColumnName) // تطبق فلتر الحالة على الـ DataView
        {
            if (_dvOrderList == null)
                return; // ماكو بيانات للفلترة

            if (string.IsNullOrEmpty(OrdrSatutsColumnName))
                return; // العمود ما متزود صحيح
            switch (OrdrSatutsColumnName) // نشرط على قيمة الـ ComboBox اللي تختارها
            {
                case "الكل": // اذا اخترنا الكل
                    {
                        _dvOrderList.RowFilter = ""; // نرجع كل السجلات
                        break; // نطلع من الكيس
                    }
                case "جديد": // فلترة على الجديد
                    {
                        _dvOrderList.RowFilter = $"[{_ColumnName}] = 'جديد'"; // صيغة فلتر الداتا فيو
                        break;
                    }
                case "قيد التنفيذ": // فلترة على قيد التنفيذ
                    {
                        _dvOrderList.RowFilter = $"[{_ColumnName}] = 'قيد التنفيذ'";
                        break;
                    }
                case "مؤجل": // فلترة على مؤجل
                    {
                        _dvOrderList.RowFilter = $"[{_ColumnName}] = 'مؤجل'";
                        break;
                    }
                case "مكتمل": // فلترة على مكتمل
                    {
                        _dvOrderList.RowFilter = $"[{_ColumnName}] = 'مكتمل'";
                        break;
                    }
                case "ملغي": // فلترة على ملغي
                    {
                        _dvOrderList.RowFilter = $"[{_ColumnName}] = 'ملغي'";
                        break;
                    }
                default: // اي قيمة ثانية
                    {
                        _dvOrderList.RowFilter = ""; // نلغي الفلتر
                        break;
                    }
            }

            lbOrdersCount.Text = _dvOrderList.Count.ToString(); // نحدّث عدد الطلبات المعروضة
        }

        private void _ApplyFilterOrderInfo(string ColumnName, string filterValue) // تطبق فلتر عام حسب العمود والقيمة
        {
            _ColumnName = ColumnName;
            _dtOrderList =  clsOrders.GetAllOrdersList(); // نجيب كل البيانات من جديد
            _dvOrderList = new DataView(_dtOrderList); // نخلق DataView للفلترة

            if (string.IsNullOrEmpty(filterValue) && ColumnName == "لاشيئ") // اذا ماكو قيمة فلتر واختار لاشي
            {
                tbFilterValue.Visible = false; // نخفي صندوق النص
                tbFilterValue.Text = ""; // نفرغه
               cmbIsOrderStutas.SelectedIndex = 0;
                _RefreshOrdersList(); // نرجع نحدّث القائمة كاملة
                return; // نطلع من الدالة
            }

            switch (ColumnName) // نطبق الفلترة حسب العمود اللي انختار
            {
                case "معرف الطلب": // اذا نريد فلترة بالمعرف
                    {
                        cmbIsOrderStutas.Visible = false; // نخفي قائمة الحالات
                        tbFilterValue.Visible = true; // نعرض صندوق النص
                        _dvOrderList.RowFilter = $"Convert([معرف الطلب], 'System.String') LIKE '%{filterValue}%'"; // فلترة باستخدام Convert
                        lbOrdersCount.Text = _dvOrderList.Count.ToString(); // نحدّث العداد
                        break;
                    }
                case "تاريخ الطلب": // اذا نريد فلترة بالتاريخ
                    {
                        cmbIsOrderStutas.Visible = false; // نخفي قائمة الحالات
                        tbFilterValue.Visible = true; // نعرض صندوق النص

                        _dvOrderList.RowFilter = $"Convert([تاريخ الطلب], 'System.String') LIKE '%{filterValue}%'";


                        //// نحدد بداية اليوم ونهايته (حتى لو كان العمود يحتوي وقت)
                        //DateTime selectedDate = dateTimePicker1.Value.Date;
                        //DateTime nextDate = selectedDate.AddDays(1);

                        //// نخلي الفلتر على شكل شرط بين تاريخين
                        //_dvOrderList.RowFilter = $"[تاريخ الطلب] >= #{selectedDate:MM/dd/yyyy}# AND [تاريخ الطلب] < #{nextDate:MM/dd/yyyy}#";

                        lbOrdersCount.Text = _dvOrderList.Count.ToString();




                        // هنا نحول التاريخ الى نص (مثلا dd/MM/yyyy أو أي صيغة تحبها)

                        break;
                    }

                case "حالة الطلب": // فلترة حسب الحالة
                    {
                        cmbIsOrderStutas.Visible = true; // نعرض قائمة الحالة
                        cmbIsOrderStutas.SelectedIndex = 0; // نضبطها على "الكل" بشكل افتراضي
                        _ApplyFilterOrderStatus(cmbIsOrderStutas.Text); // نطبق فلتر الحالة عن طريق الدالة المخصصة
                        break;
                    }
                default: // باقي الاعمدة النصية
                    {
                        cmbIsOrderStutas.Visible = false; // نخفي قائمة الحالة
                        tbFilterValue.Visible = true; // نعرض صندوق النص
                        _dvOrderList.RowFilter = $"[{ColumnName}] like '%{filterValue}%'"; // فلترة نصية باستخدام LIKE
                        lbOrdersCount.Text = _dvOrderList.Count.ToString(); // نحدّث العداد
                        break;
                    }
            }

            dgvAllOrders.DataSource = _dvOrderList; // نربط الـ DataGridView بالـ DataView بعد الفلترة
        }

        private void frmOrdersList_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _RefreshOrdersList(); // نجيب القائمة كاملة
            _FillcomboxByOrderInfo(); // نعبي الـ ComboBox بالخيارات
            _FillcomboxByOrderStuats(); // نعبي حالات الطلب
            cmbFilterOrderInfo.SelectedIndex = 0; // نضبط الافتراضي لاشي
        }

        private void pBoxAddOrder_Click(object sender, EventArgs e) // حدث الضغط على او زر اضافة طلب
        {
            frmAddAndEditOrders frmAddAnd = new frmAddAndEditOrders(); // نفتح الفورم مال الاضافة
            frmAddAnd.ShowDialog(); // نعرضه دياLOGي
            _RefreshOrdersList(); // بعد ما يقفل الفورم نحدث الليست
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }

        private void ctmsEidtOrder_Click(object sender, EventArgs e) // تعديل الطلب من القائمة (context menu)
        {
            frmAddAndEditOrders frmAddAnd = new frmAddAndEditOrders((int)dgvAllOrders.CurrentRow.Cells[0].Value); // نمرر الـ OrderItemID
            frmAddAnd.ShowDialog(); // نفتح الفورم
            _RefreshOrdersList(); // نحدث الليست بعد التعديل
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }

        private void cmbFilterOrderInfo_SelectedIndexChanged(object sender, EventArgs e) // تغيير نوع الفلتر
        {
            if (cmbFilterOrderInfo.Text == "لاشيئ") // اذا ماكو فلتر
            {
                tbFilterValue.Visible = false; // نخفي صندوق النص
                cmbIsOrderStutas.Visible = false; // نخفي قائمة الحالة ايضا
                tbFilterValue.Text = ""; // نفرغ قيمة النص
                return; // نطلع من الحدث
            }
            if (cmbFilterOrderInfo.Text == "حالة الطلب") // اذا اخترنا فلتر الحالة
            {
                tbFilterValue.Visible = false; // نخفي النص
                cmbIsOrderStutas.Visible = true; // نعرض قائمة الحالة
            }
            _ApplyFilterOrderInfo(cmbFilterOrderInfo.Text, tbFilterValue.Text); // ننفذ الفلتر بناءً على الاختيار والنص
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e) // اذا تغير نص الفلتر
        {
            _ApplyFilterOrderInfo(cmbFilterOrderInfo.Text, tbFilterValue.Text); // ننفذ الفلتر بناءً على الاختيار والنص

        }

        private void cmbIsOrderStutas_SelectedIndexChanged(object sender, EventArgs e) // اذا تغير اختيار حالة الطلب
        {
       
            _ApplyFilterOrderStatus(cmbIsOrderStutas.Text); // نطبق فلتر الحالة
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e) // حدث الضغط على كيبورد داخل صندوق الفلتر
        {


            if (cmbFilterOrderInfo.Text == "معرف الطلب")
            { // اذا الفلتر حسب المعرف نخلي الادخال رقمي بس
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
                if (cmbFilterOrderInfo.Text == "تاريخ الطلب")
                {
                    // نسمح فقط بالأرقام + الـ Backspace + علامة /
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                
            
            }

            }
        

        private void ctmsAddOrder_Click(object sender, EventArgs e)
        {
            frmAddAndEditOrders frmAddAnd = new frmAddAndEditOrders(); // نفتح الفورم مال الاضافة
            frmAddAnd.ShowDialog(); // نعرضه دياLOGي
            _RefreshOrdersList(); // بعد ما يقفل الفورم نحدث الليست
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }

        private void ctmsDetailOrder_Click(object sender, EventArgs e)
        {
            frmShowOrderDetials OrderDetials = new frmShowOrderDetials((int)dgvAllOrders.CurrentRow.Cells[0].Value); // نفتح الفورم مال الاضافة
            OrderDetials.ShowDialog(); // نعرضه دياLOGي
            _RefreshOrdersList();
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }
        //تفعيل واغلاق كونتس مينيو مال  طلب
        private void ctmsOrdersManagement_Opening(object sender, CancelEventArgs e)
        {
            //تفعيل واغلاق كونتس مينيو مال تعديل معلومات طلب
            clsOrders clsOrders;
            clsOrders = clsOrders.FindOrder((int)dgvAllOrders.CurrentRow.Cells[0].Value);
            //نتحقق هنا  من حاله الطلب الشخص اذا مكتمل طلب  او ملغي ما نكدر نعدل المعلومات تنفتح كونتس مينو مال تعديل واذا العكس ماتنفتح
            bool isAble = clsOrders.orderStatus != 3 && clsOrders.orderStatus != 4;
            ctmsEidtOrder.Enabled = isAble;
            //نتحقق هنا  من حاله الطلب الشخص اذا مكتمل طلب  او ملغي ما نكدر نلغي الطلب  تنفتح كونتس مينو مال اللغاء اذا العكس ماتنفتح
           ctmsCanselOrder.Enabled = isAble;
        }

        private void ctmsCanselOrder_Click(object sender, EventArgs e)
        {
            int OrderIdD = (int)dgvAllOrders.CurrentRow.Cells[0].Value;
           
            if (MessageBox.Show("هل انت متاكد من اللغاء رقم الطلب  "  +$" {OrderIdD} ", "اللغاء طلب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // نطلب تأكيد
            {
                clsGlobal.CanselOrderByOrderStatus(OrderIdD);
           
                    _RefreshOrdersList(); // لو انحذف نحدث الليست
               
            }
            cmbIsOrderStutas.SelectedIndex = 0;
        }
    }
}
