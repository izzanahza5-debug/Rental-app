# ⚡ QUICK REFERENCE - MULTI-PAGE SISTEM

## 🔥 30 Seconds Quick Start

```csharp
// 1. Halaman sudah siap?
UC_Dashboard.cs ✅
UC_Kategori.cs ✅

// 2. Jalankan aplikasi
F5

// 3. Klik button navigasi
Dashboard ✅
Kategori ✅

// 4. Buat halaman baru?
Lihat IMPLEMENTATION_GUIDE.md
```

---

## 🎯 3 Steps Membuat Halaman Baru

### 1️⃣ CREATE UserControl FILE

**UC_Transaksi.cs**
```csharp
public partial class UC_Transaksi : UserControl
{
    public UC_Transaksi() => InitializeComponent();
    private void UC_Transaksi_Load(object sender, EventArgs e) => LoadData();
    private void LoadData() { /* Load from DB */ }
}
```

### 2️⃣ CREATE DESIGNER FILE

**UC_Transaksi.Designer.cs**
```csharp
partial class UC_Transaksi
{
    private void InitializeComponent()
    {
        // Copy from UC_Kategori.Designer.cs
        // Modify title dan components
    }
}
```

### 3️⃣ UPDATE Form1.cs

```csharp
private void btn_transaksi_Click_1(object sender, EventArgs e)
{
    ShowPage(new UC_Transaksi());
}
```

✅ **DONE!** Halaman siap digunakan!

---

## 📋 Button Map

| Button | Handler | Page | Status |
|--------|---------|------|--------|
| 📊 Dashboard | `btn_dashboard_Click` | `UC_Dashboard` | ✅ |
| 🏷️ Kategori | `button2_Click` | `UC_Kategori` | ✅ |
| 📝 Daftar Mobil | `button3_Click` | `UC_Template` | ⏳ |
| 💰 Transaksi | `btn_transaksi_Click_1` | `UC_Template` | ⏳ |
| 📋 Status | `btn_status_Click` | `UC_Template` | ⏳ |
| 👥 Pelanggan | `btn_dataPelanggan_Click` | `UC_Template` | ⏳ |
| 📊 Laporan | `btn_laporan_Click` | `UC_Template` | ⏳ |
| ⚙️ Pengaturan | `button1_Click` | `UC_Template` | ⏳ |

---

## 🎨 Copy-Paste Template

### Designer Colors
```csharp
Background: Color.FromArgb(240, 242, 245)
Text: Color.FromArgb(33, 33, 33)
Accent: Color.FromArgb(52, 152, 219)
```

### Minimal UC Layout
```csharp
partial class UC_NewPage
{
    private void InitializeComponent()
    {
        lblTitle = new Label();
        gridData = new DataGridView();
        
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.Location = new Point(20, 20);
        lblTitle.Text = "Page Title";
        
        gridData.Location = new Point(20, 80);
        gridData.Size = new Size(1400, 800);
        
        Controls.Add(lblTitle);
        Controls.Add(gridData);
    }
}
```

---

## 🚨 Common Issues & Fixes

### Problem: "ShowPage method tidak ditemukan"
**Fix:** Pastikan Form1.cs memiliki method:
```csharp
private void ShowPage(UserControl page)
{
    if (currentPage != null)
    {
        panelContent.Controls.Remove(currentPage);
        currentPage.Dispose();
    }
    currentPage = page;
    page.Dock = DockStyle.Fill;
    panelContent.Controls.Add(page);
    panelContent.Controls.SetChildIndex(page, 0);
}
```

### Problem: "Page tidak muncul"
**Fix:** Check:
1. ✅ ShowPage() dipanggil dengan UserControl yang benar
2. ✅ UserControl sudah dibuat dan compiled
3. ✅ Event handler connected ke button

### Problem: "Memory leak"
**Fix:** ShowPage() method sudah handle dispose otomatis

---

## 📚 File Dokumentasi

| File | Isi |
|------|-----|
| `MULTI_PAGE_GUIDE.md` | Penjelasan lengkap sistem |
| `IMPLEMENTATION_GUIDE.md` | Step-by-step guide |
| `SYSTEM_OVERVIEW.md` | Diagram & architecture |
| `QUICK_REFERENCE.md` | File ini |

---

## 💡 Pro Tips

### 1. Cepat Buat Banyak Pages
1. Copy UC_Kategori.cs
2. Rename ke UC_NewPage.cs
3. Update class name dan title
4. Update event handler di Form1.cs

### 2. Reuse Components
- Copy DataGridView setup dari UC_Kategori
- Copy Button toolbar dari UC_Kategori
- Copy styling dari UC_Dashboard

### 3. Test Page
```csharp
private void btn_test_Click(object sender, EventArgs e)
{
    ShowPage(new UC_NewPage());
    MessageBox.Show("Page loaded!");
}
```

---

## ✨ What's Included

```
✅ Multi-page framework
✅ Navigation system
✅ UC_Dashboard (complete)
✅ UC_Kategori (complete with CRUD)
✅ UC_Template (for copy-paste)
✅ Styling & colors
✅ Memory management
✅ 3 Markdown guides
```

---

## 🎯 Next Steps

1. **Edit UC_Kategori untuk real data**
   - Connect ke database
   - Load actual categories

2. **Buat halaman lain**
   - UC_DaftarMobil
   - UC_Transaksi
   - UC_DataPelanggan

3. **Add database integration**
   - Models
   - Services
   - DAL

4. **Polish UI**
   - Add icons
   - Animations
   - Responsive design

---

## 🚀 Ready to Code!

**Build ✅ | Run ✅ | Test ✅ | Deploy 🎉**

Selamat mulai development! 🎊
