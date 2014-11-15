using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
           // var prostokat = new Prostokat(3.5, 4.5);
            var kwadrat = new Kwadrat(3.2);

            Prostokat p = kwadrat;
            p.a = 5.2;
            p.b = 4.3;
           // Console.WriteLine(prostokat.Pole());
            Console.WriteLine(kwadrat.Pole());

        }
    }
}
