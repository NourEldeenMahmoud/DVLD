using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsManageApplicationTypesData
    {
        public static bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeTitle, decimal ApplicationFees )
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update ApplicationTypes 
                             set ApplicationTypeTitle=@ApplicationTypeTitle,
                                 ApplicationFees=@ApplicationFees
                             Where ApplicationTypeID=@ApplicationTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            Command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);


            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            catch (Exception)
            {
                return false;
                throw;
            }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;

        }
        public static DataTable GetAllApplicationTypes()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtApplicationTypes = new DataTable();
            string Query = @"Select * from ApplicationTypes";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtApplicationTypes.Load(reader);
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

            return dtApplicationTypes;

        }

        public static bool GetApplicationType(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];

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
        public static string GetApplicationTypeName(int ApplicationTypeID)
        {

            string Name = "";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select ApplicationTypeTitle from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    Name = (string)reader["ApplicationTypeTitle"];
                   
                }
                else
                {
                    return null ;
                }
            }

            catch (Exception)
            {
                return null;
            }

            finally
            {
                Connection.Close();
            }

            return Name;
        }
    }
}
