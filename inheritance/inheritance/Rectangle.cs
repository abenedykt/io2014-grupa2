using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rectangle : ICalculate
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double CalculateField()
        {
            return A*B;
        }
    }
}
