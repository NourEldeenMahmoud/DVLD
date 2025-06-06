using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmChangePassword : Form
    {
        int _UserID = -1;
        clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        public frmChangePassword()
        {
            InitializeComponent();

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_UserID == -1)
            {
                _User = clsUser.Find(clsGlobalSettings.LoggedInUser.UserID);
                ctrlUserCard1.LoadData(clsGlobalSettings.LoggedInUser.UserID, clsGlobalSettings.LoggedInUser.PersonID);
            }
            else
            {
                _User = clsUser.Find(_UserID);
                ctrlUserCard1.LoadData(_User.UserID, _User.PersonID);
            }

        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Should Match");
                e.Cancel = true;
                txtConfirmPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_User.Password == txtCurrentPassword.Text)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Change Your Password ? ", "Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _User.Mode = clsUser.enMode.Update;
                    _User.Password = txtNewPassword.Text;
                    if (_User.Save())
                    {
                        MessageBox.Show("Your Password Is Changed Succefully ", "Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Your Password Was Not Changed  ", "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Wrong Password  ", "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
