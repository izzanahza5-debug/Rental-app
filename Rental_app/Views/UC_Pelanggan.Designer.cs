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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label11 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox7 = new TextBox();
            label3 = new Label();
            textBox8 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnHapus);
            panel1.Location = new Point(0, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 70);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(5, 150, 105);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1048, 14);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 8;
            button1.Text = "➕ ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(37, 99, 235);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1192, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 42);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "✏️ ";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(220, 38, 38);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 28, 28);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(1336, 14);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(116, 42);
            btnHapus.TabIndex = 7;
            btnHapus.Text = "🗑️ ";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(24, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(438, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "👥  Data Pelanggan";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 71, 71);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 244, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(239, 239, 239);
            dataGridView1.Location = new Point(20, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(960, 532);
            dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(988, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 534);
            panel2.TabIndex = 18;
            panel2.Visible = false;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(5, 150, 105);
            label11.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(-1, -1);
            label11.Name = "label11";
            label11.Size = new Size(466, 58);
            label11.TabIndex = 18;
            label11.Text = "   ➕   Formulir Tambah Data";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(100, 116, 139);
            label10.Location = new Point(32, 78);
            label10.Name = "label10";
            label10.Size = new Size(151, 25);
            label10.TabIndex = 19;
            label10.Text = "NAMA LENGKAP";
            label10.Click += label10_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.5F);
            textBox1.ForeColor = Color.FromArgb(15, 23, 42);
            textBox1.Location = new Point(32, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 35);
            textBox1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(100, 116, 139);
            label9.Location = new Point(32, 152);
            label9.Name = "label9";
            label9.Size = new Size(182, 25);
            label9.TabIndex = 20;
            label9.Text = "NOMOR WHATSAPP";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10.5F);
            textBox2.ForeColor = Color.FromArgb(15, 23, 42);
            textBox2.Location = new Point(32, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 35);
            textBox2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(100, 116, 139);
            label1.Location = new Point(32, 228);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 27;
            label1.Text = "ALAMAT";
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10.5F);
            textBox4.ForeColor = Color.FromArgb(15, 23, 42);
            textBox4.Location = new Point(32, 254);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(400, 35);
            textBox4.TabIndex = 26;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(5, 150, 105);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 120, 87);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(32, 436);
            button5.Name = "button5";
            button5.Size = new Size(186, 46);
            button5.TabIndex = 24;
            button5.Text = "💾  SIMPAN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(100, 116, 139);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(246, 436);
            button4.Name = "button4";
            button4.Size = new Size(186, 46);
            button4.TabIndex = 25;
            button4.Text = "⬅  KEMBALI";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(988, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 534);
            panel3.TabIndex = 19;
            panel3.Visible = false;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(37, 99, 235);
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(-1, -1);
            label6.Name = "label6";
            label6.Size = new Size(466, 58);
            label6.TabIndex = 18;
            label6.Text = "   ✏️   Formulir Edit Data";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label5.Location = new Point(32, 78);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 19;
            label5.Text = "NAMA LENGKAP";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 10.5F);
            textBox6.ForeColor = Color.FromArgb(15, 23, 42);
            textBox6.Location = new Point(32, 104);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(400, 35);
            textBox6.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(100, 116, 139);
            label4.Location = new Point(32, 152);
            label4.Name = "label4";
            label4.Size = new Size(182, 25);
            label4.TabIndex = 20;
            label4.Text = "NOMOR WHATSAPP";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Segoe UI", 10.5F);
            textBox7.ForeColor = Color.FromArgb(15, 23, 42);
            textBox7.Location = new Point(32, 178);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(400, 35);
            textBox7.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(32, 226);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 21;
            label3.Text = "TOTAL SEWA";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Segoe UI", 10.5F);
            textBox8.ForeColor = Color.FromArgb(15, 23, 42);
            textBox8.Location = new Point(32, 252);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(400, 35);
            textBox8.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(32, 300);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 27;
            label2.Text = "ALAMAT";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 10.5F);
            textBox5.ForeColor = Color.FromArgb(15, 23, 42);
            textBox5.Location = new Point(32, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(400, 35);
            textBox5.TabIndex = 26;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(37, 99, 235);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(32, 436);
            button6.Name = "button6";
            button6.Size = new Size(186, 46);
            button6.TabIndex = 24;
            button6.Text = "💾  SIMPAN";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(100, 116, 139);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 85, 105);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(246, 436);
            button3.Name = "button3";
            button3.Size = new Size(186, 46);
            button3.TabIndex = 25;
            button3.Text = "⬅  KEMBALI";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UC_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "UC_Pelanggan";
            Size = new Size(1476, 715);
            Load += UC_Pelanggan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEdit;
        private Button btnHapus;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox4;
        private Panel panel3;
        private Label label2;
        private TextBox textBox5;
        private Button button3;
        private Button button6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}