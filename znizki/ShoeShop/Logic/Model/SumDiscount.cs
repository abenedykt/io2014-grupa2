using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model
{
    public class SumDiscount : IDiscount
    {
        protected double MinSum;
        protected double Discount;
        
        public SumDiscount (double minSum, double discount)
	    {
            MinSum = minSum;
            Discount = discount;
	    }

        public double Calculate(IPosition position)
        {
            return ((position.Amount * position.Price) > MinSum) ? Discount : 0.0;
        }
    }
}
