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
    public partial class Form3 : Form
    {
        public OrderDetails orderDetails { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetails = new OrderDetails();
            orderDetails.GoodName = textBox_GoodName.Text;
            orderDetails.GoodNum = Convert.ToInt32(text_GoodNo.Text);
            orderDetails.GoodPrice = Convert.ToInt32(textBox_GoodPrice.Text);

        }
    }
}
