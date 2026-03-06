namespace ETEZAN2024.forms.Persons
{
    partial class frmPersonsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonsList));
            this.lbPersonsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsPersonsManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsDetailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEidtPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEmailPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllPersons = new System.Windows.Forms.DataGridView();
            this.cmboFilterBY = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilterValue = new System.Windows.Forms.TextBox();
            this.pBoxPeople = new System.Windows.Forms.PictureBox();
            this.pBoxAddPerson = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PboxNext = new System.Windows.Forms.PictureBox();
            this.PboxPrevious = new System.Windows.Forms.PictureBox();
            this.ctmsPersonsManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersonsCount
            // 
            this.lbPersonsCount.AutoSize = true;
            this.lbPersonsCount.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbPersonsCount.ForeColor = System.Drawing.Color.Green;
            this.lbPersonsCount.Location = new System.Drawing.Point(136, 649);
            this.lbPersonsCount.Name = "lbPersonsCount";
            this.lbPersonsCount.Size = new System.Drawing.Size(65, 29);
            this.lbPersonsCount.TabIndex = 18;
            this.lbPersonsCount.Text = "####";
            this.lbPersonsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(-2, 644);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = " عدد الااشخاص :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(472, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "تصفية بواسطه :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(363, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "ادارة الااشـخــاص";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // ctmsPersonsManagement
            // 
            this.ctmsPersonsManagement.BackColor = System.Drawing.Color.White;
            this.ctmsPersonsManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctmsPersonsManagement.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ctmsPersonsManagement.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctmsPersonsManagement.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.ctmsPersonsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsDetailPerson,
            this.toolStripSeparator1,
            this.ctmsAddPerson,
            this.ctmsEidtPerson,
            this.ctmsDeletePerson,
            this.toolStripSeparator2,
            this.ctmsCallPerson,
            this.ctmsEmailPerson});
            this.ctmsPersonsManagement.Name = "ctmsPeopleManagement";
            this.ctmsPersonsManagement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctmsPersonsManagement.ShowCheckMargin = true;
            this.ctmsPersonsManagement.Size = new System.Drawing.Size(275, 292);
            // 
            // ctmsDetailPerson
            // 
            this.ctmsDetailPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctmsDetailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDetailPerson.Image")));
            this.ctmsDetailPerson.Name = "ctmsDetailPerson";
            this.ctmsDetailPerson.Size = new System.Drawing.Size(274, 46);
            this.ctmsDetailPerson.Text = "تفاصيل الشخص";
            this.ctmsDetailPerson.Click += new System.EventHandler(this.ctmsDetailPerson_Click);
            // 
            // ctmsAddPerson
            // 
            this.ctmsAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsAddPerson.Image")));
            this.ctmsAddPerson.Name = "ctmsAddPerson";
            this.ctmsAddPerson.Size = new System.Drawing.Size(274, 46);
            this.ctmsAddPerson.Text = "اضافه شخص";
            this.ctmsAddPerson.Click += new System.EventHandler(this.ctmsAddPerson_Click);
            // 
            // ctmsEidtPerson
            // 
            this.ctmsEidtPerson.ForeColor = System.Drawing.Color.Chocolate;
            this.ctmsEidtPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEidtPerson.Image")));
            this.ctmsEidtPerson.Name = "ctmsEidtPerson";
            this.ctmsEidtPerson.Size = new System.Drawing.Size(274, 46);
            this.ctmsEidtPerson.Text = "تحديث معلومات الشخص";
            this.ctmsEidtPerson.Click += new System.EventHandler(this.ctmsEidtPerson_Click);
            // 
            // ctmsDeletePerson
            // 
            this.ctmsDeletePerson.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.ctmsDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsDeletePerson.Image")));
            this.ctmsDeletePerson.Name = "ctmsDeletePerson";
            this.ctmsDeletePerson.Size = new System.Drawing.Size(274, 46);
            this.ctmsDeletePerson.Text = "حذف الشخص";
            this.ctmsDeletePerson.Click += new System.EventHandler(this.ctmsDeletePerson_Click);
            // 
            // ctmsCallPerson
            // 
            this.ctmsCallPerson.ForeColor = System.Drawing.Color.Green;
            this.ctmsCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsCallPerson.Image")));
            this.ctmsCallPerson.Name = "ctmsCallPerson";
            this.ctmsCallPerson.Size = new System.Drawing.Size(274, 46);
            this.ctmsCallPerson.Text = "الاتصال بالشخص";
            // 
            // ctmsEmailPerson
            // 
            this.ctmsEmailPerson.ForeColor = System.Drawing.Color.Navy;
            this.ctmsEmailPerson.Image = ((System.Drawing.Image)(resources.GetObject("ctmsEmailPerson.Image")));
            this.ctmsEmailPerson.Name = "ctmsEmailPerson";
            this.ctmsEmailPerson.Size = new System.Drawing.Size(274, 46);
            this.ctmsEmailPerson.Text = "الاارسال عبر الايميل";
            // 
            // dgvAllPersons
            // 
            this.dgvAllPersons.AllowUserToAddRows = false;
            this.dgvAllPersons.AllowUserToDeleteRows = false;
            this.dgvAllPersons.AllowUserToOrderColumns = true;
            this.dgvAllPersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAllPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPersons.ContextMenuStrip = this.ctmsPersonsManagement;
            this.dgvAllPersons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAllPersons.Location = new System.Drawing.Point(7, 252);
            this.dgvAllPersons.Name = "dgvAllPersons";
            this.dgvAllPersons.ReadOnly = true;
            this.dgvAllPersons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllPersons.Size = new System.Drawing.Size(932, 390);
            this.dgvAllPersons.TabIndex = 15;
            // 
            // cmboFilterBY
            // 
            this.cmboFilterBY.FormattingEnabled = true;
            this.cmboFilterBY.Location = new System.Drawing.Point(625, 203);
            this.cmboFilterBY.Name = "cmboFilterBY";
            this.cmboFilterBY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboFilterBY.Size = new System.Drawing.Size(118, 21);
            this.cmboFilterBY.TabIndex = 14;
            this.cmboFilterBY.SelectedIndexChanged += new System.EventHandler(this.cmboFilterBY_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(49, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "اضـافــة شـخـص";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFilterValue
            // 
            this.tbFilterValue.Location = new System.Drawing.Point(772, 203);
            this.tbFilterValue.Name = "tbFilterValue";
            this.tbFilterValue.Size = new System.Drawing.Size(165, 20);
            this.tbFilterValue.TabIndex = 19;
            this.tbFilterValue.Visible = false;
            this.tbFilterValue.TextChanged += new System.EventHandler(this.tbFilterValue_TextChanged);
            this.tbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterValue_KeyPress);
            // 
            // pBoxPeople
            // 
            this.pBoxPeople.BackgroundImage = global::ETEZAN2024.Properties.Resources.people;
            this.pBoxPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxPeople.Location = new System.Drawing.Point(389, 12);
            this.pBoxPeople.Name = "pBoxPeople";
            this.pBoxPeople.Size = new System.Drawing.Size(144, 93);
            this.pBoxPeople.TabIndex = 11;
            this.pBoxPeople.TabStop = false;
            // 
            // pBoxAddPerson
            // 
            this.pBoxAddPerson.BackgroundImage = global::ETEZAN2024.Properties.Resources.add_user1;
            this.pBoxAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddPerson.Location = new System.Drawing.Point(54, 147);
            this.pBoxAddPerson.Name = "pBoxAddPerson";
            this.pBoxAddPerson.Size = new System.Drawing.Size(116, 46);
            this.pBoxAddPerson.TabIndex = 13;
            this.pBoxAddPerson.TabStop = false;
            this.pBoxAddPerson.Click += new System.EventHandler(this.pBoxAddPerson_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(433, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "الصفحة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PboxNext
            // 
            this.PboxNext.Image = global::ETEZAN2024.Properties.Resources.next_button;
            this.PboxNext.Location = new System.Drawing.Point(316, 647);
            this.PboxNext.Name = "PboxNext";
            this.PboxNext.Size = new System.Drawing.Size(100, 34);
            this.PboxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxNext.TabIndex = 40;
            this.PboxNext.TabStop = false;
            this.PboxNext.Click += new System.EventHandler(this.PboxNext_Click);
            // 
            // PboxPrevious
            // 
            this.PboxPrevious.Image = global::ETEZAN2024.Properties.Resources.previous;
            this.PboxPrevious.Location = new System.Drawing.Point(526, 647);
            this.PboxPrevious.Name = "PboxPrevious";
            this.PboxPrevious.Size = new System.Drawing.Size(100, 34);
            this.PboxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxPrevious.TabIndex = 39;
            this.PboxPrevious.TabStop = false;
            this.PboxPrevious.Click += new System.EventHandler(this.PboxPrevious_Click);
            // 
            // frmPersonsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 684);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PboxNext);
            this.Controls.Add(this.PboxPrevious);
            this.Controls.Add(this.tbFilterValue);
            this.Controls.Add(this.lbPersonsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBoxPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllPersons);
            this.Controls.Add(this.cmboFilterBY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBoxAddPerson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاشخاص";
            this.Load += new System.EventHandler(this.frmPersonsManagement_Load);
            this.ctmsPersonsManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PboxPrevious)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPersonsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBoxPeople;
        private System.Windows.Forms.ToolStripMenuItem ctmsEmailPerson;
        private System.Windows.Forms.ToolStripMenuItem ctmsCallPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsDeletePerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ctmsEidtPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsDetailPerson;
        private System.Windows.Forms.ContextMenuStrip ctmsPersonsManagement;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddPerson;
        private System.Windows.Forms.DataGridView dgvAllPersons;
        private System.Windows.Forms.ComboBox cmboFilterBY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBoxAddPerson;
        private System.Windows.Forms.TextBox tbFilterValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PboxNext;
        private System.Windows.Forms.PictureBox PboxPrevious;
    }
}