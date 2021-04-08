using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using System.IO;
using problem1;

namespace OrderServiceTest
{
    [TestClass]
    public class OrderServiceUnitTest
    {
        OrderService orderService = new OrderService();

        public void Initialize()
        {
            OrderDetails orderDetail1 = new OrderDetails(2,"1",20) ;
            OrderDetails orderDetail2 = new OrderDetails(4, "2", 10); 
            OrderDetails orderDetail3 = new OrderDetails(1, "3", 12);

            List<OrderDetails> orderDetailsList =new List<OrderDetails>();
            orderDetailsList.Add(orderDetail1);
            orderDetailsList.Add(orderDetail2);
            orderDetailsList.Add(orderDetail3);

            Order order1 = new Order(orderDetailsList,"J");

            OrderDetails orderDetail4 = new OrderDetails(6, "4", 52);
            OrderDetails orderDetail5 = new OrderDetails(3, "5", 13);
            OrderDetails orderDetail6 = new OrderDetails(8, "6", 34);

            List<OrderDetails> orderDetailsList2 = new List<OrderDetails>();
            orderDetailsList2.Add(orderDetail1);
            orderDetailsList2.Add(orderDetail2);
            orderDetailsList2.Add(orderDetail3);

            Order order2 = new Order(orderDetailsList2, "L");

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
        }

        [TestMethod()]
        public void ExportTest()
        {
            Initialize();
            orderService.Export();
            Assert.IsTrue(File.Exists("OrderList.xml"));

        }

        [TestMethod()]
        public void ImportTest()
        {
            Initialize();
            orderService.Import();
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Initialize();
        }


    }
}
