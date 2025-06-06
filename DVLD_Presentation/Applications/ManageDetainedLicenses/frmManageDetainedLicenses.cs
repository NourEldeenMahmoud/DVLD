using DVLD_Business;
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

namespace DVLD_Presentation
{
    public partial class frmManageDetainedLicenses : Form
    {
       
        private int _LicenseID=-1;
        private clsLicense _License;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            dgvDetainedLicenses.DataSource= clsDetainedLicense.GetAllDetainedLicenses();
            lblNumberOfRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense();
            frmDetainLicense.ShowDialog();
            dgvDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense();
            frmReleaseDetainedLicense.ShowDialog();
            dgvDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetainedLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object LicenseIDcell = dgvDetainedLicenses.Rows[e.RowIndex].Cells["LicenseID"].Value;
                object DetainIDcell = dgvDetainedLicenses.Rows[e.RowIndex].Cells["DetainID"].Value;

                if (LicenseIDcell != null && int.TryParse(LicenseIDcell.ToString(), out int LicenseID))
                {
                    _LicenseID = LicenseID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
               
            }
        }

        private void dgvDetainedLicenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object LicenseIDcell = dgvDetainedLicenses.Rows[e.RowIndex].Cells["LicenseID"].Value;
                object DetainIDcell = dgvDetainedLicenses.Rows[e.RowIndex].Cells["DetainID"].Value;

                if (LicenseIDcell != null && int.TryParse(LicenseIDcell.ToString(), out int LicenseID))
                {
                    _LicenseID = LicenseID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
              
            }
        }

        private void dgvDetainedLicenses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object LicenseIDcell = dgvDetainedLicenses.Rows[e.RowIndex].Cells["LicenseID"].Value;
                object DetainIDcell = dgvDetainedLicenses.Rows[e.RowIndex].Cells["DetainID"].Value;

                if (LicenseIDcell != null && int.TryParse(LicenseIDcell.ToString(), out int LicenseID))
                {
                    _LicenseID = LicenseID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
               
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _License = clsLicense.Find(_LicenseID);
            frmPersonCardDetails frmPersonCardDetails = new frmPersonCardDetails(_License.DriverData.PersonID);
            frmPersonCardDetails.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetainLicense = new frmDetainLicense(_LicenseID);
            frmDetainLicense.ShowDialog();
            dgvDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
        }

        private void relaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense(_LicenseID);
            frmReleaseDetainedLicense.ShowDialog();
            dgvDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainedLicenses();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            string Selected = cbFilterBy.SelectedItem.ToString();
            switch (Selected)
            {
                case "None":
                    dgvDetainedLicenses.DataSource = clsDetainedLicense.GetAllDetainedLicenses(); 

                    break;
                case "DetainID":
                    dgvDetainedLicenses.Sort(dgvDetainedLicenses.Columns["DetainID"], ListSortDirection.Ascending);
                    break;
                case "IsReleased":
                    dgvDetainedLicenses.Sort(dgvDetainedLicenses.Columns["IsReleased"], ListSortDirection.Ascending);
                    break;
                case "NationalNo":
                    dgvDetainedLicenses.Sort(dgvDetainedLicenses.Columns["NationalNo"], ListSortDirection.Ascending);
                    break;
                case "FullName":
                    dgvDetainedLicenses.Sort(dgvDetainedLicenses.Columns["FullName"], ListSortDirection.Ascending);
                    break;
                case "ReleaseApplicationID":
                    dgvDetainedLicenses.Sort(dgvDetainedLicenses.Columns["ReleaseApplicationID"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Default !!!!!!!!!!!!!");
                    dgvDetainedLicenses.Sort(dgvDetainedLicenses.Columns["DetainID"], ListSortDirection.Ascending);
                    break;

            }
            dgvDetainedLicenses.Refresh();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
