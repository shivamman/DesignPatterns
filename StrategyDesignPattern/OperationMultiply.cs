using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class OperationMultiply : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a * b;
        }
    }
}
