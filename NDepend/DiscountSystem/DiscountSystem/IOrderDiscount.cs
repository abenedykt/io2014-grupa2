using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public interface IOrderDiscount : IDiscount
    {
        Order Order { get; set; }
    }
}
