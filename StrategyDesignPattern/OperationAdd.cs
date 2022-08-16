using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class OperationAdd : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }
}
