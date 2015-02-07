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
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentException("Invalid discount value!");
            }

            DiscountPercentage = discountPercentage;
        }

        public override void ApplyDiscount()
        {
            Order.Items.ToList().ForEach(n =>
            {
                n.Price = n.Price * DiscountPercentage;
                n.Discounts.Add(this);
            });
        }
    }
}
