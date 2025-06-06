using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsManageTestTypesData
    {
        public static bool UpdateTestType(int TestTypeID,string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update TestTypes 
                             set TestTypeTitle=@TestTypeTitle,
                                 TestTypeDescription=@TestTypeDescription,
                                 TestTypeFees=@TestTypeFees
                             Where TestTypeID=@TestTypeID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            Command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            Command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);


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
        public static DataTable GetAllTestTypes()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtApplicationTypes = new DataTable();
            string Query = @"Select * from TestTypes";
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

        public static bool GetTestType(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from TestTypes where TestTypeID=@TestTypeID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];

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
    }
}
