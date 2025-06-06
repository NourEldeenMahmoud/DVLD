namespace DVLD_Presentation
{
    partial class frmReplacmentForDamageOrLost
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
            this.llblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnIssueReplacement = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLicenseInfo1 = new DVLD_Presentation.Controls.ctrlLicenseInfo();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblReplacedLicenseIDValue = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.lblRApplicationIDValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblRApplicationID = new System.Windows.Forms.Label();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbDamage = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLost = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnFindLicense = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblShowLicenseHistory
            // 
            this.llblShowLicenseHistory.AutoSize = true;
            this.llblShowLicenseHistory.Enabled = false;
            this.llblShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseHistory.Location = new System.Drawing.Point(245, 839);
            this.llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            this.llblShowLicenseHistory.Size = new System.Drawing.Size(201, 25);
            this.llblShowLicenseHistory.TabIndex = 83;
            this.llblShowLicenseHistory.TabStop = true;
            this.llblShowLicenseHistory.Text = "Show License History";
            this.llblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(40, 839);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(180, 25);
            this.llblShowLicenseInfo.TabIndex = 82;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show Liscense Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(467, 827);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BorderRadius = 15;
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.ForeColor = System.Drawing.Color.White;
            this.btnIssueReplacement.Location = new System.Drawing.Point(685, 827);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(241, 50);
            this.btnIssueReplacement.TabIndex = 80;
            this.btnIssueReplacement.Text = "Issue Replacement 💾";
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(29, 149);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(897, 408);
            this.ctrlLicenseInfo1.TabIndex = 79;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblReplacedLicenseIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblReplacedLicenseID);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFees);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedByValue);
            this.guna2GroupBox1.Controls.Add(this.lblOldLicenseIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationDateValue);
            this.guna2GroupBox1.Controls.Add(this.lblRApplicationIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedBy);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationDate);
            this.guna2GroupBox1.Controls.Add(this.lblOldLicenseID);
            this.guna2GroupBox1.Controls.Add(this.lblRApplicationID);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(29, 577);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(897, 228);
            this.guna2GroupBox1.TabIndex = 78;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // lblReplacedLicenseIDValue
            // 
            this.lblReplacedLicenseIDValue.AutoSize = true;
            this.lblReplacedLicenseIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblReplacedLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblReplacedLicenseIDValue.Location = new System.Drawing.Point(631, 114);
            this.lblReplacedLicenseIDValue.Name = "lblReplacedLicenseIDValue";
            this.lblReplacedLicenseIDValue.Size = new System.Drawing.Size(79, 30);
            this.lblReplacedLicenseIDValue.TabIndex = 96;
            this.lblReplacedLicenseIDValue.Text = "[--??--]";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(407, 114);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(218, 30);
            this.lblReplacedLicenseID.TabIndex = 95;
            this.lblReplacedLicenseID.Text = "Replaced License ID :";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(205, 176);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(79, 30);
            this.lblApplicationFeesValue.TabIndex = 94;
            this.lblApplicationFeesValue.Text = "[--??--]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(15, 176);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(187, 30);
            this.lblApplicationFees.TabIndex = 93;
            this.lblApplicationFees.Text = "Application Fees :";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByValue.Location = new System.Drawing.Point(631, 176);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(79, 30);
            this.lblCreatedByValue.TabIndex = 87;
            this.lblCreatedByValue.Text = "[--??--]";
            // 
            // lblOldLicenseIDValue
            // 
            this.lblOldLicenseIDValue.AutoSize = true;
            this.lblOldLicenseIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblOldLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseIDValue.Location = new System.Drawing.Point(631, 54);
            this.lblOldLicenseIDValue.Name = "lblOldLicenseIDValue";
            this.lblOldLicenseIDValue.Size = new System.Drawing.Size(79, 30);
            this.lblOldLicenseIDValue.TabIndex = 82;
            this.lblOldLicenseIDValue.Text = "[--??--]";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateValue.Location = new System.Drawing.Point(205, 114);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(79, 30);
            this.lblApplicationDateValue.TabIndex = 81;
            this.lblApplicationDateValue.Text = "[--??--]";
            // 
            // lblRApplicationIDValue
            // 
            this.lblRApplicationIDValue.AutoSize = true;
            this.lblRApplicationIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRApplicationIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblRApplicationIDValue.Location = new System.Drawing.Point(205, 54);
            this.lblRApplicationIDValue.Name = "lblRApplicationIDValue";
            this.lblRApplicationIDValue.Size = new System.Drawing.Size(79, 30);
            this.lblRApplicationIDValue.TabIndex = 80;
            this.lblRApplicationIDValue.Text = "[--??--]";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(495, 176);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(130, 30);
            this.lblCreatedBy.TabIndex = 78;
            this.lblCreatedBy.Text = "Created By :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(12, 114);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(190, 30);
            this.lblApplicationDate.TabIndex = 75;
            this.lblApplicationDate.Text = "Application Date :";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseID.Location = new System.Drawing.Point(460, 54);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(165, 30);
            this.lblOldLicenseID.TabIndex = 74;
            this.lblOldLicenseID.Text = "Old License ID :";
            // 
            // lblRApplicationID
            // 
            this.lblRApplicationID.AutoSize = true;
            this.lblRApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblRApplicationID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblRApplicationID.Location = new System.Drawing.Point(15, 54);
            this.lblRApplicationID.Name = "lblRApplicationID";
            this.lblRApplicationID.Size = new System.Drawing.Size(187, 30);
            this.lblRApplicationID.TabIndex = 73;
            this.lblRApplicationID.Text = "R.Applicatoin ID :";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rbDamage);
            this.gbFilter.Controls.Add(this.rbLost);
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.lblSearch);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(29, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(897, 131);
            this.gbFilter.TabIndex = 77;
            this.gbFilter.Text = "Filter";
            // 
            // rbDamage
            // 
            this.rbDamage.AutoSize = true;
            this.rbDamage.BackColor = System.Drawing.Color.Transparent;
            this.rbDamage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDamage.CheckedState.BorderThickness = 0;
            this.rbDamage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDamage.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDamage.CheckedState.InnerOffset = -4;
            this.rbDamage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamage.ForeColor = System.Drawing.Color.Black;
            this.rbDamage.Location = new System.Drawing.Point(560, 90);
            this.rbDamage.Name = "rbDamage";
            this.rbDamage.Size = new System.Drawing.Size(239, 25);
            this.rbDamage.TabIndex = 7;
            this.rbDamage.Tag = "3";
            this.rbDamage.Text = "Replacement Form Damage";
            this.rbDamage.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDamage.UncheckedState.BorderThickness = 2;
            this.rbDamage.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDamage.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDamage.UseVisualStyleBackColor = false;
            this.rbDamage.CheckedChanged += new System.EventHandler(this.rbDamage_CheckedChanged);
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.BackColor = System.Drawing.Color.Transparent;
            this.rbLost.Checked = true;
            this.rbLost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLost.CheckedState.BorderThickness = 0;
            this.rbLost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLost.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLost.CheckedState.InnerOffset = -4;
            this.rbLost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLost.ForeColor = System.Drawing.Color.Black;
            this.rbLost.Location = new System.Drawing.Point(560, 51);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(191, 25);
            this.rbLost.TabIndex = 6;
            this.rbLost.TabStop = true;
            this.rbLost.Tag = "4";
            this.rbLost.Text = "Replacement For Lost";
            this.rbLost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLost.UncheckedState.BorderThickness = 2;
            this.rbLost.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLost.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLost.UseVisualStyleBackColor = false;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnFindLicense.BackgroundImage = global::DVLD_Presentation.Properties.Resources.search;
            this.btnFindLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindLicense.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindLicense.Location = new System.Drawing.Point(452, 57);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.Size = new System.Drawing.Size(58, 58);
            this.btnFindLicense.TabIndex = 5;
            this.btnFindLicense.UseVisualStyleBackColor = false;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(144, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 29);
            this.txtSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(27, 71);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "License ID :";
            // 
            // frmReplacmentForDamageOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 896);
            this.Controls.Add(this.llblShowLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.gbFilter);
            this.Name = "frmReplacmentForDamageOrLost";
            this.Text = "frmReplacmentForDamageOrLost";
            this.Load += new System.EventHandler(this.frmReplacmentForDamageOrLost_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnIssueReplacement;
        private Controls.ctrlLicenseInfo ctrlLicenseInfo1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblRApplicationIDValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblRApplicationID;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2RadioButton rbDamage;
        private Guna.UI2.WinForms.Guna2RadioButton rbLost;
        private System.Windows.Forms.Button btnFindLicense;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReplacedLicenseIDValue;
    }
}