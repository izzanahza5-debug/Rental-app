namespace Rental_app
{
    public partial class UC_Dashboard : UserControl
    {
        private UserController userController = new UserController();
        private DashboardController dashboardController = new DashboardController();
        public UC_Dashboard()
        {
            InitializeComponent();
            StyleDashboard();
        }

        private void StyleDashboard()
        {
            //// Style DataGridView
            //gridKategori.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            //gridKategori.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            //gridKategori.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            //gridKategori.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 100, 100);
            //gridKategori.ColumnHeadersHeight = 30;
            //gridKategori.RowTemplate.Height = 25;
            //gridKategori.AllowUserToAddRows = false;
            //gridKategori.AllowUserToDeleteRows = false;
            //gridKategori.ReadOnly = true;

            // Style ListBox
            listPopuler.Font = new Font("Segoe UI", 10F);
            listPopuler.ItemHeight = 25;
            gridKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add hover effects to stat cards
            AddCardHoverEffect(cardTotal);
            AddCardHoverEffect(cardTersedia);
            AddCardHoverEffect(cardPelanggan);
            AddCardHoverEffect(cardPendapatan);
        }

        private void AddCardHoverEffect(Panel card)
        {
            card.MouseEnter += (s, e) =>
            {
                card.BorderStyle = BorderStyle.Fixed3D;
                card.Cursor = Cursors.Hand;
            };
            card.MouseLeave += (s, e) =>
            {
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Cursor = Cursors.Default;
            };
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            gridKategori.DataSource = userController.GetUser();
            dataGridView1.DataSource = dashboardController.StatusMobil();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["kategori"].Visible = false;
            dataGridView1.Columns["harga"].Visible = false;
            label3.Text = dashboardController.totalMobil().ToString();
            label7.Text = dashboardController.totalPelanggan().ToString();
            label4.Text = dashboardController.totalAktif().ToString();
            decimal pendapatanValue = dashboardController.pendapatan();
            string pendapatan = "Rp " + pendapatanValue.ToString("N2", new System.Globalization.CultureInfo("id-ID"));
            label10.Text = pendapatan;
            TampilkanMobilTerlaris();
            //var populerList = dashboardController.GetPopuler();
        }
        private void listPopuler_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // 1. Atur Warna Background Item
            // Gunakan warna biru sangat muda (AliceBlue/mirip) jika dipilih, putih jika tidak
            Color bgColor = isSelected ? Color.FromArgb(235, 245, 255) : Color.White;
            using (SolidBrush bgBrush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            // 2. Atur Warna dan Gaya Teks
            // Gunakan warna biru tema jika dipilih, abu-abu gelap jika biasa
            Color textColor = isSelected ? Color.FromArgb(0, 102, 204) : Color.FromArgb(64, 64, 64);
            Font textFont = isSelected
                ? new Font("Segoe UI Semibold", 11F, FontStyle.Bold) // Bold saat dipilih
                : new Font("Segoe UI", 11F, FontStyle.Regular);

            string text = listBox.Items[e.Index].ToString();

            // 3. Gambar Teks dengan Padding (Indentasi margin kiri dan rata tengah vertikal)
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                // Margin kiri 15px, Margin atas (agar teks di tengah item height) sekitar 8px
                float textY = e.Bounds.Top + ((e.Bounds.Height - textFont.Height) / 2);
                e.Graphics.DrawString(text, textFont, textBrush, new PointF(e.Bounds.Left + 15, textY));
            }

            // (Opsional) Menggambar garis pemisah tipis di bawah setiap item
            using (Pen separatorPen = new Pen(Color.FromArgb(240, 240, 240)))
            {
                e.Graphics.DrawLine(separatorPen, e.Bounds.Left + 10, e.Bounds.Bottom - 1, e.Bounds.Right - 10, e.Bounds.Bottom - 1);
            }

            e.DrawFocusRectangle(); // Menghilangkan kotak fokus default bertitik-titik
        }

        private void TampilkanMobilTerlaris()
        {
            var ctrl = new DashboardController();
            List<string> data = ctrl.DaftarMobilTerlaris();

            listPopuler.Items.Clear();
            foreach (string item in data)
            {
                listPopuler.Items.Add(item);
            }
        }

        private void gridKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: implementasi sesuai kebutuhan
        }

        private void listPopuler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cardTersedia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardPendapatan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
