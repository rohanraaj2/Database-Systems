using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Warm_Up
{
    public partial class CtoFConverter : Form
    {
        public CtoFConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Result: ";

        }

        private void textTempInC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            String textC = textTempInC.Text;
            double tempC = 0;
            if (Double.TryParse(textC, out tempC))
            {
                double tempF = tempC * 9.0 / 5.0 + 32;
                double tempFRounded = Math.Round(tempF, 2);
                resultLabel.Text = "Result: " + tempC + " in C = " + tempFRounded + " in F";
            }
            else
                resultLabel.Text = "You have entered an invalid value " + textC;
            textTempInC.Text = "";
        }
    }
}
