namespace Rental_app
{
    partial class UC_Status : System.Windows.Forms.UserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblTitle = new Label();
            dgvStatus = new DataGridView();
            pnlFooter = new Panel();
            btnRefresh = new Button();
            btnPerpanjang = new Button();
            btnSelesai = new Button();
            label1 = new Label();
            label2 = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatus).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Controls.Add(lblSearch);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(5, 6, 5, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1500, 154);
            pnlHeader.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.LightGray;
            lblSearch.Location = new Point(967, 64);
            lblSearch.Margin = new Padding(5, 0, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(97, 25);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Cari Mobil:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(1083, 56);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(381, 37);
            txtSearch.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(33, 48);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Status Pinjaman Kendaraan";
            // 
            // dgvStatus
            // 
            dgvStatus.AllowUserToAddRows = false;
            dgvStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatus.BackgroundColor = Color.FromArgb(245, 246, 250);
            dgvStatus.BorderStyle = BorderStyle.None;
            dgvStatus.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStatus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStatus.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 241, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStatus.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStatus.Dock = DockStyle.Fill;
            dgvStatus.EnableHeadersVisualStyles = false;
            dgvStatus.GridColor = Color.FromArgb(239, 241, 243);
            dgvStatus.Location = new Point(0, 154);
            dgvStatus.Margin = new Padding(5, 6, 5, 6);
            dgvStatus.Name = "dgvStatus";
            dgvStatus.RowHeadersVisible = false;
            dgvStatus.RowHeadersWidth = 62;
            dgvStatus.RowTemplate.Height = 35;
            dgvStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatus.Size = new Size(1500, 807);
            dgvStatus.TabIndex = 1;
            dgvStatus.CellContentClick += dgvStatus_CellContentClick;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.White;
            pnlFooter.Controls.Add(btnRefresh);
            pnlFooter.Controls.Add(btnPerpanjang);
            pnlFooter.Controls.Add(btnSelesai);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 961);
            pnlFooter.Margin = new Padding(5, 6, 5, 6);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1500, 135);
            pnlFooter.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(149, 165, 166);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(42, 29);
            btnRefresh.Margin = new Padding(5, 6, 5, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(200, 77);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnPerpanjang
            // 
            btnPerpanjang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPerpanjang.BackColor = Color.FromArgb(241, 196, 15);
            btnPerpanjang.FlatAppearance.BorderSize = 0;
            btnPerpanjang.FlatStyle = FlatStyle.Flat;
            btnPerpanjang.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPerpanjang.ForeColor = Color.White;
            btnPerpanjang.Location = new Point(983, 29);
            btnPerpanjang.Margin = new Padding(5, 6, 5, 6);
            btnPerpanjang.Name = "btnPerpanjang";
            btnPerpanjang.Size = new Size(217, 77);
            btnPerpanjang.TabIndex = 1;
            btnPerpanjang.Text = "Perpanjang Sewa";
            btnPerpanjang.UseVisualStyleBackColor = false;
            btnPerpanjang.Click += btnPerpanjang_Click;
            // 
            // btnSelesai
            // 
            btnSelesai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelesai.BackColor = Color.FromArgb(46, 204, 113);
            btnSelesai.FlatAppearance.BorderSize = 0;
            btnSelesai.FlatStyle = FlatStyle.Flat;
            btnSelesai.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSelesai.ForeColor = Color.White;
            btnSelesai.Location = new Point(1233, 29);
            btnSelesai.Margin = new Padding(5, 6, 5, 6);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(233, 77);
            btnSelesai.TabIndex = 2;
            btnSelesai.Text = "Mobil Kembali";
            btnSelesai.UseVisualStyleBackColor = false;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(492, 339);
            label1.Name = "label1";
            label1.Size = new Size(527, 51);
            label1.TabIndex = 3;
            label1.Text = "TIdak Ada Transaksi Yang Aktif";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(661, 213);
            label2.Name = "label2";
            label2.Size = new Size(136, 94);
            label2.TabIndex = 4;
            label2.Text = "🚗";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // UC_Status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStatus);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UC_Status";
            Size = new Size(1500, 1096);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatus).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPerpanjang;
        private System.Windows.Forms.Button btnSelesai;
        private Label label1;
        private Label label2;
    }
}