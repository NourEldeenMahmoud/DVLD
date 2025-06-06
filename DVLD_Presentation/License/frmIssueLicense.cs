using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.License
{
    public partial class frmIssueLicense : Form
    {


        private int _LDLAppID;
        private clsLicense _License = new clsLicense();
        private clsLicenseClasses _LicenseClass;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsDriver _Driver;
        public frmIssueLicense(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;

        }
        private void _FillLicense()
        {
            _License.ApplicationID = _LDLApp.ApplicationID;
            _License.LicenseClassID = _LDLApp.LicenseClassID;
            _License.IssueDate = DateTime.Now;
            _License.ExpirationDate = _License.IssueDate.AddYears(_LicenseClass.DefaultValidityLength);
            _License.Notes = rtxtNotes.Text;
            _License.PaidFees = _LDLApp.ApplicaionData.PaidFees;
            _License.IsActive = true;
            _License.IssueReason = 1;
            _License.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;


        }
        private void frmIssueLicense_Load(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            _LicenseClass = clsLicenseClasses.Find(_LDLApp.LicenseClassID);
            ctrlApplicationInfo1.LoadApplication(_LDLApp.ApplicationID);
            ctrlLDLAppInfo1.LoadLDLApp(_LDLApp.LocalDrivingLicenseApplicationID);




        }
        private bool _SaveDriver()
        {
            _Driver = new clsDriver();
            _Driver.PersonID = _LDLApp.ApplicaionData.ApplicantPersonID;
            _Driver.CreatedDate = DateTime.Now;
            _Driver.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;

            return _Driver.Save();

        }
        private void _SaveLicense()
        {
            if (_License.Save())
            {

                _LDLApp.ApplicaionData.ApplicationStatus = 3;
                _LDLApp.ApplicaionData.Mode = clsApplication.enMode.Update;
                if (_LDLApp.ApplicaionData.Save())
                {
                    MessageBox.Show("License Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error Updating Application Status", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("License Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            _FillLicense();

            if (clsDriver.IsDriverExistByPersonID(_LDLApp.ApplicaionData.ApplicantPersonID))
            {
                _License.DriverID = clsDriver.GetDriverIDByPersonID(_LDLApp.ApplicaionData.ApplicantPersonID);
                _SaveLicense();
            }
            else if (_SaveDriver())
            {
                _License.DriverID = clsDriver.GetDriverIDByPersonID(_LDLApp.ApplicaionData.ApplicantPersonID);
                _SaveLicense();

            }
            else
            {
                MessageBox.Show("Driver Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
