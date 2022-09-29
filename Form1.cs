using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int OVERWEIGHT = 25;
            const double UNDERWEIGHT = 18.5;
            double weight, height, bmi;

            if (double.TryParse(weightTextBox.Text, out weight))
            {
                if (double.TryParse(heightTextBox.Text, out height))
                {
                    bmi = weight / (height * height) * 703;
                    bmiLabel.Text = "BMI: " + bmi.ToString("n2");

                    if (bmi > OVERWEIGHT)
                    {
                        bmiLabel.Text += "\nStatus: overweight";
                    }
                    else if (bmi < UNDERWEIGHT)
                    {
                        bmiLabel.Text += "\nStatus: underweight";
                    }
                    else
                    {
                        bmiLabel.Text += "\nStatus: optimal";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for height.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for weight.");
            }
        }
    }
}
