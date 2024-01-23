namespace Kysymykset
{
    public partial class VastauslomakeFORM : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D," };
        int laskuri = 0;
        int oikein = 0;
        public VastauslomakeFORM()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }

        private void VastauslomakeFORM_Load(object sender, EventArgs e)
        {
           
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 11)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;

                laskuri++;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 0; j < 11; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }            
            if(VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }            
            if(VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }            
            if(VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}