using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia
{
  public class Order
  {
    public IList<IProduct> Products { get; set; }
    public IList<IDiscount> Discounts { get; set; }
    public Delivery Delivery { get; set; }
    public Client Client { get; set; }

    public decimal GetFinalPrice()
    {
      
    }
  }
}
