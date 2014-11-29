using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamowienia
{
  class Program
  {
    static void Main(string[] args)
    {
      var order = new Order();

      order.Discounts.Add(new TenPercentDiscount());


    }
  }
}
