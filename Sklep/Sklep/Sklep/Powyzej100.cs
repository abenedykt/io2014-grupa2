using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    //znizka 10% za zakupy powyzej 100zl
    class Powyzej100 : IZnizka
    {
        public double Wielkosc { get; set; }
        public string NazwaPromocji { get; set; }
        public Koszyk Koszyk { get; set; }
        public double ProcentZnizki { get; set; }

        public Powyzej100(Koszyk koszyk)
        {
            NazwaPromocji = "Zrob zakupy za 100zl - dostaniesz 10% znizki!"
            Koszyk = koszyk;
            ProcentZnizki = 0.1;

            ObliczZnizke();
        }

        public bool CzyPasuje()
        {
            if (Koszyk.PodstawowaCena >= 100)
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
