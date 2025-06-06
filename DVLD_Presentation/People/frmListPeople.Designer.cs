namespace DVLD_Presentation.People
{
    partial class frmListPeople
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
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvListPeople = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cnDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.cnDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gender",
            "DateOfBirth",
            "Nationality",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(225, 340);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(205, 33);
            this.cbFilterBy.TabIndex = 10;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(40, 325);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(196, 50);
            this.lblFilterBy.TabIndex = 8;
            this.lblFilterBy.Text = "Filter By : ";
            // 
            // dgvListPeople
            // 
            this.dgvListPeople.AllowUserToAddRows = false;
            this.dgvListPeople.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListPeople.ColumnHeadersHeight = 50;
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListPeople.ContextMenuStrip = this.cnDetails;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPeople.Location = new System.Drawing.Point(35, 392);
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListPeople.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListPeople.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListPeople.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListPeople.Size = new System.Drawing.Size(1835, 531);
            this.dgvListPeople.TabIndex = 11;
            this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListPeople.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPeople.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListPeople.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListPeople.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListPeople.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListPeople.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListPeople.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvListPeople.ThemeStyle.ReadOnly = true;
            this.dgvListPeople.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListPeople.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListPeople.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListPeople.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPeople_CellClick);
            this.dgvListPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPeople_CellContentClick);
            this.dgvListPeople.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListPeople_CellMouseClick);
            // 
            // cnDetails
            // 
            this.cnDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.cmShowDetails,
            this.toolStripSeparator1,
            this.cmAdd,
            this.cmEdit,
            this.cmDelete,
            this.toolStripSeparator2});
            this.cnDetails.Name = "cnDetails";
            this.cnDetails.Size = new System.Drawing.Size(178, 110);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // cmShowDetails
            // 
            this.cmShowDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmShowDetails.Name = "cmShowDetails";
            this.cmShowDetails.Size = new System.Drawing.Size(177, 22);
            this.cmShowDetails.Text = "Show Details";
            this.cmShowDetails.Click += new System.EventHandler(this.cmShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // cmAdd
            // 
            this.cmAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmAdd.Name = "cmAdd";
            this.cmAdd.Size = new System.Drawing.Size(177, 22);
            this.cmAdd.Text = "Add New Person";
            this.cmAdd.Click += new System.EventHandler(this.cmAdd_Click);
            // 
            // cmEdit
            // 
            this.cmEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(177, 22);
            this.cmEdit.Text = "Edit";
            this.cmEdit.Click += new System.EventHandler(this.cmEdit_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(177, 22);
            this.cmDelete.Text = "Delete";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(28, 937);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(212, 50);
            this.lblRecords.TabIndex = 14;
            this.lblRecords.Text = "| Records : ";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(232, 937);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(40, 47);
            this.lblNumberOfRecords.TabIndex = 15;
            this.lblNumberOfRecords.Text = "0";
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
            this.txtSearch.Location = new System.Drawing.Point(461, 340);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(256, 33);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = global::DVLD_Presentation.Properties.Resources.people;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(832, 119);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(261, 216);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BackgroundImage = global::DVLD_Presentation.Properties.Resources.add;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.Location = new System.Drawing.Point(1799, 319);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(71, 67);
            this.btnAddPerson.TabIndex = 9;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 100);
            this.panel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(755, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage People";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1737, 937);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(133, 57);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "Close";
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvListPeople);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblFilterBy);
            this.Name = "frmListPeople";
            this.Text = "frmListPeople";
            this.Load += new System.EventHandler(this.frmListPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.cnDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblFilterBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListPeople;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip cnDetails;
        private System.Windows.Forms.ToolStripMenuItem cmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmAdd;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}