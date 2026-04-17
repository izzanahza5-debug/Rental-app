namespace Rental_app
{
    partial class UC_Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDaftarMobil = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbInput = new Label();
            comboBox2 = new ComboBox();
            txt_nama = new TextBox();
            txt_plat = new TextBox();
            txt_hari = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pnlToolbar = new Panel();
            button3 = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            panel2 = new Panel();
            button4 = new Button();
            button5 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox4 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlToolbar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbDaftarMobil
            // 
            lbDaftarMobil.AutoSize = true;
            lbDaftarMobil.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbDaftarMobil.ForeColor = Color.FromArgb(33, 33, 33);
            lbDaftarMobil.Location = new Point(20, 20);
            lbDaftarMobil.Name = "lbDaftarMobil";
            lbDaftarMobil.Size = new Size(343, 54);
            lbDaftarMobil.TabIndex = 12;
            lbDaftarMobil.Text = "📝  Daftar Mobil";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(52, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(356, 33);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbInput);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(txt_nama);
            panel1.Controls.Add(txt_plat);
            panel1.Controls.Add(txt_hari);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(937, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 532);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 67, 54);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 11F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(238, 456);
            button2.Name = "button2";
            button2.Size = new Size(170, 50);
            button2.TabIndex = 25;
            button2.Text = "KEMBALI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(52, 456);
            button1.Name = "button1";
            button1.Size = new Size(170, 50);
            button1.TabIndex = 24;
            button1.Text = "SIMPAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 372);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 23;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 296);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 22;
            label4.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 225);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 21;
            label3.Text = "Harga / Hari";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 156);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 20;
            label2.Text = "Nomor Plat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 89);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 19;
            label1.Text = "Nama Mobil";
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbInput.Location = new Point(136, 20);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(208, 38);
            lbInput.TabIndex = 18;
            lbInput.Text = "Formulir Input ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(52, 403);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(356, 33);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(52, 117);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(356, 31);
            txt_nama.TabIndex = 16;
            // 
            // txt_plat
            // 
            txt_plat.Location = new Point(52, 184);
            txt_plat.Name = "txt_plat";
            txt_plat.Size = new Size(356, 31);
            txt_plat.TabIndex = 15;
            // 
            // txt_hari
            // 
            txt_hari.Location = new Point(52, 257);
            txt_hari.Name = "txt_hari";
            txt_hari.Size = new Size(356, 31);
            txt_hari.TabIndex = 14;
            txt_hari.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(20, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(911, 532);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama Mobil";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nomor Plat";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Harga / Hari";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 197;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kategori";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.BorderStyle = BorderStyle.FixedSingle;
            pnlToolbar.Controls.Add(button3);
            pnlToolbar.Controls.Add(btnEdit);
            pnlToolbar.Controls.Add(btnHapus);
            pnlToolbar.Location = new Point(20, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1404, 60);
            pnlToolbar.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(76, 175, 80);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1065, 10);
            button3.Name = "button3";
            button3.Size = new Size(92, 40);
            button3.TabIndex = 5;
            button3.Text = "➕ Tambah";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(comboBox4);
            panel2.Location = new Point(937, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 532);
            panel2.TabIndex = 17;
            panel2.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(244, 67, 54);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Calibri", 11F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(238, 456);
            button4.Name = "button4";
            button4.Size = new Size(170, 50);
            button4.TabIndex = 25;
            button4.Text = "KEMBALI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(52, 152, 219);
            button5.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Snow;
            button5.Location = new Point(52, 456);
            button5.Name = "button5";
            button5.Size = new Size(170, 50);
            button5.TabIndex = 24;
            button5.Text = "SIMPAN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 372);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 23;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 296);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 22;
            label7.Text = "Kategori";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 225);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 21;
            label8.Text = "Harga / Hari";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 156);
            label9.Name = "label9";
            label9.Size = new Size(103, 25);
            label9.TabIndex = 20;
            label9.Text = "Nomor Plat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 89);
            label10.Name = "label10";
            label10.Size = new Size(110, 25);
            label10.TabIndex = 19;
            label10.Text = "Nama Mobil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(136, 20);
            label11.Name = "label11";
            label11.Size = new Size(234, 38);
            label11.TabIndex = 18;
            label11.Text = "Formulir Update ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(52, 403);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(356, 33);
            comboBox3.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 31);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += txt_namaEdit_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(52, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 31);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 31);
            textBox3.TabIndex = 14;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(52, 328);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(356, 33);
            comboBox4.TabIndex = 13;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(panel2);
            Controls.Add(pnlToolbar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(lbDaftarMobil);
            Name = "UC_Home";
            Size = new Size(1427, 844);
            Load += UC_Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlToolbar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbDaftarMobil;
        private ComboBox comboBox1;
        private Panel panel1;
        private ComboBox comboBox2;
        private TextBox txt_nama;
        private TextBox txt_plat;
        private TextBox txt_hari;
        private Label lbInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel pnlToolbar;
        private Button button3;
        private Button btnEdit;
        private Button btnHapus;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox4;
    }
}
