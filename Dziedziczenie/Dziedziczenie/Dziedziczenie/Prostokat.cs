using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    public class Prostokat
    {
        public double a { get; set; }
        public double b { get; set; }

        public Prostokat(double A, double B)
        {
            a = A;
            b = B;
        }

        public virtual double Pole()
        {
            return a*b;
        }
    }
}
