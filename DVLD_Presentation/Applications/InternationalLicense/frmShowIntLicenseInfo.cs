using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.InternationalLicense
{
    public partial class frmShowIntLicenseInfo : Form
    {
        private int _DriverID;
        public frmShowIntLicenseInfo(int DriverID)
        {
            InitializeComponent();
            _DriverID = DriverID;
        }

        private void frmShowIntLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadIntlicense(_DriverID);
        }
    }
}
