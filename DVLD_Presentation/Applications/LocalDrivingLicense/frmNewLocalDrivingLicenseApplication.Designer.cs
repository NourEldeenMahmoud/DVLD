namespace DVLD_Presentation.LocalDrivingLicense
{
    partial class frmNewLocalDrivingLicenseApplication
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.Controls.ctrlPersonCardWithFilter();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblApplicationDateValue = new System.Windows.Forms.Label();
            this.lblApplicationFeesValue = new System.Windows.Forms.Label();
            this.lblLocalLicenseAppIDValue = new System.Windows.Forms.Label();
            this.cbLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNameIcon = new System.Windows.Forms.Label();
            this.lblLocalLicenseAppID = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(19, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(666, 626);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 50);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save 💾";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonInfo);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.ItemSize = new System.Drawing.Size(403, 35);
            this.tabControl1.Location = new System.Drawing.Point(15, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 592);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 63;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 39);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(802, 549);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(636, 63);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 50);
            this.btnNext.TabIndex = 63;
            this.btnNext.Text = "Next ➡️";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardWithFilter1.ForeColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(5, 5);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(791, 538);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.guna2GroupBox1);
            this.tpApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 39);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(802, 549);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lblCreatedByValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationDateValue);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFeesValue);
            this.guna2GroupBox1.Controls.Add(this.lblLocalLicenseAppIDValue);
            this.guna2GroupBox1.Controls.Add(this.cbLicenseClass);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.lblCreatedBy);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationFees);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.lblLicenseClass);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.lblApplicationDate);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.lblNameIcon);
            this.guna2GroupBox1.Controls.Add(this.lblLocalLicenseAppID);
            this.guna2GroupBox1.Controls.Add(this.lblUserIDValue);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(31, 76);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(756, 392);
            this.guna2GroupBox1.TabIndex = 74;
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.Location = new System.Drawing.Point(306, 252);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(48, 25);
            this.lblCreatedByValue.TabIndex = 93;
            this.lblCreatedByValue.Text = "[???]";
            // 
            // lblApplicationDateValue
            // 
            this.lblApplicationDateValue.AutoSize = true;
            this.lblApplicationDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateValue.Location = new System.Drawing.Point(306, 130);
            this.lblApplicationDateValue.Name = "lblApplicationDateValue";
            this.lblApplicationDateValue.Size = new System.Drawing.Size(48, 25);
            this.lblApplicationDateValue.TabIndex = 92;
            this.lblApplicationDateValue.Text = "[???]";
            // 
            // lblApplicationFeesValue
            // 
            this.lblApplicationFeesValue.AutoSize = true;
            this.lblApplicationFeesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesValue.Location = new System.Drawing.Point(306, 211);
            this.lblApplicationFeesValue.Name = "lblApplicationFeesValue";
            this.lblApplicationFeesValue.Size = new System.Drawing.Size(48, 25);
            this.lblApplicationFeesValue.TabIndex = 91;
            this.lblApplicationFeesValue.Text = "[???]";
            // 
            // lblLocalLicenseAppIDValue
            // 
            this.lblLocalLicenseAppIDValue.AutoSize = true;
            this.lblLocalLicenseAppIDValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseAppIDValue.Location = new System.Drawing.Point(306, 87);
            this.lblLocalLicenseAppIDValue.Name = "lblLocalLicenseAppIDValue";
            this.lblLocalLicenseAppIDValue.Size = new System.Drawing.Size(48, 25);
            this.lblLocalLicenseAppIDValue.TabIndex = 90;
            this.lblLocalLicenseAppIDValue.Text = "[???]";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FocusedColor = System.Drawing.Color.Empty;
            this.cbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.ItemHeight = 30;
            this.cbLicenseClass.Location = new System.Drawing.Point(311, 170);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(248, 36);
            this.cbLicenseClass.TabIndex = 89;
            this.cbLicenseClass.Validating += new System.ComponentModel.CancelEventHandler(this.cbLicenseClass_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(133, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 30);
            this.label11.TabIndex = 88;
            this.label11.Text = "👤";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(99, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 30);
            this.label10.TabIndex = 87;
            this.label10.Text = "💰";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(177, 253);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(128, 25);
            this.lblCreatedBy.TabIndex = 85;
            this.lblCreatedBy.Text = "Created By   :";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(133, 211);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(172, 25);
            this.lblApplicationFees.TabIndex = 84;
            this.lblApplicationFees.Text = "Application Fees  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(126, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 30);
            this.label4.TabIndex = 83;
            this.label4.Text = "🏷️";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseClass.Location = new System.Drawing.Point(166, 170);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(139, 25);
            this.lblLicenseClass.TabIndex = 81;
            this.lblLicenseClass.Text = "License Class  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(254, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 82;
            this.label6.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(106, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 30);
            this.label1.TabIndex = 80;
            this.label1.Text = "⏳";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(135, 130);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(170, 25);
            this.lblApplicationDate.TabIndex = 78;
            this.lblApplicationDate.Text = "Application Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(193, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 79;
            this.label3.Text = "??";
            // 
            // lblNameIcon
            // 
            this.lblNameIcon.AutoSize = true;
            this.lblNameIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblNameIcon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNameIcon.Location = new System.Drawing.Point(41, 79);
            this.lblNameIcon.Name = "lblNameIcon";
            this.lblNameIcon.Size = new System.Drawing.Size(43, 30);
            this.lblNameIcon.TabIndex = 74;
            this.lblNameIcon.Text = "🆔";
            // 
            // lblLocalLicenseAppID
            // 
            this.lblLocalLicenseAppID.AutoSize = true;
            this.lblLocalLicenseAppID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseAppID.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicenseAppID.Location = new System.Drawing.Point(81, 83);
            this.lblLocalLicenseAppID.Name = "lblLocalLicenseAppID";
            this.lblLocalLicenseAppID.Size = new System.Drawing.Size(224, 25);
            this.lblLocalLicenseAppID.TabIndex = 60;
            this.lblLocalLicenseAppID.Text = "Driving License App ID :";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDValue.Location = new System.Drawing.Point(181, 83);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(28, 25);
            this.lblUserIDValue.TabIndex = 73;
            this.lblUserIDValue.Text = "??";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 708);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmNewLocalDrivingLicenseApplication";
            this.Text = "frmNewLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblNameIcon;
        private System.Windows.Forms.Label lblLocalLicenseAppID;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblApplicationDateValue;
        private System.Windows.Forms.Label lblApplicationFeesValue;
        private System.Windows.Forms.Label lblLocalLicenseAppIDValue;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}