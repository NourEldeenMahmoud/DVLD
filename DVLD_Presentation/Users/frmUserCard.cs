using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Users
{
    public partial class frmUserCard : Form
    {
        int _UserID;
        int _PersonID;
        public frmUserCard(int UserID, int PersonID)
        {
            InitializeComponent();
            _UserID = UserID;
            _PersonID = PersonID;
        }


        private void frmUserCard_Load(object sender, EventArgs e)
        {

            ctrlUserCard1.LoadData(_UserID, _PersonID);

        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
