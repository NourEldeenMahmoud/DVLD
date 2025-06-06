using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {
         public static bool GetTestAppointmentDataByID(int TestAppointmentID ,ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,ref DateTime AppointmentDate,ref decimal PaidFees,
             ref int CreatedByUserID, ref bool IsLocked,ref int RetakeTestApplicationID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from TestAppointments where TestAppointmentID=@TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }
                    else { RetakeTestApplicationID = -1; };
                     
                    PaidFees = (decimal)reader["PaidFees"];
                    IsLocked = (bool)reader["IsLocked"];

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
        
        public static int AddNewTestAppointment( int TestTypeID,  int LocalDrivingLicenseApplicationID,  DateTime AppointmentDate,  decimal PaidFees,
              int CreatedByUserID,  bool IsLocked,  int RetakeTestApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into TestAppointments( TestTypeID, LocalDrivingLicenseApplicationID,AppointmentDate ,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID)
                             Values ( @TestTypeID, @LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);

            Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID == -1 ? DBNull.Value : (object)RetakeTestApplicationID);
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

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees,
              int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update TestAppointments 
                             set TestTypeID=@TestTypeID,
                                 LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID,
                                 AppointmentDate=@AppointmentDate,
                                 PaidFees=@PaidFees,
                                 CreatedByUserID=@CreatedByUserID,
                                 IsLocked=@IsLocked,
                                 RetakeTestApplicationID=@RetakeTestApplicationID
                             Where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", IsLocked);
            Command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID == -1 ? DBNull.Value : (object)RetakeTestApplicationID);




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

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete TestAppointments 
                            Where TestAppointmentID=@TestAppointmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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

        public static DataTable GetAllTestAppointments()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtTestAppointments = new DataTable();
            string Query = @"SELECT TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtTestAppointments.Load(reader);
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

            return dtTestAppointments;

        }
        public static DataTable GetPersonAppointments(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtTestAppointments = new DataTable();
            string Query = @"SELECT TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtTestAppointments.Load(reader);
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

            return dtTestAppointments;

        }
        public static bool CheckForActiveAppointment(int LocalDrivingLicenseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from TestAppointments Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked = 0";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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
        public static bool LastTestFailed(int LocalDrivingLicenseApplicationID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); 
            string Query = @"SELECT Found = 1
                                FROM (
                                    SELECT TOP 1 T.TestResult
                                    FROM TestAppointments TA  
                                    JOIN Tests T ON T.TestAppointmentID = TA.TestAppointmentID  
                                    WHERE TA.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                    ORDER BY T.TestID DESC
                                ) AS LastTest
                                WHERE LastTest.TestResult = 0";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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
        public static bool IsTestAppointmentExistByID(int TestAppointmentID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from TestAppointments Where TestAppointmentID=@TestAppointmentID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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
