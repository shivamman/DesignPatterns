using System;

namespace StrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Context context = new Context(new OperationAdd());
            Console.WriteLine(context.ExecuteStrategy(a, b));
            context = new Context(new OperationMultiply());
            Console.WriteLine(context.ExecuteStrategy(a, b));
            context = new Context(new OperationSubstract());
            Console.WriteLine(context.ExecuteStrategy(a, b));
            Console.WriteLine("Hello World!");
        }
    }
}
