using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        double var1, var2;
        string sign;
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1 .Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text =textBox1 .Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "" )
            textBox1.Text = ".";
        else if (textBox1.Text == var1.ToString ())
            textBox1.Text = ".";
             else if (textBox1.Text == var2.ToString ())
            textBox1.Text = ".";
        else
             {
                 if (textBox1.Text.Contains("."))
                    
                     a=b;
                 else
                     textBox1.Text = textBox1.Text + ".";
             }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sign = button12.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var2 = Convert.ToDouble(textBox1.Text);
            if (sign  == "+")
            {
                textBox1.Text = (var1 + var2).ToString();
            }
            else if (sign == "-")
            {
                textBox1.Text = (var1 - var2).ToString();
            }
            else if (sign == "/")
            {
                textBox1.Text = (var1 / var2).ToString();
            }
            else if (sign == "*")
            {
                textBox1.Text = (var1 * var2).ToString();
            }
            else
            {
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sign = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sign = button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sign = button15.Text;
        }
    }
}
