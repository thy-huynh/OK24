namespace Sekuntikello
{
    partial class SekuntikelloForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.AikaLB.Location = new System.Drawing.Point(59, 35);
            this.AikaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(394, 86);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00.000";
            this.AikaLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(59, 124);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(122, 46);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Käynnistä";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(309, 124);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(122, 46);
            this.ResetBT.TabIndex = 2;
            this.ResetBT.Text = "Tyhjennä";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(184, 124);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(122, 46);
            this.StopBT.TabIndex = 3;
            this.StopBT.Text = "Lopeta";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SekuntikelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 225);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.AikaLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SekuntikelloForm";
            this.Text = "Sekuntikello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AikaLB;
        private Button StartBT;
        private Button ResetBT;
        private Button StopBT;
        private System.Windows.Forms.Timer timer1;
    }
}