using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class TwoDigit : IStrategy
    {
        private int number;

        public TwoDigit(int number)
        {
            this.number = number;
        }

        public void TypeNumber()
        {
            Console.WriteLine($"{number} - двузначное число");
        }
    }
}
