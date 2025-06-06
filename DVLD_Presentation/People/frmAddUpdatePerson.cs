using DVLD_Business;
using DVLD_Presentation.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVLD_Presentation.People
{

    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEvent(string NationalNo);
        public event DataBackEvent DataBack;
        public string ImageTransferLocation;
        int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;//for update

        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();//for add

        }
        public void _UpperHeader()
        {

         
            if (_PersonID == 0)
            {
                lblTitleLabel.Text = "Add New Person";
            }
            else
            {
                lblTitleLabel.Text = "Edit Person";
            }

        }
        private void _FillCountries()
        {

            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }

        }
        private void _FillPerson()
        {
            _Person.NationalNo = txtNatoinalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            if (rbMale.Checked)
            {
                _Person.Gendar = 0;
            }
            else
            {
                _Person.Gendar = 1;
            }
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Address = rtxtAddress.Text;
            _Person.NationalityCountryID = clsCountry.GetCountryIDByName(cbCountries.SelectedItem.ToString());

            if (pbPersonImage.ImageLocation != null)//image does exist
            {
                _MovePersonImage();
                _Person.ImagePath = ImageTransferLocation;
            }
            else
            {
                _Person.ImagePath = "";
            }


        }
        private void _LoadPerson()
        {

            lblPersonIDValue.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNatoinalNo.Text = _Person.NationalNo;
            if (_Person.Gendar == 0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtEmail.Text = _Person.Email;
            rtxtAddress.Text = _Person.Address;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            cbCountries.SelectedIndex = _Person.NationalityCountryID - 1;
            txtPhone.Text = _Person.Phone;
            if (System.IO.File.Exists(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                byte[] imageData = File.ReadAllBytes(_Person.ImagePath); // قراءة الصورة كمصفوفة بايت
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pbPersonImage.Image = Image.FromStream(ms); // تحميل الصورة من الذاكرة
                    pbPersonImage.Tag = _Person.ImagePath;
                    llblRemove.Visible = true;
                }
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
        private void _MovePersonImage()
        {

            string Extension = Path.GetExtension(pbPersonImage.ImageLocation);
            string ImageName = Guid.NewGuid().ToString() + Extension;
            ImageTransferLocation = Path.Combine(@"D:\programming course\prject sources\Person Image", ImageName);

            File.Copy(pbPersonImage.ImageLocation, ImageTransferLocation);

        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {

            _UpperHeader();
            _FillCountries();
            cbCountries.StartIndex = 0;
            if (_PersonID == -1)
            {
                _Person = new clsPerson();
                _Person.Mode = clsPerson.enMode.AddNew;
            }
            else
            {
                _Person = clsPerson.Find(_PersonID);
                _Person.Mode = clsPerson.enMode.Update;
                _LoadPerson();
            }

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked == true)
            {
                pbPersonImage.Image = Resources.woman;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _FillPerson();

            if (_Person.Save())
            {
                MessageBox.Show("Person Saved Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(_Person.NationalNo);
                lblPersonIDValue.Text = _Person.PersonID.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Person Was not Saved Succefully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
            {
                pbPersonImage.Image = Resources.man;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Select an Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {



                if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting old image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string selectedFilePath = openFileDialog1.FileName;
                using (var stream = new MemoryStream(File.ReadAllBytes(selectedFilePath)))
                {
                    pbPersonImage.Image = Image.FromStream(stream); // تحميل الصورة إلى PictureBox
                }

                pbPersonImage.ImageLocation = selectedFilePath;
                _Person.ImagePath = selectedFilePath; // تحديث المسار الجديد
                pbPersonImage.Tag = selectedFilePath;
                llblRemove.Visible = true;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First Name Is Required !!");
                e.Cancel = true;
                txtFirstName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }

        }

        private void cbCountries_Validating(object sender, CancelEventArgs e)
        {
            if (cbCountries.SelectedItem == null)
            {
                errorProvider1.SetError(cbCountries, "Country Is Required !!");
                e.Cancel = true;
                cbCountries.Focus();
            }
            else
            {
                errorProvider1.SetError(cbCountries, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last Name Is Required !!");
                e.Cancel = true;
                txtLastName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
            }

        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                errorProvider1.SetError(txtSecondName, " Second Name Is Required !!");
                e.Cancel = true;
                txtSecondName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtSecondName, "");
            }
        }

        private void txtNatoinalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNatoinalNo.Text))
            {
                errorProvider1.SetError(txtNatoinalNo, " NatoinalNo  Is Required !!");
                e.Cancel = true;
                txtNatoinalNo.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNatoinalNo, "");
            }


            if (txtNatoinalNo.Text == _Person.NationalNo)
            {
                errorProvider1.SetError(txtNatoinalNo, "");
            }
            else if (clsPerson.IsPersonExist(txtNatoinalNo.Text))
            {
                errorProvider1.SetError(txtNatoinalNo, " NatoinalNo  Is Used For Another Account !!");
                e.Cancel = true;
                txtNatoinalNo.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNatoinalNo, "");
            }
        }

        private void dtpDateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dtpDateOfBirth.ToString()))
            {
                errorProvider1.SetError(dtpDateOfBirth, " DateOfBirth  Is Required !!");
                e.Cancel = true;
                dtpDateOfBirth.Focus();
            }
            else
            {
                errorProvider1.SetError(dtpDateOfBirth, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text.ToString()))
            {
                errorProvider1.SetError(txtPhone, " Phone  Is Required !!");
                e.Cancel = true;
                txtPhone.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void rtxtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtAddress.Text.ToString()))
            {
                errorProvider1.SetError(rtxtAddress, " Address  Is Required !!");
                e.Cancel = true;
                rtxtAddress.Focus();
            }
            else
            {
                errorProvider1.SetError(rtxtAddress, "");
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string EmailFormat = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "");
            }
            else if (!Regex.IsMatch(txtEmail.Text, EmailFormat))
            {
                errorProvider1.SetError(txtEmail, "Email Format is Incorrect !!");
                e.Cancel = true;
                txtEmail.Focus();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;
            if (rbMale.Checked == true)
            {
                pbPersonImage.Image = Resources.man;
            }
            else
            {
                pbPersonImage.Image = Resources.woman;
            }
            _Person.ImagePath = "";

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
