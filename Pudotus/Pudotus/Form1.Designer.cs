namespace Pudotus
{
    partial class Form1
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
            this.AvainLB = new System.Windows.Forms.Label();
            this.OppilaitosLB = new System.Windows.Forms.Label();
            this.VastuuhenkiloLB = new System.Windows.Forms.Label();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.Puhelin2LB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvainLB
            // 
            this.AvainLB.AutoSize = true;
            this.AvainLB.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvainLB.Location = new System.Drawing.Point(22, 14);
            this.AvainLB.Name = "AvainLB";
            this.AvainLB.Size = new System.Drawing.Size(443, 47);
            this.AvainLB.TabIndex = 0;
            this.AvainLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // OppilaitosLB
            // 
            this.OppilaitosLB.AutoSize = true;
            this.OppilaitosLB.Location = new System.Drawing.Point(31, 78);
            this.OppilaitosLB.Name = "OppilaitosLB";
            this.OppilaitosLB.Size = new System.Drawing.Size(159, 25);
            this.OppilaitosLB.TabIndex = 1;
            this.OppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // VastuuhenkiloLB
            // 
            this.VastuuhenkiloLB.AutoSize = true;
            this.VastuuhenkiloLB.Location = new System.Drawing.Point(290, 78);
            this.VastuuhenkiloLB.Name = "VastuuhenkiloLB";
            this.VastuuhenkiloLB.Size = new System.Drawing.Size(159, 25);
            this.VastuuhenkiloLB.TabIndex = 2;
            this.VastuuhenkiloLB.Text = "Valitse oppilaitos:";
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(31, 119);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(159, 33);
            this.OppilaitosCB.TabIndex = 3;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // VastuuhenkiloCB
            // 
            this.VastuuhenkiloCB.FormattingEnabled = true;
            this.VastuuhenkiloCB.Location = new System.Drawing.Point(290, 119);
            this.VastuuhenkiloCB.Name = "VastuuhenkiloCB";
            this.VastuuhenkiloCB.Size = new System.Drawing.Size(159, 33);
            this.VastuuhenkiloCB.TabIndex = 4;
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(31, 173);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(70, 25);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite:";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(31, 214);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(118, 25);
            this.PostinumeroLB.TabIndex = 6;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(31, 255);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(153, 25);
            this.PostitoimipaikkaLB.TabIndex = 7;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka:";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(31, 296);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(76, 25);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // Puhelin2LB
            // 
            this.Puhelin2LB.AutoSize = true;
            this.Puhelin2LB.Location = new System.Drawing.Point(290, 296);
            this.Puhelin2LB.Name = "Puhelin2LB";
            this.Puhelin2LB.Size = new System.Drawing.Size(76, 25);
            this.Puhelin2LB.TabIndex = 12;
            this.Puhelin2LB.Text = "Puhelin";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(290, 255);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(108, 25);
            this.EmailLB.TabIndex = 11;
            this.EmailLB.Text = "Sähköposti:";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(290, 214);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(73, 25);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto:";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(290, 173);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(63, 25);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "Titteli:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 371);
            this.Controls.Add(this.Puhelin2LB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.VastuuhenkiloCB);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.VastuuhenkiloLB);
            this.Controls.Add(this.OppilaitosLB);
            this.Controls.Add(this.AvainLB);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AvainLB;
        private Label OppilaitosLB;
        private Label VastuuhenkiloLB;
        private ComboBox OppilaitosCB;
        private ComboBox VastuuhenkiloCB;
        private Label OsoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label Puhelin2LB;
        private Label EmailLB;
        private Label OsastoLB;
        private Label TitteliLB;
    }
}