using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace OrderProgram
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; }

        public OrderService() { OrderList = new List<Order>(); }
        public void AddOrder(Order order)
        {
            //judge same
            foreach (Order i in OrderList)
                if (order == i)
                {
                    Console.WriteLine("same");
                    return;
                }

            OrderList.Add(order);
        }

        public void DeleteOrder(int orderNum)
        {
            try
            {
                OrderList.RemoveAt(orderNum - 1);
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
        }

        public void OrderShow(int orderNum)
        {
            string str = OrderList[orderNum - 1].ToString();
            Console.WriteLine(str);
        }

        public void OrderSort(string i)
        {
            switch (i)
            {
                case "1":
                    {
                        OrderList.Sort((p1, p2) => (int)(p1.OrderPrice - p2.OrderPrice));
                        break;
                    }
                case "2":
                    {
                        OrderList.Sort((p1, p2) => p1.Customer.CompareTo(p2.Customer));
                        break;
                    }

                default: break;
            }

        }

        public List<Order> OrderSearch(string i)
        {
            List<Order> OrderResult = null;

            switch (i)
            {
                case "1":
                    {
                        OrderResult = OrderPriceSearch();
                        break;
                    }
                case "2":
                    {
                        OrderResult = OrderCustomerSearch();
                        break;
                    }
                default: break;
            }

            OrderResult.Sort((p1, p2) => (int)(p1.OrderPrice - p2.OrderPrice));
            return OrderResult;
        }

        private List<Order> OrderPriceSearch()
        {
            string i = Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            List<Order> o = null;

            switch (i)
            {
                case "1":
                    {
                        o = (List<Order>)(from n in OrderList where n.OrderPrice > price select n);
                        break;
                    }
                case "2":
                    {
                        o = (List<Order>)(from n in OrderList where n.OrderPrice < price select n);
                        break;
                    }
                case "3":
                    {
                        o = (List<Order>)(from n in OrderList where n.OrderPrice == price select n);
                        break;
                    }
                default: break;
            }
            return o;
        }


        private List<Order> OrderCustomerSearch()
        {
            string customer = Console.ReadLine();
            List<Order> o = null;
            o = (List<Order>)(from n in OrderList where n.Customer == customer select n);
            return o;
        }

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
    }
}
