using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Abstract;

namespace Discount.Discount
{
    public class PriceDiscount:IDiscount
    {
        private readonly Dictionary<double, double> _disclountWariants = new Dictionary<double, double>
        {
            //zawsze w kolejnosci rosnacej 
            {250,0.01},
            {500,0.02},
            {1000,0.03},
            {5000,0.05}
        };
        public void Recalculate(IOrder order)
        {
            double result = SearchWariant(order);
            order.Discount += result;
            if (result > 0)
                Console.WriteLine("Przyznano " + result + "% znizki za wartosc zamowienia");
            if (result >= 1000)
            {

                Console.WriteLine("Przyznano gratisową dostawę ");
            }
                
        }

        private double SearchWariant(IOrder order)
        {
            double discountSize = 0;
            foreach (KeyValuePair<double, double> discountwariant in _disclountWariants)
            {
                if (discountwariant.Key <= order.TotalPrice)
                    discountSize = discountwariant.Value;
            }
            return discountSize;
        }
    }
}
