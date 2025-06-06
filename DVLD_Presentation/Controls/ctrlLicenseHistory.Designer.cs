namespace DVLD_Presentation.Controls
{
    partial class ctrlLicenseHistory
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

        #region Component Designer generated code

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLocalLicense = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLocalLicense = new System.Windows.Forms.TabPage();
            this.lblLocalLicenseHistory = new System.Windows.Forms.Label();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.dgvIntLicense = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblInternational = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showIntLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicense)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpLocalLicense.SuspendLayout();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocalLicense
            // 
            this.dgvLocalLicense.AllowUserToAddRows = false;
            this.dgvLocalLicense.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLocalLicense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocalLicense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocalLicense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocalLicense.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalLicense.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalLicense.EnableHeadersVisualStyles = false;
            this.dgvLocalLicense.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLocalLicense.Location = new System.Drawing.Point(9, 38);
            this.dgvLocalLicense.Name = "dgvLocalLicense";
            this.dgvLocalLicense.ReadOnly = true;
            this.dgvLocalLicense.RowHeadersVisible = false;
            this.dgvLocalLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicense.Size = new System.Drawing.Size(743, 129);
            this.dgvLocalLicense.TabIndex = 0;
            this.dgvLocalLicense.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvLocalLicense.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalLicense.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLocalLicense.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLocalLicense.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLocalLicense.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLocalLicense.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalLicense.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLocalLicense.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLocalLicense.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocalLicense.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLocalLicense.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLocalLicense.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocalLicense.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvLocalLicense.ThemeStyle.ReadOnly = true;
            this.dgvLocalLicense.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLocalLicense.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocalLicense.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLocalLicense.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvLocalLicense.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLocalLicense.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLocalLicense.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLocalLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalLicense_CellClick);
            this.dgvLocalLicense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalLicense_CellContentClick);
            this.dgvLocalLicense.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalLicense_CellMouseClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblNumberOfRecords);
            this.guna2GroupBox1.Controls.Add(this.tabControl1);
            this.guna2GroupBox1.Controls.Add(this.lblRecords);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 22);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(780, 300);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Driver License";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(131, 265);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(23, 25);
            this.lblNumberOfRecords.TabIndex = 26;
            this.lblNumberOfRecords.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLocalLicense);
            this.tabControl1.Controls.Add(this.tpInternational);
            this.tabControl1.Location = new System.Drawing.Point(7, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 208);
            this.tabControl1.TabIndex = 0;
            // 
            // tpLocalLicense
            // 
            this.tpLocalLicense.Controls.Add(this.lblLocalLicenseHistory);
            this.tpLocalLicense.Controls.Add(this.dgvLocalLicense);
            this.tpLocalLicense.Location = new System.Drawing.Point(4, 24);
            this.tpLocalLicense.Name = "tpLocalLicense";
            this.tpLocalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicense.Size = new System.Drawing.Size(762, 180);
            this.tpLocalLicense.TabIndex = 0;
            this.tpLocalLicense.Text = "Local Licenses";
            this.tpLocalLicense.UseVisualStyleBackColor = true;
            // 
            // lblLocalLicenseHistory
            // 
            this.lblLocalLicenseHistory.AutoSize = true;
            this.lblLocalLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseHistory.Location = new System.Drawing.Point(6, 3);
            this.lblLocalLicenseHistory.Name = "lblLocalLicenseHistory";
            this.lblLocalLicenseHistory.Size = new System.Drawing.Size(178, 21);
            this.lblLocalLicenseHistory.TabIndex = 27;
            this.lblLocalLicenseHistory.Text = "Local License History :";
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.dgvIntLicense);
            this.tpInternational.Controls.Add(this.lblInternational);
            this.tpInternational.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpInternational.Location = new System.Drawing.Point(4, 24);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(762, 180);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International Licenses";
            this.tpInternational.UseVisualStyleBackColor = true;
            this.tpInternational.Click += new System.EventHandler(this.tpInternational_Click);
            // 
            // dgvIntLicense
            // 
            this.dgvIntLicense.AllowUserToAddRows = false;
            this.dgvIntLicense.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvIntLicense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIntLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgvIntLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntLicense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIntLicense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIntLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIntLicense.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntLicense.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIntLicense.EnableHeadersVisualStyles = false;
            this.dgvIntLicense.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIntLicense.Location = new System.Drawing.Point(10, 26);
            this.dgvIntLicense.Name = "dgvIntLicense";
            this.dgvIntLicense.ReadOnly = true;
            this.dgvIntLicense.RowHeadersVisible = false;
            this.dgvIntLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntLicense.Size = new System.Drawing.Size(743, 129);
            this.dgvIntLicense.TabIndex = 29;
            this.dgvIntLicense.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvIntLicense.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntLicense.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvIntLicense.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvIntLicense.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvIntLicense.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvIntLicense.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntLicense.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIntLicense.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvIntLicense.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIntLicense.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntLicense.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIntLicense.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIntLicense.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvIntLicense.ThemeStyle.ReadOnly = true;
            this.dgvIntLicense.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntLicense.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIntLicense.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIntLicense.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvIntLicense.ThemeStyle.RowsStyle.Height = 22;
            this.dgvIntLicense.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIntLicense.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIntLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntLicense_CellClick);
            this.dgvIntLicense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntLicense_CellContentClick);
            this.dgvIntLicense.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIntLicense_CellMouseClick);
            // 
            // lblInternational
            // 
            this.lblInternational.AutoSize = true;
            this.lblInternational.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternational.Location = new System.Drawing.Point(6, 3);
            this.lblInternational.Name = "lblInternational";
            this.lblInternational.Size = new System.Drawing.Size(238, 21);
            this.lblInternational.TabIndex = 28;
            this.lblInternational.Text = "International License History :";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(16, 265);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(109, 25);
            this.lblRecords.TabIndex = 25;
            this.lblRecords.Text = "| Records : ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showIntLicenseToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(163, 26);
            // 
            // showIntLicenseToolStripMenuItem
            // 
            this.showIntLicenseToolStripMenuItem.Name = "showIntLicenseToolStripMenuItem";
            this.showIntLicenseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showIntLicenseToolStripMenuItem.Text = "Show Int License";
            this.showIntLicenseToolStripMenuItem.Click += new System.EventHandler(this.showIntLicenseToolStripMenuItem_Click);
            // 
            // ctrlLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "ctrlLicenseHistory";
            this.Size = new System.Drawing.Size(801, 333);
            this.Load += new System.EventHandler(this.ctrlLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicense)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpLocalLicense.ResumeLayout(false);
            this.tpLocalLicense.PerformLayout();
            this.tpInternational.ResumeLayout(false);
            this.tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvLocalLicense;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLocalLicense;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblLocalLicenseHistory;
        private System.Windows.Forms.Label lblInternational;
        private Guna.UI2.WinForms.Guna2DataGridView dgvIntLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showIntLicenseToolStripMenuItem;
    }
}
