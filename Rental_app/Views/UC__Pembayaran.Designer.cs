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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblJudul = new Label();
            lblSubJudul = new Label();
            pnlKiri = new Panel();
            pnlTombol = new Panel();
            btnSimpan = new Button();
            btnCetak = new Button();
            btnReset = new Button();
            grpInputBayar = new GroupBox();
            lblMetode = new Label();
            cboMetode = new ComboBox();
            lblStatusBayar = new Label();
            cboStatusBayar = new ComboBox();
            lblJumlahDP = new Label();
            txtJumlahDP = new TextBox();
            lblJumlahLunas = new Label();
            txtJumlahLunas = new TextBox();
            lblCatatanBayar = new Label();
            txtCatatanBayar = new TextBox();
            grpInfoTransaksi = new GroupBox();
            lblInfoPelanggan = new Label();
            lblValPelanggan = new Label();
            lblInfoMobil = new Label();
            lblValMobil = new Label();
            lblInfoTglSewa = new Label();
            lblValTglSewa = new Label();
            lblInfoDurasi = new Label();
            lblValDurasi = new Label();
            pnlGarisTotalTrx = new Panel();
            lblInfoTotal = new Label();
            lblValTotal = new Label();
            grpPilihTransaksi = new GroupBox();
            lblCariTrx = new Label();
            txtCariTrx = new TextBox();
            btnCariTrx = new Button();
            lblPilihTrx = new Label();
            cboTransaksi = new ComboBox();
            pnlKanan = new Panel();
            grpDaftar = new GroupBox();
            pnlToolbar = new Panel();
            txtCari = new TextBox();
            btnCari = new Button();
            btnRefresh = new Button();
            dgvPembayaran = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlKiri.SuspendLayout();
            pnlTombol.SuspendLayout();
            grpInputBayar.SuspendLayout();
            grpInfoTransaksi.SuspendLayout();
            grpPilihTransaksi.SuspendLayout();
            pnlKanan.SuspendLayout();
            grpDaftar.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(40, 167, 69);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20, 10, 20, 10);
            pnlHeader.Size = new Size(1200, 72);
            pnlHeader.TabIndex = 2;
            //pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(20, 2);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(367, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "  Pembayaran & Kwitansi";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 9F);
            lblSubJudul.ForeColor = Color.FromArgb(180, 240, 200);
            lblSubJudul.Location = new Point(22, 42);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(445, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Catat pembayaran dan cetak kwitansi untuk pelanggan";
            // 
            // pnlKiri
            // 
            pnlKiri.BackColor = Color.FromArgb(245, 246, 250);
            pnlKiri.Controls.Add(pnlTombol);
            pnlKiri.Controls.Add(grpInputBayar);
            pnlKiri.Controls.Add(grpInfoTransaksi);
            pnlKiri.Controls.Add(grpPilihTransaksi);
            pnlKiri.Dock = DockStyle.Left;
            pnlKiri.Location = new Point(0, 72);
            pnlKiri.Name = "pnlKiri";
            pnlKiri.Padding = new Padding(12, 12, 6, 12);
            pnlKiri.Size = new Size(400, 678);
            pnlKiri.TabIndex = 1;
            // 
            // pnlTombol
            // 
            pnlTombol.BackColor = Color.FromArgb(245, 246, 250);
            pnlTombol.Controls.Add(btnSimpan);
            pnlTombol.Controls.Add(btnCetak);
            pnlTombol.Controls.Add(btnReset);
            pnlTombol.Dock = DockStyle.Top;
            pnlTombol.Location = new Point(12, 547);
            pnlTombol.Name = "pnlTombol";
            pnlTombol.Size = new Size(382, 56);
            pnlTombol.TabIndex = 0;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(40, 167, 69);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(0, 10);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(100, 36);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(255, 153, 0);
            btnCetak.Cursor = Cursors.Hand;
            btnCetak.FlatAppearance.BorderSize = 0;
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCetak.ForeColor = Color.White;
            btnCetak.Location = new Point(108, 10);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(130, 36);
            btnCetak.TabIndex = 1;
            btnCetak.Text = "Cetak Kwitansi";
            btnCetak.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(246, 10);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(80, 36);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // grpInputBayar
            // 
            grpInputBayar.BackColor = Color.White;
            grpInputBayar.Controls.Add(lblMetode);
            grpInputBayar.Controls.Add(cboMetode);
            grpInputBayar.Controls.Add(lblStatusBayar);
            grpInputBayar.Controls.Add(cboStatusBayar);
            grpInputBayar.Controls.Add(lblJumlahDP);
            grpInputBayar.Controls.Add(txtJumlahDP);
            grpInputBayar.Controls.Add(lblJumlahLunas);
            grpInputBayar.Controls.Add(txtJumlahLunas);
            grpInputBayar.Controls.Add(lblCatatanBayar);
            grpInputBayar.Controls.Add(txtCatatanBayar);
            grpInputBayar.Dock = DockStyle.Top;
            grpInputBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInputBayar.ForeColor = Color.FromArgb(40, 167, 69);
            grpInputBayar.Location = new Point(12, 315);
            grpInputBayar.Name = "grpInputBayar";
            grpInputBayar.Padding = new Padding(14, 14, 14, 10);
            grpInputBayar.Size = new Size(382, 232);
            grpInputBayar.TabIndex = 1;
            grpInputBayar.TabStop = false;
            grpInputBayar.Text = "  Input Pembayaran";
            // 
            // lblMetode
            // 
            lblMetode.Font = new Font("Segoe UI", 9F);
            lblMetode.ForeColor = Color.FromArgb(70, 70, 70);
            lblMetode.Location = new Point(14, 28);
            lblMetode.Name = "lblMetode";
            lblMetode.Size = new Size(110, 20);
            lblMetode.TabIndex = 0;
            lblMetode.Text = "Metode Bayar :";
            // 
            // cboMetode
            // 
            cboMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetode.FlatStyle = FlatStyle.Flat;
            cboMetode.Font = new Font("Segoe UI", 9F);
            cboMetode.Items.AddRange(new object[] { "Tunai", "Transfer Bank", "QRIS / E-Wallet" });
            cboMetode.Location = new Point(14, 24);
            cboMetode.Name = "cboMetode";
            cboMetode.Size = new Size(220, 33);
            cboMetode.TabIndex = 1;
            // 
            // lblStatusBayar
            // 
            lblStatusBayar.Font = new Font("Segoe UI", 9F);
            lblStatusBayar.ForeColor = Color.FromArgb(70, 70, 70);
            lblStatusBayar.Location = new Point(14, 68);
            lblStatusBayar.Name = "lblStatusBayar";
            lblStatusBayar.Size = new Size(110, 20);
            lblStatusBayar.TabIndex = 2;
            lblStatusBayar.Text = "Status Bayar :";
            // 
            // cboStatusBayar
            // 
            cboStatusBayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusBayar.FlatStyle = FlatStyle.Flat;
            cboStatusBayar.Font = new Font("Segoe UI", 9F);
            cboStatusBayar.Items.AddRange(new object[] { "Belum Bayar", "DP", "Lunas" });
            cboStatusBayar.Location = new Point(14, 64);
            cboStatusBayar.Name = "cboStatusBayar";
            cboStatusBayar.Size = new Size(220, 33);
            cboStatusBayar.TabIndex = 3;
            // 
            // lblJumlahDP
            // 
            lblJumlahDP.Font = new Font("Segoe UI", 9F);
            lblJumlahDP.ForeColor = Color.FromArgb(70, 70, 70);
            lblJumlahDP.Location = new Point(14, 108);
            lblJumlahDP.Name = "lblJumlahDP";
            lblJumlahDP.Size = new Size(110, 20);
            lblJumlahDP.TabIndex = 4;
            lblJumlahDP.Text = "Jumlah DP :";
            // 
            // txtJumlahDP
            // 
            txtJumlahDP.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahDP.Font = new Font("Segoe UI", 9F);
            txtJumlahDP.Location = new Point(14, 104);
            txtJumlahDP.Name = "txtJumlahDP";
            txtJumlahDP.Size = new Size(220, 31);
            txtJumlahDP.TabIndex = 5;
            txtJumlahDP.Text = "0";
            // 
            // lblJumlahLunas
            // 
            lblJumlahLunas.Font = new Font("Segoe UI", 9F);
            lblJumlahLunas.ForeColor = Color.FromArgb(70, 70, 70);
            lblJumlahLunas.Location = new Point(14, 148);
            lblJumlahLunas.Name = "lblJumlahLunas";
            lblJumlahLunas.Size = new Size(110, 20);
            lblJumlahLunas.TabIndex = 6;
            lblJumlahLunas.Text = "Jumlah Lunas :";
            // 
            // txtJumlahLunas
            // 
            txtJumlahLunas.BorderStyle = BorderStyle.FixedSingle;
            txtJumlahLunas.Font = new Font("Segoe UI", 9F);
            txtJumlahLunas.Location = new Point(14, 144);
            txtJumlahLunas.Name = "txtJumlahLunas";
            txtJumlahLunas.Size = new Size(220, 31);
            txtJumlahLunas.TabIndex = 7;
            txtJumlahLunas.Text = "0";
            // 
            // lblCatatanBayar
            // 
            lblCatatanBayar.Font = new Font("Segoe UI", 9F);
            lblCatatanBayar.ForeColor = Color.FromArgb(70, 70, 70);
            lblCatatanBayar.Location = new Point(14, 188);
            lblCatatanBayar.Name = "lblCatatanBayar";
            lblCatatanBayar.Size = new Size(110, 20);
            lblCatatanBayar.TabIndex = 8;
            lblCatatanBayar.Text = "Catatan :";
            // 
            // txtCatatanBayar
            // 
            txtCatatanBayar.BorderStyle = BorderStyle.FixedSingle;
            txtCatatanBayar.Font = new Font("Segoe UI", 9F);
            txtCatatanBayar.Location = new Point(14, 184);
            txtCatatanBayar.Name = "txtCatatanBayar";
            txtCatatanBayar.Size = new Size(220, 31);
            txtCatatanBayar.TabIndex = 9;
            // 
            // grpInfoTransaksi
            // 
            grpInfoTransaksi.BackColor = Color.FromArgb(248, 255, 248);
            grpInfoTransaksi.Controls.Add(lblInfoPelanggan);
            grpInfoTransaksi.Controls.Add(lblValPelanggan);
            grpInfoTransaksi.Controls.Add(lblInfoMobil);
            grpInfoTransaksi.Controls.Add(lblValMobil);
            grpInfoTransaksi.Controls.Add(lblInfoTglSewa);
            grpInfoTransaksi.Controls.Add(lblValTglSewa);
            grpInfoTransaksi.Controls.Add(lblInfoDurasi);
            grpInfoTransaksi.Controls.Add(lblValDurasi);
            grpInfoTransaksi.Controls.Add(pnlGarisTotalTrx);
            grpInfoTransaksi.Controls.Add(lblInfoTotal);
            grpInfoTransaksi.Controls.Add(lblValTotal);
            grpInfoTransaksi.Dock = DockStyle.Top;
            grpInfoTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInfoTransaksi.ForeColor = Color.FromArgb(40, 167, 69);
            grpInfoTransaksi.Location = new Point(12, 127);
            grpInfoTransaksi.Name = "grpInfoTransaksi";
            grpInfoTransaksi.Padding = new Padding(14, 14, 14, 10);
            grpInfoTransaksi.Size = new Size(382, 188);
            grpInfoTransaksi.TabIndex = 2;
            grpInfoTransaksi.TabStop = false;
            grpInfoTransaksi.Text = "  Detail Transaksi";
            // 
            // lblInfoPelanggan
            // 
            lblInfoPelanggan.Font = new Font("Segoe UI", 9F);
            lblInfoPelanggan.ForeColor = Color.Gray;
            lblInfoPelanggan.Location = new Point(14, 26);
            lblInfoPelanggan.Name = "lblInfoPelanggan";
            lblInfoPelanggan.Size = new Size(100, 20);
            lblInfoPelanggan.TabIndex = 0;
            lblInfoPelanggan.Text = "Pelanggan";
            // 
            // lblValPelanggan
            // 
            lblValPelanggan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValPelanggan.ForeColor = Color.FromArgb(30, 30, 30);
            lblValPelanggan.Location = new Point(120, 26);
            lblValPelanggan.Name = "lblValPelanggan";
            lblValPelanggan.Size = new Size(230, 20);
            lblValPelanggan.TabIndex = 1;
            lblValPelanggan.Text = "—";
            // 
            // lblInfoMobil
            // 
            lblInfoMobil.Font = new Font("Segoe UI", 9F);
            lblInfoMobil.ForeColor = Color.Gray;
            lblInfoMobil.Location = new Point(14, 50);
            lblInfoMobil.Name = "lblInfoMobil";
            lblInfoMobil.Size = new Size(100, 20);
            lblInfoMobil.TabIndex = 2;
            lblInfoMobil.Text = "Mobil";
            // 
            // lblValMobil
            // 
            lblValMobil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValMobil.ForeColor = Color.FromArgb(30, 30, 30);
            lblValMobil.Location = new Point(120, 50);
            lblValMobil.Name = "lblValMobil";
            lblValMobil.Size = new Size(230, 20);
            lblValMobil.TabIndex = 3;
            lblValMobil.Text = "—";
            // 
            // lblInfoTglSewa
            // 
            lblInfoTglSewa.Font = new Font("Segoe UI", 9F);
            lblInfoTglSewa.ForeColor = Color.Gray;
            lblInfoTglSewa.Location = new Point(14, 74);
            lblInfoTglSewa.Name = "lblInfoTglSewa";
            lblInfoTglSewa.Size = new Size(100, 20);
            lblInfoTglSewa.TabIndex = 4;
            lblInfoTglSewa.Text = "Tgl Sewa";
            // 
            // lblValTglSewa
            // 
            lblValTglSewa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValTglSewa.ForeColor = Color.FromArgb(30, 30, 30);
            lblValTglSewa.Location = new Point(120, 74);
            lblValTglSewa.Name = "lblValTglSewa";
            lblValTglSewa.Size = new Size(230, 20);
            lblValTglSewa.TabIndex = 5;
            lblValTglSewa.Text = "—";
            // 
            // lblInfoDurasi
            // 
            lblInfoDurasi.Font = new Font("Segoe UI", 9F);
            lblInfoDurasi.ForeColor = Color.Gray;
            lblInfoDurasi.Location = new Point(14, 98);
            lblInfoDurasi.Name = "lblInfoDurasi";
            lblInfoDurasi.Size = new Size(100, 20);
            lblInfoDurasi.TabIndex = 6;
            lblInfoDurasi.Text = "Durasi";
            // 
            // lblValDurasi
            // 
            lblValDurasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValDurasi.ForeColor = Color.FromArgb(30, 30, 30);
            lblValDurasi.Location = new Point(120, 98);
            lblValDurasi.Name = "lblValDurasi";
            lblValDurasi.Size = new Size(230, 20);
            lblValDurasi.TabIndex = 7;
            lblValDurasi.Text = "—";
            // 
            // pnlGarisTotalTrx
            // 
            pnlGarisTotalTrx.BackColor = Color.LightGray;
            pnlGarisTotalTrx.Location = new Point(14, 122);
            pnlGarisTotalTrx.Name = "pnlGarisTotalTrx";
            pnlGarisTotalTrx.Size = new Size(346, 1);
            pnlGarisTotalTrx.TabIndex = 8;
            // 
            // lblInfoTotal
            // 
            lblInfoTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInfoTotal.ForeColor = Color.FromArgb(30, 30, 30);
            lblInfoTotal.Location = new Point(14, 136);
            lblInfoTotal.Name = "lblInfoTotal";
            lblInfoTotal.Size = new Size(100, 24);
            lblInfoTotal.TabIndex = 9;
            lblInfoTotal.Text = "TOTAL BIAYA";
            // 
            // lblValTotal
            // 
            lblValTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblValTotal.ForeColor = Color.FromArgb(40, 167, 69);
            lblValTotal.Location = new Point(120, 132);
            lblValTotal.Name = "lblValTotal";
            lblValTotal.Size = new Size(230, 30);
            lblValTotal.TabIndex = 10;
            lblValTotal.Text = "—";
            // 
            // grpPilihTransaksi
            // 
            grpPilihTransaksi.BackColor = Color.White;
            grpPilihTransaksi.Controls.Add(lblCariTrx);
            grpPilihTransaksi.Controls.Add(txtCariTrx);
            grpPilihTransaksi.Controls.Add(btnCariTrx);
            grpPilihTransaksi.Controls.Add(lblPilihTrx);
            grpPilihTransaksi.Controls.Add(cboTransaksi);
            grpPilihTransaksi.Dock = DockStyle.Top;
            grpPilihTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPilihTransaksi.ForeColor = Color.FromArgb(40, 167, 69);
            grpPilihTransaksi.Location = new Point(12, 12);
            grpPilihTransaksi.Name = "grpPilihTransaksi";
            grpPilihTransaksi.Padding = new Padding(14, 14, 14, 10);
            grpPilihTransaksi.Size = new Size(382, 115);
            grpPilihTransaksi.TabIndex = 3;
            grpPilihTransaksi.TabStop = false;
            grpPilihTransaksi.Text = "  Pilih Transaksi";
            // 
            // lblCariTrx
            // 
            lblCariTrx.Font = new Font("Segoe UI", 9F);
            lblCariTrx.ForeColor = Color.FromArgb(70, 70, 70);
            lblCariTrx.Location = new Point(14, 26);
            lblCariTrx.Name = "lblCariTrx";
            lblCariTrx.Size = new Size(110, 20);
            lblCariTrx.TabIndex = 0;
            lblCariTrx.Text = "Cari Pelanggan :";
            // 
            // txtCariTrx
            // 
            txtCariTrx.BorderStyle = BorderStyle.FixedSingle;
            txtCariTrx.Font = new Font("Segoe UI", 9F);
            txtCariTrx.Location = new Point(128, 22);
            txtCariTrx.Name = "txtCariTrx";
            txtCariTrx.Size = new Size(170, 31);
            txtCariTrx.TabIndex = 1;
            // 
            // btnCariTrx
            // 
            btnCariTrx.BackColor = Color.FromArgb(40, 167, 69);
            btnCariTrx.Cursor = Cursors.Hand;
            btnCariTrx.FlatAppearance.BorderSize = 0;
            btnCariTrx.FlatStyle = FlatStyle.Flat;
            btnCariTrx.Font = new Font("Segoe UI", 9F);
            btnCariTrx.ForeColor = Color.White;
            btnCariTrx.Location = new Point(306, 22);
            btnCariTrx.Name = "btnCariTrx";
            btnCariTrx.Size = new Size(52, 31);
            btnCariTrx.TabIndex = 2;
            btnCariTrx.Text = "Cari";
            btnCariTrx.UseVisualStyleBackColor = false;
            // 
            // lblPilihTrx
            // 
            lblPilihTrx.Font = new Font("Segoe UI", 9F);
            lblPilihTrx.ForeColor = Color.FromArgb(70, 70, 70);
            lblPilihTrx.Location = new Point(14, 62);
            lblPilihTrx.Name = "lblPilihTrx";
            lblPilihTrx.Size = new Size(110, 20);
            lblPilihTrx.TabIndex = 3;
            lblPilihTrx.Text = "Transaksi :";
            // 
            // cboTransaksi
            // 
            cboTransaksi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransaksi.FlatStyle = FlatStyle.Flat;
            cboTransaksi.Font = new Font("Segoe UI", 9F);
            cboTransaksi.Location = new Point(128, 58);
            cboTransaksi.Name = "cboTransaksi";
            cboTransaksi.Size = new Size(230, 33);
            cboTransaksi.TabIndex = 4;
            // 
            // pnlKanan
            // 
            pnlKanan.BackColor = Color.FromArgb(245, 246, 250);
            pnlKanan.Controls.Add(grpDaftar);
            pnlKanan.Dock = DockStyle.Fill;
            pnlKanan.Location = new Point(400, 72);
            pnlKanan.Name = "pnlKanan";
            pnlKanan.Padding = new Padding(6, 12, 12, 12);
            pnlKanan.Size = new Size(800, 678);
            pnlKanan.TabIndex = 0;
            // 
            // grpDaftar
            // 
            grpDaftar.BackColor = Color.White;
            grpDaftar.Controls.Add(pnlToolbar);
            grpDaftar.Controls.Add(dgvPembayaran);
            grpDaftar.Dock = DockStyle.Fill;
            grpDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDaftar.ForeColor = Color.FromArgb(40, 167, 69);
            grpDaftar.Location = new Point(6, 12);
            grpDaftar.Name = "grpDaftar";
            grpDaftar.Size = new Size(782, 654);
            grpDaftar.TabIndex = 0;
            grpDaftar.TabStop = false;
            grpDaftar.Text = "  Riwayat Pembayaran";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtCari);
            pnlToolbar.Controls.Add(btnCari);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(3, 27);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(10, 8, 10, 0);
            pnlToolbar.Size = new Size(776, 44);
            pnlToolbar.TabIndex = 0;
            // 
            // txtCari
            // 
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Font = new Font("Segoe UI", 9F);
            txtCari.Location = new Point(10, 8);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(260, 31);
            txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(40, 167, 69);
            btnCari.Cursor = Cursors.Hand;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9F);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(278, 8);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(60, 31);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(346, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 31);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvPembayaran
            // 
            dgvPembayaran.AllowUserToAddRows = false;
            dgvPembayaran.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 255, 248);
            dgvPembayaran.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPembayaran.BackgroundColor = Color.White;
            dgvPembayaran.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 167, 69);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPembayaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPembayaran.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 167, 69);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 240, 210);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPembayaran.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPembayaran.Dock = DockStyle.Fill;
            dgvPembayaran.EnableHeadersVisualStyles = false;
            dgvPembayaran.Font = new Font("Segoe UI", 9F);
            dgvPembayaran.GridColor = Color.FromArgb(230, 230, 230);
            dgvPembayaran.Location = new Point(3, 27);
            dgvPembayaran.MultiSelect = false;
            dgvPembayaran.Name = "dgvPembayaran";
            dgvPembayaran.ReadOnly = true;
            dgvPembayaran.RowHeadersVisible = false;
            dgvPembayaran.RowHeadersWidth = 62;
            dgvPembayaran.RowTemplate.Height = 32;
            dgvPembayaran.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPembayaran.Size = new Size(776, 624);
            dgvPembayaran.TabIndex = 1;
            dgvPembayaran.CellContentClick += dgvPembayaran_CellContentClick;
            // 
            // UC__Pembayaran
            // 
            BackColor = Color.FromArgb(245, 246, 250);
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
            grpPilihTransaksi.ResumeLayout(false);
            grpPilihTransaksi.PerformLayout();
            pnlKanan.ResumeLayout(false);
            grpDaftar.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPembayaran).EndInit();
            ResumeLayout(false);
        }
        #endregion

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
    }
}