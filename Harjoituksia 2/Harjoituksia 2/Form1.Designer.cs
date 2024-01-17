namespace Harjoituksia_2
{
    partial class Form2
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
            OtsikkoLB = new Label();
            TulostusLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(33, 35);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(381, 44);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TulostusLB.Location = new Point(33, 95);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(96, 44);
            TulostusLB.TabIndex = 1;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ViestiTB.Location = new Point(409, 36);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(379, 43);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Location = new Point(513, 95);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(179, 29);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Form2";
            Text = "Harjoitus 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostusLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}
