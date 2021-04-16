using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProgram
{
    public class Order
    {
        public List<OrderDetails> OrderDetailsList { get;}
        public int OrderNum { get; }
        public string Customer {get; }
        public double OrderPrice
        { 
            get
            {
                int sum = 0;
                foreach (OrderDetails i in OrderDetailsList)
                    sum += i.GoodPrice;
                return sum;
            } 
        }

        public Order() { this.OrderDetailsList = new List<OrderDetails>(); }
        public Order( int orderNum,string customer,List<OrderDetails> orderDetailsList) 
        {
            this.OrderDetailsList = new List<OrderDetails>();
            this.OrderNum = orderNum;
            this.OrderDetailsList = orderDetailsList;
            this.Customer = customer;
        }

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            //judge same
            foreach (OrderDetails i in OrderDetailsList)
                if (orderDetails == i)
                {
                    Console.WriteLine("same");
                    return;
                }

            OrderDetailsList.Add(orderDetails);
        }

        public void DeleteOrderDetails(int goodNo)
        {
            try
            {
                OrderDetailsList.RemoveAt(goodNo);
            }
            catch(ArgumentNullException e)
            {
                throw e;
            }
        }

        public override string ToString()
        {
            string order="Customer:"+Customer+"\n";
            int num = 1;
            foreach (OrderDetails i in OrderDetailsList)
            { 
                order = order + "No:"+num+"     " + i + "\n";
                num++;
            }
            order = order + "OrderPrice:" + OrderPrice;
            return order;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<List<OrderDetails>>.Default.Equals(OrderDetailsList, order.OrderDetailsList) &&
                   Customer == order.Customer &&
                   OrderPrice == order.OrderPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderDetailsList, Customer, OrderPrice);
        }
    }
}
