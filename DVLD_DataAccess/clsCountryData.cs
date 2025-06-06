using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static DataTable GetAllCountries()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            DataTable dtCountries = new DataTable();
            string Query = "Select CountryName from Countries";
            SqlCommand Command = new SqlCommand(Query, Connection);


            try
            {
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtCountries.Load(reader);
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

            return dtCountries;

        }
        public static string GetCountryNameByID(int ID)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from Countries where CountryID=@ID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ID", ID);
            string Name = "";
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Name = (string)reader["CountryName"];

                }
                else
                {
                    return null;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }
            return Name;
        }
        public static int GetCountryIDByName(string CountryName)
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select CountryID from Countries where CountryName=@CountryName";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            int CountryID ;
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryID = (int)reader["CountryID"];

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
            return CountryID;
        }
    }
    
    
}
