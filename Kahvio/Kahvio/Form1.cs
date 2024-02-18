namespace Kahvio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 v�lituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka p�iv� maanantaista torstaisin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa l�mpimien \n ";
            MeistaLB.Text += " juomien lis�ksi virvokkeita sek� pient� purtavaa ja makeisia \n";
            MeistaLB.Text += " Tervetuloa tutustumaan! \n";
            MeistaLB.Font = new Font("Arial", 12);

        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = true;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = true;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = true;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = true;
            KoriPL.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = true;
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
