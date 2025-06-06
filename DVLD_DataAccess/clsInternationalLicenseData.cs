using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseData
    {
        public static bool GetInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
          ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from InternationalLicenses where InternationalLicenseID=@InternationalLicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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
        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into InternationalLicenses( ApplicationID, DriverID,  IssuedUsingLocalLicenseID ,IssueDate, ExpirationDate,IsActive,CreatedByUserID)
                             Values (@ApplicationID, @DriverID,  @IssuedUsingLocalLicenseID ,@IssueDate, @ExpirationDate,@IsActive ,@CreatedByUserID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update InternationalLicenses 
                             set ApplicationID=@ApplicationID,
                                 DriverID=@DriverID,
                                 IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID,
                                 IssueDate=@IssueDate,
                                 ExpirationDate=@ExpirationDate,
                                 IsActive=@IsActive,
                                 CreatedByUserID=@CreatedByUserID
                             Where InternationalLicenseID=@InternationalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete  InternationalLicenses
                            Where InternationalLicenseID=@InternationalLicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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


        public static int GetInternationalLicenseIDByApplicationID(int ApplicationID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select InternationalLicenseID from InternationalLicenses where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            int InternationalLicenseID = -1;
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];

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
            return InternationalLicenseID;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtInternationalLicenses = new DataTable();
            string Query = @"SELECT InternationalLicenseID as 'Int.License ID' , ApplicationID,DriverID,IssuedUsingLocalLicenseID As 'L.License ID',IssueDate,ExpirationDate,IsActive FROM InternationalLicenses";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtInternationalLicenses.Load(reader);
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

            return dtInternationalLicenses;

        }
        public static DataTable GetIntLicenseHistory(int DriverID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtLicenses = new DataTable();
            string Query = @"SELECT InternationalLicenseID as 'Int.License ID' , ApplicationID,IssuedUsingLocalLicenseID As 'L.License ID',IssueDate,ExpirationDate,IsActive FROM InternationalLicenses
                                    Where DriverID=@DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtLicenses.Load(reader);
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

            return dtLicenses;

        }
        public static bool IsInternationalLicenseExist(int DriverID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from InternationalLicenses Where DriverID=@DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);


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
