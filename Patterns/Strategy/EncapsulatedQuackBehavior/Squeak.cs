using System;

namespace Patterns.Strategy.EncapsulatedQuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void QuackMethod()
        {
            Console.WriteLine("Squeak!!");
        }
    }
}