namespace ETEZAN2024.forms_And_Contrls.Orders
{
    partial class frmActiveOrdersWithRemainingTimeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActiveOrdersWithRemainingTimeList));
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrdersCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsActiveOrdersManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsOrderInProgressingNow = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsPendingOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstCompletedOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsWhatsappPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllActiveOrdersWithRemainingTime = new System.Windows.Forms.DataGridView();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterProductInventorieInfo = new System.Windows.Forms.ComboBox();
            this.lblNearestBooking = new System.Windows.Forms.Label();
            this.pBoxProductInventories = new System.Windows.Forms.PictureBox();
            this.ctmsActiveOrdersManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllActiveOrdersWithRemainingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductInventories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(235, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "اداره حجوزات الطلبات الغير مكتملة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOrdersCount
            // 
            this.lbOrdersCount.AutoSize = true;
            this.lbOrdersCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrdersCount.ForeColor = System.Drawing.Color.Green;
            this.lbOrdersCount.Location = new System.Drawing.Point(5, 562);
            this.lbOrdersCount.Name = "lbOrdersCount";
            this.lbOrdersCount.Size = new System.Drawing.Size(212, 29);
            this.lbOrdersCount.TabIndex = 76;
            this.lbOrdersCount.Text = "عدد الطلبات الغير مكتملة";
            this.lbOrdersCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(310, 6);
            // 
            // ctmsActiveOrdersManagement
            // 
            this.ctmsActiveOrdersManagement.BackColor = System.Drawing.Color.White;
            this.ctmsActiveOrdersManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsActiveOrdersManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsActiveOrdersManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsActiveOrdersManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsActiveOrdersManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsOrderInProgressingNow,
            this.ctmsPendingOrder,
            this.ctmsCancelOrder,
            this.cmstCompletedOrder,
            this.toolStripSeparator1,
            this.ctmsDetailOrder,
            this.toolStripSeparator2,
            this.ctmsWhatsappPerson});
            this.ctmsActiveOrdersManagement.Name = "ctmsPeopleManagement";
            this.ctmsActiveOrdersManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsActiveOrdersManagement.ShowCheckMargin = true;
            this.ctmsActiveOrdersManagement.Size = new System.Drawing.Size(314, 292);
            // 
            // ctmsDetailOrder
            // 
            this.ctmsDetailOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailOrder.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailOrder.Name = "ctmsDetailOrder";
            this.ctmsDetailOrder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.ctmsDetailOrder.Size = new System.Drawing.Size(313, 46);
            this.ctmsDetailOrder.Text = "تفاصيل  الطلب";
            this.ctmsDetailOrder.Click += new System.EventHandler(this.ctmsDetailOrder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(310, 6);
            // 
            // ctmsOrderInProgressingNow
            // 
            this.ctmsOrderInProgressingNow.ForeColor = System.Drawing.Color.Olive;
            this.ctmsOrderInProgressingNow.Image = global::ETEZAN2024.Properties.Resources.steps;
            this.ctmsOrderInProgressingNow.Name = "ctmsOrderInProgressingNow";
            this.ctmsOrderInProgressingNow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.ctmsOrderInProgressingNow.Size = new System.Drawing.Size(313, 46);
            this.ctmsOrderInProgressingNow.Text = "تنفيذ الطلب الان";
            this.ctmsOrderInProgressingNow.Click += new System.EventHandler(this.ctmsOrderInProgressingNow_Click);
            // 
            // ctmsPendingOrder
            // 
            this.ctmsPendingOrder.ForeColor = System.Drawing.Color.Purple;
            this.ctmsPendingOrder.Image = global::ETEZAN2024.Properties.Resources.timer1;
            this.ctmsPendingOrder.Name = "ctmsPendingOrder";
            this.ctmsPendingOrder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.ctmsPendingOrder.Size = new System.Drawing.Size(313, 46);
            this.ctmsPendingOrder.Text = "تأجيل الطلب";
            this.ctmsPendingOrder.Click += new System.EventHandler(this.ctmsPendingOrder_Click);
            // 
            // cmstCompletedOrder
            // 
            this.cmstCompletedOrder.ForeColor = System.Drawing.Color.Teal;
            this.cmstCompletedOrder.Image = global::ETEZAN2024.Properties.Resources.delivery;
            this.cmstCompletedOrder.Name = "cmstCompletedOrder";
            this.cmstCompletedOrder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.End)));
            this.cmstCompletedOrder.Size = new System.Drawing.Size(313, 46);
            this.cmstCompletedOrder.Text = "اكتمل الطلب";
            this.cmstCompletedOrder.Click += new System.EventHandler(this.cmstCompletedOrder_Click);
            // 
            // ctmsCancelOrder
            // 
            this.ctmsCancelOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsCancelOrder.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCancelOrder.Image")));
            this.ctmsCancelOrder.Name = "ctmsCancelOrder";
            this.ctmsCancelOrder.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.ctmsCancelOrder.Size = new System.Drawing.Size(313, 46);
            this.ctmsCancelOrder.Text = "اللغاءالطلب";
            this.ctmsCancelOrder.Click += new System.EventHandler(this.ctmsCancelOrder_Click);
            // 
            // ctmsWhatsappPerson
            // 
            this.ctmsWhatsappPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsWhatsappPerson.Image = global::ETEZAN2024.Properties.Resources.whatsapp;
            this.ctmsWhatsappPerson.Name = "ctmsWhatsappPerson";
            this.ctmsWhatsappPerson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.ctmsWhatsappPerson.Size = new System.Drawing.Size(313, 46);
            this.ctmsWhatsappPerson.Text = "الاارسال عبر الواتساب";
            this.ctmsWhatsappPerson.Click += new System.EventHandler(this.ctmsWhatsappPerson_Click);
            // 
            // dgvAllActiveOrdersWithRemainingTime
            // 
            this.dgvAllActiveOrdersWithRemainingTime.AllowUserToAddRows = false;
            this.dgvAllActiveOrdersWithRemainingTime.AllowUserToDeleteRows = false;
            this.dgvAllActiveOrdersWithRemainingTime.AllowUserToOrderColumns = true;
            this.dgvAllActiveOrdersWithRemainingTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllActiveOrdersWithRemainingTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllActiveOrdersWithRemainingTime.ContextMenuStrip = this.ctmsActiveOrdersManagement;
            this.dgvAllActiveOrdersWithRemainingTime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllActiveOrdersWithRemainingTime.Location = new System.Drawing.Point(6, 167);
            this.dgvAllActiveOrdersWithRemainingTime.Name = "dgvAllActiveOrdersWithRemainingTime";
            this.dgvAllActiveOrdersWithRemainingTime.ReadOnly = true;
            this.dgvAllActiveOrdersWithRemainingTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllActiveOrdersWithRemainingTime.Size = new System.Drawing.Size(787, 390);
            this.dgvAllActiveOrdersWithRemainingTime.TabIndex = 74;
            this.dgvAllActiveOrdersWithRemainingTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllActiveOrdersWithRemainingTime_CellContentClick);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(252, 139);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 79;
            this.tbFilterValue.Visible = false;
            // 
            // cmbFilterProductInventorieInfo
            // 
            this.cmbFilterProductInventorieInfo.FormattingEnabled = true;
            this.cmbFilterProductInventorieInfo.Location = new System.Drawing.Point(128, 139);
            this.cmbFilterProductInventorieInfo.Name = "cmbFilterProductInventorieInfo";
            this.cmbFilterProductInventorieInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterProductInventorieInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterProductInventorieInfo.TabIndex = 77;
            // 
            // lblNearestBooking
            // 
            this.lblNearestBooking.AutoSize = true;
            this.lblNearestBooking.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNearestBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNearestBooking.Location = new System.Drawing.Point(489, 131);
            this.lblNearestBooking.Name = "lblNearestBooking";
            this.lblNearestBooking.Size = new System.Drawing.Size(130, 29);
            this.lblNearestBooking.TabIndex = 80;
            this.lblNearestBooking.Text = "أقرب موعد حجز";
            this.lblNearestBooking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBoxProductInventories
            // 
            this.pBoxProductInventories.BackgroundImage = global::ETEZAN2024.Properties.Resources.deadline;
            this.pBoxProductInventories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxProductInventories.Location = new System.Drawing.Point(336, 2);
            this.pBoxProductInventories.Name = "pBoxProductInventories";
            this.pBoxProductInventories.Size = new System.Drawing.Size(89, 62);
            this.pBoxProductInventories.TabIndex = 71;
            this.pBoxProductInventories.TabStop = false;
            // 
            // frmActiveOrdersWithRemainingTimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.lblNearestBooking);
            this.Controls.Add(this.pBoxProductInventories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOrdersCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllActiveOrdersWithRemainingTime);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterProductInventorieInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActiveOrdersWithRemainingTimeList";
            this.Opacity = 0.96D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اداره حجوزات الطلبات الغير مكتملة";
            this.Load += new System.EventHandler(this.frmActiveOrdersWithRemainingTime_Load);
            this.ctmsActiveOrdersManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllActiveOrdersWithRemainingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductInventories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxProductInventories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrdersCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ctmsWhatsappPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsPendingOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsCancelOrder;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailOrder;
        private System.Windows.Forms.ContextMenuStrip ctmsActiveOrdersManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvAllActiveOrdersWithRemainingTime;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterProductInventorieInfo;
        private System.Windows.Forms.ToolStripMenuItem ctmsOrderInProgressingNow;
        private System.Windows.Forms.Label lblNearestBooking;
        private System.Windows.Forms.ToolStripMenuItem cmstCompletedOrder;
    }
}