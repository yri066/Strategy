using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class SingleDigit : IStrategy
    {
        private int number;

        public SingleDigit(int number)
        {
            this.number = number;
        }

        public void TypeNumber()
        {
            Console.WriteLine($"{number} - однозначное число");
        }
    }
}
