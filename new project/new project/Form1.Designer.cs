namespace new_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            btnHitung = new Button();
            lblHasil = new Label();
            listBox1 = new ListBox();
            reset = new Button();
            SuspendLayout();
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(73, 85);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(150, 31);
            txtAngka1.TabIndex = 0;
            txtAngka1.TextChanged += txtAngka1_TextChanged;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(73, 166);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(150, 31);
            txtAngka2.TabIndex = 1;
            txtAngka2.TextChanged += textBox2_TextChanged;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(282, 186);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(112, 34);
            btnHitung.TabIndex = 2;
            btnHitung.Text = "hitung pembagian";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(455, 26);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(195, 25);
            lblHasil.TabIndex = 3;
            lblHasil.Text = "Hasil akan keluar di sini";
            lblHasil.Click += lblHasil_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(455, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(261, 229);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // reset
            // 
            reset.Location = new Point(282, 131);
            reset.Name = "reset";
            reset.Size = new Size(112, 34);
            reset.TabIndex = 5;
            reset.Text = "hapus";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reset);
            Controls.Add(listBox1);
            Controls.Add(lblHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAngka1;
        private TextBox txtAngka2;
        private Button btnHitung;
        private Label lblHasil;
        private ListBox listBox1;
        private Button reset;
    }
}
