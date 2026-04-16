namespace Rental_app
{
    partial class UC_Transaksi
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
            flowLayoutStats = new FlowLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cardPendapatan = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblTitle = new Label();
            pnlToolbar = new Panel();
            button1 = new Button();
            txt_search = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            flowLayoutStats.SuspendLayout();
            panel2.SuspendLayout();
            cardPendapatan.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutStats
            // 
            flowLayoutStats.Controls.Add(panel2);
            flowLayoutStats.Location = new Point(20, 110);
            flowLayoutStats.Name = "flowLayoutStats";
            flowLayoutStats.Size = new Size(1400, 150);
            flowLayoutStats.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 130);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.FromArgb(51, 171, 101);
            label3.Location = new Point(266, 33);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 10);
            label3.Size = new Size(78, 64);
            label3.TabIndex = 20;
            label3.Text = "💵";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 49);
            label2.Name = "label2";
            label2.Size = new Size(228, 38);
            label2.TabIndex = 20;
            label2.Text = "Rp. 124.500.000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 20;
            label1.Text = "Total Pendapatan";
            label1.Click += label1_Click_1;
            // 
            // cardPendapatan
            // 
            cardPendapatan.BackColor = Color.White;
            cardPendapatan.BorderStyle = BorderStyle.FixedSingle;
            cardPendapatan.Controls.Add(label7);
            cardPendapatan.Controls.Add(label8);
            cardPendapatan.Controls.Add(label9);
            cardPendapatan.Location = new Point(1006, 110);
            cardPendapatan.Margin = new Padding(0);
            cardPendapatan.Name = "cardPendapatan";
            cardPendapatan.Size = new Size(379, 130);
            cardPendapatan.TabIndex = 3;
            cardPendapatan.Paint += cardPendapatan_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20F);
            label7.ForeColor = Color.FromArgb(148, 0, 212);
            label7.Location = new Point(283, 39);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 10);
            label7.Size = new Size(78, 64);
            label7.TabIndex = 21;
            label7.Text = "📌";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 55);
            label8.Name = "label8";
            label8.Size = new Size(212, 38);
            label8.TabIndex = 22;
            label8.Text = "Rp. 20.000.000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(20, 25);
            label9.Name = "label9";
            label9.Size = new Size(151, 28);
            label9.TabIndex = 23;
            label9.Text = "Rata-rata Order";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 54);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "💰  Transaksi";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.BorderStyle = BorderStyle.FixedSingle;
            pnlToolbar.Controls.Add(button1);
            pnlToolbar.Controls.Add(txt_search);
            pnlToolbar.Controls.Add(button3);
            pnlToolbar.Location = new Point(20, 301);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1365, 77);
            pnlToolbar.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 116, 199);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(363, 10);
            button1.Name = "button1";
            button1.Size = new Size(109, 49);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(15, 20);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(314, 31);
            txt_search.TabIndex = 6;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 116, 199);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1056, 10);
            button3.Name = "button3";
            button3.Size = new Size(282, 49);
            button3.TabIndex = 5;
            button3.Text = "EXPORT DATA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(20, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1365, 352);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(509, 110);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 130);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.FromArgb(31, 120, 255);
            label4.Location = new Point(283, 39);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 10);
            label4.Size = new Size(78, 64);
            label4.TabIndex = 21;
            label4.Text = "📅";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 55);
            label5.Name = "label5";
            label5.Size = new Size(65, 38);
            label5.TabIndex = 22;
            label5.Text = "850";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(20, 25);
            label6.Name = "label6";
            label6.Size = new Size(182, 28);
            label6.TabIndex = 23;
            label6.Text = "Penyewaan Selesai";
            // 
            // Column7
            // 
            Column7.HeaderText = "Id Transaksi";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Pelanggan";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 190;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mobil";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tanggal";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total Biaya";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 210;
            // 
            // Column6
            // 
            Column6.HeaderText = "Metode";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 195;
            // 
            // UC_Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(pnlToolbar);
            Controls.Add(cardPendapatan);
            Controls.Add(lblTitle);
            Controls.Add(flowLayoutStats);
            Name = "UC_Transaksi";
            Size = new Size(1429, 764);
            Load += UC_Transaksi_Load;
            flowLayoutStats.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            cardPendapatan.ResumeLayout(false);
            cardPendapatan.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutStats;
        private Panel cardPendapatan;
        private Label lblTitle;
        private Panel pnlToolbar;
        private Button button1;
        private TextBox txt_search;
        private Button button3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
