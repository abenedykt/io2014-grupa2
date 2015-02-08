using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioSklep
{
    public interface IDiscount
    {
        void recalculate(Order order);
    }

}
