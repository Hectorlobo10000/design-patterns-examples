using System;

namespace Patterns.PatternsOfPatterns
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }
}