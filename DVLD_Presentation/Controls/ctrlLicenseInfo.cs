using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlLicenseInfo : UserControl
    {
        clsLicense _License;
        public ctrlLicenseInfo()
        {
            InitializeComponent();

        }
        public void LoadLicense(int LicenseID)
        {
            _License = clsLicense.Find(LicenseID);

            //////
            lblClassValue.Text = clsLicenseClasses.GetClassTitleByID(_License.LicenseClassID);
            lblNameValue.Text = _License.DriverData.PersonData.FullName();
            lblNationalNoValue.Text = _License.DriverData.PersonData.NationalNo;
            if (_License.DriverData.PersonData.Gendar == 0)
            {
                lblGenderValue.Text = "Male";
            }
            else
            {
                lblGenderValue.Text = "Female";
            }
            lblLicenseIDValue.Text = _License.LicenseID.ToString();
            lblIssueDateValue.Text = _License.IssueDate.ToString("dd/MM/yyyy");
            if (_License.IssueReason == 1)
            {
                lblIssueReasonValue.Text = "First Time";
            }
            else if (_License.IssueReason == 2)
            {
                lblIssueReasonValue.Text = "Renew";

            }
            else if (_License.IssueReason == 4)
            {
                lblIssueReasonValue.Text = "Replacement for Damaged";

            }
            else
            {
                lblIssueReasonValue.Text = " Replacement for Lost";
            }
            lblNotesValue.Text = _License.Notes == "" ? "No Note" : _License.Notes;
            lblIsActiveValue.Text = Convert.ToBoolean(_License.IsActive) ? "Yes" : "No";
            lblDateOfBirthValue.Text = _License.DriverData.PersonData.DateOfBirth.ToString("dd/MM/yyyy");
            lblDriverIDValue.Text = _License.DriverID.ToString();
            lblExpirationDateValue.Text = _License.ExpirationDate.ToString("dd/MM/yyyy");
            //IsDetained
            lblIsDetainedValue.Text = "No";


        }
        private void ctrlLicenseInfo_Load(object sender, EventArgs e)
        {


        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
