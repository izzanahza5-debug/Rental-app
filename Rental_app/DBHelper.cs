using System;
using MySql.Data.MySqlClient;

namespace Rental_app
{
    // ============================================================
    //  DBHelper.cs  —  Koneksi MySQL
    //
    //  CARA INSTALL MySQL Connector:
    //  Tools → NuGet Package Manager → Package Manager Console → ketik:
    //  Install-Package MySql.Data
    // ============================================================
    public static class DBHelper
    {
        private static string server = "localhost";
        private static string database = "rental_db"; // ganti nama database kamu
        private static string username = "root";          // ganti username MySQL kamu
        private static string password = "";              // ganti password MySQL kamu

        public static string ConnectionString =>
            $"Server={server};Database={database};Uid={username};Pwd={password};CharSet=utf8;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}