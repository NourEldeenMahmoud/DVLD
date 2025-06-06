using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsLicenseClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClasses()
        {
             LicenseClassID = 0;
             ClassName = "";
             ClassDescription = "";
             MinimumAllowedAge = -1;
             DefaultValidityLength = -1;
             ClassFees = -1;
        }
        public clsLicenseClasses(int LicenseClassID,  string ClassName,  string ClassDescription, short MinimumAllowedAge,  short DefaultValidityLength, decimal ClassFees)
        { 
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

        }
        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesData.GetAllLicenseClasses();
        }
        public static clsLicenseClasses Find(int LicenseClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            short MinimumAllowedAge = -1;
            short DefaultValidityLength = -1;
            decimal ClassFees = -1;

           bool IsFound = clsLicenseClassesData.GetLicenseClassDataByID(LicenseClassID, ref ClassName, ref ClassDescription,ref  MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);
            if (IsFound)
            {
                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }
        public static string GetClassTitleByID(int ClassID)
        {
            clsLicenseClasses Class = clsLicenseClasses.Find(ClassID);
            return Class.ClassName;
        }
      
    }
}
