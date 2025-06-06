using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Presentation.MangeTestsTypes
{
    public partial class frmManageTestTypes : Form
    {
        DataTable dtTestTypes = clsManageTestTypes.GetAllTestTypes();
        private int _TestTypeID;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {

            dgvListTestTypes.DataSource = dtTestTypes;
            lblNumberOfRecords.Text = dtTestTypes.Rows.Count.ToString();
            dgvListTestTypes.Columns[0].Width = 50;
            dgvListTestTypes.Columns[1].Width = 120;
            dgvListTestTypes.Columns[2].Width = 200;
            dgvListTestTypes.Columns[3].Width = 120;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frmUpdateTestTypes = new frmUpdateTestTypes(_TestTypeID);
            frmUpdateTestTypes.ShowDialog();
        }

        private void dgvListTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValueUser = dgvListTestTypes.Rows[e.RowIndex].Cells["TestTypeID"].Value;

                if (cellValueUser != null && int.TryParse(cellValueUser.ToString(), out int selectedUserID))
                {
                    _TestTypeID = selectedUserID;
                }
                else
                {
                    MessageBox.Show("You need to select a valid person and user ID.");
                }
            }
        }

        private void dgvListTestTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object cellValueUser = dgvListTestTypes.Rows[e.RowIndex].Cells["TestTypeID"].Value;

                if (cellValueUser != null && int.TryParse(cellValueUser.ToString(), out int selectedUserID))
                {
                    _TestTypeID = selectedUserID;
                }
                else
                {
                    MessageBox.Show("You need to select a valid person and user ID.");
                }
            }
        }
    }
}
