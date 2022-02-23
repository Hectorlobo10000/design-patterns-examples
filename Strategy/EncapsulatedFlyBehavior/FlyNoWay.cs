using System;

namespace Strategy.EncapsulatedFlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly!!");
        }
    }
}