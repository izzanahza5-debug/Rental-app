using MySql.Data.MySqlClient;

namespace Rental_app
{
    public class KonekDb
    {
        // String koneksi (sesuaikan dengan setting MySQL kamu)
        private string connectionString = "server=localhost;database=db_rental;uid=root;pwd=;";
        public MySqlConnection koneksi;

        public KonekDb()
        {
            koneksi = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (koneksi.State == System.Data.ConnectionState.Closed)
                koneksi.Open();
        }

        public void CloseConnection()
        {
            if (koneksi.State == System.Data.ConnectionState.Open)
                koneksi.Close();
        }
    }
}