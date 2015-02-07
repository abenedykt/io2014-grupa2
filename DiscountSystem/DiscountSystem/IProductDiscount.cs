using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public interface IProductDiscount : IDiscount
    {
        Product Product { get; set; }

        void ApplyDiscount(OrderPosition orderPosition);
    }
}
