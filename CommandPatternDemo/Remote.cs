using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo
{
    public class Remote
    {
        public ICommand Command { get; set; }

        public void SetCommand(ICommand command)
        {
            Command = command;
        }

        public void PressButton()
        {
            Command.Execute();
        }

    }
}
