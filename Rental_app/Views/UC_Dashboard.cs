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
             //var populerList = dashboardController.GetPopuler();
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
    }
}
