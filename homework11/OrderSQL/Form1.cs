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
using OrderSQL;

namespace OrderForm
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        

        public Form1()
        {
            InitializeComponent();
            using (var db = new OrderDbContext())
            {

                var orders=db.Orders.OrderBy(o=>o.OrderId).ToList();
                var orderDetails = db.OrderDetails.OrderBy(od=>od.GoodId).ToList();

                bindingSource_Order.DataSource = orders;
                dataGridView1.DataSource = bindingSource_Order;
                Column1_OrderNum.DataPropertyName = "OrderId";
                dataGridView1.Columns["OrderId"].Visible = false;
                Column1_Customer.DataPropertyName = "Customer";
                dataGridView1.Columns["Customer"].Visible = false;
                Column1_OrderPrice.DataPropertyName = "OrderPrice";
                dataGridView1.Columns["OrderPrice"].Visible = false;

                bindingSource_OrderDetail.DataSource = bindingSource_Order;
                bindingSource_OrderDetail.DataMember = "OrderDetails";
                dataGridView2.DataSource = bindingSource_OrderDetail;
                Column2_GoodId.DataPropertyName = "GoodId";
                dataGridView2.Columns["GoodId"].Visible = false;
                Column2_GoodName .DataPropertyName = "GoodName";
                dataGridView2.Columns["GoodName"].Visible = false;
                Column2_GoodNum.DataPropertyName = "GoodNum";
                dataGridView2.Columns["GoodNum"].Visible = false;
                Column2_GoodPrice.DataPropertyName = "GoodPrice";
                dataGridView2.Columns["GoodPrice"].Visible = false;
                dataGridView2.Columns["order"].Visible = false;
                dataGridView2.Columns["OrderId"].Visible = false;
                Column2_GoodTotalPrice.DataPropertyName = "GoodTotalPrice";
                dataGridView2.Columns["GoodTotalPrice"].Visible = false;


            }

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {


        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "订单号":
                    int a=Convert.ToInt32(textBox_search.Text);
                    using (var db=new OrderDbContext())
                    {
                        var order = db.Orders.SingleOrDefault(o => o.OrderId == a);
                        bindingSource_Order.DataSource = order;
                        bindingSource_OrderDetail.DataSource = bindingSource_Order;
                        bindingSource_OrderDetail.DataMember = "OrderDetails";
                    }
                    //bindingSource_Order.DataSource = orderService.OrderList.Where(o => o.OrderId == Convert.ToDouble(textBox_search.Text));
                    break;
                case "客户名":
                    using (var db = new OrderDbContext())
                    {
                        var order = db.Orders.SingleOrDefault(o => o.Customer == comboBox1.Text);
                        bindingSource_Order.DataSource = order;
                    }
                    break;
                case "金额大于":
                    double b1 = Convert.ToDouble(textBox_search.Text);
                    using (var db = new OrderDbContext())
                    {
                        var order = db.Orders.SingleOrDefault(o => o.OrderPrice == b1);
                        bindingSource_Order.DataSource = order;
                    }
                    break;
                case "金额小于":
                    double b2 = Convert.ToDouble(textBox_search.Text);
                    using (var db = new OrderDbContext())
                    {
                        var order = db.Orders.SingleOrDefault(o => o.OrderPrice == b2);
                        bindingSource_Order.DataSource = order;
                    }
                    break;
                case "金额等于":
                    double b3 = Convert.ToDouble(textBox_search.Text);
                    using (var db = new OrderDbContext())
                    {
                        var order = db.Orders.SingleOrDefault(o => o.OrderPrice == b3);
                        bindingSource_Order.DataSource = order;
                    }
                    break;
                default:
                    using (var db = new OrderDbContext())
                    {
                        var order = db.Orders.OrderBy(o=>o.OrderId).ToList();
                        var orderdetail = db.OrderDetails.OrderBy(o => o.GoodId).ToList();
                        bindingSource_Order.DataSource = order;
                        bindingSource_OrderDetail.DataSource = bindingSource_Order;
                        bindingSource_OrderDetail.DataMember = "OrderDetails";
                    }

                    //bindingSource_Order.DataSource = orderService.OrderList;
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

        private void toolStripMenuItemOrderDetailAdd_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

            form3.Close();
            bindingSource_Order.ResetBindings(true);
        }
        
        private void toolStripMenuItemOrderAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            orderService.AddOrder(form2.order);
            form2.Close();
            bindingSource_Order.ResetBindings(true);

        }

        private void toolStripMenuItem2CellChange_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem2DelRow_Click(object sender, EventArgs e)
        {
            //orderService.OrderList[dataGridView1.CurrentCellAddress.Y].DeleteOrderDetails(dataGridView2.CurrentCellAddress.Y );
            bindingSource_Order.ResetBindings(true);
        }

        private void toolStripMenuItem1DelRow_Click(object sender, EventArgs e)
        {
            //orderService.DeleteOrder(dataGridView1.CurrentCellAddress.Y+1);
            bindingSource_Order.ResetBindings(true);
        }

        private void toolStripMenuItem1CellChange_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
