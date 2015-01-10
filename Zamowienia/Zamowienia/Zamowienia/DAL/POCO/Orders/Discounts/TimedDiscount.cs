using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia.Rabaty
{
    public class TimedDiscount : IDiscount
    {

        public double CalculateDiscountForOrder(Order order)
        {
            return 0;
        }

    }
}
