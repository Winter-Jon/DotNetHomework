using System;
using System.Collections.Generic;
using System.Text;

namespace problem1
{
    public class OrderDetails
    {
        public int GoodNum { get; set; }
        public string GoodName { get; set; }
        public int GoodPrice { get; set; }

        OrderDetails() { }
        public OrderDetails(int goodNum, string goodName, int goodPrice)
        {
            this.GoodNum = goodNum;
            this.GoodName = goodName;
            this.GoodPrice = goodPrice;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   GoodNum == details.GoodNum &&
                   GoodName == details.GoodName &&
                   GoodPrice == details.GoodPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GoodNum, GoodName,  GoodPrice);
        }

        public override string ToString()
        {
            return "GoodNum:"+GoodNum+"   "+"GoodName:"+GoodName+"   "+"GoodPrice:"+GoodPrice;
        }
    }
}
