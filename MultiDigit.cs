using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class MultiDigit : IStrategy
    {
        private int number;

        public MultiDigit(int number)
        {
            this.number = number;
        }

        public void TypeNumber()
        {
            Console.WriteLine($"{number} - многозначное число");
        }
    }
}
