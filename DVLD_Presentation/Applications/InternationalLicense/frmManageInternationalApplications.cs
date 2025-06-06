using DVLD_Business;
using DVLD_Presentation.License;
using DVLD_Presentation.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.InternationalLicense
{
    public partial class frmManageInternationalApplications : Form
    {
        DataTable dtAllIntLicenses=clsInternationalLicense.GetAllInternationalLicenses();
        private int _DriverID;
        private int _IntLicenseID;

        public frmManageInternationalApplications()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLDL_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frmAddInternationalLicense = new frmAddInternationalLicense();
            frmAddInternationalLicense.ShowDialog();
        }

        private void frmManageInternationalApplications_Load(object sender, EventArgs e)
        {
            dgvIntLicenses.DataSource = dtAllIntLicenses;
        }

        private void dgvIntLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                object DriverIDcell = dgvIntLicenses.Rows[e.RowIndex].Cells["DriverID"].Value;
                object Licensecell = dgvIntLicenses.Rows[e.RowIndex].Cells["Int.License ID"].Value;
                if ((DriverIDcell != null && int.TryParse(DriverIDcell.ToString(), out int DriverID))&& (Licensecell != null && int.TryParse(Licensecell.ToString(), out int IntLicenseID)))
                {
                    _DriverID = DriverID;
                    _IntLicenseID = IntLicenseID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Application wich you want to show");
                    return;
                }
              
            }

        }

        private void dgvIntLicenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                object DriverIDcell = dgvIntLicenses.Rows[e.RowIndex].Cells["DriverID"].Value;
                object Licensecell = dgvIntLicenses.Rows[e.RowIndex].Cells["Int.License ID"].Value;
                if ((DriverIDcell != null && int.TryParse(DriverIDcell.ToString(), out int DriverID)) && (Licensecell != null && int.TryParse(Licensecell.ToString(), out int IntLicenseID)))
                {
                    _DriverID = DriverID;
                    _IntLicenseID = IntLicenseID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Application wich you want to show");
                    return;
                }

            }
        }

        private void dgvIntLicenses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                object DriverIDcell = dgvIntLicenses.Rows[e.RowIndex].Cells["DriverID"].Value;
                object Licensecell = dgvIntLicenses.Rows[e.RowIndex].Cells["Int.License ID"].Value;
                if ((DriverIDcell != null && int.TryParse(DriverIDcell.ToString(), out int DriverID)) && (Licensecell != null && int.TryParse(Licensecell.ToString(), out int IntLicenseID)))
                {
                    _DriverID = DriverID;
                    _IntLicenseID = IntLicenseID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Application wich you want to show");
                    return;
                }

            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.Find(_DriverID);

            frmPersonCardDetails frmPersonCardDetails = new frmPersonCardDetails(Driver.PersonID);
            frmPersonCardDetails.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowIntLicenseInfo frmShowIntLicenseInfo = new frmShowIntLicenseInfo(_IntLicenseID);
            frmShowIntLicenseInfo.ShowDialog();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory frmShowLicenseHistory = new frmShowLicenseHistory(_DriverID);
            frmShowLicenseHistory.ShowDialog();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selected = cbFilterBy.SelectedItem.ToString();
            switch (Selected)
            {
                case "None":
                    dgvIntLicenses.DataSource = dtAllIntLicenses; // no order 
                    break;
                case "Int.License ID":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["Int.License ID"], ListSortDirection.Ascending);
                    break;
                case "ApplicationID":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["ApplicationID"], ListSortDirection.Ascending);
                    break;
                case "DriverID":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["DriverID"], ListSortDirection.Ascending);
                    break;
                case "L.License ID":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["L.License ID"], ListSortDirection.Ascending);
                    break;
                case "IssueDate":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["IssueDate"], ListSortDirection.Ascending);
                    break;
                case "ExpirationDate":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["ExpirationDate"], ListSortDirection.Ascending);
                    break;
                case "IsActive":
                    txtSearch.Visible = true;
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["IsActive"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Default !!!!!!!!!!!!!");
                    dgvIntLicenses.Sort(dgvIntLicenses.Columns["Int.License ID"], ListSortDirection.Ascending);
                    break;

            }
            dgvIntLicenses.Refresh();
        }
    }
}
