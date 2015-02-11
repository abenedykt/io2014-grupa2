using ShoeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Service
{
    public class OrderCalculator : IOrderCalculator
    {
        private void ApplyDiscountToPosition(IPosition position, IEnumerable<IDiscount> discounts)
        {
            var discountsSum = discounts.Sum(n => n.Calculate(position));
            position.Price -= position.Price * discountsSum;
        }

        public void ApplyDiscounts(IOrder order, IEnumerable<IDiscount> discounts)
        {
            order.Positions.ToList().ForEach(n=>ApplyDiscountToPosition(n, discounts));
        }
    }
}
