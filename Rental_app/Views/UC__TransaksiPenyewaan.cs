using MySql.Data.MySqlClient;
using Rental_app.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Rental_app
{
    public partial class UC__TransaksiPenyewaan : UserControl
    {
        // Pengganti DataTable — simpan list mobil untuk hitung harga
        private List<Mobil> _listMobil = new List<Mobil>();

        public UC__TransaksiPenyewaan()
        {
            InitializeComponent();
            this.Load += UC__TransaksiPenyewaan_Load;
        }

        // ── Load awal ──────────────────────────────────────────────
        private void UC__TransaksiPenyewaan_Load(object sender, EventArgs e)
        {
            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;
            btnReset.Click += btnReset_Click;
            btnCari.Click += btnCari_Click;
            btnRefresh.Click += (s, ev) => LoadDataTransaksi();

            cboMobil.SelectedIndexChanged += (s, ev) => HitungTotal();
            dtpTglSewa.ValueChanged += (s, ev) => HitungTotal();
            dtpTglKembali.ValueChanged += (s, ev) => HitungTotal();
            txtCari.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Enter) CariTransaksi(); };

            dtpTglSewa.Value = DateTime.Today;
            dtpTglKembali.Value = DateTime.Today.AddDays(1);
            dtpTglSewa.MinDate = DateTime.Today;

            LoadPelanggan();
            LoadMobil();
            LoadDataTransaksi();
        }

        // ── Load dropdown Pelanggan ────────────────────────────────
        private void LoadPelanggan()
        {
            try
            {
                var listPelanggan = new List<Pelanggan>();

                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, nama, nomor_wa FROM pelanggan ORDER BY nama";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listPelanggan.Add(new Pelanggan
                            {
                                id = reader["id"].ToString(),
                                nama_pelanggan = reader["nama"].ToString(),
                                nomor_telepon = reader["nomor_wa"].ToString(),
                            });
                        }
                    }
                }

                cboPelanggan.DataSource = null;
                cboPelanggan.DataSource = listPelanggan;
                cboPelanggan.DisplayMember = "nama_pelanggan";
                cboPelanggan.ValueMember = "id";
                cboPelanggan.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load pelanggan:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Load dropdown Mobil (hanya Tersedia) ──────────────────
        private void LoadMobil()
        {
            try
            {
                _listMobil.Clear();

                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT id, nama_mobil, nomor_plat, harga
                                   FROM daftar_mobil
                                   WHERE status = 'Tersedia'
                                   ORDER BY nama_mobil";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _listMobil.Add(new Mobil
                            {
                                id = reader.GetInt32("id"),
                                nama_mobil = reader.GetString("nama_mobil"),
                                nomor_plat = reader.GetString("nomor_plat"),
                                harga = reader.GetDecimal("harga")
                            });
                        }
                    }
                }

                cboMobil.DataSource = null;           // reset dulu agar tidak dobel
                cboMobil.DataSource = _listMobil;
                cboMobil.DisplayMember = "nama_mobil";
                cboMobil.ValueMember = "id";
                cboMobil.SelectedIndex = _listMobil.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load mobil:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Load tabel transaksi ───────────────────────────────────
        private void LoadDataTransaksi(string keyword = "")
        {
            try
            {
                var listTransaksi = new List<Transaksi>();

                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            t.id_transaksi,
                            p.nama                                         AS pelanggan,
                            CONCAT(m.nama_mobil,' (',m.nomor_plat,')')    AS mobil,
                            DATE_FORMAT(t.tgl_sewa,'%d/%m/%Y')            AS tgl_sewa,
                            DATE_FORMAT(t.tgl_rencana_kembali,'%d/%m/%Y') AS rencana_kembali,
                            CONCAT(t.durasi,' hari')                      AS durasi,
                            CONCAT('Rp ',FORMAT(t.total_biaya,0))         AS total_biaya,
                            t.status,
                            t.id_mobil
                        FROM tbl_transaksi t
                        JOIN pelanggan    p ON t.id_pelanggan = p.id
                        JOIN daftar_mobil m ON t.id_mobil     = m.id
                        WHERE p.nama LIKE @kw OR m.nama_mobil LIKE @kw
                        ORDER BY t.created_at ASC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listTransaksi.Add(new Transaksi
                                {
                                    IdTransaksi = reader.GetInt32("id_transaksi"),
                                    Pelanggan = reader.GetString("pelanggan"),
                                    Mobil = reader.GetString("mobil"),
                                    TglSewa = reader.GetString("tgl_sewa"),
                                    RencanaKembali = reader.GetString("rencana_kembali"),
                                    Durasi = reader.GetString("durasi"),
                                    TotalBiaya = reader.GetString("total_biaya"),
                                    Status = reader.GetString("status"),
                                    IdMobil = reader.GetInt32("id_mobil")
                                });
                            }
                        }
                    }
                }

                // Bind ke DataGridView
                dgvTransaksi.DataSource = null;
                dgvTransaksi.DataSource = listTransaksi;

                // Rename header kolom agar lebih rapi
                AturKolomDGV();

                // Warna baris per status
                foreach (DataGridViewRow row in dgvTransaksi.Rows)
                {
                    string st = row.Cells["Status"].Value?.ToString();
                    if (st == "Aktif") row.DefaultCellStyle.BackColor = Color.FromArgb(232, 248, 232);
                    else if (st == "Batal") row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                    else if (st == "Selesai") row.DefaultCellStyle.BackColor = Color.FromArgb(235, 245, 255);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load transaksi:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //logika status
        private void logikaStatus()
        {
            if (dgvTransaksi.CurrentRow == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }
            int id = Convert.ToInt32(dgvTransaksi.Rows[0].Cells["IdTransaksi"].Value);

            string status = dgvTransaksi.CurrentRow.Cells["status"].Value.ToString();

            if (status == "Selesai")
            {
                MessageBox.Show("Transaksi ini sudah selesai!");
                return;
            }
            using (var conn = DBHelper.GetConnection())
            {
                conn.Open();

                // Update transaksi
                var cmd = new MySqlCommand(@"
        UPDATE tbl_transaksi 
        SET status='Selesai', tgl_kembali_real=NOW()
        WHERE id_transaksi=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                // Update mobil jadi tersedia
                var cmdMobil = new MySqlCommand(@"
        UPDATE daftar_mobil 
        SET status='Tersedia' 
        WHERE id = (SELECT id_mobil FROM tbl_transaksi WHERE id_transaksi=@id)", conn);

                cmdMobil.Parameters.AddWithValue("@id", id);
                cmdMobil.ExecuteNonQuery();

                MessageBox.Show("Mobil berhasil dikembalikan!");
                LoadDataTransaksi();
            }
        }

        // ── Atur nama header dan visibilitas kolom DGV ────────────
        private void AturKolomDGV()
        {
            if (dgvTransaksi.Columns.Count == 0) return;

            // Pasang nama header yang ramah pengguna
            var headerMap = new Dictionary<string, string>
            {
                { "IdTransaksi",    "ID"              },
                { "Pelanggan",      "Pelanggan"       },
                { "Mobil",          "Mobil"           },
                { "TglSewa",        "Tgl Sewa"        },
                { "RencanaKembali", "Rencana Kembali" },
                { "Durasi",         "Durasi"          },
                { "TotalBiaya",     "Total Biaya"     },
                { "Status",         "Status"          },
                { "IdMobil",        "IdMobil"         }
            };

            foreach (var kv in headerMap)
            {
                if (dgvTransaksi.Columns[kv.Key] != null)
                    dgvTransaksi.Columns[kv.Key].HeaderText = kv.Value;
            }

            // Sembunyikan kolom IdMobil — hanya dipakai saat Batal
            if (dgvTransaksi.Columns["IdMobil"] != null)
                dgvTransaksi.Columns["IdMobil"].Visible = false;
        }

        // ── Hitung total otomatis ──────────────────────────────────
        private void HitungTotal()
        {
            // Ambil langsung object Mobil dari SelectedItem
            Mobil mobil = cboMobil.SelectedItem as Mobil;
            if (mobil == null) return;

            int durasi = (dtpTglKembali.Value.Date - dtpTglSewa.Value.Date).Days;
            if (durasi <= 0)
            {
                lblhargaPerHari.Text = "—";
                lblDurasi.Text = "—";
                lblTotalBiaya.Text = "—";
                return;
            }

            decimal total = mobil.harga * durasi;

            lblhargaPerHari.Text = "Rp " + mobil.harga.ToString("N0");
            lblDurasi.Text = durasi + " hari";
            lblTotalBiaya.Text = "Rp " + total.ToString("N0");
        }

        // ── Simpan Transaksi ───────────────────────────────────────
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cboPelanggan.SelectedItem == null)
            { MessageBox.Show("Pilih pelanggan terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cboMobil.SelectedItem == null)
            { MessageBox.Show("Pilih mobil terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int durasi = (dtpTglKembali.Value.Date - dtpTglSewa.Value.Date).Days;
            if (durasi <= 0)
            { MessageBox.Show("Tanggal kembali harus setelah tanggal sewa!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Ambil langsung dari SelectedItem — tidak perlu Convert.ToInt32
            Mobil mobil = cboMobil.SelectedItem as Mobil;
            Pelanggan pelanggan = cboPelanggan.SelectedItem as Pelanggan;
            if (mobil == null || pelanggan == null) return;

            decimal total = mobil.harga * durasi;

            string info = $"Pelanggan : {cboPelanggan.Text}\n" +
                          $"Mobil     : {cboMobil.Text}\n" +
                          $"Tgl Sewa  : {dtpTglSewa.Value:dd/MM/yyyy}\n" +
                          $"Kembali   : {dtpTglKembali.Value:dd/MM/yyyy}\n" +
                          $"Durasi    : {durasi} hari\n" +
                          $"Total     : Rp {total:N0}\n\nSimpan transaksi ini?";

            if (MessageBox.Show(info, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        try
                        {
                            string sqlInsert = @"
                                INSERT INTO tbl_transaksi
                                    (id_pelanggan, id_mobil, tgl_sewa, tgl_rencana_kembali,
                                     durasi, harga_per_hari, total_biaya, status, catatan)
                                VALUES
                                    (@pel, @mob, @ts, @tk, @dur, @harga, @total, 'Aktif', @cat)";

                            using (var cmd = new MySqlCommand(sqlInsert, conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@pel", pelanggan.id);
                                cmd.Parameters.AddWithValue("@mob", mobil.id);
                                cmd.Parameters.AddWithValue("@ts", dtpTglSewa.Value.Date);
                                cmd.Parameters.AddWithValue("@tk", dtpTglKembali.Value.Date);
                                cmd.Parameters.AddWithValue("@dur", durasi);
                                cmd.Parameters.Add("@harga", MySqlDbType.Decimal).Value = mobil.harga;
                                cmd.Parameters.AddWithValue("@total", total);
                                cmd.Parameters.AddWithValue("@cat", txtCatatan.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }

                            using (var cmd2 = new MySqlCommand(
                                "UPDATE daftar_mobil SET status='Disewa' WHERE id=@id", conn, tx))
                            {
                                cmd2.Parameters.AddWithValue("@id", mobil.id);
                                cmd2.ExecuteNonQuery();
                            }

                            tx.Commit();
                            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            LoadMobil();
                            LoadDataTransaksi();
                        }
                        catch { tx.Rollback(); throw; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Batalkan Transaksi (dari tabel) ───────────────────────
        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (dgvTransaksi.SelectedRows.Count == 0)
            { MessageBox.Show("Pilih baris transaksi yang ingin dibatalkan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var row = dgvTransaksi.SelectedRows[0];
            string status = row.Cells["Status"].Value?.ToString();
            int idTrx = Convert.ToInt32(row.Cells["IdTransaksi"].Value);
            int idMob = Convert.ToInt32(row.Cells["IdMobil"].Value);

            if (status != "Aktif")
            { MessageBox.Show("Hanya transaksi Aktif yang bisa dibatalkan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show($"Yakin batalkan transaksi ID #{idTrx}?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var c1 = new MySqlCommand(
                                "UPDATE tbl_transaksi SET status='Batal' WHERE id_transaksi=@id", conn, tx))
                            {
                                c1.Parameters.AddWithValue("@id", idTrx);
                                c1.ExecuteNonQuery();
                            }

                            using (var c2 = new MySqlCommand(
                                "UPDATE daftar_mobil SET status='Tersedia' WHERE id=@id", conn, tx))
                            {
                                c2.Parameters.AddWithValue("@id", idMob);
                                c2.ExecuteNonQuery();
                            }

                            tx.Commit();
                            MessageBox.Show("Transaksi berhasil dibatalkan!", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataTransaksi();
                            LoadMobil();
                        }
                        catch { tx.Rollback(); throw; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membatalkan:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Reset form ─────────────────────────────────────────────
        private void btnReset_Click(object sender, EventArgs e) => ResetForm();

        private void ResetForm()
        {
            cboPelanggan.SelectedIndex = -1;
            cboMobil.SelectedIndex = -1;
            dtpTglSewa.Value = DateTime.Today;
            dtpTglKembali.Value = DateTime.Today.AddDays(1);
            txtCatatan.Clear();
            lblhargaPerHari.Text = "—";
            lblDurasi.Text = "—";
            lblTotalBiaya.Text = "—";
        }

        // ── Pencarian ──────────────────────────────────────────────
        private void btnCari_Click(object sender, EventArgs e) => CariTransaksi();
        private void CariTransaksi() => LoadDataTransaksi(txtCari.Text.Trim());

        private void cboPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBatal_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTransaksi.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Pilih data terlebih dahulu!");
                return;
            }

            int id = Convert.ToInt32(dgvTransaksi.SelectedRows[0].Cells["IdTransaksi"].Value);
            string status = dgvTransaksi.SelectedRows[0].Cells["status"].Value.ToString();

            if (status == "Selesai")
            {
                MessageBox.Show("Transaksi ini sudah selesai!");
                return;
            }

            if (MessageBox.Show("Yakin mobil sudah dikembalikan?",
                "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

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
                LoadDataTransaksi();
            }
        }
    }
}