using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // 

namespace Pi_32_1_Nagoy_N1
{
    public partial class FormMain : Form
    {
        private double[] inputPixels;
        public FormMain()
        {
            InitializeComponent();
            inputPixels = new double[15];
        }

        public void change_button_colour(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White) // white to black
            {
                ((Button)sender).BackColor = Color.Black;
                inputPixels[((Button)sender).TabIndex] = 1d;
            }
            else
            {
                ((Button)sender).BackColor = Color.White; // black to white
                inputPixels[((Button)sender).TabIndex] = 0d;
            }
        }
        private void button_SaveTestSample_Click
    }
}