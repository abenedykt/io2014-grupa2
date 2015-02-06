using System;
using System.Collections.Generic;
using System.Linq;
using Discount.Abstract;


namespace Discount.Model
{
    public class Order : IOrder
    {
        public Person Person { get; set; }
        public List<IOrderDetail> OrderDetails { get; set; }

        private DateTime _created;
        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        private double _totalQuantity;
        public double TotalQuantity
        {
            get { return _totalQuantity = OrderDetails.Sum(x => x.Quantity); }
            set { _totalQuantity = value; }
        }


        private double _totalPrice;
        public double TotalPrice
        {
            get { return _totalPrice = OrderDetails.Sum(x => x.Price*x.Quantity); }
            set
            {
                _totalPrice = value;

            }
        }

        public double Discount { get; set; }
        private double _discountValue;
        public double DiscountValue
        {
            get { return _discountValue = Discount * TotalPrice; }
            set { _discountValue = value; }
        }
        private double _totalPriceWithDiscount;
        public double TotalPriceWithDiscount
        {
            get { return _totalPriceWithDiscount = TotalPrice - DiscountValue; }
            set { _totalPriceWithDiscount = value; }
        }



    }
}
