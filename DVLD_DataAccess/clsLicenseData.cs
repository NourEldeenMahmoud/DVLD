using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace DVLD_DataAccess
{
    public class clsLicenseData
    {
        public static bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate,
           ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees,ref bool IsActive, ref short IssueReason,ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Licenses where LicenseID=@LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else { Notes = ""; }
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
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
        public static int AddNewLicense( int ApplicationID,  int DriverID,  int LicenseClass,  DateTime IssueDate,
            DateTime ExpirationDate,  string Notes,  decimal PaidFees,  bool IsActive,  short IssueReason,  int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); 
            string Query = @"insert into Licenses( ApplicationID, DriverID,  LicenseClass ,IssueDate, ExpirationDate,Notes,IsActive,IssueReason, PaidFees ,CreatedByUserID)
                             Values (@ApplicationID, @DriverID,  @LicenseClass ,@IssueDate, @ExpirationDate,@Notes,@IsActive,@IssueReason, @PaidFees ,@CreatedByUserID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, short IssueReason, int CreatedByUserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Licenses 
                             set ApplicationID=@ApplicationID,
                                 DriverID=@DriverID,
                                 LicenseClass=@LicenseClass,
                                 IssueDate=@IssueDate,
                                 ExpirationDate=@ExpirationDate,
                                 Notes=@Notes,
                                 IsActive=@IsActive,
                                 IssueReason=@IssueReason,
                                 PaidFees=@PaidFees,
                                 CreatedByUserID=@CreatedByUserID
                             Where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            Command.Parameters.AddWithValue("@IssueDate", IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", Notes);
            Command.Parameters.AddWithValue("@PaidFees", PaidFees);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
            Command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static bool DeleteLicense(int LicenseID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete  Licenses
                            Where LicenseID=@LicenseID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


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

       
        public static int GetLicenseIDByApplicationID(int ApplicationID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select LicenseID from Licenses where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            int LicenseID = -1;
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];

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
            return LicenseID;
        }
        
        public static DataTable GetAllLicenses()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtLicenses = new DataTable();
            string Query = @"select * from Licenses";
            SqlCommand Command = new SqlCommand(Query, Connection);


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
        public static DataTable GetLicenseHistory(int DriverID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtLicenses = new DataTable();
            string Query = @"Select L.LicenseID,L.applicationID,C.ClassName,L.IssueDate,L.ExpirationDate,L.IsActive 
                                    from Licenses L
                                    inner join LicenseClasses C
                                    ON C.LicenseClassID=L.LicenseClass 
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
        public static bool IsLicenseExist(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from Licenses Where LicenseID=@LicenseID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);


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

