using MySql.Data.MySqlClient;
using System.Data;

namespace Rental_app
{
    public partial class UC_Kategori : UserControl
    {
        public UC_Kategori()
        {
            InitializeComponent();
        }

        private void UC_Kategori_Load(object sender, EventArgs e)
        {
            
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
                string kodeKategori = gridKategori.SelectedRows[0].Cells[1].Value.ToString();
                string namaKategori = gridKategori.SelectedRows[0].Cells[0].Value.ToString();
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
                gridKategori.Rows.RemoveAt(gridKategori.SelectedRows[0].Index);
                panel_edit.Visible = false;
                MessageBox.Show("Kategori berhasil dihapus!");
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

            if (namaKategori == "" || kodeKategori == "")
            {
                MessageBox.Show("Nama dan Kode kategori tidak boleh kosong!");
                return;
            }

            if (gridKategori.SelectedRows.Count > 0)
            {
                gridKategori.SelectedRows[0].Cells[0].Value = namaKategori;
                gridKategori.SelectedRows[0].Cells[1].Value = kodeKategori;
                MessageBox.Show("Kategori berhasil diperbarui!");
                txt_nama.Clear();
                txt_kode.Clear();
                return;
            }

            gridKategori.Rows.Add(namaKategori, kodeKategori);

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
            TampilDataMobil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_input.Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string namaKategori = txtNamaEdit.Text;
            string kodeKategori = txtKodeEdit.Text;

            if (namaKategori == "" || kodeKategori == "")
            {
                MessageBox.Show("Nama dan Kode kategori tidak boleh kosong!");
                return;
            }

            gridKategori.SelectedRows[0].Cells[0].Value = namaKategori;
            gridKategori.SelectedRows[0].Cells[1].Value = kodeKategori;
            MessageBox.Show("Kategori berhasil diperbarui!");
            panel_edit.Visible = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel_edit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
