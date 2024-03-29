﻿using System;
using System.Collections.Generic;
using System.Text;
using CommandPatternDemo.Abstract;

namespace CommandPatternDemo.Commands
{
    public class LightDimCommand : ICommand
    {
        private readonly Light _light;

        public LightDimCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.DecreaseBrightness();
        }

    }
}
