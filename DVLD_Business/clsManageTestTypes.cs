using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsManageTestTypes
    {
        
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestFees { get; set; }

        public clsManageTestTypes()
        {
            TestTypeID = -1;
            TestFees = -1;
            TestTypeTitle = "";
            TestTypeDescription = "";
        }

        public clsManageTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestFees = TestFees;
            this.TestTypeDescription = TestTypeDescription;
        }


        private bool _UpdateTestType()
        {
            return clsManageTestTypesData.UpdateTestType(TestTypeID, TestTypeTitle,  TestTypeDescription, TestFees);
        }
        

       
        public static DataTable GetAllTestTypes()
        {
            return clsManageTestTypesData.GetAllTestTypes();
        }
        public static clsManageTestTypes Find(int TestTypeID)
        {

            
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            decimal TestFees = -1;

            bool IsFound = clsManageTestTypesData.GetTestType(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestFees);
            if (IsFound)
            {
                return new clsManageTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestFees);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
           
            if (_UpdateTestType())
            {
                return true;
            }
            else
            {
                return false;
            
            }

        }
    }
}
