using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class Game
    {
        internal string Play(int p)
        {
            // sposob nr 1
            string str = Console.ReadLine();
            int result;

            switch (str)
            {                
                case "FizzBuzz":
                    result = p % 15;
                    break;
                
                case "Fizz":
                    result = p % 3;
                    break;
                
                case "Buzz":
                    result = p % 5;
                    break;

                default:
                    result = 1;
                    break;
            }
            
            // sposob nr 2
            if (p % 3 == 0 && p % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (p % 5 == 0)
            {
                return "Buzz";
            }
            else if (p % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return 1.ToString();
            }
        }
    }
}
