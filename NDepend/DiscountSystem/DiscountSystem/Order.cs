using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public IList<OrderPosition> Positions { get; set; }
        public IList<IOrderDiscount> Discounts { get; set; }

    }
}
