namespace ETEZAN2024.forms_And_Contrls.Inventories
{
    partial class frmInventoryTransactionsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryTransactionsList));
            this.cmbTypeInventoryTransactions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInventoryTransactionsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsInventoryTransactionsManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailInventoryTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddInventoryTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtInventoryTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteInventoryTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllInventoryTransactions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterInventoryTransactionsInfo = new System.Windows.Forms.ComboBox();
            this.pBoxInventoryTransactions = new System.Windows.Forms.PictureBox();
            this.pBoxAddInventoryTransactions = new System.Windows.Forms.PictureBox();
            this.ctmsInventoryTransactionsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInventoryTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInventoryTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddInventoryTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTypeInventoryTransactions
            // 
            this.cmbTypeInventoryTransactions.FormattingEnabled = true;
            this.cmbTypeInventoryTransactions.Location = new System.Drawing.Point(495, 234);
            this.cmbTypeInventoryTransactions.Name = "cmbTypeInventoryTransactions";
            this.cmbTypeInventoryTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTypeInventoryTransactions.Size = new System.Drawing.Size(118, 21);
            this.cmbTypeInventoryTransactions.TabIndex = 80;
            this.cmbTypeInventoryTransactions.Visible = false;
            this.cmbTypeInventoryTransactions.SelectedIndexChanged += new System.EventHandler(this.cmbTypeInventoryTransactions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(258, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "ادارة جرد لحركات المخزون";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(-17, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "    عدد حركات جرد المخزون   :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInventoryTransactionsCount
            // 
            this.lbInventoryTransactionsCount.AutoSize = true;
            this.lbInventoryTransactionsCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbInventoryTransactionsCount.ForeColor = System.Drawing.Color.Green;
            this.lbInventoryTransactionsCount.Location = new System.Drawing.Point(230, 656);
            this.lbInventoryTransactionsCount.Name = "lbInventoryTransactionsCount";
            this.lbInventoryTransactionsCount.Size = new System.Drawing.Size(65, 29);
            this.lbInventoryTransactionsCount.TabIndex = 76;
            this.lbInventoryTransactionsCount.Text = "####";
            this.lbInventoryTransactionsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(376, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(299, 6);
            // 
            // ctmsInventoryTransactionsManagement
            // 
            this.ctmsInventoryTransactionsManagement.BackColor = System.Drawing.Color.White;
            this.ctmsInventoryTransactionsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsInventoryTransactionsManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsInventoryTransactionsManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsInventoryTransactionsManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsInventoryTransactionsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailInventoryTransactions,
            this.toolStripSeparator1,
            this.ctmsAddInventoryTransactions,
            this.ctmsEidtInventoryTransactions,
            this.ctmsDeleteInventoryTransactions,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsInventoryTransactionsManagement.Name = "ctmsPeopleManagement";
            this.ctmsInventoryTransactionsManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsInventoryTransactionsManagement.ShowCheckMargin = true;
            this.ctmsInventoryTransactionsManagement.Size = new System.Drawing.Size(303, 292);
            // 
            // ctmsDetailInventoryTransactions
            // 
            this.ctmsDetailInventoryTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailInventoryTransactions.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailInventoryTransactions.Name = "ctmsDetailInventoryTransactions";
            this.ctmsDetailInventoryTransactions.Size = new System.Drawing.Size(302, 46);
            this.ctmsDetailInventoryTransactions.Text = "تفاصيل  الجرد";
            this.ctmsDetailInventoryTransactions.Click += new System.EventHandler(this.ctmsDetailInventoryTransactions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(299, 6);
            // 
            // ctmsAddInventoryTransactions
            // 
            this.ctmsAddInventoryTransactions.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddInventoryTransactions.Name = "ctmsAddInventoryTransactions";
            this.ctmsAddInventoryTransactions.Size = new System.Drawing.Size(302, 46);
            this.ctmsAddInventoryTransactions.Text = "اضافه جردلحركات المخزون";
            this.ctmsAddInventoryTransactions.Click += new System.EventHandler(this.ctmsAddInventoryTransactions_Click);
            // 
            // ctmsEidtInventoryTransactions
            // 
            this.ctmsEidtInventoryTransactions.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtInventoryTransactions.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtInventoryTransactions.Image")));
            this.ctmsEidtInventoryTransactions.Name = "ctmsEidtInventoryTransactions";
            this.ctmsEidtInventoryTransactions.Size = new System.Drawing.Size(302, 46);
            this.ctmsEidtInventoryTransactions.Text = "تحديث معلومات  الجرد";
            this.ctmsEidtInventoryTransactions.Click += new System.EventHandler(this.ctmsEidtInventoryTransactions_Click);
            // 
            // ctmsDeleteInventoryTransactions
            // 
            this.ctmsDeleteInventoryTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsDeleteInventoryTransactions.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteInventoryTransactions.Image")));
            this.ctmsDeleteInventoryTransactions.Name = "ctmsDeleteInventoryTransactions";
            this.ctmsDeleteInventoryTransactions.Size = new System.Drawing.Size(302, 46);
            this.ctmsDeleteInventoryTransactions.Text = "حذف  الجرد";
            this.ctmsDeleteInventoryTransactions.Click += new System.EventHandler(this.ctmsDeleteInventoryTransactions_Click);
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(302, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(302, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
            // 
            // dgvAllInventoryTransactions
            // 
            this.dgvAllInventoryTransactions.AllowUserToAddRows = false;
            this.dgvAllInventoryTransactions.AllowUserToDeleteRows = false;
            this.dgvAllInventoryTransactions.AllowUserToOrderColumns = true;
            this.dgvAllInventoryTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllInventoryTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInventoryTransactions.ContextMenuStrip = this.ctmsInventoryTransactionsManagement;
            this.dgvAllInventoryTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllInventoryTransactions.Location = new System.Drawing.Point(16, 260);
            this.dgvAllInventoryTransactions.Name = "dgvAllInventoryTransactions";
            this.dgvAllInventoryTransactions.ReadOnly = true;
            this.dgvAllInventoryTransactions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllInventoryTransactions.Size = new System.Drawing.Size(724, 390);
            this.dgvAllInventoryTransactions.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "اضـافــة جرد للمخزون";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(619, 210);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 79;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterInventoryTransactionsInfo
            // 
            this.cmbFilterInventoryTransactionsInfo.FormattingEnabled = true;
            this.cmbFilterInventoryTransactionsInfo.Location = new System.Drawing.Point(495, 210);
            this.cmbFilterInventoryTransactionsInfo.Name = "cmbFilterInventoryTransactionsInfo";
            this.cmbFilterInventoryTransactionsInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterInventoryTransactionsInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterInventoryTransactionsInfo.TabIndex = 77;
            this.cmbFilterInventoryTransactionsInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterInventoryTransactionsInfo_SelectedIndexChanged);
            // 
            // pBoxInventoryTransactions
            // 
            this.pBoxInventoryTransactions.BackgroundImage = global::ETEZAN2024.Properties.Resources.checklist;
            this.pBoxInventoryTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxInventoryTransactions.Location = new System.Drawing.Point(318, 5);
            this.pBoxInventoryTransactions.Name = "pBoxInventoryTransactions";
            this.pBoxInventoryTransactions.Size = new System.Drawing.Size(89, 62);
            this.pBoxInventoryTransactions.TabIndex = 71;
            this.pBoxInventoryTransactions.TabStop = false;
            // 
            // pBoxAddInventoryTransactions
            // 
            this.pBoxAddInventoryTransactions.BackgroundImage = global::ETEZAN2024.Properties.Resources.warehouse;
            this.pBoxAddInventoryTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddInventoryTransactions.Location = new System.Drawing.Point(39, 170);
            this.pBoxAddInventoryTransactions.Name = "pBoxAddInventoryTransactions";
            this.pBoxAddInventoryTransactions.Size = new System.Drawing.Size(86, 46);
            this.pBoxAddInventoryTransactions.TabIndex = 73;
            this.pBoxAddInventoryTransactions.TabStop = false;
            this.pBoxAddInventoryTransactions.Click += new System.EventHandler(this.pBoxAddInventoryTransactions_Click);
            // 
            // frmInventoryTransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 693);
            this.Controls.Add(this.pBoxInventoryTransactions);
            this.Controls.Add(this.cmbTypeInventoryTransactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbInventoryTransactionsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllInventoryTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterInventoryTransactionsInfo);
            this.Controls.Add(this.pBoxAddInventoryTransactions);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventoryTransactionsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة جرد/حركات المخزون";
            this.Load += new System.EventHandler(this.frmInventoryTransactionsList_Load);
            this.ctmsInventoryTransactionsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInventoryTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInventoryTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddInventoryTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxInventoryTransactions;
        private System.Windows.Forms.ComboBox cmbTypeInventoryTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInventoryTransactionsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteInventoryTransactions;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtInventoryTransactions;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddInventoryTransactions;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailInventoryTransactions;
        private System.Windows.Forms.ContextMenuStrip ctmsInventoryTransactionsManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvAllInventoryTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterInventoryTransactionsInfo;
        private System.Windows.Forms.PictureBox pBoxAddInventoryTransactions;
    }
}