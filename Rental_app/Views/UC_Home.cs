using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static KategoriController;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rental_app
{
    public partial class UC_Home : UserControl
    {
        private MobilController MobilController = new MobilController();
        public UC_Home()
        {
            InitializeComponent();

            string connectionString = "server=localhost;database=rental_db;uid=root;pwd=;";
            string query = "SELECT id, nama_kategori FROM kategori";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind data ke ComboBox
                    comboBox4.DisplayMember = "nama_kategori"; // Kolom yang ditampilkan
                    comboBox4.ValueMember = "id";           // Nilai tersembunyi
                    comboBox4.DataSource = dt;
                    comboBox1.DisplayMember = "nama_kategori"; // Kolom yang ditampilkan
                    comboBox1.ValueMember = "id";           // Nilai tersembunyi
                    comboBox1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            

            comboBox3.Items.Add("Dipinjam");
            comboBox3.Items.Add("Tersedia");
            comboBox3.Items.Add("Maintenence");
            comboBox3.SelectedIndex = 1;


            

            comboBox2.Items.Add("Dipinjam");
            comboBox2.Items.Add("Tersedia");
            comboBox2.Items.Add("Maintenence");

            comboBox2.SelectedIndex = 1;

           

            comboBox1.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

            dataGridView1.DataSource = MobilController.GetMobil();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UC_Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string nama_mobil = txt_nama.Text;      // sesuaikan nama textbox
            string nomor_plat = txt_plat.Text;
            decimal harga;
            if (!decimal.TryParse(txt_harga.Text, out harga))
            {
                MessageBox.Show("harga harus berupa angka!");
                return;
            }
            string kategori = comboBox1.SelectedValue?.ToString() ?? "";
            string status = comboBox2.SelectedItem?.ToString() ?? "";

            if (MobilController.CreateMobil(nama_mobil, nomor_plat, harga, kategori, status) != null)
            {
                dataGridView1.DataSource = MobilController.GetMobil();
                MessageBox.Show("Berhasil ditambahkan");
            }
            else
            {
                MessageBox.Show("gagal menambahkan mobil!");
            }

            txt_nama.Clear();
            txt_plat.Clear();
            txt_harga.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                string namaMobil = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string nomorPlat = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string hargaSewa = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string statusMobil = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string kategoriMobil = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                textBox1.Text = namaMobil;
                textBox2.Text = nomorPlat;
                textBox3.Text = hargaSewa;
                comboBox3.Items.Add(statusMobil);
                comboBox4.Text = kategoriMobil;
            }
            else
            {
                MessageBox.Show("Pilih mobil terlebih dahulu!");

            }
        }

        private void txt_namaEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string namaMobil = textBox1.Text;
            string nomorPlat = textBox2.Text;
            string hargaSewa = textBox3.Text;
            string statusMobil = comboBox3.SelectedItem.ToString();
            string kategoriMobil = comboBox4.SelectedValue.ToString();

            bool berhasil = MobilController.UpdateMobil(
        id: (int)dataGridView1.CurrentRow.Cells["id"].Value, // ambil id dari baris yang dipilih
        nama_mobil: textBox1.Text,
        nomor_plat: textBox2.Text,
        harga: Convert.ToDecimal(textBox3.Text),
        kategori: comboBox4.SelectedValue.ToString(),
        status: comboBox3.SelectedItem.ToString()
    );

            if (berhasil)
            {
                // Refresh tampilan data di DataGridView
                dataGridView1.DataSource = MobilController.GetMobil();
            }

            panel2.Visible = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["id"].Value;
                bool berhasil = MobilController.deleteMobil(id);
                if (berhasil)
                {
                    dataGridView1.DataSource = MobilController.GetMobil();
                    MessageBox.Show("Mobil berhasil dihapus!");
                }
                else
                {
                    MessageBox.Show("Gagal menghapus mobil!");
                }
            }
            else
            {
                MessageBox.Show("Pilih mobil terlebih dahulu!");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}