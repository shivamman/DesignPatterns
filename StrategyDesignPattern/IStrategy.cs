using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public interface IStrategy
    {
        public int DoOperation(int a, int b);
    }
}
