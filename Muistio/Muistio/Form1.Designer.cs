namespace Muistio
{
    partial class NoteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimelläToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaEsikatseluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.kopioiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leikkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liitäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorostusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTB
            // 
            this.richTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTB.Location = new System.Drawing.Point(0, 24);
            this.richTB.Margin = new System.Windows.Forms.Padding(5);
            this.richTB.Name = "richTB";
            this.richTB.Size = new System.Drawing.Size(635, 409);
            this.richTB.TabIndex = 0;
            this.richTB.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muokkaaToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.apuaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.tallennaNimelläToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tulostaEsikatseluToolStripMenuItem,
            this.tulostaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.lopetaToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lopetaToolStripMenuItem.Text = "Poistu";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem,
            this.tekstinKorostusToolStripMenuItem,
            this.tekstinRivitysToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.muotoileToolStripMenuItem.Text = "Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            this.kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            this.kirjasinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kirjasinToolStripMenuItem.Text = "Kirjasin";
            this.kirjasinToolStripMenuItem.Click += new System.EventHandler(this.kirjasinToolStripMenuItem_Click);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.kopioiToolStripMenuItem,
            this.leikkaaToolStripMenuItem,
            this.liitäToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.valitseKaikkiToolStripMenuItem});
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.muokkaaToolStripMenuItem.Text = "Muokkaa";
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.apuaToolStripMenuItem.Text = "Apua";
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            this.tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            this.tallennaNimelläToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä... ";
            this.tallennaNimelläToolStripMenuItem.Click += new System.EventHandler(this.tallennaNimelläToolStripMenuItem_Click);
            // 
            // tulostaEsikatseluToolStripMenuItem
            // 
            this.tulostaEsikatseluToolStripMenuItem.Name = "tulostaEsikatseluToolStripMenuItem";
            this.tulostaEsikatseluToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tulostaEsikatseluToolStripMenuItem.Text = "Tulosta esikatselu -";
            this.tulostaEsikatseluToolStripMenuItem.Click += new System.EventHandler(this.tulostaEsikatseluToolStripMenuItem_Click);
            // 
            // tulostaToolStripMenuItem
            // 
            this.tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            this.tulostaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tulostaToolStripMenuItem.Text = "Tulosta ";
            this.tulostaToolStripMenuItem.Click += new System.EventHandler(this.tulostaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(179, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            this.kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            this.kopioiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kopioiToolStripMenuItem.Text = "Kopioi";
            // 
            // leikkaaToolStripMenuItem
            // 
            this.leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            this.leikkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.leikkaaToolStripMenuItem.Text = "Leikkaa";
            // 
            // liitäToolStripMenuItem
            // 
            this.liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            this.liitäToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitäToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.liitäToolStripMenuItem.Text = "Liitä";
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.poistaToolStripMenuItem.Text = "Poista";
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            this.valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            this.valitseKaikkiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            this.tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            this.tekstinKorostusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            this.tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            this.tekstinRivitysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tietoaToolStripMenuItem.Text = "Tietoa";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 433);
            this.Controls.Add(this.richTB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NoteForm";
            this.Text = "Mini muistio";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem lopetaToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripMenuItem tulostaEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
    }
}