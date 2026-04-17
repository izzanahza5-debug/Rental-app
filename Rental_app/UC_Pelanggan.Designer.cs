namespace Rental_app
{
    partial class UC_Pelanggan
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            textBox1 = new TextBox();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox5 = new TextBox();
            label2 = new Label();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(20, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 69);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 198, 10);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(958, 10);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 9;
            button2.Text = "👁️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1064, 10);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 8;
            button1.Text = "➕ Tambah";
            button1.UseVisualStyleBackColor = false;
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
            btnEdit.TabIndex = 6;
            btnEdit.Text = "✏️ ";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(244, 67, 54);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 10F);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(1276, 10);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(100, 40);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "🗑️  Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(370, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "👥 Data Pelanggan";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(20, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1058, 412);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "NAMA & DETAIL";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "KONTAK";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "ALAMAT";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "TOTAL SEWA";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "STATUS";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 144;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(1084, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 412);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 76);
            label10.Name = "label10";
            label10.Size = new Size(110, 25);
            label10.TabIndex = 19;
            label10.Text = "Nama Mobil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(84, 18);
            label11.Name = "label11";
            label11.Size = new Size(170, 32);
            label11.TabIndex = 18;
            label11.Text = "Formulir Input";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 31);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 152);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 21;
            label1.Text = "Nama Mobil";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(16, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(295, 31);
            textBox5.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 233);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 23;
            label2.Text = "Nama Mobil";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(16, 261);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(295, 31);
            textBox6.TabIndex = 22;
            // 
            // UC_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "UC_Pelanggan";
            Size = new Size(1476, 715);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEdit;
        private Button btnHapus;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel2;
        private Label label11;
        private Label label10;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox6;
        private Label label1;
        private TextBox textBox5;
    }
}
