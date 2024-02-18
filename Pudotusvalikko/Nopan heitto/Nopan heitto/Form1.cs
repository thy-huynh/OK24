﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nopan_heitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NoppaBT.FlatAppearance.BorderColor = Color.DodgerBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NoppaBT_Click(object sender, EventArgs e)
        {

            piirraNoppa(Noppa01PB);
            piirraNoppa(Noppa02PB);
        }

        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random randomi = new Random();
            int noppa = randomi.Next(1, 7); 

            switch(noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01; 
                    break;

                    case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;

                case 3:
                    NoppaBox.Image = Properties.Resources.dice03; 
                    break;  

                    case 4:
                    NoppaBox.Image = Properties.Resources.dice04; 
                    break;

                case 5:
                    NoppaBox.Image = Properties.Resources.dice05; 
                    break;

                    case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;



            }
        }

       
    }   
        

}
