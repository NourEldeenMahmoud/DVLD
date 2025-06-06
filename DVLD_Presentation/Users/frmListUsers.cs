using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmListUsers : Form
    {
        DataTable dtAllUsers = clsUser.GetAllUsers();
        int UserID;
        int PersonID;

        public frmListUsers()
        {
            InitializeComponent();
        }
        public void Header()
        {


        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            Header();
            cbFilterBy.SelectedIndex = 0;

            dgvListUsers.DataSource = dtAllUsers;
            dgvListUsers.Columns["UserID"].Width = 50;
            dgvListUsers.Columns["PersonID"].Width = 80;
            dgvListUsers.Columns["FullName"].Width = 160;
            dgvListUsers.Columns["UserName"].Width = 70;
            dgvListUsers.Columns["IsActive"].Width = 100;

            lblNumberOfRecords.Text = dtAllUsers.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            string Selected = cbFilterBy.SelectedItem.ToString();
            switch (Selected)
            {
                case "None":
                    dgvListUsers.DataSource = dtAllUsers; // no order

                    break;
                case "UserID":
                    dgvListUsers.Sort(dgvListUsers.Columns["PersonID"], ListSortDirection.Ascending);
                    break;
                case "PersonID":
                    dgvListUsers.Sort(dgvListUsers.Columns["PersonID"], ListSortDirection.Ascending);
                    break;
                case "FullName":
                    dgvListUsers.Sort(dgvListUsers.Columns["FullName"], ListSortDirection.Ascending);
                    break;
                case "UserName":
                    dgvListUsers.Sort(dgvListUsers.Columns["UserName"], ListSortDirection.Ascending);
                    break;
                case "IsActive":
                    dgvListUsers.Sort(dgvListUsers.Columns["IsActive"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Default !!!!!!!!!!!!!");
                    dgvListUsers.Sort(dgvListUsers.Columns["PersonID"], ListSortDirection.Ascending);
                    break;

            }
            dgvListUsers.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem != null)
            {
                string columnName = cbFilterBy.SelectedItem.ToString();
                string searchText = txtSearch.Text.Trim().Replace("'", "''");

                string filter = dtAllUsers.Columns[columnName].DataType == typeof(string) ? $"{columnName} LIKE '%{searchText}%'" : $"CONVERT({columnName}, 'System.String') LIKE '%{searchText}%'";

                dtAllUsers.DefaultView.RowFilter = filter;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)//cancel entry without conditions
            {
                e.Handled = true;
            }
            else if (cbFilterBy.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//if not digit or contorl button canel entry 
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUser = new frmAddUpdateUser();
            frmAddUser.ShowDialog();
            dgvListUsers.DataSource = clsUser.GetAllUsers();
        }

        private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValueUser = dgvListUsers.Rows[e.RowIndex].Cells["UserID"].Value;
                object cellValuePerson = dgvListUsers.Rows[e.RowIndex].Cells["PersonID"].Value;

                if (cellValueUser != null && int.TryParse(cellValueUser.ToString(), out int selectedUserID) &&
                    cellValuePerson != null && int.TryParse(cellValuePerson.ToString(), out int selectedPersonID))
                {
                    UserID = selectedUserID;
                    PersonID = selectedPersonID;


                }
                else
                {
                    MessageBox.Show("You need to select a valid person and user ID.");
                }
            }
        }

        private void dgvListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValueUser = dgvListUsers.Rows[e.RowIndex].Cells["UserID"].Value;
                object cellValuePerson = dgvListUsers.Rows[e.RowIndex].Cells["PersonID"].Value;

                if (cellValueUser != null && int.TryParse(cellValueUser.ToString(), out int selectedUserID) &&
                    cellValuePerson != null && int.TryParse(cellValuePerson.ToString(), out int selectedPersonID))
                {
                    UserID = selectedUserID;
                    PersonID = selectedPersonID;


                }
                else
                {
                    MessageBox.Show("You need to select a valid person and user ID.");
                }
            }
        }


        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmUserCard frmUserCard = new frmUserCard(UserID, PersonID);
            frmUserCard.ShowDialog();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete User With ID " + UserID + " ?!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsUser.Delete(UserID))
                {

                    MessageBox.Show("User With UserID " + UserID + " Is Deleted Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("User With UserID " + UserID + " Was Not Deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvListUsers.DataSource = clsUser.GetAllUsers();
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
            dgvListUsers.DataSource = clsUser.GetAllUsers();

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser(UserID);
            frmAddUpdateUser.ShowDialog();
            dgvListUsers.DataSource = clsUser.GetAllUsers();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(UserID);
            frmChangePassword.ShowDialog();
        }
    }
}
