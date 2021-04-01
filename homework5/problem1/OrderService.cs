using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem1
{
    class OrderService
    {
        readonly List<Order> OrderList;

        public void AddOrderDetails(Order order)
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

        public void DeleteOrderDetails(int orderNum)
        {
            try
            {
                OrderList.RemoveAt(orderNum-1);
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
        }

        public void OrderShow(int orderNum)
        {
            string str=OrderList[orderNum - 1].ToString();
            Console.WriteLine(str);
        }

        public void OrderSort(string i)
        {
            switch(i)
            {
                case "1":
                    {
                        OrderList.Sort((p1, p2) =>  p1.OrderPrice - p2.OrderPrice);
                        break;
                    }
                case "2":
                    {
                        OrderList.Sort((p1, p2) => p1.Customer.CompareTo(p2.Customer));
                        break;
                    }
                case "3":
                    {
                        OrderList.Sort((p1, p2) => p1.OrderDetailsNum - p2.OrderDetailsNum);
                        break;
                    }
                default:break;
            }

        }

        public List<Order> OrderSearch(string i)
        {
            List<Order> OrderResult=null;

            switch (i)
            {
                case "1":
                    {
                        OrderResult=OrderPriceSearch();
                        break;
                    }
                case "2":
                    {
                        OrderResult = OrderCustomerSearch();
                        break;
                    }
                case "3":
                    {
                        OrderResult = OrderDetailsNumSearch();
                        break;
                    }
                default: break;
            }

            OrderResult.Sort((p1, p2) => p1.OrderPrice - p2.OrderPrice);
            return OrderResult;
        }
        
        private List<Order> OrderPriceSearch()
        {
            string i=Console.ReadLine();
            int price = Convert.ToInt32(Console.ReadLine());
            List<Order> o=null;

            switch (i)
            {
                case "1":
                    {
                        o= (List<Order>)(from n in OrderList where n.OrderPrice > price select n);
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

        private List<Order> OrderDetailsNumSearch()
        {
            string i = Console.ReadLine();
            int detailsNum = Convert.ToInt32(Console.ReadLine());
            List<Order> o = null;
            switch (i)
            {
                case "1":
                    {
                        o = (List<Order>)(from n in OrderList where n.OrderDetailsNum > detailsNum select n);
                        break;
                    }
                case "2":
                    {
                        o = (List<Order>)(from n in OrderList where n.OrderDetailsNum < detailsNum select n);
                        break;
                    }
                case "3":
                    {
                        o = (List<Order>)(from n in OrderList where n.OrderDetailsNum == detailsNum select n);
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

    }
}
