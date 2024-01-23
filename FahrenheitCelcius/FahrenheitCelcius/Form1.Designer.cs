namespace FahrenheitCelcius
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
            AsteetLB = new Label();
            AsteetTB = new TextBox();
            MitenGB = new GroupBox();
            CelciusRB = new RadioButton();
            FahrenheitRB = new RadioButton();
            MuunnanBT = new Button();
            VastausLB = new Label();
            MitenGB.SuspendLayout();
            SuspendLayout();
            // 
            // AsteetLB
            // 
            AsteetLB.AutoSize = true;
            AsteetLB.Location = new Point(12, 64);
            AsteetLB.Name = "AsteetLB";
            AsteetLB.Size = new Size(140, 31);
            AsteetLB.TabIndex = 0;
            AsteetLB.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(158, 61);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(125, 38);
            AsteetTB.TabIndex = 1;
            // 
            // MitenGB
            // 
            MitenGB.Controls.Add(FahrenheitRB);
            MitenGB.Controls.Add(CelciusRB);
            MitenGB.Location = new Point(289, 12);
            MitenGB.Name = "MitenGB";
            MitenGB.Size = new Size(250, 125);
            MitenGB.TabIndex = 2;
            MitenGB.TabStop = false;
            MitenGB.Text = "Miten muunnat?";
            // 
            // CelciusRB
            // 
            CelciusRB.AutoSize = true;
            CelciusRB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CelciusRB.Location = new Point(6, 33);
            CelciusRB.Name = "CelciusRB";
            CelciusRB.Size = new Size(110, 35);
            CelciusRB.TabIndex = 0;
            CelciusRB.TabStop = true;
            CelciusRB.Text = "Celcius";
            CelciusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.Location = new Point(6, 64);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(149, 35);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // MuunnanBT
            // 
            MuunnanBT.Location = new Point(545, 61);
            MuunnanBT.Name = "MuunnanBT";
            MuunnanBT.Size = new Size(133, 41);
            MuunnanBT.TabIndex = 3;
            MuunnanBT.Text = "Muunnan";
            MuunnanBT.UseVisualStyleBackColor = true;
            MuunnanBT.Click += MuunnanBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(22, 161);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(91, 31);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(VastausLB);
            Controls.Add(MuunnanBT);
            Controls.Add(MitenGB);
            Controls.Add(AsteetTB);
            Controls.Add(AsteetLB);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Celcius to Fahrenheit";
            MitenGB.ResumeLayout(false);
            MitenGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AsteetLB;
        private TextBox AsteetTB;
        private GroupBox MitenGB;
        private RadioButton FahrenheitRB;
        private RadioButton CelciusRB;
        private Button MuunnanBT;
        private Label VastausLB;
    }
}
