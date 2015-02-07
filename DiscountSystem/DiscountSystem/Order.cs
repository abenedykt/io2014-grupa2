using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;

namespace DiscountSystem
{
    public class Order
    {
        public bool CanAddDiscounts { get; set; }

        public IList<Discount> Discounts { get; private set; }
        public IList<Item> Items { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Order()
        {
            CanAddDiscounts = true;

            Discounts = new List<Discount>();
            Items = new List<Item>();
        }

        public void AddDiscount(Discount discount)
        {
            if (!CanAddDiscount(discount))
            {
                throw new Exception("Nie można dodać rabatu!");
            }
            Discounts.Add(discount);               
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ApplyDiscounts()
        {

        }

        private bool CanAddDiscount(Discount discount)
        {
            Func<bool> isCanBeUsedMultipleTimesRuleValid = () => discount.CanBeUsedMultipleTimes || 
                Discounts.All(n => n.Name != discount.Name);

            Func<bool> isCanBeUsedWithOtherDiscountsRuleValid = () => discount.CanBeUsedWithOtherDiscounts || 
                !Discounts.Any();

            return CanAddDiscounts &&
                isCanBeUsedMultipleTimesRuleValid() && 
                isCanBeUsedWithOtherDiscountsRuleValid();
        }
    }
}
