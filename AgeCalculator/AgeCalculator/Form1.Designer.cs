namespace AgeCalculator
{
    partial class IkaForm
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
            SyntymaAikaDT = new DateTimePicker();
            LaskeIkaBT = new Button();
            VuosinaLB = new Label();
            KuukausinaLB = new Label();
            PaivinaLB = new Label();
            TunteinaLB = new Label();
            MinuutteinaLB = new Label();
            SekunteinaLB = new Label();
            SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            SyntymaAikaDT.Location = new Point(40, 39);
            SyntymaAikaDT.Name = "SyntymaAikaDT";
            SyntymaAikaDT.Size = new Size(441, 43);
            SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeIkaBT
            // 
            LaskeIkaBT.Location = new Point(514, 39);
            LaskeIkaBT.Name = "LaskeIkaBT";
            LaskeIkaBT.Size = new Size(154, 43);
            LaskeIkaBT.TabIndex = 1;
            LaskeIkaBT.Text = "Laske ikä";
            LaskeIkaBT.UseVisualStyleBackColor = true;
            LaskeIkaBT.Click += LaskeBT_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Location = new Point(52, 123);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(114, 38);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuosina";
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Location = new Point(52, 179);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(158, 38);
            KuukausinaLB.TabIndex = 3;
            KuukausinaLB.Text = "Kuukausina";
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Location = new Point(52, 236);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(103, 38);
            PaivinaLB.TabIndex = 4;
            PaivinaLB.Text = "Päivinä";
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Location = new Point(294, 123);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(125, 38);
            TunteinaLB.TabIndex = 5;
            TunteinaLB.Text = "Tunteina";
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Location = new Point(294, 179);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(167, 38);
            MinuutteinaLB.TabIndex = 6;
            MinuutteinaLB.Text = "Minuutteina";
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Location = new Point(294, 236);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(154, 38);
            SekunteinaLB.TabIndex = 7;
            SekunteinaLB.Text = "Sekunteina";
            // 
            // IkaForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 832);
            Controls.Add(SekunteinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(LaskeIkaBT);
            Controls.Add(SyntymaAikaDT);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "IkaForm";
            Text = "Ikälaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Button LaskeIkaBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekunteinaLB;
    }
}
