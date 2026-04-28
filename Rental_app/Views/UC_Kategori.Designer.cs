namespace Rental_app
{
    partial class UC_Kategori
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlToolbar = new Panel();
            button1 = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            gridKategori = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colharga = new DataGridViewTextBoxColumn();
            panel_input = new Panel();
            button2 = new Button();
            txt_nama = new TextBox();
            label1 = new Label();
            btnTambah = new Button();
            label3 = new Label();
            txt_kode = new MaskedTextBox();
            label2 = new Label();
            panel_edit = new Panel();
            button3 = new Button();
            txtNamaEdit = new TextBox();
            label4 = new Label();
            btn_edit = new Button();
            label5 = new Label();
            txtKodeEdit = new MaskedTextBox();
            label6 = new Label();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridKategori).BeginInit();
            panel_input.SuspendLayout();
            panel_edit.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(383, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🏷️  Kategori Mobil";
            lblTitle.Click += lblTitle_Click;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.BorderStyle = BorderStyle.FixedSingle;
            pnlToolbar.Controls.Add(button1);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnHapus);
            pnlToolbar.Location = new Point(20, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1400, 60);
            pnlToolbar.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1065, 10);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 5;
            button1.Text = "➕ Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1170, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ ";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(244, 67, 54);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 10F);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(1282, 10);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(100, 40);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "🗑️  Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // gridKategori
            // 
            gridKategori.AllowUserToDeleteRows = false;
            gridKategori.BackgroundColor = Color.White;
            gridKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridKategori.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridKategori.Location = new Point(20, 168);
            gridKategori.Name = "gridKategori";
            gridKategori.ReadOnly = true;
            gridKategori.RowHeadersWidth = 62;
            gridKategori.Size = new Size(665, 707);
            gridKategori.TabIndex = 2;
            gridKategori.CellContentClick += gridKategori_CellContentClick;
            // 
            // colID
            // 
            colID.MinimumWidth = 8;
            colID.Name = "colID";
            colID.Width = 150;
            // 
            // colharga
            // 
            colharga.MinimumWidth = 8;
            colharga.Name = "colharga";
            colharga.Width = 150;
            // 
            // panel_input
            // 
            panel_input.BackColor = Color.White;
            panel_input.BorderStyle = BorderStyle.FixedSingle;
            panel_input.Controls.Add(button2);
            panel_input.Controls.Add(txt_nama);
            panel_input.Controls.Add(label1);
            panel_input.Controls.Add(btnTambah);
            panel_input.Controls.Add(label3);
            panel_input.Controls.Add(txt_kode);
            panel_input.Controls.Add(label2);
            panel_input.Location = new Point(1048, 168);
            panel_input.Name = "panel_input";
            panel_input.Size = new Size(356, 359);
            panel_input.TabIndex = 3;
            panel_input.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 67, 54);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(184, 278);
            button2.Name = "button2";
            button2.Size = new Size(145, 40);
            button2.TabIndex = 7;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(23, 97);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(306, 31);
            txt_nama.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(264, 30);
            label1.TabIndex = 5;
            label1.Text = "Formulir Tambah Kategori";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(76, 175, 80);
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 10F);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(23, 278);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(145, 40);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "➕ Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 157);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 3;
            label3.Text = "Kode Kategori";
            // 
            // txt_kode
            // 
            txt_kode.Location = new Point(23, 196);
            txt_kode.Name = "txt_kode";
            txt_kode.Size = new Size(306, 31);
            txt_kode.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 62);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Kategori";
            label2.Click += label2_Click;
            // 
            // panel_edit
            // 
            panel_edit.BackColor = Color.White;
            panel_edit.BorderStyle = BorderStyle.FixedSingle;
            panel_edit.Controls.Add(button3);
            panel_edit.Controls.Add(txtNamaEdit);
            panel_edit.Controls.Add(label4);
            panel_edit.Controls.Add(btn_edit);
            panel_edit.Controls.Add(label5);
            panel_edit.Controls.Add(txtKodeEdit);
            panel_edit.Controls.Add(label6);
            panel_edit.Location = new Point(1047, 168);
            panel_edit.Name = "panel_edit";
            panel_edit.Size = new Size(356, 359);
            panel_edit.TabIndex = 4;
            panel_edit.Visible = false;
            panel_edit.Paint += panel_edit_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(244, 67, 54);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(184, 278);
            button3.Name = "button3";
            button3.Size = new Size(145, 40);
            button3.TabIndex = 7;
            button3.Text = "Kembali";
            button3.UseVisualStyleBackColor = false;
            // 
            // txtNamaEdit
            // 
            txtNamaEdit.Location = new Point(23, 97);
            txtNamaEdit.Name = "txtNamaEdit";
            txtNamaEdit.Size = new Size(306, 31);
            txtNamaEdit.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(50, 19);
            label4.Name = "label4";
            label4.Size = new Size(224, 30);
            label4.TabIndex = 5;
            label4.Text = "Formulir Edit Kategori";
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(52, 152, 219);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI", 10F);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(23, 278);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(145, 40);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "✏️ Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 157);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 3;
            label5.Text = "Kode Kategori";
            // 
            // txtKodeEdit
            // 
            txtKodeEdit.Location = new Point(23, 196);
            txtKodeEdit.Name = "txtKodeEdit";
            txtKodeEdit.Size = new Size(306, 31);
            txtKodeEdit.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 62);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 1;
            label6.Text = "Nama Kategori";
            // 
            // UC_Kategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(panel_edit);
            Controls.Add(panel_input);
            Controls.Add(gridKategori);
            Controls.Add(pnlToolbar);
            Controls.Add(lblTitle);
            Name = "UC_Kategori";
            Size = new Size(1440, 920);
            Load += UC_Kategori_Load;
            pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridKategori).EndInit();
            panel_input.ResumeLayout(false);
            panel_input.PerformLayout();
            panel_edit.ResumeLayout(false);
            panel_edit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Panel pnlToolbar;
        private Button btnEdit;
        private Button btnHapus;
        private DataGridView gridKategori;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colharga;
        private Panel panel_input;
        private Label label2;
        private Label label3;
        private MaskedTextBox txt_kode;
        private Button btnTambah;
        private Button button1;
        private Label label1;
        private TextBox txt_nama;
        private Button button2;
        private Panel panel_edit;
        private Button button3;
        private TextBox txtNamaEdit;
        private Label label4;
        private Button btn_edit;
        private Label label5;
        private MaskedTextBox txtKodeEdit;
        private Label label6;
    }
}
