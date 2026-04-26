using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Rental_app
{
    // ============================================================
    //  DBHelper.cs
    //  Class pembantu untuk koneksi database
    //  Sesuaikan ConnectionString dengan pengaturan SQL Server kamu
    // ============================================================
    public static class DBHelper
    {
        // Ganti "NAMA_PC_KAMU\SQLEXPRESS" sesuai nama SQL Server kamu
        // Ganti "RentalMobilDB" dengan nama database kamu
        public static string ConnectionString = "server=localhost;database=rental_db;uid=root;pwd=;";

        // Cek apakah koneksi berhasil
        public static bool TestConnection()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnectionString))
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

        // Buat objek koneksi baru
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
