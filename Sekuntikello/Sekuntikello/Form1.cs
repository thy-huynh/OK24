using System.Diagnostics;

namespace Sekuntikello
{
    public partial class SekuntikelloForm : Form
    {
        private Stopwatch sekuntikello = new Stopwatch();
        public SekuntikelloForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekuntikello.Elapsed);
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekuntikello.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            sekuntikello.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekuntikello.Reset();
        }
    }
}