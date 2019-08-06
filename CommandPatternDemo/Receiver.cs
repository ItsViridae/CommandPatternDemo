using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternDemo
{
    public class Receiver
    {
        public void PressOnButton(string lightsOn)
        {
            Console.WriteLine($"Receiver: Turns Lights On  => ({lightsOn}).");
        }

        public void PressOffButton(string lightsOff)
        {
            Console.WriteLine($"Receiver: Turns Lights Off => ({lightsOff}).");
        }
        public void PressDimButton(string lightsDim)
        {
            Console.WriteLine($"Receiver: Lights Brightness Decrease by -1 => ({lightsDim}).");
        }
        public void PressBrightenButton(string lightsBrighten)
        {
            Console.WriteLine($"Receiver: Lights Brightness Increase by +1 => ({lightsBrighten}).");
        }
    }
    
}
