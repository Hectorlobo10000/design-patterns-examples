using System;

namespace Patterns.Strategy.EncapsulatedFlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!!!");
        }
    }
}