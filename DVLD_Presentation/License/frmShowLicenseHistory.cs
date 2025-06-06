using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.License
{
    public partial class frmShowLicenseHistory : Form
    {
        private int _PersonID;
        private int _DriverID;
        public frmShowLicenseHistory(int DriverID)
        {
            InitializeComponent();
            _DriverID = DriverID;
        }

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            clsDriver _Driver = clsDriver.Find(_DriverID);
            ctrlPersonCardWithFilter1.LoadPerson(_Driver.PersonID);
            ctrlLicenseHistory1.LoadLiceseHistory(_DriverID);
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
