using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Abstract;

namespace Discount.Model
{
    public class OrderDetail:IOrderDetail
    {
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }
}
