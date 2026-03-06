namespace ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution
{
    partial class frmOrderCashBoxsDistributionList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderCashBoxsDistributionList));
            this.dgvAllOrderCashBoxsDistribution = new System.Windows.Forms.DataGridView();
            this.ctmsOrderCashBoxsDistributionManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailOrderCashBoxsDistribution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddCashOrderCashBoxsDistribution = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtOrderCashBoxsDistribution = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteOrderCashBoxsDistribution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterOrderCashBoxDistributionInfo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrderCashBoxsDistributionCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderCashBoxsDistributionStatus = new System.Windows.Forms.ComboBox();
            this.pBoxAddOrderCashBoxsDistribution = new System.Windows.Forms.PictureBox();
            this.pBoxOrderCashBoxsDistribution = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrderCashBoxsDistribution)).BeginInit();
            this.ctmsOrderCashBoxsDistributionManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddOrderCashBoxsDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOrderCashBoxsDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllOrderCashBoxsDistribution
            // 
            this.dgvAllOrderCashBoxsDistribution.AllowUserToAddRows = false;
            this.dgvAllOrderCashBoxsDistribution.AllowUserToDeleteRows = false;
            this.dgvAllOrderCashBoxsDistribution.AllowUserToOrderColumns = true;
            this.dgvAllOrderCashBoxsDistribution.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllOrderCashBoxsDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrderCashBoxsDistribution.ContextMenuStrip = this.ctmsOrderCashBoxsDistributionManagement;
            this.dgvAllOrderCashBoxsDistribution.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllOrderCashBoxsDistribution.Location = new System.Drawing.Point(8, 242);
            this.dgvAllOrderCashBoxsDistribution.Name = "dgvAllOrderCashBoxsDistribution";
            this.dgvAllOrderCashBoxsDistribution.ReadOnly = true;
            this.dgvAllOrderCashBoxsDistribution.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllOrderCashBoxsDistribution.Size = new System.Drawing.Size(746, 390);
            this.dgvAllOrderCashBoxsDistribution.TabIndex = 95;
            // 
            // ctmsOrderCashBoxsDistributionManagement
            // 
            this.ctmsOrderCashBoxsDistributionManagement.BackColor = System.Drawing.Color.White;
            this.ctmsOrderCashBoxsDistributionManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsOrderCashBoxsDistributionManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsOrderCashBoxsDistributionManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsOrderCashBoxsDistributionManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsOrderCashBoxsDistributionManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailOrderCashBoxsDistribution,
            this.toolStripSeparator1,
            this.ctmsAddCashOrderCashBoxsDistribution,
            this.ctmsEidtOrderCashBoxsDistribution,
            this.ctmsDeleteOrderCashBoxsDistribution,
            this.toolStripSeparator2});
            this.ctmsOrderCashBoxsDistributionManagement.Name = "ctmsPeopleManagement";
            this.ctmsOrderCashBoxsDistributionManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsOrderCashBoxsDistributionManagement.ShowCheckMargin = true;
            this.ctmsOrderCashBoxsDistributionManagement.Size = new System.Drawing.Size(356, 200);
            // 
            // ctmsDetailOrderCashBoxsDistribution
            // 
            this.ctmsDetailOrderCashBoxsDistribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailOrderCashBoxsDistribution.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailOrderCashBoxsDistribution.Name = "ctmsDetailOrderCashBoxsDistribution";
            this.ctmsDetailOrderCashBoxsDistribution.Size = new System.Drawing.Size(355, 46);
            this.ctmsDetailOrderCashBoxsDistribution.Text = "تفاصيل  ترحيل الاموال";
            this.ctmsDetailOrderCashBoxsDistribution.Click += new System.EventHandler(this.ctmsDetailOrderCashBoxsDistribution_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(352, 6);
            // 
            // ctmsAddCashOrderCashBoxsDistribution
            // 
            this.ctmsAddCashOrderCashBoxsDistribution.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddCashOrderCashBoxsDistribution.Name = "ctmsAddCashOrderCashBoxsDistribution";
            this.ctmsAddCashOrderCashBoxsDistribution.Size = new System.Drawing.Size(355, 46);
            this.ctmsAddCashOrderCashBoxsDistribution.Text = "اضافه ترحيل";
            this.ctmsAddCashOrderCashBoxsDistribution.Click += new System.EventHandler(this.ctmsAddCashOrderCashBoxsDistribution_Click);
            // 
            // ctmsEidtOrderCashBoxsDistribution
            // 
            this.ctmsEidtOrderCashBoxsDistribution.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtOrderCashBoxsDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtOrderCashBoxsDistribution.Image")));
            this.ctmsEidtOrderCashBoxsDistribution.Name = "ctmsEidtOrderCashBoxsDistribution";
            this.ctmsEidtOrderCashBoxsDistribution.Size = new System.Drawing.Size(355, 46);
            this.ctmsEidtOrderCashBoxsDistribution.Text = "تحديث معلومات  اموال الطلب لصندوق";
            this.ctmsEidtOrderCashBoxsDistribution.Click += new System.EventHandler(this.ctmsEidtOrderCashBoxsDistribution_Click);
            // 
            // ctmsDeleteOrderCashBoxsDistribution
            // 
            this.ctmsDeleteOrderCashBoxsDistribution.Enabled = false;
            this.ctmsDeleteOrderCashBoxsDistribution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsDeleteOrderCashBoxsDistribution.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteOrderCashBoxsDistribution.Image")));
            this.ctmsDeleteOrderCashBoxsDistribution.Name = "ctmsDeleteOrderCashBoxsDistribution";
            this.ctmsDeleteOrderCashBoxsDistribution.Size = new System.Drawing.Size(355, 46);
            this.ctmsDeleteOrderCashBoxsDistribution.Text = "حذف اموال الطلب لصندوق";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(352, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(30, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "إضافة ترحيل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(636, 177);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 100;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterOrderCashBoxDistributionInfo
            // 
            this.cmbFilterOrderCashBoxDistributionInfo.FormattingEnabled = true;
            this.cmbFilterOrderCashBoxDistributionInfo.Location = new System.Drawing.Point(512, 177);
            this.cmbFilterOrderCashBoxDistributionInfo.Name = "cmbFilterOrderCashBoxDistributionInfo";
            this.cmbFilterOrderCashBoxDistributionInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterOrderCashBoxDistributionInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterOrderCashBoxDistributionInfo.TabIndex = 98;
            this.cmbFilterOrderCashBoxDistributionInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterOrderCashBoxDistributionInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(222, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "ادارة ترحيل الاموال الئ الصناديق";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(7, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 96;
            this.label4.Text = "عدداموال الطلبات لصناديق    :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOrderCashBoxsDistributionCount
            // 
            this.lbOrderCashBoxsDistributionCount.AutoSize = true;
            this.lbOrderCashBoxsDistributionCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrderCashBoxsDistributionCount.ForeColor = System.Drawing.Color.Green;
            this.lbOrderCashBoxsDistributionCount.Location = new System.Drawing.Point(266, 639);
            this.lbOrderCashBoxsDistributionCount.Name = "lbOrderCashBoxsDistributionCount";
            this.lbOrderCashBoxsDistributionCount.Size = new System.Drawing.Size(65, 29);
            this.lbOrderCashBoxsDistributionCount.TabIndex = 97;
            this.lbOrderCashBoxsDistributionCount.Text = "####";
            this.lbOrderCashBoxsDistributionCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(393, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderCashBoxsDistributionStatus
            // 
            this.OrderCashBoxsDistributionStatus.FormattingEnabled = true;
            this.OrderCashBoxsDistributionStatus.Location = new System.Drawing.Point(546, 204);
            this.OrderCashBoxsDistributionStatus.Name = "OrderCashBoxsDistributionStatus";
            this.OrderCashBoxsDistributionStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderCashBoxsDistributionStatus.Size = new System.Drawing.Size(84, 21);
            this.OrderCashBoxsDistributionStatus.TabIndex = 101;
            this.OrderCashBoxsDistributionStatus.SelectedIndexChanged += new System.EventHandler(this.OrderCashBoxsDistributionStatus_SelectedIndexChanged);
            // 
            // pBoxAddOrderCashBoxsDistribution
            // 
            this.pBoxAddOrderCashBoxsDistribution.BackgroundImage = global::ETEZAN2024.Properties.Resources.money_transfer;
            this.pBoxAddOrderCashBoxsDistribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddOrderCashBoxsDistribution.Location = new System.Drawing.Point(33, 152);
            this.pBoxAddOrderCashBoxsDistribution.Name = "pBoxAddOrderCashBoxsDistribution";
            this.pBoxAddOrderCashBoxsDistribution.Size = new System.Drawing.Size(86, 46);
            this.pBoxAddOrderCashBoxsDistribution.TabIndex = 94;
            this.pBoxAddOrderCashBoxsDistribution.TabStop = false;
            this.pBoxAddOrderCashBoxsDistribution.Click += new System.EventHandler(this.pBoxAddOrderCashBoxsDistribution_Click);
            // 
            // pBoxOrderCashBoxsDistribution
            // 
            this.pBoxOrderCashBoxsDistribution.BackgroundImage = global::ETEZAN2024.Properties.Resources.money;
            this.pBoxOrderCashBoxsDistribution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxOrderCashBoxsDistribution.Location = new System.Drawing.Point(304, 5);
            this.pBoxOrderCashBoxsDistribution.Name = "pBoxOrderCashBoxsDistribution";
            this.pBoxOrderCashBoxsDistribution.Size = new System.Drawing.Size(89, 62);
            this.pBoxOrderCashBoxsDistribution.TabIndex = 92;
            this.pBoxOrderCashBoxsDistribution.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(447, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 102;
            this.label5.Text = "مجموع اموال الطلبات     :\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.Green;
            this.lbTotalAmount.Location = new System.Drawing.Point(657, 639);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(65, 29);
            this.lbTotalAmount.TabIndex = 103;
            this.lbTotalAmount.Text = "####";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmOrderCashBoxsDistributionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.OrderCashBoxsDistributionStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterOrderCashBoxDistributionInfo);
            this.Controls.Add(this.pBoxAddOrderCashBoxsDistribution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOrderCashBoxsDistributionCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBoxOrderCashBoxsDistribution);
            this.Controls.Add(this.dgvAllOrderCashBoxsDistribution);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderCashBoxsDistributionList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ترحيل الاموال الئ الصناديق";
            this.Load += new System.EventHandler(this.frmOrderCashBoxsDistributionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrderCashBoxsDistribution)).EndInit();
            this.ctmsOrderCashBoxsDistributionManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddOrderCashBoxsDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOrderCashBoxsDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllOrderCashBoxsDistribution;
        private System.Windows.Forms.ContextMenuStrip ctmsOrderCashBoxsDistributionManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailOrderCashBoxsDistribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddCashOrderCashBoxsDistribution;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtOrderCashBoxsDistribution;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteOrderCashBoxsDistribution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterOrderCashBoxDistributionInfo;
        private System.Windows.Forms.PictureBox pBoxAddOrderCashBoxsDistribution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOrderCashBoxsDistributionCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBoxOrderCashBoxsDistribution;
        private System.Windows.Forms.ComboBox OrderCashBoxsDistributionStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalAmount;
    }
}