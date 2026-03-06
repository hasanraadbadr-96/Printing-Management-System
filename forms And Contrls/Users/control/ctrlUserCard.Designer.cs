namespace ETEZAN2024.forms_And_Contrls.Users.control
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlUserCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIsAtive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrlPersonCard1 = new ETEZAN2024.forms_And_Contrls.Persons.Control.ctrlPersonCard();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIsAtive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbUserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("mohammad bold art 1", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(24, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(716, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم";
            // 
            // lbIsAtive
            // 
            this.lbIsAtive.AutoSize = true;
            this.lbIsAtive.BackColor = System.Drawing.Color.Transparent;
            this.lbIsAtive.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbIsAtive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbIsAtive.Location = new System.Drawing.Point(23, 17);
            this.lbIsAtive.Name = "lbIsAtive";
            this.lbIsAtive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbIsAtive.Size = new System.Drawing.Size(50, 23);
            this.lbIsAtive.TabIndex = 60;
            this.lbIsAtive.Text = "####";
            this.lbIsAtive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(82, 17);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "  :  نشط\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbUserName.Location = new System.Drawing.Point(263, 15);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUserName.Size = new System.Drawing.Size(50, 23);
            this.lbUserName.TabIndex = 58;
            this.lbUserName.Text = "####";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUserName.Click += new System.EventHandler(this.lbUserName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(358, 17);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "  :  اسم المستخدم\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.BackColor = System.Drawing.Color.Transparent;
            this.lbUserID.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbUserID.Location = new System.Drawing.Point(532, 18);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUserID.Size = new System.Drawing.Size(50, 23);
            this.lbUserID.TabIndex = 56;
            this.lbUserID.Text = "####";
            this.lbUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(591, 17);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "  :  معرف المستخدم\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrlPersonCard1);
            this.groupBox2.Font = new System.Drawing.Font("mohammad bold art 1", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(24, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(716, 425);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات الشخص";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlPersonCard1.BackgroundImage")));
            this.ctrlPersonCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlPersonCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 24);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(699, 390);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(763, 478);
            this.Load += new System.EventHandler(this.ctrlUserCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIsAtive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label2;
        private Persons.Control.ctrlPersonCard ctrlPersonCard1;
    }
}
