using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Presentation.LocalDrivingLicense
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public clsLocalDrivingLicenseApplication _LocalLicenseApplication;
        public clsApplication _Application;
        private int _LocalAppLicenseID = -1;
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        public frmNewLocalDrivingLicenseApplication(int LocalAppLicenseID)
        {
            InitializeComponent();
            _LocalAppLicenseID = LocalAppLicenseID;

        }

        private void _SaveApplication()
        {


            _LocalLicenseApplication.LicenseClassID = cbLicenseClass.SelectedIndex + 1;
            _LocalLicenseApplication.ApplicaionData.ApplicationStatus = 1;
            _LocalLicenseApplication.ApplicaionData.ApplicationTypeID = 1;
            _LocalLicenseApplication.ApplicaionData.ApplicationDate = DateTime.Parse(lblApplicationDateValue.Tag.ToString());
            _LocalLicenseApplication.ApplicaionData.LastStatusDate = DateTime.Now;
            _LocalLicenseApplication.ApplicaionData.PaidFees = 15;
            _LocalLicenseApplication.ApplicaionData.CreatedByUserID = clsGlobalSettings.LoggedInUser.UserID;



        }
        private void _UpdateApplication()
        {
            btnSave.Visible = true;
            lblLocalLicenseAppIDValue.Text = _LocalLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationDateValue.Tag = DateTime.Now;
            cbLicenseClass.SelectedItem = _LocalLicenseApplication.LicenseClassID;
            lblApplicationFeesValue.Text = _LocalLicenseApplication.ApplicaionData.PaidFees.ToString() + "$";
            lblCreatedByValue.Text = _LocalLicenseApplication.ApplicaionData.CreatedByUserID.ToString();
        }
        private void _NewApplication()//new
        {

            lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblApplicationDateValue.Tag = DateTime.Now;
            lblApplicationFeesValue.Text = " 15$";
            lblCreatedByValue.Text = clsGlobalSettings.LoggedInUser.UserName;
            lblCreatedByValue.Tag = clsGlobalSettings.LoggedInUser.UserID;

        }

        private void _FillClasses()
        {
            DataTable dtAllClasses = clsLicenseClasses.GetAllLicenseClasses();
            foreach (DataRow Row in dtAllClasses.Rows)
            {
                cbLicenseClass.Items.Add(Row["ClassName"]);
            }
        }
        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillClasses();
            if (_LocalAppLicenseID == -1)
            {
                _NewApplication();

                _LocalLicenseApplication = new clsLocalDrivingLicenseApplication();
                _LocalLicenseApplication.Mode = clsLocalDrivingLicenseApplication.enMode.AddNew;


            }
            else
            {
                _LocalLicenseApplication = clsLocalDrivingLicenseApplication.Find(_LocalAppLicenseID);
                _LocalLicenseApplication.Mode = clsLocalDrivingLicenseApplication.enMode.Update;
                _LocalLicenseApplication.ApplicaionData.Mode = clsApplication.enMode.Update;
                ctrlPersonCardWithFilter1.LoadPerson(_LocalLicenseApplication.ApplicaionData.ApplicantPersonID);
                _UpdateApplication();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_LocalLicenseApplication.Mode == clsLocalDrivingLicenseApplication.enMode.AddNew)
            {
                if (ctrlPersonCardWithFilter1.PersonData == null)
                {
                    MessageBox.Show("You Need To Select A Person ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnSave.Visible = true;
                    _LocalLicenseApplication.ApplicaionData.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonData.PersonID;
                    tabControl1.SelectedTab = tabControl1.TabPages[1];
                }
            }

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_LocalLicenseApplication.Mode == clsLocalDrivingLicenseApplication.enMode.AddNew)
            {
                if (e.TabPage == tpApplicationInfo)
                {
                    if (ctrlPersonCardWithFilter1.PersonData == null)
                    {
                        MessageBox.Show("You Need To Select A Person ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else
                    {
                        btnSave.Visible = true;
                        _LocalLicenseApplication.ApplicaionData.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonData.PersonID;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveApplication();
            if (!clsLocalDrivingLicenseApplication.HasActiveApplicationForClass(_LocalLicenseApplication.ApplicaionData.ApplicantPersonID, cbLicenseClass.SelectedIndex + 1))
            {
                if (_LocalLicenseApplication.Save())
                {
                    MessageBox.Show("Application Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblLocalLicenseAppIDValue.Text = _LocalLicenseApplication.ApplicaionData.ApplicationID.ToString();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Application Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Already Have an application with the same class ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbLicenseClass_Validating(object sender, CancelEventArgs e)
        {
            if (cbLicenseClass.SelectedItem == null)
            {
                errorProvider1.SetError(cbLicenseClass, "License Class Is Required !!");
                e.Cancel = true;
                cbLicenseClass.Focus();
            }
            else
            {
                errorProvider1.SetError(cbLicenseClass, "");
            }
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
