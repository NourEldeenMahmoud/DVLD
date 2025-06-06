using DVLD_Business;
using DVLD_Presentation.InternationalLicense;
using DVLD_Presentation.License;
using DVLD_Presentation.LocalDrivingLicense;
using DVLD_Presentation.MangeApplicationType;
using DVLD_Presentation.MangeTestsTypes;
using DVLD_Presentation.NewLocalDrivingLicense;
using DVLD_Presentation.People;
using DVLD_Presentation.Users;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();

        }
        private void LoadFormInPanel(Form frm)
        {
            MainPanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(frm);
            frm.Show();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormInPanel(new frmListPeople());

        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormInPanel(new frmListUsers());
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCard frmUserCard = new frmUserCard(clsGlobalSettings.LoggedInUser.UserID, clsGlobalSettings.LoggedInUser.PersonID);
            frmUserCard.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();


        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frmAppTypes = new frmManageApplicationTypes();
            frmAppTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frmNewLocalDrivingLicenseApplication = new frmNewLocalDrivingLicenseApplication();
            frmNewLocalDrivingLicenseApplication.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormInPanel(new frmDrivers());
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frmInternationalLicensecs = new frmAddInternationalLicense();
            frmInternationalLicensecs.ShowDialog();
        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageLocalApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormInPanel(new frmListLocalLicenseApplications());
        }

        private void internationalApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormInPanel(new frmManageInternationalApplications());
        }

        private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense frmRenewLicense = new frmRenewLicense();    
            frmRenewLicense.ShowDialog();
        }

        private void replacmentForDamageOfLOstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacmentForDamageOrLost frmReplacmentForDamageOrLost = new frmReplacmentForDamageOrLost();
            frmReplacmentForDamageOrLost.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense();
            frmDetainLicense.ShowDialog();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense();
            frmReleaseDetainedLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            LoadFormInPanel(new frmManageDetainedLicenses());

        }
    }
}
