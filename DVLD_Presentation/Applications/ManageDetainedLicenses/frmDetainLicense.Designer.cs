namespace DVLD_Presentation
{
    partial class frmDetainLicense
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
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFineFeesValue = new System.Windows.Forms.TextBox();
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
            this.ctrlLicenseInfo1 = new DVLD_Presentation.Controls.ctrlLicenseInfo();
            this.guna2GroupBox1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblShowLicenseHistory
            // 
            this.llblShowLicenseHistory.AutoSize = true;
            this.llblShowLicenseHistory.Enabled = false;
            this.llblShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseHistory.Location = new System.Drawing.Point(249, 857);
            this.llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            this.llblShowLicenseHistory.Size = new System.Drawing.Size(201, 25);
            this.llblShowLicenseHistory.TabIndex = 90;
            this.llblShowLicenseHistory.TabStop = true;
            this.llblShowLicenseHistory.Text = "Show License History";
            this.llblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(44, 857);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(180, 25);
            this.llblShowLicenseInfo.TabIndex = 89;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show Liscense Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(471, 845);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BorderRadius = 15;
            this.btnDetain.Enabled = false;
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.Location = new System.Drawing.Point(781, 845);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(149, 50);
            this.btnDetain.TabIndex = 87;
            this.btnDetain.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtFineFeesValue);
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
            this.guna2GroupBox1.Location = new System.Drawing.Point(33, 595);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(897, 228);
            this.guna2GroupBox1.TabIndex = 85;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // txtFineFeesValue
            // 
            this.txtFineFeesValue.Location = new System.Drawing.Point(208, 183);
            this.txtFineFeesValue.Name = "txtFineFeesValue";
            this.txtFineFeesValue.Size = new System.Drawing.Size(100, 25);
            this.txtFineFeesValue.TabIndex = 94;
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFineFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.Black;
            this.lblFineFees.Location = new System.Drawing.Point(88, 176);
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
            this.lblCreatedByValue.Location = new System.Drawing.Point(637, 114);
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
            this.lblLicenseIDValue.Location = new System.Drawing.Point(631, 54);
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
            this.lblDetainDateValue.Location = new System.Drawing.Point(205, 114);
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
            this.lblDetainIDValue.Location = new System.Drawing.Point(205, 54);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(501, 114);
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
            this.lblDetainDate.Location = new System.Drawing.Point(62, 114);
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
            this.lblLicenseID.Location = new System.Drawing.Point(501, 54);
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
            this.lblDetainID.Location = new System.Drawing.Point(91, 54);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(111, 30);
            this.lblDetainID.TabIndex = 73;
            this.lblDetainID.Text = "DetainID :";
            this.lblDetainID.Click += new System.EventHandler(this.lblRApplicationID_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.lblSearch);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(33, 30);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(897, 131);
            this.gbFilter.TabIndex = 84;
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
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(33, 167);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(897, 408);
            this.ctrlLicenseInfo1.TabIndex = 86;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 970);
            this.Controls.Add(this.llblShowLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.gbFilter);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
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
        private Guna.UI2.WinForms.Guna2Button btnDetain;
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
        private System.Windows.Forms.TextBox txtFineFeesValue;
    }
}