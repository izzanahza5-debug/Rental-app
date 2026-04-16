using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace new_project
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Deklarasikan List di tingkat Class (seperti property di Controller)
        List<LogHitung> daftarRiwayat = new List<LogHitung>();

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = double.Parse(txtAngka1.Text);
                double a2 = double.Parse(txtAngka2.Text);

                if (a2 == 0)
                {
                    MessageBox.Show("Tidak bisa bagi nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Berhenti di sini
                }

                double hasilHitung = a1 / a2;

                // 2. Membuat Object Baru (Sama seperti: $log = new LogHitung;)
                LogHitung dataBaru = new LogHitung
                {
                    Angka1 = a1,
                    Angka2 = a2,
                    Hasil = hasilHitung,
                    Waktu = DateTime.Now
                };

                // 3. Masukkan ke List (Collection)
                daftarRiwayat.Add(dataBaru);

                // 4. Update Tampilan UI
                lblHasil.Text = $"Hasil: {hasilHitung}";

                // Kita masukkan Object-nya langsung ke ListBox!
                // Karena kita sudah override ToString() di Class tadi, 
                // ListBox akan otomatis menampilkan teks yang rapi.
                listBox1.Items.Add(dataBaru);
                txtAngka1.Clear();
                txtAngka2.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input harus angka!");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void lblHasil_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class LogHitung
    {
        public double Angka1 { get; set; }
        public double Angka2 { get; set; }
        public double Hasil { get; set; }
        public DateTime Waktu { get; set; } // Untuk mencatat kapan dihitung

        // Ini adalah Method untuk mempercantik tampilan di ListBox nanti
        public override string ToString()
        {
            return $"[{Waktu:HH:mm:ss}]  {Angka1} / {Angka2} = {Hasil}";
        }
    }
    
}
