using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo.Commands
{
    public class LightBrightenCommand : ICommand
    {
        private readonly Light _light;

        public LightBrightenCommand(Light light)
        {
            _light = light;
        }
        
        public void Execute()
        {
           _light.IncreaseBrightness();
        }
    }
}
