using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    //znizka 20% powyzej 200zl
    class Powyzej200 : IZnizka
    {
        public double Wielkosc { get; set; }
        public string NazwaPromocji { get; set; }
        public Koszyk Koszyk { get; set; }
        public double ProcentZnizki { get; set; }

        public Powyzej200(Koszyk koszyk)
        {
            NazwaPromocji = "Zrob zakupy za 200zl - otrzymasz 20% znizki";
            Koszyk = koszyk;
            ProcentZnizki = 0.2;

            ObliczZnizke();
        }

        public bool CzyPasuje()
        {
            if (Koszyk.PodstawowaCena >= 200)
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
