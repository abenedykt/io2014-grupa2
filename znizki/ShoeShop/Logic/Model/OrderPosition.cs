using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Model
{
    public class OrderPosition : IPosition
    {
        public IItem Item { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public OrderPosition(IItem item, int amount)
        {
            Item = item;
            Amount = amount;
            Price = Amount * item.Price;
        }
    }
}
