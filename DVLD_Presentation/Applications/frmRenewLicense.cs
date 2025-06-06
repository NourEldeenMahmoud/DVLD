using DVLD_Business;
using DVLD_Presentation.InternationalLicense;
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
    public partial class frmRenewLicense : Form
    {
        private clsManageApplicationTypes _AppType = clsManageApplicationTypes.Find(2);
        private clsLicense _RenewLicense = new clsLicense();
        private clsLicense _OldLicense;
        private clsLicenseClasses _LicenseClass;
        private int _OldLicenseID;

        public frmRenewLicense()
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
        private void _SaveRenewApplication()
        {
            _RenewLicense.ApplicationData.ApplicantPersonID=_OldLicense.ApplicationData.ApplicantPersonID;
            _RenewLicense.ApplicationData.ApplicationDate = DateTime.Now;
            _RenewLicense.ApplicationData.ApplicationTypeID = 2;
            _RenewLicense.ApplicationData.ApplicationStatus = 3;
            _RenewLicense.ApplicationData.LastStatusDate = DateTime.Now;
            _RenewLicense.ApplicationData.PaidFees = _AppType.ApplicationFees;
            _RenewLicense.ApplicationData.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;

        }
        private void _SaveRenewLicense()
        {
            _RenewLicense.ApplicationID= _RenewLicense.ApplicationData.ApplicationID;
            _RenewLicense.DriverID = _OldLicense.DriverID;
            _RenewLicense.LicenseClassID = _OldLicense.LicenseClassID;
            _RenewLicense.IssueDate = DateTime.Now;
            _RenewLicense.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
            _RenewLicense.Notes = rtxtNotes.Text;
            _RenewLicense.PaidFees = _LicenseClass.ClassFees;
            _RenewLicense.IsActive = true;
            _RenewLicense.IssueReason = 2;  
            _RenewLicense.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;
        }
        private void _LoadRenewApplication()
        {
            lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationFeesValue.Text = _AppType.ApplicationFees.ToString();
            lblCreatedByValue.Text = clsGlobalSettings.LoggedInUser.UserName;

        }
        private void _LoadOldApplication()
        {
            lblOldLicenseIDValue.Text = _OldLicense.LicenseID.ToString();
            lblExpirationDateValue.Text = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength).ToString();
            lblApplicationFeesValue.Text = _AppType.ApplicationFees.ToString();
            lblTotalFeesValue.Text = (_AppType.ApplicationFees+_LicenseClass.ClassFees).ToString();

        }
        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            _LoadRenewApplication();


        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            int.TryParse(txtSearch.Text, out int OldLicenseID);
            _OldLicenseID = OldLicenseID;
            _OldLicense = clsLicense.Find(_OldLicenseID);
            llblShowLicenseHistory.Enabled = true;

            if (_OldLicense != null)
            {
                _LicenseClass= clsLicenseClasses.Find(_OldLicense.LicenseClassID);
                ctrlLicenseInfo1.LoadLicense(_OldLicense.LicenseID);
                _LoadOldApplication(); 
                btnIssue.Enabled = true;
                
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_OldLicense.IsActive==true)
            {
                if (DateTime.Now > _OldLicense.ExpirationDate)
                {
                    
                    _SaveRenewApplication();
                    if (_RenewLicense.ApplicationData.Save())
                    {
                        lblRLApplicationIDValue.Text= _RenewLicense.ApplicationData.ApplicationID.ToString();

                        _SaveRenewLicense();
                        if (_RenewLicense.Save())
                        {
                            lblRenewLicenseIDValue.Text= _RenewLicense.LicenseID.ToString();
                            _UpdateOldLicense();
                            llblShowLicenseInfo.Enabled = true;
                            MessageBox.Show(" Renew License with ID " + _RenewLicense.LicenseID + " Is Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(" Renew License with ID " + _RenewLicense.LicenseID + " Was Not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(" Application with ID " + _RenewLicense.ApplicationData.ApplicationID + " Was Not Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    
                }
                else
                {
                    MessageBox.Show(" License with ID " + _OldLicense.LicenseID + " Is Not Expired Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" License with ID " + _OldLicense.LicenseID + " Is Not Activated ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(_OldLicense.DriverID);
            frmShowLicenseHistory.ShowDialog();

        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense= new frmShowLicense(_RenewLicense.LicenseID);
            frmShowLicense.ShowDialog();
        }
    }
}
