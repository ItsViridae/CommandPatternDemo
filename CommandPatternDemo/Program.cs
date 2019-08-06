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
            var remote = new Remote();
            remote.SetCommand(new LightOnOrOffCommand(light));
            remote.PressButton();
            Console.WriteLine($"Brightness is: {light.Brightness}");
            remote.SetCommand(new LightDimCommand(light));
            remote.PressButton();
            Console.WriteLine($"Brightness is: {light.Brightness}");
            remote.SetCommand(new LightOnOrOffCommand(light));
            remote.PressButton();
            Console.WriteLine($"Brightness is: {light.Brightness}");

        }
    }
}
