using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIO_Zajecia15112014
{
    class Rectangle
    {
        private double _a;
        private double _b;
        public Rectangle()
        {

        }
        public Rectangle(double SideALength, double SideBLength)
        {
            a = SideALength;
            b = SideBLength;
        }
        public double a
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        public double b
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }

       virtual public double Area()
        {
            return a * b;
        }

    }
}
