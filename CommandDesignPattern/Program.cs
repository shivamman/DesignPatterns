using System;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new 
            // New Command Executed 
            //file, open, close
            string stringCommand = Console.ReadLine().ToString();
            #region ifs
            //if(stringCommand == "file")
            //{
            //    Console.WriteLine("File Command Executed");
            //}
            //else if (stringCommand == "new")
            //{
            //    Console.WriteLine("New Command Executed");
            //}
            //else if (stringCommand == "open")
            //{
            //    Console.WriteLine("Open Command Executed");
            //}
            //else if (stringCommand == "close")
            //{
            //    Console.WriteLine("Close Command Executed");
            //}
            #endregion
            Invoker invoker = new Invoker();
            var command  =  invoker.GetCommand(stringCommand);
            command.Execute();
            Console.ReadLine();
        }
    }
}
