using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Abstract;
using Discount.Model;

namespace Discount.Discount.DateDiscount
{
    public class RangeDateAgregate
    {
        public IEnumerable<IRangeTimeValue> AllVariants { get; set; }

        public RangeDateAgregate()
        {
            AllVariants = FillTDateRange();
        }

        public IEnumerable<IRangeTimeValue> FillTDateRange()
        {
            return new List<IRangeTimeValue>
            {
                new RangeTimeValue{DiscountValue = 0.05,EventName = "Akcja lato",StartDateTime = new DateTime(DateTime.Now.Year,6,20),EndDateTime = new DateTime(DateTime.Now.Year,9,21)},
                new RangeTimeValue{DiscountValue = 0.08,EventName = "Wyprzedaż",StartDateTime = new DateTime(DateTime.Now.Year,1,1),EndDateTime = new DateTime(DateTime.Now.Year,3,28)},
                new RangeTimeValue{DiscountValue= 0.05,EventName = "Akcja zima",StartDateTime = new DateTime(DateTime.Now.Year,1,1),EndDateTime = new DateTime(DateTime.Now.Year,3,21)},
                new RangeTimeValue{DiscountValue= 0.05,EventName = "Akcja zima",StartDateTime = new DateTime(DateTime.Now.Year,11,21),EndDateTime = new DateTime(DateTime.Now.Year,12,31)},
            };
                
        }
    }
}
