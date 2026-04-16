using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rental_app
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();


            comboBox3.Items.Add("Dipinjam");
            comboBox3.Items.Add("Tersedia");
            comboBox3.Items.Add("Maintenence");
            comboBox3.SelectedIndex = 1;

            comboBox4.Items.Add("SUV");
            comboBox4.Items.Add("Sedan");
            comboBox4.Items.Add("Hatchback");
            comboBox4.SelectedIndex = 0;

            comboBox2.Items.Add("Dipinjam");
            comboBox2.Items.Add("Tersedia");
            comboBox2.Items.Add("Maintenence");

            comboBox2.SelectedIndex = 1;

            comboBox1.Items.Add("SUV");
            comboBox1.Items.Add("Sedan");
            comboBox1.Items.Add("Hatchback");

            comboBox1.SelectedIndex = 0;

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
            string namaMobil = txt_nama.Text;
            string nomorPlat = txt_plat.Text;
            string HargaSewa = txt_hari.Text;
            string statusMobil = comboBox2.SelectedItem.ToString();
            string kategoriMobil = comboBox1.SelectedItem.ToString();

            if (namaMobil == "" || nomorPlat == "" || HargaSewa == "")
            {
                MessageBox.Show("Nama, Nomor Plat, dan Harga Sewa tidak boleh kosong!");
                return;
            }

            if (HargaSewa != "" && !decimal.TryParse(HargaSewa, out _))
            {
                MessageBox.Show("Harga Sewa harus berupa angka!");
                return;
            }

            dataGridView1.Rows.Add(namaMobil, nomorPlat, HargaSewa, kategoriMobil, statusMobil);

            txt_nama.Clear();
            txt_plat.Clear();
            txt_hari.Clear();

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
                string namaMobil = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nomorPlat = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string HargaSewa = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string statusMobil = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string kategoriMobil = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                textBox1.Text = namaMobil;
                textBox2.Text = nomorPlat;
                textBox3.Text = HargaSewa;
                comboBox3.Items.Add(statusMobil);
                comboBox4.Items.Add(kategoriMobil);
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
            string HargaSewa = textBox3.Text;
            string statusMobil = comboBox3.SelectedItem.ToString();
            string kategoriMobil = comboBox4.SelectedItem.ToString();

            if (namaMobil == "" || nomorPlat == "" || HargaSewa == "")
            {
                MessageBox.Show("Nama, Nomor Plat, dan Harga Sewa tidak boleh kosong!");
                return;
            }

            if (HargaSewa != "" && !decimal.TryParse(HargaSewa, out _))
            {
                MessageBox.Show("Harga Sewa harus berupa angka!");
                return;
            }

            dataGridView1.SelectedRows[0].Cells[0].Value = namaMobil;
            dataGridView1.SelectedRows[0].Cells[1].Value = nomorPlat;
            dataGridView1.SelectedRows[0].Cells[2].Value = HargaSewa;
            dataGridView1.SelectedRows[0].Cells[4].Value = statusMobil;
            dataGridView1.SelectedRows[0].Cells[3].Value = kategoriMobil;

            panel2.Visible = false;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) { 
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                return;
            }
            else
            {
                MessageBox.Show("Pilih mobil terlebih dahulu!");
            }
        }
    }
}