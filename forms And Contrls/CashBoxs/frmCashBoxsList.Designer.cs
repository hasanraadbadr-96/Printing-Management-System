namespace ETEZAN2024.forms_And_Contrls.CashBoxs
{
    partial class frmCashBoxsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashBoxsList));
            this.dgvAllCashBoxs = new System.Windows.Forms.DataGridView();
            this.ctmsCashBoxsManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailCashBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddCashBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtCashBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteCashBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.cmbFilterCashBoxInfo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCashBoxsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pBoxAddCashBox = new System.Windows.Forms.PictureBox();
            this.pBoxCashBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCashBoxs)).BeginInit();
            this.ctmsCashBoxsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddCashBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCashBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllCashBoxs
            // 
            this.dgvAllCashBoxs.AllowUserToAddRows = false;
            this.dgvAllCashBoxs.AllowUserToDeleteRows = false;
            this.dgvAllCashBoxs.AllowUserToOrderColumns = true;
            this.dgvAllCashBoxs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllCashBoxs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCashBoxs.ContextMenuStrip = this.ctmsCashBoxsManagement;
            this.dgvAllCashBoxs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllCashBoxs.Location = new System.Drawing.Point(14, 244);
            this.dgvAllCashBoxs.Name = "dgvAllCashBoxs";
            this.dgvAllCashBoxs.ReadOnly = true;
            this.dgvAllCashBoxs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllCashBoxs.Size = new System.Drawing.Size(979, 390);
            this.dgvAllCashBoxs.TabIndex = 85;
            // 
            // ctmsCashBoxsManagement
            // 
            this.ctmsCashBoxsManagement.BackColor = System.Drawing.Color.White;
            this.ctmsCashBoxsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsCashBoxsManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsCashBoxsManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsCashBoxsManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsCashBoxsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailCashBox,
            this.toolStripSeparator1,
            this.ctmsAddCashBox,
            this.ctmsEidtCashBox,
            this.ctmsDeleteCashBox,
            this.toolStripSeparator2});
            this.ctmsCashBoxsManagement.Name = "ctmsPeopleManagement";
            this.ctmsCashBoxsManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsCashBoxsManagement.ShowCheckMargin = true;
            this.ctmsCashBoxsManagement.Size = new System.Drawing.Size(290, 200);
            // 
            // ctmsDetailCashBox
            // 
            this.ctmsDetailCashBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailCashBox.Image = global::ETEZAN2024.Properties.Resources.orders;
            this.ctmsDetailCashBox.Name = "ctmsDetailCashBox";
            this.ctmsDetailCashBox.Size = new System.Drawing.Size(289, 46);
            this.ctmsDetailCashBox.Text = "تفاصيل  الصندو ق";
            this.ctmsDetailCashBox.Click += new System.EventHandler(this.ctmsDetailCashBox_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // ctmsAddCashBox
            // 
            this.ctmsAddCashBox.Image = global::ETEZAN2024.Properties.Resources.add_Order;
            this.ctmsAddCashBox.Name = "ctmsAddCashBox";
            this.ctmsAddCashBox.Size = new System.Drawing.Size(289, 46);
            this.ctmsAddCashBox.Text = "اضافه صندو ق";
            this.ctmsAddCashBox.Click += new System.EventHandler(this.ctmsAddCashBox_Click);
            // 
            // ctmsEidtCashBox
            // 
            this.ctmsEidtCashBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ctmsEidtCashBox.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtCashBox.Image")));
            this.ctmsEidtCashBox.Name = "ctmsEidtCashBox";
            this.ctmsEidtCashBox.Size = new System.Drawing.Size(289, 46);
            this.ctmsEidtCashBox.Text = "تحديث معلومات  الصندو ق";
            this.ctmsEidtCashBox.Click += new System.EventHandler(this.ctmsEidtCashBox_Click);
            // 
            // ctmsDeleteCashBox
            // 
            this.ctmsDeleteCashBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctmsDeleteCashBox.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteCashBox.Image")));
            this.ctmsDeleteCashBox.Name = "ctmsDeleteCashBox";
            this.ctmsDeleteCashBox.Size = new System.Drawing.Size(289, 46);
            this.ctmsDeleteCashBox.Text = "حذف الصندو ق";
            this.ctmsDeleteCashBox.Click += new System.EventHandler(this.ctmsDeleteCashBox_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(29, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "اضـافــة صندوق";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(869, 193);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 90;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // cmbFilterCashBoxInfo
            // 
            this.cmbFilterCashBoxInfo.FormattingEnabled = true;
            this.cmbFilterCashBoxInfo.Location = new System.Drawing.Point(745, 193);
            this.cmbFilterCashBoxInfo.Name = "cmbFilterCashBoxInfo";
            this.cmbFilterCashBoxInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFilterCashBoxInfo.Size = new System.Drawing.Size(118, 21);
            this.cmbFilterCashBoxInfo.TabIndex = 88;
            this.cmbFilterCashBoxInfo.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCashBoxInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(415, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 81;
            this.label1.Text = "ادارة صناديق الاموال";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(-14, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 86;
            this.label4.Text = "    عدد صناديق الاموال   :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCashBoxsCount
            // 
            this.lbCashBoxsCount.AutoSize = true;
            this.lbCashBoxsCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbCashBoxsCount.ForeColor = System.Drawing.Color.Green;
            this.lbCashBoxsCount.Location = new System.Drawing.Point(188, 646);
            this.lbCashBoxsCount.Name = "lbCashBoxsCount";
            this.lbCashBoxsCount.Size = new System.Drawing.Size(65, 29);
            this.lbCashBoxsCount.TabIndex = 87;
            this.lbCashBoxsCount.Text = "####";
            this.lbCashBoxsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(626, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBoxAddCashBox
            // 
            this.pBoxAddCashBox.BackgroundImage = global::ETEZAN2024.Properties.Resources.borrowing;
            this.pBoxAddCashBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddCashBox.Location = new System.Drawing.Point(39, 154);
            this.pBoxAddCashBox.Name = "pBoxAddCashBox";
            this.pBoxAddCashBox.Size = new System.Drawing.Size(86, 46);
            this.pBoxAddCashBox.TabIndex = 84;
            this.pBoxAddCashBox.TabStop = false;
            this.pBoxAddCashBox.Click += new System.EventHandler(this.pBoxAddCashBox_Click);
            // 
            // pBoxCashBox
            // 
            this.pBoxCashBox.BackgroundImage = global::ETEZAN2024.Properties.Resources.DebtsList;
            this.pBoxCashBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxCashBox.Location = new System.Drawing.Point(471, 7);
            this.pBoxCashBox.Name = "pBoxCashBox";
            this.pBoxCashBox.Size = new System.Drawing.Size(89, 62);
            this.pBoxCashBox.TabIndex = 82;
            this.pBoxCashBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(676, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 29);
            this.label5.TabIndex = 104;
            this.label5.Text = "مجموع اموال الصناديق     :\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.Green;
            this.lbTotalAmount.Location = new System.Drawing.Point(896, 646);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(50, 23);
            this.lbTotalAmount.TabIndex = 105;
            this.lbTotalAmount.Text = "####";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCashBoxsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.dgvAllCashBoxs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.cmbFilterCashBoxInfo);
            this.Controls.Add(this.pBoxAddCashBox);
            this.Controls.Add(this.pBoxCashBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCashBoxsCount);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashBoxsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة صناديق لاموال";
            this.Load += new System.EventHandler(this.frmCashBoxsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCashBoxs)).EndInit();
            this.ctmsCashBoxsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddCashBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCashBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllCashBoxs;
        private System.Windows.Forms.ContextMenuStrip ctmsCashBoxsManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailCashBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddCashBox;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtCashBox;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteCashBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.ComboBox cmbFilterCashBoxInfo;
        private System.Windows.Forms.PictureBox pBoxAddCashBox;
        private System.Windows.Forms.PictureBox pBoxCashBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCashBoxsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTotalAmount;
    }
}