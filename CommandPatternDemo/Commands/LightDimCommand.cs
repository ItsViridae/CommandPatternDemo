using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo.Commands
{
    public class LightDimCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Lights Dim");
        }

        public void Unexecute()
        {
            Console.WriteLine("Lights Un-Dim");
        }
    }
}
