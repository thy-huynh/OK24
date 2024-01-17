namespace LukujenJarjestys
{
    partial class LukujenJarjestys
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
            LukuLB = new Label();
            uusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // LukuLB
            // 
            LukuLB.AutoSize = true;
            LukuLB.Location = new Point(47, 43);
            LukuLB.Name = "LukuLB";
            LukuLB.Size = new Size(327, 38);
            LukuLB.TabIndex = 0;
            LukuLB.Text = "Anna luku (-999 lopetus):";
            // 
            // uusiLukuTB
            // 
            uusiLukuTB.Location = new Point(380, 43);
            uusiLukuTB.Name = "uusiLukuTB";
            uusiLukuTB.Size = new Size(239, 43);
            uusiLukuTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(47, 98);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(109, 38);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 512);
            Controls.Add(VastausLB);
            Controls.Add(uusiLukuTB);
            Controls.Add(LukuLB);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "LukujenJarjestys";
            Text = "Lukujen Järjestys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LukuLB;
        private TextBox uusiLukuTB;
        private Label VastausLB;
    }
}
