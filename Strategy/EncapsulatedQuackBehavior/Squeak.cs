using System;

namespace Strategy.EncapsulatedQuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void QuackMethod()
        {
            Console.WriteLine("Squeak!!");
        }
    }
}