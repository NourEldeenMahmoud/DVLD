using DVLD_Business;
using DVLD_Presentation.License;
using DVLD_Presentation.LocalDrivingLicense;
using DVLD_Presentation.Tests;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation.NewLocalDrivingLicense
{
    public partial class frmListLocalLicenseApplications : Form
    {
        DataTable dtAllLocalLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
        private int _LDLAppID;
        private string _NationalNo = "";
        public void Header()
        {


        }
        public frmListLocalLicenseApplications()
        {

            InitializeComponent();
        }
        private void _CheckTest()
        {
            int Test = clsLocalDrivingLicenseApplication.GetPassedTests(_LDLAppID) + 1;
            if (Test == 1)
            {
                cmScheduleTest.Enabled = true;
                cmVisionTest.Enabled = true;
                cmWrittenTest.Enabled = false;
                cmStreetTest.Enabled = false;
            }
            if (Test == 2)
            {
                cmScheduleTest.Enabled = true;
                cmVisionTest.Enabled = false;
                cmWrittenTest.Enabled = true;
                cmStreetTest.Enabled = false;
            }
            else if (Test == 3)
            {
                cmScheduleTest.Enabled = true;
                cmVisionTest.Enabled = false;
                cmWrittenTest.Enabled = false;
                cmStreetTest.Enabled = true;
            }
            else if (Test > 3)
            {
                cmScheduleTest.Enabled = false;
                cmIssueLicense.Enabled = true;
            }

        }
        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            Header();
            dgvListApplications.DataSource = dtAllLocalLicenseApplications;
            dgvListApplications.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "LDLAppID";
            lblNumberOfRecords.Text = dtAllLocalLicenseApplications.Rows.Count.ToString();
        }
        private void _GetNationnalNo()
        {
            if (dgvListApplications.CurrentRow == null)
            {
                return;
            }
            var NationalNoCell = dgvListApplications.CurrentRow.Cells["NationalNo"].Value;

            string NationalNo = "";


            if (NationalNoCell != null)
            {
                NationalNo = NationalNoCell.ToString();
            }
            _NationalNo = NationalNo;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frmNewLocalLicense = new frmNewLocalDrivingLicenseApplication();
            frmNewLocalLicense.ShowDialog();
            dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
        }

        private void cmCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Cancel Application With ID " + _LDLAppID + " ?!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsLocalDrivingLicenseApplication.Cancel(_LDLAppID))
                {

                    MessageBox.Show("Application With ApplicationID " + _LDLAppID + " Is Canceled Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Application With ApplicationID " + _LDLAppID + " Was Not Canceled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
            }
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete LDLApp With ID " + _LDLAppID + " ?!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsLocalDrivingLicenseApplication.Delete(_LDLAppID))
                {

                    MessageBox.Show("Application With ApplicationID " + _LDLAppID + " Is Deleted Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Application With ApplicationID " + _LDLAppID + " Was Not Deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
            }
        }

        private void dgvListApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                object cellValue = dgvListApplications.Rows[e.RowIndex].Cells["LocalDrivingLicenseApplicationID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _LDLAppID = selectedID;
                    _CheckTest();
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Application wich you want to show");
                    return;
                }
            }
            _GetNationnalNo();
        }

        private void dgvListApplications_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListApplications.Rows[e.RowIndex].Cells["LocalDrivingLicenseApplicationID"].Value != null)
            {
                int.TryParse(dgvListApplications.Rows[e.RowIndex].Cells["LocalDrivingLicenseApplicationID"].Value.ToString(), out _LDLAppID);

                _CheckTest();
            }
            _GetNationnalNo();
        }
        private void dgvListPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                object cellValue = dgvListApplications.Rows[e.RowIndex].Cells["LocalDrivingLicenseApplicationID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _LDLAppID = selectedID;
                    _CheckTest();
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Application wich you want to show");
                    return;
                }
            }
            _GetNationnalNo();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string Selected = cbFilterBy.SelectedItem.ToString();
            switch (Selected)
            {
                case "None":
                    dgvListApplications.DataSource = dtAllLocalLicenseApplications; // no order 
                    break;
                case "LDLAppID":
                    txtSearch.Visible = true;
                    dgvListApplications.Sort(dgvListApplications.Columns["LocalDrivingLicenseApplicationID"], ListSortDirection.Ascending);
                    break;
                case "NationalNo":
                    txtSearch.Visible = true;
                    dgvListApplications.Sort(dgvListApplications.Columns["NationalNo"], ListSortDirection.Ascending);
                    break;
                case "FullName":
                    txtSearch.Visible = true;
                    dgvListApplications.Sort(dgvListApplications.Columns["FullName"], ListSortDirection.Ascending);
                    break;
                case "Status":
                    txtSearch.Visible = true;
                    dgvListApplications.Sort(dgvListApplications.Columns["Status"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Default !!!!!!!!!!!!!");
                    dgvListApplications.Sort(dgvListApplications.Columns["PersonID"], ListSortDirection.Ascending);
                    break;

            }
            dgvListApplications.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.SelectedItem != null)
            {
                string columnName = cbFilterBy.SelectedItem.ToString();
                if (cbFilterBy.SelectedItem.ToString() == "LDLAppID")
                {
                    columnName = "LocalDrivingLicenseApplicationID";
                }
                string searchText = txtSearch.Text.Trim().Replace("'", "''");

                string filter = dtAllLocalLicenseApplications.Columns[columnName].DataType == typeof(string) ? $"{columnName} LIKE '%{searchText}%'" : $"CONVERT({columnName}, 'System.String') LIKE '%{searchText}%'";

                dtAllLocalLicenseApplications.DefaultView.RowFilter = filter;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cbFilterBy.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//if not digit or contorl button canel entry 
                {
                    e.Handled = true;
                }
            }
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication frmNewLocalLicense = new frmNewLocalDrivingLicenseApplication(_LDLAppID);
            frmNewLocalLicense.ShowDialog();
            dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
        }

        private void cmShow_Click(object sender, EventArgs e)
        {
            frmShowLDLAppDetails frmShowLDLAppDetails = new frmShowLDLAppDetails(_LDLAppID);
            frmShowLDLAppDetails.ShowDialog();
        }

        private void cmVisionTest_Click(object sender, EventArgs e)
        {
            frmManageTestAppointments frmManageTestAppointments = new frmManageTestAppointments(_LDLAppID);
            frmManageTestAppointments.ShowDialog();
            dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();


        }

        private void cmWrittenTest_Click(object sender, EventArgs e)
        {

            frmManageTestAppointments frmManageTestAppointments = new frmManageTestAppointments(_LDLAppID);
            frmManageTestAppointments.ShowDialog();
            dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
        }

        private void cmStreetTest_Click(object sender, EventArgs e)
        {
            frmManageTestAppointments frmManageTestAppointments = new frmManageTestAppointments(_LDLAppID);
            frmManageTestAppointments.ShowDialog();
            dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();

        }

        private void cmIssueLicense_Click(object sender, EventArgs e)
        {
            frmIssueLicense frmIssueLicense = new frmIssueLicense(_LDLAppID);
            frmIssueLicense.ShowDialog();
            dgvListApplications.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalLicensesApplications();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvListApplications.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }
            var StatusValueCell = dgvListApplications.CurrentRow.Cells["Status"].Value;
            string StatusValue = "";

            if (StatusValueCell != null)
            {
                StatusValue = StatusValueCell.ToString();
            }
            if (StatusValue == "Cancelled")
            {
                cmEdit.Enabled = false;
                cmDelete.Enabled = true;
                cmIssueLicense.Enabled = false;
                cmScheduleTest.Enabled = false;
                cmShow.Enabled = false;
                cmCancel.Enabled = false;
                cmShowLicense.Enabled = false;
                cmShowLicenseHistory.Enabled = false;
            }
            else if (StatusValue == "Completed")
            {
                cmEdit.Enabled = false;
                cmIssueLicense.Enabled = false;
                cmScheduleTest.Enabled = false;
                cmDelete.Enabled = false;
                cmShow.Enabled = true;
                cmCancel.Enabled = false;
                cmShowLicense.Enabled = true;
                cmShowLicenseHistory.Enabled = true;
            }
            else if (StatusValue == "New")
            {
                cmEdit.Enabled = true;
                cmDelete.Enabled = true;
                cmShow.Enabled = true;
                cmCancel.Enabled = true;
                cmShowLicense.Enabled = false;
                cmShowLicenseHistory.Enabled = true;
            }
        }

        private void cmShowLicense_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            int LicenseID = clsLicense.GetLicenseIDByApplicationID(LDLApp.ApplicationID);
            frmShowLicense frmShowLicense = new frmShowLicense(LicenseID);
            frmShowLicense.ShowDialog();
        }

        private void cmShowLicenseHistory_Click(object sender, EventArgs e)
        {
            clsPerson _Person = clsPerson.Find(_NationalNo);
            clsDriver _Driver = clsDriver.GetDriverByPersonID(_Person.PersonID);
            frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(_Driver.DriverID);
            frmShowLicenseHistory.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
