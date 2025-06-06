using DVLD_Business;
using DVLD_Presentation.People;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_Presentation.Controls
{
    public partial class ctrlPersonCard : UserControl
    {

        public int _PersonID { get; }

        private clsPerson _Person;

        public ctrlPersonCard()
        {
            InitializeComponent();

        }
        public void LoadPersonData(int _PersonID)
        {

            _Person = clsPerson.Find(_PersonID);
            if (_Person != null)
            {
                _FillCard();
            }
            else
            {
                MessageBox.Show("Inable To Find Person With Person ID " + _PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetCard();
            }
        }
        public void LoadPersonData(string NationalNo)
        {

            _Person = clsPerson.Find(NationalNo);
            if (_Person != null)
            {
                _FillCard();
            }
            else
            {
                MessageBox.Show("Inable To Find Person With NationalNo " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetCard();
            }
        }
        private void _FillCard()
        {


            lblPersonIDValue.Text = _Person.PersonID.ToString();
            lblNameValue.Text = _Person.FullName();
            lblNationalNoValue.Text = _Person.NationalNo;
            if (_Person.Gendar == 0)
            {
                lblGenderValue.Text = "Male";
                pbPersonImage.Image = Properties.Resources.man;
            }
            else
            {
                lblGenderValue.Text = "Female";
                pbPersonImage.Image = Properties.Resources.woman;
            }
            lblEmailValue.Text = _Person.Email;
            lblAddressValue.Text = _Person.Address;
            lblDateOfBirthValue.Text = _Person.DateOfBirth.ToString();
            lblCountryValue.Text = clsCountry.GetCountryNameByID(_Person.NationalityCountryID);
            lblPhoneValue.Text = _Person.Phone;
            if (System.IO.File.Exists(_Person.ImagePath))
            {
                Image img = Image.FromFile(_Person.ImagePath);  // تحميل الصورة
                pbPersonImage.Image = new Bitmap(img);  // إنشاء نسخة جديدة لتجنب قفل الملف
                img.Dispose();  // التخلص من الصورة الأصلية لتجنب استهلاك الموارد
            }
            else if (_Person.Gendar == 0)
            {
                pbPersonImage.Image = Properties.Resources.man;
            }
            else
            {
                pbPersonImage.Image = Properties.Resources.woman;
            }





        }
        private void _ResetCard()
        {
            lblPersonIDValue.Text = "[--??--]";
            lblNameValue.Text = "[--??--]";
            lblNationalNoValue.Text = "[--??--]";
            lblGenderValue.Text = "[--??--]";
            lblEmailValue.Text = "[--??--]";
            lblAddressValue.Text = "[--??--]";
            lblDateOfBirthValue.Text = "[--??--]";
            lblCountryValue.Text = "[--??--]";
            lblPhoneValue.Text = "[--??--]";
            pbPersonImage.Image = Properties.Resources.man;
        }

        private void llblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAddUpdatePerson frmUpdatePerson = new frmAddUpdatePerson(_Person.PersonID);
            frmUpdatePerson.ShowDialog();
        }

        private void gbPersonInformation_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
