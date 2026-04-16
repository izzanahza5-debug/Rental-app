## 📚 DOKUMENTASI MULTI-PAGE SISTEM

### ✅ Struktur yang Telah Dibuat

#### 1. **Form1.cs** - Main Form (Container)
- Berperan sebagai **container** utama aplikasi
- Menampilkan **Sidebar** dengan menu navigasi
- Menampilkan **panelContent** sebagai area untuk menampilkan halaman

#### 2. **UC_Dashboard.cs & UC_Dashboard.Designer.cs** - Dashboard Page
- UserControl untuk halaman Dashboard
- Menampilkan: Statistics Cards, Chart, Popular Cars List, Recent Transactions
- Fitur: Interactive cards, animated chart

#### 3. **UC_Template.cs & UC_Template.Designer.cs** - Template Page
- UserControl template untuk halaman-halaman lain
- Bisa dikustomisasi sesuai kebutuhan
- Struktur: Title + Content Area

---

### 🔄 Cara Kerja Sistem Multi-Page

```
┌─────────────────────────────────────┐
│         Form1 (Main Container)       │
├─────────────────────────────────────┤
│ ┌──────────────────────────────────┐│
│ │ panelSidebar (Menu Navigation)   ││
│ │ - Dashboard                       ││
│ │ - Kategori Mobil                 ││
│ │ - Daftar Mobil                   ││
│ │ - Transaksi                      ││
│ │ - Status Rental                  ││
│ │ - Data Pelanggan                 ││
│ │ - Laporan                        ││
│ │ - Pengaturan                     ││
│ └──────────────────────────────────┘│
│ ┌──────────────────────────────────┐│
│ │ panelContent (Content Area)       ││
│ │  [UserControl Page Displayed]    ││
│ │                                  ││
│ │  - UC_Dashboard                 ││
│ │  - UC_Template (atau custom)    ││
│ └──────────────────────────────────┘│
└─────────────────────────────────────┘
```

---

### 🎯 Cara Menggunakan / Menambah Halaman Baru

#### **Step 1: Buat UserControl Baru**

```csharp
// UC_Kategori.cs
public partial class UC_Kategori : UserControl
{
    public UC_Kategori()
    {
        InitializeComponent();
    }

    private void UC_Kategori_Load(object sender, EventArgs e)
    {
        // Load data kategori
    }
}
```

#### **Step 2: Tambah di Form1.cs Event Handler**

```csharp
private void button2_Click(object sender, EventArgs e)
{
    // Kategori Mobil Button Click
    ShowPage(new UC_Kategori()); // ← Ganti dengan UserControl baru
}
```

#### **Step 3: ShowPage Method**
Method ini otomatis menghapus halaman lama dan menampilkan halaman baru:

```csharp
private void ShowPage(UserControl page)
{
    // Hapus halaman sebelumnya
    if (currentPage != null)
    {
        panelContent.Controls.Remove(currentPage);
        currentPage.Dispose();
    }

    // Set halaman baru
    currentPage = page;
    page.Dock = DockStyle.Fill;
    panelContent.Controls.Add(page);
    panelContent.Controls.SetChildIndex(page, 0);
}
```

---

### 📋 Button-Page Mapping

| Button | Event Handler | Page |
|--------|---------------|------|
| 📊 Dashboard | `btn_dashboard_Click` | `UC_Dashboard` |
| 🏷️ Kategori | `button2_Click` | `UC_Template` |
| 📝 Daftar Mobil | `button3_Click` | `UC_Template` |
| 💰 Transaksi | `btn_transaksi_Click_1` | `UC_Template` |
| 📋 Status Rental | `btn_status_Click` | `UC_Template` |
| 👥 Data Pelanggan | `btn_dataPelanggan_Click` | `UC_Template` |
| 📊 Laporan | `btn_laporan_Click` | `UC_Template` |
| ⚙️ Pengaturan | `button1_Click` | `UC_Template` |
| 🚗 Logo (Go Home) | `label1_Click` | `UC_Dashboard` |

---

### 🚀 Best Practices

1. **Gunakan Template untuk Pages Baru**
   - Copy UC_Template dan customize sesuai kebutuhan
   - Inherit dari UserControl

2. **Organize UserControl Files**
   ```
   Rental_app/
   ├── Pages/
   │   ├── UC_Dashboard.cs
   │   ├── UC_Dashboard.Designer.cs
   │   ├── UC_Kategori.cs
   │   ├── UC_Kategori.Designer.cs
   │   ├── UC_DaftarMobil.cs
   │   └── UC_DaftarMobil.Designer.cs
   ├── Form1.cs
   ├── Form1.Designer.cs
   └── Program.cs
   ```

3. **Consistent Styling**
   - Background Color: `Color.FromArgb(240, 242, 245)`
   - Text Color: `Color.FromArgb(33, 33, 33)`
   - Accent Color: `Color.FromArgb(52, 152, 219)`

4. **Memory Management**
   - ShowPage() method otomatis dispose halaman lama
   - Tidak perlu khawatir memory leak

---

### 💡 Tips

- **Transition Smooth**: Gunakan `DockStyle.Fill` agar halaman memenuhi panel
- **Active Button**: Tambah method untuk highlight button yang aktif
- **Reload Data**: Implement `IReloadable` interface jika perlu reload saat kembali ke page

---

### 📞 Support Features dalam UC_Dashboard

✅ Statistics Cards (Total Mobil, Tersedia, Pelanggan, Pendapatan)
✅ Interactive Bar Chart (Ketersediaan Mobil)
✅ Popular Cars List
✅ Recent Transactions Table
✅ Card Hover Effects

---

**Terima kasih! Sistem multi-page sudah siap digunakan! 🎉**
