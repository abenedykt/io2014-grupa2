namespace Discount.Abstract
{
    public interface IDiscount
    {
        void Recalculate(IOrder order);    
    }
}