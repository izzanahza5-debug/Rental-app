namespace Rental_app
{
    partial class UC_Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblDashboardTitle = new Label();
            lblDashboardSubtitle = new Label();
            flowLayoutStats = new FlowLayoutPanel();
            cardTotal = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cardTersedia = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cardPelanggan = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cardPendapatan = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panelChart = new Panel();
            dataGridView1 = new DataGridView();
            lblChartTitle = new Label();
            chartMobil = new PictureBox();
            panelPopuler = new Panel();
            lblPopulerTitle = new Label();
            listPopuler = new ListBox();
            panelTransaksi = new Panel();
            lblTransaksiTitle = new Label();
            gridKategori = new DataGridView();
            flowLayoutStats.SuspendLayout();
            cardTotal.SuspendLayout();
            cardTersedia.SuspendLayout();
            cardPelanggan.SuspendLayout();
            cardPendapatan.SuspendLayout();
            panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMobil).BeginInit();
            panelPopuler.SuspendLayout();
            panelTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridKategori).BeginInit();
            SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDashboardTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblDashboardTitle.Location = new Point(20, 20);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(249, 60);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // lblDashboardSubtitle
            // 
            lblDashboardSubtitle.AutoSize = true;
            lblDashboardSubtitle.Font = new Font("Segoe UI", 10F);
            lblDashboardSubtitle.ForeColor = Color.FromArgb(150, 150, 150);
            lblDashboardSubtitle.Location = new Point(20, 75);
            lblDashboardSubtitle.Name = "lblDashboardSubtitle";
            lblDashboardSubtitle.Size = new Size(448, 28);
            lblDashboardSubtitle.TabIndex = 1;
            lblDashboardSubtitle.Text = "Selamat datang di sistem manajemen rental mobil";
            // 
            // flowLayoutStats
            // 
            flowLayoutStats.Controls.Add(cardTotal);
            flowLayoutStats.Controls.Add(cardTersedia);
            flowLayoutStats.Controls.Add(cardPelanggan);
            flowLayoutStats.Controls.Add(cardPendapatan);
            flowLayoutStats.Location = new Point(20, 110);
            flowLayoutStats.Name = "flowLayoutStats";
            flowLayoutStats.Size = new Size(1400, 150);
            flowLayoutStats.TabIndex = 2;
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.BorderStyle = BorderStyle.FixedSingle;
            cardTotal.Controls.Add(label3);
            cardTotal.Controls.Add(label2);
            cardTotal.Controls.Add(label1);
            cardTotal.Location = new Point(0, 0);
            cardTotal.Margin = new Padding(0, 0, 15, 0);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(330, 130);
            cardTotal.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(33, 33, 33);
            label3.Location = new Point(70, 67);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 8;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Cambria", 29F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(31, 120, 255);
            label2.Location = new Point(202, 23);
            label2.Name = "label2";
            label2.Size = new Size(97, 68);
            label2.TabIndex = 7;
            label2.Text = "🚗";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(122, 122, 122);
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 6;
            label1.Text = "Total Mobil";
            label1.Click += label1_Click;
            // 
            // cardTersedia
            // 
            cardTersedia.BackColor = Color.White;
            cardTersedia.BorderStyle = BorderStyle.FixedSingle;
            cardTersedia.Controls.Add(label4);
            cardTersedia.Controls.Add(label5);
            cardTersedia.Controls.Add(label6);
            cardTersedia.Location = new Point(345, 0);
            cardTersedia.Margin = new Padding(0, 0, 15, 0);
            cardTersedia.Name = "cardTersedia";
            cardTersedia.Size = new Size(330, 130);
            cardTersedia.TabIndex = 1;
            cardTersedia.Paint += cardTersedia_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(33, 33, 33);
            label4.Location = new Point(76, 67);
            label4.Name = "label4";
            label4.Size = new Size(0, 34);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Cambria", 29F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(51, 171, 101);
            label5.Location = new Point(228, 30);
            label5.Name = "label5";
            label5.Size = new Size(97, 68);
            label5.TabIndex = 10;
            label5.Text = "📝";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(122, 122, 122);
            label6.Location = new Point(35, 24);
            label6.Name = "label6";
            label6.Size = new Size(173, 28);
            label6.TabIndex = 9;
            label6.Text = "Peminjaman Aktif";
            // 
            // cardPelanggan
            // 
            cardPelanggan.BackColor = Color.White;
            cardPelanggan.BorderStyle = BorderStyle.FixedSingle;
            cardPelanggan.Controls.Add(label7);
            cardPelanggan.Controls.Add(label8);
            cardPelanggan.Controls.Add(label9);
            cardPelanggan.Location = new Point(690, 0);
            cardPelanggan.Margin = new Padding(0, 0, 15, 0);
            cardPelanggan.Name = "cardPelanggan";
            cardPelanggan.Size = new Size(330, 130);
            cardPelanggan.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(33, 33, 33);
            label7.Location = new Point(80, 67);
            label7.Name = "label7";
            label7.Size = new Size(0, 34);
            label7.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("Cambria", 33F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(38, 169, 199);
            label8.Location = new Point(214, 17);
            label8.Name = "label8";
            label8.Size = new Size(111, 78);
            label8.TabIndex = 10;
            label8.Text = "👥";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(122, 122, 122);
            label9.Location = new Point(27, 24);
            label9.Name = "label9";
            label9.Size = new Size(156, 28);
            label9.TabIndex = 9;
            label9.Text = "Total Pelanggan";
            // 
            // cardPendapatan
            // 
            cardPendapatan.BackColor = Color.White;
            cardPendapatan.BorderStyle = BorderStyle.FixedSingle;
            cardPendapatan.Controls.Add(label10);
            cardPendapatan.Controls.Add(label11);
            cardPendapatan.Controls.Add(label12);
            cardPendapatan.Location = new Point(1035, 0);
            cardPendapatan.Margin = new Padding(0);
            cardPendapatan.Name = "cardPendapatan";
            cardPendapatan.Size = new Size(365, 130);
            cardPendapatan.TabIndex = 3;
            cardPendapatan.Paint += cardPendapatan_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calisto MT", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(33, 33, 33);
            label10.Location = new Point(17, 67);
            label10.Name = "label10";
            label10.Size = new Size(0, 34);
            label10.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.System;
            label11.Font = new Font("Cambria", 29F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(204, 27, 27);
            label11.Location = new Point(267, 23);
            label11.Name = "label11";
            label11.Size = new Size(97, 68);
            label11.TabIndex = 10;
            label11.Text = "📊";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(122, 122, 122);
            label12.Location = new Point(48, 24);
            label12.Name = "label12";
            label12.Size = new Size(119, 28);
            label12.TabIndex = 9;
            label12.Text = "Pendapatan";
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.White;
            panelChart.BorderStyle = BorderStyle.FixedSingle;
            panelChart.Controls.Add(dataGridView1);
            panelChart.Controls.Add(lblChartTitle);
            panelChart.Controls.Add(chartMobil);
            panelChart.Location = new Point(20, 280);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(1000, 320);
            panelChart.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 71, 71);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 244, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(239, 239, 239);
            dataGridView1.Location = new Point(-1, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1000, 274);
            dataGridView1.TabIndex = 2;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblChartTitle.Location = new Point(10, 10);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(312, 32);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Status Ketersediaan Mobil";
            // 
            // chartMobil
            // 
            chartMobil.BackColor = Color.White;
            chartMobil.Location = new Point(10, 45);
            chartMobil.Name = "chartMobil";
            chartMobil.Size = new Size(0, 0);
            chartMobil.TabIndex = 1;
            chartMobil.TabStop = false;
            // 
            // --- panelPopuler ---
            panelPopuler.BackColor = Color.White;
            // Menghilangkan garis tepi yang kaku untuk gaya Flat/Modern Card
            panelPopuler.BorderStyle = BorderStyle.None;
            panelPopuler.Controls.Add(lblPopulerTitle);
            panelPopuler.Controls.Add(listPopuler);
            panelPopuler.Location = new Point(1040, 280);
            panelPopuler.Name = "panelPopuler";
            panelPopuler.Size = new Size(380, 320);
            panelPopuler.TabIndex = 4;

            // --- lblPopulerTitle ---
            lblPopulerTitle.AutoSize = true;
            lblPopulerTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold); // Ukuran sedikit diperbesar & Semibold
            lblPopulerTitle.ForeColor = Color.FromArgb(45, 45, 45); // Abu-abu gelap (lebih lembut di mata dari hitam pekat)
            lblPopulerTitle.Location = new Point(20, 15); // Memberikan margin yang lebih luas
            lblPopulerTitle.Name = "lblPopulerTitle";
            lblPopulerTitle.Size = new Size(213, 32);
            lblPopulerTitle.TabIndex = 0;
            lblPopulerTitle.Text = "Mobil Terpopuler";

            // --- listPopuler ---
            listPopuler.BackColor = Color.White;
            listPopuler.BorderStyle = BorderStyle.None; // Hilangkan border bawaan
            listPopuler.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            listPopuler.ForeColor = Color.FromArgb(64, 64, 64);
            listPopuler.Location = new Point(20, 55);
            listPopuler.Name = "listPopuler";
            listPopuler.Size = new Size(340, 240);
            listPopuler.TabIndex = 1;
            listPopuler.SelectedIndexChanged += listPopuler_SelectedIndexChanged;

            // PENTING UNTUK DESAIN MODERN: Aktifkan mode kustom untuk menggambar item
            listPopuler.DrawMode = DrawMode.OwnerDrawFixed;
            listPopuler.ItemHeight = 40; // Memberikan padding/jarak antar item yang lega
            listPopuler.DrawItem += listPopuler_DrawItem; // Daftarkan event DrawItem
            // panelTransaksi
            // 
            panelTransaksi.BackColor = Color.White;
            panelTransaksi.BorderStyle = BorderStyle.FixedSingle;
            panelTransaksi.Controls.Add(lblTransaksiTitle);
            panelTransaksi.Controls.Add(gridKategori);
            panelTransaksi.Location = new Point(20, 620);
            panelTransaksi.Name = "panelTransaksi";
            panelTransaksi.Size = new Size(1400, 280);
            panelTransaksi.TabIndex = 5;
            // 
            // lblTransaksiTitle
            // 
            lblTransaksiTitle.AutoSize = true;
            lblTransaksiTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTransaksiTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTransaksiTitle.Location = new Point(10, 10);
            lblTransaksiTitle.Name = "lblTransaksiTitle";
            lblTransaksiTitle.Size = new Size(214, 32);
            lblTransaksiTitle.TabIndex = 0;
            lblTransaksiTitle.Text = "Transaksi Terbaru";
            // 
            // gridKategori
            // 
            gridKategori.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 249, 250);
            gridKategori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            gridKategori.BackgroundColor = Color.White;
            gridKategori.BorderStyle = BorderStyle.None;
            gridKategori.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridKategori.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(10, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridKategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridKategori.ColumnHeadersHeight = 45;
            gridKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 71, 71);
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(232, 244, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridKategori.DefaultCellStyle = dataGridViewCellStyle6;
            gridKategori.EnableHeadersVisualStyles = false;
            gridKategori.GridColor = Color.FromArgb(239, 239, 239);
            gridKategori.Location = new Point(10, 55);
            gridKategori.Name = "gridKategori";
            gridKategori.ReadOnly = true;
            gridKategori.RowHeadersVisible = false;
            gridKategori.RowHeadersWidth = 62;
            gridKategori.RowTemplate.Height = 40;
            gridKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridKategori.Size = new Size(1380, 210);
            gridKategori.TabIndex = 1;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(panelTransaksi);
            Controls.Add(panelPopuler);
            Controls.Add(panelChart);
            Controls.Add(flowLayoutStats);
            Controls.Add(lblDashboardSubtitle);
            Controls.Add(lblDashboardTitle);
            Name = "UC_Dashboard";
            Size = new Size(1440, 920);
            Load += UC_Dashboard_Load;
            flowLayoutStats.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            cardTersedia.ResumeLayout(false);
            cardTersedia.PerformLayout();
            cardPelanggan.ResumeLayout(false);
            cardPelanggan.PerformLayout();
            cardPendapatan.ResumeLayout(false);
            cardPendapatan.PerformLayout();
            panelChart.ResumeLayout(false);
            panelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMobil).EndInit();
            panelPopuler.ResumeLayout(false);
            panelPopuler.PerformLayout();
            panelTransaksi.ResumeLayout(false);
            panelTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridKategori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDashboardTitle;
        private Label lblDashboardSubtitle;
        private FlowLayoutPanel flowLayoutStats;
        private Panel cardTotal;
        private Panel cardTersedia;
        private Panel cardPelanggan;
        private Panel cardPendapatan;
        private Panel panelChart;
        private Label lblChartTitle;
        private PictureBox chartMobil;
        private Panel panelPopuler;
        private Label lblPopulerTitle;
        private ListBox listPopuler;
        private Panel panelTransaksi;
        private Label lblTransaksiTitle;
        private DataGridView gridKategori;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dataGridView1;
    }
}
