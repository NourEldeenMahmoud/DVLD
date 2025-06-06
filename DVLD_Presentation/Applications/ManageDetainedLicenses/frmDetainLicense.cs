using DVLD_Business;
using DVLD_Presentation.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation
{
    public partial class frmDetainLicense : Form
    {
        private clsLicense _License;
        private int _LicenseID=-1;

        private clsDetainedLicense _DetainedLicense = new clsDetainedLicense();
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        public frmDetainLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            int.TryParse(txtSearch.Text, out int OldLicenseID);
            _LicenseID = OldLicenseID;
            _License = clsLicense.Find(_LicenseID);
            llblShowLicenseHistory.Enabled = true;

            if (_License != null)
            {
                lblLicenseIDValue.Text = _License.LicenseID.ToString();
                ctrlLicenseInfo1.LoadLicense(_License.LicenseID);

                btnDetain.Enabled = true;

            }
            else
            {
                MessageBox.Show("Inable To Find License with ID " + txtSearch.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _SaveDetainedLicense()
        {
            _DetainedLicense.LicenseID = _License.LicenseID;
            _DetainedLicense.DetainDate = DateTime.Now;
            if (decimal.TryParse(txtFineFeesValue.Text, out decimal fineFees))
            {
                _DetainedLicense.FineFees = fineFees;
            }
            _DetainedLicense.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;
            _DetainedLicense.IsReleased =false;

        }
        private void _LoadDetainData()
        {

            lblDetainDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedByValue.Text = clsGlobalSettings.LoggedInUser.UserName;

        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (_License.IsActive==true)
            {
                if (!clsDetainedLicense.IsLicenseDetained(_LicenseID) == true)
                {

                    _SaveDetainedLicense();
                    if (_DetainedLicense.Save())
                    {
                        lblDetainIDValue.Text = _DetainedLicense.DetainID.ToString();
                        llblShowLicenseInfo.Enabled = true;
                        MessageBox.Show(" Renew License with ID " + _DetainedLicense.LicenseID + " Is Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Detianing License with ID " + _DetainedLicense.DetainID + " Was Not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(" License with ID " + _License.LicenseID + " Is Already Detained ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" License with ID " + _License.LicenseID + " Is Not Activated Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _LoadDetainData();
            if (_LicenseID != -1)
            {
                gbFilter.Enabled = false;
                _License = clsLicense.Find(_LicenseID);
                llblShowLicenseHistory.Enabled = true;

                if (_License != null)
                {
                    lblLicenseIDValue.Text = _License.LicenseID.ToString();
                    ctrlLicenseInfo1.LoadLicense(_License.LicenseID);

                    btnDetain.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Inable To Find License with ID " + txtSearch.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(_License.LicenseID);
            frmShowLicenseHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_License.LicenseID);
            frmShowLicense.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//if not digit or contorl button canel entry 
            {
                e.Handled = true;
            }
        }
    }
}
