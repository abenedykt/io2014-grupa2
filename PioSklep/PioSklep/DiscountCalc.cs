using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioSklep
{
    class DiscountCalc
    {
        public List<IDiscount> Discounts;
        public List<IDiscount> FillDiscounts()
        {
            return new List<IDiscount>
            {
                new QuantityDiscount(),
                //new PriceDiscount(),
            };
        }

        public double CountDiscount(Order order)
        {
            Discounts = FillDiscounts();
            foreach (var item in Discounts)
            {
                item.recalculate(order);

            }
            return order.TotalPrcice;
        }

    }
}
