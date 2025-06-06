using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassesData
    {
        public static bool GetLicenseClassDataByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref short MinimumAllowedAge, ref short DefaultValidityLength,
             ref decimal ClassFees)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from LicenseClasses where LicenseClassID=@LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];


                }
                else
                {
                    IsFound = false;
                }
            }

            catch (Exception)
            {
                return IsFound = false;
            }

            finally
            {
                Connection.Close();
            }

            return IsFound;
        }


        public static DataTable GetAllLicenseClasses()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtLicenseClasss = new DataTable();
            string Query = @"Select * from LicenseClasses";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtLicenseClasss.Load(reader);
                }
                reader.Close();
            }

            catch (Exception)
            {

            }

            finally
            {
                Connection.Close();
            }

            return dtLicenseClasss;

        }

        public static bool IsLicenseClassExist(int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from LicenseClasss Where LicenseClassID=@LicenseClassID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }

            catch (Exception)
            {
                return IsFound = false;
            }

            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

    }
}
