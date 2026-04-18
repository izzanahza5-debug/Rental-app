namespace Rental_app
{
    partial class UC_Status
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
            lblTitle = new Label();
            pnlToolbar = new Panel();
            button1 = new Button();
            txt_search = new TextBox();
            button3 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            pnlToolbar.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(405, 54);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "🕑  Status Pinjaman";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.BorderStyle = BorderStyle.FixedSingle;
            pnlToolbar.Controls.Add(button1);
            pnlToolbar.Controls.Add(txt_search);
            pnlToolbar.Controls.Add(button3);
            pnlToolbar.Location = new Point(20, 110);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1365, 77);
            pnlToolbar.TabIndex = 18;
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
            txt_search.Location = new Point(15, 10);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(314, 49);
            txt_search.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 116, 199);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1140, 10);
            button3.Name = "button3";
            button3.Size = new Size(198, 49);
            button3.TabIndex = 5;
            button3.Text = "Refresh Data";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(1365, 150);
            panel1.TabIndex = 19;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 58, 158);
            button2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1140, 60);
            button2.Name = "button2";
            button2.Size = new Size(180, 62);
            button2.TabIndex = 11;
            button2.Text = "Lihat Detail";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(148, 0, 212);
            label11.Location = new Point(713, 88);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(60, 41);
            label11.TabIndex = 10;
            label11.Text = "🕑";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(765, 94);
            label9.Name = "label9";
            label9.Size = new Size(292, 28);
            label9.TabIndex = 9;
            label9.Text = "12 April 2026 - 14 April 2026";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(723, 61);
            label10.Name = "label10";
            label10.Size = new Size(179, 25);
            label10.TabIndex = 8;
            label10.Text = "DURASI PINJAMAN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(454, 98);
            label6.Name = "label6";
            label6.Size = new Size(151, 28);
            label6.TabIndex = 7;
            label6.Text = "Avanza Hybrid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(454, 64);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 6;
            label7.Text = "MOBIL";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label8);
            panel3.Location = new Point(363, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(53, 62);
            panel3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(31, 120, 255);
            label8.Location = new Point(0, 9);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(60, 41);
            label8.TabIndex = 1;
            label8.Text = "🚗";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(117, 98);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 4;
            label5.Text = "Izzan Ahza Alisti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(117, 64);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 3;
            label4.Text = "PENYEWA";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(26, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(53, 62);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(0, 9);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(60, 41);
            label3.TabIndex = 1;
            label3.Text = "👤";
            label3.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(148, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(160, 28);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(8, 116, 199);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 2;
            label2.Text = "Dalam Pinjaman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "ID: TRX-001";
            // 
            // UC_Status
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlToolbar);
            Controls.Add(lblTitle);
            Name = "UC_Status";
            Size = new Size(1401, 636);
            Load += UC_Status_Load;
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel pnlToolbar;
        private Button button1;
        private TextBox txt_search;
        private Button button3;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label9;
        private Label label10;
        private Button button2;
    }
}
