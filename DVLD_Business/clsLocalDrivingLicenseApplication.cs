using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication
    {
        public enum enMode {AddNew=1,Update=2 }
        public enMode Mode = enMode.AddNew;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public clsApplication ApplicaionData { get; set; }
        

        public clsLocalDrivingLicenseApplication() 
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;
            Mode = enMode.AddNew;
            ApplicaionData = new clsApplication();
        }
        public clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.ApplicaionData = clsApplication.Find(ApplicationID);
            Mode = enMode.AddNew;
        }
        private bool _AddNewLocalLicense()
        {
            
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalLicense(this.ApplicationID, this.LicenseClassID);
            return this.LocalDrivingLicenseApplicationID != -1;
        }
        private bool _UpdateLocalLicense()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalLicense(this.LocalDrivingLicenseApplicationID,this.ApplicationID, this.LicenseClassID);

        }
        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;


            bool IsFound = clsLocalDrivingLicenseApplicationData.GetLocalLicenseData(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);
            if (IsFound)
            {
                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID,  ApplicationID,  LicenseClassID);
            }
            else
            {
                return null;
            }
        }
        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.DeleteLocalLicense(LocalDrivingLicenseApplicationID);
        }
        public static bool Cancel(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.CancelLocalLicense(LocalDrivingLicenseApplicationID);
        }
        public static DataTable GetAllLocalLicensesApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalLicensesApplications();
        }
        public static bool IsLocalLicenseExist(int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationData.IsLocalLicenseExist(LicenseClassID);
        }

        public static bool HasActiveApplicationForClass(int ApplicantPersonID,int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationData.HasActiveApplicationForClass(ApplicantPersonID,LicenseClassID);
        }
        public static int GetPassedTests(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.GetPassedTests(LocalDrivingLicenseApplicationID);
        }
        public bool Save()
        {
            if (!ApplicaionData.Save())
            {
                return false;
            }
            ApplicationID = ApplicaionData.ApplicationID;
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateLocalLicense();
            }
            return false;

        }

    }
}
