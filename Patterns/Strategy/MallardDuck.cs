using System;
using Patterns.Strategy.EncapsulatedFlyBehavior;
using Patterns.Strategy.EncapsulatedQuackBehavior;

namespace Patterns.Strategy
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }
        
        public override void Display()
        {
            Console.WriteLine("Mallard Duck!!");
        }
    }
}