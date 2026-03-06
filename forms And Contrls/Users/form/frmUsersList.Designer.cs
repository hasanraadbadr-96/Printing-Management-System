namespace ETEZAN2024.forms_And_Contrls.Users
{
    partial class frmUsersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersList));
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.ctmsUsersManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsCallUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmboFilterBY = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsersCount = new System.Windows.Forms.Label();
            this.pBoxUsers = new System.Windows.Forms.PictureBox();
            this.pBoxAddUser = new System.Windows.Forms.PictureBox();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.ctmsUsersManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(512, 175);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(118, 20);
            this.tbFilterValue.TabIndex = 29;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AllowUserToOrderColumns = true;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.ctmsUsersManagement;
            this.dgvAllUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllUsers.Location = new System.Drawing.Point(7, 223);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllUsers.Size = new System.Drawing.Size(623, 267);
            this.dgvAllUsers.TabIndex = 25;
            // 
            // ctmsUsersManagement
            // 
            this.ctmsUsersManagement.BackColor = System.Drawing.Color.White;
            this.ctmsUsersManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsUsersManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsUsersManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsUsersManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsUsersManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailUser,
            this.toolStripSeparator1,
            this.ctmsAddUser,
            this.ctmsEidtUser,
            this.ctmsDeleteUser,
            this.toolStripSeparator2,
            this.ctmsCallUser,
            this.ctmsEmailUser});
            this.ctmsUsersManagement.Name = "ctmsPeopleManagement";
            this.ctmsUsersManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsUsersManagement.ShowCheckMargin = true;
            this.ctmsUsersManagement.Size = new System.Drawing.Size(291, 292);
            // 
            // ctmsDetailUser
            // 
            this.ctmsDetailUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailUser.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDetailUser.Image")));
            this.ctmsDetailUser.Name = "ctmsDetailUser";
            this.ctmsDetailUser.Size = new System.Drawing.Size(290, 46);
            this.ctmsDetailUser.Text = "تفاصيل المستخدم";
            this.ctmsDetailUser.Click += new System.EventHandler(this.ctmsDetailUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(287, 6);
            // 
            // ctmsAddUser
            // 
            this.ctmsAddUser.Image = ((System.Drawing.Image)(resources.GetObject("ctmsAddUser.Image")));
            this.ctmsAddUser.Name = "ctmsAddUser";
            this.ctmsAddUser.Size = new System.Drawing.Size(290, 46);
            this.ctmsAddUser.Text = "اضافه مستخدم";
            this.ctmsAddUser.Click += new System.EventHandler(this.ctmsAddUser_Click);
            // 
            // ctmsEidtUser
            // 
            this.ctmsEidtUser.ForeColor = System.Drawing.Color.Chocolate;
            this.ctmsEidtUser.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtUser.Image")));
            this.ctmsEidtUser.Name = "ctmsEidtUser";
            this.ctmsEidtUser.Size = new System.Drawing.Size(290, 46);
            this.ctmsEidtUser.Text = "تحديث معلومات المستخدم";
            this.ctmsEidtUser.Click += new System.EventHandler(this.ctmsEidtUser_Click);
            // 
            // ctmsDeleteUser
            // 
            this.ctmsDeleteUser.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.ctmsDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeleteUser.Image")));
            this.ctmsDeleteUser.Name = "ctmsDeleteUser";
            this.ctmsDeleteUser.Size = new System.Drawing.Size(290, 46);
            this.ctmsDeleteUser.Text = "حذف المستخدم";
            this.ctmsDeleteUser.Click += new System.EventHandler(this.ctmsDeleteUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(287, 6);
            // 
            // ctmsCallUser
            // 
            this.ctmsCallUser.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallUser.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallUser.Image")));
            this.ctmsCallUser.Name = "ctmsCallUser";
            this.ctmsCallUser.Size = new System.Drawing.Size(290, 46);
            this.ctmsCallUser.Text = "الاتصال بالمستخدم";
            // 
            // ctmsEmailUser
            // 
            this.ctmsEmailUser.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailUser.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailUser.Image")));
            this.ctmsEmailUser.Name = "ctmsEmailUser";
            this.ctmsEmailUser.Size = new System.Drawing.Size(290, 46);
            this.ctmsEmailUser.Text = "الاارسال عبر الايميل";
            // 
            // cmboFilterBY
            // 
            this.cmboFilterBY.FormattingEnabled = true;
            this.cmboFilterBY.Location = new System.Drawing.Point(310, 175);
            this.cmboFilterBY.Name = "cmboFilterBY";
            this.cmboFilterBY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboFilterBY.Size = new System.Drawing.Size(118, 21);
            this.cmboFilterBY.TabIndex = 24;
            this.cmboFilterBY.SelectedIndexChanged += new System.EventHandler(this.cmboFilterBY_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "اضـافــة مستخم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(220, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "ادارة المستخدمين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(2, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = " عدد المستخدمين :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(301, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbUsersCount
            // 
            this.lbUsersCount.AutoSize = true;
            this.lbUsersCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUsersCount.ForeColor = System.Drawing.Color.Green;
            this.lbUsersCount.Location = new System.Drawing.Point(153, 497);
            this.lbUsersCount.Name = "lbUsersCount";
            this.lbUsersCount.Size = new System.Drawing.Size(65, 29);
            this.lbUsersCount.TabIndex = 28;
            this.lbUsersCount.Text = "####";
            this.lbUsersCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pBoxUsers
            // 
            this.pBoxUsers.BackgroundImage = global::ETEZAN2024.Properties.Resources.people;
            this.pBoxUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxUsers.Location = new System.Drawing.Point(251, -3);
            this.pBoxUsers.Name = "pBoxUsers";
            this.pBoxUsers.Size = new System.Drawing.Size(130, 69);
            this.pBoxUsers.TabIndex = 21;
            this.pBoxUsers.TabStop = false;
            // 
            // pBoxAddUser
            // 
            this.pBoxAddUser.BackgroundImage = global::ETEZAN2024.Properties.Resources.add_user1;
            this.pBoxAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddUser.Location = new System.Drawing.Point(18, 121);
            this.pBoxAddUser.Name = "pBoxAddUser";
            this.pBoxAddUser.Size = new System.Drawing.Size(116, 46);
            this.pBoxAddUser.TabIndex = 23;
            this.pBoxAddUser.TabStop = false;
            this.pBoxAddUser.Click += new System.EventHandler(this.pBoxAddUser_Click);
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Location = new System.Drawing.Point(430, 175);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbIsActive.Size = new System.Drawing.Size(79, 21);
            this.cmbIsActive.TabIndex = 30;
            this.cmbIsActive.Visible = false;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 522);
            this.Controls.Add(this.cmbIsActive);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.pBoxUsers);
            this.Controls.Add(this.dgvAllUsers);
            this.Controls.Add(this.cmboFilterBY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBoxAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUsersCount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsersList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المستخدمين";
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.ctmsUsersManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.PictureBox pBoxUsers;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.ContextMenuStrip ctmsUsersManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddUser;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtUser;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallUser;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailUser;
        private System.Windows.Forms.ComboBox cmboFilterBY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBoxAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsersCount;
        private System.Windows.Forms.ComboBox cmbIsActive;
    }
}