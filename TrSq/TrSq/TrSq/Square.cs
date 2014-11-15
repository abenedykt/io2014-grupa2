using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrSq
{
    public class Square : Shape
    {

        public Square()
        {
                
        }
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                base.Width = value;
            }

        }

        public double SurfaceArea()
        {
            return Width * Height;
        }

    }

}
