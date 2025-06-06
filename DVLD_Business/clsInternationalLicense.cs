using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationData { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverData { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public clsLicense LicenseData { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            CreatedByUserID = -1;
            IsActive = false;
            ApplicationData = new clsApplication();
            DriverData = new clsDriver();
            LicenseData = new clsLicense();
            Mode = enMode.AddNew;
        }

        public clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate,  bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.ApplicationData = clsApplication.Find(ApplicationID);
            this.DriverData = clsDriver.Find(DriverID);
            this.LicenseData = clsLicense.Find(IssuedUsingLocalLicenseID);
            Mode = enMode.AddNew;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, 
                this.IsActive,  this.CreatedByUserID);
            return this.InternationalLicenseID != -1;
        }
        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, 
                this.IsActive, this.CreatedByUserID);

        }
        public static clsInternationalLicense Find(int InternationalLicenseID)
        {

            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            int CreatedByUserID = -1;
            bool IsActive = false;



            bool IsFound = clsInternationalLicenseData.GetInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
              ref IsActive, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate,
             ExpirationDate,  IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int InternationalLicenseID)
        {
            return clsInternationalLicenseData.DeleteInternationalLicense(InternationalLicenseID);
        }
        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }
        public static DataTable GetIntLicenseHistory(int DriverID)
        {
            return clsInternationalLicenseData.GetIntLicenseHistory(DriverID);
        }

        public static bool IsInternationalLicenseExist(int DriverID)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExist(DriverID);
        }
       
        public static int GetInternationalLicenseIDByApplicationID(int ApplicationID)
        {
            return clsInternationalLicenseData.GetInternationalLicenseIDByApplicationID(ApplicationID);
        }
        public bool Save()
        {
            if (!ApplicationData.Save())
            {
                return false;
            }
            ApplicationID = ApplicationData.ApplicationID;
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInternationalLicense();
            }
            return false;

        }
    }
}

