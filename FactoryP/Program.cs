using System;
using Patterns.Factory.FrameworkForThePizzaStore;
using Patterns.Factory.SimpleFactory;


// The factory method pattern defines an interface for creating an object, but l3ets subclassses decide which
// class to instantiate. factory method lets a class defer instantiate to subclasses.

// The dependency inversion principle:
// depend upon abstractions. do not depend upon concrete classes.

// the abstract factory pattern provides an interface for creating families of realted or dependent objects
// without specificing their concrete classes.

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple factory

            // var pizzaFactory = new PizzaFactory();
            // var pizzaStore = new PizzaStore(pizzaFactory);
            // var pizza = pizzaStore.OrderPizza("CheesePizza");
            // Console.WriteLine(pizza.ToString());
            
            // factory method

            var nyPizzaStore = new NYStylePizzaStore();
            var chPizzaStore = new ChicagoStylePizzaStore();

            var pizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

            pizza = chPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}");
        }
    }
}