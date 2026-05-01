namespace Rental_app
{
    partial class UC__PengembalianMobil
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblJudul = new Label();
            lblSubJudul = new Label();
            pnlKiri = new Panel();
            pnlTombol = new Panel();
            btnProses = new Button();
            btnReset = new Button();
            grpRingkasanDenda = new GroupBox();
            lblTagTelatJudul = new Label();
            lblValTelat = new Label();
            lblTagDendaJudul = new Label();
            lblValDenda = new Label();
            pnlGarisDenda = new Panel();
            lblTagTotalDenda = new Label();
            lblValTotalDenda = new Label();
            grpInputKembali = new GroupBox();
            lblTglAktual = new Label();
            dtpTglAktual = new DateTimePicker();
            lblKondisi = new Label();
            cboKondisi = new ComboBox();
            lblCatatan = new Label();
            txtCatatan = new TextBox();
            grpInfoSewa = new GroupBox();
            lblTagPelanggan = new Label();
            lblValPelanggan = new Label();
            lblTagMobil = new Label();
            lblValMobil = new Label();
            lblTagTglSewa = new Label();
            lblValTglSewa = new Label();
            lblTagRencana = new Label();
            lblValRencana = new Label();
            lblTagTotalBiaya = new Label();
            lblValTotalBiaya = new Label();
            grpPilihTransaksi = new GroupBox();
            lblTransaksi = new Label();
            cboTransaksi = new ComboBox();
            pnlKanan = new Panel();
            grpDaftar = new GroupBox();
            pnlToolbar = new Panel();
            txtCari = new TextBox();
            btnCari = new Button();
            cboFilterKondisi = new ComboBox();
            btnRefresh = new Button();
            dgvPengembalian = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlKiri.SuspendLayout();
            pnlTombol.SuspendLayout();
            grpRingkasanDenda.SuspendLayout();
            grpInputKembali.SuspendLayout();
            grpInfoSewa.SuspendLayout();
            grpPilihTransaksi.SuspendLayout();
            pnlKanan.SuspendLayout();
            grpDaftar.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengembalian).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(183, 28, 28);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 72);
            pnlHeader.TabIndex = 2;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(20, 5);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(348, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "  Pengembalian Mobil";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 9F);
            lblSubJudul.ForeColor = Color.FromArgb(255, 200, 200);
            lblSubJudul.Location = new Point(22, 44);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(497, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Proses pengembalian mobil dan hitung denda keterlambatan";
            // 
            // pnlKiri
            // 
            pnlKiri.BackColor = Color.FromArgb(245, 246, 250);
            pnlKiri.Controls.Add(pnlTombol);
            pnlKiri.Controls.Add(grpRingkasanDenda);
            pnlKiri.Controls.Add(grpInputKembali);
            pnlKiri.Controls.Add(grpInfoSewa);
            pnlKiri.Controls.Add(grpPilihTransaksi);
            pnlKiri.Dock = DockStyle.Left;
            pnlKiri.Location = new Point(0, 72);
            pnlKiri.Name = "pnlKiri";
            pnlKiri.Padding = new Padding(12, 12, 6, 12);
            pnlKiri.Size = new Size(395, 678);
            pnlKiri.TabIndex = 1;
            // 
            // pnlTombol
            // 
            pnlTombol.BackColor = Color.FromArgb(245, 246, 250);
            pnlTombol.Controls.Add(btnProses);
            pnlTombol.Controls.Add(btnReset);
            pnlTombol.Dock = DockStyle.Top;
            pnlTombol.Location = new Point(12, 542);
            pnlTombol.Name = "pnlTombol";
            pnlTombol.Size = new Size(377, 56);
            pnlTombol.TabIndex = 0;
            // 
            // btnProses
            // 
            btnProses.BackColor = Color.FromArgb(183, 28, 28);
            btnProses.Cursor = Cursors.Hand;
            btnProses.FlatAppearance.BorderSize = 0;
            btnProses.FlatStyle = FlatStyle.Flat;
            btnProses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProses.ForeColor = Color.White;
            btnProses.Location = new Point(0, 10);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(140, 36);
            btnProses.TabIndex = 0;
            btnProses.Text = "Proses Kembali";
            btnProses.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(148, 10);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(80, 36);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // grpRingkasanDenda
            // 
            grpRingkasanDenda.BackColor = Color.White;
            grpRingkasanDenda.Controls.Add(lblTagTelatJudul);
            grpRingkasanDenda.Controls.Add(lblValTelat);
            grpRingkasanDenda.Controls.Add(lblTagDendaJudul);
            grpRingkasanDenda.Controls.Add(lblValDenda);
            grpRingkasanDenda.Controls.Add(pnlGarisDenda);
            grpRingkasanDenda.Controls.Add(lblTagTotalDenda);
            grpRingkasanDenda.Controls.Add(lblValTotalDenda);
            grpRingkasanDenda.Dock = DockStyle.Top;
            grpRingkasanDenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRingkasanDenda.ForeColor = Color.FromArgb(183, 28, 28);
            grpRingkasanDenda.Location = new Point(12, 420);
            grpRingkasanDenda.Margin = new Padding(0, 6, 0, 0);
            grpRingkasanDenda.Name = "grpRingkasanDenda";
            grpRingkasanDenda.Size = new Size(377, 122);
            grpRingkasanDenda.TabIndex = 1;
            grpRingkasanDenda.TabStop = false;
            grpRingkasanDenda.Text = "  Kalkulasi Denda";
            // 
            // lblTagTelatJudul
            // 
            lblTagTelatJudul.AutoSize = true;
            lblTagTelatJudul.Font = new Font("Segoe UI", 9F);
            lblTagTelatJudul.ForeColor = Color.Gray;
            lblTagTelatJudul.Location = new Point(12, 26);
            lblTagTelatJudul.Name = "lblTagTelatJudul";
            lblTagTelatJudul.Size = new Size(126, 25);
            lblTagTelatJudul.TabIndex = 0;
            lblTagTelatJudul.Text = "Keterlambatan";
            // 
            // lblValTelat
            // 
            lblValTelat.AutoSize = true;
            lblValTelat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValTelat.ForeColor = Color.FromArgb(183, 28, 28);
            lblValTelat.Location = new Point(200, 26);
            lblValTelat.Name = "lblValTelat";
            lblValTelat.Size = new Size(30, 25);
            lblValTelat.TabIndex = 1;
            lblValTelat.Text = "—";
            // 
            // lblTagDendaJudul
            // 
            lblTagDendaJudul.AutoSize = true;
            lblTagDendaJudul.Font = new Font("Segoe UI", 9F);
            lblTagDendaJudul.ForeColor = Color.Gray;
            lblTagDendaJudul.Location = new Point(12, 50);
            lblTagDendaJudul.Name = "lblTagDendaJudul";
            lblTagDendaJudul.Size = new Size(113, 25);
            lblTagDendaJudul.TabIndex = 2;
            lblTagDendaJudul.Text = "Denda / Hari";
            // 
            // lblValDenda
            // 
            lblValDenda.AutoSize = true;
            lblValDenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValDenda.ForeColor = Color.FromArgb(30, 30, 30);
            lblValDenda.Location = new Point(200, 50);
            lblValDenda.Name = "lblValDenda";
            lblValDenda.Size = new Size(30, 25);
            lblValDenda.TabIndex = 3;
            lblValDenda.Text = "—";
            // 
            // pnlGarisDenda
            // 
            pnlGarisDenda.BackColor = Color.LightGray;
            pnlGarisDenda.Location = new Point(12, 70);
            pnlGarisDenda.Name = "pnlGarisDenda";
            pnlGarisDenda.Size = new Size(340, 1);
            pnlGarisDenda.TabIndex = 4;
            // 
            // lblTagTotalDenda
            // 
            lblTagTotalDenda.AutoSize = true;
            lblTagTotalDenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTagTotalDenda.ForeColor = Color.FromArgb(30, 30, 30);
            lblTagTotalDenda.Location = new Point(12, 81);
            lblTagTotalDenda.Name = "lblTagTotalDenda";
            lblTagTotalDenda.Size = new Size(135, 25);
            lblTagTotalDenda.TabIndex = 5;
            lblTagTotalDenda.Text = "TOTAL DENDA";
            // 
            // lblValTotalDenda
            // 
            lblValTotalDenda.AutoSize = true;
            lblValTotalDenda.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblValTotalDenda.ForeColor = Color.FromArgb(183, 28, 28);
            lblValTotalDenda.Location = new Point(150, 77);
            lblValTotalDenda.Name = "lblValTotalDenda";
            lblValTotalDenda.Size = new Size(76, 38);
            lblValTotalDenda.TabIndex = 6;
            lblValTotalDenda.Text = "Rp 0";
            // 
            // grpInputKembali
            // 
            grpInputKembali.BackColor = Color.White;
            grpInputKembali.Controls.Add(lblTglAktual);
            grpInputKembali.Controls.Add(dtpTglAktual);
            grpInputKembali.Controls.Add(lblKondisi);
            grpInputKembali.Controls.Add(cboKondisi);
            grpInputKembali.Controls.Add(lblCatatan);
            grpInputKembali.Controls.Add(txtCatatan);
            grpInputKembali.Dock = DockStyle.Top;
            grpInputKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInputKembali.ForeColor = Color.FromArgb(183, 28, 28);
            grpInputKembali.Location = new Point(12, 242);
            grpInputKembali.Margin = new Padding(0, 6, 0, 0);
            grpInputKembali.Name = "grpInputKembali";
            grpInputKembali.Padding = new Padding(12, 14, 12, 10);
            grpInputKembali.Size = new Size(377, 178);
            grpInputKembali.TabIndex = 2;
            grpInputKembali.TabStop = false;
            grpInputKembali.Text = "  Data Pengembalian";
            // 
            // lblTglAktual
            // 
            lblTglAktual.Font = new Font("Segoe UI", 9F);
            lblTglAktual.ForeColor = Color.FromArgb(70, 70, 70);
            lblTglAktual.Location = new Point(12, 30);
            lblTglAktual.Name = "lblTglAktual";
            lblTglAktual.Size = new Size(118, 20);
            lblTglAktual.TabIndex = 0;
            lblTglAktual.Text = "Tgl Kembali :";
            // 
            // dtpTglAktual
            // 
            dtpTglAktual.Font = new Font("Segoe UI", 9F);
            dtpTglAktual.Format = DateTimePickerFormat.Short;
            dtpTglAktual.Location = new Point(134, 26);
            dtpTglAktual.Name = "dtpTglAktual";
            dtpTglAktual.Size = new Size(220, 31);
            dtpTglAktual.TabIndex = 1;
            // 
            // lblKondisi
            // 
            lblKondisi.Font = new Font("Segoe UI", 9F);
            lblKondisi.ForeColor = Color.FromArgb(70, 70, 70);
            lblKondisi.Location = new Point(12, 72);
            lblKondisi.Name = "lblKondisi";
            lblKondisi.Size = new Size(118, 20);
            lblKondisi.TabIndex = 2;
            lblKondisi.Text = "Kondisi Mobil :";
            // 
            // cboKondisi
            // 
            cboKondisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKondisi.FlatStyle = FlatStyle.Flat;
            cboKondisi.Font = new Font("Segoe UI", 9F);
            cboKondisi.Items.AddRange(new object[] { "Baik", "Rusak Ringan", "Rusak Berat" });
            cboKondisi.Location = new Point(134, 68);
            cboKondisi.Name = "cboKondisi";
            cboKondisi.Size = new Size(220, 33);
            cboKondisi.TabIndex = 3;
            // 
            // lblCatatan
            // 
            lblCatatan.Font = new Font("Segoe UI", 9F);
            lblCatatan.ForeColor = Color.FromArgb(70, 70, 70);
            lblCatatan.Location = new Point(12, 114);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Size = new Size(118, 20);
            lblCatatan.TabIndex = 4;
            lblCatatan.Text = "Catatan :";
            // 
            // txtCatatan
            // 
            txtCatatan.BorderStyle = BorderStyle.FixedSingle;
            txtCatatan.Font = new Font("Segoe UI", 9F);
            txtCatatan.Location = new Point(134, 110);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.ScrollBars = ScrollBars.Vertical;
            txtCatatan.Size = new Size(220, 50);
            txtCatatan.TabIndex = 5;
            // 
            // grpInfoSewa
            // 
            grpInfoSewa.BackColor = Color.FromArgb(255, 250, 250);
            grpInfoSewa.Controls.Add(lblTagPelanggan);
            grpInfoSewa.Controls.Add(lblValPelanggan);
            grpInfoSewa.Controls.Add(lblTagMobil);
            grpInfoSewa.Controls.Add(lblValMobil);
            grpInfoSewa.Controls.Add(lblTagTglSewa);
            grpInfoSewa.Controls.Add(lblValTglSewa);
            grpInfoSewa.Controls.Add(lblTagRencana);
            grpInfoSewa.Controls.Add(lblValRencana);
            grpInfoSewa.Controls.Add(lblTagTotalBiaya);
            grpInfoSewa.Controls.Add(lblValTotalBiaya);
            grpInfoSewa.Dock = DockStyle.Top;
            grpInfoSewa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInfoSewa.ForeColor = Color.FromArgb(183, 28, 28);
            grpInfoSewa.Location = new Point(12, 84);
            grpInfoSewa.Margin = new Padding(0, 6, 0, 0);
            grpInfoSewa.Name = "grpInfoSewa";
            grpInfoSewa.Size = new Size(377, 158);
            grpInfoSewa.TabIndex = 3;
            grpInfoSewa.TabStop = false;
            grpInfoSewa.Text = "  Detail Sewa";
            // 
            // lblTagPelanggan
            // 
            lblTagPelanggan.Font = new Font("Segoe UI", 9F);
            lblTagPelanggan.ForeColor = Color.Gray;
            lblTagPelanggan.Location = new Point(12, 26);
            lblTagPelanggan.Name = "lblTagPelanggan";
            lblTagPelanggan.Size = new Size(105, 20);
            lblTagPelanggan.TabIndex = 0;
            lblTagPelanggan.Text = "Pelanggan";
            // 
            // lblValPelanggan
            // 
            lblValPelanggan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValPelanggan.ForeColor = Color.FromArgb(30, 30, 30);
            lblValPelanggan.Location = new Point(120, 26);
            lblValPelanggan.Name = "lblValPelanggan";
            lblValPelanggan.Size = new Size(240, 20);
            lblValPelanggan.TabIndex = 1;
            lblValPelanggan.Text = "—";
            // 
            // lblTagMobil
            // 
            lblTagMobil.Font = new Font("Segoe UI", 9F);
            lblTagMobil.ForeColor = Color.Gray;
            lblTagMobil.Location = new Point(12, 50);
            lblTagMobil.Name = "lblTagMobil";
            lblTagMobil.Size = new Size(105, 20);
            lblTagMobil.TabIndex = 2;
            lblTagMobil.Text = "Mobil";
            // 
            // lblValMobil
            // 
            lblValMobil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValMobil.ForeColor = Color.FromArgb(30, 30, 30);
            lblValMobil.Location = new Point(120, 50);
            lblValMobil.Name = "lblValMobil";
            lblValMobil.Size = new Size(240, 20);
            lblValMobil.TabIndex = 3;
            lblValMobil.Text = "—";
            // 
            // lblTagTglSewa
            // 
            lblTagTglSewa.Font = new Font("Segoe UI", 9F);
            lblTagTglSewa.ForeColor = Color.Gray;
            lblTagTglSewa.Location = new Point(12, 74);
            lblTagTglSewa.Name = "lblTagTglSewa";
            lblTagTglSewa.Size = new Size(105, 20);
            lblTagTglSewa.TabIndex = 4;
            lblTagTglSewa.Text = "Tgl Sewa";
            // 
            // lblValTglSewa
            // 
            lblValTglSewa.Font = new Font("Segoe UI", 9F);
            lblValTglSewa.ForeColor = Color.FromArgb(30, 30, 30);
            lblValTglSewa.Location = new Point(120, 74);
            lblValTglSewa.Name = "lblValTglSewa";
            lblValTglSewa.Size = new Size(240, 20);
            lblValTglSewa.TabIndex = 5;
            lblValTglSewa.Text = "—";
            // 
            // lblTagRencana
            // 
            lblTagRencana.Font = new Font("Segoe UI", 9F);
            lblTagRencana.ForeColor = Color.Gray;
            lblTagRencana.Location = new Point(12, 98);
            lblTagRencana.Name = "lblTagRencana";
            lblTagRencana.Size = new Size(105, 20);
            lblTagRencana.TabIndex = 6;
            lblTagRencana.Text = "Rencana Kembali";
            // 
            // lblValRencana
            // 
            lblValRencana.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValRencana.ForeColor = Color.FromArgb(183, 28, 28);
            lblValRencana.Location = new Point(120, 98);
            lblValRencana.Name = "lblValRencana";
            lblValRencana.Size = new Size(240, 20);
            lblValRencana.TabIndex = 7;
            lblValRencana.Text = "—";
            // 
            // lblTagTotalBiaya
            // 
            lblTagTotalBiaya.Font = new Font("Segoe UI", 9F);
            lblTagTotalBiaya.ForeColor = Color.Gray;
            lblTagTotalBiaya.Location = new Point(12, 122);
            lblTagTotalBiaya.Name = "lblTagTotalBiaya";
            lblTagTotalBiaya.Size = new Size(105, 25);
            lblTagTotalBiaya.TabIndex = 8;
            lblTagTotalBiaya.Text = "Total Biaya";
            // 
            // lblValTotalBiaya
            // 
            lblValTotalBiaya.AutoSize = true;
            lblValTotalBiaya.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValTotalBiaya.ForeColor = Color.FromArgb(21, 128, 61);
            lblValTotalBiaya.Location = new Point(120, 119);
            lblValTotalBiaya.Name = "lblValTotalBiaya";
            lblValTotalBiaya.Size = new Size(32, 28);
            lblValTotalBiaya.TabIndex = 9;
            lblValTotalBiaya.Text = "—";
            // 
            // grpPilihTransaksi
            // 
            grpPilihTransaksi.BackColor = Color.White;
            grpPilihTransaksi.Controls.Add(lblTransaksi);
            grpPilihTransaksi.Controls.Add(cboTransaksi);
            grpPilihTransaksi.Dock = DockStyle.Top;
            grpPilihTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPilihTransaksi.ForeColor = Color.FromArgb(183, 28, 28);
            grpPilihTransaksi.Location = new Point(12, 12);
            grpPilihTransaksi.Name = "grpPilihTransaksi";
            grpPilihTransaksi.Padding = new Padding(12, 10, 12, 10);
            grpPilihTransaksi.Size = new Size(377, 72);
            grpPilihTransaksi.TabIndex = 4;
            grpPilihTransaksi.TabStop = false;
            grpPilihTransaksi.Text = "  Pilih Transaksi Aktif";
            // 
            // lblTransaksi
            // 
            lblTransaksi.Font = new Font("Segoe UI", 9F);
            lblTransaksi.ForeColor = Color.FromArgb(70, 70, 70);
            lblTransaksi.Location = new Point(12, 30);
            lblTransaksi.Name = "lblTransaksi";
            lblTransaksi.Size = new Size(80, 20);
            lblTransaksi.TabIndex = 0;
            lblTransaksi.Text = "Transaksi :";
            // 
            // cboTransaksi
            // 
            cboTransaksi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransaksi.FlatStyle = FlatStyle.Flat;
            cboTransaksi.Font = new Font("Segoe UI", 9F);
            cboTransaksi.Location = new Point(96, 26);
            cboTransaksi.Name = "cboTransaksi";
            cboTransaksi.Size = new Size(258, 33);
            cboTransaksi.TabIndex = 1;
            // 
            // pnlKanan
            // 
            pnlKanan.BackColor = Color.FromArgb(245, 246, 250);
            pnlKanan.Controls.Add(grpDaftar);
            pnlKanan.Dock = DockStyle.Fill;
            pnlKanan.Location = new Point(395, 72);
            pnlKanan.Name = "pnlKanan";
            pnlKanan.Padding = new Padding(6, 12, 12, 12);
            pnlKanan.Size = new Size(805, 678);
            pnlKanan.TabIndex = 0;
            // 
            // grpDaftar
            // 
            grpDaftar.BackColor = Color.White;
            grpDaftar.Controls.Add(pnlToolbar);
            grpDaftar.Controls.Add(dgvPengembalian);
            grpDaftar.Dock = DockStyle.Fill;
            grpDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDaftar.ForeColor = Color.FromArgb(183, 28, 28);
            grpDaftar.Location = new Point(6, 12);
            grpDaftar.Name = "grpDaftar";
            grpDaftar.Size = new Size(787, 654);
            grpDaftar.TabIndex = 0;
            grpDaftar.TabStop = false;
            grpDaftar.Text = "  Riwayat Pengembalian";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtCari);
            pnlToolbar.Controls.Add(btnCari);
            pnlToolbar.Controls.Add(cboFilterKondisi);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(3, 27);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(10, 8, 10, 0);
            pnlToolbar.Size = new Size(781, 44);
            pnlToolbar.TabIndex = 0;
            pnlToolbar.Paint += pnlToolbar_Paint;
            // 
            // txtCari
            // 
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Font = new Font("Segoe UI", 9F);
            txtCari.Location = new Point(10, 8);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(200, 31);
            txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(183, 28, 28);
            btnCari.Cursor = Cursors.Hand;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9F);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(218, 8);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(55, 31);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // cboFilterKondisi
            // 
            cboFilterKondisi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterKondisi.FlatStyle = FlatStyle.Flat;
            cboFilterKondisi.Font = new Font("Segoe UI", 9F);
            cboFilterKondisi.Items.AddRange(new object[] { "Semua Kondisi", "Baik", "Rusak Ringan", "Rusak Berat" });
            cboFilterKondisi.Location = new Point(282, 8);
            cboFilterKondisi.Name = "cboFilterKondisi";
            cboFilterKondisi.Size = new Size(140, 33);
            cboFilterKondisi.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(430, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(81, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvPengembalian
            // 
            dgvPengembalian.AllowUserToAddRows = false;
            dgvPengembalian.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 250, 250);
            dgvPengembalian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvPengembalian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengembalian.BackgroundColor = Color.White;
            dgvPengembalian.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(183, 28, 28);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.Padding = new Padding(4, 6, 4, 6);
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvPengembalian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvPengembalian.ColumnHeadersHeight = 38;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(183, 28, 28);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 220, 220);
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvPengembalian.DefaultCellStyle = dataGridViewCellStyle15;
            dgvPengembalian.Dock = DockStyle.Fill;
            dgvPengembalian.EnableHeadersVisualStyles = false;
            dgvPengembalian.Font = new Font("Segoe UI", 9F);
            dgvPengembalian.GridColor = Color.FromArgb(230, 230, 230);
            dgvPengembalian.Location = new Point(3, 27);
            dgvPengembalian.MultiSelect = false;
            dgvPengembalian.Name = "dgvPengembalian";
            dgvPengembalian.ReadOnly = true;
            dgvPengembalian.RowHeadersVisible = false;
            dgvPengembalian.RowHeadersWidth = 62;
            dgvPengembalian.RowTemplate.Height = 32;
            dgvPengembalian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengembalian.Size = new Size(781, 624);
            dgvPengembalian.TabIndex = 1;
            // 
            // UC__PengembalianMobil
            // 
            BackColor = Color.FromArgb(245, 246, 250);
            Controls.Add(pnlKanan);
            Controls.Add(pnlKiri);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 680);
            Name = "UC__PengembalianMobil";
            Size = new Size(1200, 750);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKiri.ResumeLayout(false);
            pnlTombol.ResumeLayout(false);
            grpRingkasanDenda.ResumeLayout(false);
            grpRingkasanDenda.PerformLayout();
            grpInputKembali.ResumeLayout(false);
            grpInputKembali.PerformLayout();
            grpInfoSewa.ResumeLayout(false);
            grpInfoSewa.PerformLayout();
            grpPilihTransaksi.ResumeLayout(false);
            pnlKanan.ResumeLayout(false);
            grpDaftar.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengembalian).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Panel pnlKiri;
        private System.Windows.Forms.GroupBox grpPilihTransaksi;
        private System.Windows.Forms.Label lblTransaksi;
        private System.Windows.Forms.ComboBox cboTransaksi;
        private System.Windows.Forms.GroupBox grpInfoSewa;
        private System.Windows.Forms.Label lblTagPelanggan;
        private System.Windows.Forms.Label lblValPelanggan;
        private System.Windows.Forms.Label lblTagMobil;
        private System.Windows.Forms.Label lblValMobil;
        private System.Windows.Forms.Label lblTagTglSewa;
        private System.Windows.Forms.Label lblValTglSewa;
        private System.Windows.Forms.Label lblTagRencana;
        private System.Windows.Forms.Label lblValRencana;
        private System.Windows.Forms.Label lblTagTotalBiaya;
        private System.Windows.Forms.Label lblValTotalBiaya;
        private System.Windows.Forms.GroupBox grpInputKembali;
        private System.Windows.Forms.Label lblTglAktual;
        private System.Windows.Forms.DateTimePicker dtpTglAktual;
        private System.Windows.Forms.Label lblKondisi;
        private System.Windows.Forms.ComboBox cboKondisi;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.GroupBox grpRingkasanDenda;
        private System.Windows.Forms.Label lblTagTelatJudul;
        private System.Windows.Forms.Label lblValTelat;
        private System.Windows.Forms.Label lblTagDendaJudul;
        private System.Windows.Forms.Label lblValDenda;
        private System.Windows.Forms.Panel pnlGarisDenda;
        private System.Windows.Forms.Label lblTagTotalDenda;
        private System.Windows.Forms.Label lblValTotalDenda;
        private System.Windows.Forms.Panel pnlTombol;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlKanan;
        private System.Windows.Forms.GroupBox grpDaftar;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cboFilterKondisi;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPengembalian;
    }
}