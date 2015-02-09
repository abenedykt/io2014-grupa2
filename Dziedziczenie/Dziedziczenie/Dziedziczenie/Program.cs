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
            var kwadrat = new Kwadrat(3.2);

            Prostokat p = kwadrat;
            p.a = 5.2;
            p.b = 4.3;

            Console.WriteLine(kwadrat.Pole());

        }
    }
}
