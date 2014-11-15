using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    class Square : Rectangle
    {
        private double a;

        public Square(double a) : base(a, 1)
        {
            this.a = a;
        }

        public override double Area()
        {
            return a*a;
        }
    }
}
