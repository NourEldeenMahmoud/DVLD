using DVLD_Business;
using DVLD_Presentation.InternationalLicense;
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
    public partial class frmAddInternationalLicense : Form
    {
        private clsManageApplicationTypes _AppType =clsManageApplicationTypes.Find(6);
        private clsInternationalLicense _InternationalLicense = new clsInternationalLicense();
        private clsLicense _License;
        private int _LicenseID;
        public frmAddInternationalLicense()
        {
            InitializeComponent();
        }
        private void _LoadInternationalApp()
        {
            lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFeesValue.Text= _AppType.ApplicationFees.ToString();
            lblExpirationDateValue.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");
            lblCreatedByValue.Text = clsGlobalSettings.LoggedInUser.UserName;
            

        }
        private void _SaveApplication()
        {
            _InternationalLicense.ApplicationData.ApplicantPersonID =_License.ApplicationData.ApplicantPersonID ;
            _InternationalLicense.ApplicationData.ApplicationDate = DateTime.Now;
            _InternationalLicense.ApplicationData.ApplicationTypeID = 6 ;
            _InternationalLicense.ApplicationData.ApplicationStatus = 3;
            _InternationalLicense.ApplicationData.LastStatusDate = DateTime.Now;
            _InternationalLicense.ApplicationData.PaidFees = _AppType.ApplicationFees;
            _InternationalLicense.ApplicationData.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;
            //
            _InternationalLicense.DriverID=_License.DriverID ;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
            _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _InternationalLicense.IsActive = true;
            _InternationalLicense.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;

            
           
        }
        private void frmInternationalLicensecs_Load(object sender, EventArgs e)
        {
            _LoadInternationalApp();
            
        }
        private bool CheckForIssue()
        {
            if (!_License.IsActive)
            {
                return false;
            }
            else if (_License.ExpirationDate<DateTime.Now)
            {
                return false;
            }
            else
            { return true; }
        
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveApplication();
            if (!clsInternationalLicense.IsInternationalLicenseExist(_License.DriverID))
            {
                if (CheckForIssue())
                {

                    if (_InternationalLicense.Save())
                    {
                        lblILApplicationValue.Text = _InternationalLicense.ApplicationData.ApplicationID.ToString();
                        lblILIDValue.Text = _InternationalLicense.InternationalLicenseID.ToString();
                        llblShowLicenseInfo.Enabled = true;
                        MessageBox.Show("Application Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Application Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Your License is either expired or deactivaed ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("You Already Have an InternationalLicense ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDriverLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            int.TryParse(txtSearch.Text, out int LicenseID);
            _LicenseID = LicenseID;
            _License = clsLicense.Find(LicenseID);
            if (_License != null)
            {
                ctrlLicenseInfo1.LoadLicense(LicenseID);
                lblLocalLicenseIDValue.Text = _LicenseID.ToString();
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Inable To Find License with ID " + LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//if not digit or contorl button canel entry 
            {
                e.Handled = true;
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowIntLicenseInfo frmShowIntLicenseInfo = new frmShowIntLicenseInfo(_InternationalLicense.InternationalLicenseID);
            frmShowIntLicenseInfo.ShowDialog();
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmIntLicenseHistory frmIntLicenseHistory =new  frmIntLicenseHistory(_License.DriverID);
            frmIntLicenseHistory.ShowDialog();
        }

        private void ctrlLicenseInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
