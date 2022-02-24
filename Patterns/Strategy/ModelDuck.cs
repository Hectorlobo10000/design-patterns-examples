using System;
using Patterns.Strategy.EncapsulatedFlyBehavior;
using Patterns.Strategy.EncapsulatedQuackBehavior;

namespace Patterns.Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
        
        public override void Display()
        {
            Console.WriteLine("Model Duck!!");
        }
    }
}