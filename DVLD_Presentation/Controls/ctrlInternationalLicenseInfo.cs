using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        private clsInternationalLicense _IntLicense;
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
            
        }
        public void LoadIntlicense(int IntLicenseID)
        {
            _IntLicense = clsInternationalLicense.Find(IntLicenseID);
            //////
            lblInternationalIDValue.Text = IntLicenseID.ToString();
            lblApplicationIDValue.Text = _IntLicense.ApplicationID.ToString();
            lblNameValue.Text = _IntLicense.DriverData.PersonData.FullName();
            lblNationalNoValue.Text = _IntLicense.DriverData.PersonData.NationalNo;
            if (_IntLicense.DriverData.PersonData.Gendar == 0)
            {
                lblGenderValue.Text = "Male";
            }
            else
            {
                lblGenderValue.Text = "Female";
            }
            lblLicenseIDValue.Text = _IntLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDateValue.Text = _IntLicense.IssueDate.ToString("dd/MM/yyyy");
           
         
            lblIsActiveValue.Text = Convert.ToBoolean(_IntLicense.IsActive) ? "Yes" : "No";
            lblDateOfBirthValue.Text = _IntLicense.DriverData.PersonData.DateOfBirth.ToString("dd/MM/yyyy");
            lblDriverIDValue.Text = _IntLicense.DriverID.ToString();
            lblExpirationDateValue.Text = _IntLicense.ExpirationDate.ToString("dd/MM/yyyy");
        }
        private void ctrlInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
