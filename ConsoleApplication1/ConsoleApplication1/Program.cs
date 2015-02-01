﻿using System;
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
            var koszyk = new ShoppingCart()
            {
                Products = new List<Product>
                {
                    new Product() {Name = "10", Price = 1000},
                    new Product() {Name = "20", Price = 1000},
                    new Product() {Name = "30", Price = 1000},
                    new Product() {Name = "40", Price = 1000},
                    new Product() {Name = "50", Price = 1000},
                }
            };

            koszyk.CalculteBasicPrice();

            Console.WriteLine(koszyk.BasicPrice);
            Console.WriteLine();

            var zamowienie = new Order(koszyk);

            Console.WriteLine(zamowienie.Total());


        }
    }
}
