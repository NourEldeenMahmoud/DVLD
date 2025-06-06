namespace DVLD_Presentation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocalApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacmentForDamageOfLOstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem1,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.drivingLicenseServicesToolStripMenuItem,
            this.detainLicensesToolStripMenuItem});
            this.applicationsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(199, 49);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalApplicationsToolStripMenuItem,
            this.internationalApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            this.manageApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsToolStripMenuItem_Click);
            // 
            // manageLocalApplicationsToolStripMenuItem
            // 
            this.manageLocalApplicationsToolStripMenuItem.Name = "manageLocalApplicationsToolStripMenuItem";
            this.manageLocalApplicationsToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.manageLocalApplicationsToolStripMenuItem.Text = "Local Applications";
            this.manageLocalApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageLocalApplicationsToolStripMenuItem_Click);
            // 
            // internationalApplicationsToolStripMenuItem
            // 
            this.internationalApplicationsToolStripMenuItem.Name = "internationalApplicationsToolStripMenuItem";
            this.internationalApplicationsToolStripMenuItem.Size = new System.Drawing.Size(451, 44);
            this.internationalApplicationsToolStripMenuItem.Text = "International Applications";
            this.internationalApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationalApplicationsToolStripMenuItem_Click);
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            this.drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewLicenseToolStripMenuItem,
            this.replacmentForDamageOfLOstToolStripMenuItem});
            this.drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            this.drivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.drivingLicenseServicesToolStripMenuItem.Text = "Driving License Services ";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(537, 44);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(381, 44);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(381, 44);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewLicenseToolStripMenuItem
            // 
            this.renewLicenseToolStripMenuItem.Name = "renewLicenseToolStripMenuItem";
            this.renewLicenseToolStripMenuItem.Size = new System.Drawing.Size(537, 44);
            this.renewLicenseToolStripMenuItem.Text = "Renew License";
            this.renewLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewLicenseToolStripMenuItem_Click);
            // 
            // replacmentForDamageOfLOstToolStripMenuItem
            // 
            this.replacmentForDamageOfLOstToolStripMenuItem.Name = "replacmentForDamageOfLOstToolStripMenuItem";
            this.replacmentForDamageOfLOstToolStripMenuItem.Size = new System.Drawing.Size(537, 44);
            this.replacmentForDamageOfLOstToolStripMenuItem.Text = "Replacment For Damage Of Lost";
            this.replacmentForDamageOfLOstToolStripMenuItem.Click += new System.EventHandler(this.replacmentForDamageOfLOstToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.deToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(458, 44);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(459, 44);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(459, 44);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(459, 44);
            this.deToolStripMenuItem.Text = "Release Detained License";
            this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.peopleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(122, 49);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(127, 49);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(113, 49);
            this.usersToolStripMenuItem1.Text = "Users";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.usersToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(261, 49);
            this.usersToolStripMenuItem.Text = "Account Settings";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(335, 44);
            this.currentUserInfoToolStripMenuItem.Text = "Current User info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(335, 44);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(335, 44);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.menuStrip1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1829, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(79, 45);
            this.guna2ControlBox1.TabIndex = 87;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 53);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1920, 1027);
            this.MainPanel.TabIndex = 88;
            this.MainPanel.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "`";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocalApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacmentForDamageOfLOstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
    }
}

