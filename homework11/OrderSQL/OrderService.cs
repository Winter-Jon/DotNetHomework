using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using OrderSQL;

namespace OrderProgram
{
    public class OrderService
    {

        public OrderService() { }
        public void AddOrder(OrderSQL.Order order)
        {
            using(var db=new OrderDbContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }


        public void DeleteOrder(int orderID)
        {
            using (var db = new OrderDbContext())
            {
                var order = db.Orders.Include("OrderDetails").FirstOrDefault(p => p.OrderId == orderID);
                if(order!=null)
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
        }

        public void OrderSort(string i)
        {

        }



        /*
        public void Import()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("OrderList.xml", FileMode.Create))
                xml.Serialize(fs, OrderList);

        }

        public void Export()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("OrderList.xml", FileMode.Open))
            {
                OrderList = (List<Order>)xml.Deserialize(fs);
            }

        }
        */



    }
}
