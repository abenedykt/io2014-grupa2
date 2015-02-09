using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Witaj w naszym sklepie www===========");
            Console.WriteLine("=================Podaj swoje Id:================");
            int x; // x odpowiada za Id klienta
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("=============Wybierz produkt z listy:===========");
            // tutaj lista produktow, zeby zrobic readline
            int y; // y odpowiada za Id produktu
            y = int.Parse(Console.ReadLine());
        }
    }
}
