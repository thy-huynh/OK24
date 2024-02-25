using System.Data;

namespace Pudotus
{
    public partial class Form1 : Form
    {
        DataTable oppilaitos = new DataTable();
        DataTable vastuuHenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            OppilaitosCB.DataSource = oppilaitos;
            OppilaitosCB.DisplayMember= "Onimi";
            taytaVastuuHenkilotTaulukko();
        }
        private void OppilaitosCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void taytaOppilaitosTaulukko()
        {
            oppilaitos.Columns.Add("OID",typeof(int));
            oppilaitos.Columns.Add("ONimi");
            oppilaitos.Columns.Add("OKatuosoite");
            oppilaitos.Columns.Add("OPostinumero");
            oppilaitos.Columns.Add("OPostitoimipaikka");
            oppilaitos.Columns.Add("OPuhelin");

            oppilaitos.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            oppilaitos.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            oppilaitos.Rows.Add(3, "Varia", "R‰lssitie 13", "01530", "Vantaa", "040 182 4668");
            oppilaitos.Rows.Add(4, "Keuda", "Sibeliuksenv‰yl‰ 55 A", "04400", "J‰rvenp‰‰", "09 27 381");
        }
        private void taytavastuuHenkilotTaulukko()
        { 
            vastuuHenkilot.Columns.Add("OID"), typeof(int));
            vastuuHenkilot.Columns.Add("Vnimi");
            vastuuHenkilot.Columns.Add("VTitteli");
            vastuuHenkilot.Columns.Add("VOsasto");
            vastuuHenkilot.Columns.Add("VSahkoposti");
            vastuuHenkilot.Columns.Add("VPuhelin");


        
        }
    }
}