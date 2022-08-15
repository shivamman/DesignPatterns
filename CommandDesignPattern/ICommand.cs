using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern
{
    public abstract class ICommand
    {
        public string stringCommand = "";
        public abstract void Execute();

    }
}
