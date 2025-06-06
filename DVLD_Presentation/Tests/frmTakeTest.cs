using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID;
        private clsTestAppointment _TestAppointment;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsTest _Test;
        public frmTakeTest(int AppointmentID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _TestAppointment = clsTestAppointment.Find(_AppointmentID);
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_TestAppointment.LocalDrivingLicenseApplicationID);
            _LoadData();

            _Test = new clsTest();
            _Test.Mode = clsTest.enMode.AddNew;
        }
        private void _LoadData()
        {
            lblIDValue.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClassValue.Text = clsLicenseClasses.GetClassTitleByID(_LDLApp.LicenseClassID);
            lblNameValue.Text = _LDLApp.ApplicaionData.PersonData.FullName();
            lblFeesValue.Text = _TestAppointment.PaidFees.ToString();
            lblDateValue.Text = _TestAppointment.AppointmentDate.ToString("dd/MM/yyyy");

        }
        private void _SaveTest()
        {
            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = rtxtNotes.Text;
            _Test.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveTest();
            _TestAppointment.IsLocked = true;
            _TestAppointment.Mode = clsTestAppointment.enMode.Update;
            if (_Test.Save() && _TestAppointment.Save())
            {
                MessageBox.Show("Test Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Test Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
