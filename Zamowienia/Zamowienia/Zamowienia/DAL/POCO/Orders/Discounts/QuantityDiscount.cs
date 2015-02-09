using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia.BLS.Services.Management;
using Zamowienia.Rabaty;

namespace Zamowienia.Rabaty
{
    public class QuantityDiscount : IDiscount
    {

        public int Priority { get; set; }
        public double CalculateDiscountForOrder(Order order)
        {
            return 0;
        }

        public QuantityDiscount()
        {
            Priority = DiscountManagementService.GetPriorityForDiscount(this);
        }
    }
}
