using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDriverData
    {
        public static bool GetDriverByID(int DriverID, ref int PersonID, ref DateTime CreatedDate, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Drivers where DriverID=@DriverID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DriverID = (int)reader["DriverID"];
                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
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
        public static bool GetDriverByPersonID(int PersonID, ref int DriverID, ref DateTime CreatedDate, ref int CreatedByUserID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from Drivers where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    DriverID = (int)reader["DriverID"];
                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
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

        public static int AddNewDriver(int PersonID, DateTime CreatedDate, int CreatedByUserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into Drivers( PersonID, CreatedDate,CreatedByUserID)
                             Values (@PersonID, @CreatedDate ,@CreatedByUserID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
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

        public static bool UpdateDriver(int DriverID, int PersonID, DateTime CreatedDate, int CreatedByUserID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Drivers 
                             set PersonID=@PersonID,
                                 CreatedDate=@CreatedDate,
                                 CreatedByUserID=@CreatedByUserID
                             Where DriverID=@DriverID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
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

        public static bool DeleteDriver(int DriverID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete Drivers 
                            Where DriverID=@DriverID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DriverID", DriverID);


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

        public static DataTable GetAllDrivers()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtDrivers = new DataTable();
            string Query = @"SELECT * From Drivers_View ";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtDrivers.Load(reader);
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

            return dtDrivers;

        }

        public static bool IsDriverExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = "Select Found = 1 from Drivers Where PersonID=@PersonID";
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
        public static int GetDriverIDByPersonID( int PersonID)
        {

            int DriverID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select DriverID from Drivers where PersonID=@PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.Read())
                {
                    DriverID = (int)reader["DriverID"];

                }
                else
                {
                    return -1;
                }
            }

            catch (Exception)
            {
                return -1;
            }

            finally
            {
                Connection.Close();
            }

            return DriverID;
        }
    }
}
