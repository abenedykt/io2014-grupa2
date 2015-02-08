using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioSklep
{
    class AllDiscount
    {
    }

    public class QuantityDiscount : IDiscount
    {

        public void recalculate (Order order)
        {
            if (order.TotalQuantity > 2)
            {
                order.DiscountValue +=0.05;

             
            }
          
        }
    }
    public class PriceDiscount : IDiscount
    {
        public void recalculate(Order order)
        {
            if (order.TotalPrcice > 500)
            {
                order.DiscountValue += 0.02;
               
            }
        }
    }


}

