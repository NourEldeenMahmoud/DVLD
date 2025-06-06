using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Diagnostics.SymbolStore;

namespace DVLD_DataAccess
{
    public class clsUserData
    {

        public static bool GetUserDataByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Users where UserID=@UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];

                    IsActive = (bool)reader["IsActive"];

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

        public static bool GetUserDataByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Users where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {

                    IsFound = true;

                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

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
        public static bool GetUserDataByUserName(string UserName,ref int PersonID, ref int UserID,  ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Users where UserName=@UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read())
                {

                    IsFound = true;

                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

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

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Users( PersonID, UserName,  Password ,IsActive)
                             Values (@PersonID, @UserName,  @Password ,@IsActive)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Users 
                             set PersonID=@PersonID,
                                 UserName=@UserName,
                                 Password=@Password,
                                 IsActive=@IsActive
                             Where UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@IsActive", IsActive);



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

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete Users 
                            Where UserID=@UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);


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

        public static DataTable GetAllUsers()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtUsers = new DataTable();
            string Query = @"SELECT u.UserID,u.PersonID,
                            CONCAT(p.FirstName, ' ', p.SecondName, ' ', p.ThirdName, ' ', p.LastName) AS FullName, u.UserName,u.IsActive
                            FROM users u
                            INNER JOIN people p ON u.PersonID = p.PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtUsers.Load(reader);
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

            return dtUsers;

        }

        public static bool IsUserExistByUserID(int UserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from Users Where UserID=@UserID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);


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
        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from Users Where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);


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
