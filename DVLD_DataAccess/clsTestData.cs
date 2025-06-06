using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestData
    {
        public static bool GetTestDataByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Tests where TestID=@TestID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = (string)reader["Notes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static int AddNewTest( int TestAppointmentID,  bool TestResult,  string Notes,  int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Tests( TestAppointmentID, TestResult,  Notes ,CreatedByUserID)
                             Values (@TestAppointmentID, @TestResult,  @Notes ,@CreatedByUserID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {

                Connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    return InsertedID;
                }
                else { return -1; }
            }

            catch (Exception)
            {


            }

            finally
            {
                Connection.Close();
            }

            return -1;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Tests 
                             set TestAppointmentID=@TestAppointmentID,
                                 TestResult=@TestResult,
                                 Notes=@Notes,
                                 CreatedByUserID=@CreatedByUserID
                             Where TestID=@TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", TestResult);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



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

        public static bool DeleteTest(int TestID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete Tests 
                            Where TestID=@TestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);


            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();

            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

        public static DataTable GetAllTests()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtTests = new DataTable();
            string Query = @"SELECT * from Tests ";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtTests.Load(reader);
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

            return dtTests;

        }

        public static bool IsTestExistByTestID(int TestID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from Tests Where TestID=@TestID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestID", TestID);


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
