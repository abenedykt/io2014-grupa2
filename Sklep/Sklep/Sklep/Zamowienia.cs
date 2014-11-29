using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{ //pojedyncze zamowienie
    public class Zamowienia
    {
        public IList<Produkt> Produkty { get; set; }
        public Klient Zamawiajacy { get; set; }
        public Dostawa Dostawca { get; set; } 
        public IList<Znizka> Zniżka { get; set; } //tutaj bedzie zmiana, bo sa rozne znizki
    }
}
