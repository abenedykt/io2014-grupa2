using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pio111514
{
    class Rectangle:IFigure
    {
        public int Width{ get; set; }
        public int Height { get; set; }

        public int ReturnField()
        {

            return Width * Height;
        }
    
    }
}
