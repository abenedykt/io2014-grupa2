using ShoeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Service
{
    public interface IOrderCalculator
    {
        void ApplyDiscounts(IOrder order, IEnumerable<IDiscount> discounts);
    }
}
