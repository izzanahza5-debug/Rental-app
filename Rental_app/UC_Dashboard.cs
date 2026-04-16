namespace Rental_app
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            StyleDashboard();
        }

        private void StyleDashboard()
        {
            //// Style DataGridView
            //gridTransaksi.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            //gridTransaksi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            //gridTransaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            //gridTransaksi.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 100, 100);
            //gridTransaksi.ColumnHeadersHeight = 30;
            //gridTransaksi.RowTemplate.Height = 25;
            //gridTransaksi.AllowUserToAddRows = false;
            //gridTransaksi.AllowUserToDeleteRows = false;
            //gridTransaksi.ReadOnly = true;

            // Style ListBox
            listPopuler.Font = new Font("Segoe UI", 10F);
            listPopuler.ItemHeight = 25;

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
    }
}
