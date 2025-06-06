using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicense
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationData { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverData { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public string Notes { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public short IssueReason { get; set; }
        public int CreatedByUserID { get; set; }


        public clsLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            PaidFees = -1;
            Notes = "";
            CreatedByUserID = -1;
            IsActive = false;
            IssueReason = -1;
            ApplicationData = new clsApplication();
            DriverData = new clsDriver();
            Mode = enMode.AddNew;
        }

        public clsLicense(int LicenseID,int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, short IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.ApplicationData = clsApplication.Find(ApplicationID);
            this.DriverData = clsDriver.Find(DriverID);
            Mode = enMode.AddNew;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate,this.Notes,this.PaidFees,
                this.IsActive, this.IssueReason, this.CreatedByUserID);
            return this.LicenseID != -1;
        }
        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, this.IssueReason, this.CreatedByUserID);

        }
        public static clsLicense Find(int LicenseID)
        {
           
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            decimal PaidFees = -1;
            string Notes = "";
            int CreatedByUserID = -1;
            bool IsActive = false;
            short IssueReason = -1;



            bool IsFound = clsLicenseData.GetLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate,
             ref Notes,ref PaidFees, ref IsActive,ref IssueReason, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsLicense( LicenseID,  ApplicationID,  DriverID,  LicenseClass,  IssueDate,
             ExpirationDate,  Notes,  PaidFees,  IsActive,  IssueReason,  CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int LicenseID)
        {
            return clsLicenseData.DeleteLicense(LicenseID);
        }
        public static DataTable GetAllLicenses()
        {
            return clsLicenseData.GetAllLicenses();
        }
        public static bool IsLicenseExist(int ApplicantPersonID)
        {
            return clsLicenseData.IsLicenseExist(ApplicantPersonID);
        }
        public static DataTable GetLicenseHistory(int DriverID)
        {
            return clsLicenseData.GetLicenseHistory(DriverID);
        }
        public static int GetLicenseIDByApplicationID(int ApplicationID)
        { 
            return clsLicenseData.GetLicenseIDByApplicationID(ApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLicense();
            }
            return false;

        }
    }
}

