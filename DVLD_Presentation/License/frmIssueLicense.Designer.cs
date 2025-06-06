namespace DVLD_Presentation.License
{
    partial class frmIssueLicense
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
            this.ctrlLDLAppInfo1 = new DVLD_Presentation.Controls.ctrlLDLAppInfo();
            this.ctrlApplicationInfo1 = new DVLD_Presentation.Controls.ctrlApplicationInfo();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlLDLAppInfo1
            // 
            this.ctrlLDLAppInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLDLAppInfo1.Name = "ctrlLDLAppInfo1";
            this.ctrlLDLAppInfo1.Size = new System.Drawing.Size(871, 181);
            this.ctrlLDLAppInfo1.TabIndex = 0;
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(20, 209);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(873, 247);
            this.ctrlApplicationInfo1.TabIndex = 1;
            this.ctrlApplicationInfo1.Load += new System.EventHandler(this.ctrlApplicationInfo1_Load);
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(146, 472);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(737, 96);
            this.rtxtNotes.TabIndex = 2;
            this.rtxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(26, 472);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(114, 40);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes :";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(146, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 50);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 15;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(741, 598);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(142, 50);
            this.btnIssue.TabIndex = 62;
            this.btnIssue.Text = "Issue 💾";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // frmIssueLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 689);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtxtNotes);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.ctrlLDLAppInfo1);
            this.Name = "frmIssueLicense";
            this.Text = "frmIssueLicense";
            this.Load += new System.EventHandler(this.frmIssueLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlLDLAppInfo ctrlLDLAppInfo1;
        private Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
    }
}