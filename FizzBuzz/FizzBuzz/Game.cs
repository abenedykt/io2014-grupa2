using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Game
    {
        internal string Play(int p)
        {
            if ((p % 3 == 0) && (p % 5 == 0))
            {
                return "FizzBazz";
            }
            if (p % 3 == 0)
            {
                return "Fizz";
            }
            if (p % 5 == 0)
            {
                return "Bazz";
            }
            return p.ToString();
        }
    }
}
