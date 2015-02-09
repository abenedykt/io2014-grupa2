using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class Koszyk
    {
        public List<Produkt> Produkty { get; set; }
        public double PodstawowaCena { get; set; }
        public int Ilosc { get; set; }

        public Koszyk()
        {
            Produkty = new List<Produkt>();
            PodstawowaCena = 0.0;
            Ilosc = 0;
        }

        public void ObliczCene()
        {
            Produkty.ForEach(p => PodstawowaCena += p.Cena);
        }
    }
}
