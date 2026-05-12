using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rental_app
{
    public partial class UC_Status : UserControl
    {
        //private UserControl currentPage = null;
        string connectionString = "server=localhost;port=3306;username=root;password=;database=rental_db;";
        public UC_Status()
        {
            InitializeComponent();
            // Jalankan saat UserControl dimuat
            this.Load += (s, e) => MuatData();
            // Pasang event formatting warna
            dgvStatus.CellFormatting += dgvStatus_CellFormatting;

            // Pasang event pencarian
            txtSearch.TextChanged += (s, e) => MuatData(txtSearch.Text);

            // Tombol Refresh
            btnRefresh.Click += (s, e) => MuatData();
            if (dgvStatus.Columns.Count < 0)
            {
                label1.Visible = true;
                label2.Visible = true;
            }
        }
        public void MuatData(string keyword = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Query JOIN untuk mengambil data dari 3 tabel
                    // Kita asumsikan ada kolom 'status_rental' untuk membedakan mana yang sedang jalan
                    string query = @"SELECT t.id_transaksi, p.nama, m.nama_mobil, m.nomor_plat, 
                                     t.tgl_sewa, t.tgl_rencana_kembali, t.status 
                                     FROM tbl_transaksi t 
                                     JOIN pelanggan p ON t.id_pelanggan = p.id
                                     JOIN daftar_mobil m ON t.id_mobil = m.id 
                                     WHERE t.status = 'Aktif'";

                    // Tambahkan filter jika user mengetik di kotak pencarian
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " AND (p.nama LIKE @key OR m.nama_mobil LIKE @key OR m.nomor_plat LIKE @key)";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStatus.DataSource = dt;
                    if (dgvStatus.Columns.Count < 0)
                    {
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    AturHeaderTabel();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Waduh, gagal ambil data: " + ex.Message);
            }
        }
        private void AturHeaderTabel()
        {
            if (dgvStatus.Columns.Count > 0)
            {
                dgvStatus.Columns["id_transaksi"].HeaderText = "ID";
                dgvStatus.Columns["nama"].HeaderText = "Penyewa";
                dgvStatus.Columns["nama_mobil"].HeaderText = "Unit Mobil";
                dgvStatus.Columns["nomor_plat"].HeaderText = "No. Plat";
                dgvStatus.Columns["tgl_sewa"].HeaderText = "Tgl Pinjam";
                dgvStatus.Columns["tgl_rencana_kembali"].HeaderText = "Batas Kembali";
                dgvStatus.Columns["status"].HeaderText = "Status";
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
            }
        }
        private void UC_Status_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void dgvStatus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Cek kolom 'tgl_kembali'
            if (dgvStatus.Columns[e.ColumnIndex].Name == "tgl_kembali" && e.Value != null)
            {
                DateTime batasKembali = Convert.ToDateTime(e.Value);

                // Jika waktu sekarang sudah melewati batas kembali
                if (DateTime.Now > batasKembali)
                {
                    // Baris jadi merah muda (soft red) agar tetap kebaca
                    dgvStatus.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                    dgvStatus.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else if (DateTime.Now.Date == batasKembali.Date)
                {
                    // Jika harus kembali hari ini, kasih warna kuning (peringatan)
                    dgvStatus.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPerpanjang_Click(object sender, EventArgs e)
        {

        }

        private void dgvStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelesai_Click_1(object sender, EventArgs e)
        {
            string status = dgvStatus.SelectedRows[0].Cells["Status"].Value.ToString();
            int id = Convert.ToInt32(dgvStatus.SelectedRows[0].Cells["id_transaksi"].Value);
            if (dgvStatus.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Pilih Data Terlebih Dalhulu");
                return;
            }
            if (status == "Aktif")
            {
                if (MessageBox.Show("Yakin mobil sudah kembali?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    var cmd = new MySqlCommand(@"
                    UPDATE tbl_transaksi 
                    SET status='Selesai', tgl_kembali_real=NOW()
                    WHERE id_transaksi=@id", conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    var cmdMobil = new MySqlCommand(@"
            UPDATE daftar_mobil 
            SET status='Tersedia' 
            WHERE id = (SELECT id_mobil FROM tbl_transaksi WHERE id_transaksi=@id)", conn);

                    cmdMobil.Parameters.AddWithValue("@id", id);
                    cmdMobil.ExecuteNonQuery();

                    MessageBox.Show("Mobil berhasil dikembalikan!");
                    MuatData();
                }
            }
        }
    }
}
