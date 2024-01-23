namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa1PB);
            piirraNoppa(Noppa2PB);
            Wait(1000);
        }
        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();
            int noppa = satunnainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
            }
            }
            public void Wait(int time)
            {
                Thread thread = new Thread(delegate ()
                {
                    System.Threading.Thread.Sleep(time);
                });
                thread.Start();
                while (thread.IsAlive)
                    Application.DoEvents();
            }
        }
    }
