using System;

namespace _3.Zlozonosc
{
    public class Class1
    {
        public void Metoda1()
        {

        }

        public int Metoda2(int k, int j)
        {
            return k + j;
        }

        public double Metoda3(bool monday, double @base, double tax)
        {
            if (monday)
            {
                return @base + @base * tax;
            } else if(tax < 0 )
            {
                return 0;
            }
            return @base;
        }

        public double Metoda4(int day, double @base, double tax)
        {
            switch (day)
            {
                case 12: return @base + tax * 5;
                case 2: return @base + tax * 6;
            }

            return 0;
        }

    }
}
