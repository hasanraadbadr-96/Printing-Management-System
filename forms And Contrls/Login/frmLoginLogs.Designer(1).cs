namespace ETEZAN2024.forms_And_Contrls.Login
{
    partial class frmLoginLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginLogs));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLoginLogsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAllLoginLogs = new System.Windows.Forms.DataGridView();
            this.ctmsLoginLogsManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbLoginLogsInfo = new System.Windows.Forms.ComboBox();
            this.pBoxProductInventories = new System.Windows.Forms.PictureBox();
            this.ctmsDetailLoginLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLoginLogs)).BeginInit();
            this.ctmsLoginLogsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductInventories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(256, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "سجلات عملية تسجيل الدخول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(-4, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "    عدد سجلات الدخول   :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbLoginLogsCount
            // 
            this.lbLoginLogsCount.AutoSize = true;
            this.lbLoginLogsCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbLoginLogsCount.ForeColor = System.Drawing.Color.Green;
            this.lbLoginLogsCount.Location = new System.Drawing.Point(195, 615);
            this.lbLoginLogsCount.Name = "lbLoginLogsCount";
            this.lbLoginLogsCount.Size = new System.Drawing.Size(65, 29);
            this.lbLoginLogsCount.TabIndex = 76;
            this.lbLoginLogsCount.Text = "####";
            this.lbLoginLogsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(21, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvAllLoginLogs
            // 
            this.dgvAllLoginLogs.AllowUserToAddRows = false;
            this.dgvAllLoginLogs.AllowUserToDeleteRows = false;
            this.dgvAllLoginLogs.AllowUserToOrderColumns = true;
            this.dgvAllLoginLogs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllLoginLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLoginLogs.ContextMenuStrip = this.ctmsLoginLogsManagement;
            this.dgvAllLoginLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllLoginLogs.Location = new System.Drawing.Point(5, 219);
            this.dgvAllLoginLogs.Name = "dgvAllLoginLogs";
            this.dgvAllLoginLogs.ReadOnly = true;
            this.dgvAllLoginLogs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllLoginLogs.Size = new System.Drawing.Size(787, 390);
            this.dgvAllLoginLogs.TabIndex = 74;
            // 
            // ctmsLoginLogsManagement
            // 
            this.ctmsLoginLogsManagement.BackColor = System.Drawing.Color.White;
            this.ctmsLoginLogsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsLoginLogsManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsLoginLogsManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsLoginLogsManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsLoginLogsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailLoginLog,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsLoginLogsManagement.Name = "ctmsPeopleManagement";
            this.ctmsLoginLogsManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsLoginLogsManagement.ShowCheckMargin = true;
            this.ctmsLoginLogsManagement.Size = new System.Drawing.Size(273, 154);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(264, 172);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 79;
            this.tbFilterValue.Visible = false;
            // 
            // cmbLoginLogsInfo
            // 
            this.cmbLoginLogsInfo.FormattingEnabled = true;
            this.cmbLoginLogsInfo.Location = new System.Drawing.Point(140, 172);
            this.cmbLoginLogsInfo.Name = "cmbLoginLogsInfo";
            this.cmbLoginLogsInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLoginLogsInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbLoginLogsInfo.TabIndex = 77;
            // 
            // pBoxProductInventories
            // 
            this.pBoxProductInventories.BackgroundImage = global::ETEZAN2024.Properties.Resources.monitoring;
            this.pBoxProductInventories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxProductInventories.Location = new System.Drawing.Point(327, 16);
            this.pBoxProductInventories.Name = "pBoxProductInventories";
            this.pBoxProductInventories.Size = new System.Drawing.Size(89, 62);
            this.pBoxProductInventories.TabIndex = 71;
            this.pBoxProductInventories.TabStop = false;
            // 
            // ctmsDetailLoginLog
            // 
            this.ctmsDetailLoginLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailLoginLog.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailLoginLog.Name = "ctmsDetailLoginLog";
            this.ctmsDetailLoginLog.Size = new System.Drawing.Size(272, 46);
            this.ctmsDetailLoginLog.Text = "تفاصيل تسجيل الدخول";
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(272, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(272, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
            // 
            // frmLoginLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.pBoxProductInventories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLoginLogsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllLoginLogs);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbLoginLogsInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginLogs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجلات الدخول";
            this.Load += new System.EventHandler(this.frmLoginLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLoginLogs)).EndInit();
            this.ctmsLoginLogsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductInventories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxProductInventories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLoginLogsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAllLoginLogs;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbLoginLogsInfo;
        private System.Windows.Forms.ContextMenuStrip ctmsLoginLogsManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailLoginLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
    }
}