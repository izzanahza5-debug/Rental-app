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