using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Discount.Model;

namespace Discount.Abstract
{
    public interface IOrder
    {
        Person Person { get; set; }
        DateTime Created { get; set; }
        double TotalQuantity { get; set; }
        double TotalPrice { get; set; }
        List<IOrderDetail> OrderDetails { get; set; }
        double Discount { get; set; }
        double DiscountValue { get; set; }
        double TotalPriceWithDiscount { get; set; }
    }
}