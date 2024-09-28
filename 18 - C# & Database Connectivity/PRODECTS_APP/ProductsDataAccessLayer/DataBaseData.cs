using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductsDataAccessLayer
{
    public class clsDataBaseDataAccess
    {
        static public bool CreateBackup(string PathCreateBackup)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"
                             backup database SalesManagementDB 
                             to Disk=@PathCreateBackup";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PathCreateBackup", PathCreateBackup);
            try
            {
                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch
            {
               
            }
            finally
            {
                Connection.Close();
            }
            return (File.Exists(PathCreateBackup));
        }

        static public bool RestoreBackup(string PathRestoreBackup)
        {
            bool IsRestored = true;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" use master;
                              Restore DATABASE SalesManagementDB
                              FROM Disk=@PathRestoreBackup
                              with Replace;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PathRestoreBackup", PathRestoreBackup);
            try
            {
                Connection.Open();
                Command.ExecuteNonQuery();
                IsRestored = true;
            }
            catch
            {
                IsRestored = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsRestored;
        }
    }
}
