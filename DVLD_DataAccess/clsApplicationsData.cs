using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {
        public static bool GetApplicationDataByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref short ApplicationStatus,
            ref DateTime  LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Applications where ApplicationID=@ApplicationID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
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

        public static int AddNewApplication( int ApplicantPersonID,  DateTime ApplicationDate,  int ApplicationTypeID,  short ApplicationStatus,
             DateTime LastStatusDate,  decimal PaidFees,  int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Applications( ApplicantPersonID, ApplicationDate,  ApplicationTypeID ,ApplicationStatus, LastStatusDate, PaidFees ,CreatedByUserID)
                             Values (@ApplicantPersonID, @ApplicationDate,  @ApplicationTypeID ,@ApplicationStatus, @LastStatusDate, @PaidFees ,@CreatedByUserID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        public static bool UpdateApplication(int ApplicationID,int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, short ApplicationStatus,
             DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Applications 
                             set ApplicantPersonID=@ApplicantPersonID,
                                 ApplicationDate=@ApplicationDate,
                                 ApplicationTypeID=@ApplicationTypeID,
                                 ApplicationStatus=@ApplicationStatus,
                                 LastStatusDate=@LastStatusDate,
                                 PaidFees=@PaidFees,
                                 CreatedByUserID=@CreatedByUserID
                             Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

        public static bool DeleteApplication(int ApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete  Application
                            Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


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
        public static bool CencelApplication(int ApplicationID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"UPDATE Applications
                            set ApplicationStatus=2
                            Where ApplicationID=@ApplicationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


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
    

        public static DataTable GetAllApplications()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtApplications = new DataTable();
            string Query = @"select * from Applications";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtApplications.Load(reader);
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

            return dtApplications;

        }

        public static bool IsApplicationExist(int ApplicantPersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from Applications Where ApplicantPersonID=@ApplicantPersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
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

