using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderProgram;

namespace OrderForm
{
    public partial class OrderForm : Form
    {
        OrderService orderService = new OrderService();
        

        public OrderForm()
        {
            InitializeComponent();

            OrderDetails o1 = new OrderDetails(1, "a", 10);
            OrderDetails o2 = new OrderDetails(2, "b", 15);
            OrderDetails o3 = new OrderDetails(3, "c", 20);
            List<OrderDetails> orderDetailsList = new List<OrderDetails>();
            List<OrderDetails> orderDetailsList2 = new List<OrderDetails>();

            orderDetailsList.Add(o1);
            orderDetailsList.Add(o2);
            Order order = new Order( 1,"L",orderDetailsList);

            Order order1 = new Order(2,  "J",orderDetailsList2);

            orderService.AddOrder(order);

            order1.AddOrderDetails(o2);
            order1.AddOrderDetails(o1);
            order1.AddOrderDetails(o3);

            orderService.AddOrder(order1);

            bindingSource_Order.DataSource = orderService.OrderList;
            dataGridView1.DataSource = bindingSource_Order;
            Column1_OrderNum.DataPropertyName = "OrderNum";
            dataGridView1.Columns["OrderNum"].Visible = false;
            Column1_Customer.DataPropertyName = "Customer";
            dataGridView1.Columns["Customer"].Visible = false;
            Column1_OrderPrice.DataPropertyName = "OrderPrice";
            dataGridView1.Columns["OrderPrice"].Visible = false;

            bindingSource_OrderDetail.DataSource = bindingSource_Order;
            bindingSource_OrderDetail.DataMember = "OrderDetailsList";
            dataGridView2.DataSource = bindingSource_OrderDetail;
            Column2_GoodName .DataPropertyName = "GoodName";
            dataGridView2.Columns["GoodName"].Visible = false;
            Column2_GoodNum.DataPropertyName = "GoodNum";
            dataGridView2.Columns["GoodNum"].Visible = false;
            Column2_GoodPrice.DataPropertyName = "GoodPrice";
            dataGridView2.Columns["GoodPrice"].Visible = false;
            Column2_GoodTotalPrice.DataPropertyName = "GoodTotalPrice";
            dataGridView2.Columns["GoodTotalPrice"].Visible = false;

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {


        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "订单号":
                    bindingSource_Order.DataSource = orderService.OrderList.Where(o => o.OrderNum == Convert.ToDouble(textBox_search.Text));
                    break;
                case "客户名":
                    bindingSource_Order.DataSource = orderService.OrderList.Where(o => o.Customer == textBox_search.Text);
                    break;
                case "金额大于":
                    bindingSource_Order.DataSource = orderService.OrderList.Where(o => o.OrderPrice > Convert.ToDouble(textBox_search.Text));
                    break;
                case "金额小于":
                    bindingSource_Order.DataSource = orderService.OrderList.Where(o => o.OrderPrice < Convert.ToDouble(textBox_search.Text));
                    break;
                case "金额等于":
                    bindingSource_Order.DataSource = orderService.OrderList.Where(o => o.OrderPrice == Convert.ToDouble(textBox_search.Text));
                    break;
                default:
                    bindingSource_Order.DataSource = orderService;
                    break;
            }
        }
        private void dataGridView2_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentCell.ContextMenuStrip = contextMenuStrip2Cell;
        }

        private void dataGridView1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.ContextMenuStrip = contextMenuStrip1Cell;
        }


    }
}
