using System;

namespace FizzBuzz
{
    public class Game
    {
        public string Play(int p)
        {
            string result;
            if (p%5 == 0 && p%3 == 0)
            {
                return "FizzBuzz";
            }
            else if (p%3 == 0)
            {
                result = "Fizz";
            }
            else if (p%5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = p.ToString();
            }

            return result;
        }
    }
}
