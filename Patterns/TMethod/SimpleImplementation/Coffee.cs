using System;

namespace Patterns.TMethod.SimpleImplementation
{
    public class Coffee : CaffeinBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("dripping coffee through filter");
        }
    }
}