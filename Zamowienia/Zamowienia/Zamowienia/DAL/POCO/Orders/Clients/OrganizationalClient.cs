using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia.DAL.POCO.Orders.Orders;

namespace Zamowienia
{
    public class OrganizationalClient : IClient
    {
        public List<IOrderVerifier> OrderVerifiers { get; set; }

        public bool VerifyClientOrder(Order order)
        {
            return false;
        }
    }

}
