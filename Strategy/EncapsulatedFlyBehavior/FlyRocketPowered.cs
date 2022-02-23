using System;

namespace Strategy.EncapsulatedFlyBehavior
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!!");
        }
    }
}