namespace DVLD_Presentation.License
{
    partial class frmShowLicenseHistory
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
            this.ctrlLicenseHistory1 = new DVLD_Presentation.Controls.ctrlLicenseHistory();
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.Controls.ctrlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // ctrlLicenseHistory1
            // 
            this.ctrlLicenseHistory1.Location = new System.Drawing.Point(2, 627);
            this.ctrlLicenseHistory1.Name = "ctrlLicenseHistory1";
            this.ctrlLicenseHistory1.Size = new System.Drawing.Size(801, 342);
            this.ctrlLicenseHistory1.TabIndex = 1;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCardWithFilter1.ForeColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(22, 58);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(813, 563);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load);
            // 
            // frmShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 966);
            this.Controls.Add(this.ctrlLicenseHistory1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Name = "frmShowLicenseHistory";
            this.Text = "frmShowLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowLicenseHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Controls.ctrlLicenseHistory ctrlLicenseHistory1;
    }
}