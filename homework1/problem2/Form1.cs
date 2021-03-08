using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelOperator.Text = "+";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            labelOperator.Text = "-";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            labelOperator.Text = "x";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            labelOperator.Text = "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            char c = Convert.ToChar(labelOperator.Text);
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double s = 0;
            if (c == '+')
            {
                s = a + b;
            }
            else if (c == '-')
            {
                s = a - b;
            }
            else if (c == '*')
            {
                s = a * b;
            }
            else if (c == '/')
            {
                s = a / b;
            }
            else
            {
                MessageBox.Show("请输入操作符");
                return;
            }
            if ((int)s == s)
            {
                labelResult.Text = Convert.ToDouble(s).ToString("0");
            }
            else 
            {
                labelResult.Text = Convert.ToDouble(s).ToString("0.000000");
            }
            return;
        }
    }
}
