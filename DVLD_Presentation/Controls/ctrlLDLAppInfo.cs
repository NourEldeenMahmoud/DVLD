using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlLDLAppInfo : UserControl
    {
        private int _LDLAppID;
        clsLocalDrivingLicenseApplication _LDLApp;
        public ctrlLDLAppInfo()
        {
            InitializeComponent();
        }
        public void LoadLDLApp(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);

            lblIDValue.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForValue.Text = clsLicenseClasses.GetClassTitleByID(_LDLApp.LicenseClassID);
            if (_LDLApp.ApplicaionData.ApplicationStatus == 3)
            {
                btnShowLicense.Enabled = true;


            }
            lblPassedTestsVlaue.Text = clsLocalDrivingLicenseApplication.GetPassedTests(_LDLApp.LocalDrivingLicenseApplicationID).ToString() + "/3";
        }
        private void ctrlLDLAppInfo_Load(object sender, EventArgs e)
        {

        }

        private void gbApplicationInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnShowLicense_Click(object sender, EventArgs e)
        {

        }
    }
}
