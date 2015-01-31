namespace DiscountSystem
{
    public abstract class Discount
    {
        public string Name { get; private set; }
        public virtual bool CanBeUsedWithOtherDiscounts { get; set; }
        public virtual bool CanBeUsedMultipleTimes { get; set; }

        public Order Order { get; set; }

        public Discount(string name)
        {
            Name = name;
        }

        public abstract Order ApplyDiscount();
    }
}
