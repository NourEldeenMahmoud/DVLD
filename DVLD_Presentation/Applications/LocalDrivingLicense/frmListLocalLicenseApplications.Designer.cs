namespace DVLD_Presentation.NewLocalDrivingLicense
{
    partial class frmListLocalLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvListApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmIssueLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddLDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(458, 345);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(244, 33);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(222, 954);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(40, 47);
            this.lblNumberOfRecords.TabIndex = 24;
            this.lblNumberOfRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(28, 951);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(212, 50);
            this.lblRecords.TabIndex = 23;
            this.lblRecords.Text = "| Records : ";
            // 
            // dgvListApplications
            // 
            this.dgvListApplications.AllowUserToAddRows = false;
            this.dgvListApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListApplications.ColumnHeadersHeight = 50;
            this.dgvListApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListApplications.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListApplications.Location = new System.Drawing.Point(35, 392);
            this.dgvListApplications.Name = "dgvListApplications";
            this.dgvListApplications.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListApplications.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListApplications.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListApplications.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListApplications.Size = new System.Drawing.Size(1835, 531);
            this.dgvListApplications.TabIndex = 20;
            this.dgvListApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListApplications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListApplications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListApplications.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListApplications.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvListApplications.ThemeStyle.ReadOnly = true;
            this.dgvListApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListApplications.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListApplications.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListApplications_CellClick);
            this.dgvListApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPeople_CellContentClick);
            this.dgvListApplications.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListApplications_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShow,
            this.toolStripSeparator1,
            this.cmEdit,
            this.cmDelete,
            this.toolStripSeparator2,
            this.cmCancel,
            this.toolStripSeparator3,
            this.cmScheduleTest,
            this.toolStripSeparator4,
            this.cmIssueLicense,
            this.toolStripSeparator5,
            this.cmShowLicense,
            this.toolStripSeparator6,
            this.cmShowLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 216);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmShow
            // 
            this.cmShow.Name = "cmShow";
            this.cmShow.Size = new System.Drawing.Size(225, 22);
            this.cmShow.Text = "Show Application Details";
            this.cmShow.Click += new System.EventHandler(this.cmShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // cmEdit
            // 
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(225, 22);
            this.cmEdit.Text = "Edit";
            this.cmEdit.Click += new System.EventHandler(this.cmEdit_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(225, 22);
            this.cmDelete.Text = "Delete";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // cmCancel
            // 
            this.cmCancel.Name = "cmCancel";
            this.cmCancel.Size = new System.Drawing.Size(225, 22);
            this.cmCancel.Text = "Cancel";
            this.cmCancel.Click += new System.EventHandler(this.cmCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // cmScheduleTest
            // 
            this.cmScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmVisionTest,
            this.cmWrittenTest,
            this.cmStreetTest});
            this.cmScheduleTest.Name = "cmScheduleTest";
            this.cmScheduleTest.Size = new System.Drawing.Size(225, 22);
            this.cmScheduleTest.Text = "Schedule Test";
            // 
            // cmVisionTest
            // 
            this.cmVisionTest.Enabled = false;
            this.cmVisionTest.Name = "cmVisionTest";
            this.cmVisionTest.Size = new System.Drawing.Size(187, 22);
            this.cmVisionTest.Text = "Schedule Vision Test";
            this.cmVisionTest.Click += new System.EventHandler(this.cmVisionTest_Click);
            // 
            // cmWrittenTest
            // 
            this.cmWrittenTest.Enabled = false;
            this.cmWrittenTest.Name = "cmWrittenTest";
            this.cmWrittenTest.Size = new System.Drawing.Size(187, 22);
            this.cmWrittenTest.Text = "Schedule Written Test";
            this.cmWrittenTest.Click += new System.EventHandler(this.cmWrittenTest_Click);
            // 
            // cmStreetTest
            // 
            this.cmStreetTest.Enabled = false;
            this.cmStreetTest.Name = "cmStreetTest";
            this.cmStreetTest.Size = new System.Drawing.Size(187, 22);
            this.cmStreetTest.Text = "Schedule Street Test";
            this.cmStreetTest.Click += new System.EventHandler(this.cmStreetTest_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // cmIssueLicense
            // 
            this.cmIssueLicense.Name = "cmIssueLicense";
            this.cmIssueLicense.Size = new System.Drawing.Size(225, 22);
            this.cmIssueLicense.Text = "Issue License (Frist Time)";
            this.cmIssueLicense.Click += new System.EventHandler(this.cmIssueLicense_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(222, 6);
            // 
            // cmShowLicense
            // 
            this.cmShowLicense.Name = "cmShowLicense";
            this.cmShowLicense.Size = new System.Drawing.Size(225, 22);
            this.cmShowLicense.Text = "Show License";
            this.cmShowLicense.Click += new System.EventHandler(this.cmShowLicense_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(222, 6);
            // 
            // cmShowLicenseHistory
            // 
            this.cmShowLicenseHistory.Name = "cmShowLicenseHistory";
            this.cmShowLicenseHistory.Size = new System.Drawing.Size(225, 22);
            this.cmShowLicenseHistory.Text = "Show Person License History";
            this.cmShowLicenseHistory.Click += new System.EventHandler(this.cmShowLicenseHistory_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "LDLAppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(219, 345);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(205, 33);
            this.cbFilterBy.TabIndex = 19;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(36, 331);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(196, 50);
            this.lblFilterBy.TabIndex = 17;
            this.lblFilterBy.Text = "Filter By : ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1737, 951);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(133, 57);
            this.guna2Button1.TabIndex = 33;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 100);
            this.panel1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(456, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(968, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Local Driving Licnse Applications";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = global::DVLD_Presentation.Properties.Resources.application;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(818, 122);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(261, 216);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 34;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAddLDL
            // 
            this.btnAddLDL.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLDL.BackgroundImage = global::DVLD_Presentation.Properties.Resources.add;
            this.btnAddLDL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLDL.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddLDL.Location = new System.Drawing.Point(1812, 328);
            this.btnAddLDL.Name = "btnAddLDL";
            this.btnAddLDL.Size = new System.Drawing.Size(58, 58);
            this.btnAddLDL.TabIndex = 18;
            this.btnAddLDL.UseVisualStyleBackColor = false;
            this.btnAddLDL.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // frmListLocalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvListApplications);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnAddLDL);
            this.Controls.Add(this.lblFilterBy);
            this.Name = "frmListLocalLicenseApplications";
            this.Text = "frmLocalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblRecords;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListApplications;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddLDL;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmShow;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripMenuItem cmCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmScheduleTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmIssueLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cmShowLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem cmVisionTest;
        private System.Windows.Forms.ToolStripMenuItem cmWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem cmStreetTest;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}