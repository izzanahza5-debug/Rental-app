using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            ShowPage(new UC_createPelanggan());
        }
    }
}
