using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioSklep
{
   public class Order
    {

        public List<OrderDetail> OrderDetails;//order ma liste publiczna orderdetail
        public Order()
        {
            OrderDetails = new List<OrderDetail>
            {
                new OrderDetail{ Name="Rower", Price=250, Quantity = 2},
                new OrderDetail{ Name="Auto", Price=50, Quantity = 1},
                new OrderDetail{ Name="Pilka", Price=100, Quantity = 12},
                new OrderDetail{ Name="Pompka", Price=200, Quantity = 3},
                new OrderDetail{ Name="Rolki", Price=50, Quantity = 1},
               
            };
        }
        public DateTime Created { get; set; }
        public double DiscountValue { get; set; }
        private double _totalQuantity;
        private double _totalDiscountValue;
        public double TotalDiscounValue
        {
            get { return _totalDiscountValue = TotalPrcice-  DiscountValue * TotalPrcice; }
            set { _totalDiscountValue = value; }
        }
        public double TotalQuantity
        {
            get { return _totalQuantity=OrderDetails.Sum(x=>x.Quantity) ;}
            set { _totalQuantity = value; } 
        }

        private double _totalPrice;
        public double TotalPrcice {
            get { return _totalPrice= OrderDetails.Sum(x => x.TotalValue ) ; }
            set { _totalPrice = value; } 
        }
    }
}
