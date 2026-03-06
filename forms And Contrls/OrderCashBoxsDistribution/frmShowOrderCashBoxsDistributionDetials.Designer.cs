namespace ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution
{
    partial class frmShowOrderCashBoxsDistributionDetials
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
            this.dtpPending = new System.Windows.Forms.DateTimePicker();
            this.dtpAdded = new System.Windows.Forms.DateTimePicker();
            this.rbAdded = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btaCansel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbOrderCashBoxsDistributionLID = new System.Windows.Forms.Label();
            this.lnkEditProductPrice = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dtpPending
            // 
            this.dtpPending.Enabled = false;
            this.dtpPending.Location = new System.Drawing.Point(195, 368);
            this.dtpPending.Name = "dtpPending";
            this.dtpPending.Size = new System.Drawing.Size(237, 20);
            this.dtpPending.TabIndex = 153;
            // 
            // dtpAdded
            // 
            this.dtpAdded.Enabled = false;
            this.dtpAdded.Location = new System.Drawing.Point(195, 320);
            this.dtpAdded.Name = "dtpAdded";
            this.dtpAdded.Size = new System.Drawing.Size(237, 20);
            this.dtpAdded.TabIndex = 152;
            // 
            // rbAdded
            // 
            this.rbAdded.AutoSize = true;
            this.rbAdded.BackColor = System.Drawing.Color.Transparent;
            this.rbAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAdded.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbAdded.ForeColor = System.Drawing.Color.Teal;
            this.rbAdded.Location = new System.Drawing.Point(191, 249);
            this.rbAdded.Name = "rbAdded";
            this.rbAdded.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbAdded.Size = new System.Drawing.Size(113, 33);
            this.rbAdded.TabIndex = 151;
            this.rbAdded.Text = "تم الترحيل";
            this.rbAdded.UseVisualStyleBackColor = false;
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.BackColor = System.Drawing.Color.Transparent;
            this.rbPending.Checked = true;
            this.rbPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPending.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbPending.Location = new System.Drawing.Point(327, 249);
            this.rbPending.Name = "rbPending";
            this.rbPending.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbPending.Size = new System.Drawing.Size(122, 33);
            this.rbPending.TabIndex = 150;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "قيد الترحيل";
            this.rbPending.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 359);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 149;
            this.label4.Text = " : تاريخ التحديث";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 147;
            this.label3.Text = " : رقم الطلب";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lbOrderID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrderID.ForeColor = System.Drawing.Color.Black;
            this.lbOrderID.Location = new System.Drawing.Point(254, 137);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOrderID.Size = new System.Drawing.Size(78, 29);
            this.lbOrderID.TabIndex = 148;
            this.lbOrderID.Text = "#####";
            this.lbOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 311);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 144;
            this.label6.Text = " : تاريخ الاضافة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(473, 422);
            this.btaCansel2.Name = "btaCansel2";
            this.btaCansel2.Size = new System.Drawing.Size(109, 34);
            this.btaCansel2.TabIndex = 139;
            this.btaCansel2.Text = "الـلـغــاء";
            this.btaCansel2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 142;
            this.label2.Text = " : معرف المعرف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 189);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 141;
            this.label1.Text = " : المبلغ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAddAndEdit
            // 
            this.lbAddAndEdit.AutoSize = true;
            this.lbAddAndEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbAddAndEdit.Location = new System.Drawing.Point(197, 3);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.Size = new System.Drawing.Size(199, 44);
            this.lbAddAndEdit.TabIndex = 140;
            this.lbAddAndEdit.Text = "تفاصيل الترحيل";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(40, 251);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 146;
            this.label7.Text = " : الحالة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAmount
            // 
            this.tbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAmount.Enabled = false;
            this.tbAmount.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbAmount.ForeColor = System.Drawing.Color.Chocolate;
            this.tbAmount.Location = new System.Drawing.Point(195, 187);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAmount.Size = new System.Drawing.Size(237, 32);
            this.tbAmount.TabIndex = 145;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbOrderCashBoxsDistributionLID
            // 
            this.lbOrderCashBoxsDistributionLID.AutoSize = true;
            this.lbOrderCashBoxsDistributionLID.BackColor = System.Drawing.Color.Transparent;
            this.lbOrderCashBoxsDistributionLID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrderCashBoxsDistributionLID.ForeColor = System.Drawing.Color.Black;
            this.lbOrderCashBoxsDistributionLID.Location = new System.Drawing.Point(254, 84);
            this.lbOrderCashBoxsDistributionLID.Name = "lbOrderCashBoxsDistributionLID";
            this.lbOrderCashBoxsDistributionLID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOrderCashBoxsDistributionLID.Size = new System.Drawing.Size(78, 29);
            this.lbOrderCashBoxsDistributionLID.TabIndex = 143;
            this.lbOrderCashBoxsDistributionLID.Text = "#####";
            this.lbOrderCashBoxsDistributionLID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkEditProductPrice
            // 
            this.lnkEditProductPrice.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkEditProductPrice.AutoSize = true;
            this.lnkEditProductPrice.BackColor = System.Drawing.Color.Transparent;
            this.lnkEditProductPrice.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnkEditProductPrice.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnkEditProductPrice.ForeColor = System.Drawing.Color.DarkCyan;
            this.lnkEditProductPrice.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkEditProductPrice.Location = new System.Drawing.Point(406, 81);
            this.lnkEditProductPrice.Name = "lnkEditProductPrice";
            this.lnkEditProductPrice.Size = new System.Drawing.Size(187, 32);
            this.lnkEditProductPrice.TabIndex = 154;
            this.lnkEditProductPrice.TabStop = true;
            this.lnkEditProductPrice.Text = "تعديل معلومات المنتج";
            this.lnkEditProductPrice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditProductPrice_LinkClicked);
            // 
            // frmShowOrderCashBoxsDistributionDetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 472);
            this.Controls.Add(this.lnkEditProductPrice);
            this.Controls.Add(this.dtpPending);
            this.Controls.Add(this.dtpAdded);
            this.Controls.Add(this.rbAdded);
            this.Controls.Add(this.rbPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btaCansel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddAndEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbOrderCashBoxsDistributionLID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowOrderCashBoxsDistributionDetials";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الترحيل";
            this.Load += new System.EventHandler(this.frmShowOrderCashBoxsDistributionDetials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPending;
        private System.Windows.Forms.DateTimePicker dtpAdded;
        private System.Windows.Forms.RadioButton rbAdded;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbOrderCashBoxsDistributionLID;
        private System.Windows.Forms.LinkLabel lnkEditProductPrice;
    }
}