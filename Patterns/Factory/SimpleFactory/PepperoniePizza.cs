using System;

namespace Patterns.Factory.SimpleFactory
{
    public class PepperoniePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("prepare");
        }

        public void Bake()
        {
            Console.WriteLine("bake");
        }

        public void Cut()
        {
            Console.WriteLine("cut");
        }

        public void Box()
        {
            Console.WriteLine("box");
        }
    }
}