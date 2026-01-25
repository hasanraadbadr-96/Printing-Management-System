namespace ETEZAN2024.forms_And_Contrls.Users.form
{
    partial class frmChangePasswordUser
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
            this.btnSaveUserInfo = new System.Windows.Forms.Button();
            this.tbConfirmPasswerd = new System.Windows.Forms.TextBox();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lbConfrimPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderChangePassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserCard1 = new ETEZAN2024.forms_And_Contrls.Users.control.ctrlUserCard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(18, 505);
            this.btaCansel2.Name = "btaCansel2";
            this.btaCansel2.Size = new System.Drawing.Size(109, 34);
            this.btaCansel2.TabIndex = 34;
            this.btaCansel2.Text = "الـلـغــاء";
            this.btaCansel2.UseVisualStyleBackColor = true;
            this.btaCansel2.Click += new System.EventHandler(this.btaCansel2_Click);
            // 
            // btnSaveUserInfo
            // 
            this.btnSaveUserInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveUserInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveUserInfo.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveUserInfo.Location = new System.Drawing.Point(158, 505);
            this.btnSaveUserInfo.Name = "btnSaveUserInfo";
            this.btnSaveUserInfo.Size = new System.Drawing.Size(109, 34);
            this.btnSaveUserInfo.TabIndex = 33;
            this.btnSaveUserInfo.Text = "حـفــظ";
            this.btnSaveUserInfo.UseVisualStyleBackColor = true;
            this.btnSaveUserInfo.Click += new System.EventHandler(this.btnSaveUserInfo_Click);
            // 
            // tbConfirmPasswerd
            // 
            this.tbConfirmPasswerd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPasswerd.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbConfirmPasswerd.ForeColor = System.Drawing.Color.Chocolate;
            this.tbConfirmPasswerd.Location = new System.Drawing.Point(13, 466);
            this.tbConfirmPasswerd.Name = "tbConfirmPasswerd";
            this.tbConfirmPasswerd.Size = new System.Drawing.Size(118, 32);
            this.tbConfirmPasswerd.TabIndex = 30;
            this.tbConfirmPasswerd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmPasswerd.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPasswerd_Validating);
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentPassword.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbCurrentPassword.ForeColor = System.Drawing.Color.Chocolate;
            this.tbCurrentPassword.Location = new System.Drawing.Point(591, 466);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(118, 32);
            this.tbCurrentPassword.TabIndex = 29;
            this.tbCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // lbConfrimPassword
            // 
            this.lbConfrimPassword.AutoSize = true;
            this.lbConfrimPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbConfrimPassword.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbConfrimPassword.ForeColor = System.Drawing.Color.Gray;
            this.lbConfrimPassword.Location = new System.Drawing.Point(156, 470);
            this.lbConfrimPassword.Name = "lbConfrimPassword";
            this.lbConfrimPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbConfrimPassword.Size = new System.Drawing.Size(138, 25);
            this.lbConfrimPassword.TabIndex = 32;
            this.lbConfrimPassword.Text = "  تأكـيـد الــــرمـــــز :";
            this.lbConfrimPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(723, 470);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = " : الــــرمـــــز الحالي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPassword.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbNewPassword.ForeColor = System.Drawing.Color.Chocolate;
            this.tbNewPassword.Location = new System.Drawing.Point(314, 466);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(118, 32);
            this.tbNewPassword.TabIndex = 35;
            this.tbNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(443, 470);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = " : الــــرمـــــز الجديد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(351, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "تغيير رمز المستخدم";
            // 
            // errorProviderChangePassword
            // 
            this.errorProviderChangePassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderChangePassword.ContainerControl = this;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlUserCard1.Location = new System.Drawing.Point(47, 38);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(763, 415);
            this.ctrlUserCard1.TabIndex = 39;
            // 
            // frmChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(856, 544);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btaCansel2);
            this.Controls.Add(this.btnSaveUserInfo);
            this.Controls.Add(this.tbConfirmPasswerd);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.lbConfrimPassword);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePasswordUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير رمز المستخدم";
            this.Load += new System.EventHandler(this.frmChangePasswordUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Button btnSaveUserInfo;
        private System.Windows.Forms.TextBox tbConfirmPasswerd;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lbConfrimPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private control.ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.ErrorProvider errorProviderChangePassword;
    }
}