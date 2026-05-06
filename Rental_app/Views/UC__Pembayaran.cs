using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rental_app
{
    public partial class UC__Pembayaran : UserControl
    {
        // Simpan data transaksi yang sedang dipilih
        private int _idTransaksi = 0;
        private decimal _totalBiaya = 0;
        private string _namaPelanggan = "";
        private string _namaMobil = "";
        private string _tglSewa = "";
        private string _durasi = "";
        private int _idPembayaran = 0; // ID pembayaran terakhir disimpan (untuk cetak)

        public UC__Pembayaran()
        {
            InitializeComponent();
            // ✅ FIX BUG 1: Daftarkan Load hanya sekali di sini
            this.Load += UC__Pembayaran_Load;
        }

        // ── Load awal ─────────────────────────────────────────
        private void UC__Pembayaran_Load(object sender, EventArgs e)
        {
            // Daftarkan semua event (Load TIDAK didaftarkan lagi di sini)
            btnCariTrx.Click += btnCariTrx_Click;
            btnSimpan.Click += btnSimpan_Click;
            btnCetak.Click += btnCetak_Click;
            btnReset.Click += btnReset_Click;
            btnCari.Click += (s, ev) => LoadRiwayatPembayaran(txtCari.Text.Trim());
            btnRefresh.Click += (s, ev) => LoadRiwayatPembayaran();
            cboTransaksi.SelectedIndexChanged += cboTransaksi_SelectedIndexChanged;
            cboStatusBayar.SelectedIndexChanged += cboStatusBayar_SelectedIndexChanged;
            txtCariTrx.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Enter) LoadTransaksiAktif(txtCariTrx.Text.Trim()); };
            txtCari.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Enter) LoadRiwayatPembayaran(txtCari.Text.Trim()); };
            //dgvPembayaran.Columns["IdBayar"].Visible = false;

            LoadTransaksiAktif();
            LoadRiwayatPembayaran();
            UpdateVisibilitasInput();
        }

        // ── Load transaksi aktif ke ComboBox ─────────────────
        private void LoadTransaksiAktif(string keyword = "")
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    string sql = @"
                        SELECT t.id_transaksi,
                               CONCAT('#', t.id_transaksi, ' - ', p.nama, ' - ', m.nama_mobil,
                                      ' (Rp ', FORMAT(t.total_biaya,0), ')') AS info
                        FROM tbl_transaksi t
                        JOIN pelanggan p ON t.id_pelanggan = p.id
                        JOIN daftar_mobil      m ON t.id_mobil      = m.id
                        WHERE t.status = 'Aktif'
                          AND (p.nama LIKE @kw OR m.nama_mobil LIKE @kw)
                        ORDER BY t.created_at ASC";

                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    var listTransaksi = new List<TransaksiItem>();

                    while (reader.Read())
                    {
                        listTransaksi.Add(new TransaksiItem
                        {
                            IdTransaksi = Convert.ToInt32(reader["id_transaksi"]),
                            Info = reader["info"].ToString()
                        });
                    }

                    cboTransaksi.DataSource = listTransaksi;
                    cboTransaksi.DisplayMember = "Info"; // Diganti dari id_transaksi agar info text tampil
                    cboTransaksi.ValueMember = "IdTransaksi";
                    cboTransaksi.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load transaksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Saat transaksi dipilih → tampilkan detail ────────
        private void cboTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTransaksi.SelectedValue == null) return;

            // Pastikan tidak error cast ketika reset DataSource
            if (int.TryParse(cboTransaksi.SelectedValue.ToString(), out int idTrx))
            {
                _idTransaksi = idTrx;
                TampilkanDetailTransaksi(_idTransaksi);
            }
        }

        private void TampilkanDetailTransaksi(int idTrx)
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    string sql = @"
                        SELECT p.nama, m.nama_mobil, m.nomor_plat,
                               DATE_FORMAT(t.tgl_sewa,'%d/%m/%Y') AS tgl_sewa,
                               CONCAT(t.durasi,' hari') AS durasi,
                               t.total_biaya
                        FROM tbl_transaksi t
                        JOIN pelanggan p ON t.id_pelanggan = p.id
                        JOIN daftar_mobil      m ON t.id_mobil      = m.id
                        WHERE t.id_transaksi = @id";

                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idTrx);
                    conn.Open();
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        _namaPelanggan = reader["nama"].ToString();
                        _namaMobil = $"{reader["nama_mobil"]} ({reader["nomor_plat"]})";
                        _tglSewa = reader["tgl_sewa"].ToString();
                        _durasi = reader["durasi"].ToString();
                        _totalBiaya = Convert.ToDecimal(reader["total_biaya"]);

                        lblValPelanggan.Text = _namaPelanggan;
                        lblValMobil.Text = _namaMobil;
                        lblValTglSewa.Text = _tglSewa;
                        lblValDurasi.Text = _durasi;
                        lblValTotal.Text = "Rp " + _totalBiaya.ToString("N0");

                        // Auto-isi jumlah lunas jika status Lunas
                        if (cboStatusBayar.SelectedItem?.ToString() == "Lunas")
                            txtJumlahLunas.Text = _totalBiaya.ToString("N0");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load detail transaksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Atur visibilitas field DP/Lunas ──────────────────
        private void cboStatusBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibilitasInput();
            if (cboStatusBayar.SelectedItem?.ToString() == "Lunas" && _totalBiaya > 0)
                txtJumlahLunas.Text = _totalBiaya.ToString("N0");
        }

        private void UpdateVisibilitasInput()
        {
            string status = cboStatusBayar.SelectedItem?.ToString() ?? "";
            bool isDP = status == "DP";
            bool isLunas = status == "Lunas";

            lblJumlahDP.Visible = isDP;
            txtJumlahDP.Visible = isDP;
            lblJumlahLunas.Visible = isLunas || isDP;
            txtJumlahLunas.Visible = isLunas || isDP;
        }

        // ── Cari transaksi ────────────────────────────────────
        private void btnCariTrx_Click(object sender, EventArgs e)
        {
            LoadTransaksiAktif(txtCariTrx.Text.Trim());
        }

        // ── Simpan Pembayaran ─────────────────────────────────
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_idTransaksi == 0)
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = cboStatusBayar.SelectedItem?.ToString() ?? "";
            if (status == "Belum Bayar")
            {
                MessageBox.Show("Pilih status pembayaran selain 'Belum Bayar'!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal dp = 0;
            decimal lunas = 0;
            if (!decimal.TryParse(txtJumlahDP.Text.Replace(",", "").Replace(".", ""), out dp))
                dp = 0;
            if (!decimal.TryParse(txtJumlahLunas.Text.Replace(",", "").Replace(".", ""), out lunas))
                lunas = 0;

            // Validasi jumlah
            if (status == "DP" && dp <= 0)
            {
                MessageBox.Show("Isi jumlah DP!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (status == "Lunas" && lunas <= 0)
            {
                MessageBox.Show("Isi jumlah pelunasan!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string konfirmasi = $"Simpan pembayaran?\n\n" +
                                $"Transaksi : #{_idTransaksi}\n" +
                                $"Pelanggan : {_namaPelanggan}\n" +
                                $"Total     : Rp {_totalBiaya:N0}\n" +
                                $"Metode    : {cboMetode.SelectedItem}\n" +
                                $"Status    : {status}";

            if (MessageBox.Show(konfirmasi, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        try
                        {
                            // Cek apakah sudah ada pembayaran sebelumnya
                            var cmdCek = new MySqlCommand("SELECT COUNT(*) FROM tbl_pembayaran WHERE id_transaksi=@id", conn, tx);
                            cmdCek.Parameters.AddWithValue("@id", _idTransaksi);
                            int sudahAda = Convert.ToInt32(cmdCek.ExecuteScalar());

                            if (sudahAda > 0)
                            {
                                // Update pembayaran yang ada
                                var cmdUpd = new MySqlCommand(@"
                                    UPDATE tbl_pembayaran SET 
                                        metode_bayar=@met, jumlah_dp=@dp, 
                                        jumlah_lunas=@lns, status_bayar=@st, 
                                        tgl_bayar=NOW(), catatan=@cat 
                                    WHERE id_transaksi=@id", conn, tx);
                                cmdUpd.Parameters.AddWithValue("@met", cboMetode.SelectedItem.ToString());
                                cmdUpd.Parameters.AddWithValue("@dp", dp);
                                cmdUpd.Parameters.AddWithValue("@lns", lunas);
                                cmdUpd.Parameters.AddWithValue("@st", status);
                                cmdUpd.Parameters.AddWithValue("@cat", txtCatatanBayar.Text.Trim());
                                cmdUpd.Parameters.AddWithValue("@id", _idTransaksi);
                                cmdUpd.ExecuteNonQuery();
                            }
                            else
                            {
                                // Insert pembayaran baru
                                var cmdIns = new MySqlCommand(@"
                                    INSERT INTO tbl_pembayaran 
                                        (id_transaksi, metode_bayar, jumlah_dp, 
                                         jumlah_lunas, status_bayar, tgl_bayar, catatan)
                                    VALUES (@id, @met, @dp, @lns, @st, NOW(), @cat)", conn, tx);
                                cmdIns.Parameters.AddWithValue("@id", _idTransaksi);
                                cmdIns.Parameters.AddWithValue("@met", cboMetode.SelectedItem.ToString());
                                cmdIns.Parameters.AddWithValue("@dp", dp);
                                cmdIns.Parameters.AddWithValue("@lns", lunas);
                                cmdIns.Parameters.AddWithValue("@st", status);
                                cmdIns.Parameters.AddWithValue("@cat", txtCatatanBayar.Text.Trim());
                                cmdIns.ExecuteNonQuery();
                            }

                            // Jika Lunas → update status transaksi jadi Selesai
                            //if (status == "Lunas")
                            //{
                            //    var cmdTrx = new MySqlCommand("UPDATE tbl_transaksi SET status='Selesai' WHERE id_transaksi=@id", conn, tx);
                            //    cmdTrx.Parameters.AddWithValue("@id", _idTransaksi);
                            //    cmdTrx.ExecuteNonQuery();

                            //    // Update status mobil → Tersedia
                            //    var cmdMobil = new MySqlCommand(@"
                            //        UPDATE daftar_mobil SET status='Tersedia' 
                            //        WHERE id=(SELECT id_mobil FROM tbl_transaksi WHERE id_transaksi=@id)", conn, tx);
                            //    cmdMobil.Parameters.AddWithValue("@id", _idTransaksi);
                            //    cmdMobil.ExecuteNonQuery();
                            //}

                            // Ambil id_pembayaran untuk cetak
                            var cmdGetId = new MySqlCommand("SELECT id_pembayaran FROM tbl_pembayaran WHERE id_transaksi=@id", conn, tx);
                            cmdGetId.Parameters.AddWithValue("@id", _idTransaksi);
                            _idPembayaran = Convert.ToInt32(cmdGetId.ExecuteScalar());

                            tx.Commit();

                            MessageBox.Show("Pembayaran berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tanya langsung cetak kwitansi?
                            if (MessageBox.Show("Cetak kwitansi sekarang?", "Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                CetakKwitansi();

                            ResetForm();
                            LoadTransaksiAktif();
                            LoadRiwayatPembayaran();
                        }
                        catch { tx.Rollback(); throw; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pembayaran:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Load riwayat pembayaran (tabel kanan) ────────────
        private void LoadRiwayatPembayaran(string keyword = "")
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    string sql = @"
                        SELECT 
                            b.id_pembayaran                          AS 'ID Bayar',
                            CONCAT('#',t.id_transaksi)               AS 'ID Trx',
                            p.nama                                   AS 'Pelanggan',
                            m.nama_mobil                             AS 'Mobil',
                            b.metode_bayar                           AS 'Metode',
                            CONCAT('Rp ',FORMAT(t.total_biaya,0))    AS 'Total Sewa',
                            CONCAT('Rp ',FORMAT(b.jumlah_dp,0))      AS 'DP',
                            CONCAT('Rp ',FORMAT(b.jumlah_lunas,0))   AS 'Lunas',
                            b.status_bayar                           AS 'Status',
                            DATE_FORMAT(b.tgl_bayar,'%d/%m/%Y %H:%i') AS 'Tgl Bayar'
                        FROM tbl_pembayaran b
                        JOIN tbl_transaksi t ON b.id_transaksi = t.id_transaksi
                        JOIN pelanggan p ON t.id_pelanggan = p.id
                        JOIN daftar_mobil     m ON t.id_mobil     = m.id
                        WHERE p.nama LIKE @kw OR m.nama_mobil LIKE @kw
                        ORDER BY b.tgl_bayar ASC";

                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    var listRiwayat = new List<RiwayatPembayaranItem>();

                    while (reader.Read())
                    {
                        listRiwayat.Add(new RiwayatPembayaranItem
                        {
                            IdBayar = reader["ID Bayar"].ToString(),
                            IdTrx = reader["ID Trx"].ToString(),
                            Pelanggan = reader["Pelanggan"].ToString(),
                            Mobil = reader["Mobil"].ToString(),
                            Metode = reader["Metode"].ToString(),
                            TotalSewa = reader["Total Sewa"].ToString(),
                            Dp = reader["DP"].ToString(),
                            Lunas = reader["Lunas"].ToString(),
                            Status = reader["Status"].ToString(),
                            TglBayar = reader["Tgl Bayar"].ToString()
                        });
                    }
                    // ✅ FIX BUG 2: Reset DataSource & kolom dulu sebelum bind ulang
                    // agar kolom tidak dobel setiap kali method ini dipanggil
                    dgvPembayaran.DataSource = null;
                    dgvPembayaran.Columns.Clear();
                    dgvPembayaran.AutoGenerateColumns = true;
                    dgvPembayaran.DataSource = listRiwayat;

                    // Warna status
                    foreach (DataGridViewRow row in dgvPembayaran.Rows)
                    {
                        string st = row.Cells["Status"].Value?.ToString();
                        if (st == "Lunas") row.DefaultCellStyle.BackColor = Color.FromArgb(232, 248, 232);
                        else if (st == "DP") row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load riwayat:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Cetak Kwitansi ────────────────────────────────────
        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (_idPembayaran == 0 && _idTransaksi == 0)
            {
                MessageBox.Show("Pilih transaksi / simpan pembayaran dulu sebelum cetak!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CetakKwitansi();
        }

        private void CetakKwitansi()
        {
            KwitansiData dataKwitansi = null;
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    string sql = @"
                        SELECT b.id_pembayaran, b.metode_bayar, b.jumlah_dp, 
                               b.jumlah_lunas, b.status_bayar, b.tgl_bayar,
                               p.nama, p.no_hp, p.alamat, 
                               m.nama_mobil, m.nomor_plat, 
                               t.tgl_sewa, t.tgl_rencana_kembali, 
                               t.durasi, t.harga_per_hari, t.total_biaya
                        FROM tbl_pembayaran b
                        JOIN tbl_transaksi t ON b.id_transaksi = t.id_transaksi
                        JOIN pelanggan p ON t.id_pelanggan = p.id
                        JOIN daftar_mobil     m ON t.id_mobil     = m.id
                        WHERE b.id_transaksi = @id
                        ORDER BY b.tgl_bayar DESC LIMIT 1";

                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _idTransaksi);

                    conn.Open();
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dataKwitansi = new KwitansiData
                        {
                            IdPembayaran = reader["id_pembayaran"].ToString(),
                            TglBayar = Convert.ToDateTime(reader["tgl_bayar"]),
                            Nama = reader["nama"].ToString(),
                            NoHp = reader["no_hp"].ToString(),
                            NamaMobil = reader["nama_mobil"].ToString(),
                            PlatNomor = reader["nomor_plat"].ToString(),
                            TglSewa = Convert.ToDateTime(reader["tgl_sewa"]),
                            TglRencanaKembali = Convert.ToDateTime(reader["tgl_rencana_kembali"]),
                            Durasi = reader["durasi"].ToString(),
                            HargaPerHari = Convert.ToDecimal(reader["harga_per_hari"]),
                            TotalBiaya = Convert.ToDecimal(reader["total_biaya"]),
                            JumlahDp = Convert.ToDecimal(reader["jumlah_dp"]),
                            JumlahLunas = Convert.ToDecimal(reader["jumlah_lunas"]),
                            StatusBayar = reader["status_bayar"].ToString(),
                            MetodeBayar = reader["metode_bayar"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data kwitansi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataKwitansi == null)
            {
                MessageBox.Show("Data pembayaran tidak ditemukan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat PrintDocument untuk print kwitansi
            var pd = new PrintDocument();

            pd.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                float x = 40;
                float y = 20;
                float lw2 = 300; // lebar area

                var fontJudul = new Font("Segoe UI", 14, FontStyle.Bold);
                var fontSub = new Font("Segoe UI", 9);
                var fontBold = new Font("Segoe UI", 9, FontStyle.Bold);
                var fontKecil = new Font("Segoe UI", 8);
                var brushHitam = Brushes.Black;
                var brushAbu = Brushes.Gray;
                var brushHijau = new SolidBrush(Color.FromArgb(40, 167, 69));

                // Header kwitansi
                g.DrawString("KWITANSI RENTAL MOBIL", fontJudul, brushHijau, x, y);
                y += 24;
                g.DrawString("Jl. Contoh No. 1, Kota Anda  |  Telp: 0812-xxxx-xxxx", fontKecil, brushAbu, x, y);
                y += 20;
                g.DrawLine(Pens.LightGray, x, y, x + lw2 + 60, y);
                y += 10;

                // Nomor & tanggal
                g.DrawString($"No. Kwitansi : KWT-{dataKwitansi.IdPembayaran.PadLeft(4, '0')}", fontBold, brushHitam, x, y);
                g.DrawString($"Tanggal      : {dataKwitansi.TglBayar.ToString("dd/MM/yyyy HH:mm")}", fontSub, brushHitam, x + lw2 - 50, y);
                y += 20;
                g.DrawLine(Pens.LightGray, x, y, x + lw2 + 60, y);
                y += 14;

                // Data pelanggan
                g.DrawString("DATA PELANGGAN", fontBold, brushHijau, x, y); y += 18;
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Nama", dataKwitansi.Nama);
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "No HP", dataKwitansi.NoHp);
                y += 6;
                g.DrawLine(Pens.LightGray, x, y, x + lw2 + 60, y);
                y += 14;

                // Data sewa
                g.DrawString("DETAIL SEWA", fontBold, brushHijau, x, y); y += 18;
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Mobil", $"{dataKwitansi.NamaMobil} ({dataKwitansi.PlatNomor})");
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Tgl Sewa", dataKwitansi.TglSewa.ToString("dd/MM/yyyy"));
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Tgl Kembali", dataKwitansi.TglRencanaKembali.ToString("dd/MM/yyyy"));
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Durasi", dataKwitansi.Durasi + " hari");
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Harga/Hari", "Rp " + dataKwitansi.HargaPerHari.ToString("N0"));
                y += 6;
                g.DrawLine(Pens.Black, x, y, x + lw2 + 60, y);
                y += 10;

                // Total
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "TOTAL BIAYA", "Rp " + dataKwitansi.TotalBiaya.ToString("N0"));
                if (dataKwitansi.JumlahDp > 0)
                    TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "DP Dibayar", "Rp " + dataKwitansi.JumlahDp.ToString("N0"));
                if (dataKwitansi.JumlahLunas > 0)
                    TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Lunas", "Rp " + dataKwitansi.JumlahLunas.ToString("N0"));

                TulisBarisKwitansi(g, fontSub, fontBold, brushHijau, x, ref y, "Status Bayar", dataKwitansi.StatusBayar);
                TulisBarisKwitansi(g, fontSub, fontBold, brushHitam, x, ref y, "Metode", dataKwitansi.MetodeBayar);

                y += 10;
                g.DrawLine(Pens.LightGray, x, y, x + lw2 + 60, y);
                y += 20;

                // Tanda tangan
                g.DrawString("Petugas,", fontSub, brushHitam, x + lw2 - 20, y);
                y += 50;
                g.DrawString("(________________________)", fontSub, brushHitam, x + lw2 - 40, y);
                y += 18;
                g.DrawString("Terima kasih atas kepercayaan Anda!", fontKecil, brushAbu, x, y);

                fontJudul.Dispose(); fontSub.Dispose(); fontBold.Dispose(); fontKecil.Dispose();
                brushHijau.Dispose();
            };

            // Preview sebelum print
            var preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 700,
                Height = 600,
                Text = "Preview Kwitansi",
                StartPosition = FormStartPosition.CenterParent
            };
            preview.ShowDialog();
        }

        private void TulisBarisKwitansi(Graphics g, Font fontLabel, Font fontVal,
            Brush brushVal, float x, ref float y, string label, string nilai)
        {
            g.DrawString(label + " :", fontLabel, Brushes.Gray, x, y);
            g.DrawString(nilai, fontVal, brushVal, x + 130, y);
            y += 18;
        }

        // ── Reset Form ────────────────────────────────────────
        private void btnReset_Click(object sender, EventArgs e) => ResetForm();

        private void ResetForm()
        {
            cboTransaksi.SelectedIndex = -1;
            cboMetode.SelectedIndex = 0;
            cboStatusBayar.SelectedIndex = 0;
            txtJumlahDP.Text = "0";
            txtJumlahLunas.Text = "0";
            txtCatatanBayar.Clear();
            lblValPelanggan.Text = "—";
            lblValMobil.Text = "—";
            lblValTglSewa.Text = "—";
            lblValDurasi.Text = "—";
            lblValTotal.Text = "—";
            _idTransaksi = 0;
            _totalBiaya = 0;
            _idPembayaran = 0;
            UpdateVisibilitasInput();
        }

        private void grpInfoTransaksi_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    // ───────────────────────────────────────────────────────────
    // MODEL CLASS BANTUAN (Letakan di bagian bawah namespace / file yang sama)
    // ───────────────────────────────────────────────────────────

    public class TransaksiItem
    {
        public int IdTransaksi { get; set; }
        public string Info { get; set; }
    }

    public class RiwayatPembayaranItem
    {
        // Atribut DisplayName otomatis merubah header text di DataGridView
        [DisplayName("ID Bayar")]
        public string IdBayar { get; set; }
        [DisplayName("ID Trx")]
        public string IdTrx { get; set; }
        [DisplayName("Pelanggan")]
        public string Pelanggan { get; set; }
        [DisplayName("Mobil")]
        public string Mobil { get; set; }
        [DisplayName("Metode")]
        public string Metode { get; set; }
        [DisplayName("Total Sewa")]
        public string TotalSewa { get; set; }
        [DisplayName("DP")]
        public string Dp { get; set; }
        [DisplayName("Lunas")]
        public string Lunas { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        [DisplayName("Tgl Bayar")]
        public string TglBayar { get; set; }
    }

    public class KwitansiData
    {
        public string IdPembayaran { get; set; }
        public string MetodeBayar { get; set; }
        public decimal JumlahDp { get; set; }
        public decimal JumlahLunas { get; set; }
        public string StatusBayar { get; set; }
        public DateTime TglBayar { get; set; }
        public string Nama { get; set; }
        public string NoHp { get; set; }
        public string NamaMobil { get; set; }
        public string PlatNomor { get; set; }
        public DateTime TglSewa { get; set; }
        public DateTime TglRencanaKembali { get; set; }
        public string Durasi { get; set; }
        public decimal HargaPerHari { get; set; }
        public decimal TotalBiaya { get; set; }
    }
}