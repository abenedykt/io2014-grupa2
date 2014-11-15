using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pio111514
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 5, Height = 5 };
            var recentangle = new Rectangle { Width = 7, Height = 5 };

            Console.WriteLine(square.ReturnField());
            Console.WriteLine(recentangle.ReturnField());
            Console.ReadKey();

        }
    }
}
