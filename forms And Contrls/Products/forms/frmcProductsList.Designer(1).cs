namespace ETEZAN2024.forms_And_Contrls.Products
{
    partial class frmcProductsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcProductsList));
            this.cmbIsAvailableProduct = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterProductInfo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.ctmsProductsManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbProductsCount = new System.Windows.Forms.Label();
            this.pBoxAddProduct = new System.Windows.Forms.PictureBox();
            this.pBoxProducts = new System.Windows.Forms.PictureBox();
            this.cmbHasDemandProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.ctmsProductsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIsAvailableProduct
            // 
            this.cmbIsAvailableProduct.FormattingEnabled = true;
            this.cmbIsAvailableProduct.Location = new System.Drawing.Point(653, 210);
            this.cmbIsAvailableProduct.Name = "cmbIsAvailableProduct";
            this.cmbIsAvailableProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsAvailableProduct.Size = new System.Drawing.Size(79, 21);
            this.cmbIsAvailableProduct.TabIndex = 46;
            this.cmbIsAvailableProduct.Visible = false;
            this.cmbIsAvailableProduct.SelectedIndexChanged += new System.EventHandler(this.cmbIsAvailableProduct_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(738, 186);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 45;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterProductInfo
            // 
            this.cmbFilterProductInfo.FormattingEnabled = true;
            this.cmbFilterProductInfo.Location = new System.Drawing.Point(614, 186);
            this.cmbFilterProductInfo.Name = "cmbFilterProductInfo";
            this.cmbFilterProductInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterProductInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterProductInfo.TabIndex = 43;
            this.cmbFilterProductInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterProductInfo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(466, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.AllowUserToAddRows = false;
            this.dgvAllProducts.AllowUserToDeleteRows = false;
            this.dgvAllProducts.AllowUserToOrderColumns = true;
            this.dgvAllProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.ContextMenuStrip = this.ctmsProductsManagement;
            this.dgvAllProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllProducts.Location = new System.Drawing.Point(20, 261);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.ReadOnly = true;
            this.dgvAllProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllProducts.Size = new System.Drawing.Size(836, 390);
            this.dgvAllProducts.TabIndex = 40;
            // 
            // ctmsProductsManagement
            // 
            this.ctmsProductsManagement.BackColor = System.Drawing.Color.White;
            this.ctmsProductsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsProductsManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsProductsManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsProductsManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsProductsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailProduct,
            this.toolStripSeparator1,
            this.ctmsAddProduct,
            this.ctmsEidtProduct,
            this.ctmsDeleteProduct,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsProductsManagement.Name = "ctmsPeopleManagement";
            this.ctmsProductsManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsProductsManagement.ShowCheckMargin = true;
            this.ctmsProductsManagement.Size = new System.Drawing.Size(268, 292);
            // 
            // ctmsDetailProduct
            // 
            this.ctmsDetailProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailProduct.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailProduct.Name = "ctmsDetailProduct";
            this.ctmsDetailProduct.Size = new System.Drawing.Size(267, 46);
            this.ctmsDetailProduct.Text = "تفاصيل المنتج";
            this.ctmsDetailProduct.Click += new System.EventHandler(this.ctmsDetailProduct_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // ctmsAddProduct
            // 
            this.ctmsAddProduct.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddProduct.Name = "ctmsAddProduct";
            this.ctmsAddProduct.Size = new System.Drawing.Size(267, 46);
            this.ctmsAddProduct.Text = "اضافه المنتج";
            this.ctmsAddProduct.Click += new System.EventHandler(this.ctmsAddProduct_Click);
            // 
            // ctmsEidtProduct
            // 
            this.ctmsEidtProduct.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtProduct.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtProduct.Image")));
            this.ctmsEidtProduct.Name = "ctmsEidtProduct";
            this.ctmsEidtProduct.Size = new System.Drawing.Size(267, 46);
            this.ctmsEidtProduct.Text = "تحديث معلومات المنتج";
            this.ctmsEidtProduct.Click += new System.EventHandler(this.ctmsEidtProduct_Click);
            // 
            // ctmsDeleteProduct
            // 
            this.ctmsDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteProduct.Image")));
            this.ctmsDeleteProduct.Name = "ctmsDeleteProduct";
            this.ctmsDeleteProduct.Size = new System.Drawing.Size(267, 46);
            this.ctmsDeleteProduct.Text = "حذف المنتج";
            this.ctmsDeleteProduct.Click += new System.EventHandler(this.ctmsDeleteProduct_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(267, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(267, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(25, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "اضـافــة منتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(372, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "ادارة المنتجات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(11, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = " عدد المنتجات :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbProductsCount
            // 
            this.lbProductsCount.AutoSize = true;
            this.lbProductsCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbProductsCount.ForeColor = System.Drawing.Color.Green;
            this.lbProductsCount.Location = new System.Drawing.Point(149, 658);
            this.lbProductsCount.Name = "lbProductsCount";
            this.lbProductsCount.Size = new System.Drawing.Size(65, 29);
            this.lbProductsCount.TabIndex = 42;
            this.lbProductsCount.Text = "####";
            this.lbProductsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBoxAddProduct
            // 
            this.pBoxAddProduct.BackgroundImage = global::ETEZAN2024.Properties.Resources.box;
            this.pBoxAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddProduct.Location = new System.Drawing.Point(24, 156);
            this.pBoxAddProduct.Name = "pBoxAddProduct";
            this.pBoxAddProduct.Size = new System.Drawing.Size(116, 46);
            this.pBoxAddProduct.TabIndex = 39;
            this.pBoxAddProduct.TabStop = false;
            this.pBoxAddProduct.Click += new System.EventHandler(this.pBoxAddProduct_Click);
            // 
            // pBoxProducts
            // 
            this.pBoxProducts.BackgroundImage = global::ETEZAN2024.Properties.Resources.online_shopping;
            this.pBoxProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxProducts.Location = new System.Drawing.Point(370, 9);
            this.pBoxProducts.Name = "pBoxProducts";
            this.pBoxProducts.Size = new System.Drawing.Size(126, 74);
            this.pBoxProducts.TabIndex = 37;
            this.pBoxProducts.TabStop = false;
            // 
            // cmbHasDemandProduct
            // 
            this.cmbHasDemandProduct.FormattingEnabled = true;
            this.cmbHasDemandProduct.Location = new System.Drawing.Point(653, 234);
            this.cmbHasDemandProduct.Name = "cmbHasDemandProduct";
            this.cmbHasDemandProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbHasDemandProduct.Size = new System.Drawing.Size(79, 21);
            this.cmbHasDemandProduct.TabIndex = 47;
            this.cmbHasDemandProduct.Visible = false;
            this.cmbHasDemandProduct.SelectedIndexChanged += new System.EventHandler(this.cmbHasDemandProduct_SelectedIndexChanged);
            // 
            // frmcProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 694);
            this.Controls.Add(this.cmbHasDemandProduct);
            this.Controls.Add(this.cmbIsAvailableProduct);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterProductInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBoxAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbProductsCount);
            this.Controls.Add(this.pBoxProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcProductsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة المنتجات";
            this.Load += new System.EventHandler(this.frmcProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.ctmsProductsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbIsAvailableProduct;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterProductInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.ContextMenuStrip ctmsProductsManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBoxAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbProductsCount;
        private System.Windows.Forms.PictureBox pBoxProducts;
        private System.Windows.Forms.ComboBox cmbHasDemandProduct;
    }
}