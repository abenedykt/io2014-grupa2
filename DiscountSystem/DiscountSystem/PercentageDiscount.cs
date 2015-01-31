using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public class PercentageDiscount : Discount
    {
        public decimal DiscountPercentage { get; set; }

        public PercentageDiscount(string name, decimal discountPercentage)
            :base(name)
        {
            DiscountPercentage = discountPercentage;
        }

        public override Order ApplyDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
