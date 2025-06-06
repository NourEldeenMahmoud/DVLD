namespace DVLD_Presentation.Users
{
    partial class frmAddUpdateUser
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmailIcon = new System.Windows.Forms.Label();
            this.lblGenderIcon = new System.Windows.Forms.Label();
            this.lblNtionalNoIcon = new System.Windows.Forms.Label();
            this.lblNameIcon = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserIDValue = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.Controls.ctrlPersonCardWithFilter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpUserInfo.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 15;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(5, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 50);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close ❌ ";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(641, 583);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 50);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save 💾";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.Controls.Add(this.guna2GroupBox1);
            this.tpUserInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpUserInfo.Location = new System.Drawing.Point(4, 44);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(781, 522);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User Info";
            this.tpUserInfo.UseVisualStyleBackColor = true;
            this.tpUserInfo.Click += new System.EventHandler(this.tpUserInfo_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.lblEmailIcon);
            this.guna2GroupBox1.Controls.Add(this.lblGenderIcon);
            this.guna2GroupBox1.Controls.Add(this.lblNtionalNoIcon);
            this.guna2GroupBox1.Controls.Add(this.lblNameIcon);
            this.guna2GroupBox1.Controls.Add(this.lblUserID);
            this.guna2GroupBox1.Controls.Add(this.lblUserIDValue);
            this.guna2GroupBox1.Controls.Add(this.lblUserName);
            this.guna2GroupBox1.Controls.Add(this.chkIsActive);
            this.guna2GroupBox1.Controls.Add(this.lblPassword);
            this.guna2GroupBox1.Controls.Add(this.txtPassword);
            this.guna2GroupBox1.Controls.Add(this.lblConfirm);
            this.guna2GroupBox1.Controls.Add(this.txtUserName);
            this.guna2GroupBox1.Controls.Add(this.txtConfirmPassword);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(775, 516);
            this.guna2GroupBox1.TabIndex = 74;
            this.guna2GroupBox1.Text = "User Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 78;
            this.label1.Text = "Is Active :";
            // 
            // lblEmailIcon
            // 
            this.lblEmailIcon.AutoSize = true;
            this.lblEmailIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailIcon.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblEmailIcon.Location = new System.Drawing.Point(46, 350);
            this.lblEmailIcon.Name = "lblEmailIcon";
            this.lblEmailIcon.Size = new System.Drawing.Size(93, 40);
            this.lblEmailIcon.TabIndex = 77;
            this.lblEmailIcon.Text = "✅🔒";
            // 
            // lblGenderIcon
            // 
            this.lblGenderIcon.AutoSize = true;
            this.lblGenderIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblGenderIcon.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblGenderIcon.Location = new System.Drawing.Point(88, 261);
            this.lblGenderIcon.Name = "lblGenderIcon";
            this.lblGenderIcon.Size = new System.Drawing.Size(58, 40);
            this.lblGenderIcon.TabIndex = 76;
            this.lblGenderIcon.Text = "🔑";
            // 
            // lblNtionalNoIcon
            // 
            this.lblNtionalNoIcon.AutoSize = true;
            this.lblNtionalNoIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblNtionalNoIcon.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNtionalNoIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNtionalNoIcon.Location = new System.Drawing.Point(95, 172);
            this.lblNtionalNoIcon.Name = "lblNtionalNoIcon";
            this.lblNtionalNoIcon.Size = new System.Drawing.Size(52, 40);
            this.lblNtionalNoIcon.TabIndex = 75;
            this.lblNtionalNoIcon.Text = "👤";
            // 
            // lblNameIcon
            // 
            this.lblNameIcon.AutoSize = true;
            this.lblNameIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblNameIcon.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNameIcon.Location = new System.Drawing.Point(95, 85);
            this.lblNameIcon.Name = "lblNameIcon";
            this.lblNameIcon.Size = new System.Drawing.Size(58, 40);
            this.lblNameIcon.TabIndex = 74;
            this.lblNameIcon.Text = "🆔";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(152, 85);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(118, 37);
            this.lblUserID.TabIndex = 60;
            this.lblUserID.Text = "UserID :";
            // 
            // lblUserIDValue
            // 
            this.lblUserIDValue.AutoSize = true;
            this.lblUserIDValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDValue.ForeColor = System.Drawing.Color.Black;
            this.lblUserIDValue.Location = new System.Drawing.Point(274, 89);
            this.lblUserIDValue.Name = "lblUserIDValue";
            this.lblUserIDValue.Size = new System.Drawing.Size(36, 32);
            this.lblUserIDValue.TabIndex = 73;
            this.lblUserIDValue.Text = "??";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(145, 174);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(165, 37);
            this.lblUserName.TabIndex = 61;
            this.lblUserName.Text = "UserName :";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.ForeColor = System.Drawing.Color.Black;
            this.chkIsActive.Location = new System.Drawing.Point(291, 445);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(15, 14);
            this.chkIsActive.TabIndex = 72;
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(145, 263);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(153, 37);
            this.lblPassword.TabIndex = 63;
            this.lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(309, 265);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(236, 35);
            this.txtPassword.TabIndex = 70;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Black;
            this.lblConfirm.Location = new System.Drawing.Point(145, 352);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(264, 37);
            this.lblConfirm.TabIndex = 64;
            this.lblConfirm.Text = "Confirm Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(309, 177);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(236, 35);
            this.txtUserName.TabIndex = 68;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 15;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(418, 355);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(236, 35);
            this.txtConfirmPassword.TabIndex = 65;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(781, 522);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BorderRadius = 15;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(626, 62);
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
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(-4, 0);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(785, 528);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonInfo);
            this.tabControl1.Controls.Add(this.tpUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(393, 40);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 570);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(797, 641);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpUserInfo.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.tpPersonInfo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpUserInfo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblEmailIcon;
        private System.Windows.Forms.Label lblGenderIcon;
        private System.Windows.Forms.Label lblNtionalNoIcon;
        private System.Windows.Forms.Label lblNameIcon;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUserIDValue;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}