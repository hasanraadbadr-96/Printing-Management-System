namespace ETEZAN2024
{
    partial class frmDebtsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebtsList));
            this.cmbIsDebtStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDebtsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsDebtsManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllDebts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterDebtInfo = new System.Windows.Forms.ComboBox();
            this.pBoxDebt = new System.Windows.Forms.PictureBox();
            this.pBoxAddDebt = new System.Windows.Forms.PictureBox();
            this.ctmsDebtsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDebts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddDebt)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIsDebtStatus
            // 
            this.cmbIsDebtStatus.FormattingEnabled = true;
            this.cmbIsDebtStatus.Location = new System.Drawing.Point(775, 218);
            this.cmbIsDebtStatus.Name = "cmbIsDebtStatus";
            this.cmbIsDebtStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsDebtStatus.Size = new System.Drawing.Size(79, 21);
            this.cmbIsDebtStatus.TabIndex = 80;
            this.cmbIsDebtStatus.Visible = false;
            this.cmbIsDebtStatus.SelectedIndexChanged += new System.EventHandler(this.cmbIsDebtStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(445, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 70;
            this.label1.Text = "ادارة الديون";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(-4, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "    عدد  المدينين   :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDebtsCount
            // 
            this.lbDebtsCount.AutoSize = true;
            this.lbDebtsCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDebtsCount.ForeColor = System.Drawing.Color.Green;
            this.lbDebtsCount.Location = new System.Drawing.Point(195, 641);
            this.lbDebtsCount.Name = "lbDebtsCount";
            this.lbDebtsCount.Size = new System.Drawing.Size(65, 29);
            this.lbDebtsCount.TabIndex = 76;
            this.lbDebtsCount.Text = "####";
            this.lbDebtsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(617, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // ctmsDebtsManagement
            // 
            this.ctmsDebtsManagement.BackColor = System.Drawing.Color.White;
            this.ctmsDebtsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsDebtsManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsDebtsManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsDebtsManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsDebtsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailDebt,
            this.toolStripSeparator1,
            this.ctmsAddDebt,
            this.ctmsEidtDebt,
            this.ctmsDeleteDebt,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsDebtsManagement.Name = "ctmsPeopleManagement";
            this.ctmsDebtsManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsDebtsManagement.ShowCheckMargin = true;
            this.ctmsDebtsManagement.Size = new System.Drawing.Size(267, 292);
            // 
            // ctmsDetailDebt
            // 
            this.ctmsDetailDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailDebt.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailDebt.Name = "ctmsDetailDebt";
            this.ctmsDetailDebt.Size = new System.Drawing.Size(266, 46);
            this.ctmsDetailDebt.Text = "تفاصيل  الدين";
            this.ctmsDetailDebt.Click += new System.EventHandler(this.ctmsDetailDebt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // ctmsAddDebt
            // 
            this.ctmsAddDebt.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddDebt.Name = "ctmsAddDebt";
            this.ctmsAddDebt.Size = new System.Drawing.Size(266, 46);
            this.ctmsAddDebt.Text = "اضافه  دين";
            this.ctmsAddDebt.Click += new System.EventHandler(this.ctmsAddDebt_Click);
            // 
            // ctmsEidtDebt
            // 
            this.ctmsEidtDebt.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtDebt.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtDebt.Image")));
            this.ctmsEidtDebt.Name = "ctmsEidtDebt";
            this.ctmsEidtDebt.Size = new System.Drawing.Size(266, 46);
            this.ctmsEidtDebt.Text = "تحديث معلومات  الدين";
            this.ctmsEidtDebt.Click += new System.EventHandler(this.ctmsEidtDebt_Click);
            // 
            // ctmsDeleteDebt
            // 
            this.ctmsDeleteDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsDeleteDebt.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteDebt.Image")));
            this.ctmsDeleteDebt.Name = "ctmsDeleteDebt";
            this.ctmsDeleteDebt.Size = new System.Drawing.Size(266, 46);
            this.ctmsDeleteDebt.Text = "حذف  الدين";
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(266, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(266, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
            // 
            // dgvAllDebts
            // 
            this.dgvAllDebts.AllowUserToAddRows = false;
            this.dgvAllDebts.AllowUserToDeleteRows = false;
            this.dgvAllDebts.AllowUserToOrderColumns = true;
            this.dgvAllDebts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDebts.ContextMenuStrip = this.ctmsDebtsManagement;
            this.dgvAllDebts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllDebts.Location = new System.Drawing.Point(5, 245);
            this.dgvAllDebts.Name = "dgvAllDebts";
            this.dgvAllDebts.ReadOnly = true;
            this.dgvAllDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllDebts.Size = new System.Drawing.Size(979, 390);
            this.dgvAllDebts.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "اضـافــة دين";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(860, 194);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 79;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterDebtInfo
            // 
            this.cmbFilterDebtInfo.FormattingEnabled = true;
            this.cmbFilterDebtInfo.Location = new System.Drawing.Point(736, 194);
            this.cmbFilterDebtInfo.Name = "cmbFilterDebtInfo";
            this.cmbFilterDebtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterDebtInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterDebtInfo.TabIndex = 77;
            this.cmbFilterDebtInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDebtInfo_SelectedIndexChanged);
            // 
            // pBoxDebt
            // 
            this.pBoxDebt.BackgroundImage = global::ETEZAN2024.Properties.Resources.DebtsList;
            this.pBoxDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxDebt.Location = new System.Drawing.Point(462, 8);
            this.pBoxDebt.Name = "pBoxDebt";
            this.pBoxDebt.Size = new System.Drawing.Size(89, 62);
            this.pBoxDebt.TabIndex = 71;
            this.pBoxDebt.TabStop = false;
            // 
            // pBoxAddDebt
            // 
            this.pBoxAddDebt.BackgroundImage = global::ETEZAN2024.Properties.Resources.borrowing;
            this.pBoxAddDebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddDebt.Location = new System.Drawing.Point(30, 155);
            this.pBoxAddDebt.Name = "pBoxAddDebt";
            this.pBoxAddDebt.Size = new System.Drawing.Size(86, 46);
            this.pBoxAddDebt.TabIndex = 73;
            this.pBoxAddDebt.TabStop = false;
            this.pBoxAddDebt.Click += new System.EventHandler(this.pBoxAddDebt_Click);
            // 
            // frmDebtsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 678);
            this.Controls.Add(this.pBoxDebt);
            this.Controls.Add(this.cmbIsDebtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDebtsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllDebts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterDebtInfo);
            this.Controls.Add(this.pBoxAddDebt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDebtsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الديون";
            this.Load += new System.EventHandler(this.frmDebtsList_Load);
            this.ctmsDebtsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDebts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddDebt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxDebt;
        private System.Windows.Forms.ComboBox cmbIsDebtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDebtsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteDebt;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtDebt;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddDebt;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailDebt;
        private System.Windows.Forms.ContextMenuStrip ctmsDebtsManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvAllDebts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterDebtInfo;
        private System.Windows.Forms.PictureBox pBoxAddDebt;
    }
}