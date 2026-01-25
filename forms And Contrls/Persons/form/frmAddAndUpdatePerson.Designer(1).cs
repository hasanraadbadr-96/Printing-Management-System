namespace ETEZAN2024.forms.Persons
{
    partial class frmAddAndUpdatePerson
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
            this.saveImagePath = new System.Windows.Forms.SaveFileDialog();
            this.openFileAddPhoto = new System.Windows.Forms.OpenFileDialog();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.rbFamel = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lnkDeletePhoto = new System.Windows.Forms.LinkLabel();
            this.lnkAddPhoto = new System.Windows.Forms.LinkLabel();
            this.pBoxPerson = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbAddAndEdit1 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbOrderCount = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileAddPhoto
            // 
            this.openFileAddPhoto.FileName = "openFileDialog1";
            // 
            // cmbCities
            // 
            this.cmbCities.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(401, 330);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCities.Size = new System.Drawing.Size(177, 28);
            this.cmbCities.TabIndex = 61;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbAddress.ForeColor = System.Drawing.Color.Chocolate;
            this.tbAddress.Location = new System.Drawing.Point(307, 410);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(271, 55);
            this.tbAddress.TabIndex = 45;
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // tbPhone
            // 
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhone.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbPhone.ForeColor = System.Drawing.Color.Chocolate;
            this.tbPhone.Location = new System.Drawing.Point(401, 291);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(177, 32);
            this.tbPhone.TabIndex = 42;
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // rbFamel
            // 
            this.rbFamel.AutoSize = true;
            this.rbFamel.BackColor = System.Drawing.Color.Transparent;
            this.rbFamel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFamel.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbFamel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbFamel.Location = new System.Drawing.Point(272, 201);
            this.rbFamel.Name = "rbFamel";
            this.rbFamel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbFamel.Size = new System.Drawing.Size(94, 33);
            this.rbFamel.TabIndex = 41;
            this.rbFamel.TabStop = true;
            this.rbFamel.Text = "انـثــــــــــئ";
            this.rbFamel.UseVisualStyleBackColor = false;
            this.rbFamel.CheckedChanged += new System.EventHandler(this.rbFamel_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMale.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbMale.Location = new System.Drawing.Point(493, 203);
            this.rbMale.Name = "rbMale";
            this.rbMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbMale.Size = new System.Drawing.Size(109, 33);
            this.rbMale.TabIndex = 40;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "ذكــــــــــــــر";
            this.rbMale.UseVisualStyleBackColor = false;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNationalNo.Enabled = false;
            this.tbNationalNo.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbNationalNo.ForeColor = System.Drawing.Color.Chocolate;
            this.tbNationalNo.Location = new System.Drawing.Point(401, 162);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(177, 32);
            this.tbNationalNo.TabIndex = 38;
            this.tbNationalNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // tbFullName
            // 
            this.tbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFullName.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbFullName.ForeColor = System.Drawing.Color.Chocolate;
            this.tbFullName.Location = new System.Drawing.Point(401, 121);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(177, 32);
            this.tbFullName.TabIndex = 34;
            this.tbFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFullName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(96, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "الـلـغــاء";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(172, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(70, 33);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "حـفــظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lnkDeletePhoto
            // 
            this.lnkDeletePhoto.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkDeletePhoto.AutoSize = true;
            this.lnkDeletePhoto.BackColor = System.Drawing.Color.Transparent;
            this.lnkDeletePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkDeletePhoto.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnkDeletePhoto.LinkColor = System.Drawing.Color.Red;
            this.lnkDeletePhoto.Location = new System.Drawing.Point(110, 336);
            this.lnkDeletePhoto.Name = "lnkDeletePhoto";
            this.lnkDeletePhoto.Size = new System.Drawing.Size(111, 34);
            this.lnkDeletePhoto.TabIndex = 50;
            this.lnkDeletePhoto.TabStop = true;
            this.lnkDeletePhoto.Text = "حــذف صوره";
            this.lnkDeletePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeletePhoto_LinkClicked);
            // 
            // lnkAddPhoto
            // 
            this.lnkAddPhoto.AutoSize = true;
            this.lnkAddPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lnkAddPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkAddPhoto.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnkAddPhoto.Location = new System.Drawing.Point(110, 281);
            this.lnkAddPhoto.Name = "lnkAddPhoto";
            this.lnkAddPhoto.Size = new System.Drawing.Size(111, 34);
            this.lnkAddPhoto.TabIndex = 47;
            this.lnkAddPhoto.TabStop = true;
            this.lnkAddPhoto.Text = "اضافة صوره";
            this.lnkAddPhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddPhoto_LinkClicked);
            // 
            // pBoxPerson
            // 
            this.pBoxPerson.BackColor = System.Drawing.Color.White;
            this.pBoxPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxPerson.Location = new System.Drawing.Point(94, 133);
            this.pBoxPerson.Name = "pBoxPerson";
            this.pBoxPerson.Size = new System.Drawing.Size(149, 115);
            this.pBoxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPerson.TabIndex = 56;
            this.pBoxPerson.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(607, 415);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = " : العنوان";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(609, 334);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 54;
            this.label9.Text = " : المدينه";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(592, 293);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 51;
            this.label8.Text = " : رقم الهاتف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(608, 205);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = " : الجنس";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(584, 164);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = " : الرقم الوطني";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(371, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 43;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAddAndEdit
            // 
            this.lbAddAndEdit.AutoSize = true;
            this.lbAddAndEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.Black;
            this.lbAddAndEdit.Location = new System.Drawing.Point(607, 123);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAddAndEdit.Size = new System.Drawing.Size(78, 29);
            this.lbAddAndEdit.TabIndex = 39;
            this.lbAddAndEdit.Text = " : الاســـم";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lbPersonID.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbPersonID.ForeColor = System.Drawing.Color.Black;
            this.lbPersonID.Location = new System.Drawing.Point(435, 69);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPersonID.Size = new System.Drawing.Size(35, 23);
            this.lbPersonID.TabIndex = 66;
            this.lbPersonID.Text = "N/A";
            this.lbPersonID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(476, 69);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 65;
            this.label13.Text = "معرف الشخص :\r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAddAndEdit1
            // 
            this.lbAddAndEdit1.AutoSize = true;
            this.lbAddAndEdit1.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit1.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit1.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAddAndEdit1.Location = new System.Drawing.Point(300, -5);
            this.lbAddAndEdit1.Name = "lbAddAndEdit1";
            this.lbAddAndEdit1.Size = new System.Drawing.Size(151, 44);
            this.lbAddAndEdit1.TabIndex = 64;
            this.lbAddAndEdit1.Text = "؟؟؟؟؟؟؟؟؟؟؟";
            this.lbAddAndEdit1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbNotes
            // 
            this.tbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNotes.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbNotes.ForeColor = System.Drawing.Color.Chocolate;
            this.tbNotes.Location = new System.Drawing.Point(401, 373);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(177, 32);
            this.tbNotes.TabIndex = 67;
            this.tbNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(591, 369);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 68;
            this.label6.Text = " : ملاحضات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(585, 247);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 70;
            this.label7.Text = " : عدد الطلبيات";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbOrderCount
            // 
            this.mtbOrderCount.Location = new System.Drawing.Point(401, 258);
            this.mtbOrderCount.Mask = "00000";
            this.mtbOrderCount.Name = "mtbOrderCount";
            this.mtbOrderCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtbOrderCount.Size = new System.Drawing.Size(177, 20);
            this.mtbOrderCount.TabIndex = 71;
            this.mtbOrderCount.ValidatingType = typeof(int);
            this.mtbOrderCount.Validating += new System.ComponentModel.CancelEventHandler(this.mtbOrderCount_Validating);
            // 
            // frmAddAndUpdate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ETEZAN2024.Properties.Resources.EYE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(729, 481);
            this.Controls.Add(this.mtbOrderCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbAddAndEdit1);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.rbFamel);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbNationalNo);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lnkDeletePhoto);
            this.Controls.Add(this.lnkAddPhoto);
            this.Controls.Add(this.pBoxPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddAndEdit);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه وتعديل شخص ";
            this.Load += new System.EventHandler(this.frmAddAndUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveImagePath;
        private System.Windows.Forms.OpenFileDialog openFileAddPhoto;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.RadioButton rbFamel;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkDeletePhoto;
        private System.Windows.Forms.LinkLabel lnkAddPhoto;
        private System.Windows.Forms.PictureBox pBoxPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbAddAndEdit1;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbOrderCount;
    }
}