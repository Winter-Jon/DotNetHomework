using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderProgram;

namespace OrderForm
{
    public partial class Form2 : Form
    {
        public Order order { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.OrderNum = Convert.ToInt32( textBox_OrderNum.Text);
            order.Customer = textBox_Customer.Text;

        }
    }
}
