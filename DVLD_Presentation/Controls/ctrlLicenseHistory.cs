using DVLD_Business;
using DVLD_Presentation.InternationalLicense;
using DVLD_Presentation.License;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlLicenseHistory : UserControl
    {
        private DataTable dtAllLicenses;
        private DataTable dtIntAllLicenses;
        private int _LicenseID;
        private int _IntLicenseID;
        public ctrlLicenseHistory()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        public void LoadLiceseHistory(int DriverID)
        {
            dtAllLicenses = clsLicense.GetLicenseHistory(DriverID);
            dgvLocalLicense.DataSource = dtAllLicenses;
            lblNumberOfRecords.Text = dgvLocalLicense.Rows.Count.ToString();
            dtIntAllLicenses= clsInternationalLicense.GetIntLicenseHistory(DriverID);
            dgvIntLicense.DataSource = dtIntAllLicenses;
            lblNumberOfRecords.Text = dgvLocalLicense.Rows.Count.ToString();

            
        }
        private void ctrlLicenseHistory_Load(object sender, EventArgs e)
        {

        }

        private void tpInternational_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void dgvLocalLicense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvLocalLicense.Rows[e.RowIndex].Cells["LicenseID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _LicenseID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void dgvLocalLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvLocalLicense.Rows[e.RowIndex].Cells["LicenseID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _LicenseID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void dgvLocalLicense_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvLocalLicense.Rows[e.RowIndex].Cells["LicenseID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _LicenseID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void dgvIntLicense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvIntLicense.Rows[e.RowIndex].Cells["Int.License ID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _IntLicenseID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void dgvIntLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvIntLicense.Rows[e.RowIndex].Cells["Int.License ID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _IntLicenseID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void dgvIntLicense_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValue = dgvIntLicense.Rows[e.RowIndex].Cells["Int.License ID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int selectedID))
                {
                    _IntLicenseID = selectedID;
                }
                else
                {
                    MessageBox.Show(" You Need To Select The Person whom you want to show");
                    return;
                }
            }
        }

        private void showIntLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowIntLicenseInfo frmShowIntLicenseInfo = new frmShowIntLicenseInfo(_IntLicenseID);
            frmShowIntLicenseInfo.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_LicenseID);
            frmShowLicense.ShowDialog();
        }
    }
}
