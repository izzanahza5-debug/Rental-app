namespace Rental_app.Models
{
    public class Mobil
    {
        public int     Id        { get; set; }
        public string  NamaMobil { get; set; }
        public string  NomorPlat { get; set; }
        public decimal harga     { get; set; }

        // Ditampilkan di ComboBox
        public string Info => $"{NamaMobil} [{NomorPlat}] - Rp {harga:N0}/hari";
    }
}
