namespace ETEZAN2024.forms_And_Contrls.Persons.Control
{
    partial class ctrlPersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbPersonFilter = new System.Windows.Forms.GroupBox();
            this.pBoxAddPerson = new System.Windows.Forms.PictureBox();
            this.pBoxFindPerson = new System.Windows.Forms.PictureBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilterPerson = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new ETEZAN2024.forms_And_Contrls.Persons.Control.ctrlPersonCard();
            this.gbPersonFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFindPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonFilter
            // 
            this.gbPersonFilter.Controls.Add(this.pBoxAddPerson);
            this.gbPersonFilter.Controls.Add(this.pBoxFindPerson);
            this.gbPersonFilter.Controls.Add(this.cmbFilterBy);
            this.gbPersonFilter.Controls.Add(this.tbFilterPerson);
            this.gbPersonFilter.Font = new System.Drawing.Font("mohammad bold art 1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbPersonFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbPersonFilter.Location = new System.Drawing.Point(7, 2);
            this.gbPersonFilter.Name = "gbPersonFilter";
            this.gbPersonFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbPersonFilter.Size = new System.Drawing.Size(695, 69);
            this.gbPersonFilter.TabIndex = 1;
            this.gbPersonFilter.TabStop = false;
            this.gbPersonFilter.Text = "التصفية بواسطة";
            this.gbPersonFilter.Enter += new System.EventHandler(this.gbPersonFilter_Enter);
            // 
            // pBoxAddPerson
            // 
            this.pBoxAddPerson.BackColor = System.Drawing.Color.White;
            this.pBoxAddPerson.BackgroundImage = global::ETEZAN2024.Properties.Resources.add_user11;
            this.pBoxAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxAddPerson.ErrorImage = null;
            this.pBoxAddPerson.Location = new System.Drawing.Point(91, 16);
            this.pBoxAddPerson.Name = "pBoxAddPerson";
            this.pBoxAddPerson.Size = new System.Drawing.Size(55, 28);
            this.pBoxAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxAddPerson.TabIndex = 51;
            this.pBoxAddPerson.TabStop = false;
            this.pBoxAddPerson.Click += new System.EventHandler(this.pBoxAddPerson_Click);
            // 
            // pBoxFindPerson
            // 
            this.pBoxFindPerson.BackColor = System.Drawing.Color.White;
            this.pBoxFindPerson.BackgroundImage = global::ETEZAN2024.Properties.Resources.business;
            this.pBoxFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxFindPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBoxFindPerson.ErrorImage = null;
            this.pBoxFindPerson.Location = new System.Drawing.Point(169, 16);
            this.pBoxFindPerson.Name = "pBoxFindPerson";
            this.pBoxFindPerson.Size = new System.Drawing.Size(55, 28);
            this.pBoxFindPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxFindPerson.TabIndex = 50;
            this.pBoxFindPerson.TabStop = false;
            this.pBoxFindPerson.Click += new System.EventHandler(this.pBoxFindPerson_Click);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Location = new System.Drawing.Point(568, 17);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(121, 27);
            this.cmbFilterBy.TabIndex = 1;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // tbFilterPerson
            // 
            this.tbFilterPerson.Location = new System.Drawing.Point(255, 18);
            this.tbFilterPerson.Multiline = true;
            this.tbFilterPerson.Name = "tbFilterPerson";
            this.tbFilterPerson.Size = new System.Drawing.Size(288, 25);
            this.tbFilterPerson.TabIndex = 0;
            this.tbFilterPerson.TextChanged += new System.EventHandler(this.tbFilterPerson_TextChanged);
            this.tbFilterPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterPerson_KeyPress);
            this.tbFilterPerson.Validating += new System.ComponentModel.CancelEventHandler(this.tbFilterPerson_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.BackgroundImage = global::ETEZAN2024.Properties.Resources.LightMode1;
            this.ctrlPersonCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlPersonCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 73);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(699, 337);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ETEZAN2024.Properties.Resources.EYE;
            this.Controls.Add(this.gbPersonFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(707, 422);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbPersonFilter.ResumeLayout(false);
            this.gbPersonFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFindPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gbPersonFilter;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox tbFilterPerson;
        private System.Windows.Forms.PictureBox pBoxFindPerson;
        private System.Windows.Forms.PictureBox pBoxAddPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
