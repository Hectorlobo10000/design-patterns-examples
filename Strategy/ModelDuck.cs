using System;
using Strategy.EncapsulatedFlyBehavior;
using Strategy.EncapsulatedQuackBehavior;

namespace Strategy
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