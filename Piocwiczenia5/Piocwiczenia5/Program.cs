using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Piocwiczenia5.Model;

namespace Piocwiczenia5
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() {Width = 5,Height = 5};
            var rectangle = new Rectangle() {Width = 5, Height = 5};

            Console.WriteLine(square.ReturlField());
            Console.WriteLine(rectangle.ReturlField());
            Console.ReadKey();
        }
    }
}
