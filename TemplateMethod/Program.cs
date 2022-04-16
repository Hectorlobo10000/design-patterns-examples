using System;
using Patterns.TMethod.HookedOnTMethod;

// the template method pattern defines the skeleton
// of an algorithm in a method, deferring some steps to subclasses.
// template method lets subclasses redefine certain steps of an algorithm without changing the algorithm's
// structure.

// the hoolywood principle: don't call us, we'll call you.

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeWithHook = new CoffeeWithHook();
            
            Console.WriteLine("\nmaking coffe");
            coffeWithHook.PrepareRecipe();
        }
    }
}