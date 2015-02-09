using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Kup3NajtanszyGratis : IZnizka
    {
        public double Wielkosc { get; set; }
        public string NazwaPromocji { get; set; }
        public Koszyk Koszyk { get; set; }
        public double ProcentZnizki { get; set; }
        public int Ilosc { get; set; }
        public double Znizka { get; set; }

        public Kup3NajtanszyGratis(Koszyk koszyk)
        {
            NazwaPromocji = "Kup 3 rzeczy - najtansza za darmo!";
            Koszyk = koszyk;
            Ilosc = 3;

            Znizka = Koszyk.Produkty.Min(x => x.Cena);

            ObliczZnizke();
        }

        public bool czyPasuje()
        {
            if (Koszyk.Ilosc == 5)
            {
            return true;
            }
            return false;
        }

        private void ObliczZnizke()
        {
           Wielkosc = Koszyk.PodstawowaCena - Znizka;
        }
 
    }
}
