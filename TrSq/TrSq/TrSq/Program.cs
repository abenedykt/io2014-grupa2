using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrSq
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new Square();
            p.Width  = 10;

            Rectangle r = (Rectangle)p;
            r.Height = 200;
            r.Width = 400;

            Console.WriteLine(p.SurfaceArea());
        }
    }
}
