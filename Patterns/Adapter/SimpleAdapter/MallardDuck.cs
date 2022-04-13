using System;

namespace Patterns.Adapter.SimpleAdapter
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("i am flying");
        }

        public void Quack()
        {
            Console.WriteLine("i am quacking");
        }
    }
}