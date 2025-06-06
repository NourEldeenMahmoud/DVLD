namespace DVLD_Presentation
{
    partial class frmRenewLicense
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
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnFindLicense = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblRenewLicenseIDValue = new System.Windows.Forms.Label();
            this.lblRenewLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblLicenseFeesValue = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblExpirationDateValue = new System.Windows.Forms.Label();
            this.lblIssueDateValue = new System.Windows.Forms.Label();
            this.lblOldLicenseIDValue = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.lblRLApplicationIDValue = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblRLApplicationID = new System.Windows.Forms.Label();
            this.llblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLicenseInfo1 = new DVLD_Presentation.Controls.ctrlLicenseInfo();
            this.gbFilter.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.lblSearch);
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFilter.Location = new System.Drawing.Point(12, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(897, 131);
            this.gbFilter.TabIndex = 69;
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
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindPerson_Click);
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
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.rtxtNotes);
            this.guna2GroupBox1.Controls.Add(this.lblNotes);
            this.guna2GroupBox1.Controls.Add(this.lblTotalFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblTotalFees);
            this.guna2GroupBox1.Controls.Add(this.lblRenewLicenseIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblRenewLicenseID);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFees);
            this.guna2GroupBox1.Controls.Add(this.lblLicenseFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedByValue);
            this.guna2GroupBox1.Controls.Add(this.lblIssueDate);
            this.guna2GroupBox1.Controls.Add(this.lblExpirationDateValue);
            this.guna2GroupBox1.Controls.Add(this.lblIssueDateValue);
            this.guna2GroupBox1.Controls.Add(this.lblOldLicenseIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationDateValue);
            this.guna2GroupBox1.Controls.Add(this.lblRLApplicationIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblExpirationDate);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedBy);
            this.guna2GroupBox1.Controls.Add(this.lblLicenseFees);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationDate);
            this.guna2GroupBox1.Controls.Add(this.lblOldLicenseID);
            this.guna2GroupBox1.Controls.Add(this.lblRLApplicationID);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 577);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(897, 228);
            this.guna2GroupBox1.TabIndex = 71;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(693, 128);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(160, 60);
            this.rtxtNotes.TabIndex = 100;
            this.rtxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(621, 125);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 21);
            this.lblNotes.TabIndex = 99;
            this.lblNotes.Text = "Notes :";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFeesValue.Location = new System.Drawing.Point(690, 63);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(50, 17);
            this.lblTotalFeesValue.TabIndex = 98;
            this.lblTotalFeesValue.Text = "[--??--]";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(591, 63);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(93, 21);
            this.lblTotalFees.TabIndex = 97;
            this.lblTotalFees.Text = "Total Fees :";
            // 
            // lblRenewLicenseIDValue
            // 
            this.lblRenewLicenseIDValue.AutoSize = true;
            this.lblRenewLicenseIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRenewLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLicenseIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblRenewLicenseIDValue.Location = new System.Drawing.Point(467, 128);
            this.lblRenewLicenseIDValue.Name = "lblRenewLicenseIDValue";
            this.lblRenewLicenseIDValue.Size = new System.Drawing.Size(50, 17);
            this.lblRenewLicenseIDValue.TabIndex = 96;
            this.lblRenewLicenseIDValue.Text = "[--??--]";
            // 
            // lblRenewLicenseID
            // 
            this.lblRenewLicenseID.AutoSize = true;
            this.lblRenewLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblRenewLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblRenewLicenseID.Location = new System.Drawing.Point(311, 124);
            this.lblRenewLicenseID.Name = "lblRenewLicenseID";
            this.lblRenewLicenseID.Size = new System.Drawing.Size(150, 21);
            this.lblRenewLicenseID.TabIndex = 95;
            this.lblRenewLicenseID.Text = "Renew License ID :";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(171, 165);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(50, 17);
            this.lblApplicationFeesValue.TabIndex = 94;
            this.lblApplicationFeesValue.Text = "[--??--]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(22, 161);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(144, 21);
            this.lblApplicationFees.TabIndex = 93;
            this.lblApplicationFees.Text = "Application Fees :";
            // 
            // lblLicenseFeesValue
            // 
            this.lblLicenseFeesValue.AutoSize = true;
            this.lblLicenseFeesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseFeesValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFeesValue.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseFeesValue.Location = new System.Drawing.Point(467, 63);
            this.lblLicenseFeesValue.Name = "lblLicenseFeesValue";
            this.lblLicenseFeesValue.Size = new System.Drawing.Size(50, 17);
            this.lblLicenseFeesValue.TabIndex = 88;
            this.lblLicenseFeesValue.Text = "[--??--]";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByValue.Location = new System.Drawing.Point(690, 97);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(50, 17);
            this.lblCreatedByValue.TabIndex = 87;
            this.lblCreatedByValue.Text = "[--??--]";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(70, 124);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(96, 21);
            this.lblIssueDate.TabIndex = 85;
            this.lblIssueDate.Text = "Issue Date :";
            // 
            // lblExpirationDateValue
            // 
            this.lblExpirationDateValue.AutoSize = true;
            this.lblExpirationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblExpirationDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDateValue.Location = new System.Drawing.Point(467, 165);
            this.lblExpirationDateValue.Name = "lblExpirationDateValue";
            this.lblExpirationDateValue.Size = new System.Drawing.Size(50, 17);
            this.lblExpirationDateValue.TabIndex = 84;
            this.lblExpirationDateValue.Text = "[--??--]";
            // 
            // lblIssueDateValue
            // 
            this.lblIssueDateValue.AutoSize = true;
            this.lblIssueDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblIssueDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDateValue.Location = new System.Drawing.Point(171, 128);
            this.lblIssueDateValue.Name = "lblIssueDateValue";
            this.lblIssueDateValue.Size = new System.Drawing.Size(50, 17);
            this.lblIssueDateValue.TabIndex = 83;
            this.lblIssueDateValue.Text = "[--??--]";
            // 
            // lblOldLicenseIDValue
            // 
            this.lblOldLicenseIDValue.AutoSize = true;
            this.lblOldLicenseIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblOldLicenseIDValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseIDValue.Location = new System.Drawing.Point(467, 96);
            this.lblOldLicenseIDValue.Name = "lblOldLicenseIDValue";
            this.lblOldLicenseIDValue.Size = new System.Drawing.Size(50, 17);
            this.lblOldLicenseIDValue.TabIndex = 82;
            this.lblOldLicenseIDValue.Text = "[--??--]";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateValue.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateValue.Location = new System.Drawing.Point(171, 91);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(50, 17);
            this.lblApplicationDateValue.TabIndex = 81;
            this.lblApplicationDateValue.Text = "[--??--]";
            // 
            // lblRLApplicationIDValue
            // 
            this.lblRLApplicationIDValue.AutoSize = true;
            this.lblRLApplicationIDValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRLApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLApplicationIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblRLApplicationIDValue.Location = new System.Drawing.Point(171, 54);
            this.lblRLApplicationIDValue.Name = "lblRLApplicationIDValue";
            this.lblRLApplicationIDValue.Size = new System.Drawing.Size(50, 17);
            this.lblRLApplicationIDValue.TabIndex = 80;
            this.lblRLApplicationIDValue.Text = "[--??--]";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(324, 161);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(137, 21);
            this.lblExpirationDate.TabIndex = 79;
            this.lblExpirationDate.Text = "Expiration Date :";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(584, 93);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(100, 21);
            this.lblCreatedBy.TabIndex = 78;
            this.lblCreatedBy.Text = "Created By :";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseFees.Location = new System.Drawing.Point(350, 63);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(111, 21);
            this.lblLicenseFees.TabIndex = 76;
            this.lblLicenseFees.Text = "License Fees :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(19, 87);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(147, 21);
            this.lblApplicationDate.TabIndex = 75;
            this.lblApplicationDate.Text = "Application Date :";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseID.Location = new System.Drawing.Point(335, 92);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(126, 21);
            this.lblOldLicenseID.TabIndex = 74;
            this.lblOldLicenseID.Text = "Old License ID :";
            // 
            // lblRLApplicationID
            // 
            this.lblRLApplicationID.AutoSize = true;
            this.lblRLApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.lblRLApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblRLApplicationID.Location = new System.Drawing.Point(12, 50);
            this.lblRLApplicationID.Name = "lblRLApplicationID";
            this.lblRLApplicationID.Size = new System.Drawing.Size(154, 21);
            this.lblRLApplicationID.TabIndex = 73;
            this.lblRLApplicationID.Text = "R.L.Applicatoin ID :";
            // 
            // llblShowLicenseHistory
            // 
            this.llblShowLicenseHistory.AutoSize = true;
            this.llblShowLicenseHistory.Enabled = false;
            this.llblShowLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseHistory.Location = new System.Drawing.Point(228, 839);
            this.llblShowLicenseHistory.Name = "llblShowLicenseHistory";
            this.llblShowLicenseHistory.Size = new System.Drawing.Size(201, 25);
            this.llblShowLicenseHistory.TabIndex = 76;
            this.llblShowLicenseHistory.TabStop = true;
            this.llblShowLicenseHistory.Text = "Show License History";
            this.llblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(23, 839);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(180, 25);
            this.llblShowLicenseInfo.TabIndex = 75;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show Liscense Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(547, 827);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 15;
            this.btnIssue.Enabled = false;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(760, 827);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(149, 50);
            this.btnIssue.TabIndex = 73;
            this.btnIssue.Text = "Issue 💾";
            this.btnIssue.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(12, 149);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(897, 408);
            this.ctrlLicenseInfo1.TabIndex = 72;
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 933);
            this.Controls.Add(this.llblShowLicenseHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.gbFilter);
            this.Name = "frmRenewLicense";
            this.Text = "frmRenewLicense";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Button btnFindLicense;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblLicenseFeesValue;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpirationDateValue;
        private System.Windows.Forms.Label lblIssueDateValue;
        private System.Windows.Forms.Label lblOldLicenseIDValue;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblRLApplicationIDValue;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblRLApplicationID;
        private System.Windows.Forms.Label lblRenewLicenseIDValue;
        private System.Windows.Forms.Label lblRenewLicenseID;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Controls.ctrlLicenseInfo ctrlLicenseInfo1;
        private System.Windows.Forms.LinkLabel llblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
    }
}