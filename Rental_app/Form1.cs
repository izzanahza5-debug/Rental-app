
namespace Rental_app
{
    public partial class Form1 : Form
    {
        private UserControl currentPage = null;

        public Form1()
        {
            InitializeComponent();
            SetupButtonHoverEffects();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Show Dashboard page by default
            ShowPage(new UC_Dashboard());
        }

        private void SetupButtonHoverEffects()
        {
            Button[] buttons = { btn_dashboard, btn_kategori, btn_daftarMobil, btn_transaksi,
                               btn_status, btn_dataPelanggan, btn_laporan };

            foreach (Button btn in buttons)
            {
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(52, 152, 219);
                    btn.ForeColor = Color.White;
                    Cursor = Cursors.Hand;
                };
                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(41, 128, 185);
                    btn.ForeColor = Color.White;
                    Cursor = Cursors.Default;
                };
            }
        }

        //<summary>
        /// Method untuk menampilkan halaman UserControl
        //</summary>
        private void ShowPage(UserControl page)
        {
            // Hapus halaman sebelumnya
            if (currentPage != null)
            {
                panelContent.Controls.Remove(currentPage);
                currentPage.Dispose();
            }

            // Set halaman baru
            currentPage = page;
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
            panelContent.Controls.SetChildIndex(page, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kategori Mobil
            ShowPage(new UC_Kategori());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Daftar Mobil
            ShowPage(new UC_Home());
        }

        private void btn_transaksi_Click_1(object sender, EventArgs e)
        {
            // Transaksi
            ShowPage(new UC__TransaksiPenyewaan());
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            // Status Rental
            ShowPage(new UC_Status());
        }

        private void btn_dataPelanggan_Click(object sender, EventArgs e)
        {
            // Data Pelanggan
            ShowPage(new UC_Pelanggan());
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            // Laporan
            ShowPage(new UC_Template());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pengaturan
            ShowPage(new UC_Template());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Kembali ke Dashboard
            ShowPage(new UC_Dashboard());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
    public class logHitung()
    {

    }
}
