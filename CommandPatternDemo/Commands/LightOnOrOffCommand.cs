using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo
{
    public class LightOnOrOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOnOrOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.OnOrOff();
        }
    }
}
