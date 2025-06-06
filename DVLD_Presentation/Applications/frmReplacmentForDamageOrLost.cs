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
    public partial class frmReplacmentForDamageOrLost : Form
    {
        private clsLicense _OldLicense;
        private clsLicense _ReplaceLicense= new clsLicense();
        private int _OldLicenseID;
        private clsManageApplicationTypes _AppType;
        public frmReplacmentForDamageOrLost()
        {
            InitializeComponent();
        }
        private void _UpdateOldLicense()
        {
            _OldLicense.IsActive = false;
            _OldLicense.Mode = clsLicense.enMode.Update;
            if (!_OldLicense.Save())
            {
                MessageBox.Show(" Old License with ID " + _OldLicense.LicenseID + "Was Not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void _SaveReplaceApplication()
        {

            _ReplaceLicense.ApplicationData.ApplicantPersonID = _OldLicense.ApplicationData.ApplicantPersonID;
            _ReplaceLicense.ApplicationData.ApplicationDate = DateTime.Now;
            _ReplaceLicense.ApplicationData.ApplicationTypeID = _AppType.ApplicationTypeID;
            _ReplaceLicense.ApplicationData.ApplicationStatus = 3;
            _ReplaceLicense.ApplicationData.LastStatusDate = DateTime.Now;
            _ReplaceLicense.ApplicationData.PaidFees = _AppType.ApplicationFees;
            _ReplaceLicense.ApplicationData.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;

        }
        private void _SaveReplaceLicense()
        {
            _ReplaceLicense.ApplicationID = _ReplaceLicense.ApplicationData.ApplicationID;
            _ReplaceLicense.DriverID = _OldLicense.DriverID;
            _ReplaceLicense.LicenseClassID = _OldLicense.LicenseClassID;
            _ReplaceLicense.IssueDate = _OldLicense.IssueDate;
            _ReplaceLicense.ExpirationDate = _OldLicense.ExpirationDate;
            _ReplaceLicense.Notes = _OldLicense.Notes;
            _ReplaceLicense.PaidFees = _OldLicense.PaidFees;
            _ReplaceLicense.IsActive = true;
            if (rbDamage.Checked== true)
            {
                _ReplaceLicense.IssueReason =3 ;
            }
            else
            {
                _ReplaceLicense.IssueReason = 4;
            }

            _ReplaceLicense.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;
        }
        private void _CheckAppType() 
        {
            if (rbDamage.Checked == true)
            {
                _AppType=clsManageApplicationTypes.Find(4);
            }
            else
            {
                _AppType = clsManageApplicationTypes.Find(3);
            }
        }
        private void _LoadReplaceApplication()
        {

            lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _CheckAppType();
            lblApplicationFeesValue.Text = _AppType.ApplicationFees.ToString();
            lblCreatedByValue.Text = clsGlobalSettings.LoggedInUser.UserName;

        }
        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            int.TryParse(txtSearch.Text, out int OldLicenseID);
            _OldLicenseID = OldLicenseID;
            _OldLicense = clsLicense.Find(_OldLicenseID);
            llblShowLicenseHistory.Enabled = true;

            if (_OldLicense != null)
            {
                lblOldLicenseIDValue.Text=_OldLicense.LicenseID.ToString();
                ctrlLicenseInfo1.LoadLicense(_OldLicense.LicenseID);
                
                btnIssueReplacement.Enabled = true;

            }
            else
            {
                MessageBox.Show("Inable To Find License with ID " + txtSearch.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReplacmentForDamageOrLost_Load(object sender, EventArgs e)
        {
            _LoadReplaceApplication();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            
            if (_OldLicense.IsActive == true)
            {

                _SaveReplaceApplication();
                if (_ReplaceLicense.ApplicationData.Save())
                {
                    lblRApplicationIDValue.Text = _ReplaceLicense.ApplicationData.ApplicationID.ToString();

                    _SaveReplaceLicense();
                    if (_ReplaceLicense.Save())
                    {
                        lblReplacedLicenseIDValue.Text = _ReplaceLicense.LicenseID.ToString();
                        _UpdateOldLicense();
                        llblShowLicenseInfo.Enabled = true;
                        MessageBox.Show(" Renew License with ID " + _ReplaceLicense.LicenseID + " Is Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Renew License with ID " + _ReplaceLicense.LicenseID + " Was Not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(" Application with ID " + _ReplaceLicense.ApplicationData.ApplicationID + " Was Not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show(" License with ID " + _OldLicense.LicenseID + " Is Not Activated Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbDamage_CheckedChanged(object sender, EventArgs e)
        {
            _CheckAppType();

            lblApplicationFeesValue.Text = _AppType.ApplicationFees.ToString();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            _CheckAppType();

            lblApplicationFeesValue.Text = _AppType.ApplicationFees.ToString();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(_OldLicense.DriverID);
            frmShowLicenseHistory.ShowDialog();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_ReplaceLicense.LicenseID);
            frmShowLicense.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
