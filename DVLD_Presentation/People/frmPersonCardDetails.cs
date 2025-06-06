using System;
using System.Windows.Forms;

namespace DVLD_Presentation.People
{
    public partial class frmPersonCardDetails : Form
    {
        private int _PersonID;
        public frmPersonCardDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPersonCardDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonData(_PersonID);
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
