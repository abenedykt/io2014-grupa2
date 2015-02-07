using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public class OrderValueDiscount : Discount
    {
        public decimal DiscountValue { get; set; }

        public OrderValueDiscount(string name, decimal value)
            : base(name)
        {
            DiscountValue = value;
        }

        public override void ApplyDiscount()
        {
            Order.AddDiscount(this);
        }
    }
}
