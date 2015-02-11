using ShoeShop.Model;
using ShoeShop.Repository;
using ShoeShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoe1 = new Shoe() { Name = "Szpilki", Price = 33};
            var shoe2 = new Shoe() { Name = "Glany", Price = 21 };
            var shoe3 = new Shoe() { Name = "Gumowce", Price = 88 };

            IOrder order = new Order();
            order.Positions = new List<IPosition>()
            {
                new OrderPosition(shoe1, 11),
                new OrderPosition(shoe2, 2),
                new OrderPosition(shoe3, 55)
            };

            Console.WriteLine("Przed znizkami: ");
            order.Positions.ToList().ForEach(n => Console.WriteLine("Nazwa: {0}\t Cena: {1}", n.Item.Name, n.Price));

            IOrderCalculator calculatorService = new OrderCalculator();
            IDiscountRepository discountRepository = new StaticDiscountRepository();
            calculatorService.ApplyDiscounts(order, discountRepository.GetDiscounts());

            Console.WriteLine("Po znizkach: ");
            order.Positions.ToList().ForEach(n => Console.WriteLine("Nazwa: {0}\t Cena: {1}", n.Item.Name, n.Price));

        }
    }
}
