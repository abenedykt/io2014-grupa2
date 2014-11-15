using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIO_LAB
{
    class Prostokat
    {
        public int width { get; set; }
        public int height { get; set; }

        public Prostokat(int w, int h)
        {
            width = w;
            height = h;
        }
        public int ObliczPole()
        {
            return width * height;
        }
    }
}
