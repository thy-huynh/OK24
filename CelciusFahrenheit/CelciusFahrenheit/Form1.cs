namespace CelciusFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if(CelciusRB.Checked) 
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celcius astetta ";
                VastausLB.Visible= true;
            }
            else if(FahrenheitRB.Checked) 
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " Celcius astetta "  + vastaus + " Fahrenheitia on";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                VastausLB.Visible = true;
            }
        }
    }
}