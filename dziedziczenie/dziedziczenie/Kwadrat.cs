using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    class Kwadrat:Prostokat
    {
        public Kwadrat(int w)
            : base(w, w)
        {
            width = w;
            height = w;
        }

    }
}
