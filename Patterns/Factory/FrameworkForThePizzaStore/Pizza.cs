using System;
using System.Collections.Generic;

namespace Patterns.Factory.FrameworkForThePizzaStore
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"preparing {Name}...");
            Console.WriteLine($"tossing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine($"Adding toppings: ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }

        public void Bake()
        {
            Console.WriteLine($"Bake for 25 minutes at 350 degrees");
        }

        public virtual void Cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine($"Place pizza in offcial pizzastore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}