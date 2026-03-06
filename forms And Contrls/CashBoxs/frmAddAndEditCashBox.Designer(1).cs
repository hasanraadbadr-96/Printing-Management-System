namespace ETEZAN2024.forms_And_Contrls.CashBoxs
{
    partial class frmAddAndEditCashBox
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
            this.btaCansel2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.errorProviderCashBoxes = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbbox_balance = new System.Windows.Forms.TextBox();
            this.tbbox_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbCashBoxID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbdeposited_amount = new System.Windows.Forms.TextBox();
            this.ltbwithdrawn_amount = new System.Windows.Forms.TextBox();
            this.cmbPartnership_percentage = new System.Windows.Forms.ComboBox();
            this.dtpDeposit_date = new System.Windows.Forms.DateTimePicker();
            this.dtpWithdrawal_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCashBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(548, 510);
            this.btaCansel2.Name = "btaCansel2";
            this.btaCansel2.Size = new System.Drawing.Size(109, 34);
            this.btaCansel2.TabIndex = 8;
            this.btaCansel2.Text = "الـلـغــاء";
            this.btaCansel2.UseVisualStyleBackColor = true;
            this.btaCansel2.Click += new System.EventHandler(this.btaCansel2_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(433, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حـفــظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbAddAndEdit
            // 
            this.lbAddAndEdit.AutoSize = true;
            this.lbAddAndEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbAddAndEdit.Location = new System.Drawing.Point(210, 9);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.Size = new System.Drawing.Size(173, 44);
            this.lbAddAndEdit.TabIndex = 122;
            this.lbAddAndEdit.Text = "اضافة صندوق";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProviderCashBoxes
            // 
            this.errorProviderCashBoxes.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderCashBoxes.ContainerControl = this;
            // 
            // tbbox_balance
            // 
            this.tbbox_balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbbox_balance.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbbox_balance.ForeColor = System.Drawing.Color.Chocolate;
            this.tbbox_balance.Location = new System.Drawing.Point(218, 193);
            this.tbbox_balance.Name = "tbbox_balance";
            this.tbbox_balance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbbox_balance.Size = new System.Drawing.Size(237, 32);
            this.tbbox_balance.TabIndex = 1;
            this.tbbox_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbbox_balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbox_balance_KeyPress);
            this.tbbox_balance.Validating += new System.ComponentModel.CancelEventHandler(this.tbbox_balance_Validating);
            // 
            // tbbox_name
            // 
            this.tbbox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbbox_name.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbbox_name.ForeColor = System.Drawing.Color.Chocolate;
            this.tbbox_name.Location = new System.Drawing.Point(218, 141);
            this.tbbox_name.Name = "tbbox_name";
            this.tbbox_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbbox_name.Size = new System.Drawing.Size(237, 32);
            this.tbbox_name.TabIndex = 0;
            this.tbbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbbox_name.Validating += new System.ComponentModel.CancelEventHandler(this.tbbox_name_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(28, 196);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(136, 29);
            this.label10.TabIndex = 194;
            this.label10.Text = " : رصيد الصندوق";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(29, 248);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(134, 29);
            this.label8.TabIndex = 193;
            this.label8.Text = " : نسبة الصندوق";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(32, 300);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 192;
            this.label4.Text = " المبلغ المودوع :\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(21, 352);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(150, 29);
            this.label5.TabIndex = 191;
            this.label5.Text = " :  المبلغ المسحوب ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(29, 90);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 190;
            this.label9.Text = " : معرف الصندوق";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(36, 404);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(121, 29);
            this.label11.TabIndex = 189;
            this.label11.Text = " : تاريخ الايداع";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(32, 144);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(128, 29);
            this.label12.TabIndex = 188;
            this.label12.Text = " :اســـم الصندوق";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCashBoxID
            // 
            this.lbCashBoxID.AutoSize = true;
            this.lbCashBoxID.BackColor = System.Drawing.Color.Transparent;
            this.lbCashBoxID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbCashBoxID.ForeColor = System.Drawing.Color.Black;
            this.lbCashBoxID.Location = new System.Drawing.Point(279, 90);
            this.lbCashBoxID.Name = "lbCashBoxID";
            this.lbCashBoxID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCashBoxID.Size = new System.Drawing.Size(78, 29);
            this.lbCashBoxID.TabIndex = 183;
            this.lbCashBoxID.Text = "#####";
            this.lbCashBoxID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(37, 456);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 198;
            this.label1.Text = " : تاريخ السحب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbdeposited_amount
            // 
            this.tbdeposited_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdeposited_amount.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbdeposited_amount.ForeColor = System.Drawing.Color.Chocolate;
            this.tbdeposited_amount.Location = new System.Drawing.Point(218, 297);
            this.tbdeposited_amount.Name = "tbdeposited_amount";
            this.tbdeposited_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbdeposited_amount.Size = new System.Drawing.Size(237, 32);
            this.tbdeposited_amount.TabIndex = 3;
            this.tbdeposited_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbdeposited_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbdeposited_amount_KeyPress);
            this.tbdeposited_amount.Validating += new System.ComponentModel.CancelEventHandler(this.tbdeposited_amount_Validating);
            // 
            // ltbwithdrawn_amount
            // 
            this.ltbwithdrawn_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbwithdrawn_amount.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ltbwithdrawn_amount.ForeColor = System.Drawing.Color.Chocolate;
            this.ltbwithdrawn_amount.Location = new System.Drawing.Point(218, 349);
            this.ltbwithdrawn_amount.Name = "ltbwithdrawn_amount";
            this.ltbwithdrawn_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ltbwithdrawn_amount.Size = new System.Drawing.Size(237, 32);
            this.ltbwithdrawn_amount.TabIndex = 4;
            this.ltbwithdrawn_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ltbwithdrawn_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ltbwithdrawn_amount_KeyPress);
            this.ltbwithdrawn_amount.Validating += new System.ComponentModel.CancelEventHandler(this.ltbwithdrawn_amount_Validating);
            // 
            // cmbPartnership_percentage
            // 
            this.cmbPartnership_percentage.FormattingEnabled = true;
            this.cmbPartnership_percentage.Location = new System.Drawing.Point(218, 252);
            this.cmbPartnership_percentage.Name = "cmbPartnership_percentage";
            this.cmbPartnership_percentage.Size = new System.Drawing.Size(237, 21);
            this.cmbPartnership_percentage.TabIndex = 2;
            // 
            // dtpDeposit_date
            // 
            this.dtpDeposit_date.Location = new System.Drawing.Point(218, 413);
            this.dtpDeposit_date.Name = "dtpDeposit_date";
            this.dtpDeposit_date.Size = new System.Drawing.Size(237, 20);
            this.dtpDeposit_date.TabIndex = 5;
            // 
            // dtpWithdrawal_date
            // 
            this.dtpWithdrawal_date.Location = new System.Drawing.Point(218, 465);
            this.dtpWithdrawal_date.Name = "dtpWithdrawal_date";
            this.dtpWithdrawal_date.Size = new System.Drawing.Size(237, 20);
            this.dtpWithdrawal_date.TabIndex = 6;
            // 
            // frmAddAndEditCashBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 565);
            this.Controls.Add(this.dtpWithdrawal_date);
            this.Controls.Add(this.dtpDeposit_date);
            this.Controls.Add(this.cmbPartnership_percentage);
            this.Controls.Add(this.ltbwithdrawn_amount);
            this.Controls.Add(this.tbdeposited_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbCashBoxID);
            this.Controls.Add(this.btaCansel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAddAndEdit);
            this.Controls.Add(this.tbbox_balance);
            this.Controls.Add(this.tbbox_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditCashBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل صندوق";
            this.Load += new System.EventHandler(this.frmAddAndEditCashBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCashBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.ErrorProvider errorProviderCashBoxes;
        private System.Windows.Forms.TextBox tbbox_balance;
        private System.Windows.Forms.TextBox tbbox_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbCashBoxID;
        private System.Windows.Forms.TextBox ltbwithdrawn_amount;
        private System.Windows.Forms.TextBox tbdeposited_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPartnership_percentage;
        private System.Windows.Forms.DateTimePicker dtpDeposit_date;
        private System.Windows.Forms.DateTimePicker dtpWithdrawal_date;
    }
}