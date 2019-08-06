using System;
using CommandPatternDemo.Commands;

namespace CommandPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestControlsForLights();
            Console.ReadLine();
        }

        public static void TestControlsForLights()
        {
            var light = new Light();

            var lightOn = new LightOnCommand(light);
            Console.Write($"Presses the On Button: ");
            lightOn.Execute();
            Console.Write("Undo: ");
            lightOn.Unexecute();

            var lightOff = new LightOffCommand(light);
            Console.Write($"Presses the Off Button: ");
            lightOff.Execute();
            Console.Write("Undo: ");
            lightOff.Unexecute();
        }
    }
}
