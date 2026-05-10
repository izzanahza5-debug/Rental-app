public class User
{
    public int Id { get; set; }
    public string Nama { get; set; }
}
public class Kategori
{
    public int id { get; set; }
    public string kode_kategori { get; set; }
    public string nama_kategori { get; set; }
}
public class Mobil { 
   public int id { get; set; }
    public string nama_mobil { get; set; }
    public string nomor_plat { get; set; }
    public decimal harga { get; set; }
    public string kategori { get; set; }
    public string status { get; set; }
}

public class Pelanggan {
    public string id { get; set; }
    public string nama_pelanggan { get; set; }
    public string alamat { get; set; }
    public string nomor_telepon { get; set; }
    public string total_sewa { get; set; }
}

public class ItemTransaksiAktif
{
    public int IdTransaksi { get; set; }
    public int IdMobil { get; set; }
    public string NamaPelanggan { get; set; }
    public string NamaMobil { get; set; }
    public string PlatNomor { get; set; }
    public string TglSewa { get; set; }
    public string TglRencanaKembali { get; set; }
    public decimal TotalBiaya { get; set; }
    public decimal HargaPerHari { get; set; }

    // Tampil di ComboBox
    public override string ToString() =>
        $"#{IdTransaksi} | {NamaPelanggan} - {NamaMobil} ({PlatNomor})";
}
public class TransaksiDashboard
{
    public int IdTransaksi { get; set; }
    //public int IdMobil { get; set; }
    public string NamaPelanggan { get; set; }
    public string NamaMobil { get; set; }
    //public string PlatNomor { get; set; }
    public string TglSewa { get; set; }
    public string TglRencanaKembali { get; set; }
    public string Status { get; set; }
    //public decimal TotalBiaya { get; set; }
    //public decimal HargaPerHari { get; set; }

    // Tampil di ComboBox
    //public override string ToString() =>
    //    $"#{IdTransaksi} | {NamaPelanggan} - {NamaMobil} ({PlatNomor})";
}
// Model untuk satu baris tabel riwayat pengembalian
public class ItemPengembalian
{
    public int IdPengembalian { get; set; }
    public int IdTransaksi { get; set; }
    public string NamaPelanggan { get; set; }
    public string NamaMobil { get; set; }
    public string PlatNomor { get; set; }
    public string TglRencanaKembali { get; set; }
    public string TglKembaliAktual { get; set; }
    public int TelatHari { get; set; }
    public decimal TotalDenda { get; set; }
    public string KondisiMobil { get; set; }
    public string CatatanKerusakan { get; set; }
    public string CreatedAt { get; set; }

    // Format tampil di DGV
    public string TelatHariFormatted => TelatHari > 0 ? $"{TelatHari} hari" : "Tepat Waktu";
    public string TotalDendaFormatted => TotalDenda > 0 ? "Rp " + TotalDenda.ToString("N0") : "—";
}

    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public string Pelanggan { get; set; }
        public string Mobil { get; set; }
        public string TglSewa { get; set; }
        public string RencanaKembali { get; set; }
        public string Durasi { get; set; }
        public string TotalBiaya { get; set; }
        public string Status { get; set; }

        // Disembunyikan di DataGridView, dipakai saat Batal
        public int IdMobil { get; set; }
    }
