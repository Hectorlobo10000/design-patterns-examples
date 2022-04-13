using System;

namespace Patterns.Command.ComplexCommandImplementation
{
    public class Stereo : IStereo
    {
        public void On()
        {
            Console.WriteLine("stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine("insert cd");
        }

        public void SetDvd()
        {
            Console.WriteLine("insert a dvd");
        }

        public void SetRadio()
        {
            Console.WriteLine("changing to radio");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"setting volumen to {value}");
        }
    }
}