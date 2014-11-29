using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var produkt1 = new Product {Name = "p1", Price = 10, Weight = 5, Height = 1, Width = 1};

            var zamowienie = new Order();

            zamowienie.AddProduct(produkt1);

            zamowienie.Total();
        }
    }
}
