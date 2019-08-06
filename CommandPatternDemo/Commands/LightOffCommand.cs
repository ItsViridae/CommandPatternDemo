using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }

        public void Unexecute()
        {
            light.On();
        }
    }
}
