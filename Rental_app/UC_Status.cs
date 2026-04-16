using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rental_app
{
    public partial class UC_Status : UserControl
    {
        //private UserControl currentPage = null;
        public UC_Status()
        {
            InitializeComponent();

        }

        private void UC_Status_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void changePage(UserControl page)
        //{
        //    if (currentPage != null)
        //    {
        //        panelContent.Controls.Remove(currentPage);
        //        currentPage.Dispose();
        //    }

        //    currentPage = page;
        //    panelContent.Controls.Add(page);
        //        page.Dock = DockStyle.Fill;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //changePage(new UC_Detail);
        }
    }
}
