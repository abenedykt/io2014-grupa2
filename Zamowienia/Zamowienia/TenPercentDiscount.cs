using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia
{
  public class TenPercentDiscount : IDiscount
  {
    public decimal CalculatePrice(Order order)
    {
      var sum = order.Products.Sum(n => n.Price);

      return sum - (sum*0.1m);
    }
  }
}
