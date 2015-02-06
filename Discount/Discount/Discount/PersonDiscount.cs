using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Abstract;
using Discount.Model;

namespace Discount.Discount
{
    public class PersonDiscount:IDiscount
    {
        public void Recalculate(IOrder order)
        {
            double result = SearchWariant(order);
            order.Discount += result;
            if (result > 0)
                Console.WriteLine("Przyznano " + result + "% znizki zamowienie z potwierdzonego konta");
        }

        public double SearchWariant(IOrder order)
        {
            if (order.Person == null)
                return 0;
            return 0.05;
        }
    }
}
