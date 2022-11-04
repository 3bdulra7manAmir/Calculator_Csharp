using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        String Operation = "";
        double result = 0;
        bool isOperated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button_0 = (Button)sender;

            if (isOperated)
            {
                textBox1.Clear();
            }

            if (button_0.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button_0.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button_0.Text;
            }
            isOperated = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button_0 = (Button)sender;
            Operation = button_0.Text;
            result = double.Parse(textBox1.Text);
            isOperated = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
