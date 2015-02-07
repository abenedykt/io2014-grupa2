using System.Collections.Generic;

namespace DiscountSystem
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public IList<Discount> Discounts { get; private set; }

        public Item()
        {
            Discounts = new List<Discount>();
        }
    }
}
