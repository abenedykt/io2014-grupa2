using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{   //kup 5 rzeczy otrzymaj 30% znizki
    class Kup5Znizka
    {
        public double Wielkosc { get; set; }
        public string NazwaPromocji { get; set; }
        public Koszyk Koszyk { get; set; }
        public double ProcentZnizki { get; set; }
        public int Ilosc { get; set; }

        public Kup5Znizka(Koszyk koszyk)
        {
            NazwaPromocji = "Kup 5 rzeczy - znizna 30% na cale zakupy!";
            Koszyk = koszyk;
            ProcentZnizki = 0.3;
            Ilosc = 5;

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
           Wielkosc = Koszyk.PodstawowaCena * ProcentZnizki;

        }
 
    }
    }
}
