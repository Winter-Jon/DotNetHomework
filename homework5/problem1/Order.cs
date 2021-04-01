using System;
using System.Collections.Generic;
using System.Text;

namespace problem1
{
    class Order
    {
        readonly List<OrderDetails> orderDetailsList;
        public int OrderDetailsNum { get => orderDetailsList.Count; }
        public string Customer { set; get; }
        public int OrderPrice
        { 
            get
            {
                int sum = 0;
                foreach (OrderDetails i in orderDetailsList)
                    sum += i.GoodPrice;
                return sum;
            } 
        }

        Order() { }
        Order(List<OrderDetails> orderDetailsList,string customer) 
        { 
            this.orderDetailsList = orderDetailsList;
            this.Customer = customer;
        }

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            //judge same
            foreach (OrderDetails i in orderDetailsList)
                if (orderDetails == i)
                {
                    Console.WriteLine("same");
                    return;
                }

            orderDetailsList.Add(orderDetails);
        }

        public void DeleteOrderDetails(int goodNo)
        {
            try
            {
                orderDetailsList.RemoveAt(goodNo);
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
            foreach (OrderDetails i in orderDetailsList)
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
                   EqualityComparer<List<OrderDetails>>.Default.Equals(orderDetailsList, order.orderDetailsList) &&
                   Customer == order.Customer &&
                   OrderPrice == order.OrderPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(orderDetailsList, Customer, OrderPrice);
        }
    }
}
