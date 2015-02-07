using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSystem
{
    public abstract class Discount : DiscountSystem.IDiscount
    {
        public string Name { get; set; }
    }


}
