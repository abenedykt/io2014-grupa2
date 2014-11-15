using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{
    class Square : Prostokat
    {
        public Square(int w)
            : base(w, w)
        {
            width = w;
            height = w;
        }

    }
}
