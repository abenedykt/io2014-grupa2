using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Above1000 : IDiscount
    {
        public double DiscountValue { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public double DiscountPercent { get; set; }

        public Above1000(ShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;
            DiscountPercent = 0.1;

            Recalculate();
        }

        public bool Condition()
        {
            if (ShoppingCart.BasicPrice >= 1000)
            {
                return true;
            }
            return false;
        }

        public void Recalculate()
        {
            DiscountValue = ShoppingCart.BasicPrice*DiscountPercent;
        }
    }
}
