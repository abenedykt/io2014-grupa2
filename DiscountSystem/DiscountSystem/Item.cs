using System.Collections.Generic;

namespace DiscountSystem
{
    public class Item
    {
        private IList<Discount> _discounts;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Item()
        {
            _discounts = new List<Discount>();
        }
    }
}
