namespace DVLD_Presentation.InternationalLicense
{
    partial class frmShowIntLicenseInfo
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
            this.ctrlInternationalLicenseInfo1 = new DVLD_Presentation.Controls.ctrlInternationalLicenseInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlInternationalLicenseInfo1
            // 
            this.ctrlInternationalLicenseInfo1.Location = new System.Drawing.Point(24, 122);
            this.ctrlInternationalLicenseInfo1.Name = "ctrlInternationalLicenseInfo1";
            this.ctrlInternationalLicenseInfo1.Size = new System.Drawing.Size(1004, 405);
            this.ctrlInternationalLicenseInfo1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 47);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "International License Details ";
            // 
            // frmShowIntLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 510);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlInternationalLicenseInfo1);
            this.Name = "frmShowIntLicenseInfo";
            this.Text = "frmShowLicenseInfo";
            this.Load += new System.EventHandler(this.frmShowIntLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlInternationalLicenseInfo ctrlInternationalLicenseInfo1;
        private System.Windows.Forms.Label lblTitle;
    }
}