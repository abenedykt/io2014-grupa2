using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioSklep
{
   public class OrderDetail
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int TotalValue
        {
            get { return Quantity * Price; }

            set { value = TotalValue; }
        }
    }

}
