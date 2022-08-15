using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class ExecuteOpen : ICommand
    {
        public ExecuteOpen()
        {
            this.stringCommand = "open";
        }
        public override void Execute()
        {
            Console.WriteLine("Open Command Executed");
        }
    }
}
