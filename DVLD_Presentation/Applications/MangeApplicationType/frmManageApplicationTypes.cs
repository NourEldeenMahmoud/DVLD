using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Presentation.MangeApplicationType
{
    public partial class frmManageApplicationTypes : Form
    {
        private int _ApplicationID;
        DataTable dtApplicationTypes = clsManageApplicationTypes.GetAllApplicationTypes();
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            dgvListAppTypes.DataSource = dtApplicationTypes;
            dgvListAppTypes.Columns["ApplicationTypeID"].HeaderText = "ID";
            dgvListAppTypes.Columns["ApplicationTypeID"].Width = 50;
            lblNumberOfRecords.Text = dtApplicationTypes.Rows.Count.ToString();
        }






        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frmAppType = new frmUpdateApplicationType(_ApplicationID);
            frmAppType.ShowDialog();
        }

        private void dgvListAppTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValueUser = dgvListAppTypes.Rows[e.RowIndex].Cells["ApplicationTypeID"].Value;

                if (cellValueUser != null && int.TryParse(cellValueUser.ToString(), out int selectedUserID))
                {
                    _ApplicationID = selectedUserID;
                }
                else
                {
                    MessageBox.Show("You need to select a valid person and user ID.");
                }
            }
        }

        private void dgvListAppTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValueUser = dgvListAppTypes.Rows[e.RowIndex].Cells["ApplicationTypeID"].Value;

                if (cellValueUser != null && int.TryParse(cellValueUser.ToString(), out int selectedUserID))
                {
                    _ApplicationID = selectedUserID;
                }
                else
                {
                    MessageBox.Show("You need to select a valid person and user ID.");
                }
            }
        }
    }
}
