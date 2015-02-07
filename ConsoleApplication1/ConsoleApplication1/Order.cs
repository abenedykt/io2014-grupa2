using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Order
    {
        public ShoppingCart ShoppingCart { get; set; }
        public List<IDiscount> Discounts { get; set; }

        public Order(ShoppingCart shoppingCart)
        {
            ShoppingCart = shoppingCart;
            Discounts = new List<IDiscount>();

            Discounts.Add(new Above1000(ShoppingCart));
            Discounts.Add(new NrOfProdAbove5(ShoppingCart));
            Discounts.Add(new buy3oneFree(ShoppingCart));
        }

        public double Total()
        {
            double total = ShoppingCart.BasicPrice;

            foreach (var discount in Discounts)
            {
                if (discount.Condition() == true)
                {
                    total -= discount.DiscountValue;
                }
            }

            return total;
        }
    }
}
