using DVLD_Business;
using DVLD_Presentation.People;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlApplicationInfo : UserControl
    {
        clsApplication _Application;
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        private void gbApplicationInfo_Click(object sender, EventArgs e)
        {

        }
        public void LoadApplication(int ApplicationID)
        {
            _Application = clsApplication.Find(ApplicationID);
            lblIDValue.Text = _Application.ApplicationID.ToString();
            if (_Application.ApplicationStatus == 1)
            {
                lblStatusValue.Text = "New";
            }
            else if (_Application.ApplicationStatus == 2)
            {
                lblStatusValue.Text = "Cancelled";
            }
            else
            {
                lblStatusValue.Text = "Completed";
            }
            lblFeesValue.Text = _Application.PaidFees.ToString();
            lblTypeValue.Text = clsManageApplicationTypes.GetApplicationTypeName(_Application.ApplicationTypeID);
            lblStatusDateValue.Text = _Application.LastStatusDate.ToString("dd/MM/yyyy");
            lblDateValue.Text = _Application.ApplicationDate.ToString("dd/MM/yyyy");
            lblApplicantValue.Text = clsPerson.GetFullNameByID(_Application.ApplicantPersonID);
            lblCreatedByValue.Text = clsUser.GetUserNameByID(_Application.CreatedByUserID);

        }

        private void llblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonCardDetails frmPersonCardDetails = new frmPersonCardDetails(_Application.ApplicantPersonID);
            frmPersonCardDetails.ShowDialog();
        }
    }
}
