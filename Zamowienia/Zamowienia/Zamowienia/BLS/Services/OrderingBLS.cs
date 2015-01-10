using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia.DAL.POCO.Orders.Status;

namespace Zamowienia.BLS.Services
{
    public class OrderingBLS
    {

        public OrderStatus SendOrder(Order order)
        {
            order.CalculateTotalOrderValue();

            return new OrderStatus();
        }



    }
}
