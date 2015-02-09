using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia.BLS.Services.Ordering
{
    public class DiscountManager : IDiscountManager
    {
        private Order _Order;

        void ApplyDiscountsToOrder(Order order)
        {
            _Order = order;
        }

        private void SortDiscountsByPriority()
        {

        }


        private void ApplyDiscounts()
        {
            SortDiscountsByPriority();
            _Order.CalculateTotalOrderValue();
  
        }

    }
}
