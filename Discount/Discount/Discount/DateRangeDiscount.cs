using System;
using Discount.Abstract;
using Discount.Discount.DateDiscount;

namespace Discount.Discount
{
    public class DateRangeDiscount:IDiscount
    {
        private readonly RangeDateAgregate _rangeDateAgregate = new RangeDateAgregate();
        public void Recalculate(IOrder order)
        {
            double result = SearchWariant(order);
            order.Discount += result;         
        }

        private double SearchWariant(IOrder order)
        {
            double discountSize = 0;
            foreach (IRangeTimeValue date in _rangeDateAgregate.AllVariants)
            {
                if (order.Created >= date.StartDateTime && order.Created <= date.EndDateTime)
                {
                    discountSize += date.DiscountValue;
                    Console.WriteLine("Przyznano " + date.DiscountValue + "% za znizke " + date.EventName);
                }
            }
            return discountSize;
        }
    }
}
