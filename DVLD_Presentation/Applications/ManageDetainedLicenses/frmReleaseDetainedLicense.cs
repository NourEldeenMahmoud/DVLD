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
    public partial class frmReleaseDetainedLicense : Form
    {
        private clsDetainedLicense _DetainedLicense;
        private int _LicenseID=-1;
        private clsLicense _License;
        private clsManageApplicationTypes _AppType = clsManageApplicationTypes.Find(5);
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }
        private void _SaveDetainedLicense()
        {
            _DetainedLicense.ApplicationData.ApplicantPersonID = _License.ApplicationData.ApplicantPersonID;
            _DetainedLicense.ApplicationData.ApplicationDate= DateTime.Now;
            _DetainedLicense.ApplicationData.ApplicationTypeID= 5;
            _DetainedLicense.ApplicationData.ApplicationStatus = 3;
            _DetainedLicense.ApplicationData.LastStatusDate = DateTime.Now;
            _DetainedLicense.ApplicationData.PaidFees = _AppType.ApplicationFees;
            _DetainedLicense.ApplicationData.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;

            //
            _DetainedLicense.IsReleased = true;
            _DetainedLicense.ReleaseDate = DateTime.Now;
            _DetainedLicense.ReleasedByUserID= clsGlobalSettings.LoggedInUser.UserID;
            _DetainedLicense.Mode = clsDetainedLicense.enMode.Update;

        }
        private void _LoadDeDetainedLicense()
        {
            lblDetainIDValue.Text=_DetainedLicense.DetainID.ToString();
            lblDetainDateValue.Text = _DetainedLicense.DetainDate.ToString("dd/MM/yyyy");
            lblApplicationFeesValue.Text = _AppType.ApplicationFees.ToString();
            lblFineFeesValue.Text = _DetainedLicense.FineFees.ToString();
            lblTotalFeesValue.Text = (_DetainedLicense.FineFees + _AppType.ApplicationFees).ToString();
            lblLicenseIDValue.Text = _DetainedLicense.LicenseID.ToString();
            lblCreatedByValue.Text = _DetainedLicense.CreatedByUserID.ToString();

        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            int.TryParse(txtSearch.Text, out int OldLicenseID);
            _LicenseID = OldLicenseID;
            _License = clsLicense.Find(_LicenseID);
            _DetainedLicense = clsDetainedLicense.Find(_LicenseID);
            
            llblShowLicenseHistory.Enabled = true;

            if (_DetainedLicense != null)
            {
                _LoadDeDetainedLicense();
                ctrlLicenseInfo1.LoadLicense(_DetainedLicense.LicenseID);

                btnRelease.Enabled = true;

            }
            else
            {
                MessageBox.Show("Inable To Find License with ID " + txtSearch.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
                if (clsDetainedLicense.IsLicenseDetained(_LicenseID) == true)
                {

                    _SaveDetainedLicense();
                    if (_DetainedLicense.Save())
                    {
                        lblApplicationID.Text = _DetainedLicense.ReleaseApplicationID.ToString();
                        llblShowLicenseInfo.Enabled = true;
                        MessageBox.Show("  License with ID " + _DetainedLicense.LicenseID + " Is Releases Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_LicenseID!=-1)
            {
                gbFilter.Enabled = false;
                _DetainedLicense = clsDetainedLicense.Find(_LicenseID);
                _License = clsLicense.Find(_DetainedLicense.LicenseID);
                
                llblShowLicenseHistory.Enabled = true;
                if (_DetainedLicense != null)
                {
                    _LoadDeDetainedLicense();
                    ctrlLicenseInfo1.LoadLicense(_DetainedLicense.LicenseID);

                    btnRelease.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Inable To Find License with ID " + txtSearch.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_LicenseID);
            frmShowLicense.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(_License.DriverID);
            frmShowLicenseHistory.ShowDialog();
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
