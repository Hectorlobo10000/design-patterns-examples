using System;

namespace Patterns.Strategy.EncapsulatedQuackBehavior
{
    public class Quack : IQuackBehavior
    {
        public void QuackMethod()
        {
            Console.WriteLine("Quack!!");
        }
    }
}