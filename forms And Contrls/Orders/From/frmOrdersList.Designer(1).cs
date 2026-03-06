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
            this.ctmsDetailOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCanselOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrdersCount = new System.Windows.Forms.Label();
            this.cmbIsOrderStutas = new System.Windows.Forms.ComboBox();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterOrderInfo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pBoxAddOrder = new System.Windows.Forms.PictureBox();
            this.pBoxOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            this.ctmsOrdersManagement.SuspendLayout();
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
            this.dgvAllOrders.Size = new System.Drawing.Size(1293, 390);
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
            this.ctmsDetailOrder,
            this.toolStripSeparator1,
            this.ctmsAddOrder,
            this.ctmsEidtOrder,
            this.ctmsCanselOrder,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsOrdersManagement.Name = "ctmsPeopleManagement";
            this.ctmsOrdersManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsOrdersManagement.ShowCheckMargin = true;
            this.ctmsOrdersManagement.Size = new System.Drawing.Size(264, 292);
            this.ctmsOrdersManagement.Opening += new System.ComponentModel.CancelEventHandler(this.ctmsOrdersManagement_Opening);
            // 
            // ctmsDetailOrder
            // 
            this.ctmsDetailOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailOrder.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailOrder.Name = "ctmsDetailOrder";
            this.ctmsDetailOrder.Size = new System.Drawing.Size(263, 46);
            this.ctmsDetailOrder.Text = "تفاصيل الطلب";
            this.ctmsDetailOrder.Click += new System.EventHandler(this.ctmsDetailOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // ctmsAddOrder
            // 
            this.ctmsAddOrder.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddOrder.Name = "ctmsAddOrder";
            this.ctmsAddOrder.Size = new System.Drawing.Size(263, 46);
            this.ctmsAddOrder.Text = "اضافه طلب";
            this.ctmsAddOrder.Click += new System.EventHandler(this.ctmsAddOrder_Click);
            // 
            // ctmsEidtOrder
            // 
            this.ctmsEidtOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtOrder.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtOrder.Image")));
            this.ctmsEidtOrder.Name = "ctmsEidtOrder";
            this.ctmsEidtOrder.Size = new System.Drawing.Size(263, 46);
            this.ctmsEidtOrder.Text = "تحديث معلومات الطلب";
            this.ctmsEidtOrder.Click += new System.EventHandler(this.ctmsEidtOrder_Click);
            // 
            // ctmsCanselOrder
            // 
            this.ctmsCanselOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsCanselOrder.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCanselOrder.Image")));
            this.ctmsCanselOrder.Name = "ctmsCanselOrder";
            this.ctmsCanselOrder.Size = new System.Drawing.Size(263, 46);
            this.ctmsCanselOrder.Text = "اللغاء الطلب";
            this.ctmsCanselOrder.Click += new System.EventHandler(this.ctmsCanselOrder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(260, 6);
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(263, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(263, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
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
            this.label4.Location = new System.Drawing.Point(5, 656);
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
            this.lbOrdersCount.Location = new System.Drawing.Point(143, 661);
            this.lbOrdersCount.Name = "lbOrdersCount";
            this.lbOrdersCount.Size = new System.Drawing.Size(65, 29);
            this.lbOrdersCount.TabIndex = 28;
            this.lbOrdersCount.Text = "####";
            this.lbOrdersCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbIsOrderStutas
            // 
            this.cmbIsOrderStutas.FormattingEnabled = true;
            this.cmbIsOrderStutas.Location = new System.Drawing.Point(1108, 213);
            this.cmbIsOrderStutas.Name = "cmbIsOrderStutas";
            this.cmbIsOrderStutas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsOrderStutas.Size = new System.Drawing.Size(79, 21);
            this.cmbIsOrderStutas.TabIndex = 34;
            this.cmbIsOrderStutas.SelectedIndexChanged += new System.EventHandler(this.cmbIsOrderStutas_SelectedIndexChanged);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(1190, 213);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 33;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterOrderInfo
            // 
            this.cmbFilterOrderInfo.FormattingEnabled = true;
            this.cmbFilterOrderInfo.Location = new System.Drawing.Point(988, 213);
            this.cmbFilterOrderInfo.Name = "cmbFilterOrderInfo";
            this.cmbFilterOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterOrderInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterOrderInfo.TabIndex = 31;
            this.cmbFilterOrderInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterOrderInfo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(840, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1108, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Visible = false;
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
            // frmOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 694);
            this.Controls.Add(this.dateTimePicker1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.ContextMenuStrip ctmsOrdersManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddOrder;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtOrder;
        private System.Windows.Forms.ToolStripMenuItem ctmsCanselOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}