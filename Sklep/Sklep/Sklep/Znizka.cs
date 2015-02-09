using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sklep
{
    // rabat zależy od zamówienia
    public interface IZnizka
    {   
        public double Wielkosc { get; set; }
        public string NazwaPromocji { get; set; }
        bool CzyPasuje(Produkt item);
        double ObliczZnizke(Produkt item);
    }

}
