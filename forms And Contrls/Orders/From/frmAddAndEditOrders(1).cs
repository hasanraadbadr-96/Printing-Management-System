using BusinessLayeres; // نستدعي الطبقة المسؤولة عن المنطق التجاري (Business Logic Layer)
using ETEZAN2024.forms_And_Contrls.GlobalClasses;
using ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution;
using ETEZAN2024.forms_And_Contrls.Persons.Control;
using ETEZAN2024.forms_And_Contrls.Products;
using ETEZAN2024.FormsAndControls.GlobalClasses;
using System; // مكتبة الأساسيات مثل DateTime, Convert وغيرها
using System.ComponentModel; // مكتبة خاصة بمكونات الفورم (للتحقق والتحكم بالاحداث)
using System.Data; // مكتبة للتعامل ويا الجداول (DataTable, DataSet ...)
using System.Windows.Forms; // مكتبة عناصر Windows Forms

namespace ETEZAN2024.forms_And_Contrls.Orders // مساحة الاسم الخاصة بفورم الطلبات
{
    public partial class frmAddAndEditOrders : Form // تعريف كلاس الفورم الرئيسي للطلبات
    {
        public enum enMode // تعريف enum يحتوي وضعين: اضافة وتحديث
        {
            Add = 1, // وضع اضافة
            Update = 2 // وضع تعديل
        }

        enMode _mode; // متغير نخزن بيه المود الحالي (اضافة/تحديث)
        private int _OrderID; // نخزن رقم الطلب
        private decimal _TotalPrice = 0; // نخزن السعر الكلي
        int _deliveryPrice = 5000; // كلفة التوصيل الثابتة
        private clsOrders Order; // كائن يمثل الطلب الحالي
     //   private clsOrderItems _OrderItems; // كائن يمثل عناصر الطلب
        DataTable dtProdectsList; // جدول يحتوي على المنتجات
        private int _ProdectID=-1;
        private int _personID;  // متغير داخلي نخزن بيه القيمة
        clsInventoryTransactions _inventoryTransaction;
        public int PersonID // خاصية عامة تمثل رقم الشخص
        {
            get { return _personID; } // نرجع قيمة المتغير الخاص _personID
            set
            {
                _personID = value; // نخزن القيمة الجديدة داخل المتغير
                                   // كلما يتغير الـ PersonID راح نخزن الرقم الجديد
                                   // ممكن نستدعي تحميل بيانات الشخص هنا إذا نريد
                                   // ctrlPersonCardWithFilter1.LoadPersonInfo(_personID); // (هذي معلقة حالياً)
            }
        }
        clsProducts _ProductInfo;
        public ctrlPersonCardWithFilter PersonCardWithFilter // خاصية تربط الكترول مالتنا
        {
            // نخلي تبويب معلومات الطلب غير مفعل بالبداية
            get { return ctrlPersonCardWithFilter1; } // نرجع الكترول الداخلي
            set
            {
                ctrlPersonCardWithFilter1.FillterEnable = false; // نلغي التصفية (الفلترة)
                ctrlPersonCardWithFilter1.ctrlPersonCard.LoadPersonInfoByID(_personID); // نعرض بيانات الشخص حسب ID
            }
        }

        public clsOrders ordersInfo // خاصية ترجعلنا معلومات الطلب
        {
            get { return Order; } // ترجع الكائن Order
        }

        public int OrderID // خاصية ترجع رقم الطلب
        {
            get { return _OrderID; } // ترجع القيمة المخزونة
        }

        public frmAddAndEditOrders() // كونستركتر اولي (اضافة طلب)
        {
            InitializeComponent(); // تهيئة عناصر الفورم
            _mode = enMode.Add; // نحدد المود على انه "اضافة"
        }

        public frmAddAndEditOrders(int orderID) // كونستركتر ثاني (تعديل طلب موجود)
        {
            InitializeComponent(); // تهيئة الفورم
            _mode = enMode.Update; // نحدد المود "تحديث"
            _OrderID = orderID; // نخزن رقم الطلب
        }

    

        public static void SendOrderAmountToCashBoxDistribution(clsOrders orders)
        {
            frmAddAndEditOrderCashBoxsDistribution frmAddAndEdit = new frmAddAndEditOrderCashBoxsDistribution();
            frmAddAndEdit. SaveOrderBoxCashDistributionInfo(orders);



            
        }
        private void _ResetDefualtValues() // دالة تعيد القيم الافتراضية للفورم
        {
            if (_mode == enMode.Add)
            {
                clsGlobal.CurrentOrderItemInfo = new clsOrderItems(); // ننشئ كائن جديد لعناصر الطلب
                Order = new clsOrders(); // ننشئ كائن جديد للطلب
                clsGlobal.CurrentInventoryTransactionInfo = new clsInventoryTransactions();      
               
                lbAddAndEdit.Text = "اضافة طلب "; // نخلي العنوان "اضافة"
                return;
            }

            lbOrderID.Text = "####"; // نخلي رقم الطلب فارغ
            cmbProdectName.Text = ""; // نفرغ اسم المنتج
            tbOrderPrice.Text = ""; // نفرغ سعر الطلب
            rbNo.Checked = true; // نخلي الافتراضي بدون توصيل
            dtpOrderDate.Value = DateTime.Now; // نخلي التاريخ اليوم
            tbPaidAmount.Text = ""; // نفرغ العربون
            cmbOrderStatus.Text = ""; // نفرغ حالة الطلب
            tbNots.Text = ""; // نفرغ الملاحظات
            lbUserName.Text = clsGlobal.CurrentUser.UserName; // نعرض اسم المستخدم الحالي
            lbTotalPrice.Text = "####"; // نفرغ السعر الكلي
            lbRemainingAmount.Text = "####"; // نفرغ المبلغ المتبقي
            lbPaidAmount.Text = "####"; // نفرغ العربون
            tpOrderInfo.Enabled = false; // نخلي تبويب معلومات الطلب غير مفعل بالبداية
             dtpEstimateTime.Value = DateTime.Now;
            dtpFinishTime.CustomFormat = " "; // نخلي التنسيق فارغ
            dtpFinishTime.Format = DateTimePickerFormat.Custom; // نخلي الفورمات مخصص
            cmbInventoryTransactionType.Text = "";
            cmbTypeOrderInfo.Text = "";
            tbQuantity.Text = "";


        }

        private void _FillComboBoxByProdectName() // دالة تملي ComboBox بأسماء المنتجات
        {
            DataTable dtProducts = clsProducts.GetAllProductsList(); // نجيب كل المنتجات من قاعدة البيانات
            cmbProdectName.DataSource = dtProducts; // نخلي مصدر البيانات هو الجدول
            cmbProdectName.DisplayMember = "اسم المنتج"; // نخلي العرض باسم المنتج
            cmbProdectName.ValueMember = "معرف المنتج"; // نخلي القيمة الداخلية هي ProductID
        }

        private void _FillComboBoxByProdectPrice() // دالة تجيب سعر المنتج
        {
            if (cmbProdectName.SelectedItem == null || cmbProdectName.SelectedValue == null) // اذا ما مختار منتج
                return;

            if (Order == null) // اذا بعد ماكو كائن للطلب
                Order = new clsOrders();

 

           // tbOrderPrice.Text = Order.ProductPricesInfo.Price.ToString("N0"); // نعرض السعر بصيغة مرتبة
        }

        private void _FillComboBoxByOrderStatus() // دالة تعبي ComboBox بحالات الطلب
        {
         
                cmbOrderStatus.Items.Add("جديد");               
                cmbOrderStatus.Items.Add("قيد التنفيذ");
                cmbOrderStatus.Items.Add("مؤجل");
                cmbOrderStatus.Items.Add("مكتمل");
                cmbOrderStatus.Items.Add("ملغي");
         
    
        }

        private void _FillComboBoxByOrderTypeInfo() // دالة تعبي ComboBox بحالات الطلب
        {
            cmbTypeOrderInfo.Items.Add("عادي");
           cmbTypeOrderInfo.Items.Add("طباعة ورقية");
           cmbTypeOrderInfo.Items.Add("قرطاسية");
           cmbTypeOrderInfo.Items.Add("هدايا");
           cmbTypeOrderInfo.Items.Add("صور");
           cmbTypeOrderInfo.Items.Add("استيكر");
           cmbTypeOrderInfo.Items.Add("بورد");
           cmbTypeOrderInfo.Items.Add("برواز");
           cmbTypeOrderInfo.Items.Add("أكواب");
           cmbTypeOrderInfo.Items.Add("طباعة ملفات");
            cmbTypeOrderInfo.Items.Add("كارتات");


        }

        private void _FillTexetBoxesByOrderInfo() // دالة تعبي الفورم من معلومات الطلب
        {
            lbAddAndEdit.Text = "تعديل الطلب ";
            lbOrderID.Text = Order.orderID.ToString();
            cmbProdectName.Text = clsGlobal.CurrentOrderItemInfo.ProductInfo. productName;
            tbOrderPrice.Text = Order.orderPrice.ToString("N0");
            cmbInventoryTransactionType.Text = clsGlobal.CurrentOrderItemInfo.inventoryTransactionInfo.type;
            cmbTypeOrderInfo.Text = Order.OrderType;
            tbQuantity.Text =  clsGlobal.CurrentOrderItemInfo.quantity.ToString();
            if (Order.includesDelivery) // اذا يشمل توصيل
                rbYes.Checked = true;
            else
                rbNo.Checked = true;

            dtpOrderDate.Value = Order.orderDate;
            dtpEstimateTime.Value = Order.EstimateTime;
            if (Order.FinishTime.HasValue) // تحقق إذا كان هناك قيمة في FinishTime (لأنها Nullable)
            {
                dtpFinishTime.Value = Order.FinishTime.Value;
                // إذا كان هناك قيمة، نأخذ القيمة الفعلية (Value) ونعرضها في DateTimePicker

                dtpFinishTime.Format = DateTimePickerFormat.Short;
                // نحدد تنسيق التاريخ ليكون قصير (مثلاً: 10/11/2025)، ليظهر التاريخ للمستخدم
            }
            else
            {
                dtpFinishTime.Format = DateTimePickerFormat.Custom;
                // إذا لا يوجد قيمة، نغير تنسيق DateTimePicker ليكون مخصص

                dtpFinishTime.CustomFormat = " ";
                // نجعل النص المخصص فارغ ليظهر مربع التاريخ خالي بدون أي قيمة
            }

            tbPaidAmount.Text = Order.paidAmount.ToString("N0");
            cmbOrderStatus.SelectedIndex = Order.orderStatus;
            tbNots.Text = Order.Notes;
            lbUserName.Text = Order.UsersInfo.UserName;

            _TotalPrice = Order.orderPrice;
            lbTotalPrice.Text = _TotalPrice.ToString("N0");
            lbPaidAmount.Text = Order.paidAmount.ToString("N0");
            decimal RemainingAmount = _TotalPrice - Order.paidAmount;
            lbRemainingAmount.Text = RemainingAmount.ToString("N0");

            ctrlPersonCardWithFilter1.LoadPersonInfo(Order.personID); // نعرض بيانات الشخص
            tpOrderInfo.Enabled = true; // نفعل التبويب
            ctrlPersonCardWithFilter1.FillterEnable = false; // نمنع البحث

            _ShowOrderAmounts();//نضهر معلومات السعر علئ الشاشه



        }

        private void _ValidateAndSetOrderPrice() // دالة تتحقق وتضبط سعر الطلب
        {

            decimal ProductPrice =0;
            if (!decimal.TryParse(tbOrderPrice.Text, out ProductPrice)) // تحقق من السعر
            {
                MessageBox.Show("رجاءً ادخل سعر صحيح", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            decimal paidAmount;
            if (!decimal.TryParse(tbPaidAmount.Text, out paidAmount)) // تحقق من العربون
            {
                MessageBox.Show("رجاءً ادخل عربون صحيح", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            Order.paidAmount = paidAmount;

            if (rbYes.Checked && !Order.includesDelivery) // اذا مختار توصيل
            {
                Order.includesDelivery = true;
               // _TotalPrice = OrderPrice + _deliveryPrice; // نضيف اجور التوصيل
           
            }
            else
            {
                Order.includesDelivery = false;
              //  _TotalPrice = OrderPrice; // يبقى نفس السعر بدون توصيل
            }
            Order.orderPrice= ProductPrice;
        }

        private decimal _ShowOrderAmounts() // دالة تحسب وتعرض المبالغ
        {
            
            decimal OrderPrice = 0 , paidAmount = 0;


              decimal.TryParse(tbOrderPrice.Text, out OrderPrice);
            decimal.TryParse(tbPaidAmount.Text, out paidAmount);

            if (rbYes.Checked) // اذا ويا توصيل
                _TotalPrice = OrderPrice + _deliveryPrice;
            if (rbNo.Checked) // اذا بدون توصيل
                _TotalPrice = OrderPrice;

            decimal remaining = _TotalPrice - paidAmount; // الباقي
            lbTotalPrice.Text = _TotalPrice.ToString("N0");
            lbPaidAmount.Text = paidAmount.ToString("N0");
            lbRemainingAmount.Text = remaining.ToString("N0");

            return _TotalPrice;
        }

        private void _LoadDataByOrderID(int OrderID) // دالة تجيب الطلب حسب رقمه_OrderID
        {
            OrderID = _OrderID;
            Order = clsOrders.FindOrder(_OrderID);
            clsGlobal.CurrentOrderItemInfo = clsOrderItems.FindOrderItemsByOrderID(_OrderID);
            if (Order == null )
            {
                _ResetDefualtValues();
                MessageBox.Show("لم يتم العثور علئ هذا الطلب", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (clsGlobal.CurrentOrderItemInfo == null)
            {
                _ResetDefualtValues();
                MessageBox.Show("لم يتم العثور علئ  عناصر هذا  الطلب", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            _FillTexetBoxesByOrderInfo();
        }

        private void _LoadDataPersonID() // دالة تجيب الطلب حسب الشخص
        {
            Order = clsOrders.FindOrderByPersonID(ctrlPersonCardWithFilter1.PersonID);
            if (Order == null)
            {
                _ResetDefualtValues();
                Order = new clsOrders();
                MessageBox.Show("هذا الشخص ليس لديه طلب مسبقا", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("هذا الشخص لديه طلب مسبقا", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrlPersonCardWithFilter1.FillterEnable = false;
            _FillTexetBoxesByOrderInfo();
        }

        private void frmOrders_Load(object sender, EventArgs e) // حدث تحميل الفورم
        {
            _ResetDefualtValues();
            _FillComboBoxByProdectName();
            _FillComboBoxByOrderStatus();
            _FillComboBoxByOrderTypeInfo();
            clsGlobal.FillComboBoxTypeInventoryTransactionInfo(cmbInventoryTransactionType);
            // _FillComboBoxByProdectPrice();
            // خليته شرط وما يخلي اي منتج محدد بالبداية علمودد  مايصر خطاء اذا محذوف المنتج المختار
            if (cmbProdectName.Items.Count > 0)
            {
                cmbProdectName.SelectedIndex = 0;
            }
            // خليته شرط وما يخلي اي حالة محددة بالبداية علمودد  مايصر خطاء اذا محذوف حالة الطلب المختارة
            if (cmbOrderStatus.Items.Count > 0)
            {
                cmbOrderStatus.SelectedIndex = 0;
            }
            // خليته شرط وما يخلي اي نوع حركة محددة بالبداية علمودد  مايصر خطاء اذا محذوف نوع الحركة المختار
            if (cmbInventoryTransactionType.Items.Count > 0)
            {
                cmbInventoryTransactionType.SelectedIndex = 2; // نحدد نوع الحركة الافتراضي
            }
            // خليته شرط وما يخلي اي نوع حركة محددة بالبداية علمودد  مايصر خطاء اذا محذوف نوع الحركة المختار
            if (cmbTypeOrderInfo.Items.Count > 0)
            {
                cmbTypeOrderInfo.SelectedIndex = 1; // نحدد نوع الحركة الافتراضي
            }
            rbNo.Checked = true; // نخلي الافتراضي بدون توصيل

            if (_mode == enMode.Update)
                _LoadDataByOrderID(_OrderID);
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e) // اذا اختار توصيل
        {
            _ShowOrderAmounts();
        }

        private void btNext_Click(object sender, EventArgs e) // زر التالي
        {
            if (_mode == enMode.Add)
            {
                if (ctrlPersonCardWithFilter1.selectPersonInfo == null) // اذا ما مختار شخص
                {
                    tpOrderInfo.Enabled = false;
                    MessageBox.Show("من فضلك ابحث عن شخص أو اضفه أولاً", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Order = new clsOrders();
                    tpOrderInfo.Enabled = true;
                    tpPersonInfo1.SelectTab(tpOrderInfo);
                }
            }
            else
            {
                tpOrderInfo.Enabled = true;
                tpPersonInfo1.SelectTab(tpOrderInfo);
            }
        }

        private void btaCansel2_Click(object sender, EventArgs e) // زر الالغاء
        {
            this.Close(); // نغلق الفورم
        }


        private void rbNo_CheckedChanged(object sender, EventArgs e) // اذا بدون توصيل
        {
            _ShowOrderAmounts();
        }

        private void tbOrderPrice_TextChanged(object sender, EventArgs e) // تغيير السعر
        {
            _ShowOrderAmounts();
        }

        private void tbPaidAmount_TextChanged(object sender, EventArgs e) // تغيير العربون
        {
            _ShowOrderAmounts();
        }

        private void tbPaidAmount_Validating(object sender, CancelEventArgs e) // تحقق من العربون
        {
            if (string.IsNullOrEmpty(tbPaidAmount.Text))
            {
                e.Cancel = true;
                errorProviderOrders.SetError(tbPaidAmount, "من فضلك ادخل العربون");
            }
            else
                errorProviderOrders.SetError(tbPaidAmount, "");

            decimal orderPrice = 0, paidAmount = 0;
            decimal.TryParse(tbOrderPrice.Text, out orderPrice);
            decimal.TryParse(tbPaidAmount.Text, out paidAmount);

            if (paidAmount > orderPrice && rbNo.Checked)
            {
                e.Cancel = true;
                errorProviderOrders.SetError(tbPaidAmount, "   مبلغ العربون اكبر من سعر الطلبية");
            }
            else
                errorProviderOrders.SetError(tbPaidAmount, "");

            if (rbYes.Checked)
            {
                _TotalPrice = orderPrice + _deliveryPrice;
                if (paidAmount > _TotalPrice)
                {
                    e.Cancel = true;
                    errorProviderOrders.SetError(tbPaidAmount, "   مبلغ العربون اكبر من سعر الطلبية");
                }
                else
                    errorProviderOrders.SetError(tbPaidAmount, "");
            }
        }

        private void tbOrderPrice_Validating(object sender, CancelEventArgs e) // تحقق من السعر
        {
            if (string.IsNullOrEmpty(tbOrderPrice.Text))
            {
                e.Cancel = true;
                errorProviderOrders.SetError(tbOrderPrice, "من فضلك ادخل السعر");
            }
            else
                errorProviderOrders.SetError(tbOrderPrice, "");
        }

        private void tbProductName_TextChanged(object sender, EventArgs e) { } // تغير النص (فارغ)

        private void tbOrderPrice_KeyPress(object sender, KeyPressEventArgs e) // منع كتابة غير ارقام
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbPaidAmount_KeyPress(object sender, KeyPressEventArgs e) // منع كتابة غير ارقام
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmbProdectName_SelectedIndexChanged(object sender, EventArgs e) // اذا المستخدم غيّر اسم المنتج بالقائمة
        {



            // نجيب رقم المنتج من الكمبوبوكس
            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue);

            // نجيب معلومات المنتج
             _ProductInfo = clsProducts.FindProduct(ProductID);



            // إذا SelectedValue فارغ — يصير خطأ
            if (cmbProdectName.SelectedValue == null)
            {
                errorProviderOrders.SetError(cmbProdectName, "الرجاء اختيار منتج صحيح");
                return;
            }


            // نتحقق إذا الكمية أكبر من المخزون
            if (_ProductInfo.Quantity == 0)
            {

                MessageBox.Show(
                    $"نفذ هذا المنتج من المخزن\n" +
                    $"عدد القطع المتوفرة : [ {_ProductInfo.Quantity} ]",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                errorProviderOrders.SetError(cmbProdectName,
                     $"نفذ هذا المنتج [{_ProductInfo.productName}]  من المخزن\n" +
                    $"عدد القطع المتوفرة : [ {_ProductInfo.Quantity} ]");
            }
            else
            {
                errorProviderOrders.SetError(cmbProdectName, "");
            }






        }

        private void tpOrderInfo_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddAndEditOrders_Activated(object sender, EventArgs e)
        {
            // هذا الحدث يشتغل كل مرة النموذج (الفورم) يصير هو النشط، يعني المستخدم رجع عليه بعد ما كان فاتح شي ثاني.
            // الغرض من هذا الكود إنه يحدد مكان الكتابة تلقائياً داخل مربع البحث الموجود داخل الكنترول "ctrlPersonCardWithFilter1".
            // يعني أول ما الفورم يصير فعال، المؤشر (Cursor) يروح على TextBox الخاص بالبحث عن الشخص حتى المستخدم يقدر يكتب مباشرة بدون ما ينقر الماوس.

            ctrlPersonCardWithFilter1.FoucsTextBoxFilterPersonValue(); // نستدعي دالة داخل الكنترول تخلي التركيز على TextBox الخاص بالبحث.
        }

        // 🔥 1.دالة تنشئ حركة مخزون جديدة وتحفظها
        private void _CreateAndSaveInventoryTransaction()
        {
            // 🔥 2.نسوي حركة جديدة من الصفر
            clsGlobal.CurrentInventoryTransactionInfo = new clsInventoryTransactions();
            // هذا السطر ينشئ كائن جديد للحركة حتى نبدي نعبّي بياناته

            clsGlobal.CurrentInventoryTransactionInfo.product_id = clsGlobal.CurrentOrderItemInfo.productID;
            // نربط حركة المخزون بالمنتج اللي داخل الطلب

            clsGlobal.CurrentInventoryTransactionInfo.type = cmbInventoryTransactionType.Text;
            // نحدد نوع الحركة من الكمبوبوكس مثل دخول/خروج مخزون

            clsGlobal.CurrentInventoryTransactionInfo.quantity = int.Parse(tbQuantity.Text);
            // نقرأ الكمية اللي استخدمها المستخدم ونحوّلها رقم

            clsGlobal.CurrentInventoryTransactionInfo.date = DateTime.Now;
            // نخزن تاريخ ووقت الحركة الحالي

            clsGlobal.CurrentInventoryTransactionInfo.Order_ItemID = clsGlobal.CurrentOrderItemInfo.itemID;
            // نربط حركة المخزون بصف الطلب (Order Item) حتى نعرف هاي الحركة لأي طلب بالضبط

            // 🔥 3. نحفظ الحركة الجديدة
            if (!clsGlobal.CurrentInventoryTransactionInfo.Save())
            // نحاول نحفظ الحركة، إذا رجع false يعني ما نجحت عملية الحفظ
            {
                MessageBox.Show("لم يتم حفظ حركة المخزون الجديدة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // نعرض رسالة خطأ لأن الحفظ فشل
                return;
                // نطلع من الدالة لأن ما يصير نكمل إذا الحفظ ما صار
            }
            // إذا وصلنا هنا يعني الحركة انحفظت بنجاح
        }

        private void _CreateAndSaveOrderItem()
        {
            clsGlobal.CurrentOrderItemInfo.orderID = Order.orderID;
            // نربط تفاصيل العنصر برقم الطلب اللي انحفظ قبل شوي

            clsGlobal.CurrentOrderItemInfo.productID = Convert.ToInt32(cmbProdectName.SelectedValue);
            // نخزن رقم المنتج المختار من الكمبوبوكس حتى نعرف أي منتج تابع لهاي التفاصيل

            clsGlobal.CurrentOrderItemInfo.quantity = int.Parse(tbQuantity.Text);
            // نخزن كمية المنتج اللي اختارها المستخدم من التكست بوكس

            clsGlobal.CurrentOrderItemInfo.pricePerUnit = 1000;
            // هنا نخزن سعر الوحدة (سعر القطعة الوحدة للمنتج)

            clsGlobal.CurrentOrderItemInfo.totalPrice = 500;
            // هنا نحسب ونخزن السعر الكلي = سعر القطعة × الكمية (هسه انت حاطه ثابت)

            if (!clsGlobal.CurrentOrderItemInfo.Save())
            // إذا عملية الحفظ رجعت false يعني فشلت
            {
                MessageBox.Show("لم يتم حفظ عناصر  تفاضيل الطلب.", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // نعرض رسالة خطأ للمستخدم لأن تفاصيل الطلب ما انحفظت
            }
            // إذا ما دخل على الـ if يعني الحفظ نجح بدون مشاكل
        }

        private void btnSaveOrderInfo_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // تحقق من الحقول
            {
                MessageBox.Show("بعض الحقول غير صحيحة!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🟦 حماية من Null قبل كل شيء
            if (Order == null)
            {
                MessageBox.Show("خطأ: كائن الطلب غير مهيأ!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.CurrentOrderItemInfo == null)
            {
                MessageBox.Show("خطأ: كائن  عناصر الطلب غير مهيأ!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.CurrentUser == null)
            {
                MessageBox.Show("خطأ: المستخدم الحالي غير معروف!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctrlPersonCardWithFilter1 == null)
            {
                MessageBox.Show("الرجاء اختيار الزبون!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProdectName.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المنتج!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("الرجاء إدخال الكمية!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // نحول القيمة إلى رقم بدون ما يرمي خطأ
            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue);// نحول القيمة المختارة في الكمبوبوكس إلى رقم صحيح (ID المنتج)
         // 1️⃣ نجيب الكمية القديمة قبل الحذف
            int previousQty =-1; 
            int _CurrentQuantityUsed = int.Parse(tbQuantity.Text);// لتخزين الكمية الحالية المستخدمة

            //_previousQuantityUsed = _CurrentQuantityUsed;// نخزن الكمية الحالية ككمية سابقة للتعديل القادم


            _ValidateAndSetOrderPrice(); // نتأكد من السعر

            Order.orderDate = dtpOrderDate.Value; // نخزن التاريخ
            Order.EstimateTime = dtpEstimateTime.Value;//نخزن تاريخ وقت متوقع اكمال طلب

            Order.orderStatus = (byte)cmbOrderStatus.SelectedIndex; // نخزن حالة الطلب
            Order.Notes = tbNots.Text; // نخزن الملاحظات
            Order.userID = clsGlobal.CurrentUser.UserID; // نخزن رقم المستخدم
            Order.personID = ctrlPersonCardWithFilter1.PersonID; // نخزن رقم الشخص
            Order.OrderType = cmbTypeOrderInfo.Text;

            if (cmbOrderStatus.Text == "مكتمل")
            {
                Order.FinishTime = dtpFinishTime.Value;
            }//هنا اكله اذا اكتمل طلب خزن تاريخ اليوم  من كتمل الطلب
            else
            {
                Order.FinishTime = null;
            } //خلي تاريخ  اكمال الطلب فارغ اذا ما كتمل الطلب

            TimeSpan RemainingBookingTime;
            string remainingText;
            // إذا الحالة مو مكتمل ومو ملغي نحسب الوقت المتبقي
            if (cmbOrderStatus.Text != "مكتمل" && cmbOrderStatus.Text != "ملغي")
            {

                // نحسب الفرق بين وقت الإكمال المتوقع ووقت الطلب
                RemainingBookingTime = dtpEstimateTime.Value - DateTime.Now;
                remainingText = $"{RemainingBookingTime.Days} يوم / {RemainingBookingTime.Hours} ساعه / {RemainingBookingTime.Minutes} دقيقة";



            }
            else
            {
                // إذا الطلب مكتمل أو ملغي، نخزن صفر لأن ماكو وقت متبقي
                RemainingBookingTime = TimeSpan.Zero;
                remainingText = $"{RemainingBookingTime.Days} يوم / {RemainingBookingTime.Hours} ساعه / {RemainingBookingTime.Minutes} دقيقة";

            }

            if (Order.Save()) // نحفظ
            {

                lbOrderID.Text = Order.orderID.ToString();
                lbAddAndEdit.Text = "تعديل الطلب ";
                MessageBox.Show($" تم الحفظ والمدة المتبقية لاأكمال الطلب:  {remainingText} ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // ارسال مبلغ الطلب الى توزيع صندوق الكاش بوكس عند اكتمال الطلب
                if (cmbOrderStatus.Text == "مكتمل")
                {
                    SendOrderAmountToCashBoxDistribution(Order);

                }

                // انشاء اشعار جرد حركة المخزون وارسال رسالة واتساب
                clsInventoryTransactionsNotifier.InventoryTransactions InventoryTransaction = new clsInventoryTransactionsNotifier.InventoryTransactions(Order.orderID);
                // 
                clsInventoryTransactionsNotifier.WhatsappServiec whatsapp1 = new clsInventoryTransactionsNotifier.WhatsappServiec();
              //  clsInventoryTransactionsNotifier.SaveToDataBase saveToData = new clsInventoryTransactionsNotifier.SaveToDataBase();


                // تقدر تطبع النتيجة بهذا الشكل (اختياري)
                // نتحقق اول شي من المود علمود ما يرسل هاي الرسالة كل ما نعدل الطلب، تتكرر بس بالاضافة اول مرة و نرسل تفاصيل الطلب للزبون على الواتساب
                if (_mode == enMode.Add)
                {
                    // 🔥 1.ننشئ عنصر طلب جديد ونحفظه
                    _CreateAndSaveOrderItem();

                    // 🔹 نخلق حدث جديد للطلب حتى نربطه بالواتساب
                    clsOrderNotifier.Order orderEventSource = new clsOrderNotifier.Order(Order.orderID);
                    // 🔹 نجهز رسالة الواتساب اللي راح توصل للزبون
                    clsOrderNotifier.WhatsappServiec whatsapp = new clsOrderNotifier.WhatsappServiec("شكراً لتعاملكم ويانه '... مطبعة اتزان راح توافيكم بتفاصيل الطلب خطوة بخطوة '");
                   
                    
                    // 🔹 نربط خدمة الواتساب بالطلب حتى يرسل الرسالة تلقائياً
                    whatsapp.Subscribe(orderEventSource);
                    //هنا خلينه حالة الطلب جديد
                    byte orderStatus = 0;
                   
                    
                    // 🔹 نستدعي الدالة CreateOrder ونمرر كل تفاصيل الطلب الحالي
                    // 🟩 تنفيذ العملية
                
                     orderEventSource.CreateOrder(orderStatus);


                    // 🔹 نربط خدمة الواتساب بالطلب حتى يرسل الرسالة تلقائياً مال معلومات جرد حركة المخزون
                    // whatsapp1.Subscribe(InventoryTransaction);
                    //نحفض معلومات جرد حركة المخزون بالدات بيس  



                }

                //لتعديل حركه مخزون حذف حركه القديمه وتسجيل حركه جديده عند تعديل الطلب
                if (_mode == enMode.Update)
                {
                    previousQty = clsGlobal.CurrentOrderItemInfo.quantity;// 1️⃣ نجيب الكمية القديمة قبل الحذف
                    // 🔥 1.نحذف الحركة القديمة بالكامل حسب رقم الطلب
                    clsInventoryTransactions.DeleteByOrderItemID(Order.orderID);
                    // 🔥 2.ننشئ عنصر طلب جديد ونحفظه
                    _CreateAndSaveOrderItem();

                    // 🔹 نربط خدمة الواتساب بالطلب حتى يرسل الرسالة تلقائياً مال معلومات جرد حركة المخزون
                   // whatsapp1.Subscribe(InventoryTransaction);


                    //  // 🔥 1.نحذف عنصر الطلب القديمة بالكامل حسب رقم الطلب عمود نعدل ع طلب نضيف طلب جديد مكانه
                    clsOrderItems.DeleteOrderItemByOrderID(clsGlobal.CurrentOrderItemInfo.itemID);




                    //ننشئ حدث لا انشاء جرد حرك المخزن
                   // InventoryTransaction.CreateInventoryTransaction();

                }

            

        

                if (_mode == enMode.Update)
                {
             

                    // 🔥 1.نحذف الحركة القديمة بالكامل حسب رقم الطلب
                 //   clsOrderItems.DeleteOrderItemByOrderID(clsGlobal.CurrentOrderItemInfo.itemID);

                    // 3️⃣ ننشئ عنصر طلب جديد
                    _CreateAndSaveOrderItem();

                    // 4️⃣ نحسب الفرق فقط
                    int difference = _CurrentQuantityUsed - previousQty;

                    // 5️⃣ إذا فرق = صفر → لا تسوي أي خصم
                    if (difference != 0)
                    {
                        clsInventoryTransactions.UpdateInventoryAndProdcutQuantityAfterOrder(difference, ProductID);
                    }

                }
                else
                {
                    // عملية إضافة
                    clsInventoryTransactions.UpdateInventoryAndProdcutQuantityAfterOrder(_CurrentQuantityUsed, ProductID);
                }


                  // 🔥 1.دالة تنشئ حركة مخزون جديدة وتحفظها
                _CreateAndSaveInventoryTransaction();

                _mode = enMode.Update;

            }
            else
            {
                MessageBox.Show("لم يتم الحفظ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderStatus.Text == "مكتمل")
            {
                dtpFinishTime.Checked = true;
                dtpFinishTime.Enabled = true;
                dtpFinishTime.Format = DateTimePickerFormat.Custom; // اعرض التاريخ الحالي
                dtpFinishTime.CustomFormat = "dd/MM/yyyy hh:mm tt"; // تنسيق التاريخ
            }
            else
            {
                dtpFinishTime.Checked = false;
                dtpFinishTime.Enabled = false;
                dtpFinishTime.Format = DateTimePickerFormat.Custom; // تنسيق مخصص
                dtpFinishTime.CustomFormat = " "; // عرض فارغ
            }
        }

        private void lbAddAndEdit_Click(object sender, EventArgs e)
        {

        }

        private void lnkEditProdectName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // تحقق أولاً من أن هناك منتج محدد في ComboBox
            if (cmbProdectName.SelectedValue != null)
            {
                // نحصل على القيمة الفعلية للمنتج المحدد (ID المنتج)
                // SelectedValue تعطي القيمة المرتبطة بالـ ValueMember للعنصر المحدد
                int ProdectID = Convert.ToInt32(cmbProdectName.SelectedValue);

                // إنشاء نموذج جديد لتعديل المنتج، نمرر له ID المنتج
                frmAddAndEidtProduct editProduct = new frmAddAndEidtProduct(ProdectID);

                // عرض النموذج على شكل نافذة حوارية (Modal)، يمنع المستخدم من التفاعل مع النموذج الأساسي حتى يغلق هذا النموذج
                editProduct.ShowDialog();

                _FillComboBoxByProdectName();
                // بعد ما يكمل التعديل ويرجع، نسوي تحديث للقائمة اللي تعرض أسماء المنتجات
                cmbProdectName.SelectedValue = ProdectID;//هنا نخلي كمبو بوكس علئ الخيار  اسم المنتج الي عدلنه اسمه
            }
            else
            {
                // إذا لم يتم تحديد أي منتج في ComboBox، نعرض رسالة تنبيهية للمستخدم
                MessageBox.Show("يرجى اختيار منتج أولاً.");
            }

            // نسوي فورم التعديل ونرسل له رقم المنتج حتى يعرف شنو يفتح ويعدل


            // نعرض فورم تعديل المنتج بشكل نافذة منفصلة وينتظر لين يغلقها

         
        }

        private void tbQuantity_Validating(object sender, CancelEventArgs e)
        {
            // نتأكد الحقل مو فارغ — لازم يدخل عدد
            if (string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                e.Cancel = true;
                errorProviderOrders.SetError(tbQuantity, "من فضلك ادخل عدد قطع المنتج");
                return;
            }

            errorProviderOrders.SetError(tbQuantity, "");

            // نحول القيمة إلى رقم بدون ما يرمي خطأ
            int quantity;
            if (!int.TryParse(tbQuantity.Text, out quantity))
            {
                e.Cancel = true;
                errorProviderOrders.SetError(tbQuantity, "رجاءً ادخل رقم صحيح للكمية");
                return;
            }

            // نجيب رقم المنتج من الكمبوبوكس
            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue);

            // نجيب معلومات المنتج
            clsProducts ProductInfo = clsProducts.FindProduct(ProductID);


     
                // إذا SelectedValue فارغ — يصير خطأ
                if (cmbProdectName.SelectedValue == null)
                {
                    e.Cancel = true;
                    errorProviderOrders.SetError(cmbProdectName, "الرجاء اختيار منتج صحيح");
                    return;
                }


                // نتحقق إذا الكمية أكبر من المخزون
                if (ProductInfo.Quantity < quantity)
                {
                    e.Cancel = true;

                    MessageBox.Show(
                        $"عدد قطع هذا المنتج [{ProductInfo.productName}] اكبر من الموجود بالمخزن\n" +
                        $"عدد القطع المتوفرة فقط: [ {ProductInfo.Quantity} ]",
                        "خطأ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    errorProviderOrders.SetError(tbQuantity,
                        $"عدد قطع هذا المنتج [{ProductInfo.productName}] اكبر من الموجود بالمخزن\n" +
                        $"عدد القطع المتوفرة فقط: [ {ProductInfo.Quantity} ]");
                }
                else
                {
                    errorProviderOrders.SetError(tbQuantity, "");
                }
            

           
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("من فضلك ادخل ارقام فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProdectName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbProdectName.Text))
            {
                e.Cancel = true;
                errorProviderOrders.SetError(cmbProdectName, "من فضلك اختر اسم المنتج");
                return;
            }

            errorProviderOrders.SetError(cmbProdectName, "");

       

            // نجيب رقم المنتج من الكمبوبوكس
            int ProductID = Convert.ToInt32(cmbProdectName.SelectedValue);

            // نجيب معلومات المنتج
             _ProductInfo = clsProducts.FindProduct(ProductID);



            // إذا SelectedValue فارغ — يصير خطأ
            if (cmbProdectName.SelectedValue == null)
            {
                e.Cancel = true;
                errorProviderOrders.SetError(cmbProdectName, "الرجاء اختيار منتج صحيح");
                return;
            }


            // نتحقق إذا الكمية أكبر من المخزون
            if (_ProductInfo.Quantity ==0)
            {
                e.Cancel = true;

                MessageBox.Show(
                    $"نفذ هذا المنتج من المخزن\n" +
                    $"عدد القطع المتوفرة : [ {_ProductInfo.Quantity} ]",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                errorProviderOrders.SetError(cmbProdectName,
                     $"نفذ هذا المنتج [{_ProductInfo.productName}]  من المخزن\n" +
                    $"عدد القطع المتوفرة : [ {_ProductInfo.Quantity} ]");
            }
            else
            {
                errorProviderOrders.SetError(cmbProdectName, "");
            }

        }

        private void cmbProdectName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
