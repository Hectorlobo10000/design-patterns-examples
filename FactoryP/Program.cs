using System;
using Patterns.Factory.FrameworkForThePizzaStore;
using Patterns.Factory.SimpleFactory;

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