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
    public partial class frmIntLicenseHistory : Form
    {
        private int _DriverID;
        public frmIntLicenseHistory(int DriverID)
        {
            InitializeComponent();
            _DriverID = DriverID;
        }

        private void frmIntLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlLicenseHistory1.LoadLiceseHistory(_DriverID);
        }
    }
}
