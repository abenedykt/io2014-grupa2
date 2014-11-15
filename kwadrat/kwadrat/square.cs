using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace kwadrat
{

    class Square : Rectangle
    {



        public Square(double SideLength)
        {

            a = SideLength;

        }

        public override double Area()
        {

            return a * a;

        }

    }

}