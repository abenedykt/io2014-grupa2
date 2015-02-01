using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public class PercentageProductDiscount : Discount, IProductDiscount
    {
        public Product Product { get; set; }
        public double Value { get; set; }

        public PercentageProductDiscount(double value, Product product)
        {
            Value = value;
            Product = product; 
        }

        public void ApplyDiscount(OrderPosition orderPosition)
        {
            orderPosition.DiscountsSum += (orderPosition.Product.Price * orderPosition.Quantity) * Value;
        }
    }
}
