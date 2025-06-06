namespace DVLD_Presentation.MangeTestsTypes
{
    partial class frmUpdateTestTypes
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
            this.txtFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtFees
            // 
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.DefaultText = "";
            this.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Location = new System.Drawing.Point(159, 380);
            this.txtFees.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.txtFees.Name = "txtFees";
            this.txtFees.PlaceholderText = "";
            this.txtFees.SelectedText = "";
            this.txtFees.Size = new System.Drawing.Size(188, 27);
            this.txtFees.TabIndex = 79;
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(159, 184);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(361, 27);
            this.txtTitle.TabIndex = 78;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 10;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(117, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 77;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(426, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 50);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Save 💾";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDValue.Location = new System.Drawing.Point(165, 126);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(31, 30);
            this.lblIDValue.TabIndex = 75;
            this.lblIDValue.Text = "??";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(93, 377);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(55, 30);
            this.lblFees.TabIndex = 74;
            this.lblFees.Text = "Fees";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(93, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 30);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Title";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(103, 126);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 30);
            this.lblID.TabIndex = 72;
            this.lblID.Text = "ID";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(150, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(321, 50);
            this.lblHeader.TabIndex = 71;
            this.lblHeader.Text = "Update Test Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(24, 243);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(125, 30);
            this.lblDescription.TabIndex = 80;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(159, 243);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(361, 115);
            this.txtDescription.TabIndex = 81;
            // 
            // frmUpdateTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 552);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmUpdateTestTypes";
            this.Text = "UpdateTestTypes";
            this.Load += new System.EventHandler(this.frmUpdateTestTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFees;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
    }
}