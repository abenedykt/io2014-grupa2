using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia;
using Zamowienia.Adresy;
using Zamowienia.DAL.POCO.Orders.Orders;
using Zamowienia.Produkty;

namespace Zamowienia
{
    public class Order 
    {

        public IClient Client { get; set; }

        public List<IDiscount> Discounts { get; set; }

        public List<IProduct> Products { get; set; }

        public double TotalOrderValueRaw { get; set; }

        public double TotalOrderValue { get; set; }

        public IAdress DeliveryAddr  { get; set; }

        public Order()
        {
            
        }

        public void CalculateTotalOrderValue()
        {
            double totalDiscountValue = 0.00;
            foreach (IDiscount disc in Discounts)
            {
               totalDiscountValue +=  disc.CalculateDiscountForOrder(this);
            }
            TotalOrderValue = TotalOrderValueRaw - totalDiscountValue > 0 ? TotalOrderValueRaw - totalDiscountValue : 0;
        }

    }
}
