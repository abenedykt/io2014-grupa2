using ShoeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Repository
{
    public class StaticDiscountRepository : IDiscountRepository
    {
        public IEnumerable<IDiscount> GetDiscounts()
        {
            return new List<IDiscount>() {
                new AmountDiscount(40,0.1),
                new AmountDiscount(3, 0.05),
                new SumDiscount(250, 0.1)
            };
        }
    }
}
