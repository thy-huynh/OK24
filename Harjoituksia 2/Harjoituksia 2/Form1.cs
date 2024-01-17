namespace Harjoituksia_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLB.Text = teksti;
            //TulostusLB.Text = ViestiTB.Text;
            TulostusLB.Visible = true;
        }
    }
}
