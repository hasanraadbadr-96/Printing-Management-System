namespace ETEZAN2024.forms_And_Contrls.Products.forms
{
    partial class frmAddProductToInventorey
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
            this.dtpLast_purchase_date = new System.Windows.Forms.DateTimePicker();
            this.cmbProdectName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVendor_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPurchase_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSelling_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAvailableQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderProductsInventory = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbMin_stock_alert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btaCansel2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.lbInventoryID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductsInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpLast_purchase_date
            // 
            this.dtpLast_purchase_date.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpLast_purchase_date.Location = new System.Drawing.Point(250, 410);
            this.dtpLast_purchase_date.Name = "dtpLast_purchase_date";
            this.dtpLast_purchase_date.ShowCheckBox = true;
            this.dtpLast_purchase_date.Size = new System.Drawing.Size(237, 20);
            this.dtpLast_purchase_date.TabIndex = 149;
            // 
            // cmbProdectName
            // 
            this.cmbProdectName.Enabled = false;
            this.cmbProdectName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdectName.FormattingEnabled = true;
            this.cmbProdectName.Location = new System.Drawing.Point(250, 138);
            this.cmbProdectName.Name = "cmbProdectName";
            this.cmbProdectName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProdectName.Size = new System.Drawing.Size(237, 28);
            this.cmbProdectName.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(43, 406);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 147;
            this.label5.Text = " : تاريخ اخر شراء للمنتج\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbVendor_name
            // 
            this.tbVendor_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVendor_name.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbVendor_name.ForeColor = System.Drawing.Color.Chocolate;
            this.tbVendor_name.Location = new System.Drawing.Point(250, 458);
            this.tbVendor_name.Name = "tbVendor_name";
            this.tbVendor_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbVendor_name.Size = new System.Drawing.Size(237, 32);
            this.tbVendor_name.TabIndex = 145;
            this.tbVendor_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVendor_name.Validating += new System.ComponentModel.CancelEventHandler(this.tbVendor_name_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(87, 460);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 146;
            this.label8.Text = "اسم المورد :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPurchase_price
            // 
            this.tbPurchase_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPurchase_price.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbPurchase_price.ForeColor = System.Drawing.Color.Chocolate;
            this.tbPurchase_price.Location = new System.Drawing.Point(250, 188);
            this.tbPurchase_price.Name = "tbPurchase_price";
            this.tbPurchase_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPurchase_price.Size = new System.Drawing.Size(237, 32);
            this.tbPurchase_price.TabIndex = 143;
            this.tbPurchase_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPurchase_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPurchase_price_KeyPress_1);
            this.tbPurchase_price.Validating += new System.ComponentModel.CancelEventHandler(this.tbPurchase_price_Validating_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(84, 190);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 144;
            this.label3.Text = " : سعر الشراء";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSelling_price
            // 
            this.tbSelling_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSelling_price.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbSelling_price.ForeColor = System.Drawing.Color.Chocolate;
            this.tbSelling_price.Location = new System.Drawing.Point(250, 242);
            this.tbSelling_price.Name = "tbSelling_price";
            this.tbSelling_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSelling_price.Size = new System.Drawing.Size(237, 32);
            this.tbSelling_price.TabIndex = 141;
            this.tbSelling_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSelling_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSelling_price_KeyPress_1);
            this.tbSelling_price.Validating += new System.ComponentModel.CancelEventHandler(this.tbSelling_price_Validating_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(88, 244);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 142;
            this.label4.Text = " : سعر البيع";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAvailableQuantity
            // 
            this.tbAvailableQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAvailableQuantity.Enabled = false;
            this.tbAvailableQuantity.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbAvailableQuantity.ForeColor = System.Drawing.Color.Chocolate;
            this.tbAvailableQuantity.Location = new System.Drawing.Point(250, 296);
            this.tbAvailableQuantity.Name = "tbAvailableQuantity";
            this.tbAvailableQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAvailableQuantity.Size = new System.Drawing.Size(237, 32);
            this.tbAvailableQuantity.TabIndex = 139;
            this.tbAvailableQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(36, 298);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 140;
            this.label7.Text = " : الكميه الحاليه بلمخزن";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderProductsInventory
            // 
            this.errorProviderProductsInventory.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderProductsInventory.ContainerControl = this;
            // 
            // tbMin_stock_alert
            // 
            this.tbMin_stock_alert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMin_stock_alert.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbMin_stock_alert.ForeColor = System.Drawing.Color.Chocolate;
            this.tbMin_stock_alert.Location = new System.Drawing.Point(250, 350);
            this.tbMin_stock_alert.Name = "tbMin_stock_alert";
            this.tbMin_stock_alert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMin_stock_alert.Size = new System.Drawing.Size(237, 32);
            this.tbMin_stock_alert.TabIndex = 137;
            this.tbMin_stock_alert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMin_stock_alert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMin_stock_alert_KeyPress_1);
            this.tbMin_stock_alert.Validating += new System.ComponentModel.CancelEventHandler(this.tbMin_stock_alert_Validating_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(68, 352);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 138;
            this.label6.Text = "اقل عدد لتنبيه :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(581, 516);
            this.btaCansel2.Name = "btaCansel2";
            this.btaCansel2.Size = new System.Drawing.Size(109, 34);
            this.btaCansel2.TabIndex = 132;
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
            this.btnSave.Location = new System.Drawing.Point(453, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 131;
            this.btnSave.Text = "حـفــظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(75, 82);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = " : معرف المخزن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(75, 136);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 134;
            this.label1.Text = " :  اســـم المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAddAndEdit
            // 
            this.lbAddAndEdit.AutoSize = true;
            this.lbAddAndEdit.BackColor = System.Drawing.Color.Transparent;
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbAddAndEdit.Location = new System.Drawing.Point(203, 9);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.Size = new System.Drawing.Size(289, 44);
            this.lbAddAndEdit.TabIndex = 133;
            this.lbAddAndEdit.Text = "اضافة المنتج الئ المخزن";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInventoryID
            // 
            this.lbInventoryID.AutoSize = true;
            this.lbInventoryID.BackColor = System.Drawing.Color.Transparent;
            this.lbInventoryID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbInventoryID.ForeColor = System.Drawing.Color.Black;
            this.lbInventoryID.Location = new System.Drawing.Point(309, 82);
            this.lbInventoryID.Name = "lbInventoryID";
            this.lbInventoryID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInventoryID.Size = new System.Drawing.Size(78, 29);
            this.lbInventoryID.TabIndex = 136;
            this.lbInventoryID.Text = "#####";
            this.lbInventoryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddProductToInventorey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 558);
            this.Controls.Add(this.dtpLast_purchase_date);
            this.Controls.Add(this.cmbProdectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVendor_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPurchase_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSelling_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAvailableQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMin_stock_alert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btaCansel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddAndEdit);
            this.Controls.Add(this.lbInventoryID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProductToInventorey";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة المنتج الئ المخزن";
            this.Load += new System.EventHandler(this.frmAddProductToInventorey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductsInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpLast_purchase_date;
        private System.Windows.Forms.ComboBox cmbProdectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVendor_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPurchase_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSelling_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAvailableQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderProductsInventory;
        private System.Windows.Forms.TextBox tbMin_stock_alert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.Label lbInventoryID;
    }
}