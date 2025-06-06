using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlUserCard : UserControl
    {

        clsUser _User = new clsUser();

        public ctrlUserCard()
        {

            InitializeComponent();

        }



        public void LoadData(int UserID, int PersonID)
        {

            _User = clsUser.Find(UserID);
            if (_User != null)
            {
                _FillUserCard();
                ctrlPersonCard1.LoadPersonData(PersonID);
            }
            else
            {
                MessageBox.Show("Inable To Find User With UserID " + UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _FillUserCard()
        {
            lblUserIDValue.Text = _User.UserID.ToString();
            lblUserNameValue.Text = _User.UserName;
            if (_User.IsActive)
            {
                lblIsActiveValue.Text = "Yes";
            }
            else
            {
                lblIsActiveValue.Text = "No";
            }

        }

        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
