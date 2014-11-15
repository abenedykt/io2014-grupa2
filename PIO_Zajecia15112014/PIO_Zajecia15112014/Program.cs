using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIO_Zajecia15112014
{
    class Program
    {
        static void Main(string[] args)
        {
            Square ABCD = new Square(3.14);
            Rectangle DCBA = new Rectangle(3, 4);

            Console.WriteLine(ABCD.Area());
            Console.WriteLine(DCBA.Area());
            
        }
    }
}
