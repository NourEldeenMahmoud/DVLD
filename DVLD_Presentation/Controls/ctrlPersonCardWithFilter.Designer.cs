namespace DVLD_Presentation.Controls
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
            this.ctrlPersonCard1 = new DVLD_Presentation.Controls.ctrlPersonCard();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(-35, 98);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(820, 495);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.BackColor = System.Drawing.Color.Transparent;
            this.lblFindBy.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.ForeColor = System.Drawing.Color.Black;
            this.lblFindBy.Location = new System.Drawing.Point(3, 67);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(132, 37);
            this.lblFindBy.TabIndex = 0;
            this.lblFindBy.Text = "Find By : ";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFilterBy.Location = new System.Drawing.Point(141, 74);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 29);
            this.cbFilterBy.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(282, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BackgroundImage = global::DVLD_Presentation.Properties.Resources.add;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.Location = new System.Drawing.Point(550, 57);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(58, 58);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.BackgroundImage = global::DVLD_Presentation.Properties.Resources.search;
            this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindPerson.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.Location = new System.Drawing.Point(477, 57);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(58, 58);
            this.btnFindPerson.TabIndex = 5;
            this.btnFindPerson.UseVisualStyleBackColor = false;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindPerson);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.lblFindBy);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(782, 131);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.Text = "Filter";
            this.gbFilter.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(793, 582);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnFindPerson;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
    }
}
