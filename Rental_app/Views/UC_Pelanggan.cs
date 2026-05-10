using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static KategoriController;

namespace Rental_app
{
    public partial class UC_Pelanggan : UserControl
    {
        private UserControl currentPage = null;
        private void ShowPage(UserControl page)
        {
            // Hapus halaman sebelumnya
            if (currentPage != null)
            {
                this.Controls.Remove(currentPage);
                currentPage.Dispose();
            }

            // Set halaman baru
            currentPage = page;
            page.Dock = DockStyle.Fill;
            this.Controls.Add(page);
            this.Controls.SetChildIndex(page, 0);
        }
        public UC_Pelanggan()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nama = dataGridView1.SelectedRows[0].Cells["nama_pelanggan"].Value.ToString();
                string alamat = dataGridView1.SelectedRows[0].Cells["alamat"].Value.ToString();
                string nomorTelepon = dataGridView1.SelectedRows[0].Cells["nomor_telepon"].Value.ToString();
                string totalSewa = dataGridView1.SelectedRows[0].Cells["total_sewa"].Value.ToString();
                textBox6.Text = nama;
                textBox5.Text = alamat;
                textBox7.Text = nomorTelepon;
                textBox8.Text = totalSewa;
                panel3.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("Pilih pelanggan terlebih dahulu!");
            }

        }

        public PelangganController PelangganController = new PelangganController();

        private void UC_Pelanggan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PelangganController.getPelanggan();
            dataGridView1.Columns["id"].Visible = false;
        }

        // Stub event handlers required by the Designer hookups.
        // These are intentionally empty; implement behavior as needed.
        private void button5_Click(object sender, EventArgs e)
        {
            string namaPelanggan = textBox1.Text;
            string alamat = textBox4.Text;
            int nomorTelepon;
            //int totalSewa;
            if (!int.TryParse(textBox2.Text, out nomorTelepon))
            {
                MessageBox.Show("Nomor telepon harus berupa angka!");
                return;
            }
            //if (!int.TryParse(textBox3.Text, out totalSewa))
            //{
            //    MessageBox.Show("Total sewa harus berupa angka!");
            //    return;
            //}

            if (PelangganController.createPelanggan(namaPelanggan, alamat, nomorTelepon) != null)
            {
                dataGridView1.DataSource = PelangganController.getPelanggan();
                
            }
            else
            {
                MessageBox.Show("gagal menambahkan pelanggan!");

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Optional: handle label click if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: handle label click if needed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string namaPelanggan = textBox6.Text;
            string alamat = textBox5.Text;
            int nomorTelepon = Convert.ToInt32(textBox7.Text);
            int totalSewa = Convert.ToInt32(textBox8.Text);

            bool sukses = PelangganController.updatePelanggan(
                id: Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value),
                nama: namaPelanggan,
                alamat: alamat,
                nomor_wa: nomorTelepon,
                total_sewa: totalSewa
                );

            if (sukses)
            {
                dataGridView1.DataSource = PelangganController.getPelanggan();
                //MessageBox.Show("Berhasil di update");
                panel3.Visible = false;
                return;
            }
            else
            {
                MessageBox.Show("Gagal di update!");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int idPelanggan = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                bool sukses = PelangganController.deletePelanggan(idPelanggan);
                if (sukses)
                {
                    dataGridView1.DataSource = PelangganController.getPelanggan();
                   
                }
                else
                {
                    MessageBox.Show("Gagal dihapus!");
                }
            }
            else
            {
                MessageBox.Show("Pilih pelanggan terlebih dahulu!");
            }
        }
    }
}
