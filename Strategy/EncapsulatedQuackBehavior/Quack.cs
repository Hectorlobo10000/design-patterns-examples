using System;

namespace Strategy.EncapsulatedQuackBehavior
{
    public class Quack : IQuackBehavior
    {
        public void QuackMethod()
        {
            Console.WriteLine("Quack!!");
        }
    }
}