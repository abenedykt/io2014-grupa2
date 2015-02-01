using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IDiscount
    {
        double DiscountValue { get; set; }

        bool Condition();

        void Recalculate();
    }
}
