namespace ETEZAN2024.forms.frmMainMenu
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.Main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.SalesAndInventoryManagement_MST = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mstNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mstOrdersList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mstActiveOrdersWithRemainingTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mstProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mstProductsList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mstInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtProductsInventoryList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtAddProductInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mstManageDebts = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtDebtsList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtAddDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsOrderCashBoxsDistributionL = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCashBoxs = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCashBoxsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAddCashBox = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleManagement_MST = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersManagement_MST = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettingsManagement_MST = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrUserDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrLoginLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrLoggedout = new System.Windows.Forms.ToolStripMenuItem();
            this.notificatoinLoginUeser = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmtInventoryTransactionsList = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_menuStrip
            // 
            this.Main_menuStrip.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Main_menuStrip.Font = new System.Drawing.Font("mohammad bold art 1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Main_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Main_menuStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.Main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesAndInventoryManagement_MST,
            this.PeopleManagement_MST,
            this.UsersManagement_MST,
            this.AccountSettingsManagement_MST});
            this.Main_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Main_menuStrip.Name = "Main_menuStrip";
            this.Main_menuStrip.Size = new System.Drawing.Size(1364, 58);
            this.Main_menuStrip.TabIndex = 10;
            this.Main_menuStrip.Text = "MainmenuStrip";
            this.Main_menuStrip.UseWaitCursor = true;
            this.Main_menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Main_menuStrip_ItemClicked);
            // 
            // SalesAndInventoryManagement_MST
            // 
            this.SalesAndInventoryManagement_MST.BackColor = System.Drawing.Color.Transparent;
            this.SalesAndInventoryManagement_MST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalesAndInventoryManagement_MST.Checked = true;
            this.SalesAndInventoryManagement_MST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SalesAndInventoryManagement_MST.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsOrders,
            this.mstProducts,
            this.mstInventory,
            this.mstManageDebts,
            this.mtsOrderCashBoxsDistributionL,
            this.mstCashBoxs});
            this.SalesAndInventoryManagement_MST.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SalesAndInventoryManagement_MST.Image = ((System.Drawing.Image)(resources.GetObject("SalesAndInventoryManagement_MST.Image")));
            this.SalesAndInventoryManagement_MST.Name = "SalesAndInventoryManagement_MST";
            this.SalesAndInventoryManagement_MST.Size = new System.Drawing.Size(242, 54);
            this.SalesAndInventoryManagement_MST.Tag = "";
            this.SalesAndInventoryManagement_MST.Text = "إدارة المبيعات والمخزون";
            // 
            // mtsOrders
            // 
            this.mtsOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstNewOrder,
            this.mstOrdersList,
            this.toolStripSeparator1,
            this.mstActiveOrdersWithRemainingTime});
            this.mtsOrders.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtsOrders.Image = global::ETEZAN2024.Properties.Resources.application;
            this.mtsOrders.Name = "mtsOrders";
            this.mtsOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtsOrders.RightToLeftAutoMirrorImage = true;
            this.mtsOrders.Size = new System.Drawing.Size(243, 56);
            this.mtsOrders.Text = "الطلبات";
            // 
            // mstNewOrder
            // 
            this.mstNewOrder.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.mstNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("mstNewOrder.Image")));
            this.mstNewOrder.Name = "mstNewOrder";
            this.mstNewOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mstNewOrder.RightToLeftAutoMirrorImage = true;
            this.mstNewOrder.Size = new System.Drawing.Size(319, 30);
            this.mstNewOrder.Text = "اضافة طلب";
            this.mstNewOrder.Click += new System.EventHandler(this.mstNewOrder_Click);
            // 
            // mstOrdersList
            // 
            this.mstOrdersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mstOrdersList.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.mstOrdersList.Name = "mstOrdersList";
            this.mstOrdersList.Size = new System.Drawing.Size(319, 30);
            this.mstOrdersList.Text = "قائمة الطلبات";
            this.mstOrdersList.Click += new System.EventHandler(this.mstOrdersList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // mstActiveOrdersWithRemainingTime
            // 
            this.mstActiveOrdersWithRemainingTime.ForeColor = System.Drawing.Color.Blue;
            this.mstActiveOrdersWithRemainingTime.Image = global::ETEZAN2024.Properties.Resources.deadline;
            this.mstActiveOrdersWithRemainingTime.Name = "mstActiveOrdersWithRemainingTime";
            this.mstActiveOrdersWithRemainingTime.Size = new System.Drawing.Size(319, 30);
            this.mstActiveOrdersWithRemainingTime.Text = "قائمة الحجوزات والطلبات غير مكتملة";
            this.mstActiveOrdersWithRemainingTime.Click += new System.EventHandler(this.mstActiveOrdersWithRemainingTime_Click);
            // 
            // mstProducts
            // 
            this.mstProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstProductsList,
            this.cmstAddProduct});
            this.mstProducts.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstProducts.ForeColor = System.Drawing.Color.Blue;
            this.mstProducts.Image = global::ETEZAN2024.Properties.Resources.procurement;
            this.mstProducts.Name = "mstProducts";
            this.mstProducts.Size = new System.Drawing.Size(243, 56);
            this.mstProducts.Text = "المنتجات";
            // 
            // mstProductsList
            // 
            this.mstProductsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mstProductsList.Image = global::ETEZAN2024.Properties.Resources.online_shopping;
            this.mstProductsList.Name = "mstProductsList";
            this.mstProductsList.Size = new System.Drawing.Size(214, 56);
            this.mstProductsList.Text = "قائمه المنتجات";
            this.mstProductsList.Click += new System.EventHandler(this.mstProductsList_Click);
            // 
            // cmstAddProduct
            // 
            this.cmstAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmstAddProduct.Image = global::ETEZAN2024.Properties.Resources.box;
            this.cmstAddProduct.Name = "cmstAddProduct";
            this.cmstAddProduct.Size = new System.Drawing.Size(214, 56);
            this.cmstAddProduct.Text = "اضافه منتج";
            this.cmstAddProduct.Click += new System.EventHandler(this.cmstAddProduct_Click);
            // 
            // mstInventory
            // 
            this.mstInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmtProductsInventoryList,
            this.cmtAddProductInventory,
            this.cmtInventoryTransactionsList});
            this.mstInventory.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mstInventory.Image = global::ETEZAN2024.Properties.Resources.inventory;
            this.mstInventory.Name = "mstInventory";
            this.mstInventory.Size = new System.Drawing.Size(243, 56);
            this.mstInventory.Text = "المخزن";
            // 
            // cmtProductsInventoryList
            // 
            this.cmtProductsInventoryList.Image = global::ETEZAN2024.Properties.Resources.material_management;
            this.cmtProductsInventoryList.Name = "cmtProductsInventoryList";
            this.cmtProductsInventoryList.Size = new System.Drawing.Size(294, 56);
            this.cmtProductsInventoryList.Text = "قائمة منتجات المخزن";
            this.cmtProductsInventoryList.Click += new System.EventHandler(this.cmtProductsInventoryList_Click);
            // 
            // cmtAddProductInventory
            // 
            this.cmtAddProductInventory.ForeColor = System.Drawing.Color.Indigo;
            this.cmtAddProductInventory.Image = global::ETEZAN2024.Properties.Resources.warehouse;
            this.cmtAddProductInventory.Name = "cmtAddProductInventory";
            this.cmtAddProductInventory.Size = new System.Drawing.Size(294, 56);
            this.cmtAddProductInventory.Text = "اضافة منتج للمخزن";
            this.cmtAddProductInventory.Click += new System.EventHandler(this.cmtAddProductInventory_Click);
            // 
            // mstManageDebts
            // 
            this.mstManageDebts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmtDebtsList,
            this.cmtAddDebt});
            this.mstManageDebts.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstManageDebts.ForeColor = System.Drawing.Color.Green;
            this.mstManageDebts.Image = global::ETEZAN2024.Properties.Resources.borrowing;
            this.mstManageDebts.Name = "mstManageDebts";
            this.mstManageDebts.Size = new System.Drawing.Size(243, 56);
            this.mstManageDebts.Text = "الديون";
            // 
            // cmtDebtsList
            // 
            this.cmtDebtsList.Image = global::ETEZAN2024.Properties.Resources.DebtsList;
            this.cmtDebtsList.Name = "cmtDebtsList";
            this.cmtDebtsList.Size = new System.Drawing.Size(162, 30);
            this.cmtDebtsList.Text = "قائمه الديون";
            this.cmtDebtsList.Click += new System.EventHandler(this.cmtDebtsList_Click);
            // 
            // cmtAddDebt
            // 
            this.cmtAddDebt.ForeColor = System.Drawing.Color.Olive;
            this.cmtAddDebt.Image = global::ETEZAN2024.Properties.Resources.male;
            this.cmtAddDebt.Name = "cmtAddDebt";
            this.cmtAddDebt.Size = new System.Drawing.Size(162, 30);
            this.cmtAddDebt.Text = "اضافة مدين";
            this.cmtAddDebt.Click += new System.EventHandler(this.cmtAddDebt_Click);
            // 
            // mtsOrderCashBoxsDistributionL
            // 
            this.mtsOrderCashBoxsDistributionL.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtsOrderCashBoxsDistributionL.ForeColor = System.Drawing.Color.Teal;
            this.mtsOrderCashBoxsDistributionL.Image = global::ETEZAN2024.Properties.Resources.money;
            this.mtsOrderCashBoxsDistributionL.Name = "mtsOrderCashBoxsDistributionL";
            this.mtsOrderCashBoxsDistributionL.Size = new System.Drawing.Size(243, 56);
            this.mtsOrderCashBoxsDistributionL.Text = "ترحيل اموال الطلبات";
            this.mtsOrderCashBoxsDistributionL.Click += new System.EventHandler(this.mtsOrderCashBoxsDistributionL_Click);
            // 
            // mstCashBoxs
            // 
            this.mstCashBoxs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mstCashBoxs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstCashBoxsList,
            this.mstAddCashBox});
            this.mstCashBoxs.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstCashBoxs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mstCashBoxs.Image = global::ETEZAN2024.Properties.Resources.cash_register;
            this.mstCashBoxs.Name = "mstCashBoxs";
            this.mstCashBoxs.Size = new System.Drawing.Size(243, 56);
            this.mstCashBoxs.Text = "صناديق الاموال";
            // 
            // mstCashBoxsList
            // 
            this.mstCashBoxsList.Image = global::ETEZAN2024.Properties.Resources.material_management1;
            this.mstCashBoxsList.Name = "mstCashBoxsList";
            this.mstCashBoxsList.Size = new System.Drawing.Size(178, 30);
            this.mstCashBoxsList.Text = "قائمة الصناديق";
            this.mstCashBoxsList.Click += new System.EventHandler(this.mstCashBoxsList_Click);
            // 
            // mstAddCashBox
            // 
            this.mstAddCashBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mstAddCashBox.Image = global::ETEZAN2024.Properties.Resources.product;
            this.mstAddCashBox.Name = "mstAddCashBox";
            this.mstAddCashBox.Size = new System.Drawing.Size(178, 30);
            this.mstAddCashBox.Text = "اضافه صندوق";
            this.mstAddCashBox.Click += new System.EventHandler(this.mstAddCashBox_Click);
            // 
            // PeopleManagement_MST
            // 
            this.PeopleManagement_MST.BackColor = System.Drawing.Color.Transparent;
            this.PeopleManagement_MST.Image = ((System.Drawing.Image)(resources.GetObject("PeopleManagement_MST.Image")));
            this.PeopleManagement_MST.Name = "PeopleManagement_MST";
            this.PeopleManagement_MST.Size = new System.Drawing.Size(180, 54);
            this.PeopleManagement_MST.Tag = "";
            this.PeopleManagement_MST.Text = "الااشـخــاص";
            this.PeopleManagement_MST.Click += new System.EventHandler(this.PeopleManagement_MST_Click);
            // 
            // UsersManagement_MST
            // 
            this.UsersManagement_MST.Image = ((System.Drawing.Image)(resources.GetObject("UsersManagement_MST.Image")));
            this.UsersManagement_MST.Name = "UsersManagement_MST";
            this.UsersManagement_MST.Size = new System.Drawing.Size(197, 54);
            this.UsersManagement_MST.Tag = "";
            this.UsersManagement_MST.Text = "الـمـوضـفــيــن";
            this.UsersManagement_MST.Click += new System.EventHandler(this.UsersManagement_MST_Click);
            // 
            // AccountSettingsManagement_MST
            // 
            this.AccountSettingsManagement_MST.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrUserDetail,
            this.mstrChangePassword,
            this.mstrLoginLogs,
            this.mstrLoggedout});
            this.AccountSettingsManagement_MST.Font = new System.Drawing.Font("mohammad bold art 1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AccountSettingsManagement_MST.Image = ((System.Drawing.Image)(resources.GetObject("AccountSettingsManagement_MST.Image")));
            this.AccountSettingsManagement_MST.Name = "AccountSettingsManagement_MST";
            this.AccountSettingsManagement_MST.Size = new System.Drawing.Size(202, 54);
            this.AccountSettingsManagement_MST.Tag = "";
            this.AccountSettingsManagement_MST.Text = "ادارة الـحـسـاب";
            // 
            // mstrUserDetail
            // 
            this.mstrUserDetail.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstrUserDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mstrUserDetail.Image = ((System.Drawing.Image)(resources.GetObject("mstrUserDetail.Image")));
            this.mstrUserDetail.Name = "mstrUserDetail";
            this.mstrUserDetail.Size = new System.Drawing.Size(247, 28);
            this.mstrUserDetail.Text = " معلومات المستخدم الحالي";
            this.mstrUserDetail.Click += new System.EventHandler(this.mstrUserDetail_Click);
            // 
            // mstrChangePassword
            // 
            this.mstrChangePassword.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstrChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mstrChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("mstrChangePassword.Image")));
            this.mstrChangePassword.Name = "mstrChangePassword";
            this.mstrChangePassword.Size = new System.Drawing.Size(247, 28);
            this.mstrChangePassword.Text = "تغيير كلمة المرور";
            this.mstrChangePassword.Click += new System.EventHandler(this.mstrChangePassword_Click);
            // 
            // mstrLoginLogs
            // 
            this.mstrLoginLogs.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstrLoginLogs.ForeColor = System.Drawing.Color.Purple;
            this.mstrLoginLogs.Image = global::ETEZAN2024.Properties.Resources.monitoring;
            this.mstrLoginLogs.Name = "mstrLoginLogs";
            this.mstrLoginLogs.Size = new System.Drawing.Size(247, 28);
            this.mstrLoginLogs.Text = "سجلات عملية تسجيل الخول";
            this.mstrLoginLogs.Click += new System.EventHandler(this.mstrLoginLogs_Click);
            // 
            // mstrLoggedout
            // 
            this.mstrLoggedout.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mstrLoggedout.ForeColor = System.Drawing.Color.Blue;
            this.mstrLoggedout.Image = ((System.Drawing.Image)(resources.GetObject("mstrLoggedout.Image")));
            this.mstrLoggedout.Name = "mstrLoggedout";
            this.mstrLoggedout.Size = new System.Drawing.Size(247, 28);
            this.mstrLoggedout.Text = "تسجيل خروج";
            this.mstrLoggedout.Click += new System.EventHandler(this.mstrLoggedout_Click);
            // 
            // notificatoinLoginUeser
            // 
            this.notificatoinLoginUeser.Icon = ((System.Drawing.Icon)(resources.GetObject("notificatoinLoginUeser.Icon")));
            this.notificatoinLoginUeser.Text = "notifyIcon1";
            this.notificatoinLoginUeser.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ETEZAN2024.Properties.Resources.pexels_ron_lach_7969735;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 537);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmtInventoryTransactionsList
            // 
            this.cmtInventoryTransactionsList.ForeColor = System.Drawing.Color.Maroon;
            this.cmtInventoryTransactionsList.Image = global::ETEZAN2024.Properties.Resources.checklist;
            this.cmtInventoryTransactionsList.Name = "cmtInventoryTransactionsList";
            this.cmtInventoryTransactionsList.Size = new System.Drawing.Size(294, 56);
            this.cmtInventoryTransactionsList.Text = "قائمة جرد لحركات المخزون";
            this.cmtInventoryTransactionsList.Click += new System.EventHandler(this.cmtInventoryTransactionsList_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 537);
            this.Controls.Add(this.Main_menuStrip);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشه الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.Main_menuStrip.ResumeLayout(false);
            this.Main_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SalesAndInventoryManagement_MST;
        private System.Windows.Forms.ToolStripMenuItem mtsOrders;
        private System.Windows.Forms.ToolStripMenuItem mstNewOrder;
        private System.Windows.Forms.ToolStripMenuItem mstOrdersList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mstProducts;
        private System.Windows.Forms.ToolStripMenuItem mstProductsList;
        private System.Windows.Forms.ToolStripMenuItem cmstAddProduct;
        private System.Windows.Forms.ToolStripMenuItem mstInventory;
        private System.Windows.Forms.ToolStripMenuItem mstManageDebts;
        private System.Windows.Forms.ToolStripMenuItem PeopleManagement_MST;
        private System.Windows.Forms.ToolStripMenuItem UsersManagement_MST;
        private System.Windows.Forms.ToolStripMenuItem AccountSettingsManagement_MST;
        private System.Windows.Forms.ToolStripMenuItem mstrUserDetail;
        private System.Windows.Forms.ToolStripMenuItem mstrChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mstrLoggedout;
        private System.Windows.Forms.ToolStripMenuItem cmtAddProductInventory;
        private System.Windows.Forms.ToolStripMenuItem cmtProductsInventoryList;
        private System.Windows.Forms.ToolStripMenuItem cmtDebtsList;
        private System.Windows.Forms.ToolStripMenuItem cmtAddDebt;
        private System.Windows.Forms.ToolStripMenuItem mtsOrderCashBoxsDistributionL;
        private System.Windows.Forms.ToolStripMenuItem mstCashBoxs;
        private System.Windows.Forms.ToolStripMenuItem mstCashBoxsList;
        private System.Windows.Forms.ToolStripMenuItem mstAddCashBox;
        private System.Windows.Forms.ToolStripMenuItem mstrLoginLogs;
        private System.Windows.Forms.ToolStripMenuItem mstActiveOrdersWithRemainingTime;
        private System.Windows.Forms.NotifyIcon notificatoinLoginUeser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cmtInventoryTransactionsList;
    }
}