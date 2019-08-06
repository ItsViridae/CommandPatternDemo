using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace CommandPatternDemo
{
    public class Light
    {
        public Light()
        {
            var level = 10;
        }
        public void On()
        {
            Console.WriteLine("Light Is On");
        }
        public void Off()
        {
            Console.WriteLine("Light Is Off");
        }

        public void DecreaseBrightness(int level)
        {
            if (level != 0)
            {
                level--;
            }
            else Console.WriteLine("Light is Off, 0 PowerLevel");
        }

        public void IncreaseBrightness(int level)
        {
            if (level < 10)
            {
                level++;
            }
        }
    }
}
