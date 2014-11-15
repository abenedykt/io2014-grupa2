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
            var rectangle = new Rectangle(2, 5);
            var square = new Square(5);

            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Area());


        }
    }
}
