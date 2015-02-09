using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia;

namespace Zamowienia
{
    public interface IDiscount
    {

        int Priority { get; set; }

        double CalculateDiscountForOrder(Order order);

    }
}
