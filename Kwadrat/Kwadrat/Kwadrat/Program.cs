using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{

    class Program
    {
        static void Main(string[] args)
        {
            Square kwadrat = new Square(5);
            Prostokat p = kwadrat;
            p.height = 10;
            p.width = 20;

            Console.WriteLine(kwadrat.Pole());

        }
    }
}
