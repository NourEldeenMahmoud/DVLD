using DVLD_Business;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmAddUpdateUser : Form
    {
        int _UserID = -1;
        clsUser _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }


        public void _UpperHeader()
        {


        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Segoe UI", 12, FontStyle.Bold);
            Brush textBrush = Brushes.Black;

            // الحصول على النص
            string tabText = tabControl1.TabPages[e.Index].Text;

            // ضبط المحاذاة
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;

            // ضبط حجم التاب وتوسيعه
            Rectangle tabBounds = e.Bounds;
            tabBounds.Inflate(-2, -2); // تصغير الحدود قليلًا

            // مسح التاب القديم لمنع التراكب
            g.FillRectangle(new SolidBrush(tabControl1.BackColor), e.Bounds);

            // رسم النص داخل التاب
            g.DrawString(tabText, font, textBrush, tabBounds, stringFlags);

        }

        private void _FillUser()
        {


            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;
        }
        private void _LoadUserData()
        {

            lblUserIDValue.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;

        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _UpperHeader();
            if (_UserID == -1)
            {
                _User = new clsUser();
                _User.Mode = clsUser.enMode.AddNew;

            }
            else
            {
                _User = clsUser.Find(_UserID);
                _User.Mode = clsUser.enMode.Update;
                _LoadUserData();
                ctrlPersonCardWithFilter1.LoadPerson(_User.PersonID);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "UserName Is Required !!");
                e.Cancel = true;
                txtUserName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "UserName Is Required !!");
                e.Cancel = true;
                txtPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Password Is Matched !!");
                e.Cancel = true;
                txtConfirmPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillUser();
            if (_User.Save())
            {
                MessageBox.Show("Person Added Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserIDValue.Text = _User.UserID.ToString();
            }
            else
            {
                MessageBox.Show("Person Was not Added Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (_User.Mode == clsUser.enMode.AddNew)
            {
                if (ctrlPersonCardWithFilter1.PersonData == null)
                {
                    MessageBox.Show("You Need To Select A Person ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (clsUser.IsUserExistByPersonID(ctrlPersonCardWithFilter1.PersonData.PersonID))
                {

                    MessageBox.Show("Perosn Is Already Linked ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    _User.PersonID = ctrlPersonCardWithFilter1.PersonData.PersonID;
                    tabControl1.SelectedTab = tabControl1.TabPages[1];

                }
            }


        }




        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (_User.Mode == clsUser.enMode.AddNew)
            {
                if (e.TabPage == tpUserInfo)
                {
                    if (ctrlPersonCardWithFilter1.PersonData == null)
                    {
                        MessageBox.Show("You Need To Select A Person ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    else if (clsUser.IsUserExistByPersonID(ctrlPersonCardWithFilter1.PersonData.PersonID))
                    {
                        MessageBox.Show("Person Is Already Linked ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;

                    }
                }
            }

        }

        private void tpUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
