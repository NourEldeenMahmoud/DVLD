using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmManageTestAppointments : Form
    {
        private static int _LDLAppID = -1;
        private int _AppointmentID = -1;
        clsLocalDrivingLicenseApplication _LDLApp;
        clsTestAppointment _TestAppointment;
        DataTable dtAllAppointments = clsTestAppointment.GetPersonAppointments(_LDLAppID);

        private clsManageTestTypes _TestType;
        public frmManageTestAppointments(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }



        private void frmManageTestAppointments_Load(object sender, EventArgs e)
        {
            DataTable dtAllAppointments = clsTestAppointment.GetPersonAppointments(_LDLAppID);
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);

            _TestType = clsManageTestTypes.Find(clsLocalDrivingLicenseApplication.GetPassedTests(_LDLAppID) + 1);

            lblTitle.Text = _TestType.TestTypeTitle;

            dgvListAppointments.DataSource = dtAllAppointments;


            ctrlLDLAppInfo1.LoadLDLApp(_LDLAppID);
            ctrlApplicationInfo1.LoadApplication(_LDLApp.ApplicationID);

            lblNumberOfRecords.Text = dtAllAppointments.Rows.Count.ToString();


        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.CheckForActiveAppointment(_LDLAppID))
            {
                MessageBox.Show("Person Already have an active Appointment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clsTestAppointment.LastTestFailed(_LDLAppID))
            {
                frmAddUpdateAppointment frmAddUpdateAppointment = new frmAddUpdateAppointment(_LDLAppID, true);
                frmAddUpdateAppointment.ShowDialog();
                dgvListAppointments.DataSource = clsTestAppointment.GetPersonAppointments(_LDLAppID); ;
            }
            else
            {
                frmAddUpdateAppointment frmAddUpdateAppointment = new frmAddUpdateAppointment(_LDLAppID);
                frmAddUpdateAppointment.ShowDialog();
                int TestTypeID = (clsLocalDrivingLicenseApplication.GetPassedTests(_LDLAppID) + 1);
                if (TestTypeID ==3)
                {
                    btnSchedule.Enabled = false;
                }
                dgvListAppointments.DataSource = clsTestAppointment.GetPersonAppointments(_LDLAppID); ;

            }

        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateAppointment frmAddUpdateAppointment = new frmAddUpdateAppointment(_AppointmentID, _LDLAppID);
            frmAddUpdateAppointment.ShowDialog();
            dgvListAppointments.DataSource = clsTestAppointment.GetPersonAppointments(_LDLAppID); 

        }

        private void dgvListAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var selectedRow = dgvListAppointments.Rows[e.RowIndex];

            if (selectedRow.Cells["TestAppointmentID"].Value != null &&
                int.TryParse(selectedRow.Cells["TestAppointmentID"].Value.ToString(), out int selectedID))
            {
                _AppointmentID = selectedID;
            }
            else
            {
                MessageBox.Show("You need to select a valid Appointment ID.");
            }
        }

        private void dgvListAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var selectedRow = dgvListAppointments.Rows[e.RowIndex];

            if (selectedRow.Cells["TestAppointmentID"].Value != null &&
                int.TryParse(selectedRow.Cells["TestAppointmentID"].Value.ToString(), out int selectedID))
            {
                _AppointmentID = selectedID;
            }
            else
            {
                MessageBox.Show("You need to select a valid Appointment ID.");
            }
        }

        private void cmTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeTest frmTakeTes = new frmTakeTest(_AppointmentID);
            frmTakeTes.ShowDialog();
            
            clsTestAppointment.GetPersonAppointments(_LDLAppID);
            dgvListAppointments.DataSource = clsTestAppointment.GetPersonAppointments(_LDLAppID);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvListAppointments.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }
            var isLockedValue = dgvListAppointments.CurrentRow.Cells["IsLocked"].Value;
            bool isLocked = false;

            if (isLockedValue != null && bool.TryParse(isLockedValue.ToString(), out bool result))
            {
                isLocked = result;
            }
            if (isLocked)
            {
                cmEdit.Enabled = false;
                cmTakeTest.Enabled = false;
            }
            else
            {
                cmEdit.Enabled = true;
                cmTakeTest.Enabled = true;
            }


        }

        private void dgvListAppointments_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var selectedRow = dgvListAppointments.Rows[e.RowIndex];

            if (selectedRow.Cells["TestAppointmentID"].Value != null &&
                int.TryParse(selectedRow.Cells["TestAppointmentID"].Value.ToString(), out int selectedID))
            {
                _AppointmentID = selectedID;
            }
            else
            {
                MessageBox.Show("You need to select a valid Appointment ID.");
            }
        }
    }
}
