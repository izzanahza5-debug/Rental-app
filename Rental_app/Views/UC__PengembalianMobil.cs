using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rental_app
{
    public partial class UC__PengembalianMobil : UserControl
    {
        private const decimal PERSEN_DENDA = 0.5m;

        private List<ItemTransaksiAktif> _listTransaksiAktif = new List<ItemTransaksiAktif>();
        private List<ItemPengembalian> _listPengembalian = new List<ItemPengembalian>();
        private ItemTransaksiAktif _selectedTransaksi = null;

        public UC__PengembalianMobil()
        {
            InitializeComponent();

            // ✅ FIX BUG 2: Daftarkan Load hanya SEKALI di sini
            // Jangan daftarkan lagi di DaftarkanEvent()
            this.Load += UC__PengembalianMobil_Load;
        }

        // ══════════════════════════════════════════════════════
        //  LOAD AWAL
        // ══════════════════════════════════════════════════════
        private void UC__PengembalianMobil_Load(object sender, EventArgs e)
        {
            DaftarkanEvent();
            LoadTransaksiAktif();
            LoadRiwayatPengembalian();
            BersihkanInfoSewa();
            BersihkanKalkulasi();
        }

        private void DaftarkanEvent()
        {
            // ✅ FIX BUG 2: Hapus baris "this.Load += ..." dari sini
            cboTransaksi.SelectedIndexChanged += CboTransaksi_SelectedIndexChanged;
            dtpTglAktual.ValueChanged += DtpTglAktual_ValueChanged;
            btnProses.Click += BtnProses_Click;
            btnReset.Click += (s, ev) => ResetForm();
            btnCari.Click += (s, ev) => TampilkanDGV();
            btnRefresh.Click += (s, ev) =>
            {
                LoadTransaksiAktif();
                LoadRiwayatPengembalian();
            };
            txtCari.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Enter) TampilkanDGV(); };
            cboFilterKondisi.SelectedIndexChanged += (s, ev) => TampilkanDGV();
        }

        // ══════════════════════════════════════════════════════
        //  LOAD DATA DARI DATABASE
        // ══════════════════════════════════════════════════════
        private void LoadTransaksiAktif()
        {
            // Lepas event sementara agar tidak trigger saat DataSource diganti
            cboTransaksi.SelectedIndexChanged -= CboTransaksi_SelectedIndexChanged;

            _listTransaksiAktif.Clear();

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            t.id_transaksi,
                            t.id_mobil,
                            p.nama                                            AS nama_pelanggan,
                            m.nama_mobil,
                            m.nomor_plat,
                            m.harga,
                            DATE_FORMAT(t.tgl_sewa,'%d/%m/%Y')               AS tgl_sewa,
                            DATE_FORMAT(t.tgl_rencana_kembali,'%d/%m/%Y')    AS tgl_rencana_kembali,
                            t.total_biaya
                        FROM tbl_transaksi t
                        JOIN pelanggan    p ON t.id_pelanggan = p.id
                        JOIN daftar_mobil m ON t.id_mobil     = m.id
                        WHERE t.status = 'Aktif'
                        ORDER BY t.tgl_rencana_kembali ASC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _listTransaksiAktif.Add(new ItemTransaksiAktif
                            {
                                IdTransaksi = reader.GetInt32("id_transaksi"),
                                IdMobil = reader.GetInt32("id_mobil"),
                                NamaPelanggan = reader.GetString("nama_pelanggan"),
                                NamaMobil = reader.GetString("nama_mobil"),
                                PlatNomor = reader.GetString("nomor_plat"),
                                HargaPerHari = reader.GetDecimal("harga"),
                                TglSewa = reader.GetString("tgl_sewa"),
                                TglRencanaKembali = reader.GetString("tgl_rencana_kembali"),
                                TotalBiaya = reader.GetDecimal("total_biaya"),
                            });
                        }
                    }
                }

                cboTransaksi.DataSource = null;
                cboTransaksi.DataSource = _listTransaksiAktif;
                cboTransaksi.DisplayMember = nameof(ItemTransaksiAktif.IdTransaksi);

                // ✅ FIX BUG 1: Cek dulu apakah list tidak kosong sebelum set SelectedIndex
                cboTransaksi.SelectedIndex = _listTransaksiAktif.Count > 0 ? -1 : -1;
                // Selalu -1 agar user memilih manual, tidak auto-pilih item pertama
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load transaksi aktif:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Pasang kembali event setelah DataSource selesai diset
                cboTransaksi.SelectedIndexChanged += CboTransaksi_SelectedIndexChanged;
            }
        }

        private void LoadRiwayatPengembalian()
        {
            _listPengembalian.Clear();

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            pg.id_pengembalian,
                            pg.id_transaksi,
                            p.nama                                            AS nama_pelanggan,
                            CONCAT(m.nama_mobil,' (',m.nomor_plat,')')        AS nama_mobil,
                            DATE_FORMAT(t.tgl_rencana_kembali,'%d/%m/%Y')    AS tgl_rencana_kembali,
                            DATE_FORMAT(pg.tgl_kembali_aktual,'%d/%m/%Y')    AS tgl_kembali_aktual,
                            pg.telat_hari,
                            pg.total_denda,
                            pg.kondisi_mobil,
                            IFNULL(pg.catatan_kerusakan,'')                   AS catatan_kerusakan,
                            DATE_FORMAT(pg.created_at,'%d/%m/%Y %H:%i')      AS created_at
                        FROM tbl_pengembalian pg
                        JOIN tbl_transaksi t  ON pg.id_transaksi = t.id_transaksi
                        JOIN pelanggan     p  ON t.id_pelanggan  = p.id
                        JOIN daftar_mobil  m  ON t.id_mobil      = m.id
                        ORDER BY pg.created_at DESC";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _listPengembalian.Add(new ItemPengembalian
                            {
                                IdPengembalian = reader.GetInt32("id_pengembalian"),
                                IdTransaksi = reader.GetInt32("id_transaksi"),
                                NamaPelanggan = reader.GetString("nama_pelanggan"),
                                NamaMobil = reader.GetString("nama_mobil"),
                                TglRencanaKembali = reader.GetString("tgl_rencana_kembali"),
                                TglKembaliAktual = reader.GetString("tgl_kembali_aktual"),
                                TelatHari = reader.GetInt32("telat_hari"),
                                TotalDenda = reader.GetDecimal("total_denda"),
                                KondisiMobil = reader.GetString("kondisi_mobil"),
                                CatatanKerusakan = reader.GetString("catatan_kerusakan"),
                                CreatedAt = reader.GetString("created_at"),
                            });
                        }
                    }
                }

                TampilkanDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load riwayat pengembalian:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════════════════
        //  TAMPILKAN KE DATAGRIDVIEW
        // ══════════════════════════════════════════════════════
        private void TampilkanDGV()
        {
            string keyword = txtCari.Text.Trim().ToLower();
            string filterKondisi = cboFilterKondisi.SelectedItem?.ToString() ?? "Semua Kondisi";

            var filtered = _listPengembalian
                .Where(x =>
                    (string.IsNullOrEmpty(keyword) ||
                     x.NamaPelanggan.ToLower().Contains(keyword) ||
                     x.NamaMobil.ToLower().Contains(keyword))
                    &&
                    (filterKondisi == "Semua Kondisi" || x.KondisiMobil == filterKondisi))
                .ToList();

            dgvPengembalian.Rows.Clear();
            dgvPengembalian.Columns.Clear();

            dgvPengembalian.Columns.Add("ID", "ID");
            dgvPengembalian.Columns.Add("Pelanggan", "Pelanggan");
            dgvPengembalian.Columns.Add("Mobil", "Mobil");
            dgvPengembalian.Columns.Add("Rencana", "Rencana Kembali");
            dgvPengembalian.Columns.Add("Aktual", "Tgl Kembali");
            dgvPengembalian.Columns.Add("Telat", "Keterlambatan");
            dgvPengembalian.Columns.Add("Denda", "Total Denda");
            dgvPengembalian.Columns.Add("Kondisi", "Kondisi Mobil");
            dgvPengembalian.Columns.Add("Catatan", "Catatan");

            dgvPengembalian.Columns["ID"].Width = 50;
            dgvPengembalian.Columns["Pelanggan"].Width = 150;
            dgvPengembalian.Columns["Mobil"].Width = 160;
            dgvPengembalian.Columns["Rencana"].Width = 110;
            dgvPengembalian.Columns["Aktual"].Width = 100;
            dgvPengembalian.Columns["Telat"].Width = 110;
            dgvPengembalian.Columns["Denda"].Width = 110;
            dgvPengembalian.Columns["Kondisi"].Width = 110;
            dgvPengembalian.Columns["Catatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (var item in filtered)
            {
                int rowIdx = dgvPengembalian.Rows.Add(
                    item.IdPengembalian,
                    item.NamaPelanggan,
                    item.NamaMobil,
                    item.TglRencanaKembali,
                    item.TglKembaliAktual,
                    item.TelatHariFormatted,
                    item.TotalDendaFormatted,
                    item.KondisiMobil,
                    item.CatatanKerusakan);

                var row = dgvPengembalian.Rows[rowIdx];
                if (item.KondisiMobil == "Rusak Berat") row.DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
                else if (item.KondisiMobil == "Rusak Ringan") row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
                else if (item.TelatHari > 0) row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205);
                else row.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);

                if (item.TotalDenda > 0)
                    row.Cells["Denda"].Style.ForeColor = Color.FromArgb(183, 28, 28);
            }
        }

        // ══════════════════════════════════════════════════════
        //  EVENT: PILIH TRANSAKSI DI COMBOBOX
        // ══════════════════════════════════════════════════════
        private void CboTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTransaksi = cboTransaksi.SelectedItem as ItemTransaksiAktif;

            if (_selectedTransaksi == null)
            {
                BersihkanInfoSewa();
                BersihkanKalkulasi();
                return;
            }

            lblValPelanggan.Text = _selectedTransaksi.NamaPelanggan;
            lblValMobil.Text = $"{_selectedTransaksi.NamaMobil} ({_selectedTransaksi.PlatNomor})";
            lblValTglSewa.Text = _selectedTransaksi.TglSewa;
            lblValRencana.Text = _selectedTransaksi.TglRencanaKembali;
            lblValTotalBiaya.Text = "Rp " + _selectedTransaksi.TotalBiaya.ToString("N0");

            DateTime rencana = DateTime.ParseExact(
                _selectedTransaksi.TglRencanaKembali, "dd/MM/yyyy", null);
            lblValRencana.ForeColor = rencana.Date < DateTime.Today
                ? Color.FromArgb(183, 28, 28)
                : Color.FromArgb(30, 30, 30);

            HitungDenda();
        }

        // ══════════════════════════════════════════════════════
        //  HITUNG DENDA OTOMATIS
        // ══════════════════════════════════════════════════════
        private void DtpTglAktual_ValueChanged(object sender, EventArgs e) => HitungDenda();

        private void HitungDenda()
        {
            if (_selectedTransaksi == null) return;

            DateTime rencana = DateTime.ParseExact(
                _selectedTransaksi.TglRencanaKembali, "dd/MM/yyyy", null);
            int telatHari = (dtpTglAktual.Value.Date - rencana.Date).Days;

            if (telatHari <= 0)
            {
                lblValTelat.Text = "Tepat Waktu";
                lblValTelat.ForeColor = Color.FromArgb(21, 128, 61);
                lblValDenda.Text = "—";
                lblValTotalDenda.Text = "Rp 0";
                lblValTotalDenda.ForeColor = Color.FromArgb(108, 117, 125);
            }
            else
            {
                decimal dendaPerHari = _selectedTransaksi.HargaPerHari * PERSEN_DENDA;
                decimal totalDenda = dendaPerHari * telatHari;

                lblValTelat.Text = telatHari + " hari";
                lblValTelat.ForeColor = Color.FromArgb(183, 28, 28);
                lblValDenda.Text = "Rp " + dendaPerHari.ToString("N0") + " / hari";
                lblValTotalDenda.Text = "Rp " + totalDenda.ToString("N0");
                lblValTotalDenda.ForeColor = Color.FromArgb(183, 28, 28);
            }
        }

        // ══════════════════════════════════════════════════════
        //  PROSES PENGEMBALIAN
        // ══════════════════════════════════════════════════════
        private void BtnProses_Click(object sender, EventArgs e)
        {
            if (_selectedTransaksi == null)
            {
                MessageBox.Show("Pilih transaksi terlebih dahulu!",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime rencana = DateTime.ParseExact(
                _selectedTransaksi.TglRencanaKembali, "dd/MM/yyyy", null);
            DateTime aktual = dtpTglAktual.Value.Date;
            int telatHari = Math.Max(0, (aktual - rencana.Date).Days);
            decimal dendaPerHari = _selectedTransaksi.HargaPerHari * PERSEN_DENDA;
            decimal totalDenda = dendaPerHari * telatHari;
            string kondisi = cboKondisi.SelectedItem?.ToString() ?? "Baik";

            string info =
                $"Pelanggan     : {_selectedTransaksi.NamaPelanggan}\n" +
                $"Mobil         : {_selectedTransaksi.NamaMobil}\n" +
                $"Tgl Kembali   : {aktual:dd/MM/yyyy}\n" +
                $"Keterlambatan : {(telatHari > 0 ? telatHari + " hari" : "Tepat Waktu")}\n" +
                $"Total Denda   : Rp {totalDenda:N0}\n" +
                $"Kondisi       : {kondisi}\n\n" +
                "Proses pengembalian ini?";

            if (MessageBox.Show(info, "Konfirmasi Pengembalian",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
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
                            // 1. Insert tbl_pengembalian
                            string sqlInsert = @"
                                INSERT INTO tbl_pengembalian
                                    (id_transaksi, tgl_kembali_aktual, telat_hari,
                                     denda_per_hari, total_denda, kondisi_mobil, catatan_kerusakan)
                                VALUES
                                    (@idTrx, @tglAktual, @telat,
                                     @dendaPerHari, @totalDenda, @kondisi, @catatan)";

                            using (var cmd = new MySqlCommand(sqlInsert, conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@idTrx", _selectedTransaksi.IdTransaksi);
                                cmd.Parameters.AddWithValue("@tglAktual", aktual);
                                cmd.Parameters.AddWithValue("@telat", telatHari);
                                cmd.Parameters.AddWithValue("@dendaPerHari", telatHari > 0 ? dendaPerHari : 0);
                                cmd.Parameters.AddWithValue("@totalDenda", totalDenda);
                                cmd.Parameters.AddWithValue("@kondisi", kondisi);
                                cmd.Parameters.AddWithValue("@catatan", txtCatatan.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }

                            // 2. Update status transaksi → Selesai
                            using (var cmd2 = new MySqlCommand(
                                "UPDATE tbl_transaksi SET status='Selesai' WHERE id_transaksi=@id", conn, tx))
                            {
                                cmd2.Parameters.AddWithValue("@id", _selectedTransaksi.IdTransaksi);
                                cmd2.ExecuteNonQuery();
                            }

                            // 3. Update status mobil → Tersedia
                            using (var cmd3 = new MySqlCommand(
                                "UPDATE daftar_mobil SET status='Tersedia' WHERE id=@id", conn, tx))
                            {
                                cmd3.Parameters.AddWithValue("@id", _selectedTransaksi.IdMobil);
                                cmd3.ExecuteNonQuery();
                            }

                            tx.Commit();

                            // Tambah ke List lokal langsung tanpa query ulang
                            _listPengembalian.Insert(0, new ItemPengembalian
                            {
                                IdPengembalian = 0,
                                IdTransaksi = _selectedTransaksi.IdTransaksi,
                                NamaPelanggan = _selectedTransaksi.NamaPelanggan,
                                NamaMobil = $"{_selectedTransaksi.NamaMobil} ({_selectedTransaksi.PlatNomor})",
                                TglRencanaKembali = _selectedTransaksi.TglRencanaKembali,
                                TglKembaliAktual = aktual.ToString("dd/MM/yyyy"),
                                TelatHari = telatHari,
                                TotalDenda = totalDenda,
                                KondisiMobil = kondisi,
                                CatatanKerusakan = txtCatatan.Text.Trim(),
                                CreatedAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                            });

                            MessageBox.Show("Pengembalian berhasil diproses!\nStatus mobil sudah kembali Tersedia.",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetForm();
                            LoadTransaksiAktif();
                            TampilkanDGV();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses pengembalian:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ══════════════════════════════════════════════════════
        //  HELPER
        // ══════════════════════════════════════════════════════
        private void ResetForm()
        {
            cboTransaksi.SelectedIndex = -1;
            dtpTglAktual.Value = DateTime.Today;
            cboKondisi.SelectedIndex = 0;
            txtCatatan.Clear();
            _selectedTransaksi = null;
            BersihkanInfoSewa();
            BersihkanKalkulasi();
        }

        private void BersihkanInfoSewa()
        {
            lblValPelanggan.Text = "—";
            lblValMobil.Text = "—";
            lblValTglSewa.Text = "—";
            lblValRencana.Text = "—";
            lblValRencana.ForeColor = Color.FromArgb(30, 30, 30);
            lblValTotalBiaya.Text = "—";
        }

        private void BersihkanKalkulasi()
        {
            lblValTelat.Text = "—";
            lblValTelat.ForeColor = Color.Gray;
            lblValDenda.Text = "—";
            lblValTotalDenda.Text = "Rp 0";
            lblValTotalDenda.ForeColor = Color.FromArgb(108, 117, 125);
        }

        private void pnlToolbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}