using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrSq
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public Rectangle(int a, int b)
        {
            Width = a;
            Height = b;
        }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public double SurfaceArea()
        {
            return Width * Height;
        }

        public static explicit operator Rectangle(Square sq)
        {
            Rectangle rect = new Rectangle(sq.Width, sq.Height);
            return rect;
        }
    
    }

}
