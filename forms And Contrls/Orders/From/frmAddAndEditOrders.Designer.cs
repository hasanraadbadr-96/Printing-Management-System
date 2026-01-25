namespace ETEZAN2024.forms_And_Contrls.Orders
{
    partial class frmAddAndEditOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAndEditOrders));
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpPersonInfo1 = new System.Windows.Forms.TabControl();
            this.errorProviderOrders = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCardWithFilter1 = new ETEZAN2024.forms_And_Contrls.Persons.Control.ctrlPersonCardWithFilter();
            this.tpOrderInfo = new System.Windows.Forms.TabPage();
            this.cmbInventoryTransactionType = new System.Windows.Forms.ComboBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTypeOrderInfo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFinishTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpEstimateTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lnkEditProdectName = new System.Windows.Forms.LinkLabel();
            this.cmbProdectName = new System.Windows.Forms.ComboBox();
            this.lbRemainingAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPaidAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNots = new System.Windows.Forms.TextBox();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btaCansel2 = new System.Windows.Forms.Button();
            this.btnSaveOrderInfo = new System.Windows.Forms.Button();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPaidAmount = new System.Windows.Forms.TextBox();
            this.tbOrderPrice = new System.Windows.Forms.TextBox();
            this.lbConfrimPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpPersonInfo.SuspendLayout();
            this.tpPersonInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrders)).BeginInit();
            this.tpOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddAndEdit
            // 
            this.lbAddAndEdit.AutoSize = true;
            this.lbAddAndEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbAddAndEdit.Location = new System.Drawing.Point(307, -7);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.Size = new System.Drawing.Size(207, 44);
            this.lbAddAndEdit.TabIndex = 6;
            this.lbAddAndEdit.Text = "اضافة طلب محلي";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbAddAndEdit.Click += new System.EventHandler(this.lbAddAndEdit_Click);
            // 
            // btNext
            // 
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btNext.ForeColor = System.Drawing.Color.Blue;
            this.btNext.Location = new System.Drawing.Point(0, 569);
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
            // btnCansel
            // 
            this.btnCansel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCansel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCansel.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCansel.ForeColor = System.Drawing.Color.Red;
            this.btnCansel.Location = new System.Drawing.Point(602, 489);
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
            this.btnSave.Location = new System.Drawing.Point(717, 489);
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
            this.btnNext.Location = new System.Drawing.Point(7, 489);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "الــتــالــي";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tpPersonInfo1
            // 
            this.tpPersonInfo1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tpPersonInfo1.Controls.Add(this.tpPersonInfo);
            this.tpPersonInfo1.Controls.Add(this.tpOrderInfo);
            this.tpPersonInfo1.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tpPersonInfo1.Location = new System.Drawing.Point(21, 40);
            this.tpPersonInfo1.Multiline = true;
            this.tpPersonInfo1.Name = "tpPersonInfo1";
            this.tpPersonInfo1.RightToLeftLayout = true;
            this.tpPersonInfo1.SelectedIndex = 0;
            this.tpPersonInfo1.Size = new System.Drawing.Size(848, 639);
            this.tpPersonInfo1.TabIndex = 7;
            // 
            // errorProviderOrders
            // 
            this.errorProviderOrders.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderOrders.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlPersonCardWithFilter1.BackgroundImage")));
            this.ctrlPersonCardWithFilter1.FillterEnable = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-4, -4);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPersn = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(844, 632);
            this.ctrlPersonCardWithFilter1.TabIndex = 4;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load);
            // 
            // tpOrderInfo
            // 
            this.tpOrderInfo.AccessibleDescription = "";
            this.tpOrderInfo.AccessibleName = "";
            this.tpOrderInfo.BackColor = System.Drawing.Color.White;
            this.tpOrderInfo.BackgroundImage = global::ETEZAN2024.Properties.Resources.business;
            this.tpOrderInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpOrderInfo.Controls.Add(this.cmbInventoryTransactionType);
            this.tpOrderInfo.Controls.Add(this.tbQuantity);
            this.tpOrderInfo.Controls.Add(this.label15);
            this.tpOrderInfo.Controls.Add(this.cmbTypeOrderInfo);
            this.tpOrderInfo.Controls.Add(this.label14);
            this.tpOrderInfo.Controls.Add(this.dtpFinishTime);
            this.tpOrderInfo.Controls.Add(this.label12);
            this.tpOrderInfo.Controls.Add(this.dtpEstimateTime);
            this.tpOrderInfo.Controls.Add(this.label9);
            this.tpOrderInfo.Controls.Add(this.lnkEditProdectName);
            this.tpOrderInfo.Controls.Add(this.cmbProdectName);
            this.tpOrderInfo.Controls.Add(this.lbRemainingAmount);
            this.tpOrderInfo.Controls.Add(this.label13);
            this.tpOrderInfo.Controls.Add(this.lbPaidAmount);
            this.tpOrderInfo.Controls.Add(this.label11);
            this.tpOrderInfo.Controls.Add(this.lbUserName);
            this.tpOrderInfo.Controls.Add(this.label10);
            this.tpOrderInfo.Controls.Add(this.lbTotalPrice);
            this.tpOrderInfo.Controls.Add(this.label8);
            this.tpOrderInfo.Controls.Add(this.label7);
            this.tpOrderInfo.Controls.Add(this.tbNots);
            this.tpOrderInfo.Controls.Add(this.cmbOrderStatus);
            this.tpOrderInfo.Controls.Add(this.label6);
            this.tpOrderInfo.Controls.Add(this.label5);
            this.tpOrderInfo.Controls.Add(this.dtpOrderDate);
            this.tpOrderInfo.Controls.Add(this.rbNo);
            this.tpOrderInfo.Controls.Add(this.rbYes);
            this.tpOrderInfo.Controls.Add(this.label4);
            this.tpOrderInfo.Controls.Add(this.btaCansel2);
            this.tpOrderInfo.Controls.Add(this.btnSaveOrderInfo);
            this.tpOrderInfo.Controls.Add(this.lbOrderID);
            this.tpOrderInfo.Controls.Add(this.label2);
            this.tpOrderInfo.Controls.Add(this.tbPaidAmount);
            this.tpOrderInfo.Controls.Add(this.tbOrderPrice);
            this.tpOrderInfo.Controls.Add(this.lbConfrimPassword);
            this.tpOrderInfo.Controls.Add(this.label3);
            this.tpOrderInfo.Controls.Add(this.label1);
            this.tpOrderInfo.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tpOrderInfo.Location = new System.Drawing.Point(4, 4);
            this.tpOrderInfo.Name = "tpOrderInfo";
            this.tpOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderInfo.Size = new System.Drawing.Size(840, 607);
            this.tpOrderInfo.TabIndex = 1;
            this.tpOrderInfo.Text = "معلومات الطلب";
            this.tpOrderInfo.Click += new System.EventHandler(this.tpOrderInfo_Click);
            // 
            // cmbInventoryTransactionType
            // 
            this.cmbInventoryTransactionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbInventoryTransactionType.FormattingEnabled = true;
            this.cmbInventoryTransactionType.Location = new System.Drawing.Point(359, 121);
            this.cmbInventoryTransactionType.Name = "cmbInventoryTransactionType";
            this.cmbInventoryTransactionType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbInventoryTransactionType.Size = new System.Drawing.Size(133, 27);
            this.cmbInventoryTransactionType.TabIndex = 80;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantity.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbQuantity.ForeColor = System.Drawing.Color.Chocolate;
            this.tbQuantity.Location = new System.Drawing.Point(162, 119);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(87, 30);
            this.tbQuantity.TabIndex = 81;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            this.tbQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.tbQuantity_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(243, 121);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(116, 23);
            this.label15.TabIndex = 82;
            this.label15.Text = " : عدد قطع المنتج";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTypeOrderInfo
            // 
            this.cmbTypeOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbTypeOrderInfo.FormattingEnabled = true;
            this.cmbTypeOrderInfo.Location = new System.Drawing.Point(498, 122);
            this.cmbTypeOrderInfo.Name = "cmbTypeOrderInfo";
            this.cmbTypeOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTypeOrderInfo.Size = new System.Drawing.Size(133, 27);
            this.cmbTypeOrderInfo.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(709, 121);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(99, 29);
            this.label14.TabIndex = 78;
            this.label14.Text = " : نوع الطلب";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFinishTime
            // 
            this.dtpFinishTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFinishTime.Enabled = false;
            this.dtpFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.errorProviderOrders.SetIconAlignment(this.dtpFinishTime, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.dtpFinishTime.Location = new System.Drawing.Point(359, 356);
            this.dtpFinishTime.Name = "dtpFinishTime";
            this.dtpFinishTime.ShowCheckBox = true;
            this.dtpFinishTime.ShowUpDown = true;
            this.dtpFinishTime.Size = new System.Drawing.Size(272, 27);
            this.dtpFinishTime.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(682, 356);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 77;
            this.label12.Text = "  تاريخ اكتمال الطلب :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEstimateTime
            // 
            this.dtpEstimateTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpEstimateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.errorProviderOrders.SetIconAlignment(this.dtpEstimateTime, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.dtpEstimateTime.Location = new System.Drawing.Point(359, 305);
            this.dtpEstimateTime.Name = "dtpEstimateTime";
            this.dtpEstimateTime.ShowCheckBox = true;
            this.dtpEstimateTime.ShowUpDown = true;
            this.dtpEstimateTime.Size = new System.Drawing.Size(272, 27);
            this.dtpEstimateTime.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(671, 307);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(172, 25);
            this.label9.TabIndex = 75;
            this.label9.Text = "الوقت المتوقع لاكتماله  :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkEditProdectName
            // 
            this.lnkEditProdectName.ActiveLinkColor = System.Drawing.Color.Green;
            this.lnkEditProdectName.AutoSize = true;
            this.lnkEditProdectName.BackColor = System.Drawing.Color.SlateGray;
            this.lnkEditProdectName.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lnkEditProdectName.LinkColor = System.Drawing.Color.White;
            this.lnkEditProdectName.Location = new System.Drawing.Point(162, 65);
            this.lnkEditProdectName.Name = "lnkEditProdectName";
            this.lnkEditProdectName.Size = new System.Drawing.Size(155, 32);
            this.lnkEditProdectName.TabIndex = 73;
            this.lnkEditProdectName.TabStop = true;
            this.lnkEditProdectName.Text = "تعديل اسم المنتج";
            this.lnkEditProdectName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditProdectName_LinkClicked);
            // 
            // cmbProdectName
            // 
            this.cmbProdectName.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F);
            this.cmbProdectName.FormattingEnabled = true;
            this.cmbProdectName.Location = new System.Drawing.Point(359, 71);
            this.cmbProdectName.Name = "cmbProdectName";
            this.cmbProdectName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProdectName.Size = new System.Drawing.Size(272, 27);
            this.cmbProdectName.TabIndex = 0;
            this.cmbProdectName.SelectedIndexChanged += new System.EventHandler(this.cmbProdectName_SelectedIndexChanged);
            this.cmbProdectName.TextChanged += new System.EventHandler(this.cmbProdectName_TextChanged);
            this.cmbProdectName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProdectName_Validating);
            // 
            // lbRemainingAmount
            // 
            this.lbRemainingAmount.AutoSize = true;
            this.lbRemainingAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbRemainingAmount.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbRemainingAmount.ForeColor = System.Drawing.Color.White;
            this.lbRemainingAmount.Location = new System.Drawing.Point(313, 571);
            this.lbRemainingAmount.Name = "lbRemainingAmount";
            this.lbRemainingAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRemainingAmount.Size = new System.Drawing.Size(60, 23);
            this.lbRemainingAmount.TabIndex = 72;
            this.lbRemainingAmount.Text = "#####";
            this.lbRemainingAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(386, 569);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 71;
            this.label13.Text = " :المبلغ المتبقي";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPaidAmount
            // 
            this.lbPaidAmount.AutoSize = true;
            this.lbPaidAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbPaidAmount.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbPaidAmount.ForeColor = System.Drawing.Color.Black;
            this.lbPaidAmount.Location = new System.Drawing.Point(509, 573);
            this.lbPaidAmount.Name = "lbPaidAmount";
            this.lbPaidAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPaidAmount.Size = new System.Drawing.Size(60, 23);
            this.lbPaidAmount.TabIndex = 70;
            this.lbPaidAmount.Text = "#####";
            this.lbPaidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(567, 571);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(96, 23);
            this.label11.TabIndex = 69;
            this.label11.Text = " :المبلغ الواصل";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUserName.ForeColor = System.Drawing.Color.Navy;
            this.lbUserName.Location = new System.Drawing.Point(48, 513);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbUserName.Size = new System.Drawing.Size(78, 29);
            this.lbUserName.TabIndex = 68;
            this.lbUserName.Text = "#####";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(32, 480);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 67;
            this.label10.Text = " منضم الطلب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Navy;
            this.lbTotalPrice.Location = new System.Drawing.Point(675, 573);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotalPrice.Size = new System.Drawing.Size(60, 23);
            this.lbTotalPrice.TabIndex = 66;
            this.lbTotalPrice.Text = "#####";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("mohammad bold art 1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(732, 571);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 65;
            this.label8.Text = " :المجموع الكلي";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(709, 522);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 64;
            this.label7.Text = " : ملاحضات";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNots
            // 
            this.tbNots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNots.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbNots.ForeColor = System.Drawing.Color.Chocolate;
            this.tbNots.Location = new System.Drawing.Point(359, 521);
            this.tbNots.Multiline = true;
            this.tbNots.Name = "tbNots";
            this.tbNots.Size = new System.Drawing.Size(272, 30);
            this.tbNots.TabIndex = 7;
            this.tbNots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F);
            this.cmbOrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Location = new System.Drawing.Point(359, 469);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbOrderStatus.Size = new System.Drawing.Size(272, 27);
            this.cmbOrderStatus.TabIndex = 6;
            this.cmbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cmbOrderStatus_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(705, 469);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 50;
            this.label6.Text = " :حاله الطلب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(697, 409);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 48;
            this.label5.Text = " : عربون الطلب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(359, 260);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.ShowCheckBox = true;
            this.dtpOrderDate.ShowUpDown = true;
            this.dtpOrderDate.Size = new System.Drawing.Size(272, 27);
            this.dtpOrderDate.TabIndex = 4;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNo.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbNo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rbNo.Location = new System.Drawing.Point(355, 207);
            this.rbNo.Name = "rbNo";
            this.rbNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbNo.Size = new System.Drawing.Size(43, 33);
            this.rbNo.TabIndex = 3;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "لا";
            this.rbNo.UseVisualStyleBackColor = false;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbYes.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbYes.Location = new System.Drawing.Point(533, 207);
            this.rbYes.Name = "rbYes";
            this.rbYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbYes.Size = new System.Drawing.Size(98, 33);
            this.rbYes.TabIndex = 2;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "نــــعــــــــــم";
            this.rbYes.UseVisualStyleBackColor = false;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(700, 211);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = " : مع التوصيل ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(34, 564);
            this.btaCansel2.Name = "btaCansel2";
            this.btaCansel2.Size = new System.Drawing.Size(109, 34);
            this.btaCansel2.TabIndex = 28;
            this.btaCansel2.Text = "الـلـغــاء";
            this.btaCansel2.UseVisualStyleBackColor = true;
            this.btaCansel2.Click += new System.EventHandler(this.btaCansel2_Click);
            // 
            // btnSaveOrderInfo
            // 
            this.btnSaveOrderInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveOrderInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveOrderInfo.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveOrderInfo.Location = new System.Drawing.Point(149, 564);
            this.btnSaveOrderInfo.Name = "btnSaveOrderInfo";
            this.btnSaveOrderInfo.Size = new System.Drawing.Size(109, 34);
            this.btnSaveOrderInfo.TabIndex = 27;
            this.btnSaveOrderInfo.Text = "حـفــظ";
            this.btnSaveOrderInfo.UseVisualStyleBackColor = true;
            this.btnSaveOrderInfo.Click += new System.EventHandler(this.btnSaveOrderInfo_Click);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lbOrderID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbOrderID.ForeColor = System.Drawing.Color.Black;
            this.lbOrderID.Location = new System.Drawing.Point(493, 21);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOrderID.Size = new System.Drawing.Size(78, 29);
            this.lbOrderID.TabIndex = 26;
            this.lbOrderID.Text = "#####";
            this.lbOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(700, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = " : معرف الطلب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPaidAmount
            // 
            this.tbPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPaidAmount.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbPaidAmount.ForeColor = System.Drawing.Color.Chocolate;
            this.tbPaidAmount.Location = new System.Drawing.Point(359, 407);
            this.tbPaidAmount.Name = "tbPaidAmount";
            this.tbPaidAmount.Size = new System.Drawing.Size(272, 32);
            this.tbPaidAmount.TabIndex = 5;
            this.tbPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPaidAmount.TextChanged += new System.EventHandler(this.tbPaidAmount_TextChanged);
            this.tbPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPaidAmount_KeyPress);
            this.tbPaidAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbPaidAmount_Validating);
            // 
            // tbOrderPrice
            // 
            this.tbOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOrderPrice.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbOrderPrice.ForeColor = System.Drawing.Color.Chocolate;
            this.tbOrderPrice.Location = new System.Drawing.Point(359, 166);
            this.tbOrderPrice.Name = "tbOrderPrice";
            this.tbOrderPrice.Size = new System.Drawing.Size(272, 32);
            this.tbOrderPrice.TabIndex = 1;
            this.tbOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrderPrice.TextChanged += new System.EventHandler(this.tbOrderPrice_TextChanged);
            this.tbOrderPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOrderPrice_KeyPress);
            this.tbOrderPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrderPrice_Validating);
            // 
            // lbConfrimPassword
            // 
            this.lbConfrimPassword.AutoSize = true;
            this.lbConfrimPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbConfrimPassword.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbConfrimPassword.ForeColor = System.Drawing.Color.Gray;
            this.lbConfrimPassword.Location = new System.Drawing.Point(698, 259);
            this.lbConfrimPassword.Name = "lbConfrimPassword";
            this.lbConfrimPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbConfrimPassword.Size = new System.Drawing.Size(118, 29);
            this.lbConfrimPassword.TabIndex = 21;
            this.lbConfrimPassword.Text = "  تاريخ الحجز :";
            this.lbConfrimPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(706, 168);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = " : سعر الطلب";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(696, 71);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = " :  اســـم المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddAndEditOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 686);
            this.Controls.Add(this.lbAddAndEdit);
            this.Controls.Add(this.tpPersonInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditOrders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الطلبات";
            this.Activated += new System.EventHandler(this.frmAddAndEditOrders_Activated);
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpPersonInfo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrders)).EndInit();
            this.tpOrderInfo.ResumeLayout(false);
            this.tpOrderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.TabPage tpOrderInfo;
        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Button btnSaveOrderInfo;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPaidAmount;
        private System.Windows.Forms.Label lbConfrimPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Persons.Control.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabControl tpPersonInfo1;
        private System.Windows.Forms.ErrorProvider errorProviderOrders;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrderPrice;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNots;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbRemainingAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbPaidAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbProdectName;
        private System.Windows.Forms.LinkLabel lnkEditProdectName;
        private System.Windows.Forms.DateTimePicker dtpEstimateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFinishTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbInventoryTransactionType;
        private System.Windows.Forms.ComboBox cmbTypeOrderInfo;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label15;
    }
}