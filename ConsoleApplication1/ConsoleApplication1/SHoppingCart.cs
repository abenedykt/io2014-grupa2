using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ShoppingCart
    {
        public List<Product> Products { get; set; }
        public double BasicPrice { get; set; }

        public ShoppingCart()
        {
            Products = new List<Product>();
            BasicPrice = 0;
        }

        public void CalculteBasicPrice()
        {
            Products.ForEach(p => BasicPrice += p.Price);
        }
    }
}
