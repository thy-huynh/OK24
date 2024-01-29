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
                if(!string.IsNullOrEmpty(richTB.Text)) 
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
                if(openFileDialog.ShowDialog() == DialogResult.OK)
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
            UusiTiedosto();
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTB.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }
    }
}