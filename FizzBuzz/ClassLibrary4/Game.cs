using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary4
{
    class Game
    {
        internal string Play(string p)
        {
            if ((p!="3") && (p != "5"))
            {
                return p;                
            }
            else if (p=="3")
            {
                return "fizz";
            }
            else
            {
                return "buzz";
            }

        }
    }
}
