using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.LocalDrivingLicense
{
    public partial class frmShowLDLAppDetails : Form
    {
        private int _LDLAppID;
        private clsLocalDrivingLicenseApplication _LDLApp;
        public frmShowLDLAppDetails(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }

        private void frmShowLDLAppDetails_Load(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            ctrlApplicationInfo1.LoadApplication(_LDLApp.ApplicationID);
            ctrlLDLAppInfo1.LoadLDLApp(_LDLApp.LocalDrivingLicenseApplicationID);
        }

        private void ctrlLDLAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
