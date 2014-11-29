using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IDiscount
    {
        string Name { get; set; }
        double Discount { get; set; }
    }
}
