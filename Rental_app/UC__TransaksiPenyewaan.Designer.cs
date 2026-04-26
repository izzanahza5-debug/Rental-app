namespace Rental_app
{
    partial class UC__TransaksiPenyewaan
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
            GroupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(comboBox1);
            GroupBox1.Location = new Point(0, 0);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(1834, 353);
            GroupBox1.TabIndex = 0;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Data Sewa";
            GroupBox1.UseCompatibleTextRendering = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // UC__TransaksiPenyewaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBox1);
            Name = "UC__TransaksiPenyewaan";
            Size = new Size(1834, 861);
            GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox1;
        private ComboBox comboBox1;
    }
}
