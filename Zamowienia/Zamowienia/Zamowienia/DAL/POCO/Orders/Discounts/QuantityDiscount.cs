using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia.Rabaty;

namespace Zamowienia.Rabaty
{
    public class QuantityDiscount : IDiscount
    {
        public double CalculateDiscountForOrder(Order order)
        {
            return 0;
        }
    }
}
