using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonData { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public short ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }


        public clsApplication()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = -1;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            PersonData = new clsPerson();
            Mode = enMode.AddNew;
        }

        public clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, short ApplicationStatus,
             DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.PersonData = clsPerson.Find(ApplicantPersonID);
            Mode = enMode.AddNew;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate,
           this.PaidFees, this.CreatedByUserID);
            return this.ApplicationID != -1;
        }
        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate,
           this.PaidFees, this.CreatedByUserID);

        }
        public static clsApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            short ApplicationStatus = -1;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
           


            bool IsFound = clsApplicationData.GetApplicationDataByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate,
            ref PaidFees, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsApplication( ApplicationID,  ApplicantPersonID,  ApplicationDate,  ApplicationTypeID,  ApplicationStatus,
              LastStatusDate,  PaidFees,  CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
       
        public static bool Delete(int ApplicationID)
        {
            return clsApplicationData.DeleteApplication(ApplicationID);
        }
        public static bool Cencel(int ApplicationID)
        {
            return clsApplicationData.CencelApplication(ApplicationID);
        }
        public static DataTable GetAllApplications()
        {
            return clsApplicationData.GetAllApplications();
        }
        public static bool IsApplicationExist(int ApplicantPersonID)
        {
            return clsApplicationData.IsApplicationExist(ApplicantPersonID);
        }
        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;

        }
    }
}
