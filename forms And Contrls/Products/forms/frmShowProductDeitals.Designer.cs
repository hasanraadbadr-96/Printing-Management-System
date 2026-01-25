namespace ETEZAN2024.forms_And_Contrls.Products.forms
{
    partial class frmShowProductDeitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowProductDeitals));
            this.ctrlProductCard1 = new ETEZAN2024.forms_And_Contrls.Products.controls.ctrlProductCard();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlProductCard1
            // 
            this.ctrlProductCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlProductCard1.BackgroundImage")));
            this.ctrlProductCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlProductCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlProductCard1.Location = new System.Drawing.Point(21, 45);
            this.ctrlProductCard1.Name = "ctrlProductCard1";
            this.ctrlProductCard1.Size = new System.Drawing.Size(559, 478);
            this.ctrlProductCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("mohammad bold art 1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "معلومات المنتج";
            // 
            // frmShowProductDeitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlProductCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowProductDeitals";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معلومات المنتج";
            this.Load += new System.EventHandler(this.frmShowProductDeitals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.ctrlProductCard ctrlProductCard1;
        private System.Windows.Forms.Label label1;
    }
}