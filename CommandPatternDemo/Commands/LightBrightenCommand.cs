using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo.Commands
{
    public class LightBrightenCommand : ICommand
    {

        
        public void Execute()
        {
           Console.WriteLine("Brighten");
        }

        public void Unexecute()
        {
           Console.WriteLine("Un-Brighten");
        }
    }
}
