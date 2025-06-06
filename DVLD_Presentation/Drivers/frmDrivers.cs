using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Presentation.License
{
    public partial class frmDrivers : Form
    {
        DataTable dtAllDrivers = clsDriver.GetAllDrivers();
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {

            dgvListDrivers.DataSource = dtAllDrivers;
            lblNumberOfRecords.Text = dtAllDrivers.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            string Selected = cbFilterBy.SelectedItem.ToString();
            switch (Selected)
            {
                case "None":
                    dgvListDrivers.DataSource = dgvListDrivers; // no order
                    break;
                case "DriverID":
                    dgvListDrivers.Sort(dgvListDrivers.Columns["DriverID"], ListSortDirection.Ascending);
                    break;
                case "PersonID":
                    dgvListDrivers.Sort(dgvListDrivers.Columns["PersonID"], ListSortDirection.Ascending);
                    break;
                case "NationalNo":
                    dgvListDrivers.Sort(dgvListDrivers.Columns["NationalNo"], ListSortDirection.Ascending);
                    break;
                case "FullName":
                    dgvListDrivers.Sort(dgvListDrivers.Columns["FullName"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Default !!!!!!!!!!!!!");
                    dgvListDrivers.Sort(dgvListDrivers.Columns["PersonID"], ListSortDirection.Ascending);
                    break;

            }
            dgvListDrivers.Refresh();
        }
    }
}
