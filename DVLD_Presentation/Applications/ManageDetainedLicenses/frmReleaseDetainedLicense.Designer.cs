namespace DVLD_Presentation
{
    partial class frmReleaseDetainedLicense
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
            this.btnRelease = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLicenseInfo1 = new DVLD_Presentation.Controls.ctrlLicenseInfo();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblApplicationIDValue = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblFineFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblLicenseIDValue = new System.Windows.Forms.Label();
            this.lblDetainDateValue = new System.Windows.Forms.Label();
            this.lblDetainIDValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
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
            this.llblShowLicenseHistory.Location = new System.Drawing.Point(217, 844);
            this.llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            this.llblShowLicenseHistory.Size = new System.Drawing.Size(201, 25);
            this.llblShowLicenseHistory.TabIndex = 97;
            this.llblShowLicenseHistory.TabStop = true;
            this.llblShowLicenseHistory.Text = "Show License History";
            this.llblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(12, 844);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(180, 25);
            this.llblShowLicenseInfo.TabIndex = 96;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show Liscense Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(464, 844);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 95;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BorderRadius = 15;
            this.btnRelease.Enabled = false;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Location = new System.Drawing.Point(750, 844);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(149, 50);
            this.btnRelease.TabIndex = 94;
            this.btnRelease.Text = "Relase";
            this.btnRelease.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(12, 140);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(897, 408);
            this.ctrlLicenseInfo1.TabIndex = 93;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblApplicationIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationID);
            this.guna2GroupBox1.Controls.Add(this.lblFineFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblTotalFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblTotalFees);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFees);
            this.guna2GroupBox1.Controls.Add(this.lblFineFees);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedByValue);
            this.guna2GroupBox1.Controls.Add(this.lblLicenseIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblDetainDateValue);
            this.guna2GroupBox1.Controls.Add(this.lblDetainIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedBy);
            this.guna2GroupBox1.Controls.Add(this.lblDetainDate);
            this.guna2GroupBox1.Controls.Add(this.lblLicenseID);
            this.guna2GroupBox1.Controls.Add(this.lblDetainID);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 568);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(897, 258);
            this.guna2GroupBox1.TabIndex = 92;
            this.guna2GroupBox1.Text = "Release License Info ";
            // 
            // lblApplicationIDValue
            // 
            this.lblApplicationIDValue.AutoSize = true;
            this.lblApplicationIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationIDValue.Location = new System.Drawing.Point(635, 195);
            this.lblApplicationIDValue.Name = "lblApplicationIDValue";
            this.lblApplicationIDValue.Size = new System.Drawing.Size(79, 30);
            this.lblApplicationIDValue.TabIndex = 101;
            this.lblApplicationIDValue.Text = "[--??--]";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(462, 195);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(167, 30);
            this.lblApplicationID.TabIndex = 100;
            this.lblApplicationID.Text = "Application ID :";
            // 
            // lblFineFeesValue
            // 
            this.lblFineFeesValue.AutoSize = true;
            this.lblFineFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblFineFeesValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblFineFeesValue.Location = new System.Drawing.Point(635, 148);
            this.lblFineFeesValue.Name = "lblFineFeesValue";
            this.lblFineFeesValue.Size = new System.Drawing.Size(79, 30);
            this.lblFineFeesValue.TabIndex = 99;
            this.lblFineFeesValue.Text = "[--??--]";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFeesValue.Location = new System.Drawing.Point(211, 195);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(79, 30);
            this.lblTotalFeesValue.TabIndex = 98;
            this.lblTotalFeesValue.Text = "[--??--]";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(84, 195);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(121, 30);
            this.lblTotalFees.TabIndex = 97;
            this.lblTotalFees.Text = "Total Fees :";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(211, 148);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(79, 30);
            this.lblApplicationFeesValue.TabIndex = 96;
            this.lblApplicationFeesValue.Text = "[--??--]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(18, 148);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(187, 30);
            this.lblApplicationFees.TabIndex = 95;
            this.lblApplicationFees.Text = "Application Fees :";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFineFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.Black;
            this.lblFineFees.Location = new System.Drawing.Point(515, 148);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(114, 30);
            this.lblFineFees.TabIndex = 93;
            this.lblFineFees.Text = "Fine Fees :";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByValue.Location = new System.Drawing.Point(635, 105);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(79, 30);
            this.lblCreatedByValue.TabIndex = 87;
            this.lblCreatedByValue.Text = "[--??--]";
            // 
            // lblLicenseIDValue
            // 
            this.lblLicenseIDValue.AutoSize = true;
            this.lblLicenseIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseIDValue.Location = new System.Drawing.Point(635, 55);
            this.lblLicenseIDValue.Name = "lblLicenseIDValue";
            this.lblLicenseIDValue.Size = new System.Drawing.Size(79, 30);
            this.lblLicenseIDValue.TabIndex = 82;
            this.lblLicenseIDValue.Text = "[--??--]";
            // 
            // lblDetainDateValue
            // 
            this.lblDetainDateValue.AutoSize = true;
            this.lblDetainDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainDateValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDateValue.Location = new System.Drawing.Point(211, 105);
            this.lblDetainDateValue.Name = "lblDetainDateValue";
            this.lblDetainDateValue.Size = new System.Drawing.Size(79, 30);
            this.lblDetainDateValue.TabIndex = 81;
            this.lblDetainDateValue.Text = "[--??--]";
            // 
            // lblDetainIDValue
            // 
            this.lblDetainIDValue.AutoSize = true;
            this.lblDetainIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblDetainIDValue.Location = new System.Drawing.Point(211, 55);
            this.lblDetainIDValue.Name = "lblDetainIDValue";
            this.lblDetainIDValue.Size = new System.Drawing.Size(79, 30);
            this.lblDetainIDValue.TabIndex = 80;
            this.lblDetainIDValue.Text = "[--??--]";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(499, 105);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(130, 30);
            this.lblCreatedBy.TabIndex = 78;
            this.lblCreatedBy.Text = "Created By :";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDate.Location = new System.Drawing.Point(65, 105);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(140, 30);
            this.lblDetainDate.TabIndex = 75;
            this.lblDetainDate.Text = "Detain Date :";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseID.Location = new System.Drawing.Point(505, 55);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(124, 30);
            this.lblLicenseID.TabIndex = 74;
            this.lblLicenseID.Text = "License ID :";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.BackColor = System.Drawing.Color.Transparent;
            this.lblDetainID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.Black;
            this.lblDetainID.Location = new System.Drawing.Point(94, 55);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(111, 30);
            this.lblDetainID.TabIndex = 73;
            this.lblDetainID.Text = "DetainID :";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.lblSearch);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(12, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(897, 131);
            this.gbFilter.TabIndex = 91;
            this.gbFilter.Text = "Filter";
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 926);
            this.Controls.Add(this.llblShowLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.gbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "frmReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
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
        private Guna.UI2.WinForms.Guna2Button btnRelease;
        private Controls.ctrlLicenseInfo ctrlLicenseInfo1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblLicenseIDValue;
        private System.Windows.Forms.Label lblDetainDateValue;
        private System.Windows.Forms.Label lblDetainIDValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetainID;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Button btnFindLicense;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFineFeesValue;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationIDValue;
        private System.Windows.Forms.Label lblApplicationID;
    }
}