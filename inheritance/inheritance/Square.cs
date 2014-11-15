using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Square : ICalculate
    {
        public double A { get; set; }

        public Square(double a)
        {
            A = a;
        }

        public double CalculateField()
        {
            return A*A;
        }
    }
}
