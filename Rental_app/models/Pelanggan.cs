namespace Rental_app.Models
{
    public class Pelanggan
    {
        public int    Id      { get; set; }
        public string nama    { get; set; }
        public string nomor_wa { get; set; }

        // Ditampilkan di ComboBox
        public string Info => $"{nama} - {nomor_wa}";
    }
}
