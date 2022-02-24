using System;
using Patterns.Strategy.EncapsulatedFlyBehavior;
using Patterns.Strategy.EncapsulatedQuackBehavior;

namespace Patterns.Strategy
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;
        
        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.QuackMethod();
        }

        public void Swin()
        {
            Console.WriteLine("All ducks float, even decoys!!");
        }

        public void SetFlyBehavior(FlyRocketPowered fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }
}