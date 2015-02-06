using System;

namespace Discount.Abstract
{
    public interface IRangeTimeValue
    {
        DateTime StartDateTime { get; set; }
        DateTime EndDateTime { get; set; }
        double DiscountValue { get; set; }
        string EventName { get; set; }
    }
}