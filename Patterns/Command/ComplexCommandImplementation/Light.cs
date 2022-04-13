using System;

namespace Patterns.Command.ComplexCommandImplementation
{
    public class Light : ILight
    {
        public string Name;

        public Light(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"{Name} light is on");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} light is off");
        }
    }
}