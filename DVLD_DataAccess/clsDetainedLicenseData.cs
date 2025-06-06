using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseByID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID,
           ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Select * from DetainedLicenses where LicenseID=@LicenseID";
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
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)reader["ReleaseDate"];
                    }
                    else { ReleaseDate = DateTime.Now; }

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    }
                    else { ReleasedByUserID = -1; }

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    }
                    else { ReleaseApplicationID = -1; }



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
        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"insert into DetainedLicenses( LicenseID, DetainDate,  FineFees ,CreatedByUserID, IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID)
                             Values (@LicenseID, @DetainDate,  @FineFees ,@CreatedByUserID, @IsReleased,@ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID)
                                    select scope_identity();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (IsReleased)
            {
                Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                Command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                Command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }
            

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

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update  DetainedLicenses
                             set LicenseID=@LicenseID,
                                 DetainDate=@DetainDate,
                                 FineFees=@FineFees,
                                 CreatedByUserID=@CreatedByUserID,
                                 IsReleased=@IsReleased,
                                 ReleaseDate=@ReleaseDate,
                                 ReleasedByUserID=@ReleasedByUserID,
                                 ReleaseApplicationID=@ReleaseApplicationID
                             Where DetainID=@DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);
            Command.Parameters.AddWithValue("@LicenseID", LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", DetainDate);
            Command.Parameters.AddWithValue("@FineFees", FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", IsReleased);
            Command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            Command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            Command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);


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

        public static bool DeleteDetainedLicense(int DetainID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Delete  DetainedLicenses
                            Where DetainID=@DetainID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DetainID", DetainID);


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


       

        public static DataTable GetAllDetainedLicenses()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtDetainedLicenses = new DataTable();
            string Query = @"Select * from DetainedLicenses_View";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtDetainedLicenses.Load(reader);
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

            return dtDetainedLicenses;

        }
       
        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString); ;
            string Query = @"Select Found = 1 from DetainedLicenses Where LicenseID=43 and IsReleased =0";
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
