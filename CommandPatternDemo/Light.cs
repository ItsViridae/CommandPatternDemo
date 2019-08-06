using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace CommandPatternDemo
{
    public class Light
    {
        public int Brightness { get; set; }
        public bool IsOn { get; set; }
        public void OnOrOff()
        {
            if (!IsOn)
            {
                Brightness = 10;
                IsOn = true;
                Console.WriteLine("Light Is On");
            }
            else
            {
                Brightness = 0;
                Console.WriteLine("Light Is Off");
            }
        }

        public void DecreaseBrightness()
        {
            if (Brightness != 0)
            {
                Brightness--;
            }
            else Console.WriteLine("Light is Off, 0 PowerLevel");
        }

        public void IncreaseBrightness()
        {
            if (Brightness < 10)
            {
                Brightness++;
            }
        }
    }
}
