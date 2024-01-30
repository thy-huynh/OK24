using System.Drawing.Printing;
using System.Linq.Expressions;
using System.Windows.Forms.Design;

namespace Muistio
{
    public partial class NoteForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public NoteForm()

        {
            InitializeComponent();
        }
        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(richTB.Text))
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");
                }
                else
                {
                    richTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }

        }
        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(richTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt|Rikas rakas tekstiformaatti (*.rtf) | *.rtf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTB.Text);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa: " + ex);
            }
        }
        private void NoteForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TekstilaatikkoRTB.Text = "")
            { tallennaToolStripMenuItem_Click(sender, e);
                TekstilaatiokkoRTB.Text = "";
            }
            else
            {
                {
                    TekstilaatikkoRTB.Text = "";
                }
                UusiTiedosto();
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            { Filter = "Rikastekstiformaatti| *.rtf", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader v1 = new StreamReader(atk.FileName))
                    {
                        tiedostoPolku = atk.FileName;
                        Task<string> teksti = v1.ReadToEndAsync();
                        richTB.Rtf = teksti.Result;
                    }
                }
            }
            AvaaTiedosto();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richTB.Text))
                {
                    TallennaTiedosto();
                }
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTB.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Document = PrintDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                PrintDocument1.Print();
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            { Filter = "TextDocument|*.txt", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
            }
            using (StreamWriter jonokirjoittaja = new StreamWriter(tkk.FileName))
            {
                jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Text);
            }

            }
        }

        private void tulostaEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
        printPreviewDialog1.Document = printDocument1;
        printPreviewDialog1.ShowDialog();
        }
    }
}