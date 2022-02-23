using System;

namespace Strategy.EncapsulatedQuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackMethod()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}