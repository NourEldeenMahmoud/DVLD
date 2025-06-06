using DVLD_Business;
using DVLD_Presentation.People;
using System;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        private int _PersonID;
        private string _NationaNo;
        public clsPerson PersonData
        {
            get
            {
                if (clsPerson.Find(_PersonID) != null)
                {

                    return clsPerson.Find(_PersonID);
                }
                else
                {
                    return clsPerson.Find(_NationaNo);
                }

            }
        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }


        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0)
            {
                int.TryParse(txtSearch.Text, out _PersonID);
                ctrlPersonCard1.LoadPersonData(_PersonID);
            }
            else
            {
                _NationaNo = txtSearch.Text;
                ctrlPersonCard1.LoadPersonData(_NationaNo);

            }


        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem == null)
            {
                e.Handled = true; // إلغاء الإدخال
            }
            if (cbFilterBy.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // إلغاء الإدخال
                }
            }

        }
        public void LoadPerson(int PersonID)
        {
            cbFilterBy.Enabled = false;
            lblFindBy.Enabled = false;
            txtSearch.Enabled = false;
            btnAddPerson.Enabled = false;
            btnFindPerson.Enabled = false;
            ctrlPersonCard1.LoadPersonData(PersonID);
        }
        public void LoadPerson(string NationalNo)
        {
            cbFilterBy.Enabled = false;
            lblFindBy.Enabled = false;
            txtSearch.Enabled = false;
            btnAddPerson.Enabled = false;
            btnFindPerson.Enabled = false;
            ctrlPersonCard1.LoadPersonData(NationalNo);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdatePerson1 = new frmAddUpdatePerson();
            frmAddUpdatePerson1.DataBack += _LoadPerson;
            frmAddUpdatePerson1.ShowDialog();
        }

        private void _LoadPerson(string NationalNo)
        {

            ctrlPersonCard1.LoadPersonData(NationalNo);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
