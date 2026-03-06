namespace ETEZAN2024.forms_And_Contrls.Orders
{
    partial class frmOrdersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdersList));
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            this.ctmsOrdersManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCanselOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDetailOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsPrintInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtsSaveInvoiceAsImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsWhatsappPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrdersCount = new System.Windows.Forms.Label();
            this.cmbIsOrderStutas = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterOrderInfo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveFileInvoiceAsImage = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.PboxNext = new System.Windows.Forms.PictureBox();
            this.PboxPrevious = new System.Windows.Forms.PictureBox();
            this.pBoxAddOrder = new System.Windows.Forms.PictureBox();
            this.pBoxOrder = new System.Windows.Forms.PictureBox();
            this.cmbReportFilters = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            this.ctmsOrdersManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllOrders
            // 
            this.dgvAllOrders.AllowUserToAddRows = false;
            this.dgvAllOrders.AllowUserToDeleteRows = false;
            this.dgvAllOrders.AllowUserToOrderColumns = true;
            this.dgvAllOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrders.ContextMenuStrip = this.ctmsOrdersManagement;
            this.dgvAllOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllOrders.Location = new System.Drawing.Point(14, 264);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.ReadOnly = true;
            this.dgvAllOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllOrders.Size = new System.Drawing.Size(1293, 343);
            this.dgvAllOrders.TabIndex = 25;
            // 
            // ctmsOrdersManagement
            // 
            this.ctmsOrdersManagement.BackColor = System.Drawing.Color.White;
            this.ctmsOrdersManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsOrdersManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsOrdersManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsOrdersManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsOrdersManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsAddOrder,
            this.ctmsEidtOrder,
            this.ctmsCanselOrder,
            this.ctmsDetailOrder,
            this.toolStripSeparator2,
            this.ctmsPrintInvoice,
            this.cmtsSaveInvoiceAsImage,
            this.toolStripSeparator3,
            this.ctmsWhatsappPerson});
            this.ctmsOrdersManagement.Name = "ctmsPeopleManagement";
            this.ctmsOrdersManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsOrdersManagement.ShowCheckMargin = true;
            this.ctmsOrdersManagement.Size = new System.Drawing.Size(328, 338);
            this.ctmsOrdersManagement.Opening += new System.ComponentModel.CancelEventHandler(this.ctmsOrdersManagement_Opening);
            // 
            // ctmsAddOrder
            // 
            this.ctmsAddOrder.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddOrder.Name = "ctmsAddOrder";
            this.ctmsAddOrder.Size = new System.Drawing.Size(327, 46);
            this.ctmsAddOrder.Text = "اضافه طلب";
            this.ctmsAddOrder.Click += new System.EventHandler(this.ctmsAddOrder_Click);
            // 
            // ctmsEidtOrder
            // 
            this.ctmsEidtOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtOrder.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtOrder.Image")));
            this.ctmsEidtOrder.Name = "ctmsEidtOrder";
            this.ctmsEidtOrder.Size = new System.Drawing.Size(327, 46);
            this.ctmsEidtOrder.Text = "تحديث معلومات الطلب";
            this.ctmsEidtOrder.Click += new System.EventHandler(this.ctmsEidtOrder_Click);
            // 
            // ctmsCanselOrder
            // 
            this.ctmsCanselOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsCanselOrder.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCanselOrder.Image")));
            this.ctmsCanselOrder.Name = "ctmsCanselOrder";
            this.ctmsCanselOrder.Size = new System.Drawing.Size(327, 46);
            this.ctmsCanselOrder.Text = "اللغاء الطلب";
            this.ctmsCanselOrder.Click += new System.EventHandler(this.ctmsCanselOrder_Click);
            // 
            // ctmsDetailOrder
            // 
            this.ctmsDetailOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctmsDetailOrder.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailOrder.Name = "ctmsDetailOrder";
            this.ctmsDetailOrder.Size = new System.Drawing.Size(327, 46);
            this.ctmsDetailOrder.Text = "تفاصيل الطلب";
            this.ctmsDetailOrder.Click += new System.EventHandler(this.ctmsDetailOrder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(324, 6);
            // 
            // ctmsPrintInvoice
            // 
            this.ctmsPrintInvoice.ForeColor = System.Drawing.Color.Navy;
            this.ctmsPrintInvoice.Image = global::ETEZAN2024.Properties.Resources.PrintInvoice;
            this.ctmsPrintInvoice.Name = "ctmsPrintInvoice";
            this.ctmsPrintInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ctmsPrintInvoice.Size = new System.Drawing.Size(327, 46);
            this.ctmsPrintInvoice.Text = "طباعة فاتورة الطلب";
            this.ctmsPrintInvoice.Click += new System.EventHandler(this.ctmsPrintInvoice_Click);
            // 
            // cmtsSaveInvoiceAsImage
            // 
            this.cmtsSaveInvoiceAsImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmtsSaveInvoiceAsImage.Image = global::ETEZAN2024.Properties.Resources.InvoiceAsPng1;
            this.cmtsSaveInvoiceAsImage.Name = "cmtsSaveInvoiceAsImage";
            this.cmtsSaveInvoiceAsImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cmtsSaveInvoiceAsImage.Size = new System.Drawing.Size(327, 46);
            this.cmtsSaveInvoiceAsImage.Text = "حفظ صورة فاتورة الطلب";
            this.cmtsSaveInvoiceAsImage.Click += new System.EventHandler(this.cmtsSaveInvoiceAsImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(324, 6);
            // 
            // ctmsWhatsappPerson
            // 
            this.ctmsWhatsappPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsWhatsappPerson.Image = global::ETEZAN2024.Properties.Resources.whatsapp;
            this.ctmsWhatsappPerson.Name = "ctmsWhatsappPerson";
            this.ctmsWhatsappPerson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.ctmsWhatsappPerson.Size = new System.Drawing.Size(327, 46);
            this.ctmsWhatsappPerson.Text = "الاارسال عبر الواتساب";
            this.ctmsWhatsappPerson.Click += new System.EventHandler(this.ctmsWhatsappPerson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(56, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "اضـافــة طلب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(589, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "ادارة الطلبات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(9, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = " عدد الطلبات :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOrdersCount
            // 
            this.lbOrdersCount.AutoSize = true;
            this.lbOrdersCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrdersCount.ForeColor = System.Drawing.Color.Green;
            this.lbOrdersCount.Location = new System.Drawing.Point(147, 627);
            this.lbOrdersCount.Name = "lbOrdersCount";
            this.lbOrdersCount.Size = new System.Drawing.Size(65, 29);
            this.lbOrdersCount.TabIndex = 28;
            this.lbOrdersCount.Text = "####";
            this.lbOrdersCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbIsOrderStutas
            // 
            this.cmbIsOrderStutas.FormattingEnabled = true;
            this.cmbIsOrderStutas.Location = new System.Drawing.Point(1108, 204);
            this.cmbIsOrderStutas.Name = "cmbIsOrderStutas";
            this.cmbIsOrderStutas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsOrderStutas.Size = new System.Drawing.Size(79, 21);
            this.cmbIsOrderStutas.TabIndex = 34;
            this.cmbIsOrderStutas.SelectedIndexChanged += new System.EventHandler(this.cmbIsOrderStutas_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(1190, 204);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 33;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterOrderInfo
            // 
            this.cmbFilterOrderInfo.FormattingEnabled = true;
            this.cmbFilterOrderInfo.Location = new System.Drawing.Point(988, 204);
            this.cmbFilterOrderInfo.Name = "cmbFilterOrderInfo";
            this.cmbFilterOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterOrderInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterOrderInfo.TabIndex = 31;
            this.cmbFilterOrderInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterOrderInfo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(854, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "فلترة بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(655, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "الصفحة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PboxNext
            // 
            this.PboxNext.Image = global::ETEZAN2024.Properties.Resources.next_button;
            this.PboxNext.Location = new System.Drawing.Point(538, 617);
            this.PboxNext.Name = "PboxNext";
            this.PboxNext.Size = new System.Drawing.Size(100, 34);
            this.PboxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxNext.TabIndex = 37;
            this.PboxNext.TabStop = false;
            this.PboxNext.Click += new System.EventHandler(this.PboxNext_Click);
            // 
            // PboxPrevious
            // 
            this.PboxPrevious.Image = global::ETEZAN2024.Properties.Resources.previous;
            this.PboxPrevious.Location = new System.Drawing.Point(748, 617);
            this.PboxPrevious.Name = "PboxPrevious";
            this.PboxPrevious.Size = new System.Drawing.Size(100, 34);
            this.PboxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxPrevious.TabIndex = 36;
            this.PboxPrevious.TabStop = false;
            this.PboxPrevious.Click += new System.EventHandler(this.PboxPrevious_Click);
            // 
            // pBoxAddOrder
            // 
            this.pBoxAddOrder.BackgroundImage = global::ETEZAN2024.Properties.Resources.add_product;
            this.pBoxAddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddOrder.Location = new System.Drawing.Point(55, 159);
            this.pBoxAddOrder.Name = "pBoxAddOrder";
            this.pBoxAddOrder.Size = new System.Drawing.Size(116, 46);
            this.pBoxAddOrder.TabIndex = 23;
            this.pBoxAddOrder.TabStop = false;
            this.pBoxAddOrder.Click += new System.EventHandler(this.pBoxAddOrder_Click);
            // 
            // pBoxOrder
            // 
            this.pBoxOrder.BackgroundImage = global::ETEZAN2024.Properties.Resources.orders;
            this.pBoxOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxOrder.Location = new System.Drawing.Point(582, 9);
            this.pBoxOrder.Name = "pBoxOrder";
            this.pBoxOrder.Size = new System.Drawing.Size(170, 107);
            this.pBoxOrder.TabIndex = 21;
            this.pBoxOrder.TabStop = false;
            // 
            // cmbReportFilters
            // 
            this.cmbReportFilters.FormattingEnabled = true;
            this.cmbReportFilters.Location = new System.Drawing.Point(988, 235);
            this.cmbReportFilters.Name = "cmbReportFilters";
            this.cmbReportFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReportFilters.Size = new System.Drawing.Size(199, 21);
            this.cmbReportFilters.TabIndex = 39;
            this.cmbReportFilters.SelectedIndexChanged += new System.EventHandler(this.cmbReportFilters_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(842, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "اختر نوع التقرير :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 656);
            this.Controls.Add(this.cmbReportFilters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PboxNext);
            this.Controls.Add(this.PboxPrevious);
            this.Controls.Add(this.cmbIsOrderStutas);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterOrderInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBoxAddOrder);
            this.Controls.Add(this.pBoxOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOrdersCount);
            this.Name = "frmOrdersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الطلبات";
            this.Load += new System.EventHandler(this.frmOrdersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            this.ctmsOrdersManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.ContextMenuStrip ctmsOrdersManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailOrder;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddOrder;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtOrder;
        private System.Windows.Forms.ToolStripMenuItem ctmsCanselOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBoxAddOrder;
        private System.Windows.Forms.PictureBox pBoxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOrdersCount;
        private System.Windows.Forms.ComboBox cmbIsOrderStutas;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterOrderInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ctmsPrintInvoice;
        private System.Windows.Forms.ToolStripMenuItem cmtsSaveInvoiceAsImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ctmsWhatsappPerson;
        private System.Windows.Forms.SaveFileDialog SaveFileInvoiceAsImage;
        private System.Windows.Forms.PictureBox PboxPrevious;
        private System.Windows.Forms.PictureBox PboxNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbReportFilters;
        private System.Windows.Forms.Label label6;
    }
}