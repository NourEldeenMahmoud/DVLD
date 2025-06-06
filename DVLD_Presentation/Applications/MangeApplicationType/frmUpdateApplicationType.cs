using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.MangeApplicationType
{
    public partial class frmUpdateApplicationType : Form
    {
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private int _ApplicationTypeID;
        private clsManageApplicationTypes _AppType;


        private void _LoadAppType()
        {
            lblIDValue.Text = _AppType.ApplicationTypeID.ToString();
            txtTitle.Text = _AppType.ApplicationTypeTitle;
            txtFees.Text = _AppType.ApplicationFees.ToString();
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _AppType = clsManageApplicationTypes.Find(_ApplicationTypeID);
            _LoadAppType();

        }
        private void _FillAppType()
        {
            _AppType.ApplicationTypeTitle = txtTitle.Text;
            _AppType.ApplicationFees = Convert.ToDecimal(txtFees.Text);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillAppType();
            if (_AppType.Save())
            {
                MessageBox.Show(" Application Type  Updated Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Application Type Was not Updated Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
