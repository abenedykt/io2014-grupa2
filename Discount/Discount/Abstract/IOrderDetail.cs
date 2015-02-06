namespace Discount.Abstract
{
    public interface IOrderDetail
    {
        string ProductName { get; set; }
        double Quantity { get; set; }
        double Price { get; set; }
    }
}