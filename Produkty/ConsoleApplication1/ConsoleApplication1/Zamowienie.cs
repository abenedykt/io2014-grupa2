using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Zamowienie 
    {
        IList<Produkt> Produkty { get; set; }
        IList<Dostawa> Dostawa { get; set; }
        IList<Rabat> Rabat { get; set; }
    }
}
