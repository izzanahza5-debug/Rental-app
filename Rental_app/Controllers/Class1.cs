using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

    public class UserController
{
    private string koneksi = "server=localhost;database=rental_db;uid=root;pwd=;";
    public List<TransaksiDashboard> GetUser()
    {
        List<TransaksiDashboard> users = new List<TransaksiDashboard>();
        using (var conn = new MySqlConnection(koneksi))
        {
            conn.Open();
            string query = "SELECT " + 
    " m.id,"+
    " m.nama_mobil," +
    " p.nama," +
    " t.tgl_sewa," +
    " t.tgl_rencana_kembali "+
" FROM tbl_transaksi t" +
" JOIN daftar_mobil m ON t.id_mobil = m.id" +
" JOIN pelanggan p ON t.id_pelanggan = p.id;";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new TransaksiDashboard
                        {
                            IdTransaksi = Convert.ToInt32(reader["id"]),
                            NamaMobil = reader["nama_mobil"].ToString(),
                            NamaPelanggan = reader["nama"].ToString(),
                            TglSewa = reader["tgl_sewa"].ToString(),
                            TglRencanaKembali = reader["tgl_rencana_kembali"].ToString(),
                        });
                    }

                }
            }
        }
        return users;
    }

}

    public class KategoriController
{
    private string koneksi = "server=localhost;database=rental_db;uid=root;pwd=;";

    public List<Kategori> GetKategori()
    {
        List<Kategori> kategoris = new List<Kategori>();
        using (var conn = new MySqlConnection(koneksi))
        {
            conn.Open();
            string query = "SELECT * FROM kategori";
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kategoris.Add(new Kategori
                        {
                            id = Convert.ToInt32(reader["id"]),
                            nama_kategori = reader["kode_kategori"].ToString(),
                            kode_kategori = reader["nama_kategori"].ToString(),
                        });
                    }
                }
            }
        }
        return kategoris;
    }

    public bool CreateKategori(string kode_kategori, string nama_kategori)
    {
        using (var conn = new MySqlConnection(koneksi))
        {
            conn.Open();
            string query = "INSERT INTO kategori  ( kode_kategori, nama_kategori) VALUES ( @kode_kategori, @nama_kategori)";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@kode_kategori", kode_kategori);
                cmd.Parameters.AddWithValue("@nama_kategori", nama_kategori);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    public bool UpdateKategori(int id, string kode_kategori, string nama_kategori)
    {
        try
        {
            using (var conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "UPDATE kategori SET nama_kategori = @nama_kategori, kode_kategori = @kode_kategori WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@kode_kategori", kode_kategori);
                    cmd.Parameters.AddWithValue("@nama_kategori", nama_kategori);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data kategori berhasil diperbarui!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!", "Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
            return false;
        }

    }
    public bool DeleteKategori(int id)
    {
        try
        {
            using (var conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "DELETE FROM kategori WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!", "Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
    public class MobilController
    {
        private string koneksi = "server=localhost;database=rental_db;uid=root;pwd=;";

    public List<Mobil> GetMobil()
    {
        List<Mobil> mobils = new List<Mobil>();
        using (var conn = new MySqlConnection(koneksi))
        {
            conn.Open();
            string query = @"SELECT 
                            m.id,
                            m.nama_mobil,
                            m.nomor_plat,
                            m.harga,
                            k.nama_kategori,
                            m.status
                         FROM daftar_mobil m
                         JOIN kategori k ON m.kategori = k.id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mobils.Add(new Mobil
                        {
                            id = reader.GetInt32("id"),
                            nama_mobil = reader["nama_mobil"].ToString(),
                            nomor_plat = reader["nomor_plat"].ToString(),
                            harga = Convert.ToDecimal(reader["harga"]),
                            kategori = reader["nama_kategori"].ToString(), // 🔥 ini yang berubah
                            status = reader["status"].ToString(),
                        });
                    }
                }
            }
        }
        return mobils;
    }

    public bool CreateMobil(string nama_mobil, string nomor_plat, decimal harga, string kategori, string status)
        {
            try
            {
                using (var conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string query = "INSERT INTO daftar_mobil (nama_mobil, nomor_plat, harga, kategori, status) " +
                                   "VALUES (@nama_mobil, @nomor_plat, @harga, @kategori, @status)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_mobil", nama_mobil);
                        cmd.Parameters.AddWithValue("@nomor_plat", nomor_plat);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@status", status);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool UpdateMobil(int id, string nama_mobil, string nomor_plat, decimal harga, string kategori, string status)
        {
            try
            {
                using (var conn = new MySqlConnection(koneksi))
                {
                    conn.Open();

                    string query = "UPDATE daftar_mobil SET " +
                                   "nama_mobil = @nama_mobil, " +
                                   "nomor_plat = @nomor_plat, " +
                                   "harga = @harga, " +
                                   "kategori = @kategori, " +
                                   "status = @status " +
                                   "WHERE id = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nama_mobil", nama_mobil);
                        cmd.Parameters.AddWithValue("@nomor_plat", nomor_plat);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data mobil berhasil diperbarui!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan!", "Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool deleteMobil(int id)
        {
            try
            {

                using (var conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string query = "DELETE FROM daftar_mobil WHERE id=@id ";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data mobil berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan!", "Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
    public class PelangganController
    {
        string koneksi = "server=localhost;database=rental_db;uid=root;pwd=;";
        public List<Pelanggan> getPelanggan()
        {
            List<Pelanggan> pelanggans = new List<Pelanggan>();
            using (var conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string query = "SELECT * FROM pelanggan";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pelanggans.Add(new Pelanggan
                            {
                                id = reader["id"].ToString(),
                                nama_pelanggan = reader["nama"].ToString(),
                                alamat = reader["alamat"].ToString(),
                                nomor_telepon = reader["nomor_wa"].ToString(),
                                total_sewa = reader["total_sewa"].ToString(),
                            });
                        }
                    }
                }
            }
            return pelanggans;
        }

        public bool createPelanggan(string nama, string alamat, int nomor_wa, int total_sewa)
        {
            try
            {
                string koneksi = "server=localhost;database=rental_db;uid=root;pwd=;";
                using (var conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string query = "INSERT INTO pelanggan (nama, alamat, nomor_wa, total_sewa) VALUES (@nama, @alamat, @nomor_wa, @total_sewa)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@nomor_wa", nomor_wa);
                        cmd.Parameters.AddWithValue("@total_sewa", total_sewa);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan pelanggan!", "Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool updatePelanggan(int id, string nama, string alamat, int nomor_wa, int total_sewa)
        {
            try
            {
                using (var conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string query = "UPDATE pelanggan SET nama = @nama, alamat = @alamat, nomor_wa = @nomor_wa, total_sewa = @total_sewa WHERE id = @id;";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@nomor_wa", nomor_wa);
                        cmd.Parameters.AddWithValue("@total_sewa", total_sewa);
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            MessageBox.Show("Data pelanggan berhasil diperbarui!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan!", "Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool deletePelanggan(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(koneksi))
                {
                    conn.Open();
                    string query = "DELETE FROM pelanggan WHERE id=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            MessageBox.Show("Data pelanggan berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan!", "Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public class DashboardController
{
    string koneksi = "server=localhost;database=rental_db;uid=root;pwd=;";
    public int totalMobil()
    {
        using (var conn = new MySqlConnection(koneksi))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM daftar_mobil;";
            using(var cmd = new MySqlCommand(query, conn))
            {
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                return total;
            }
        }
    }
}