using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class Game
    {
        public string play(int num)
        {
            
            if (DividesByThree(num) && DividesByFive(num))
            {
                return "Fizz Buzz";
            }
            else if (DividesByThree(num))
            {
                return "Fizz";
            }
            else if (DividesByFive(num))
            {
                return "Buzz";
            }

            return "";
        }

        public bool DividesByThree(int num)
        {
            return num % 3 == 0 ? true : false;
        }

        public bool DividesByFive(int num) 
        {
            return num % 5 == 0 ? true : false;
        }

    }

}
