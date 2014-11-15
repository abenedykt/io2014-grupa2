using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
        Kwadrat Kwadrat = new Kwadrat(5);
        //Prostokat Prostokat = new Prostokat();

        Prostokat p = Kwadrat;
        p.height = 10;
        p.width = 20;

        Console.WriteLine(Kwadrat.ObliczPole());
        }
    }
}
