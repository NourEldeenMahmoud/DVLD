using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public  class clsTest
    {
        //int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult =false ;
            Notes = "";
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        public clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.AddNew;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return this.TestID != -1;
        }
        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

        }
        public static clsTest Find(int TestID)
        {

            int TestAppointmentID = -1;
            string Notes = "";
            int CreatedByUserID = -1;
            bool TestResult = false;


            bool IsFound = clsTestData.GetTestDataByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
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
        public static DataTable GetAllTests()
        {
            return clsTestData.GetAllTests();
        }
        public static bool IsTestExistByTestID(int TestID)
        {
            return clsTestData.IsTestExistByTestID(TestID);
        }
        

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTest();
            }
            return false;

        }

    }
}

