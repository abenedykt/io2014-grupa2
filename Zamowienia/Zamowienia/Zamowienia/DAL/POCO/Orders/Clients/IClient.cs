using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia.DAL.POCO.Orders.Orders;

namespace Zamowienia
{
    public interface IClient
    {
       List<IOrderVerifier> OrderVerifiers { get; set; }

      bool VerifyClientOrder(Order order);


    }

}
