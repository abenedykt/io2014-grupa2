using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prost_kw
{
    class Program
    {
        static void Main(string[] args)
        {
            //var prostokat = new Prostokat(3.5, 4);
            var kwadrat = new Kwadrat(2);

            Prostokat p = kwadrat;
            p.A = 500;
            p.B = 400;

            //Console.WriteLine(prostokat.Pole());
            Console.WriteLine(kwadrat.Pole());
        }
    }
}
