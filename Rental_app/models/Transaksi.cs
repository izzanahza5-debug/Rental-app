namespace Rental_app.Models
{
    public class Transaksi
    {
        public int    IdTransaksi     { get; set; }
        public string Pelanggan       { get; set; }
        public string Mobil           { get; set; }
        public string TglSewa         { get; set; }
        public string RencanaKembali  { get; set; }
        public string Durasi          { get; set; }
        public string TotalBiaya      { get; set; }
        public string Status          { get; set; }

        // Disembunyikan di DataGridView, dipakai saat Batal
        public int    IdMobil         { get; set; }
    }
}
