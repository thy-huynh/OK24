namespace Kysymykset
{
    partial class VastauslomakeFORM
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
            KysymysLB = new Label();
            VastausLB = new Label();
            VastausGB = new GroupBox();
            VastausDRB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausCRB = new RadioButton();
            VastausARB = new RadioButton();
            DummyRB = new RadioButton();
            VastausGB.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(26, 32);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(264, 32);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 1.kysymykseen:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(26, 181);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(93, 32);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // VastausGB
            // 
            VastausGB.Controls.Add(VastausDRB);
            VastausGB.Controls.Add(VastausBRB);
            VastausGB.Controls.Add(VastausCRB);
            VastausGB.Controls.Add(VastausARB);
            VastausGB.Controls.Add(DummyRB);
            VastausGB.Location = new Point(296, 12);
            VastausGB.Name = "VastausGB";
            VastausGB.Size = new Size(122, 179);
            VastausGB.TabIndex = 2;
            VastausGB.TabStop = false;
            VastausGB.Text = "Vastaus";
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(7, 132);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(52, 36);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(8, 70);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(49, 36);
            VastausBRB.TabIndex = 3;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(8, 101);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(50, 36);
            VastausCRB.TabIndex = 2;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(7, 38);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(50, 36);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            DummyRB.AutoCheck = false;
            DummyRB.AutoSize = true;
            DummyRB.Location = new Point(7, 38);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(47, 36);
            DummyRB.TabIndex = 0;
            DummyRB.TabStop = true;
            DummyRB.Text = "E";
            DummyRB.UseVisualStyleBackColor = true;
            DummyRB.Visible = false;
            // 
            // VastauslomakeFORM
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 258);
            Controls.Add(VastausGB);
            Controls.Add(VastausLB);
            Controls.Add(KysymysLB);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "VastauslomakeFORM";
            Text = "Vastauslomake";
            Load += VastauslomakeFORM_Load;
            VastausGB.ResumeLayout(false);
            VastausGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox VastausGB;
        private RadioButton DummyRB;
        private RadioButton VastausDRB;
        private RadioButton VastausBRB;
        private RadioButton VastausCRB;
        private RadioButton VastausARB;
    }
}