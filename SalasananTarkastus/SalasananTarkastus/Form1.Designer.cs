namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            KayttajaLB = new Label();
            SalasanaLB = new Label();
            KayttajaTB = new TextBox();
            SalasanaTB = new TextBox();
            TarkistaBT = new Button();
            VirheviestiLB = new Label();
            SalasanaOikeinPanel = new Panel();
            label1 = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(SalasanaLB);
            SalasanaPanel.Controls.Add(KayttajaLB);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(763, 318);
            SalasanaPanel.TabIndex = 0;
            // 
            // KayttajaLB
            // 
            KayttajaLB.AutoSize = true;
            KayttajaLB.Location = new Point(49, 37);
            KayttajaLB.Name = "KayttajaLB";
            KayttajaLB.Size = new Size(256, 46);
            KayttajaLB.TabIndex = 0;
            KayttajaLB.Text = "Käyttäjätunnus:";
            // 
            // SalasanaLB
            // 
            SalasanaLB.AutoSize = true;
            SalasanaLB.Location = new Point(134, 98);
            SalasanaLB.Name = "SalasanaLB";
            SalasanaLB.Size = new Size(158, 46);
            SalasanaLB.TabIndex = 1;
            SalasanaLB.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(303, 37);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(316, 51);
            KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(303, 98);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(316, 51);
            SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(286, 173);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(200, 50);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.Location = new Point(49, 237);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(100, 46);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.Maroon;
            SalasanaOikeinPanel.Controls.Add(label1);
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(420, 136);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(250, 125);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(721, 99);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(18F, 44F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 318);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gold;
            Margin = new Padding(7, 7, 7, 7);
            Name = "SalasanaForm";
            Text = "Salasanan tarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Label SalasanaLB;
        private Label KayttajaLB;
        private Label VirheviestiLB;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Panel SalasanaOikeinPanel;
        private Label label1;
    }
}
