using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia.BLS.Services.Management;

namespace Zamowienia.Rabaty
{
    public class ValueDiscount : IDiscount
    {
        public int Priority { get; set; }

        public double CalculateDiscountForOrder(Order order)
        {
            return 0;
        }

        public ValueDiscount()
        {
            Priority = DiscountManagementService.GetPriorityForDiscount(this);
        }
    }
}
