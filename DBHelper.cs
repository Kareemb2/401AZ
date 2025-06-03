using MySql.Data.MySqlClient;

namespace HospitalManagment
{
    public static class DBHelper
    {
        // Connection string for MySQL database
        private static readonly string connectionString =
            "server=database-1.c6icxuqmursh.us-east-1.rds.amazonaws.com;user=admin;password=Jackmac12381;database=HospitalDB;";

        /// <summary>
        /// Returns a new MySqlConnection object using the configured connection string.
        /// Caller is responsible for opening and closing the connection.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
