using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Abstract;
using Discount.Logic;
using Discount.Model;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new Order
            {
                OrderDetails = new List<IOrderDetail>
                {
                    new OrderDetail {Price = 1000, ProductName = "Czapka", Quantity = 5},
                    new OrderDetail {Price = 1000, ProductName = "Koszulka Biała", Quantity = 4},
                    new OrderDetail {Price = 100, ProductName = "Skarpetki", Quantity =3 },
                    new OrderDetail {Price = 200, ProductName = "Buty", Quantity = 2}
                },
                Person = new Person { PersonId =1},
                Created = new DateTime(DateTime.Now.Year,12,6)

            };
            Console.WriteLine("Moje zamówienie");
            order.OrderDetails.ForEach(x => Console.WriteLine("Cena " +x.Price + "  Nazwa produktu " + x.ProductName + " Ilość " + x.Quantity));
            Console.WriteLine();
            Console.WriteLine("Data utworzenia " +order.Created);
            Console.WriteLine("Zamówienie na kwotę " +order.TotalPrice);
            Console.WriteLine("Ilość towaru " + order.TotalQuantity);
            Console.WriteLine();
            var calc = new DiscountCalc();
            calc.CalculateDiscount(order);
            Console.WriteLine("Wartość znizki w % "+order.Discount);
            Console.WriteLine("Wartość znizki :" + order.DiscountValue);
            Console.WriteLine("Wartość zamówienia po znizce :" + order.TotalPriceWithDiscount);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
