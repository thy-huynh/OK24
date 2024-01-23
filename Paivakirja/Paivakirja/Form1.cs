

namespace Paivakirja
{
    public partial class DiaryFrom : Form
    {
        public DiaryFrom()
        {
            InitializeComponent();            
            string teksti = File.ReadAllText(@"C:\\Users\\pham.huynh\\source\\Repos\\Ok24\\Paivakirja\\Pkirja.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {   
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\pham.huynh\\source\\Repos\\Ok24\\Paivakirja\\Pkirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}