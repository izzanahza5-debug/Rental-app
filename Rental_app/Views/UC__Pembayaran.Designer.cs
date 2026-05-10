namespace Rental_app
{
    partial class UC__Pembayaran
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubJudul = new Label();
            lblJudul = new Label();
            pnlKiri = new Panel();
            pnlTombol = new Panel();
            btnReset = new Button();
            btnCetak = new Button();
            btnSimpan = new Button();
            grpInputBayar = new GroupBox();
            txtCatatanBayar = new TextBox();
            lblCatatanBayar = new Label();
            txtJumlahLunas = new TextBox();
            lblJumlahLunas = new Label();
            txtJumlahDP = new TextBox();
            lblJumlahDP = new Label();
            cboStatusBayar = new ComboBox();
            lblStatusBayar = new Label();
            cboMetode = new ComboBox();
            lblMetode = new Label();
            grpInfoTransaksi = new GroupBox();
            lblValTotal = new Label();
            lblInfoTotal = new Label();
            pnlGarisTotalTrx = new Panel();
            lblValDurasi = new Label();
            lblInfoDurasi = new Label();
            lblValTglSewa = new Label();
            lblInfoTglSewa = new Label();
            lblValMobil = new Label();
            lblInfoMobil = new Label();
            lblValPelanggan = new Label();
            lblInfoPelanggan = new Label();
            grpPilihTransaksi = new GroupBox();
            cboTransaksi = new ComboBox();
            lblPilihTrx = new Label();
            btnCariTrx = new Button();
            txtCariTrx = new TextBox();
            lblCariTrx = new Label();
            pnlKanan = new Panel();
            grpDaftar = new GroupBox();
            dgvPembayaran = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colPelanggan = new DataGridViewTextBoxColumn();
            colMobil = new DataGridViewTextBoxColumn();
            colTglBayar = new DataGridViewTextBoxColumn();
            colMetode = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            btnCari = new Button();
            txtCari = new TextBox();
            pnlHeader.SuspendLayout();
            pnlKiri.SuspendLayout();
            pnlTombol.SuspendLayout();
            grpInputBayar.SuspendLayout();
            grpInfoTransaksi.SuspendLayout();
            grpPilihTransaksi.SuspendLayout();
            pnlKanan.SuspendLayout();
            grpDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(22, 128, 72);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 78);
            pnlHeader.TabIndex = 2;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 9F);
            lblSubJudul.ForeColor = Color.FromArgb(167, 243, 208);
            lblSubJudul.Location = new Point(28, 48);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(445, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Catat pembayaran dan cetak kwitansi untuk pelanggan";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(24, 8);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(436, 46);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "💳  Pembayaran & Kwitansi";
            // 
            // pnlKiri
            // 
            pnlKiri.BackColor = Color.FromArgb(243, 244, 246);
            pnlKiri.Controls.Add(pnlTombol);
            pnlKiri.Controls.Add(grpInputBayar);
            pnlKiri.Controls.Add(grpInfoTransaksi);
            pnlKiri.Controls.Add(grpPilihTransaksi);
            pnlKiri.Dock = DockStyle.Left;
            pnlKiri.Location = new Point(0, 78);
            pnlKiri.Name = "pnlKiri";
            pnlKiri.Size = new Size(420, 672);
            pnlKiri.TabIndex = 1;
            // 
            // pnlTombol
            // 
            pnlTombol.BackColor = Color.FromArgb(243, 244, 246);
            pnlTombol.Controls.Add(btnReset);
            pnlTombol.Controls.Add(btnCetak);
            pnlTombol.Controls.Add(btnSimpan);
            pnlTombol.Location = new Point(14, 634);
            pnlTombol.Name = "pnlTombol";
            pnlTombol.Size = new Size(392, 62);
            pnlTombol.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(100, 116, 139);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(296, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 38);
            btnReset.TabIndex = 2;
            btnReset.Text = "↺  Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(234, 88, 12);
            btnCetak.Cursor = Cursors.Hand;
            btnCetak.FlatAppearance.BorderSize = 0;
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCetak.ForeColor = Color.White;
            btnCetak.Location = new Point(126, 12);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(162, 38);
            btnCetak.TabIndex = 1;
            btnCetak.Text = "🖨️  Cetak Kwitansi";
            btnCetak.UseVisualStyleBackColor = false;
            btnCetak.Click += btnCetak_Click_1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(22, 128, 72);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(0, 12);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(118, 38);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "💾  Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // grpInputBayar
            // 
            grpInputBayar.BackColor = Color.White;
            grpInputBayar.Controls.Add(txtCatatanBayar);
            grpInputBayar.Controls.Add(lblCatatanBayar);
            grpInputBayar.Controls.Add(txtJumlahLunas);
            grpInputBayar.Controls.Add(lblJumlahLunas);
            grpInputBayar.Controls.Add(txtJumlahDP);
            grpInputBayar.Controls.Add(lblJumlahDP);
            grpInputBayar.Controls.Add(cboStatusBayar);
            grpInputBayar.Controls.Add(lblStatusBayar);
            grpInputBayar.Controls.Add(cboMetode);
            grpInputBayar.Controls.Add(lblMetode);
            grpInputBayar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpInputBayar.ForeColor = Color.FromArgb(22, 128, 72);
            grpInputBayar.Location = new Point(14, 412);
            grpInputBayar.Name = "grpInputBayar";
            grpInputBayar.Size = new Size(392, 216);
            grpInputBayar.TabIndex = 1;
            grpInputBayar.TabStop = false;
            grpInputBayar.Text = "  Input Pembayaran";
            // 
            // txtCatatanBayar
            // 
            txtCatatanBayar.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanBayar.Font = new Font("Segoe UI", 9.5F);
            txtCatatanBayar.Location = new Point(14, 177);
            txtCatatanBayar.Name = "txtCatatanBayar";
            txtCatatanBayar.PlaceholderText = "Tambah catatan jika perlu...";
            txtCatatanBayar.Size = new Size(350, 33);
            txtCatatanBayar.TabIndex = 9;
            // 
            // lblCatatanBayar
            // 
            lblCatatanBayar.AutoSize = true;
            lblCatatanBayar.Font = new Font("Segoe UI", 8.5F);
            lblCatatanBayar.ForeColor = Color.FromArgb(100, 116, 139);
            lblCatatanBayar.Location = new Point(14, 145);
            lblCatatanBayar.Name = "lblCatatanBayar";
            lblCatatanBayar.Size = new Size(149, 23);
            lblCatatanBayar.TabIndex = 8;
            lblCatatanBayar.Text = "Catatan (opsional)";
            // 
            // txtJumlahLunas
            // 
            txtJumlahLunas.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahLunas.Font = new Font("Segoe UI", 9.5F);
            txtJumlahLunas.Location = new Point(194, 104);
            txtJumlahLunas.Name = "txtJumlahLunas";
            txtJumlahLunas.PlaceholderText = "0";
            txtJumlahLunas.Size = new Size(168, 33);
            txtJumlahLunas.TabIndex = 7;
            // 
            // lblJumlahLunas
            // 
            lblJumlahLunas.AutoSize = true;
            lblJumlahLunas.Font = new Font("Segoe UI", 8.5F);
            lblJumlahLunas.ForeColor = Color.FromArgb(100, 116, 139);
            lblJumlahLunas.Location = new Point(194, 78);
            lblJumlahLunas.Name = "lblJumlahLunas";
            lblJumlahLunas.Size = new Size(148, 23);
            lblJumlahLunas.TabIndex = 6;
            lblJumlahLunas.Text = "Jumlah Lunas (Rp)";
            // 
            // txtJumlahDP
            // 
            txtJumlahDP.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahDP.Font = new Font("Segoe UI", 9.5F);
            txtJumlahDP.Location = new Point(14, 104);
            txtJumlahDP.Name = "txtJumlahDP";
            txtJumlahDP.PlaceholderText = "0";
            txtJumlahDP.Size = new Size(168, 33);
            txtJumlahDP.TabIndex = 5;
            // 
            // lblJumlahDP
            // 
            lblJumlahDP.AutoSize = true;
            lblJumlahDP.Font = new Font("Segoe UI", 8.5F);
            lblJumlahDP.ForeColor = Color.FromArgb(100, 116, 139);
            lblJumlahDP.Location = new Point(14, 78);
            lblJumlahDP.Name = "lblJumlahDP";
            lblJumlahDP.Size = new Size(126, 23);
            lblJumlahDP.TabIndex = 4;
            lblJumlahDP.Text = "Jumlah DP (Rp)";
            // 
            // cboStatusBayar
            // 
            cboStatusBayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusBayar.FlatStyle = FlatStyle.Flat;
            cboStatusBayar.Font = new Font("Segoe UI", 9.5F);
            cboStatusBayar.Items.AddRange(new object[] { "Belum Bayar", "DP", "Lunas" });
            cboStatusBayar.Location = new Point(194, 42);
            cboStatusBayar.Name = "cboStatusBayar";
            cboStatusBayar.Size = new Size(168, 33);
            cboStatusBayar.TabIndex = 3;
            // 
            // lblStatusBayar
            // 
            lblStatusBayar.AutoSize = true;
            lblStatusBayar.Font = new Font("Segoe UI", 8.5F);
            lblStatusBayar.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatusBayar.Location = new Point(188, 24);
            lblStatusBayar.Name = "lblStatusBayar";
            lblStatusBayar.Size = new Size(103, 23);
            lblStatusBayar.TabIndex = 2;
            lblStatusBayar.Text = "Status Bayar";
            // 
            // cboMetode
            // 
            cboMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetode.FlatStyle = FlatStyle.Flat;
            cboMetode.Font = new Font("Segoe UI", 9.5F);
            cboMetode.Items.AddRange(new object[] { "Tunai", "Transfer Bank", "QRIS / E-Wallet" });
            cboMetode.Location = new Point(14, 42);
            cboMetode.Name = "cboMetode";
            cboMetode.Size = new Size(168, 33);
            cboMetode.TabIndex = 1;
            // 
            // lblMetode
            // 
            lblMetode.AutoSize = true;
            lblMetode.Font = new Font("Segoe UI", 8.5F);
            lblMetode.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetode.Location = new Point(14, 24);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(116, 23);
            lblMetode.TabIndex = 0;
            lblMetode.Text = "Metode Bayar";
            // 
            // grpInfoTransaksi
            // 
            grpInfoTransaksi.BackColor = Color.White;
            grpInfoTransaksi.Controls.Add(lblValTotal);
            grpInfoTransaksi.Controls.Add(lblInfoTotal);
            grpInfoTransaksi.Controls.Add(pnlGarisTotalTrx);
            grpInfoTransaksi.Controls.Add(lblValDurasi);
            grpInfoTransaksi.Controls.Add(lblInfoDurasi);
            grpInfoTransaksi.Controls.Add(lblValTglSewa);
            grpInfoTransaksi.Controls.Add(lblInfoTglSewa);
            grpInfoTransaksi.Controls.Add(lblValMobil);
            grpInfoTransaksi.Controls.Add(lblInfoMobil);
            grpInfoTransaksi.Controls.Add(lblValPelanggan);
            grpInfoTransaksi.Controls.Add(lblInfoPelanggan);
            grpInfoTransaksi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpInfoTransaksi.ForeColor = Color.FromArgb(22, 128, 72);
            grpInfoTransaksi.Location = new Point(14, 191);
            grpInfoTransaksi.Name = "grpInfoTransaksi";
            grpInfoTransaksi.Size = new Size(392, 215);
            grpInfoTransaksi.TabIndex = 2;
            grpInfoTransaksi.TabStop = false;
            grpInfoTransaksi.Text = "  Detail Transaksi";
            grpInfoTransaksi.Enter += grpInfoTransaksi_Enter_1;
            // 
            // lblValTotal
            // 
            lblValTotal.AutoSize = true;
            lblValTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblValTotal.ForeColor = Color.FromArgb(22, 128, 72);
            lblValTotal.Location = new Point(18, 165);
            lblValTotal.Name = "lblValTotal";
            lblValTotal.Size = new Size(96, 38);
            lblValTotal.TabIndex = 10;
            lblValTotal.Text = "Rp  —";
            // 
            // lblInfoTotal
            // 
            lblInfoTotal.AutoSize = true;
            lblInfoTotal.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblInfoTotal.ForeColor = Color.FromArgb(107, 114, 128);
            lblInfoTotal.Location = new Point(14, 144);
            lblInfoTotal.Name = "lblInfoTotal";
            lblInfoTotal.Size = new Size(105, 21);
            lblInfoTotal.TabIndex = 9;
            lblInfoTotal.Text = "TOTAL BIAYA";
            // 
            // pnlGarisTotalTrx
            // 
            pnlGarisTotalTrx.BackColor = Color.FromArgb(226, 232, 240);
            pnlGarisTotalTrx.Location = new Point(14, 140);
            pnlGarisTotalTrx.Name = "pnlGarisTotalTrx";
            pnlGarisTotalTrx.Size = new Size(360, 1);
            pnlGarisTotalTrx.TabIndex = 8;
            // 
            // lblValDurasi
            // 
            lblValDurasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValDurasi.ForeColor = Color.FromArgb(30, 41, 59);
            lblValDurasi.Location = new Point(130, 107);
            lblValDurasi.Name = "lblValDurasi";
            lblValDurasi.Size = new Size(246, 20);
            lblValDurasi.TabIndex = 7;
            lblValDurasi.Text = "—";
            // 
            // lblInfoDurasi
            // 
            lblInfoDurasi.Font = new Font("Segoe UI", 9F);
            lblInfoDurasi.ForeColor = Color.FromArgb(107, 114, 128);
            lblInfoDurasi.Location = new Point(12, 107);
            lblInfoDurasi.Name = "lblInfoDurasi";
            lblInfoDurasi.Size = new Size(112, 20);
            lblInfoDurasi.TabIndex = 6;
            lblInfoDurasi.Text = "Durasi Sewa";
            // 
            // lblValTglSewa
            // 
            lblValTglSewa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValTglSewa.ForeColor = Color.FromArgb(30, 41, 59);
            lblValTglSewa.Location = new Point(128, 81);
            lblValTglSewa.Name = "lblValTglSewa";
            lblValTglSewa.Size = new Size(246, 26);
            lblValTglSewa.TabIndex = 5;
            lblValTglSewa.Text = "—";
            // 
            // lblInfoTglSewa
            // 
            lblInfoTglSewa.BackColor = Color.Transparent;
            lblInfoTglSewa.Font = new Font("Segoe UI", 9F);
            lblInfoTglSewa.ForeColor = Color.FromArgb(107, 114, 128);
            lblInfoTglSewa.Location = new Point(12, 81);
            lblInfoTglSewa.Name = "lblInfoTglSewa";
            lblInfoTglSewa.Size = new Size(112, 35);
            lblInfoTglSewa.TabIndex = 4;
            lblInfoTglSewa.Text = "Tanggal Sewa";
            // 
            // lblValMobil
            // 
            lblValMobil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValMobil.ForeColor = Color.FromArgb(30, 41, 59);
            lblValMobil.Location = new Point(128, 57);
            lblValMobil.Name = "lblValMobil";
            lblValMobil.Size = new Size(246, 20);
            lblValMobil.TabIndex = 3;
            lblValMobil.Text = "—";
            // 
            // lblInfoMobil
            // 
            lblInfoMobil.BackColor = Color.Transparent;
            lblInfoMobil.Font = new Font("Segoe UI", 9F);
            lblInfoMobil.ForeColor = Color.FromArgb(107, 114, 128);
            lblInfoMobil.Location = new Point(13, 56);
            lblInfoMobil.Name = "lblInfoMobil";
            lblInfoMobil.Size = new Size(112, 29);
            lblInfoMobil.TabIndex = 2;
            lblInfoMobil.Text = "Mobil";
            // 
            // lblValPelanggan
            // 
            lblValPelanggan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValPelanggan.ForeColor = Color.FromArgb(30, 41, 59);
            lblValPelanggan.Location = new Point(130, 28);
            lblValPelanggan.Name = "lblValPelanggan";
            lblValPelanggan.Size = new Size(246, 20);
            lblValPelanggan.TabIndex = 1;
            lblValPelanggan.Text = "—";
            // 
            // lblInfoPelanggan
            // 
            lblInfoPelanggan.Font = new Font("Segoe UI", 9F);
            lblInfoPelanggan.ForeColor = Color.FromArgb(107, 114, 128);
            lblInfoPelanggan.Location = new Point(12, 29);
            lblInfoPelanggan.Name = "lblInfoPelanggan";
            lblInfoPelanggan.Size = new Size(112, 32);
            lblInfoPelanggan.TabIndex = 0;
            lblInfoPelanggan.Text = "Pelanggan";
            // 
            // grpPilihTransaksi
            // 
            grpPilihTransaksi.BackColor = Color.White;
            grpPilihTransaksi.Controls.Add(cboTransaksi);
            grpPilihTransaksi.Controls.Add(lblPilihTrx);
            grpPilihTransaksi.Controls.Add(btnCariTrx);
            grpPilihTransaksi.Controls.Add(txtCariTrx);
            grpPilihTransaksi.Controls.Add(lblCariTrx);
            grpPilihTransaksi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpPilihTransaksi.ForeColor = Color.FromArgb(22, 128, 72);
            grpPilihTransaksi.Location = new Point(14, 14);
            grpPilihTransaksi.Name = "grpPilihTransaksi";
            grpPilihTransaksi.Size = new Size(392, 171);
            grpPilihTransaksi.TabIndex = 3;
            grpPilihTransaksi.TabStop = false;
            grpPilihTransaksi.Text = "  Pilih Transaksi";
            // 
            // cboTransaksi
            // 
            cboTransaksi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransaksi.FlatStyle = FlatStyle.Flat;
            cboTransaksi.Font = new Font("Segoe UI", 9.5F);
            cboTransaksi.Location = new Point(14, 120);
            cboTransaksi.Name = "cboTransaksi";
            cboTransaksi.Size = new Size(340, 33);
            cboTransaksi.TabIndex = 4;
            // 
            // lblPilihTrx
            // 
            lblPilihTrx.AutoSize = true;
            lblPilihTrx.Font = new Font("Segoe UI", 8.5F);
            lblPilihTrx.ForeColor = Color.FromArgb(100, 116, 139);
            lblPilihTrx.Location = new Point(18, 94);
            lblPilihTrx.Name = "lblPilihTrx";
            lblPilihTrx.Size = new Size(137, 23);
            lblPilihTrx.TabIndex = 3;
            lblPilihTrx.Text = "Pilih ID Transaksi";
            // 
            // btnCariTrx
            // 
            btnCariTrx.BackColor = Color.FromArgb(22, 128, 72);
            btnCariTrx.Cursor = Cursors.Hand;
            btnCariTrx.FlatAppearance.BorderSize = 0;
            btnCariTrx.FlatStyle = FlatStyle.Flat;
            btnCariTrx.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCariTrx.ForeColor = Color.White;
            btnCariTrx.Location = new Point(268, 56);
            btnCariTrx.Name = "btnCariTrx";
            btnCariTrx.Size = new Size(86, 33);
            btnCariTrx.TabIndex = 2;
            btnCariTrx.Text = "🔍  Cari";
            btnCariTrx.UseVisualStyleBackColor = false;
            // 
            // txtCariTrx
            // 
            txtCariTrx.BorderStyle = BorderStyle.FixedSingle;
            txtCariTrx.Font = new Font("Segoe UI", 9.5F);
            txtCariTrx.Location = new Point(12, 56);
            txtCariTrx.Name = "txtCariTrx";
            txtCariTrx.PlaceholderText = "Ketik nama pelanggan...";
            txtCariTrx.Size = new Size(248, 33);
            txtCariTrx.TabIndex = 1;
            // 
            // lblCariTrx
            // 
            lblCariTrx.AutoSize = true;
            lblCariTrx.Font = new Font("Segoe UI", 8.5F);
            lblCariTrx.ForeColor = Color.FromArgb(100, 116, 139);
            lblCariTrx.Location = new Point(11, 26);
            lblCariTrx.Name = "lblCariTrx";
            lblCariTrx.Size = new Size(176, 23);
            lblCariTrx.TabIndex = 0;
            lblCariTrx.Text = "Cari Nama Pelanggan";
            // 
            // pnlKanan
            // 
            pnlKanan.BackColor = Color.FromArgb(243, 244, 246);
            pnlKanan.Controls.Add(grpDaftar);
            pnlKanan.Dock = DockStyle.Fill;
            pnlKanan.Location = new Point(420, 78);
            pnlKanan.Name = "pnlKanan";
            pnlKanan.Padding = new Padding(8, 14, 14, 14);
            pnlKanan.Size = new Size(780, 672);
            pnlKanan.TabIndex = 0;
            // 
            // grpDaftar
            // 
            grpDaftar.BackColor = Color.White;
            grpDaftar.Controls.Add(dgvPembayaran);
            grpDaftar.Controls.Add(pnlToolbar);
            grpDaftar.Dock = DockStyle.Fill;
            grpDaftar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpDaftar.ForeColor = Color.FromArgb(22, 128, 72);
            grpDaftar.Location = new Point(8, 14);
            grpDaftar.Name = "grpDaftar";
            grpDaftar.Size = new Size(758, 644);
            grpDaftar.TabIndex = 0;
            grpDaftar.TabStop = false;
            grpDaftar.Text = "  Riwayat Pembayaran";
            // 
            // dgvPembayaran
            // 
            dgvPembayaran.AllowUserToAddRows = false;
            dgvPembayaran.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 251, 247);
            dgvPembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPembayaran.BackgroundColor = Color.White;
            dgvPembayaran.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 128, 72);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(6, 6, 4, 6);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(22, 128, 72);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPembayaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPembayaran.ColumnHeadersHeight = 40;
            dgvPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPembayaran.Columns.AddRange(new DataGridViewColumn[] { colNo, colPelanggan, colMobil, colTglBayar, colMetode, colStatus, colJumlah });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(22, 128, 72);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(209, 250, 229);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(22, 101, 52);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPembayaran.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPembayaran.Dock = DockStyle.Fill;
            dgvPembayaran.EnableHeadersVisualStyles = false;
            dgvPembayaran.Font = new Font("Segoe UI", 9F);
            dgvPembayaran.GridColor = Color.FromArgb(226, 232, 240);
            dgvPembayaran.Location = new Point(3, 79);
            dgvPembayaran.MultiSelect = false;
            dgvPembayaran.Name = "dgvPembayaran";
            dgvPembayaran.ReadOnly = true;
            dgvPembayaran.RowHeadersVisible = false;
            dgvPembayaran.RowHeadersWidth = 62;
            dgvPembayaran.RowTemplate.Height = 34;
            dgvPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPembayaran.Size = new Size(752, 562);
            dgvPembayaran.TabIndex = 1;
            dgvPembayaran.CellContentClick += dgvPembayaran_CellContentClick;
            // 
            // colNo
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNo.DefaultCellStyle = dataGridViewCellStyle3;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            colNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNo.Width = 48;
            // 
            // colPelanggan
            // 
            colPelanggan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPelanggan.FillWeight = 28F;
            colPelanggan.HeaderText = "Pelanggan";
            colPelanggan.MinimumWidth = 140;
            colPelanggan.Name = "colPelanggan";
            colPelanggan.ReadOnly = true;
            // 
            // colMobil
            // 
            colMobil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMobil.FillWeight = 24F;
            colMobil.HeaderText = "Mobil";
            colMobil.MinimumWidth = 120;
            colMobil.Name = "colMobil";
            colMobil.ReadOnly = true;
            // 
            // colTglBayar
            // 
            colTglBayar.HeaderText = "Tgl Bayar";
            colTglBayar.MinimumWidth = 8;
            colTglBayar.Name = "colTglBayar";
            colTglBayar.ReadOnly = true;
            colTglBayar.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTglBayar.Width = 102;
            // 
            // colMetode
            // 
            colMetode.HeaderText = "Metode";
            colMetode.MinimumWidth = 8;
            colMetode.Name = "colMetode";
            colMetode.ReadOnly = true;
            colMetode.SortMode = DataGridViewColumnSortMode.NotSortable;
            colMetode.Width = 114;
            // 
            // colStatus
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle4;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStatus.Width = 90;
            // 
            // colJumlah
            // 
            colJumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            colJumlah.DefaultCellStyle = dataGridViewCellStyle5;
            colJumlah.FillWeight = 22F;
            colJumlah.HeaderText = "Jumlah Bayar";
            colJumlah.MinimumWidth = 120;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnCari);
            pnlToolbar.Controls.Add(txtCari);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(3, 29);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(12, 10, 12, 8);
            pnlToolbar.Size = new Size(752, 50);
            pnlToolbar.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(100, 116, 139);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(404, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(111, 33);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "↺  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(22, 128, 72);
            btnCari.Cursor = Cursors.Hand;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(320, 10);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(76, 33);
            btnCari.TabIndex = 1;
            btnCari.Text = "🔍  Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // txtCari
            // 
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Font = new Font("Segoe UI", 9.5F);
            txtCari.Location = new Point(12, 10);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari nama pelanggan, mobil, atau status...";
            txtCari.Size = new Size(300, 33);
            txtCari.TabIndex = 0;
            // 
            // UC__Pembayaran
            // 
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(pnlKanan);
            Controls.Add(pnlKiri);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 680);
            Name = "UC__Pembayaran";
            Size = new Size(1200, 750);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKiri.ResumeLayout(false);
            pnlTombol.ResumeLayout(false);
            grpInputBayar.ResumeLayout(false);
            grpInputBayar.PerformLayout();
            grpInfoTransaksi.ResumeLayout(false);
            grpInfoTransaksi.PerformLayout();
            grpPilihTransaksi.ResumeLayout(false);
            grpPilihTransaksi.PerformLayout();
            pnlKanan.ResumeLayout(false);
            grpDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        // ── Deklarasi field ────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;

        private System.Windows.Forms.Panel pnlKiri;
        private System.Windows.Forms.GroupBox grpPilihTransaksi;
        private System.Windows.Forms.Label lblCariTrx;
        private System.Windows.Forms.TextBox txtCariTrx;
        private System.Windows.Forms.Button btnCariTrx;
        private System.Windows.Forms.Label lblPilihTrx;
        private System.Windows.Forms.ComboBox cboTransaksi;

        private System.Windows.Forms.GroupBox grpInfoTransaksi;
        private System.Windows.Forms.Label lblInfoPelanggan;
        private System.Windows.Forms.Label lblValPelanggan;
        private System.Windows.Forms.Label lblInfoMobil;
        private System.Windows.Forms.Label lblValMobil;
        private System.Windows.Forms.Label lblInfoTglSewa;
        private System.Windows.Forms.Label lblValTglSewa;
        private System.Windows.Forms.Label lblInfoDurasi;
        private System.Windows.Forms.Label lblValDurasi;
        private System.Windows.Forms.Panel pnlGarisTotalTrx;
        private System.Windows.Forms.Label lblInfoTotal;
        private System.Windows.Forms.Label lblValTotal;

        private System.Windows.Forms.GroupBox grpInputBayar;
        private System.Windows.Forms.Label lblMetode;
        private System.Windows.Forms.ComboBox cboMetode;
        private System.Windows.Forms.Label lblStatusBayar;
        private System.Windows.Forms.ComboBox cboStatusBayar;
        private System.Windows.Forms.Label lblJumlahDP;
        private System.Windows.Forms.TextBox txtJumlahDP;
        private System.Windows.Forms.Label lblJumlahLunas;
        private System.Windows.Forms.TextBox txtJumlahLunas;
        private System.Windows.Forms.Label lblCatatanBayar;
        private System.Windows.Forms.TextBox txtCatatanBayar;

        private System.Windows.Forms.Panel pnlTombol;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Panel pnlKanan;
        private System.Windows.Forms.GroupBox grpDaftar;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPembayaran;

        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
    }
}