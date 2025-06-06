using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public clsLicense LicenseData { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID  { get; set; }
        public  int ReleaseApplicationID { get; set; }
        public clsApplication ApplicationData { get; set; }

 


        public clsDetainedLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased =false;
            ReleaseDate = DateTime.Now;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
            LicenseData = new clsLicense() ;
            ApplicationData = new clsApplication() ;
            Mode = enMode.AddNew;
        }

        public clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.LicenseData = clsLicense.Find(LicenseID);
            if (ReleaseApplicationID==-1)
            {
                ApplicationData = new clsApplication();
            }
            else
            {
                this.ApplicationData = clsApplication.Find(ReleaseApplicationID);
            }
            
            Mode = enMode.AddNew;
        }

        private bool _AddNewDetainedLicense()
        {
            this.LicenseID = clsDetainedLicenseData.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID,
                this.ReleaseApplicationID);
            return this.LicenseID != -1;
        }
        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(this.DetainID,this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID,
                this.ReleaseApplicationID);

        }
        public static clsDetainedLicense Find(int LicenseID)
        {

            
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;
       


            bool IsFound = clsDetainedLicenseData.GetDetainedLicenseByID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased,
             ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);
            if (IsFound)
            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
             IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int LicenseID)
        {
            return clsDetainedLicenseData.DeleteDetainedLicense(LicenseID);
        }
        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicenseData.GetAllDetainedLicenses();
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseData.IsLicenseDetained(LicenseID);
        }
       
       
        public bool Save()
        {
           
            ReleaseApplicationID = ApplicationData.ApplicationID;
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    if (!ApplicationData.Save())
                    {
                        return false;
                    }
                    return _UpdateDetainedLicense();
            }
            return false;

        }

    }
}
