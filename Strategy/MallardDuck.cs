using System;
using Strategy.EncapsulatedFlyBehavior;
using Strategy.EncapsulatedQuackBehavior;

namespace Strategy
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