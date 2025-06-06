namespace DVLD_Presentation.Tests
{
    partial class frmManageTestAppointments
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlLDLAppInfo1 = new DVLD_Presentation.Controls.ctrlLDLAppInfo();
            this.ctrlApplicationInfo1 = new DVLD_Presentation.Controls.ctrlApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(345, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Test Appointment";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BorderRadius = 15;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(767, 529);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(140, 45);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(767, 801);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 45);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(211, 805);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(28, 32);
            this.lblNumberOfRecords.TabIndex = 26;
            this.lblNumberOfRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(49, 801);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(156, 37);
            this.lblRecords.TabIndex = 25;
            this.lblRecords.Text = "| Records : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Appointments : ";
            // 
            // dgvListAppointments
            // 
            this.dgvListAppointments.AllowUserToAddRows = false;
            this.dgvListAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListAppointments.ColumnHeadersHeight = 50;
            this.dgvListAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListAppointments.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListAppointments.Location = new System.Drawing.Point(45, 588);
            this.dgvListAppointments.Name = "dgvListAppointments";
            this.dgvListAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListAppointments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListAppointments.Size = new System.Drawing.Size(862, 199);
            this.dgvListAppointments.TabIndex = 28;
            this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvListAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListAppointments.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvListAppointments.ThemeStyle.ReadOnly = true;
            this.dgvListAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListAppointments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListAppointments_CellClick);
            this.dgvListAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListAppointments_CellContentClick);
            this.dgvListAppointments.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListAppointments_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEdit,
            this.cmTakeTest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cmEdit
            // 
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(120, 22);
            this.cmEdit.Text = "Edit";
            this.cmEdit.Click += new System.EventHandler(this.cmEdit_Click);
            // 
            // cmTakeTest
            // 
            this.cmTakeTest.Name = "cmTakeTest";
            this.cmTakeTest.Size = new System.Drawing.Size(120, 22);
            this.cmTakeTest.Text = "Take Test";
            this.cmTakeTest.Click += new System.EventHandler(this.cmTakeTest_Click);
            // 
            // ctrlLDLAppInfo1
            // 
            this.ctrlLDLAppInfo1.Location = new System.Drawing.Point(45, 81);
            this.ctrlLDLAppInfo1.Name = "ctrlLDLAppInfo1";
            this.ctrlLDLAppInfo1.Size = new System.Drawing.Size(862, 181);
            this.ctrlLDLAppInfo1.TabIndex = 2;
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(45, 268);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(873, 247);
            this.ctrlApplicationInfo1.TabIndex = 1;
            // 
            // frmManageTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 868);
            this.Controls.Add(this.dgvListAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.ctrlLDLAppInfo1);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmManageTestAppointments";
            this.Text = "frmManageTestAppointments";
            this.Load += new System.EventHandler(this.frmManageTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlApplicationInfo ctrlApplicationInfo1;
        private Controls.ctrlLDLAppInfo ctrlLDLAppInfo1;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmTakeTest;
    }
}