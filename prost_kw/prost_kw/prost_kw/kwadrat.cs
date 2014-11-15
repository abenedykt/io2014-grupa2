using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prost_kw
{
    public class Kwadrat : Prostokat
    {
        public Kwadrat(double a) : base(a, a)
        {
           
        }

        public override double Pole(double a)
        {
            return a * a;
        }
    }
}
