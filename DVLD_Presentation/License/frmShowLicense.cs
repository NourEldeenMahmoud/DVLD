using System;
using System.Windows.Forms;

namespace DVLD_Presentation.License
{
    public partial class frmShowLicense : Form
    {
        private int _LicenseID;
        public frmShowLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmShowLicense_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfo1.LoadLicense(_LicenseID);
        }
    }
}
