namespace DVLD_Presentation.LocalDrivingLicense
{
    partial class frmShowLDLAppDetails
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
            this.ctrlApplicationInfo1 = new DVLD_Presentation.Controls.ctrlApplicationInfo();
            this.ctrlLDLAppInfo1 = new DVLD_Presentation.Controls.ctrlLDLAppInfo();
            this.SuspendLayout();
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(23, 205);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(867, 257);
            this.ctrlApplicationInfo1.TabIndex = 0;
            this.ctrlApplicationInfo1.Load += new System.EventHandler(this.ctrlApplicationInfo1_Load);
            // 
            // ctrlLDLAppInfo1
            // 
            this.ctrlLDLAppInfo1.Location = new System.Drawing.Point(23, 12);
            this.ctrlLDLAppInfo1.Name = "ctrlLDLAppInfo1";
            this.ctrlLDLAppInfo1.Size = new System.Drawing.Size(867, 187);
            this.ctrlLDLAppInfo1.TabIndex = 1;
            this.ctrlLDLAppInfo1.Load += new System.EventHandler(this.ctrlLDLAppInfo1_Load);
            // 
            // frmShowLDLAppDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 472);
            this.Controls.Add(this.ctrlLDLAppInfo1);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Name = "frmShowLDLAppDetails";
            this.Text = "frmShowLDLAppDetails";
            this.Load += new System.EventHandler(this.frmShowLDLAppDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private Controls.ctrlLDLAppInfo ctrlLDLAppInfo1;
    }
}