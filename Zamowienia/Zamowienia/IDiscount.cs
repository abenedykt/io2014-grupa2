using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia
{
  public interface IDiscount
  {
    decimal CalculatePrice(Order order);
  }
}
