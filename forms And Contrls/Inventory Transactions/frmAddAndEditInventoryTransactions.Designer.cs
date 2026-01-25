namespace ETEZAN2024.forms_And_Contrls.Inventory_Transactions
{
    partial class frmAddAndEditInventoryTransactions
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
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbProdectName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderProductsInventory = new System.Windows.Forms.ErrorProvider(this.components);
            this.btaCansel2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddAndEdit = new System.Windows.Forms.Label();
            this.lbInventoryID = new System.Windows.Forms.Label();
            this.cmbTypeInventoryTransaction = new System.Windows.Forms.ComboBox();
            this.tbOrderItemID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductsInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(201, 353);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.ShowCheckBox = true;
            this.dtpdate.Size = new System.Drawing.Size(237, 20);
            this.dtpdate.TabIndex = 149;
            // 
            // cmbProdectName
            // 
            this.cmbProdectName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdectName.FormattingEnabled = true;
            this.cmbProdectName.Location = new System.Drawing.Point(202, 131);
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
            this.label5.Location = new System.Drawing.Point(70, 349);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 147;
            this.label5.Text = " : تاريخ \r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(50, 183);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 144;
            this.label3.Text = " : نوع الحركة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantity.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbQuantity.ForeColor = System.Drawing.Color.Chocolate;
            this.tbQuantity.Location = new System.Drawing.Point(202, 238);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbQuantity.Size = new System.Drawing.Size(237, 32);
            this.tbQuantity.TabIndex = 139;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            this.tbQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.tbQuantity_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(35, 240);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(150, 29);
            this.label7.TabIndex = 140;
            this.label7.Text = " : الكمية المتأثرة";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderProductsInventory
            // 
            this.errorProviderProductsInventory.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderProductsInventory.ContainerControl = this;
            // 
            // btaCansel2
            // 
            this.btaCansel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btaCansel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btaCansel2.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btaCansel2.ForeColor = System.Drawing.Color.Red;
            this.btaCansel2.Location = new System.Drawing.Point(529, 394);
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
            this.btnSave.Location = new System.Drawing.Point(401, 394);
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
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = " : معرف رقم الحركة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(49, 129);
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
            this.lbAddAndEdit.Font = new System.Drawing.Font("mohammad bold art 1", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAddAndEdit.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbAddAndEdit.Location = new System.Drawing.Point(180, 9);
            this.lbAddAndEdit.Name = "lbAddAndEdit";
            this.lbAddAndEdit.Size = new System.Drawing.Size(280, 37);
            this.lbAddAndEdit.TabIndex = 133;
            this.lbAddAndEdit.Text = "اضافة جرد لحركة المخزون";
            this.lbAddAndEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbInventoryID
            // 
            this.lbInventoryID.AutoSize = true;
            this.lbInventoryID.BackColor = System.Drawing.Color.Transparent;
            this.lbInventoryID.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbInventoryID.ForeColor = System.Drawing.Color.Black;
            this.lbInventoryID.Location = new System.Drawing.Point(261, 75);
            this.lbInventoryID.Name = "lbInventoryID";
            this.lbInventoryID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbInventoryID.Size = new System.Drawing.Size(78, 29);
            this.lbInventoryID.TabIndex = 136;
            this.lbInventoryID.Text = "#####";
            this.lbInventoryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTypeInventoryTransaction
            // 
            this.cmbTypeInventoryTransaction.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeInventoryTransaction.FormattingEnabled = true;
            this.cmbTypeInventoryTransaction.Location = new System.Drawing.Point(202, 185);
            this.cmbTypeInventoryTransaction.Name = "cmbTypeInventoryTransaction";
            this.cmbTypeInventoryTransaction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTypeInventoryTransaction.Size = new System.Drawing.Size(237, 28);
            this.cmbTypeInventoryTransaction.TabIndex = 150;
            // 
            // tbOrderItemID
            // 
            this.tbOrderItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOrderItemID.Font = new System.Drawing.Font("mohammad bold art 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbOrderItemID.ForeColor = System.Drawing.Color.Chocolate;
            this.tbOrderItemID.Location = new System.Drawing.Point(202, 294);
            this.tbOrderItemID.Name = "tbOrderItemID";
            this.tbOrderItemID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbOrderItemID.Size = new System.Drawing.Size(237, 32);
            this.tbOrderItemID.TabIndex = 151;
            this.tbOrderItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrderItemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOrderID_KeyPress);
            this.tbOrderItemID.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrderID_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("mohammad bold art 1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(38, 296);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 152;
            this.label4.Text = " :رقم عنصر الطلب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddAndEditInventoryTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 442);
            this.Controls.Add(this.tbOrderItemID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTypeInventoryTransaction);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.cmbProdectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btaCansel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddAndEdit);
            this.Controls.Add(this.lbInventoryID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditInventoryTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة جرد لحركة المخزون";
            this.Load += new System.EventHandler(this.frmAddAndEditInventoryTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProductsInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbProdectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderProductsInventory;
        private System.Windows.Forms.Button btaCansel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddAndEdit;
        private System.Windows.Forms.Label lbInventoryID;
        private System.Windows.Forms.ComboBox cmbTypeInventoryTransaction;
        private System.Windows.Forms.TextBox tbOrderItemID;
        private System.Windows.Forms.Label label4;
    }
}