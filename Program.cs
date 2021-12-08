using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contex contex = new Contex(GetStrategy(-45));
            contex.TypeNumber();
            contex.SetStrategy(GetStrategy(2));
            contex.TypeNumber();
            contex.SetStrategy(GetStrategy(208));
            contex.TypeNumber();
        }

        static IStrategy GetStrategy(int number)
        {
            if (number > -10 && number < 10)
                return new SingleDigit(number);
            else if (number > -100 && number < 100)
                return new TwoDigit(number);

            return new MultiDigit(number);
        }
    }
}
