namespace BMI
{
    public partial class BMIFrom : Form
    {
        public BMIFrom()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0,  pituus = 0, bmi;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            bmi = Math.Round(paino / (pituus * pituus),2);
            if(bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Blue;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Blue;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if(bmi < 25) 
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else if(bmi < 40)
            {
                VastausLB.Text = "Painoindeksi on: " + bmi;
                VastausLB.ForeColor = Color.Yellow;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Yellow;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Red;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
                VastausLB.Visible = true;
            }
        }
    }
}