using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia.DAL.POCO.Orders.Orders
{
    public interface IOrderVerifier
    {
        bool VerifyOrder(Order order);

    }

}
