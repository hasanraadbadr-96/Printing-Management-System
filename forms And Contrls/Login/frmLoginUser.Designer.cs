namespace ETEZAN2024
{
    partial class frmLoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUser));
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTboxPasswerd = new System.Windows.Forms.MaskedTextBox();
            this.TboxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PboxEyePasswerd = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.PboxIconYoutbe = new System.Windows.Forms.PictureBox();
            this.btnIconYoutbe = new System.Windows.Forms.Button();
            this.notificatoinLoginUeser = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbTimerConter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarLogin = new System.Windows.Forms.ProgressBar();
            this.lbPrecentLogin = new System.Windows.Forms.Label();
            this.lbprogressBarLogin = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PboxRightMarkUserName = new System.Windows.Forms.PictureBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chRemberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PboxEyePasswerd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxIconYoutbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxRightMarkUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // maskedTboxPasswerd
            // 
            this.maskedTboxPasswerd.BackColor = System.Drawing.Color.Gray;
            this.maskedTboxPasswerd.BeepOnError = true;
            resources.ApplyResources(this.maskedTboxPasswerd, "maskedTboxPasswerd");
            this.maskedTboxPasswerd.ForeColor = System.Drawing.SystemColors.Menu;
            this.maskedTboxPasswerd.Name = "maskedTboxPasswerd";
            this.maskedTboxPasswerd.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.maskedTboxPasswerd.UseSystemPasswordChar = true;
            this.maskedTboxPasswerd.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTboxPasswerd_Validating);
            // 
            // TboxUserName
            // 
            this.TboxUserName.BackColor = System.Drawing.Color.Gray;
            this.TboxUserName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.TboxUserName, "TboxUserName");
            this.TboxUserName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.TboxUserName.Name = "TboxUserName";
            this.TboxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TboxUserName_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // PboxEyePasswerd
            // 
            this.PboxEyePasswerd.Image = global::ETEZAN2024.Properties.Resources.EYE;
            resources.ApplyResources(this.PboxEyePasswerd, "PboxEyePasswerd");
            this.PboxEyePasswerd.Name = "PboxEyePasswerd";
            this.PboxEyePasswerd.TabStop = false;
            this.PboxEyePasswerd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PboxEyePasswerd_MouseDown);
            this.PboxEyePasswerd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PboxEyePasswerd_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ETEZAN2024.Properties.Resources.AL_HAMDLA;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ETEZAN2024.Properties.Resources.Line;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.BackColor = System.Drawing.Color.White;
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxMode, "comboBoxMode");
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            resources.GetString("comboBoxMode.Items"),
            resources.GetString("comboBoxMode.Items1")});
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // PboxIconYoutbe
            // 
            this.PboxIconYoutbe.BackColor = System.Drawing.Color.Transparent;
            this.PboxIconYoutbe.Image = global::ETEZAN2024.Properties.Resources.YotubeIcon2;
            resources.ApplyResources(this.PboxIconYoutbe, "PboxIconYoutbe");
            this.PboxIconYoutbe.Name = "PboxIconYoutbe";
            this.PboxIconYoutbe.TabStop = false;
            this.PboxIconYoutbe.Click += new System.EventHandler(this.PboxIconYoutbe_Click);
            // 
            // btnIconYoutbe
            // 
            this.btnIconYoutbe.BackColor = System.Drawing.Color.Transparent;
            this.btnIconYoutbe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnIconYoutbe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.btnIconYoutbe, "btnIconYoutbe");
            this.btnIconYoutbe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIconYoutbe.Name = "btnIconYoutbe";
            this.btnIconYoutbe.UseVisualStyleBackColor = false;
            this.btnIconYoutbe.Click += new System.EventHandler(this.btnIconYoutbe_Click);
            // 
            // notificatoinLoginUeser
            // 
            resources.ApplyResources(this.notificatoinLoginUeser, "notificatoinLoginUeser");
            // 
            // lbTimerConter
            // 
            resources.ApplyResources(this.lbTimerConter, "lbTimerConter");
            this.lbTimerConter.BackColor = System.Drawing.Color.Transparent;
            this.lbTimerConter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimerConter.ForeColor = System.Drawing.Color.White;
            this.lbTimerConter.Name = "lbTimerConter";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarLogin
            // 
            resources.ApplyResources(this.progressBarLogin, "progressBarLogin");
            this.progressBarLogin.Name = "progressBarLogin";
            // 
            // lbPrecentLogin
            // 
            resources.ApplyResources(this.lbPrecentLogin, "lbPrecentLogin");
            this.lbPrecentLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrecentLogin.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbPrecentLogin.Name = "lbPrecentLogin";
            // 
            // lbprogressBarLogin
            // 
            resources.ApplyResources(this.lbprogressBarLogin, "lbprogressBarLogin");
            this.lbprogressBarLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbprogressBarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbprogressBarLogin.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbprogressBarLogin.Name = "lbprogressBarLogin";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 110;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // PboxRightMarkUserName
            // 
            this.PboxRightMarkUserName.BackColor = System.Drawing.Color.Transparent;
            this.PboxRightMarkUserName.Image = global::ETEZAN2024.Properties.Resources.RightMark;
            resources.ApplyResources(this.PboxRightMarkUserName, "PboxRightMarkUserName");
            this.PboxRightMarkUserName.Name = "PboxRightMarkUserName";
            this.PboxRightMarkUserName.TabStop = false;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 1;
            this.errorProvider2.ContainerControl = this;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Name = "label3";
            // 
            // chRemberMe
            // 
            resources.ApplyResources(this.chRemberMe, "chRemberMe");
            this.chRemberMe.Checked = true;
            this.chRemberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chRemberMe.ForeColor = System.Drawing.Color.Gold;
            this.chRemberMe.Name = "chRemberMe";
            this.chRemberMe.UseVisualStyleBackColor = true;
            // 
            // frmLoginUser
            // 
            this.AcceptButton = this.btnLogin;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::ETEZAN2024.Properties.Resources.Backgrownd_Black_2;
            this.Controls.Add(this.chRemberMe);
            this.Controls.Add(this.PboxRightMarkUserName);
            this.Controls.Add(this.lbprogressBarLogin);
            this.Controls.Add(this.lbPrecentLogin);
            this.Controls.Add(this.progressBarLogin);
            this.Controls.Add(this.lbTimerConter);
            this.Controls.Add(this.PboxIconYoutbe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.PboxEyePasswerd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTboxPasswerd);
            this.Controls.Add(this.TboxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIconYoutbe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PboxEyePasswerd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxIconYoutbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxRightMarkUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PboxEyePasswerd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTboxPasswerd;
        private System.Windows.Forms.TextBox TboxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PboxIconYoutbe;
        private System.Windows.Forms.Button btnIconYoutbe;
        private System.Windows.Forms.NotifyIcon notificatoinLoginUeser;
        private System.Windows.Forms.Label lbTimerConter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarLogin;
        private System.Windows.Forms.Label lbPrecentLogin;
        private System.Windows.Forms.Label lbprogressBarLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox PboxRightMarkUserName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chRemberMe;
    }
}

