using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piocwiczenia5.Abstract;

namespace Piocwiczenia5.Model
{
    //kwadrat
    public class Square:IFigure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int ReturlField()
        {
            return Width*Height;
        }
    }
}
