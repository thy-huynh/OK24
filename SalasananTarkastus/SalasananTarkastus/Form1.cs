namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaLB.Text == "Thy" && SalasanaTB.Text == "ErkkiMerkk1")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            { VirheviestiLB.Text = "K�ytt�j�tunnus tai salasana virheellinen"
              VirheviestiLB.Visible = true;      
            }
        }
    }
}
