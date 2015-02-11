using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model
{
    public class AmountDiscount : IDiscount
    {
        protected int MinAmount;
        protected double Discount;

        public AmountDiscount(int minAmount, double discount)
        {
            MinAmount = minAmount;
            Discount = discount;
        }

        public double Calculate(IPosition position)
        {
            return (position.Amount > MinAmount) ? Discount : 0.0;
        }
    }
}
