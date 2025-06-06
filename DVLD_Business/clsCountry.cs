using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountry
    {
        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
        public static string GetCountryNameByID(int CountryID)
        {
            return clsCountryData.GetCountryNameByID(CountryID);
        }
        public static int GetCountryIDByName(string CountryName)
        {
            return clsCountryData.GetCountryIDByName(CountryName);
        }
    }
}
