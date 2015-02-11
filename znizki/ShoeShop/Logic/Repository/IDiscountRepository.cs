using ShoeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Repository
{
    public interface IDiscountRepository
    {
        IEnumerable<IDiscount> GetDiscounts();
    }
}
