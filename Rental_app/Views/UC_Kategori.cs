using MySql.Data.MySqlClient;
using System.Data;

namespace Rental_app
{
    public partial class UC_Kategori : UserControl
    {
        public UC_Kategori()
        {
            InitializeComponent();
            gridKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private KategoriController KategoriController = new KategoriController();

        private void UC_Kategori_Load(object sender, EventArgs e)
        {
            gridKategori.DataSource = KategoriController.GetKategori();
            gridKategori.Columns["id"].Visible = false;
        }

        private void LoadDataToGrid()
        {
            try
            {
                var data = KategoriController.GetKategori();

                gridKategori.DataSource = null; // Clear existing data
                gridKategori.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void TampilDataMobil()
        {
            KonekDb db = new KonekDb();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM mobil";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Asumsikan kamu punya DataGridView bernama gridKategori
                gridKategori.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur Tambah Kategori");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (gridKategori.SelectedRows.Count > 0)
            {
                string kodeKategori = gridKategori.SelectedRows[0].Cells[2].Value.ToString();
                string namaKategori = gridKategori.SelectedRows[0].Cells[1].Value.ToString();
                txtNamaEdit.Text = namaKategori;
                txtKodeEdit.Text = kodeKategori;
                panel_edit.Visible = true;
                panel_input.Visible = false;
            }
            else
            {
                MessageBox.Show("Pilih kategori terlebih dahulu!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (gridKategori.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridKategori.SelectedRows[0].Cells["id"].Value.ToString());
                bool berhasil = KategoriController.DeleteKategori(id);
                if (berhasil)
                {
                    gridKategori.DataSource = KategoriController.GetKategori();


                }
                else
                {
                    MessageBox.Show("Gagal dihapus!");
                }
            }
            else
            {
                MessageBox.Show("Pilih kategori terlebih dahulu!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            string namaKategori = txt_nama.Text;
            string kodeKategori = txt_kode.Text;

            if (KategoriController.CreateKategori(kodeKategori, namaKategori) != null)
            {
                gridKategori.DataSource = KategoriController.GetKategori();
                MessageBox.Show("Berhasil di tambahkan");
            }
            else
            {
                MessageBox.Show("gagal menambahkan kategori!");
            }

            txt_nama.Clear();
            txt_kode.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_input.Visible = true;
            panel_edit.Visible = false;
        }

        private void namaKategori_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gridKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TampilDataMobil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_input.Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //var idValue = gridKategori.CurrentRow.Cells["id"].Value;
            //MessageBox.Show($"ID yang akan diupdate: {idValue} (Type: {idValue?.GetType()})");
            string namaKategori = txtKodeEdit.Text;
            string kodeKategori = txtNamaEdit.Text;


            bool success = KategoriController.UpdateKategori(
                id: Convert.ToInt32(gridKategori.CurrentRow.Cells["id"].Value),
                kode_kategori: kodeKategori,
                nama_kategori: namaKategori
                );

            if (success)
            {
                gridKategori.DataSource = KategoriController.GetKategori();
                panel_edit.Visible = false;
                return;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel_edit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridKategori_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
