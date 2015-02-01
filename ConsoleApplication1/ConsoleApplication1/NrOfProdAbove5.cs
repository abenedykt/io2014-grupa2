using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NrOfProdAbove5 : IDiscount
    {
        public double DiscountValue { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public double Discount { get; set; }

        public NrOfProdAbove5(ShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;
            Discount = 50;

            Recalculate();
        }

        public bool Condition()
        {
            if (ShoppingCart.Products.Distinct().Count() >= 5)
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
