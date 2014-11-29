using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamowienia;
using Zamowienia.Adresy;

namespace Zamowienia
{
    public class Zamowienie
    {

        public IKlient Zamawiajacy { get; set; }

        public List<IRabat>  Rabaty { get; set; }

        public IAdres AdresWysyłki  { get; set; }

        public double ObliczWartoscZamowienia();




    }
}
