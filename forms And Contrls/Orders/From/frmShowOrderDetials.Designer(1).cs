namespace ETEZAN2024.forms_And_Contrls.Orders.From
{
    partial class frmShowOrderDetials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowOrderDetials));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlOrderCard1 = new ETEZAN2024.forms_And_Contrls.Orders.control.ctrlOrderCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(287, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "معلومات الطلب";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(558, 543);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(70, 33);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "الـلـغــاء";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlOrderCard1
            // 
            this.ctrlOrderCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlOrderCard1.BackgroundImage")));
            this.ctrlOrderCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlOrderCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlOrderCard1.ForeColor = System.Drawing.Color.White;
            this.ctrlOrderCard1.Location = new System.Drawing.Point(9, 12);
            this.ctrlOrderCard1.Name = "ctrlOrderCard1";
            this.ctrlOrderCard1.Size = new System.Drawing.Size(642, 593);
            this.ctrlOrderCard1.TabIndex = 0;
            // 
            // frmShowOrderDetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 619);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlOrderCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowOrderDetials";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات الطلب";
            this.Load += new System.EventHandler(this.frmShowOrderDetials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private control.ctrlOrderCard ctrlOrderCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}