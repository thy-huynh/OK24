namespace Ajastin
{
    public partial class FinalCountdownForm : Form
    {
        private int kokonaisaika;

        private void FinalCountdownForm_Load(object sender, EventArgs e)
        {
        StopBT.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                MinuutitCB.Items.Add(i.ToString());
                SekunnitCB.Items.Add(i.ToString());
            }
                MinuutitCB.SelectedIndex = 30;
                SekunnitCB.SelectedIndex= 0;
        }
        public FinalCountdownForm()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled= false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
            }
            else { 
                AjastinTM.Stop();
            }
        }
    }
}