namespace Dice
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
            this.HeitaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Noppa1PB = new System.Windows.Forms.PictureBox();
            this.Noppa2PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa2PB)).BeginInit();
            this.SuspendLayout();
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.HeitaBT.Location = new System.Drawing.Point(14, 169);
            this.HeitaBT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(220, 38);
            this.HeitaBT.TabIndex = 0;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nopan heitto";
            // 
            // Noppa1PB
            // 
            this.Noppa1PB.Image = global::Dice.Properties.Resources.dice01;
            this.Noppa1PB.Location = new System.Drawing.Point(14, 61);
            this.Noppa1PB.Name = "Noppa1PB";
            this.Noppa1PB.Size = new System.Drawing.Size(100, 100);
            this.Noppa1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa1PB.TabIndex = 2;
            this.Noppa1PB.TabStop = false;
            // 
            // Noppa2PB
            // 
            this.Noppa2PB.Image = global::Dice.Properties.Resources.dice01;
            this.Noppa2PB.Location = new System.Drawing.Point(135, 61);
            this.Noppa2PB.Name = "Noppa2PB";
            this.Noppa2PB.Size = new System.Drawing.Size(100, 100);
            this.Noppa2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa2PB.TabIndex = 3;
            this.Noppa2PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 256);
            this.Controls.Add(this.Noppa2PB);
            this.Controls.Add(this.Noppa1PB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeitaBT);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa2PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HeitaBT;
        private Label label1;
        private PictureBox Noppa1PB;
        private PictureBox Noppa2PB;
    }
}