namespace Rental_app
{

    partial class UC__TransaksiPenyewaan
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubJudul = new Label();
            lblJudul = new Label();
            cboPelanggan = new ComboBox();
            pnlKiri = new Panel();
            pnlTombol = new Panel();
            btnReset = new Button();
            btnBatal = new Button();
            btnSimpan = new Button();
            grpRingkasan = new GroupBox();
            lblTotalBiaya = new Label();
            lblTagTotalJudul = new Label();
            pnlGarisTotal = new Panel();
            lblDurasi = new Label();
            lblTagDurasiJudul = new Label();
            lblhargaPerHari = new Label();
            lblTaghargaJudul = new Label();
            grpInput = new GroupBox();
            txtCatatan = new TextBox();
            lblCatatan = new Label();
            dtpTglKembali = new DateTimePicker();
            lblTglKembali = new Label();
            dtpTglSewa = new DateTimePicker();
            lblTglSewa = new Label();
            cboMobil = new ComboBox();
            lblMobil = new Label();
            lblPelanggan = new Label();
            pnlKanan = new Panel();
            grpDaftar = new GroupBox();
            dgvTransaksi = new DataGridView();
            pnlToolbar = new Panel();
            btnRefresh = new Button();
            btnCari = new Button();
            txtCari = new TextBox();
            pnlHeader.SuspendLayout();
            pnlKiri.SuspendLayout();
            pnlTombol.SuspendLayout();
            grpRingkasan.SuspendLayout();
            grpInput.SuspendLayout();
            pnlKanan.SuspendLayout();
            grpDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 136, 229);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(29, 17, 29, 17);
            pnlHeader.Size = new Size(1714, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 9F);
            lblSubJudul.ForeColor = Color.FromArgb(180, 220, 255);
            lblSubJudul.Location = new Point(31, 70);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(283, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Kelola data sewa mobil pelanggan";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(29, 13);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(353, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "  Transaksi Penyewaan";
            // 
            // cboPelanggan
            // 
            cboPelanggan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelanggan.FlatStyle = FlatStyle.Flat;
            cboPelanggan.Font = new Font("Segoe UI", 9F);
            cboPelanggan.FormattingEnabled = true;
            cboPelanggan.Location = new Point(195, 55);
            cboPelanggan.Margin = new Padding(4, 5, 4, 5);
            cboPelanggan.Name = "cboPelanggan";
            cboPelanggan.Size = new Size(298, 33);
            cboPelanggan.TabIndex = 1;
            cboPelanggan.SelectedIndexChanged += cboPelanggan_SelectedIndexChanged;
            // 
            // pnlKiri
            // 
            pnlKiri.BackColor = Color.FromArgb(245, 246, 250);
            pnlKiri.Controls.Add(pnlTombol);
            pnlKiri.Controls.Add(grpRingkasan);
            pnlKiri.Controls.Add(grpInput);
            pnlKiri.Dock = DockStyle.Left;
            pnlKiri.Location = new Point(0, 120);
            pnlKiri.Margin = new Padding(4, 5, 4, 5);
            pnlKiri.Name = "pnlKiri";
            pnlKiri.Padding = new Padding(17, 20, 9, 20);
            pnlKiri.Size = new Size(550, 1130);
            pnlKiri.TabIndex = 1;
            // 
            // pnlTombol
            // 
            pnlTombol.BackColor = Color.FromArgb(245, 246, 250);
            pnlTombol.Controls.Add(btnReset);
            pnlTombol.Controls.Add(btnBatal);
            pnlTombol.Controls.Add(btnSimpan);
            pnlTombol.Dock = DockStyle.Top;
            pnlTombol.Location = new Point(17, 741);
            pnlTombol.Margin = new Padding(4, 5, 4, 5);
            pnlTombol.Name = "pnlTombol";
            pnlTombol.Size = new Size(524, 93);
            pnlTombol.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(108, 117, 125);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(309, 17);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 60);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(220, 53, 69);
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(154, 17);
            btnBatal.Margin = new Padding(4, 5, 4, 5);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(143, 60);
            btnBatal.TabIndex = 1;
            btnBatal.Text = "Batalkan";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(30, 136, 229);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(0, 17);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(143, 60);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // grpRingkasan
            // 
            grpRingkasan.BackColor = Color.White;
            grpRingkasan.Controls.Add(lblTotalBiaya);
            grpRingkasan.Controls.Add(lblTagTotalJudul);
            grpRingkasan.Controls.Add(pnlGarisTotal);
            grpRingkasan.Controls.Add(lblDurasi);
            grpRingkasan.Controls.Add(lblTagDurasiJudul);
            grpRingkasan.Controls.Add(lblhargaPerHari);
            grpRingkasan.Controls.Add(lblTaghargaJudul);
            grpRingkasan.Dock = DockStyle.Top;
            grpRingkasan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpRingkasan.ForeColor = Color.FromArgb(30, 136, 229);
            grpRingkasan.Location = new Point(17, 528);
            grpRingkasan.Margin = new Padding(0, 13, 0, 0);
            grpRingkasan.Name = "grpRingkasan";
            grpRingkasan.Padding = new Padding(4, 27, 4, 5);
            grpRingkasan.Size = new Size(524, 213);
            grpRingkasan.TabIndex = 1;
            grpRingkasan.TabStop = false;
            grpRingkasan.Text = "  Ringkasan Biaya";
            // 
            // lblTotalBiaya
            // 
            lblTotalBiaya.AutoSize = true;
            lblTotalBiaya.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalBiaya.ForeColor = Color.FromArgb(21, 128, 61);
            lblTotalBiaya.Location = new Point(214, 130);
            lblTotalBiaya.Margin = new Padding(4, 0, 4, 0);
            lblTotalBiaya.Name = "lblTotalBiaya";
            lblTotalBiaya.Size = new Size(45, 38);
            lblTotalBiaya.TabIndex = 6;
            lblTotalBiaya.Text = "—";
            // 
            // lblTagTotalJudul
            // 
            lblTagTotalJudul.AutoSize = true;
            lblTagTotalJudul.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTagTotalJudul.Location = new Point(20, 137);
            lblTagTotalJudul.Margin = new Padding(4, 0, 4, 0);
            lblTagTotalJudul.Name = "lblTagTotalJudul";
            lblTagTotalJudul.Size = new Size(125, 25);
            lblTagTotalJudul.TabIndex = 5;
            lblTagTotalJudul.Text = "TOTAL BIAYA";
            // 
            // pnlGarisTotal
            // 
            pnlGarisTotal.BackColor = Color.LightGray;
            pnlGarisTotal.Location = new Point(20, 117);
            pnlGarisTotal.Margin = new Padding(4, 5, 4, 5);
            pnlGarisTotal.Name = "pnlGarisTotal";
            pnlGarisTotal.Size = new Size(471, 2);
            pnlGarisTotal.TabIndex = 4;
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDurasi.Location = new Point(300, 80);
            lblDurasi.Margin = new Padding(4, 0, 4, 0);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(30, 25);
            lblDurasi.TabIndex = 3;
            lblDurasi.Text = "—";
            // 
            // lblTagDurasiJudul
            // 
            lblTagDurasiJudul.AutoSize = true;
            lblTagDurasiJudul.Font = new Font("Segoe UI", 9F);
            lblTagDurasiJudul.ForeColor = Color.Gray;
            lblTagDurasiJudul.Location = new Point(20, 80);
            lblTagDurasiJudul.Margin = new Padding(4, 0, 4, 0);
            lblTagDurasiJudul.Name = "lblTagDurasiJudul";
            lblTagDurasiJudul.Size = new Size(108, 25);
            lblTagDurasiJudul.TabIndex = 2;
            lblTagDurasiJudul.Text = "Durasi Sewa";
            // 
            // lblhargaPerHari
            // 
            lblhargaPerHari.AutoSize = true;
            lblhargaPerHari.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblhargaPerHari.Location = new Point(300, 40);
            lblhargaPerHari.Margin = new Padding(4, 0, 4, 0);
            lblhargaPerHari.Name = "lblhargaPerHari";
            lblhargaPerHari.Size = new Size(30, 25);
            lblhargaPerHari.TabIndex = 1;
            lblhargaPerHari.Text = "—";
            // 
            // lblTaghargaJudul
            // 
            lblTaghargaJudul.AutoSize = true;
            lblTaghargaJudul.Font = new Font("Segoe UI", 9F);
            lblTaghargaJudul.ForeColor = Color.Gray;
            lblTaghargaJudul.Location = new Point(20, 40);
            lblTaghargaJudul.Margin = new Padding(4, 0, 4, 0);
            lblTaghargaJudul.Name = "lblTaghargaJudul";
            lblTaghargaJudul.Size = new Size(106, 25);
            lblTaghargaJudul.TabIndex = 0;
            lblTaghargaJudul.Text = "harga / Hari";
            // 
            // grpInput
            // 
            grpInput.BackColor = Color.White;
            grpInput.Controls.Add(txtCatatan);
            grpInput.Controls.Add(lblCatatan);
            grpInput.Controls.Add(cboPelanggan);
            grpInput.Controls.Add(dtpTglKembali);
            grpInput.Controls.Add(lblTglKembali);
            grpInput.Controls.Add(dtpTglSewa);
            grpInput.Controls.Add(lblTglSewa);
            grpInput.Controls.Add(cboMobil);
            grpInput.Controls.Add(lblMobil);
            grpInput.Controls.Add(lblPelanggan);
            grpInput.Dock = DockStyle.Top;
            grpInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInput.ForeColor = Color.FromArgb(30, 136, 229);
            grpInput.Location = new Point(17, 20);
            grpInput.Margin = new Padding(4, 5, 4, 5);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(20, 30, 20, 17);
            grpInput.Size = new Size(524, 508);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "  Data Sewa";
            // 
            // txtCatatan
            // 
            txtCatatan.BorderStyle = BorderStyle.FixedSingle;
            txtCatatan.Font = new Font("Segoe UI", 9F);
            txtCatatan.Location = new Point(194, 340);
            txtCatatan.Margin = new Padding(4, 5, 4, 5);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.ScrollBars = ScrollBars.Vertical;
            txtCatatan.Size = new Size(299, 92);
            txtCatatan.TabIndex = 9;
            // 
            // lblCatatan
            // 
            lblCatatan.Font = new Font("Segoe UI", 9F);
            lblCatatan.ForeColor = Color.FromArgb(70, 70, 70);
            lblCatatan.Location = new Point(20, 348);
            lblCatatan.Margin = new Padding(4, 0, 4, 0);
            lblCatatan.Name = "lblCatatan";
            lblCatatan.Size = new Size(169, 33);
            lblCatatan.TabIndex = 8;
            lblCatatan.Text = "Catatan :";
            // 
            // dtpTglKembali
            // 
            dtpTglKembali.Font = new Font("Segoe UI", 9F);
            dtpTglKembali.Format = DateTimePickerFormat.Short;
            dtpTglKembali.Location = new Point(194, 267);
            dtpTglKembali.Margin = new Padding(4, 5, 4, 5);
            dtpTglKembali.Name = "dtpTglKembali";
            dtpTglKembali.Size = new Size(298, 31);
            dtpTglKembali.TabIndex = 7;
            // 
            // lblTglKembali
            // 
            lblTglKembali.Font = new Font("Segoe UI", 9F);
            lblTglKembali.ForeColor = Color.FromArgb(70, 70, 70);
            lblTglKembali.Location = new Point(20, 275);
            lblTglKembali.Margin = new Padding(4, 0, 4, 0);
            lblTglKembali.Name = "lblTglKembali";
            lblTglKembali.Size = new Size(169, 33);
            lblTglKembali.TabIndex = 6;
            lblTglKembali.Text = "Rencana Kembali :";
            // 
            // dtpTglSewa
            // 
            dtpTglSewa.Font = new Font("Segoe UI", 9F);
            dtpTglSewa.Format = DateTimePickerFormat.Short;
            dtpTglSewa.Location = new Point(194, 193);
            dtpTglSewa.Margin = new Padding(4, 5, 4, 5);
            dtpTglSewa.Name = "dtpTglSewa";
            dtpTglSewa.Size = new Size(298, 31);
            dtpTglSewa.TabIndex = 5;
            // 
            // lblTglSewa
            // 
            lblTglSewa.Font = new Font("Segoe UI", 9F);
            lblTglSewa.ForeColor = Color.FromArgb(70, 70, 70);
            lblTglSewa.Location = new Point(20, 202);
            lblTglSewa.Margin = new Padding(4, 0, 4, 0);
            lblTglSewa.Name = "lblTglSewa";
            lblTglSewa.Size = new Size(169, 33);
            lblTglSewa.TabIndex = 4;
            lblTglSewa.Text = "Tanggal Sewa :";
            // 
            // cboMobil
            // 
            cboMobil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMobil.FlatStyle = FlatStyle.Flat;
            cboMobil.Font = new Font("Segoe UI", 9F);
            cboMobil.FormattingEnabled = true;
            cboMobil.Location = new Point(194, 120);
            cboMobil.Margin = new Padding(4, 5, 4, 5);
            cboMobil.Name = "cboMobil";
            cboMobil.Size = new Size(298, 33);
            cboMobil.TabIndex = 3;
            // 
            // lblMobil
            // 
            lblMobil.Font = new Font("Segoe UI", 9F);
            lblMobil.ForeColor = Color.FromArgb(70, 70, 70);
            lblMobil.Location = new Point(20, 128);
            lblMobil.Margin = new Padding(4, 0, 4, 0);
            lblMobil.Name = "lblMobil";
            lblMobil.Size = new Size(169, 33);
            lblMobil.TabIndex = 2;
            lblMobil.Text = "Mobil :";
            // 
            // lblPelanggan
            // 
            lblPelanggan.Font = new Font("Segoe UI", 9F);
            lblPelanggan.ForeColor = Color.FromArgb(70, 70, 70);
            lblPelanggan.Location = new Point(20, 55);
            lblPelanggan.Margin = new Padding(4, 0, 4, 0);
            lblPelanggan.Name = "lblPelanggan";
            lblPelanggan.Size = new Size(169, 33);
            lblPelanggan.TabIndex = 0;
            lblPelanggan.Text = "Pelanggan :";
            // 
            // pnlKanan
            // 
            pnlKanan.BackColor = Color.FromArgb(245, 246, 250);
            pnlKanan.Controls.Add(grpDaftar);
            pnlKanan.Dock = DockStyle.Fill;
            pnlKanan.Location = new Point(550, 120);
            pnlKanan.Margin = new Padding(4, 5, 4, 5);
            pnlKanan.Name = "pnlKanan";
            pnlKanan.Padding = new Padding(9, 20, 17, 20);
            pnlKanan.Size = new Size(1164, 1130);
            pnlKanan.TabIndex = 2;
            // 
            // grpDaftar
            // 
            grpDaftar.BackColor = Color.White;
            grpDaftar.Controls.Add(dgvTransaksi);
            grpDaftar.Controls.Add(pnlToolbar);
            grpDaftar.Dock = DockStyle.Fill;
            grpDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDaftar.ForeColor = Color.FromArgb(30, 136, 229);
            grpDaftar.Location = new Point(9, 20);
            grpDaftar.Margin = new Padding(4, 5, 4, 5);
            grpDaftar.Name = "grpDaftar";
            grpDaftar.Padding = new Padding(4, 27, 4, 5);
            grpDaftar.Size = new Size(1138, 1090);
            grpDaftar.TabIndex = 0;
            grpDaftar.TabStop = false;
            grpDaftar.Text = "  Daftar Transaksi";
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 255);
            dgvTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 136, 229);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(4, 6, 4, 6);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaksi.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 136, 229);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransaksi.Dock = DockStyle.Fill;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.Font = new Font("Segoe UI", 9F);
            dgvTransaksi.GridColor = Color.FromArgb(230, 230, 230);
            dgvTransaksi.Location = new Point(4, 124);
            dgvTransaksi.Margin = new Padding(4, 5, 4, 5);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 62;
            dgvTransaksi.RowTemplate.Height = 32;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksi.Size = new Size(1130, 961);
            dgvTransaksi.TabIndex = 1;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Controls.Add(btnCari);
            pnlToolbar.Controls.Add(txtCari);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(4, 51);
            pnlToolbar.Margin = new Padding(4, 5, 4, 5);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(14, 13, 14, 0);
            pnlToolbar.Size = new Size(1130, 73);
            pnlToolbar.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(108, 117, 125);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(494, 13);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 47);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(30, 136, 229);
            btnCari.Cursor = Cursors.Hand;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI", 9F);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(397, 13);
            btnCari.Margin = new Padding(4, 5, 4, 5);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(86, 47);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // txtCari
            // 
            txtCari.BorderStyle = BorderStyle.FixedSingle;
            txtCari.Font = new Font("Segoe UI", 9F);
            txtCari.Location = new Point(14, 13);
            txtCari.Margin = new Padding(4, 5, 4, 5);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(371, 31);
            txtCari.TabIndex = 0;
            // 
            // UC__TransaksiPenyewaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            Controls.Add(pnlKanan);
            Controls.Add(pnlKiri);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1571, 1133);
            Name = "UC__TransaksiPenyewaan";
            Size = new Size(1714, 1250);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKiri.ResumeLayout(false);
            pnlTombol.ResumeLayout(false);
            grpRingkasan.ResumeLayout(false);
            grpRingkasan.PerformLayout();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            pnlKanan.ResumeLayout(false);
            grpDaftar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Panel pnlKiri;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblPelanggan;
        private System.Windows.Forms.ComboBox cboPelanggan;
        private System.Windows.Forms.Label lblMobil;
        private System.Windows.Forms.ComboBox cboMobil;
        private System.Windows.Forms.Label lblTglSewa;
        private System.Windows.Forms.DateTimePicker dtpTglSewa;
        private System.Windows.Forms.Label lblTglKembali;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.GroupBox grpRingkasan;
        private System.Windows.Forms.Label lblTaghargaJudul;
        private System.Windows.Forms.Label lblhargaPerHari;
        private System.Windows.Forms.Label lblTagDurasiJudul;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.Panel pnlGarisTotal;
        private System.Windows.Forms.Label lblTagTotalJudul;
        private System.Windows.Forms.Label lblTotalBiaya;
        private System.Windows.Forms.Panel pnlTombol;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlKanan;
        private System.Windows.Forms.GroupBox grpDaftar;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvTransaksi;
    }
}
