using BusinessLayeres; // نستدعي مكتبة الطبقة الوسطية (Business Layer) حتى نتعامل ويا الكلاسات مثل clsUsers
using DVLD_ProjecteForms;
using ETEZAN2024.forms.frmMainMenu; // نستدعي الفورم الرئيسي frmMainMenu حتى نفتحه بعد تسجيل الدخول
using ETEZAN2024.forms_And_Contrls.GlobalClasses;
using ETEZAN2024.forms_And_Contrls.Login;
using ETEZAN2024.forms_And_Contrls.Orders;
using System; // مكتبة الأساسيات (DateTime, Convert, إلخ)
using System.Collections.Generic; // مكتبة الجنريك ليست (List<T>) والمجموعات
using System.ComponentModel; // مكتبة تدعم الـ Validation وأحداث الواجهة
using System.Data; // مكتبة للتعامل ويا الجداول DataTable و DataSet
using System.Diagnostics;
using System.Drawing; // مكتبة الألوان والتصاميم
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq; // مكتبة توفر استعلامات LINQ على البيانات
using System.Runtime.Serialization.Json;
using System.Text; // مكتبة معالجة النصوص
using System.Threading.Tasks; // مكتبة العمليات الغير متزامنة (Async/Await)
using System.Windows.Forms; // مكتبة واجهات Windows Forms

namespace ETEZAN2024 // مساحة الأسماء الرئيسية للمشروع
{

    public partial class frmLoginUser : Form // تعريف فورم تسجيل الدخول
    {
        frmMainMenu _frmMainMenu = new frmMainMenu(); // نفتح الفورم الرئيسي
        frmLoginLogs _frmLoginLogs = new frmLoginLogs();
        frmActiveOrdersWithRemainingTimeList _frmActiveOrdersWithRemainingTimes = new frmActiveOrdersWithRemainingTimeList();
        clsUsers _user; // متغير خاص من نوع clsUsers يمثل المستخدم الحالي
        int _TimerConter = 0; // عداد للتايمر حتى يراقب المدة بعد غلق الشاشة
        int _CounterLogin = 0; // عداد محاولات تسجيل الدخول
        private bool _isLoading = false;
        private bool _isLoadingSettings = false;

        public frmLoginUser() // الكونستركتر للفورم
        {
            InitializeComponent(); // تهيئة مكونات الفورم (الأزرار, التكست, إلخ)
        }

        private void _AddNewLoginLogToDB(clsLoginLogs log)
        {
            // 1. فحص أولي: إذا المستخدم الحالي فارغ، لا تحاول الوصول لخصائصه
            if (clsGlobal.CurrentUser == null)
            {
                // إذا لسبب ما الكرنت يوزر نال، نستخدم الـ _user اللي عرفناه فوك بالفورم
                if (_user != null)
                    clsGlobal.CurrentUser = _user;
                else
                    return; // إذا الاثنين نال، نطلع حتى لا يضرب البرنامج
            }

            log = new clsLoginLogs();

            // نستخدم الأسامي الجديدة اللي عرفناها بداخل البزنس (الاحترافية)
            log.username = clsGlobal.CurrentUser.UserName;
            log.usersId = clsGlobal.CurrentUser.UserID;
            log.loginDate = DateTime.Now;

            // --- [التحديث الاحترافي لمحتوى اللوك] ---

            // بدل رقم الصلاحية القديم، نسجل نوع العملية
            log.ActionType = "Login";

            // بدل رقم الـ 77، نسجل حالة العملية
            log.Status = "Success";

            // جلب الـ IP الحقيقي للجهاز (أهم إضافة للمراقبة)
            log.IPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
                            .AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                            .ToString() ?? "127.0.0.1";

            // ملاحظة: الـ FailureReason نخليه فارغ لأننا بداخل دالة النجاح
            log.FailureReason = "Desktop Application Access";

            // ----------------------------------------

            if (!log.Save())
            {
                MessageBox.Show("لم يتم حفظ عملية تسجيل الدخول في سجلات المراقبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // رسالة ترحيب
        private void _Noitifcatoin_WelcomeUser()
        {
       
            notificatoinLoginUeser.Icon = SystemIcons.Hand; // يحدد الأيقونة
            notificatoinLoginUeser.BalloonTipIcon = ToolTipIcon.None; // أيقونة البالون تكون معلومات
         //   notificatoinLoginUeser.BalloonTipTitle = " تـرحـيـبا بك "; // العنوان
            notificatoinLoginUeser.BalloonTipText = "نــورت الــمــطــبــعــه بـحـضـورك " + "\"" + clsGlobal.CurrentUser.UserName + "\""; // النص مع اسم المستخدم
            notificatoinLoginUeser.ShowBalloonTip(5000); // عرض الرسالة لمدة 5 ثواني
        }

        // فحص الاغلاق بعد 3 محاولات
        private void _CheckLockScreen()
        {
            _CounterLogin++; // زيادة عداد المحاولات

            if (_CounterLogin >= 3) // إذا وصل للثالثة
            {
                // تسجيل حدث تحذيري في سجل الأحداث  بسبب تجاوز محاولات الدخول على النظام  نجدها في سجل الأحداث في الويندوز
                clsEventLog.WriteEvent("ETEZAn24","   تــــم غــلـق الــشــاشـــة البرنامج بسب  ادخال خطاءمن قبل المستخدم في عمليه تسجيل الدخول وادخال اسم المستخدم او رمز الدخول خطاء اكثر من مره", clsEventLog.enLogName.Application, EventLogEntryType.Warning); // إنشاء مصدر جديد في سجل الأحداث
                _After3TryUserLoginErrors(); // استدعاء دالة قفل الشاشة
                MessageBox.Show("تــــــــــــــــم غــــــــــلــــــــــق الــــــشــــــاشـــــــــة", "تــحـــذيــــــر", MessageBoxButtons.OK, MessageBoxIcon.Stop); // رسالة تحذير
                _Timer(); // تفعيل التايمر
            }
            else
            {
                _ProgressBarLogin(false); // تحديث شريط التقدم
                lbprogressBarLogin.Text = $" [ {_CounterLogin} ] انتبه سيتم غلق الشاشة بعد المحاولة الثالثة"; // إظهار عدد المحاولات
                MessageBox.Show("اســـــم الــمـســتـخـــدم او كــلـــمـــة الــمـــرور غــيــر صــــحـــيــحــة", "تــحـــذيــــــر", MessageBoxButtons.OK, MessageBoxIcon.Warning); // رسالة خطأ
            }
        }

        // التشييك على الدخول
        private bool _CheckLogin()
        {
            bool IsLogin = false;

            // 1. نبحث عن المستخدم بالاسم فقط أولاً (لأن BCrypt يحتاج الهاش المخزن للمقارنة)
            _user = clsUsers.FindUserByUserName(TboxUserName.Text.Trim());

            // 2. التحقق من كلمة المرور (هنا ضفنا مال التشفير اللي سويته)
            // نستخدم VerifyPassword اللي تقارن النص الصافي ويه الهاش المخزن
            if (_user != null && clsPasswordHasher.VerifyPassword(maskedTboxPasswerd.Text.Trim(), _user.Password))
            {
                if (!_user.isActive)
                {
                    IsLogin = false;
                    MessageBox.Show(" هذا المستخدم غير نشط اوفعال لا يسمح له بدخول النظام ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clsGlobal.CurrentUser = _user;
                    _ProgressBarLogin(true);
                    IsLogin = true;

                    if (chRemberMe.Checked)
                    {
                        clsGlobal.RememberUsernameAndPassword(TboxUserName.Text.Trim(), maskedTboxPasswerd.Text.Trim());
                    }
                    else
                    {
                        clsGlobal.RememberUsernameAndPassword("", "");
                    }
                }
                return IsLogin;
            }
            else
            {
                // إذا كان المستخدم نال أو الرمز غلط
                _CheckLockScreen();
                return false;
            }
        }
        // محاولة تسجيل الدخول
        private bool _IsLoginUser()
        {
            if (_CheckLogin()) // إذا تحقق الدخول
            {

                _Noitifcatoin_WelcomeUser(); // نعرض رسالة ترحيب
                                             // ✅ استدعاء Delegate من فورم ثاني (frmLoginLogs)
                frmLoginLogs.clsLoggger AddlogToDB = new frmLoginLogs.clsLoggger(_AddNewLoginLogToDB);
                clsLoginLogs newLog = new clsLoginLogs();
                AddlogToDB.Log(newLog); // تنفيذ الدالة
                frmMainMenu main = new frmMainMenu();
                main.Show();
             //   this.Hide();   // نخفي فورم الدخول


                int activeCount;
                string nearestBooking;
                //نتحقق اذا اكو طلبات غير مكتمله  يعني اذا اكو حجوزات اتضهر الشاشه طلبات وذاماكو حجوزات لا تضهرها
                clsGlobal.GetActiveOrdersWithRemainingTime(out activeCount, out nearestBooking);
                if (activeCount > 0)
                {
                    _frmActiveOrdersWithRemainingTimes.ShowDialog();
                }


                _ResetUserLoginErrors(); // نرجع العدادات صفر
             
                return true;
            }
            else
            {
                return false;
            }
        }

        // تفعيل المود (داكن/فاتح)
        private void _ScreenMode()
        {
            if (comboBoxMode.SelectedIndex == 0) // إذا اختار الأول (داكن)
            {
                this.BackColor = Color.Black;
                TboxUserName.BackColor = Color.Black;
                maskedTboxPasswerd.BackColor = Color.Black;
            }
            else // إذا اختار الثاني (رمادي)
            {
                this.BackColor = Color.DimGray;
                TboxUserName.BackColor = Color.DimGray;
                maskedTboxPasswerd.BackColor = Color.DimGray;
            }
       
         
        
        }

        // مؤقت بعد القفل
        private void _Timer()
        {
            timer1.Enabled = true; // نشغل التايمر
            _TimerConter++; // نزيد العداد
            lbTimerConter.Text = _TimerConter.ToString(); // نعرضه

            if (_TimerConter >= 10) // إذا وصل 10
            {
                _ResetUserLoginErrors(); // إعادة ضبط
                return;
            }
        }

        // البار مالت تسجيل الدخول
        private void _ProgressBarLogin(bool IsLoginUserSucess)
        {
            progressBarLogin.Visible = true;
            lbPrecentLogin.Visible = true;

            if (IsLoginUserSucess) // إذا نجح
            {
                progressBarLogin.Value = 100;
                lbPrecentLogin.Text = "%" + progressBarLogin.Value.ToString();
                progressBarLogin.Refresh();
                return;
            }
            else // إذا فشل
            {
                if (progressBarLogin.Value < progressBarLogin.Maximum)
                {
                    progressBarLogin.Value += 33; // كل محاولة تزيد 33%
                    lbPrecentLogin.Text = "%" + progressBarLogin.Value.ToString();
                    progressBarLogin.Refresh();
                }
            }
        }

        // بعد 3 محاولات
        private void _After3TryUserLoginErrors()
        {
            TboxUserName.Enabled = false;
            maskedTboxPasswerd.Enabled = false;
            PboxEyePasswerd.Enabled = false;
            comboBoxMode.Enabled = false;
            PboxIconYoutbe.Enabled = false;
            btnIconYoutbe.Enabled = false;
            progressBarLogin.Visible = false;
            PboxRightMarkUserName.Visible = false;
            lbprogressBarLogin.Text = "";
            lbPrecentLogin.Text = "";
            chRemberMe.Visible = false;
        }

        // اعادة الضبط
        private void _ResetUserLoginErrors()
        {
            _CounterLogin = 0;
            _TimerConter = 0;
            timer1.Enabled = false;
            lbTimerConter.Text = "";
            TboxUserName.Clear();
            maskedTboxPasswerd.Clear();
            TboxUserName.Enabled = true;
            maskedTboxPasswerd.Enabled = true;
            PboxEyePasswerd.Enabled = true;
            comboBoxMode.Enabled = true;
            PboxIconYoutbe.Enabled = true;
            btnIconYoutbe.Enabled = true;
            progressBarLogin.Visible = false;
            lbPrecentLogin.Visible = false;
            lbPrecentLogin.Text = "%0";
            lbprogressBarLogin.Text = "";
            progressBarLogin.Value = 0;
            progressBarLogin.Refresh();
            PboxRightMarkUserName.Visible = false;
            PboxEyePasswerd.Visible = true;
            lbprogressBarLogin.BackColor = Color.Transparent;
            chRemberMe.Visible = true;
        }

        // إظهار/إخفاء الباسورد
        private void PboxEyePasswerd_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTboxPasswerd.UseSystemPasswordChar = false; // إظهار الباسورد
        }

        private void PboxEyePasswerd_MouseUp(object sender, MouseEventArgs e)
        {
            maskedTboxPasswerd.UseSystemPasswordChar = true; // إرجاع إخفاء الباسورد
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // فحص الحقول
            {
                MessageBox.Show("بعض الحقول غير صحيحة!, ضع الماوس فوق الأيقونة الحمرة لترئ الخطأ", "خطاء ادخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _IsLoginUser(); // نحاول تسجيل الدخول
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            _isLoadingSettings = true; // 🔒 هسّه نحدد انه البرنامج دا يحمل الاعدادات حتى لا يصير تغيير بالغلط

            string userName = ""; // 🙋‍♂️ نخزن اسم المستخدم هنا
            string password = ""; // 🔑 نخزن كلمة السر هنا
            if (clsGlobal.GetUsernameAndPassword(ref userName, ref password)) // 🗄️ نتحقق إذا كان عندنا بيانات مخزنة
            {
                TboxUserName.Text = userName; // ✏️ نحط اسم المستخدم بالمربع المخصص
                maskedTboxPasswerd.Text = password; // 🔐 نحط كلمة السر بالمربع المخبّى
                chRemberMe.Checked = true; // ✅ نخلي علامة تذكّرني مفعلة
            }
            else
            {
                chRemberMe.Checked = false; // ❌ إذا ماكو بيانات مخزنة، نخلي تذكّرني مفصول
            }

            string filePath = Path.Combine(Application.StartupPath, "Appsettings.json"); // 📄 مسار ملف الاعدادات

            if (File.Exists(filePath)) // 🔎 نتحقق إذا الملف موجود
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(clsAppSettings)); // 📦 نجهز السيرياليزر للقراءة
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)) // 🛠️ نفتح الملف للقراءة
                {
                    clsAppSettings settings = (clsAppSettings)serializer.ReadObject(stream); // 🏗️ نقرا الاعدادات من الملف
                    comboBoxMode.SelectedIndex = settings.ModeIndex; // 🔄 نضبط اختيار الوضع في الكومبو بوكس
                }
            }
            else
            {
                comboBoxMode.SelectedIndex = 0; // 🔘 إذا الملف مو موجود، نخلي الوضع الافتراضي
            }

            _ScreenMode(); // 🖥️ نحدث شكل الشاشة حسب الاعدادات

            _isLoadingSettings = false; // 🔓 انتهى التحميل ونقدر نسمح للتغييرات
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingSettings) return; // 🚫 اذا البرنامج دا يحمل الاعدادات، نتجاهل التغيير

            string filePath = Path.Combine(Application.StartupPath, "Appsettings.json"); // 📄 نفس مسار الملف

            clsAppSettings settings = new clsAppSettings { ModeIndex = comboBoxMode.SelectedIndex }; // 🏗️ نسوي نسخة جديدة من الاعدادات مع الوضع الجديد

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(clsAppSettings)); // 📦 نحضر السيرياليزر

            using (MemoryStream ms = new MemoryStream()) // 📝 نكتب البيانات بالذاكرة اولاً
            {
                serializer.WriteObject(ms, settings); // 🏗️ نحول الاعدادات الى JSON
                string json = Encoding.UTF8.GetString(ms.ToArray()); // 💻 نحول البايتات لنص
                File.WriteAllText(filePath, json); // ✍️ نحفظ التغييرات بالملف
            }

            _ScreenMode(); // 🖥️ نحدث شكل الشاشة حسب الوضع الجديد
        }


        private void PboxIconYoutbe_Click(object sender, EventArgs e)
        {
            PboxIconYoutbe.BackColor = Color.Silver;
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC-euZ1e6bI6mPqq8ngua9ZA"); // فتح قناة يوتيوب
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Timer(); // استدعاء المؤقت
        }

        private void btnIconYoutbe_Click(object sender, EventArgs e)
        {
            PboxIconYoutbe_Click(sender, e); // نفس حدث الضغط على صورة يوتيوب
        }

        public void TboxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TboxUserName.Text)) // إذا الاسم فارغ
            {
                e.Cancel = true;
                errorProvider1.SetError(TboxUserName, "رجــــاء ادخـــل اســــم الــمــســتــخـــدم");
            }
            else
            {
                PboxRightMarkUserName.Visible = true;
                errorProvider1.SetError(TboxUserName, "");
            }
        }

        private void maskedTboxPasswerd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTboxPasswerd.Text)) // إذا الباسورد فارغ
            {
                e.Cancel = true;
                errorProvider1.SetError(maskedTboxPasswerd, "رجــــاء ادخـــل رمز الــمــســتــخـــدم");
            }
            else
            {
                errorProvider1.SetError(maskedTboxPasswerd, "");
            }
        }

        public void SetLoginTextBoxes(string username, string password)
        {
          
            TboxUserName.Text = username;
            maskedTboxPasswerd.Text = password;
          
            this.Hide();
        }
    

   

    }
}
