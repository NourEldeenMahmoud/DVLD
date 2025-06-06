using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
namespace DVLD_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            UserID = -1;
            PersonID=-1;
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNew;
        }

        public clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.AddNew;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID,this.PersonID, this.UserName, this.Password, this.IsActive);

        }
        public static clsUser Find(int UserID)
        {
          
            int PersonID = -1;
            string UserName = "";
            string Password = "";
            bool IsActive = false;


            bool IsFound = clsUserData.GetUserDataByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);
            if (IsFound)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }
        public static clsUser Find(string UserName)
        {

            int PersonID = -1;
            int UserID = -1;
            string Password = "";
            bool IsActive = false;


            bool IsFound = clsUserData.GetUserDataByUserName(UserName, ref PersonID, ref UserID, ref Password, ref IsActive);
            if (IsFound)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static bool IsUserExistByUserID(int UserID)
        {
            return clsUserData.IsUserExistByUserID(UserID);
        }
        public static bool IsUserExistByPersonID(int UserID)
        {
            return clsUserData.IsUserExistByPersonID(UserID);
        }

        public static string GetUserNameByID(int UserID)
        {
            clsUser User = clsUser.Find(UserID);
            return User.UserName;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;

        }

    }
}
