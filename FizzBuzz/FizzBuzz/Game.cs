using System;

namespace FizzBuzz
{
    public class Game
    {
        public string Play(int p)
        {
            string result = "";
            if (p % 3 == 0) result = "Fizz";
            if (p % 5 == 0) result += "Buzz";
            if (result == "") result = p.ToString();

            return result;
        }
    }
}
