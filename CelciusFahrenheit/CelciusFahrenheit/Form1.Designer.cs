namespace CelciusFahrenheit
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
            label1 = new Label();
            MuunnaBT = new Button();
            groupBox1 = new GroupBox();
            FahrenheitRB = new RadioButton();
            CelciusRB = new RadioButton();
            AsteetTB = new TextBox();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet:";
            // 
            // MuunnaBT
            // 
            MuunnaBT.Location = new Point(482, 57);
            MuunnaBT.Margin = new Padding(5);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(119, 38);
            MuunnaBT.TabIndex = 1;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelciusRB);
            groupBox1.Location = new Point(289, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(183, 130);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunnan?";
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.Location = new Point(9, 81);
            FahrenheitRB.Margin = new Padding(5);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(154, 36);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelciusRB
            // 
            CelciusRB.AutoSize = true;
            CelciusRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CelciusRB.Location = new Point(9, 42);
            CelciusRB.Margin = new Padding(5);
            CelciusRB.Name = "CelciusRB";
            CelciusRB.Size = new Size(115, 36);
            CelciusRB.TabIndex = 0;
            CelciusRB.TabStop = true;
            CelciusRB.Text = "Celcius";
            CelciusRB.UseVisualStyleBackColor = true;
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(175, 54);
            AsteetTB.Margin = new Padding(5);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(104, 39);
            AsteetTB.TabIndex = 3;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(37, 169);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(93, 32);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 292);
            Controls.Add(VastausLB);
            Controls.Add(AsteetTB);
            Controls.Add(groupBox1);
            Controls.Add(MuunnaBT);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Aste muunnin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button MuunnaBT;
        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelciusRB;
        private TextBox AsteetTB;
        private Label VastausLB;
    }
}