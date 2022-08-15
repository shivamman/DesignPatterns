using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class ExecuteClose : ICommand
    {
        public ExecuteClose()
        {
            this.stringCommand = "close";
        }
        public override void Execute()
        {
            Console.WriteLine("Close Command Executed");
        }
    }
}
