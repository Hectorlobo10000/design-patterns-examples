using System;

namespace Patterns.Command.SimpleCommandImplementation
{
    public class Light : ILight
    {
        public void On()
        {
            Console.WriteLine("light is on");
        }
    }
}