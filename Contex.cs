using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Contex
    {
        private IStrategy _strategy;

        public Contex(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void TypeNumber()
        {
            _strategy.TypeNumber();
        }
    }
}