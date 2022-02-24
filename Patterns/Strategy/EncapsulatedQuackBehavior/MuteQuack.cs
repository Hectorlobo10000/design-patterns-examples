using System;

namespace Patterns.Strategy.EncapsulatedQuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackMethod()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}