using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation.People
{
    public partial class frmListPeople : Form
    {
        DataTable dtAllPeople = clsPerson.GetAllPeople();
        int personID;
        public frmListPeople()
        {
            InitializeComponent();
        }
        public void Header()
        {




        }
        private void frmListPeople_Load(object sender, EventArgs e)
        {
            Header();
            cbFilterBy.SelectedIndex = 0;

            dgvListPeople.DataSource = dtAllPeople;
            dgvListPeople.Columns["ImagePath"].Visible = false;
            dgvListPeople.Columns["Address"].Visible = false;
            dgvListPeople.Columns["Gendor"].Visible = false;
            dgvListPeople.Columns["NationalityCountryID"].Visible = false;
            lblNumberOfRecords.Text = dtAllPeople.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            string Selected = cbFilterBy.SelectedItem.ToString();
            switch (Selected)
            {
                case "None":
                    dgvListPeople.DataSource = dtAllPeople; // no order

                    break;
                case "PersonID":
                    dgvListPeople.Sort(dgvListPeople.Columns["PersonID"], ListSortDirection.Ascending);
                    break;
                case "NationalNo":
                    dgvListPeople.Sort(dgvListPeople.Columns["NationalNo"], ListSortDirection.Ascending);
                    break;
                case "FirstName":
                    dgvListPeople.Sort(dgvListPeople.Columns["FirstName"], ListSortDirection.Ascending);
                    break;
                case "SecondName":
                    dgvListPeople.Sort(dgvListPeople.Columns["SecondName"], ListSortDirection.Ascending);
                    break;
                case "ThirdName":
                    dgvListPeople.Sort(dgvListPeople.Columns["ThirdName"], ListSortDirection.Ascending);
                    break;
                case "LastName":
                    dgvListPeople.Sort(dgvListPeople.Columns["LastName"], ListSortDirection.Ascending);
                    break;
                case "Gender":
                    dgvListPeople.Sort(dgvListPeople.Columns["Gendor"], ListSortDirection.Ascending);
                    break;
                case "DateOfBirth":
                    dgvListPeople.Sort(dgvListPeople.Columns["DateOfBirth"], ListSortDirection.Ascending);
                    break;
                case "Nationality":
                    dgvListPeople.Sort(dgvListPeople.Columns["Nationality"], ListSortDirection.Ascending);
                    break;
                case "Phone":
                    dgvListPeople.Sort(dgvListPeople.Columns["Phone"], ListSortDirection.Ascending);
                    break;
                case "Email":
                    dgvListPeople.Sort(dgvListPeople.Columns["Email"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Default !!!!!!!!!!!!!");
                    dgvListPeople.Sort(dgvListPeople.Columns["PersonID"], ListSortDirection.Ascending);
                    break;

            }
            dgvListPeople.Refresh();
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

                string filter = dtAllPeople.Columns[columnName].DataType == typeof(string) ? $"{columnName} LIKE '%{searchText}%'" : $"CONVERT({columnName}, 'System.String') LIKE '%{searchText}%'";

                dtAllPeople.DefaultView.RowFilter = filter;
            }
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAdd = new frmAddUpdatePerson();
            frmAdd.ShowDialog();
            dgvListPeople.DataSource = clsPerson.GetAllPeople();
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

        private void cmShowDetails_Click(object sender, EventArgs e)
        {
            if (personID <= 0)
            {
                MessageBox.Show(" You Need To Select The Person whom you want to show");
                return;
            }
            if (clsPerson.IsPersonExist(personID))
            {
                frmPersonCardDetails frmPersonCardDetails = new frmPersonCardDetails(personID);
                frmPersonCardDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error Showing " + personID + " Details ");
            }

        }

        private void dgvListPeople_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvListPeople.Rows[e.RowIndex].Cells["PersonID"].Value != null)
            {
                int.TryParse(dgvListPeople.Rows[e.RowIndex].Cells["PersonID"].Value.ToString(), out personID);
            }
        }

        private void cmAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson();
            frmAddPerson.ShowDialog();
            dgvListPeople.DataSource = clsPerson.GetAllPeople();
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete Person With ID " + personID + " ?!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsPerson.Delete(personID))
                {

                    MessageBox.Show("Person With PersonID " + personID + " Is Deleted Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Person With PersonID " + personID + " Was Not Deleted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvListPeople.DataSource = clsPerson.GetAllPeople();
            }



        }

        private void cmEdit_Click(object sender, EventArgs e)
        {

            frmAddUpdatePerson frmAddPerson = new frmAddUpdatePerson(personID);
            frmAddPerson.ShowDialog();
            dgvListPeople.DataSource = clsPerson.GetAllPeople();

        }

        private void dgvListPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                object cellValue = dgvListPeople.Rows[e.RowIndex].Cells["PersonID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    personID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void dgvListPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvListPeople.Rows[e.RowIndex].Cells["PersonID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    personID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }
    }
}
