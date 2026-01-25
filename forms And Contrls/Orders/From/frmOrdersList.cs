using BusinessLayeres; // نستدعي الطبقة التجارية اللي تحتوي الكلاسات مالت الداتا واللوجيك
using ETEZAN2024.forms_And_Contrls.GlobalClasses;
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
        int _currentPage  =1; // نفترض انو الصفحة الحالية 1
        int _nextPage ; // الصفحة الجاية
        int _PrevPage;// الصفحة السابقة

        public frmOrdersList() // الكونستركتر للفورم
        {
            InitializeComponent(); // يهيئ عناصر الفورم ويجهزها
        }

        private void _RefreshOrdersPagedList(int _PageNumber  , int _RowsPerNumber) // دالة تحديث جدول الطلبات
        {                              
          // ضبط رقم الصفحة على 0 (الصفحة الاولى)
            _dtOrderList =  clsOrders.GetOrdersPaged(_PageNumber, _RowsPerNumber);// جلب الطلبات مجزاء (صفحة الاولئ، 12 طلب بالصفحة)

            // 2. التحقق من نتيجة الدالة: هل رجعت NULL (فشل/لا توجد بيانات)؟
            if (_dtOrderList == null || _dtOrderList.Rows.Count == 0)
            {
 
               
                // عرض رسالة تنبيه لمرة واحدة فقط بأن القائمة فارغة
                MessageBox.Show("لا توجد طلبات اخرئ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PboxNext.Enabled = false; // تعطيل زر الصفحة التالية
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
            PboxNext.Enabled = true; // تفعيل زر الصفحة التالية

        }
        // دالة تحميل تقرير أعلى 10 زبائن حسب عدد الطلبات
        private void _LoadTop10CustomersByTotalOrdersReport()
        // الاسم مفهوم وطويل زيادة عن اللزوم
        // Refresh → يوحي تحديث بيانات موجودة، بينما هنا أنت دا تحمل تقرير جديد
        // الاسم أدق لو يكون Load بدل Refresh
        // احترافي أكثر: _LoadTop10CustomersByTotalOrdersReport
        {
            dgvAllOrders.DataSource = clsOrders.Rep_GetTop10CustomersByTotalOrders();
            // تحميل تقرير أعلى 10 زبائن حسب عدد الطلبات وربطه بالـ DataGridView

            if (dgvAllOrders.Columns.Count > 0)
                dgvAllOrders.Columns[0].Width = 200;
            // ضبط عرض العمود الأول

            if (dgvAllOrders.Columns.Count > 1)
                dgvAllOrders.Columns[1].Width = 200;
            // ضبط عرض العمود الثاني

            if (dgvAllOrders.Columns.Count > 2)
                dgvAllOrders.Columns[2].Width = 200;
            // ضبط عرض العمود الثالث

            if (dgvAllOrders.Columns.Count > 3)
                dgvAllOrders.Columns[3].Width = 200;
            // ضبط عرض العمود الرابع

            if (dgvAllOrders.Columns.Count > 4)
                dgvAllOrders.Columns[4].Width = 200;
            // ضبط عرض العمود الخامس

            if (dgvAllOrders.Columns.Count > 5)
                dgvAllOrders.Columns[5].Width = 200;
            // ضبط عرض العمود السادس

            if (dgvAllOrders.Columns.Count > 6)
                dgvAllOrders.Columns[6].Width = 300;
            // ضبط عرض العمود السابع

            if (dgvAllOrders.Columns.Count > 7)
                dgvAllOrders.Columns[7].Width = 300;
            // ضبط عرض العمود الثامن

            if (dgvAllOrders.Columns.Count > 8)
                dgvAllOrders.Columns[8].Width = 500;
            // ضبط عرض العمود التاسع

            lbOrdersCount.Text = dgvAllOrders.Rows.Count.ToString();
            // عرض عدد الصفوف (عدد الزبائن الظاهرين بالتقرير)
        }
        // دالة تحميل تقرير أقل 10 زبائن حسب عدد الطلبات
        private void _LoadLowsetTop10CustomersByTotalOrdersReport()
        {
            dgvAllOrders.DataSource = clsOrders.Rep_LowsetTop10CustomersByTotalOrders();// تحميل تقرير أقل 10 زبائن حسب عدد الطلبات وربطه بالـ DataGridView

            if (dgvAllOrders.Columns.Count > 0)
                dgvAllOrders.Columns[0].Width = 200;
            // ضبط عرض العمود الأول

            if (dgvAllOrders.Columns.Count > 1)
                dgvAllOrders.Columns[1].Width = 200;
            // ضبط عرض العمود الثاني

            if (dgvAllOrders.Columns.Count > 2)
                dgvAllOrders.Columns[2].Width = 200;
            // ضبط عرض العمود الثالث

            if (dgvAllOrders.Columns.Count > 3)
                dgvAllOrders.Columns[3].Width = 200;
            // ضبط عرض العمود الرابع

            if (dgvAllOrders.Columns.Count > 4)
                dgvAllOrders.Columns[4].Width = 200;
            // ضبط عرض العمود الخامس

            if (dgvAllOrders.Columns.Count > 5)
                dgvAllOrders.Columns[5].Width = 200;
            // ضبط عرض العمود السادس

            if (dgvAllOrders.Columns.Count > 6)
                dgvAllOrders.Columns[6].Width = 300;
            // ضبط عرض العمود السابع

            if (dgvAllOrders.Columns.Count > 7)
                dgvAllOrders.Columns[7].Width = 300;
            // ضبط عرض العمود الثامن

            if (dgvAllOrders.Columns.Count > 8)
                dgvAllOrders.Columns[8].Width = 500;
            // ضبط عرض العمود التاسع
            lbOrdersCount.Text = dgvAllOrders.Rows.Count.ToString();// عرض عدد الصفوف (عدد الزبائن الظاهرين بالتقرير)
        }
        // دالة تحميل تقرير أعلى 10 زبائن حسب إجمالي المبلغ
        private void _LoadReportTop10CustomersByTotalAmount()
        {
            dgvAllOrders.DataSource = clsOrders.Report_Top10CustomersByTotalAmount();// تحميل تقرير أقل 10 زبائن حسب عدد الطلبات وربطه بالـ DataGridView

            if (dgvAllOrders.Columns.Count > 0)
                dgvAllOrders.Columns[0].Width = 200;
            // ضبط عرض العمود الأول

            if (dgvAllOrders.Columns.Count > 1)
                dgvAllOrders.Columns[1].Width = 200;
            // ضبط عرض العمود الثاني

            if (dgvAllOrders.Columns.Count > 2)
                dgvAllOrders.Columns[2].Width = 200;
            // ضبط عرض العمود الثالث

            if (dgvAllOrders.Columns.Count > 3)
                dgvAllOrders.Columns[3].Width = 200;
            // ضبط عرض العمود الرابع

            if (dgvAllOrders.Columns.Count > 4)
                dgvAllOrders.Columns[4].Width = 200;
            // ضبط عرض العمود الخامس

            if (dgvAllOrders.Columns.Count > 5)
                dgvAllOrders.Columns[5].Width = 200;
            // ضبط عرض العمود السادس

            if (dgvAllOrders.Columns.Count > 6)
                dgvAllOrders.Columns[6].Width = 300;
            // ضبط عرض العمود السابع

            if (dgvAllOrders.Columns.Count > 7)
                dgvAllOrders.Columns[7].Width = 300;
            // ضبط عرض العمود الثامن

            if (dgvAllOrders.Columns.Count > 8)
                dgvAllOrders.Columns[8].Width = 500;
            // ضبط عرض العمود التاسع
            lbOrdersCount.Text = dgvAllOrders.Rows.Count.ToString();// عرض عدد الصفوف (عدد الزبائن الظاهرين بالتقرير)
        }

        // دالة تحميل تقرير طلبات اليوم
        private void _LoadReportGetOrdersToday()
        {
            dgvAllOrders.DataSource = clsOrders.Report_GetOrdersToday();

            // ضبط عرض العمود التاسع
            lbOrdersCount.Text = dgvAllOrders.Rows.Count.ToString();// عرض عدد الصفوف (عدد الزبائن الظاهرين بالتقرير)
        }
        // دالة تحميل تقرير طلبات هذا الأسبوع
        private void _LoadReportGetOrdersThisWeek()
        {
            dgvAllOrders.DataSource = clsOrders.Report_GetOrdersThisWeek();

            // ضبط عرض العمود التاسع
            lbOrdersCount.Text = dgvAllOrders.Rows.Count.ToString();// عرض عدد الصفوف (عدد الزبائن الظاهرين بالتقرير)
        }

        // دالة تحميل تقرير طلبات هذا الشهر
        private void _LoadReportGetOrdersThisMonth()
        {
            dgvAllOrders.DataSource = clsOrders.Report_GetOrdersThisMonth();

            // ضبط عرض العمود التاسع
            lbOrdersCount.Text = dgvAllOrders.Rows.Count.ToString();// عرض عدد الصفوف (عدد الزبائن الظاهرين بالتقرير)
        }

        // دالة تحميل تقرير إجمالي الطلبات الملغيه
        private void _LoadReportTotalOrderCanselled()
        {
            dgvAllOrders.DataSource = clsOrders.Report_TotalOrderCanselled();

        }

        // دالة تحميل تقرير إجمالي الطلبات المكتملة
        private void _LoadReport_TotalOrderCompleted()
        {
            dgvAllOrders.DataSource = clsOrders.Report_TotalOrderCompleted();

        }

        private void FillReportFiltersComboBox()
        {
            // تنظيف أي عناصر موجودة
            cmbReportFilters.Items.Clear();

            // إضافة عناصر فلترة احترافية
            cmbReportFilters.Items.Add("لاشيئ"); // خيار ماكو فلتر
            cmbReportFilters.Items.Add("أعلى 10 زبائن حسب عدد الطلبات");        // Top 10 customers by order count
            cmbReportFilters.Items.Add("أقل 10 زبائن حسب عدد الطلبات");         // Bottom 10 customers by order count
            cmbReportFilters.Items.Add("أعلى 10 زبائن حسب إجمالي المبلغ");       // Top 10 customers by total amount
            cmbReportFilters.Items.Add("طلبات اليوم");                          // Today's orders
            cmbReportFilters.Items.Add("طلبات هذا الأسبوع");                   // Orders this week
            cmbReportFilters.Items.Add("طلبات هذا الشهر");                     // Orders this month
            cmbReportFilters.Items.Add("الطلبات المكتملة");                     // Completed orders
            cmbReportFilters.Items.Add("الطلبات الملغية");                      // Cancelled orders
            cmbReportFilters.Items.Add("جميع الطلبات");                         // All orders        }
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

        // دالة تطبق تقرير حسب النوع المختار
        private void ApplyReportByType(string reportType)

        {

            switch (reportType)
            {
                case "لاشيئ":
                    {

                        _RefreshOrdersPagedList(1, 12); // نجيب كل البيانات من الصفحه الاولى
                        break;
                    }
                case "أعلى 10 زبائن حسب عدد الطلبات":
                    {

                        _LoadTop10CustomersByTotalOrdersReport();
                        break;
                    }
                case "أقل 10 زبائن حسب عدد الطلبات":
                    {
                        _LoadLowsetTop10CustomersByTotalOrdersReport();
                        break;
                    }
                case "أعلى 10 زبائن حسب إجمالي المبلغ":
                    {
                        _LoadReportTop10CustomersByTotalAmount();
                        break;
                    }
                case "طلبات اليوم":
                    {
                        _LoadReportGetOrdersToday();
                        break;
                    }
                case "طلبات هذا الأسبوع":
                    {
                        _LoadReportGetOrdersThisWeek();
                        break;
                    }
                case "طلبات هذا الشهر":
                    {
                        _LoadReportGetOrdersThisMonth();
                        break;
                    }
                case "الطلبات المكتملة":
                    {
                        _LoadReport_TotalOrderCompleted();
                        break;
                    }
                case "الطلبات الملغية":
                    {
                        _LoadReportTotalOrderCanselled();
                        break;
                    }
                case "جميع الطلبات":
                    {
                        dgvAllOrders.DataSource = clsOrders.GetAllOrdersList(); // نجيب كل البيانات من جديد
                        lbOrdersCount.Text= dgvAllOrders.Rows.Count.ToString();
                        break;
                    }
                default:
                    {
                        // منطق افتراضي هنا
                        break;
                    }
            }
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
                _RefreshOrdersPagedList(1,12); // نرجع نحدّث القائمة كاملة
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
            _RefreshOrdersPagedList(_currentPage, 12); // نحدّث قائمة الطلبات (الصفحة 1، 12 طلب بالصفحة)
            _FillcomboxByOrderInfo(); // نعبي الـ ComboBox بالخيارات
            _FillcomboxByOrderStuats(); // نعبي حالات الطلب
            FillReportFiltersComboBox();// نعبي خيارات تقرير الفلاتر
            cmbFilterOrderInfo.SelectedIndex = 0; // نضبط الافتراضي لاشي
            cmbReportFilters.SelectedIndex = 0; // نضبط الافتراضي لاشي
        }

        private void pBoxAddOrder_Click(object sender, EventArgs e) // حدث الضغط على او زر اضافة طلب
        {
            frmAddAndEditOrders frmAddAnd = new frmAddAndEditOrders(); // نفتح الفورم مال الاضافة
            frmAddAnd.ShowDialog(); // نعرضه دياLOGي
            _RefreshOrdersPagedList(1, 12); // نحدّث قائمة الطلبات (الصفحة 1، 12 طلب بالصفحة)
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }

        private void ctmsEidtOrder_Click(object sender, EventArgs e) // تعديل الطلب من القائمة (context menu)
        {
            frmAddAndEditOrders frmAddAnd = new frmAddAndEditOrders((int)dgvAllOrders.CurrentRow.Cells[0].Value); // نمرر الـ OrderItemID
            frmAddAnd.ShowDialog(); // نفتح الفورم
            _RefreshOrdersPagedList(_currentPage, 12); // نحدّث قائمة الطلبات (الصفحة 1، 12 طلب بالصفحة)
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
            _RefreshOrdersPagedList(1, 12); // نحدّث قائمة الطلبات (الصفحة 1، 12 طلب بالصفحة)
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }

        private void ctmsDetailOrder_Click(object sender, EventArgs e)
        {
            frmShowOrderDetials OrderDetials = new frmShowOrderDetials((int)dgvAllOrders.CurrentRow.Cells[0].Value); // نفتح الفورم مال الاضافة
            OrderDetials.ShowDialog(); // نعرضه دياLOGي
            _RefreshOrdersPagedList(1, 12); // نحدّث قائمة الطلبات (الصفحة 1، 12 طلب بالصفحة)
            cmbIsOrderStutas.SelectedIndex = 0; // نضبط الافتراضي لاشي

        }
        //تفعيل واغلاق كونتس مينيو مال  طلب
        private void ctmsOrdersManagement_Opening(object sender, CancelEventArgs e)
        {
            // منع ظهور القائمة إذا لا يوجد صف محدد
            if (dgvAllOrders.CurrentRow == null || dgvAllOrders.CurrentRow.Cells[0].Value == null || dgvAllOrders.CurrentRow.Cells[0].Value == DBNull.Value)
            {
                e.Cancel = true;
                return;
            }

            // الحصول على قيمة OrderID بشكل آمن
            int orderId;
            if (!int.TryParse(dgvAllOrders.CurrentRow.Cells[0].Value.ToString(), out orderId))
            {
                e.Cancel = true;
                return;
            }

            // استدعاء الدالة بشكل صحيح
            var order = clsOrders.FindOrder(orderId); // اسم متغير مختلف عن الكلاس

            if (order == null)
            {
                e.Cancel = true; // لا يوجد طلب بهذا الرقم
                return;
            }

            // تحقق من حالة الطلب اذا  كان طلب ما مكتمل او ملغي نسمح بالتعديل والالغاء
            bool isAble = order.orderStatus != 3 && order.orderStatus != 4;

            ctmsEidtOrder.Enabled = isAble;   // تعديل الطلب
            ctmsCanselOrder.Enabled = isAble; // إلغاء الطلب
        }

        private void ctmsCanselOrder_Click(object sender, EventArgs e)
        {
            int OrderIdD = (int)dgvAllOrders.CurrentRow.Cells[0].Value;
           
            if (MessageBox.Show("هل انت متاكد من اللغاء رقم الطلب  "  +$" {OrderIdD} ", "اللغاء طلب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // نطلب تأكيد
            {
                clsGlobal.CanselOrderByOrderStatus(OrderIdD);

                _RefreshOrdersPagedList(_currentPage, 12); // نحدّث قائمة الطلبات (الصفحة 1، 12 طلب بالصفحة)

            }
            cmbIsOrderStutas.SelectedIndex = 0;
        }

        private void ctmsWhatsappPerson_Click(object sender, EventArgs e)
        {
         
            int OrderID = (int)dgvAllOrders.CurrentRow.Cells[0].Value; // نجيب رقم الطلب من الصف المحدد
            clsOrders OrderInfo = clsOrders.FindOrder(OrderID); // نجيب تفاصيل الطلب من الطبقة التجارية (BusinessLayer)
            // ارسال رسالة بسيطة للزبون عبر واتساب (دالة موجودة في clsGlobal)
            clsGlobal.SendMessageToWhatsapp(OrderInfo.PersonsInfo.phone_number, "الــســلام عــلــيــكــم "); // نرسل رسالة ترحيبية
        }

        private void cmtsSaveInvoiceAsImage_Click(object sender, EventArgs e)
        {
            // جلب معلومات الطلب الحالي
            clsOrders OrderInfo = clsOrders.FindOrder((int)dgvAllOrders.CurrentRow.Cells[0].Value);
            // حفظ الفاتورة كصورة
            clsOrderInvoiceExporter.OnInvoiceExported = clsOrderInvoiceExporter .SaveInvoiceAsImage;
           // نمرر معرف الطلب الحالي
            clsOrderInvoiceExporter.OnInvoiceExported.Invoke(OrderInfo);
        }

        private void ctmsPrintInvoice_Click(object sender, EventArgs e)
        {
            // جلب معلومات الطلب الحالي
            clsOrders OrderInfo = clsOrders.FindOrder((int)dgvAllOrders.CurrentRow.Cells[0].Value);
            clsOrderInvoiceExporter.PrintInvoice(OrderInfo);
        }

        private void PboxNext_Click(object sender, EventArgs e)
        {

                _nextPage = _currentPage ++; // نزيد رقم الصفحة الحالية بواحد
            _RefreshOrdersPagedList(_currentPage, 12); // نزيد رقم الصفحة
        }

        private void PboxPrevious_Click(object sender, EventArgs e)
        {
            PboxNext.Enabled = true; // تفعيل زر الصفحة التالية

            // ننقص رقم الصفحة الحالية واحد
            _currentPage--;

            // اذا الصفحة نزلت اقل من 1 نرجعها 1
            if (_currentPage < 1)
            {
                MessageBox.Show("لا توجد طلبات اخرئ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _currentPage = 1;
            }

            // نحدث اللست حسب رقم الصفحة الحالي
            _RefreshOrdersPagedList(_currentPage, 12);
        }

        private void cmbReportFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyReportByType(cmbReportFilters.Text); // نطبق التقرير حسب النوع المختار
        }
    
    
    
    }
}
