using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmAddUpdateAppointment : Form
    {
        private int _LDLAppID = -1;
        private int _AppointmentID = -1;
        private clsLocalDrivingLicenseApplication _LDLApp;
        private clsTestAppointment _TestAppointment;
        private clsManageTestTypes _TestType;
        private bool _Retake = false;
        public frmAddUpdateAppointment(int AppointmentID, int LDLAppID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _LDLAppID = LDLAppID;

        }
        public frmAddUpdateAppointment(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }
        public frmAddUpdateAppointment(int LDLAppID, bool Retake)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
            _Retake = Retake;
        }

        private void _SaveAppointment()
        {

            _TestAppointment.LocalDrivingLicenseApplicationID = _LDLAppID;
            _TestAppointment.TestTypeID = _TestType.TestTypeID;
            _TestAppointment.AppointmentDate = guna2DateTimePicker1.Value;
            _TestAppointment.PaidFees = _TestType.TestFees;
            _TestAppointment.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;
            _TestAppointment.IsLocked = false;

        }
        private void _LoadData()
        {
            lblIDValue.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClassValue.Text = clsLicenseClasses.GetClassTitleByID(_LDLApp.LicenseClassID);
            lblNameValue.Text = _LDLApp.ApplicaionData.PersonData.FullName();
            lblFeesValue.Text = _TestType.TestFees.ToString();
            //Trails
            //??
            if (_TestAppointment.Mode == clsTestAppointment.enMode.Update)
            {
                guna2DateTimePicker1.Value = _TestAppointment.AppointmentDate;
            }
            //fees
            if (_Retake)
            {
                lblTitle.Text = "Retake Test";
                gbRetakeTest.Enabled = true;
                lblRetakeTestIDValue.Text = "";
                lblRetakeFeesValue.Text = "5";
                lblTotalFeesValue.Text = (_TestType.TestFees + 5).ToString();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdateAppointment_Load(object sender, EventArgs e)
        {

            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            int TestTypeID = (clsLocalDrivingLicenseApplication.GetPassedTests(_LDLAppID) + 1);
            if (TestTypeID < 4)
            {
                _TestType = clsManageTestTypes.Find(TestTypeID);
            }
           
            if (_AppointmentID == -1)
            {

                _TestAppointment = new clsTestAppointment();
                _TestAppointment.Mode = clsTestAppointment.enMode.AddNew;
                _LoadData();


            }
            else
            {

                _TestAppointment = clsTestAppointment.Find(_AppointmentID);
                _TestAppointment.Mode = clsTestAppointment.enMode.Update;
                _LoadData();

            }
        }
        private void _RetakeTestApp()
        {
            clsApplication RetakeApp = new clsApplication();
            RetakeApp.ApplicantPersonID = _LDLApp.ApplicaionData.ApplicantPersonID;
            RetakeApp.ApplicationDate = DateTime.Now;
            RetakeApp.ApplicationTypeID = 7;
            RetakeApp.ApplicationStatus = 1;
            RetakeApp.LastStatusDate = DateTime.Now;
            RetakeApp.PaidFees = 5;
            RetakeApp.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;
            RetakeApp.Save();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveAppointment();
            if (_Retake)
            {
                _RetakeTestApp();
            }
            if (_TestAppointment.Save())
            {
                MessageBox.Show("Application Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Application Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
