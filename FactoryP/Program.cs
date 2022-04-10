using System;
using Patterns.Factory.SimpleFactory;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple factory

            var pizzaFactory = new PizzaFactory();
            var pizzaStore = new PizzaStore(pizzaFactory);
            var pizza = pizzaStore.OrderPizza("CheesePizza");
            Console.WriteLine(pizza.ToString());
        }
    }
}