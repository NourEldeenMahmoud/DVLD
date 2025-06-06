using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalLicenseData(int LocalDrivingLicenseApplicationID,ref int ApplicationID,ref int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from LocalDrivingLicenseApplications
                            Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue( @"LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read()) 
                {
                    IsFound = true;
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];

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

        public static int AddNewLocalLicense( int ApplicationID,  int LicenseClassID)
        {
            SqlConnection Connection = new SqlConnection( clsDataAccessSettings.ConnectionString );
            string Query = @"Insert into LocalDrivingLicenseApplications (ApplicationID,LicenseClassID)
                                Values (@ApplicationID,@LicenseClassID)
                                 SELECT SCOPE_IDENTITY()";
            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                object result =Command.ExecuteScalar();
                if (result!=null&int.TryParse(result.ToString(),out int InsertedID))
                {
                    return InsertedID;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {

                
            }
            finally
            {
                Connection.Close ();
            }
            return -1;
        }

        public static bool UpdateLocalLicense(int LocalDrivingLicenseApplicationID,  int ApplicationID,  int LicenseClassID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update LocalDrivingLicenseApplications
                             set
                             ApplicationID=@ApplicationID,
                             LicenseClassID=@LicenseClassID
                             Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                Connection.Open();
                RowsAffected=Command.ExecuteNonQuery();
                

            }
            catch (Exception)
            {
                return false ;
                throw;
            }
            finally
            {
                Connection.Close ();
            }
            return RowsAffected > 0;   
        }
        public static bool DeleteLocalLicense( int LocalDrivingLicenseApplicationID)
        {
            int RowsAffected;
            SqlConnection Connection =new SqlConnection( clsDataAccessSettings.ConnectionString );
            string Query = @"Delete LocalDrivingLicenseApplications 
                             Where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand Command  =new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
                Connection.Close ();
            }
            return RowsAffected>0;
        }
        public static bool CancelLocalLicense(int LocalDrivingLicenseApplicationID)
        {
            int RowsAffected;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE a
                            SET a.ApplicationStatus = 2
                            FROM LocalDrivingLicenseApplications l
                            INNER JOIN Applications a
                            ON a.ApplicationID = l.ApplicationID
                            WHERE l.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
        public static DataTable GetAllLocalLicensesApplications()
        {
            DataTable dtAllLicenses = new DataTable();
            SqlConnection Connection= new SqlConnection( clsDataAccessSettings.ConnectionString );
            string Query = @"Select * from LocalDrivingLicenseApplications_View ";
            SqlCommand Command = new SqlCommand (Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtAllLicenses.Load(reader);
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return dtAllLicenses;
        }
        public static int GetPassedTests(int LocalDrivingLicenseApplicationID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT COUNT(TestAppointments.TestTypeID) AS PassedTestCount 
                        FROM Tests 
                        INNER JOIN TestAppointments 
                            ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                        INNER JOIN LocalDrivingLicenseApplications 
                            ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                        WHERE Tests.TestResult = 1 and LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID= @LocalDrivingLicenseApplicationID;";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            int PassedTests;
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PassedTests = Convert.ToInt32(reader["PassedTestCount"]);;

                }
                else
                {
                    return -1;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                Connection.Close();
            }
            return PassedTests;


        }
        public static bool IsLocalLicenseExist(int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from LocalDrivingLicenseApplications Where LicenseClassID=@LicenseClassID";
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
        public static bool HasActiveApplicationForClass(int ApplicantPersonID,int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = @"Select Found=1 from LocalDrivingLicenseFullApplications_View where ApplicantPersonID=@ApplicantPersonID and LicenseClassID=@LicenseClassID and not ApplicationStatus= 2";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);


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
