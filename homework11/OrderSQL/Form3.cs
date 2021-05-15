using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderSQL;

namespace OrderForm
{
    public partial class Form3 : Form
    {
        public OrderDetail orderDetail { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetail = new OrderDetail();
            orderDetail.GoodName = textBox_GoodName.Text;
            orderDetail.GoodNum = Convert.ToInt32(text_GoodNo.Text);
            orderDetail.GoodPrice = Convert.ToInt32(textBox_GoodPrice.Text);

        }
    }
}
