namespace Rental_app
{
    partial class Form1
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

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            btn_rental = new Button();
            lblAccentBar = new Label();
            lblMenuSection = new Label();
            lblDivider = new Label();
            btn_transaksi = new Button();
            btn_status = new Button();
            btn_laporan = new Button();
            btn_dataPelanggan = new Button();
            btn_daftarMobil = new Button();
            btn_kategori = new Button();
            btn_dashboard = new Button();
            panelHeader = new Panel();
            label1 = new Label();
            lblDate = new Label();
            panelContent = new Panel();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(18, 30, 46);
            panelSidebar.Controls.Add(btn_rental);
            panelSidebar.Controls.Add(lblAccentBar);
            panelSidebar.Controls.Add(lblMenuSection);
            panelSidebar.Controls.Add(lblDivider);
            panelSidebar.Controls.Add(btn_transaksi);
            panelSidebar.Controls.Add(btn_status);
            panelSidebar.Controls.Add(btn_laporan);
            panelSidebar.Controls.Add(btn_dataPelanggan);
            panelSidebar.Controls.Add(btn_daftarMobil);
            panelSidebar.Controls.Add(btn_kategori);
            panelSidebar.Controls.Add(btn_dashboard);
            panelSidebar.Controls.Add(panelHeader);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(260, 728);
            panelSidebar.TabIndex = 0;
            // 
            // btn_rental
            // 
            btn_rental.BackColor = Color.FromArgb(18, 30, 46);
            btn_rental.FlatAppearance.BorderSize = 0;
            btn_rental.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_rental.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_rental.FlatStyle = FlatStyle.Flat;
            btn_rental.Font = new Font("Segoe UI", 10F);
            btn_rental.ForeColor = Color.White;
            btn_rental.Location = new Point(10, 474);
            btn_rental.Name = "btn_rental";
            btn_rental.Padding = new Padding(14, 0, 0, 0);
            btn_rental.Size = new Size(240, 48);
            btn_rental.TabIndex = 6;
            btn_rental.Text = "🕑   Status Rental";
            btn_rental.TextAlign = ContentAlignment.MiddleLeft;
            btn_rental.UseVisualStyleBackColor = false;
            btn_rental.Click += btn_rental_Click;
            // 
            // lblAccentBar
            // 
            lblAccentBar.BackColor = Color.FromArgb(56, 152, 236);
            lblAccentBar.Location = new Point(0, 108);
            lblAccentBar.Name = "lblAccentBar";
            lblAccentBar.Size = new Size(260, 3);
            lblAccentBar.TabIndex = 20;
            // 
            // lblMenuSection
            // 
            lblMenuSection.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblMenuSection.ForeColor = Color.FromArgb(80, 120, 165);
            lblMenuSection.Location = new Point(22, 122);
            lblMenuSection.Name = "lblMenuSection";
            lblMenuSection.Size = new Size(216, 22);
            lblMenuSection.TabIndex = 21;
            lblMenuSection.Text = "MENU UTAMA";
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.FromArgb(35, 55, 80);
            lblDivider.Location = new Point(20, 534);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(220, 1);
            lblDivider.TabIndex = 22;
            // 
            // btn_transaksi
            // 
            btn_transaksi.BackColor = Color.FromArgb(18, 30, 46);
            btn_transaksi.FlatAppearance.BorderSize = 0;
            btn_transaksi.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_transaksi.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_transaksi.FlatStyle = FlatStyle.Flat;
            btn_transaksi.Font = new Font("Segoe UI", 10F);
            btn_transaksi.ForeColor = Color.White;
            btn_transaksi.Location = new Point(10, 366);
            btn_transaksi.Name = "btn_transaksi";
            btn_transaksi.Padding = new Padding(14, 0, 0, 0);
            btn_transaksi.Size = new Size(240, 48);
            btn_transaksi.TabIndex = 4;
            btn_transaksi.Text = "💰   Transaksi";
            btn_transaksi.TextAlign = ContentAlignment.MiddleLeft;
            btn_transaksi.UseVisualStyleBackColor = false;
            btn_transaksi.Click += btn_transaksi_Click_1;
            // 
            // btn_status
            // 
            btn_status.BackColor = Color.FromArgb(18, 30, 46);
            btn_status.FlatAppearance.BorderSize = 0;
            btn_status.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_status.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_status.FlatStyle = FlatStyle.Flat;
            btn_status.Font = new Font("Segoe UI", 10F);
            btn_status.ForeColor = Color.White;
            btn_status.Location = new Point(10, 420);
            btn_status.Name = "btn_status";
            btn_status.Padding = new Padding(14, 0, 0, 0);
            btn_status.Size = new Size(240, 48);
            btn_status.TabIndex = 5;
            btn_status.Text = "📋   Pembayaran";
            btn_status.TextAlign = ContentAlignment.MiddleLeft;
            btn_status.UseVisualStyleBackColor = false;
            btn_status.Click += btn_status_Click;
            // 
            // btn_laporan
            // 
            btn_laporan.BackColor = Color.FromArgb(18, 30, 46);
            btn_laporan.FlatAppearance.BorderSize = 0;
            btn_laporan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_laporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_laporan.FlatStyle = FlatStyle.Flat;
            btn_laporan.Font = new Font("Segoe UI", 10F);
            btn_laporan.ForeColor = Color.White;
            btn_laporan.Location = new Point(10, 542);
            btn_laporan.Name = "btn_laporan";
            btn_laporan.Padding = new Padding(14, 0, 0, 0);
            btn_laporan.Size = new Size(240, 48);
            btn_laporan.TabIndex = 7;
            btn_laporan.Text = "⚙️   Pengaturan";
            btn_laporan.TextAlign = ContentAlignment.MiddleLeft;
            btn_laporan.UseVisualStyleBackColor = false;
            btn_laporan.Visible = false;
            btn_laporan.Click += btn_laporan_Click;
            // 
            // btn_dataPelanggan
            // 
            btn_dataPelanggan.BackColor = Color.FromArgb(18, 30, 46);
            btn_dataPelanggan.FlatAppearance.BorderSize = 0;
            btn_dataPelanggan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_dataPelanggan.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_dataPelanggan.FlatStyle = FlatStyle.Flat;
            btn_dataPelanggan.Font = new Font("Segoe UI", 10F);
            btn_dataPelanggan.ForeColor = Color.White;
            btn_dataPelanggan.Location = new Point(10, 312);
            btn_dataPelanggan.Name = "btn_dataPelanggan";
            btn_dataPelanggan.Padding = new Padding(14, 0, 0, 0);
            btn_dataPelanggan.Size = new Size(240, 48);
            btn_dataPelanggan.TabIndex = 6;
            btn_dataPelanggan.Text = "👥   Data Pelanggan";
            btn_dataPelanggan.TextAlign = ContentAlignment.MiddleLeft;
            btn_dataPelanggan.UseVisualStyleBackColor = false;
            btn_dataPelanggan.Click += btn_dataPelanggan_Click;
            // 
            // btn_daftarMobil
            // 
            btn_daftarMobil.BackColor = Color.FromArgb(18, 30, 46);
            btn_daftarMobil.FlatAppearance.BorderSize = 0;
            btn_daftarMobil.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_daftarMobil.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_daftarMobil.FlatStyle = FlatStyle.Flat;
            btn_daftarMobil.Font = new Font("Segoe UI", 10F);
            btn_daftarMobil.ForeColor = Color.White;
            btn_daftarMobil.Location = new Point(10, 258);
            btn_daftarMobil.Name = "btn_daftarMobil";
            btn_daftarMobil.Padding = new Padding(14, 0, 0, 0);
            btn_daftarMobil.Size = new Size(240, 48);
            btn_daftarMobil.TabIndex = 3;
            btn_daftarMobil.Text = "📝   Daftar Mobil";
            btn_daftarMobil.TextAlign = ContentAlignment.MiddleLeft;
            btn_daftarMobil.UseVisualStyleBackColor = false;
            btn_daftarMobil.Click += button3_Click;
            // 
            // btn_kategori
            // 
            btn_kategori.BackColor = Color.FromArgb(18, 30, 46);
            btn_kategori.FlatAppearance.BorderSize = 0;
            btn_kategori.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_kategori.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_kategori.FlatStyle = FlatStyle.Flat;
            btn_kategori.Font = new Font("Segoe UI", 10F);
            btn_kategori.ForeColor = Color.White;
            btn_kategori.Location = new Point(10, 204);
            btn_kategori.Name = "btn_kategori";
            btn_kategori.Padding = new Padding(14, 0, 0, 0);
            btn_kategori.Size = new Size(240, 48);
            btn_kategori.TabIndex = 2;
            btn_kategori.Text = "🏷️   Kategori Mobil";
            btn_kategori.TextAlign = ContentAlignment.MiddleLeft;
            btn_kategori.UseVisualStyleBackColor = false;
            btn_kategori.Click += button2_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.FromArgb(18, 30, 46);
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 80, 118);
            btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 52, 78);
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 10F);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Location = new Point(10, 150);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(14, 0, 0, 0);
            btn_dashboard.Size = new Size(240, 48);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "📊   Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(12, 21, 34);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(lblDate);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(260, 108);
            panelHeader.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 0;
            label1.Text = "🚗  RentalCar";
            label1.Click += label1_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 8.5F);
            lblDate.ForeColor = Color.FromArgb(140, 170, 200);
            lblDate.Location = new Point(24, 60);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(170, 23);
            lblDate.TabIndex = 1;
            lblDate.Text = "Senin, 30 Maret 2026";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(240, 242, 245);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(260, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1544, 728);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1804, 728);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Sistem Manajemen Rental Mobil";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #region Component Designer generated code
        #endregion

        private Panel panelSidebar;
        private Panel panelHeader;
        private Label label1;
        private Label lblDate;
        private Button btn_dataPelanggan;
        private Button btn_status;
        private Button btn_transaksi;
        private Button btn_daftarMobil;
        private Button btn_kategori;
        private Button btn_dashboard;
        private Panel panelContent;
        private Button btn_laporan;
        private Button btn_rental;
        private Label lblAccentBar;
        private Label lblMenuSection;
        private Label lblDivider;
    }
}