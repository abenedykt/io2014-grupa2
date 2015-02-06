using System;
using Discount.Abstract;

namespace Discount.Model
{
    public class RangeTimeValue:IRangeTimeValue
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double DiscountValue { get; set; }
        public string EventName { get; set; }
    }
}
