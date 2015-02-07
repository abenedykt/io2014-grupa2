using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class buy3oneFree : IDiscount
    {
        public double DiscountValue { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public double Discount { get; set; }

        public buy3oneFree(ShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;

            Discount = shoppingCart.Products.Min(x => x.Price);

            Recalculate();
        }

        public bool Condition()
        {
            if (ShoppingCart.Products.Distinct().Count() >= 3)
            {
                return true;
            }
            return false;
        }

        public void Recalculate()
        {
            DiscountValue = Discount;
        }
    }
}
