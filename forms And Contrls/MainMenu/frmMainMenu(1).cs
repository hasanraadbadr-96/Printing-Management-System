using BusinessLayeres; // نستدعي الطبقة الخاصة بالمنطق التجاري (Business Layer) اللي تربط الواجهة مع قاعدة البيانات
using ETEZAN2024.forms.Persons; // نستدعي النماذج الخاصة بإدارة الأشخاص
using ETEZAN2024.forms_And_Contrls.CashBoxs; // نستدعي النماذج الخاصة بإدارة صناديق الأموال
using ETEZAN2024.forms_And_Contrls.Debts; // نستدعي النماذج الخاصة بإدارة الديون
using ETEZAN2024.forms_And_Contrls.Inventories; // نستدعي النماذج الخاصة بالمخازن (Inventories)
using ETEZAN2024.forms_And_Contrls.Login;
using ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution; // نستدعي النماذج الخاصة بتوزيع الطلبات على الصناديق
using ETEZAN2024.forms_And_Contrls.Orders; // نستدعي النماذج الخاصة بالطلبات (Orders)
using ETEZAN2024.forms_And_Contrls.Products; // نستدعي النماذج الخاصة بالمنتجات
using ETEZAN2024.forms_And_Contrls.Users; // نستدعي النماذج الخاصة بالمستخدمين
using ETEZAN2024.forms_And_Contrls.Users.form; // نستدعي النماذج الفرعية المتعلقة بالمستخدمين
using ETEZAN2024.FormsAndControls.GlobalClasses;
using System; // مكتبة الأساسيات مثل الوقت والتاريخ والأنواع
using System.Collections.Generic; // مكتبة القوائم والمجاميع
using System.ComponentModel; // مكتبة للتحكم بخواص الكومبوننتات (components)
using System.Data; // مكتبة التعامل مع البيانات والجداول
using System.Drawing; // مكتبة الألوان والتصاميم الرسومية
using System.Linq; // مكتبة خاصة بالاستعلامات (LINQ)
using System.Security.Cryptography.X509Certificates;
using System.Text; // مكتبة معالجة النصوص
using System.Threading.Tasks; // مكتبة خاصة بالتنفيذ المتوازي أو المهام
using System.Windows.Forms; // مكتبة واجهات المستخدم الرسومية (Windows Forms)

namespace ETEZAN2024.forms.frmMainMenu // نعلن عن فضاء الأسماء الخاص بالقائمة الرئيسية
{
    public partial class frmMainMenu : Form // تعريف كلاس الفورم الرئيسي المسمى frmMainMenu
    {
        private int _LastNotifiedMinute = -1;
        public frmMainMenu() // الدالة البانية (Constructor) للفورم
        {
            InitializeComponent(); // استدعاء الميثود المسؤولة عن تحميل المكونات داخل الفورم
        }

        private void frmMainMenu_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            //استدعينا كلاس مال تايمر ينبهه اليوزر بوقت الحجوزات القريبه من ساعه وانته نازل علمود ماينسئ حجوزات
            clsTimerBookingNotifierService.Start();
        }

        private void ApplicationsManagement_MST_Click(object sender, EventArgs e) // حدث عند الضغط على "إدارة التطبيقات"
        {
            // حاليا ماكو كود، ممكن نضيف بيه نافذة خاصة بإدارة التطبيقات
        }

        private void PeopleManagement_MST_Click(object sender, EventArgs e) // حدث عند الضغط على "إدارة الأشخاص"
        {
            frmPersonsList frmPersonsManagement = new frmPersonsList(); // ننشئ نموذج جديد من قائمة الأشخاص
            frmPersonsManagement.ShowDialog(); // نعرض النافذة كـ Dialog (يعني توقف التطبيق لحين إغلاقها)
        }

        private void ctrlPersonDetails1_Load(object sender, EventArgs e) // حدث تحميل كنترول الأشخاص داخل الفورم
        {

        }

        private void UsersManagement_MST_Click(object sender, EventArgs e) // حدث عند الضغط على "إدارة المستخدمين"
        {
            frmUsersList UsersList = new frmUsersList(); // ننشئ نموذج جديد لقائمة المستخدمين
            UsersList.ShowDialog(); // نعرض النموذج كنافذة حوارية
        }

        private void mstrUserDetail_Click(object sender, EventArgs e) // حدث عند الضغط على "معلومات المستخدم"
        {
            frmUserInfo UserInfo = new frmUserInfo(clsGlobal.CurrentUser.UserID); // ننشئ نموذج يعرض تفاصيل المستخدم الحالي
            UserInfo.ShowDialog(); // نعرضه كـ Dialog
        }

        private void mstrChangePassword_Click(object sender, EventArgs e) // حدث عند الضغط على "تغيير كلمة المرور"
        {
            frmChangePasswordUser ChangePasswordUser = new frmChangePasswordUser(clsGlobal.CurrentUser.UserID); // ننشئ نموذج تغيير كلمة المرور
            ChangePasswordUser.ShowDialog(); // نعرضه
        }

        private void mstrLoggedout_Click(object sender, EventArgs e)
        {



            this.Close(); // أغلق الحالي أولاً
            frmLoginUser LoginUser = new frmLoginUser();
            //LoginUser.SetLoginTextBoxes(clsGlobal.CurrentUser.UserName, clsGlobal.CurrentUser.Password);
            // LoginUser.ShowDialog();
            this.Close();
        }

        private void Main_menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) // حدث عند الضغط على أي عنصر بالقائمة
        {
            // ممكن نستخدمه لاحقاً لمراقبة الضغطات على عناصر القائمة
        }

        private void mstNewOrder_Click(object sender, EventArgs e) // حدث عند الضغط على "طلب جديد"
        {
            frmAddAndEditOrders AddOrder = new frmAddAndEditOrders(); // ننشئ نموذج جديد لإضافة أو تعديل الطلبات
            AddOrder.ShowDialog(); // نعرضه
        }

        private void mstOrdersList_Click(object sender, EventArgs e) // حدث عند الضغط على "قائمة الطلبات"
        {
            frmOrdersList frmOrdersList = new frmOrdersList(); // ننشئ نموذج لقائمة الطلبات
            frmOrdersList.ShowDialog(); // نعرضه
        }

        private void mstProductsList_Click(object sender, EventArgs e) // حدث عند الضغط على "قائمة المنتجات"
        {
            frmcProductsList ProductsList = new frmcProductsList(); // ننشئ نموذج لقائمة المنتجات
            ProductsList.ShowDialog(); // نعرضه
        }

        private void cmstAddProduct_Click(object sender, EventArgs e) // حدث عند الضغط على "إضافة منتج"
        {
            frmAddAndEidtProduct frmAdd = new frmAddAndEidtProduct(); // ننشئ نموذج لإضافة منتج جديد
            frmAdd.ShowDialog(); // نعرض النموذج
        }

        private void cmtAddProductInventory_Click(object sender, EventArgs e) // حدث عند الضغط على "إضافة منتج للمخزون"
        {
            frmAddAndEditProductsInventory frmAdd = new frmAddAndEditProductsInventory(); // ننشئ نموذج إضافة مخزون منتج
            frmAdd.ShowDialog(); // نعرضه
        }

        private void cmtProductsInventoryList_Click(object sender, EventArgs e) // حدث عند الضغط على "قائمة المخزون"
        {
            frmInventoriesList frmAdd = new frmInventoriesList(); // ننشئ نموذج لقائمة المخزون
            frmAdd.ShowDialog(); // نعرضه
        }

        private void cmtDebtsList_Click(object sender, EventArgs e) // حدث عند الضغط على "قائمة الديون"
        {
            frmDebtsList frmAdd = new frmDebtsList(); // ننشئ نموذج يعرض كل الديون
            frmAdd.ShowDialog(); // نعرضه
        }

        private void cmtAddDebt_Click(object sender, EventArgs e) // حدث عند الضغط على "إضافة دين"
        {
            frmAddAndEditDebt frmAdd = new frmAddAndEditDebt(); // ننشئ نموذج لإضافة أو تعديل الدين
            frmAdd.ShowDialog(); // نعرضه
        }

        private void mtsOrderCashBoxsDistributionL_Click(object sender, EventArgs e) // حدث عند الضغط على "توزيع أموال الطلبات"
        {
            frmOrderCashBoxsDistributionList boxsDistributionList = new frmOrderCashBoxsDistributionList(); // ننشئ نموذج لتوزيع الطلبات على الصناديق
            boxsDistributionList.ShowDialog(); // نعرضه
        }

        private void mstCashBoxsList_Click(object sender, EventArgs e) // حدث عند الضغط على "قائمة الصناديق"
        {
            frmCashBoxsList frmCashBoxsList = new frmCashBoxsList(); // ننشئ نموذج لقائمة الصناديق
            frmCashBoxsList.ShowDialog(); // نعرضه
        }

        private void mstAddCashBox_Click(object sender, EventArgs e) // حدث عند الضغط على "إضافة صندوق"
        {
            frmAddAndEditCashBox frmAddCashBox = new frmAddAndEditCashBox(); // ننشئ نموذج لإضافة أو تعديل صندوق
            frmAddCashBox.ShowDialog(); // نعرضه
        }

        private void mstrLoginLogs_Click(object sender, EventArgs e)
        {
            frmLoginLogs loginLogs = new frmLoginLogs();
            loginLogs.ShowDialog();
        }

        private void mstActiveOrdersWithRemainingTime_Click(object sender, EventArgs e)
        {
            frmActiveOrdersWithRemainingTimeList frmActiveOrdersWithRemainingTimes = new frmActiveOrdersWithRemainingTimeList();
            frmActiveOrdersWithRemainingTimes.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmtInventoryTransactionsList_Click(object sender, EventArgs e)
        {
            frmInventoryTransactionsList frmInventoryTransactionsList = new frmInventoryTransactionsList();
            frmInventoryTransactionsList.ShowDialog();
        }

      
    }
}
