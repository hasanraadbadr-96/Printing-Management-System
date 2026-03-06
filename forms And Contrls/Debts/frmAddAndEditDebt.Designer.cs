namespace ETEZAN2024.forms_And_Contrls.Debts
{
    partial class frmAddAndEditDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAndEditDebt));
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new ETEZAN2024.forms_And_Contrls.Persons.Control.ctrlPersonCardWithFilter();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpDebtsInfo = new System.Windows.Forms.TabControl();
            this.tpDeptInfo = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lnkEditPerson = new System.Windows.Forms.LinkLabel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDebtDate = new System.Windows.Forms.DateTimePicker();
            this.lbDebtorName = new System.Windows.Forms.Label();
            this.lbDebtID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btaCansel2 = new System.Windows.Forms.Button();
            this.btnSaveDebtInfo = new System.Windows.Forms.Button();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkboxIsActive = new System.Windows.Forms.CheckBox();
            this.tbDebtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDebts = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpPersonInfo.SuspendLayout();
            this.tpDebtsInfo.SuspendLayout();
            this.tpDeptInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDebts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddAndEdit
            // 
            this.lbAddAndEdit.AutoSize = true;
            this.lbAddAndEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbAddAndEdit.Location = new System.Drawing.Point(290, -9);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.Size = new System.Drawing.Size(176, 44);
            this.lbAddAndEdit.TabIndex = 6;
            this.lbAddAndEdit.Text = "اضافة مــــديـن";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btNext
            // 
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btNext.ForeColor = System.Drawing.Color.Blue;
            this.btNext.Location = new System.Drawing.Point(26, 524);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(110, 38);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "الـتـالــي-->>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.Controls.Add(this.btNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Controls.Add(this.btnCansel);
            this.tpPersonInfo.Controls.Add(this.btnSave);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.ForeColor = System.Drawing.Color.Black;
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 4);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(840, 607);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "معلومات الشخص";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlPersonCardWithFilter1.BackgroundImage")));
            this.ctrlPersonCardWithFilter1.FillterEnable = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(1, -5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPersn = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(844, 632);
            this.ctrlPersonCardWithFilter1.TabIndex = 4;
            // 
            // btnCansel
            // 
            this.btnCansel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCansel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCansel.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCansel.ForeColor = System.Drawing.Color.Red;
            this.btnCansel.Location = new System.Drawing.Point(628, 444);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(109, 34);
            this.btnCansel.TabIndex = 3;
            this.btnCansel.Text = "الـلـغــاء";
            this.btnCansel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(743, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حـفــظ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNext.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(33, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "الــتــالــي";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tpDebtsInfo
            // 
            this.tpDebtsInfo.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tpDebtsInfo.Controls.Add(this.tpPersonInfo);
            this.tpDebtsInfo.Controls.Add(this.tpDeptInfo);
            this.tpDebtsInfo.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tpDebtsInfo.Location = new System.Drawing.Point(4, 33);
            this.tpDebtsInfo.Multiline = true;
            this.tpDebtsInfo.Name = "tpDebtsInfo";
            this.tpDebtsInfo.RightToLeftLayout = true;
            this.tpDebtsInfo.SelectedIndex = 0;
            this.tpDebtsInfo.Size = new System.Drawing.Size(848, 639);
            this.tpDebtsInfo.TabIndex = 7;
            // 
            // tpDeptInfo
            // 
            this.tpDeptInfo.BackColor = System.Drawing.Color.White;
            this.tpDeptInfo.BackgroundImage = global::ETEZAN2024.Properties.Resources.debt__2_;
            this.tpDeptInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpDeptInfo.Controls.Add(this.label6);
            this.tpDeptInfo.Controls.Add(this.lbOrderID);
            this.tpDeptInfo.Controls.Add(this.lbAdress);
            this.tpDeptInfo.Controls.Add(this.label10);
            this.tpDeptInfo.Controls.Add(this.lbPhone);
            this.tpDeptInfo.Controls.Add(this.label8);
            this.tpDeptInfo.Controls.Add(this.lnkEditPerson);
            this.tpDeptInfo.Controls.Add(this.lbUserName);
            this.tpDeptInfo.Controls.Add(this.label7);
            this.tpDeptInfo.Controls.Add(this.label5);
            this.tpDeptInfo.Controls.Add(this.dtpDebtDate);
            this.tpDeptInfo.Controls.Add(this.lbDebtorName);
            this.tpDeptInfo.Controls.Add(this.lbDebtID);
            this.tpDeptInfo.Controls.Add(this.label4);
            this.tpDeptInfo.Controls.Add(this.btaCansel2);
            this.tpDeptInfo.Controls.Add(this.btnSaveDebtInfo);
            this.tpDeptInfo.Controls.Add(this.lbUserID);
            this.tpDeptInfo.Controls.Add(this.label2);
            this.tpDeptInfo.Controls.Add(this.chkboxIsActive);
            this.tpDeptInfo.Controls.Add(this.tbDebtAmount);
            this.tpDeptInfo.Controls.Add(this.label3);
            this.tpDeptInfo.Controls.Add(this.label1);
            this.tpDeptInfo.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tpDeptInfo.Location = new System.Drawing.Point(4, 4);
            this.tpDeptInfo.Name = "tpDeptInfo";
            this.tpDeptInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeptInfo.Size = new System.Drawing.Size(840, 607);
            this.tpDeptInfo.TabIndex = 1;
            this.tpDeptInfo.Text = "معلومات الدين";
            this.tpDeptInfo.Click += new System.EventHandler(this.tpDeptInfo_Click);
            this.tpDeptInfo.Validating += new System.ComponentModel.CancelEventHandler(this.tpDeptInfo_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(617, 78);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(208, 29);
            this.label6.TabIndex = 163;
            this.label6.Text = " : رقم الطلب المديون عليه ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.BackColor = System.Drawing.Color.White;
            this.lbOrderID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrderID.ForeColor = System.Drawing.Color.Black;
            this.lbOrderID.Location = new System.Drawing.Point(346, 78);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOrderID.Size = new System.Drawing.Size(78, 29);
            this.lbOrderID.TabIndex = 162;
            this.lbOrderID.Text = "#####";
            this.lbOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.BackColor = System.Drawing.Color.White;
            this.lbAdress.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAdress.ForeColor = System.Drawing.Color.Black;
            this.lbAdress.Location = new System.Drawing.Point(353, 205);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAdress.Size = new System.Drawing.Size(65, 29);
            this.lbAdress.TabIndex = 47;
            this.lbAdress.Text = "####";
            this.lbAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(687, 205);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(78, 29);
            this.label10.TabIndex = 46;
            this.label10.Text = " : العنوان";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.White;
            this.lbPhone.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbPhone.ForeColor = System.Drawing.Color.Black;
            this.lbPhone.Location = new System.Drawing.Point(353, 266);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPhone.Size = new System.Drawing.Size(65, 29);
            this.lbPhone.TabIndex = 45;
            this.lbPhone.Text = "####";
            this.lbPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(672, 266);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 44;
            this.label8.Text = " : رقم الهاتف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkEditPerson
            // 
            this.lnkEditPerson.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lnkEditPerson.AutoSize = true;
            this.lnkEditPerson.BackColor = System.Drawing.Color.Transparent;
            this.lnkEditPerson.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnkEditPerson.LinkColor = System.Drawing.Color.Black;
            this.lnkEditPerson.Location = new System.Drawing.Point(8, 7);
            this.lnkEditPerson.Name = "lnkEditPerson";
            this.lnkEditPerson.Size = new System.Drawing.Size(196, 32);
            this.lnkEditPerson.TabIndex = 43;
            this.lnkEditPerson.TabStop = true;
            this.lnkEditPerson.Text = "تعديل معلومات الشخص";
            this.lnkEditPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditPerson_LinkClicked);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.White;
            this.lbUserName.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserName.ForeColor = System.Drawing.Color.Black;
            this.lbUserName.Location = new System.Drawing.Point(353, 327);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbUserName.Size = new System.Drawing.Size(65, 29);
            this.lbUserName.TabIndex = 35;
            this.lbUserName.Text = "####";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(647, 327);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(158, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = " اســـم منضم الدين :\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(671, 388);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = " : تاريخ الدين";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDebtDate
            // 
            this.dtpDebtDate.Location = new System.Drawing.Point(267, 389);
            this.dtpDebtDate.Name = "dtpDebtDate";
            this.dtpDebtDate.Size = new System.Drawing.Size(237, 27);
            this.dtpDebtDate.TabIndex = 32;
            // 
            // lbDebtorName
            // 
            this.lbDebtorName.AutoSize = true;
            this.lbDebtorName.BackColor = System.Drawing.Color.White;
            this.lbDebtorName.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDebtorName.ForeColor = System.Drawing.Color.Black;
            this.lbDebtorName.Location = new System.Drawing.Point(353, 144);
            this.lbDebtorName.Name = "lbDebtorName";
            this.lbDebtorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDebtorName.Size = new System.Drawing.Size(65, 29);
            this.lbDebtorName.TabIndex = 31;
            this.lbDebtorName.Text = "####";
            this.lbDebtorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDebtID
            // 
            this.lbDebtID.AutoSize = true;
            this.lbDebtID.BackColor = System.Drawing.Color.White;
            this.lbDebtID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDebtID.ForeColor = System.Drawing.Color.Black;
            this.lbDebtID.Location = new System.Drawing.Point(353, 21);
            this.lbDebtID.Name = "lbDebtID";
            this.lbDebtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDebtID.Size = new System.Drawing.Size(65, 29);
            this.lbDebtID.TabIndex = 30;
            this.lbDebtID.Text = "####";
            this.lbDebtID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(666, 21);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = " : معرف المدين";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(42, 550);
            this.btaCansel2.Name = "btaCansel2";
            this.btaCansel2.Size = new System.Drawing.Size(109, 34);
            this.btaCansel2.TabIndex = 28;
            this.btaCansel2.Text = "الـلـغــاء";
            this.btaCansel2.UseVisualStyleBackColor = true;
            this.btaCansel2.Click += new System.EventHandler(this.btaCansel2_Click);
            // 
            // btnSaveDebtInfo
            // 
            this.btnSaveDebtInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveDebtInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveDebtInfo.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveDebtInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveDebtInfo.Location = new System.Drawing.Point(157, 550);
            this.btnSaveDebtInfo.Name = "btnSaveDebtInfo";
            this.btnSaveDebtInfo.Size = new System.Drawing.Size(109, 34);
            this.btnSaveDebtInfo.TabIndex = 27;
            this.btnSaveDebtInfo.Text = "حـفــظ";
            this.btnSaveDebtInfo.UseVisualStyleBackColor = true;
            this.btnSaveDebtInfo.Click += new System.EventHandler(this.btnSaveDebtInfo_Click);
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.BackColor = System.Drawing.Color.Transparent;
            this.lbUserID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbUserID.Location = new System.Drawing.Point(513, -26);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbUserID.Size = new System.Drawing.Size(78, 29);
            this.lbUserID.TabIndex = 26;
            this.lbUserID.Text = "#####";
            this.lbUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(701, -26);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = " : معرف المستخدم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxIsActive
            // 
            this.chkboxIsActive.AutoSize = true;
            this.chkboxIsActive.BackColor = System.Drawing.Color.DimGray;
            this.chkboxIsActive.Checked = true;
            this.chkboxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkboxIsActive.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkboxIsActive.ForeColor = System.Drawing.Color.White;
            this.chkboxIsActive.Location = new System.Drawing.Point(321, 519);
            this.chkboxIsActive.Name = "chkboxIsActive";
            this.chkboxIsActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkboxIsActive.Size = new System.Drawing.Size(74, 33);
            this.chkboxIsActive.TabIndex = 24;
            this.chkboxIsActive.Text = "نـشــط\r\n";
            this.chkboxIsActive.UseVisualStyleBackColor = false;
            // 
            // tbDebtAmount
            // 
            this.tbDebtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDebtAmount.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbDebtAmount.ForeColor = System.Drawing.Color.Chocolate;
            this.tbDebtAmount.Location = new System.Drawing.Point(267, 447);
            this.tbDebtAmount.Name = "tbDebtAmount";
            this.tbDebtAmount.Size = new System.Drawing.Size(237, 32);
            this.tbDebtAmount.TabIndex = 17;
            this.tbDebtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDebtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDebtAmount_KeyPress);
            this.tbDebtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbDebtAmount_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(675, 449);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = " : مبلغ الدين";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(667, 144);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = " : اســـم المدين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderUser
            // 
            this.errorProviderUser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderUser.ContainerControl = this;
            // 
            // errorProviderDebts
            // 
            this.errorProviderDebts.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderDebts.ContainerControl = this;
            // 
            // frmAddAndEditDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 669);
            this.Controls.Add(this.tpDebtsInfo);
            this.Controls.Add(this.lbAddAndEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditDebt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة/تعديل دين";
            this.Activated += new System.EventHandler(this.frmAddAndEditDebt_Activated);
            this.Load += new System.EventHandler(this.frmAddDebt_Load);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpDebtsInfo.ResumeLayout(false);
            this.tpDeptInfo.ResumeLayout(false);
            this.tpDeptInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDebts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.TabPage tpDeptInfo;
        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Button btnSaveDebtInfo;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkboxIsActive;
        private System.Windows.Forms.TextBox tbDebtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Persons.Control.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl tpDebtsInfo;
        private System.Windows.Forms.ErrorProvider errorProviderUser;
        private System.Windows.Forms.Label lbDebtorName;
        private System.Windows.Forms.Label lbDebtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDebtDate;
        private System.Windows.Forms.LinkLabel lnkEditPerson;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.ErrorProvider errorProviderDebts;
    }
}