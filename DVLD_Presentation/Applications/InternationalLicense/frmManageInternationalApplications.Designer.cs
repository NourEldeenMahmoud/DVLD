namespace DVLD_Presentation.InternationalLicense
{
    partial class frmManageInternationalApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvIntLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddLDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
            this.txtSearch.Location = new System.Drawing.Point(446, 345);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(251, 33);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.Visible = false;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(233, 951);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(40, 47);
            this.lblNumberOfRecords.TabIndex = 32;
            this.lblNumberOfRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(28, 948);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(212, 50);
            this.lblRecords.TabIndex = 31;
            this.lblRecords.Text = "| Records : ";
            // 
            // dgvIntLicenses
            // 
            this.dgvIntLicenses.AllowUserToAddRows = false;
            this.dgvIntLicenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvIntLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvIntLicenses.ColumnHeadersHeight = 50;
            this.dgvIntLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvIntLicenses.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntLicenses.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIntLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIntLicenses.Location = new System.Drawing.Point(35, 392);
            this.dgvIntLicenses.Name = "dgvIntLicenses";
            this.dgvIntLicenses.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIntLicenses.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntLicenses.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIntLicenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntLicenses.Size = new System.Drawing.Size(1835, 531);
            this.dgvIntLicenses.TabIndex = 29;
            this.dgvIntLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvIntLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvIntLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvIntLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvIntLicenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntLicenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIntLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvIntLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIntLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvIntLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIntLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvIntLicenses.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvIntLicenses.ThemeStyle.ReadOnly = true;
            this.dgvIntLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIntLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvIntLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIntLicenses.ThemeStyle.RowsStyle.Height = 22;
            this.dgvIntLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIntLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIntLicenses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntLicenses_CellClick);
            this.dgvIntLicenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntLicenses_CellContentClick);
            this.dgvIntLicenses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIntLicenses_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseInfoToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 70);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Details";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "ApplicationID",
            "DriverID",
            "L.License ID",
            "IssueDate",
            "ExpirationDate",
            "IsActive"});
            this.cbFilterBy.Location = new System.Drawing.Point(215, 345);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(205, 33);
            this.cbFilterBy.TabIndex = 28;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(30, 328);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(196, 50);
            this.lblFilterBy.TabIndex = 26;
            this.lblFilterBy.Text = "Filter By : ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(207, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(711, 47);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "International Driving License Applciations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 100);
            this.panel1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(456, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(965, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage International Licnse Applications";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1737, 948);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(133, 57);
            this.guna2Button1.TabIndex = 34;
            this.guna2Button1.Text = "Close";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::DVLD_Presentation.Properties.Resources.earth;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(968, 219);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(92, 93);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 38;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = global::DVLD_Presentation.Properties.Resources.application;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(770, 116);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(261, 216);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 37;
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
            this.btnAddLDL.TabIndex = 27;
            this.btnAddLDL.UseVisualStyleBackColor = false;
            this.btnAddLDL.Click += new System.EventHandler(this.btnAddLDL_Click);
            // 
            // frmManageInternationalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvIntLicenses);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnAddLDL);
            this.Controls.Add(this.lblFilterBy);
            this.Name = "frmManageInternationalApplications";
            this.Text = "frmManageInternationalApplications";
            this.Load += new System.EventHandler(this.frmManageInternationalApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblRecords;
        private Guna.UI2.WinForms.Guna2DataGridView dgvIntLicenses;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddLDL;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}