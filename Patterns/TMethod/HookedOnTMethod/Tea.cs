using System;

namespace Patterns.TMethod.HookedOnTMethod
{
    public class Tea : CaffeinBeverageWithHook
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