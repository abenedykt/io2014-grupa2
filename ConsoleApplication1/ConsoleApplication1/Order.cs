using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Order
    {
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public double Total(IDiscount discount)
        {
            return 0;
        }
    }
}
