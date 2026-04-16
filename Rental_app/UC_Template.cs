namespace Rental_app
{
    public partial class UC_Template : UserControl
    {
        public UC_Template()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }

        public void SetContent(string content)
        {
            lblContent.Text = content;
        }

        private void UC_Template_Load(object sender, EventArgs e)
        {
        }
    }
}
