using System;

namespace Patterns.Adapter.SimpleAdapter
{
    public class WildTurkey : ITurkey

    {
        public void Gobble()
        {
            Console.WriteLine("gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("i am flying a short distance");
        }
    }
}