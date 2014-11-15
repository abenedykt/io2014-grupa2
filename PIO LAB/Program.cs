using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIO_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kwadrat = new Kwadrat(5);

            Prostokat p = kwadrat;

            p.height = 90;
            p.width = 80;

            //Prostokat prostokat = new Prostokat(5, 6);

            Console.WriteLine(kwadrat.ObliczPole());
            //Console.WriteLine(prostokat.ObliczPole());
        }
    }
}
