using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 5);
            var square = new Square(5);


            Console.WriteLine("Rectangle field: {0}", rectangle.CalculateField());
            Console.WriteLine("Square field: {0}", square.CalculateField());
            Console.ReadLine();
        }
    }
}
