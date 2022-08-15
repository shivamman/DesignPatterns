using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class ExecuteFile : ICommand
    {
        public ExecuteFile()
        {
            this.stringCommand = "file";
        }
        public override void Execute()
        {
            Console.WriteLine("File Command Executed");
        }
    }
}
