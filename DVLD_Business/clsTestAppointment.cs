using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        //int TestAppointmentID, int TestAppointmentAppointmentID, bool TestAppointmentResult, string Notes, int CreatedByUserID
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }


        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked=false;
            RetakeTestApplicationID = -1;
            Mode = enMode.AddNew;
        }

        public clsTestAppointment( int TestAppointmentID,int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees,
              int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            Mode = enMode.AddNew;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees,this.CreatedByUserID
                ,this.IsLocked,this.RetakeTestApplicationID);
            return this.TestAppointmentID != -1;
        }
        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID
                , this.IsLocked, this.RetakeTestApplicationID);

        }
        public static clsTestAppointment Find(int TestAppointmentID)
        { 
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees= -1;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;


            bool IsFound = clsTestAppointmentData.GetTestAppointmentDataByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees,ref CreatedByUserID, ref IsLocked,ref RetakeTestApplicationID);
            if (IsFound)
            {
                return new clsTestAppointment(TestAppointmentID,  TestTypeID,  LocalDrivingLicenseApplicationID,  AppointmentDate,  PaidFees,  CreatedByUserID,  IsLocked,  RetakeTestApplicationID);
            }
            else
            {
                return null;
            }
        }


        public static bool Delete(int TestID)
        {
            return clsTestData.DeleteTest(TestID);
        }
        public static DataTable GetAllAppointments()
        {
            return clsTestAppointmentData.GetAllTestAppointments();
        }
        public static DataTable GetPersonAppointments(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.GetPersonAppointments(LocalDrivingLicenseApplicationID);
        }
        public static bool DoesTestAppointmentExistByTestID(int TestID)
        {
            return clsTestAppointmentData.IsTestAppointmentExistByID(TestID);
        }
        
        public static bool CheckForActiveAppointment(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.CheckForActiveAppointment(LocalDrivingLicenseApplicationID);
        }
        public static bool LastTestFailed(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentData.LastTestFailed(LocalDrivingLicenseApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTestAppointment();
            }
            return false;

        }

    }
}

