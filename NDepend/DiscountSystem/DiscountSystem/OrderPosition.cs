using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public class OrderPosition
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public IList<IProductDiscount> Discounts { get; set; }
        public Order Order { get; set; }
        public double DiscountsSum { get; set; }

    }
}
