namespace DVLD_Presentation.License
{
    partial class frmShowLicense
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
            this.ctrlLicenseInfo1 = new DVLD_Presentation.Controls.ctrlLicenseInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(12, 89);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(908, 427);
            this.ctrlLicenseInfo1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(232, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 47);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Local Driver License Info";
            // 
            // frmShowLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 528);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Name = "frmShowLicense";
            this.Text = "frmShowLicense";
            this.Load += new System.EventHandler(this.frmShowLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlLicenseInfo ctrlLicenseInfo1;
        private System.Windows.Forms.Label lblTitle;
    }
}