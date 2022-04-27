using System;

namespace Patterns.PatternsOfPatterns
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("squeak");
        }
    }
}