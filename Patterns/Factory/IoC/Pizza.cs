using System;

namespace Patterns.Factory.IoC
{
    public abstract class Pizza
    {
        protected string Name;
        protected IDough Dough;
        protected ISauce Sauce;
        protected IVeggies[] Veggies;
        protected ICheese Cheese;
        protected IPepperoni Pepperoni;
        protected IClams Clams;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("cutrting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("place pizza in official pizzastore box");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName(string name)
        {
            return Name;
        }
        
    }
}