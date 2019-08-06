using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo.Commands
{
    public class NoCommand : ICommand
    {
        void ICommand.Execute()
        {
        }

        void ICommand.Unexecute()
        {
        }
    }
}
