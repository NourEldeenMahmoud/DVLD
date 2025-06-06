using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDriver
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonData { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }

        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedDate = DateTime.Now;
            CreatedByUserID = -1;
            PersonData = new clsPerson();
            Mode = enMode.AddNew;
        }

        public clsDriver(int DriverID,int PersonID, DateTime CreatedDate, int CreatedByUserID)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedDate = CreatedDate;
            this.CreatedByUserID = CreatedByUserID;
            this.PersonData = clsPerson.Find(PersonID);
            Mode = enMode.AddNew;
        }
        
        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedDate,  this.CreatedByUserID);
            return this.DriverID != -1;
        }
        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedDate, this.CreatedByUserID);

        }
        public static clsDriver GetDriverByPersonID(int PersonID)
        {

            int DriverID = -1;
            DateTime CreatedDate =DateTime.Now;
            int CreatedByUserID = -1;


            bool IsFound = clsDriverData.GetDriverByPersonID(PersonID, ref DriverID, ref CreatedDate,  ref CreatedByUserID);
            if (IsFound)
            {
                return new clsDriver(DriverID,PersonID , CreatedDate, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static clsDriver Find(int DriverID)
        {

            int PersonID = -1;
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;


            bool IsFound = clsDriverData.GetDriverByID(DriverID, ref PersonID, ref CreatedDate, ref CreatedByUserID);
            if (IsFound)
            {
                return new clsDriver(DriverID, PersonID, CreatedDate, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static int GetDriverIDByPersonID(int PersonID)
        {
            return clsDriverData.GetDriverIDByPersonID(PersonID);
        }
        public static bool Delete(int DriverID)
        {
            return clsDriverData.DeleteDriver(DriverID);
        }
        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }
        public static bool IsDriverExistByPersonID(int DriverID)
        {
            return clsDriverData.IsDriverExistByPersonID(DriverID);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDriver();
            }
            return false;

        }
    }
}
