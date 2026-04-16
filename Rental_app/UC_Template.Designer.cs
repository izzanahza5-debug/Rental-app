namespace Rental_app
{
    partial class UC_Template
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
            lblContent = new Label();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 33, 33);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Page Title";

            // lblContent
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 12F);
            lblContent.ForeColor = Color.FromArgb(100, 100, 100);
            lblContent.Location = new Point(20, 80);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(200, 35);
            lblContent.TabIndex = 1;
            lblContent.Text = "Page content goes here...";

            // UC_Template
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Name = "UC_Template";
            Size = new Size(1440, 920);
            Load += UC_Template_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblContent;
    }
}
