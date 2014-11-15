using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prost_kw
{
    public class Prostokat
    {
        public double A { get; set; }
        public double B { get; set; }

        public Prostokat(double a, double b)
        {
            A = a;
            B = b;
        }

        public virtual double Pole()
        {
            return A * B;
        }


    }
}
