namespace ETEZAN2024.forms_And_Contrls.Inventories
{
    partial class frmInventoriesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoriesList));
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterProductInventorieInfo = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvAllProductInventories = new System.Windows.Forms.DataGridView();
            this.ctmsProductsInventoriesManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbIsProductStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbProductInventoriesCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBoxAddProductInventories = new System.Windows.Forms.PictureBox();
            this.pBoxProductInventories = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductInventories)).BeginInit();
            this.ctmsProductsInventoriesManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddProductInventories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductInventories)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(8, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "اضـافــة منتج للمخزن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(740, 203);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 68;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterProductInventorieInfo
            // 
            this.cmbFilterProductInventorieInfo.FormattingEnabled = true;
            this.cmbFilterProductInventorieInfo.Location = new System.Drawing.Point(616, 203);
            this.cmbFilterProductInventorieInfo.Name = "cmbFilterProductInventorieInfo";
            this.cmbFilterProductInventorieInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterProductInventorieInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterProductInventorieInfo.TabIndex = 66;
            this.cmbFilterProductInventorieInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterProductInventorieInfo_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // dgvAllProductInventories
            // 
            this.dgvAllProductInventories.AllowUserToAddRows = false;
            this.dgvAllProductInventories.AllowUserToDeleteRows = false;
            this.dgvAllProductInventories.AllowUserToOrderColumns = true;
            this.dgvAllProductInventories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllProductInventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProductInventories.ContextMenuStrip = this.ctmsProductsInventoriesManagement;
            this.dgvAllProductInventories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllProductInventories.Location = new System.Drawing.Point(8, 254);
            this.dgvAllProductInventories.Name = "dgvAllProductInventories";
            this.dgvAllProductInventories.ReadOnly = true;
            this.dgvAllProductInventories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllProductInventories.Size = new System.Drawing.Size(858, 390);
            this.dgvAllProductInventories.TabIndex = 63;
            // 
            // ctmsProductsInventoriesManagement
            // 
            this.ctmsProductsInventoriesManagement.BackColor = System.Drawing.Color.White;
            this.ctmsProductsInventoriesManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsProductsInventoriesManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsProductsInventoriesManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsProductsInventoriesManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsProductsInventoriesManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailProduct,
            this.toolStripSeparator1,
            this.ctmsAddProduct,
            this.ctmsEidtProduct,
            this.ctmsDeleteProduct,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsProductsInventoriesManagement.Name = "ctmsPeopleManagement";
            this.ctmsProductsInventoriesManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsProductsInventoriesManagement.ShowCheckMargin = true;
            this.ctmsProductsInventoriesManagement.Size = new System.Drawing.Size(272, 292);
            // 
            // ctmsDetailProduct
            // 
            this.ctmsDetailProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailProduct.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailProduct.Name = "ctmsDetailProduct";
            this.ctmsDetailProduct.Size = new System.Drawing.Size(271, 46);
            this.ctmsDetailProduct.Text = "تفاصيل  المنتج";
            this.ctmsDetailProduct.Click += new System.EventHandler(this.ctmsDetailProduct_Click);
            // 
            // ctmsAddProduct
            // 
            this.ctmsAddProduct.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddProduct.Name = "ctmsAddProduct";
            this.ctmsAddProduct.Size = new System.Drawing.Size(271, 46);
            this.ctmsAddProduct.Text = "اضافه  المنتج";
            this.ctmsAddProduct.Click += new System.EventHandler(this.ctmsAddProduct_Click);
            // 
            // ctmsEidtProduct
            // 
            this.ctmsEidtProduct.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtProduct.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtProduct.Image")));
            this.ctmsEidtProduct.Name = "ctmsEidtProduct";
            this.ctmsEidtProduct.Size = new System.Drawing.Size(271, 46);
            this.ctmsEidtProduct.Text = "تحديث معلومات  المنتج";
            this.ctmsEidtProduct.Click += new System.EventHandler(this.ctmsEidtProduct_Click);
            // 
            // ctmsDeleteProduct
            // 
            this.ctmsDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteProduct.Image")));
            this.ctmsDeleteProduct.Name = "ctmsDeleteProduct";
            this.ctmsDeleteProduct.Size = new System.Drawing.Size(271, 46);
            this.ctmsDeleteProduct.Text = "حذف  المنتج";
            this.ctmsDeleteProduct.Click += new System.EventHandler(this.ctmsDeleteProduct_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(268, 6);
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(271, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(271, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
            // 
            // cmbIsProductStatus
            // 
            this.cmbIsProductStatus.FormattingEnabled = true;
            this.cmbIsProductStatus.Location = new System.Drawing.Point(655, 227);
            this.cmbIsProductStatus.Name = "cmbIsProductStatus";
            this.cmbIsProductStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsProductStatus.Size = new System.Drawing.Size(79, 21);
            this.cmbIsProductStatus.TabIndex = 69;
            this.cmbIsProductStatus.Visible = false;
            this.cmbIsProductStatus.SelectedIndexChanged += new System.EventHandler(this.cmbIsProductStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(293, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "ادارة منتجات المخزن";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(-3, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "    عدد منتجات المخزن   :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbProductInventoriesCount
            // 
            this.lbProductInventoriesCount.AutoSize = true;
            this.lbProductInventoriesCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbProductInventoriesCount.ForeColor = System.Drawing.Color.Green;
            this.lbProductInventoriesCount.Location = new System.Drawing.Point(196, 650);
            this.lbProductInventoriesCount.Name = "lbProductInventoriesCount";
            this.lbProductInventoriesCount.Size = new System.Drawing.Size(65, 29);
            this.lbProductInventoriesCount.TabIndex = 65;
            this.lbProductInventoriesCount.Text = "####";
            this.lbProductInventoriesCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(497, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBoxAddProductInventories
            // 
            this.pBoxAddProductInventories.BackgroundImage = global::ETEZAN2024.Properties.Resources.warehouse;
            this.pBoxAddProductInventories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddProductInventories.Location = new System.Drawing.Point(31, 164);
            this.pBoxAddProductInventories.Name = "pBoxAddProductInventories";
            this.pBoxAddProductInventories.Size = new System.Drawing.Size(86, 46);
            this.pBoxAddProductInventories.TabIndex = 62;
            this.pBoxAddProductInventories.TabStop = false;
            this.pBoxAddProductInventories.Click += new System.EventHandler(this.pBoxAddProductInventories_Click);
            // 
            // pBoxProductInventories
            // 
            this.pBoxProductInventories.BackgroundImage = global::ETEZAN2024.Properties.Resources.material_management;
            this.pBoxProductInventories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxProductInventories.Location = new System.Drawing.Point(328, 12);
            this.pBoxProductInventories.Name = "pBoxProductInventories";
            this.pBoxProductInventories.Size = new System.Drawing.Size(89, 62);
            this.pBoxProductInventories.TabIndex = 60;
            this.pBoxProductInventories.TabStop = false;
            // 
            // frmInventoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterProductInventorieInfo);
            this.Controls.Add(this.pBoxAddProductInventories);
            this.Controls.Add(this.pBoxProductInventories);
            this.Controls.Add(this.dgvAllProductInventories);
            this.Controls.Add(this.cmbIsProductStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbProductInventoriesCount);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventoriesList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة منتجات المخزن";
            this.Load += new System.EventHandler(this.frmInventoriesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductInventories)).EndInit();
            this.ctmsProductsInventoriesManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddProductInventories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductInventories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterProductInventorieInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pBoxAddProductInventories;
        private System.Windows.Forms.PictureBox pBoxProductInventories;
        private System.Windows.Forms.DataGridView dgvAllProductInventories;
        private System.Windows.Forms.ContextMenuStrip ctmsProductsInventoriesManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cmbIsProductStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbProductInventoriesCount;
        private System.Windows.Forms.Label label3;
    }
}