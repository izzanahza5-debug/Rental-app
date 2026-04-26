using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rental_app
{
    public partial class UC_createPelanggan : UserControl
    {
        public UC_createPelanggan()
        {
            InitializeComponent();
        }

        private UserControl currentPage = null;
       

        private void ShowPage(UserControl Page)
        {
            if(currentPage != null)
            {
                this.Controls.Remove(currentPage);
                currentPage.Dispose();
            }

            currentPage = Page;
            Page.Dock = DockStyle.Fill;
            this.Controls.Add(Page);
            this.Controls.SetChildIndex(Page, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_Pelanggan());
        }
    }
}
