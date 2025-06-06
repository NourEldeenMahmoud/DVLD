using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.MangeTestsTypes
{
    public partial class frmUpdateTestTypes : Form
    {
        private int _TestTypeID;
        private clsManageTestTypes _TestType;
        public frmUpdateTestTypes(int TestType)
        {
            InitializeComponent();
            _TestTypeID = TestType;
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            _TestType = clsManageTestTypes.Find(_TestTypeID);
            _LoadAppType();
        }
        private void _FillAppType()
        {
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            _TestType.TestFees = Convert.ToDecimal(txtFees.Text);
        }
        private void _LoadAppType()
        {
            lblIDValue.Text = _TestType.TestTypeID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestFees.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillAppType();
            if (_TestType.Save())
            {
                MessageBox.Show(" Test Type  Updated Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Test Type Was not Updated Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
