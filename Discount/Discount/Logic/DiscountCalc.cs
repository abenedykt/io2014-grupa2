using System;
using System.Collections.Generic;
using Discount.Abstract;
using Discount.Discount;

namespace Discount.Logic
{
    public class DiscountCalc
    {
        public double CalculateDiscount(IOrder order)
        {
            var discounts = FillDiscountForOrder();
            foreach (var discount in discounts)
            {
                discount.Recalculate(order);
            }
            return order.Discount;
        }

        public IEnumerable<IDiscount> FillDiscountForOrder()
        {
            return new List<IDiscount>
            {
                new QuantityDiscount(),
                new PersonDiscount(),
                new DateRangeDiscount(),
                new PriceDiscount()
            
            };
        }
    }
}
