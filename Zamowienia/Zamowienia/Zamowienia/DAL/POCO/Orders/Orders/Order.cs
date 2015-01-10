using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia;
using Zamowienia.Adresy;
using Zamowienia.DAL.POCO.Orders.Orders;

namespace Zamowienia
{
    public class Order 
    {

        public IClient Client { get; set; }

        public List<IDiscount>  Discounts { get; set; }

       

        public IAdress DeliveryAddr  { get; set; }

        public double CalculateTotalOrderValue()
        {
            return 0;
        }

    }
}
