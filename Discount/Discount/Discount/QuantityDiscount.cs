using System;
using System.Collections.Generic;
using Discount.Abstract;

namespace Discount.Discount
{
    public class QuantityDiscount:IDiscount
    {
        private readonly Dictionary<double,double> _disclountWariants = new Dictionary<double,double>
        {
            //zawsze w kolejnosci rosnacej 
            {5,0.01},
            {10,0.02},
            {15,0.04},
        }; 
        public void Recalculate(IOrder order)
        {
            double result = SearchWariant(order);
            order.Discount += result;
            if (result > 0)
                Console.WriteLine("Przyznano " + result + "% znizki za ilość towaru");
        }

        private double SearchWariant(IOrder order)
        {
            double discountSize = 0;
            foreach (KeyValuePair<double,double> discountwariant in _disclountWariants)
            {
                if(discountwariant.Key <= order.TotalQuantity)
                    discountSize = discountwariant.Value;
            }
            return discountSize;
        }
    }
}
