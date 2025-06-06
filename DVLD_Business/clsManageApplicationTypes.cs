using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsManageApplicationTypes
    {
        
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        public clsManageApplicationTypes()
        {
            ApplicationTypeID = -1;
            ApplicationFees = -1;
            ApplicationTypeTitle = "";
        }

        public clsManageApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }


        private bool _UpdateApplicationType()
        {
            return clsManageApplicationTypesData.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
        }
        

       
        public static DataTable GetAllApplicationTypes()
        {
            return clsManageApplicationTypesData.GetAllApplicationTypes();
        }
        
        public static string GetApplicationTypeName(int ApplicationTypeID)
        {
            return clsManageApplicationTypesData.GetApplicationTypeName( ApplicationTypeID);
        }
        public static clsManageApplicationTypes Find(int ApplicationTypeID)
        {

            
            string ApplicationTypeTitle = "";
            decimal ApplicationFees = -1;

            bool IsFound = clsManageApplicationTypesData.GetApplicationType(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees);
            if (IsFound)
            {
                return new clsManageApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
           
            if (_UpdateApplicationType())
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
