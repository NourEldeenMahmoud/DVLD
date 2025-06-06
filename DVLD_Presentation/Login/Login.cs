using DVLD_Business;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DVLD_Presentation.Users
{
    public partial class Login : Form
    {
        //string FilePath = "D:\\programming course\\prject sources\\LoginData\\LoginData.txt";
        string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLDRememberUser";


        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {

            guna2CustomGradientPanel1.FillColor = Color.FromArgb(108, 92, 231); // اللون العلوي (غامق)
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(136, 84, 208); // لون أفتح قليلاً
            LoadLoginData();
        }
        private bool LoadLoginData()
        {

            try
            {
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\DVLDRememberUser"))
                {
                    if (Key == null)
                    {
                        return false;
                    }
                    string UserNameValue = Key.GetValue("UserName",  null) as string;
                    string PasswordValue = Key.GetValue("Password",  null) as string;
                    txtUserName.Text = UserNameValue;
                    txtPassword.Text = PasswordValue;
                    chkRemember.Checked = true; 
                }


            }
            catch (Exception)
            {
                return false;
            }
            return true;


        }
        private bool RememberMeCheck()
        {
            if (!chkRemember.Checked)
            {
                try
                {
                    using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\DVLDRememberUser",true))
                    {
                        if (Key == null)
                        {
                            return false;
                        }
                        if (Key.GetValue("UserName") != null)
                            Key.DeleteValue("UserName");

                        if (Key.GetValue("Password") != null)
                            Key.DeleteValue("Password");
                        chkRemember.Checked = false;
                    }

                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }

            string UserNameValue = txtUserName.Text.Trim();
            string PasswordValue = txtPassword.Text.Trim();

            try
            {
                using (RegistryKey Key =  Registry.CurrentUser.CreateSubKey(@"SOFTWARE\DVLDRememberUser"))
                {
                    if (Key == null) 
                    {
                        return false;
                    }
                    Key.SetValue( "UserName", UserNameValue, RegistryValueKind.String);
                    Key.SetValue( "Password", PasswordValue, RegistryValueKind.String);
                }
               

            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            RememberMeCheck();
            
            clsUser User = clsUser.Find(txtUserName.Text); ;
            if (User != null)
            {
                if (User.UserName != txtUserName.Text || User.Password != txtPassword.Text)
                {
                    MessageBox.Show("Wrong Credentials !! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (User.IsActive == false)
                {
                    MessageBox.Show("Your Account Is Deacitvated !! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    clsGlobalSettings.LoggedInUser = User;
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Wrong Credentials !! ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            chkRemember.Checked = false;
        }
    }
}
