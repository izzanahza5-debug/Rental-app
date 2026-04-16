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
            btn_laporan = new Button();
            btn_dataPelanggan = new Button();
            btn_status = new Button();
            btn_transaksi = new Button();
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
            panelSidebar.BackColor = Color.FromArgb(41, 128, 185);
            panelSidebar.Controls.Add(btn_laporan);
            panelSidebar.Controls.Add(btn_dataPelanggan);
            panelSidebar.Controls.Add(btn_status);
            panelSidebar.Controls.Add(btn_transaksi);
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
            // btn_laporan
            // 
            btn_laporan.BackColor = Color.FromArgb(41, 128, 185);
            btn_laporan.FlatAppearance.BorderSize = 0;
            btn_laporan.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_laporan.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_laporan.FlatStyle = FlatStyle.Flat;
            btn_laporan.Font = new Font("Segoe UI", 11F);
            btn_laporan.ForeColor = Color.White;
            btn_laporan.Location = new Point(10, 460);
            btn_laporan.Name = "btn_laporan";
            btn_laporan.Size = new Size(240, 50);
            btn_laporan.TabIndex = 7;
            btn_laporan.Text = "⚙️  Pengaturan";
            btn_laporan.UseVisualStyleBackColor = false;
            btn_laporan.Click += btn_laporan_Click;
            // 
            // btn_dataPelanggan
            // 
            btn_dataPelanggan.BackColor = Color.FromArgb(41, 128, 185);
            btn_dataPelanggan.FlatAppearance.BorderSize = 0;
            btn_dataPelanggan.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_dataPelanggan.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_dataPelanggan.FlatStyle = FlatStyle.Flat;
            btn_dataPelanggan.Font = new Font("Segoe UI", 11F);
            btn_dataPelanggan.ForeColor = Color.White;
            btn_dataPelanggan.Location = new Point(10, 400);
            btn_dataPelanggan.Name = "btn_dataPelanggan";
            btn_dataPelanggan.Size = new Size(240, 50);
            btn_dataPelanggan.TabIndex = 6;
            btn_dataPelanggan.Text = "👥  Data Pelanggan";
            btn_dataPelanggan.UseVisualStyleBackColor = false;
            btn_dataPelanggan.Click += btn_dataPelanggan_Click;
            // 
            // btn_status
            // 
            btn_status.BackColor = Color.FromArgb(41, 128, 185);
            btn_status.FlatAppearance.BorderSize = 0;
            btn_status.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_status.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_status.FlatStyle = FlatStyle.Flat;
            btn_status.Font = new Font("Segoe UI", 11F);
            btn_status.ForeColor = Color.White;
            btn_status.Location = new Point(10, 340);
            btn_status.Name = "btn_status";
            btn_status.Size = new Size(240, 50);
            btn_status.TabIndex = 5;
            btn_status.Text = "📋  Status Rental";
            btn_status.UseVisualStyleBackColor = false;
            btn_status.Click += btn_status_Click;
            // 
            // btn_transaksi
            // 
            btn_transaksi.BackColor = Color.FromArgb(41, 128, 185);
            btn_transaksi.FlatAppearance.BorderSize = 0;
            btn_transaksi.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_transaksi.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_transaksi.FlatStyle = FlatStyle.Flat;
            btn_transaksi.Font = new Font("Segoe UI", 11F);
            btn_transaksi.ForeColor = Color.White;
            btn_transaksi.Location = new Point(10, 280);
            btn_transaksi.Name = "btn_transaksi";
            btn_transaksi.Size = new Size(240, 50);
            btn_transaksi.TabIndex = 4;
            btn_transaksi.Text = "💰  Transaksi";
            btn_transaksi.UseVisualStyleBackColor = false;
            btn_transaksi.Click += btn_transaksi_Click_1;
            // 
            // btn_daftarMobil
            // 
            btn_daftarMobil.BackColor = Color.FromArgb(41, 128, 185);
            btn_daftarMobil.FlatAppearance.BorderSize = 0;
            btn_daftarMobil.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_daftarMobil.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_daftarMobil.FlatStyle = FlatStyle.Flat;
            btn_daftarMobil.Font = new Font("Segoe UI", 11F);
            btn_daftarMobil.ForeColor = Color.White;
            btn_daftarMobil.Location = new Point(10, 220);
            btn_daftarMobil.Name = "btn_daftarMobil";
            btn_daftarMobil.Size = new Size(240, 50);
            btn_daftarMobil.TabIndex = 3;
            btn_daftarMobil.Text = "📝  Daftar Mobil";
            btn_daftarMobil.UseVisualStyleBackColor = false;
            btn_daftarMobil.Click += button3_Click;
            // 
            // btn_kategori
            // 
            btn_kategori.BackColor = Color.FromArgb(41, 128, 185);
            btn_kategori.FlatAppearance.BorderSize = 0;
            btn_kategori.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_kategori.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_kategori.FlatStyle = FlatStyle.Flat;
            btn_kategori.Font = new Font("Segoe UI", 11F);
            btn_kategori.ForeColor = Color.White;
            btn_kategori.Location = new Point(10, 160);
            btn_kategori.Name = "btn_kategori";
            btn_kategori.Size = new Size(240, 50);
            btn_kategori.TabIndex = 2;
            btn_kategori.Text = "🏷️  Kategori Mobil";
            btn_kategori.UseVisualStyleBackColor = false;
            btn_kategori.Click += button2_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.FromArgb(41, 128, 185);
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 100, 160);
            btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 11F);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Location = new Point(10, 100);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(240, 50);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "📊  Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 100, 160);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(lblDate);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(260, 90);
            panelHeader.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 0;
            label1.Text = "🚗 Rental";
            label1.Click += label1_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(34, 44);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(180, 25);
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
    }
}
