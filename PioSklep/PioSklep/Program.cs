using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioSklep
{
    class Program
    {
        static void Main(string[] args)
        {

            Order Zamowienie = new Order();
            Console.WriteLine(Zamowienie.TotalPrcice);
            Console.WriteLine(Zamowienie.TotalQuantity);
            var calc = new DiscountCalc();
            calc.CountDiscount(Zamowienie);
           
            Console.WriteLine(Zamowienie.DiscountValue);
            Console.WriteLine(Zamowienie.TotalDiscounValue);
            Console.ReadKey();
        }
    }
}
