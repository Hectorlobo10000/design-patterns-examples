using System;

namespace Patterns.TMethod.SimpleImplementation
{
    public class Tea : CaffeinBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("adding lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("steeping the tea");
        }
    }
}