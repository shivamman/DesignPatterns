using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public class Invoker
    {
        public List<ICommand> commands = new List<ICommand>();
        public Invoker()
        {
            commands.Add(new ExecuteClose());
            commands.Add(new ExecuteFile());
            commands.Add(new ExecuteOpen());
        }
        public ICommand GetCommand(string commandString)
        {
            foreach (var command in commands)
            {
                if(command.stringCommand == commandString)
                {
                    return command;
                }
            }
            return null;
        }
    }
}
