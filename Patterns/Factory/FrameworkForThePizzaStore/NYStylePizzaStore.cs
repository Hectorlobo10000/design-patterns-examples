using System.Collections.Generic;

namespace Patterns.Factory.FrameworkForThePizzaStore
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var dictionary = new Dictionary<string, Pizza>()
            {
                {"cheese", new NYStyleCheesePizza()},
                {"pepperonie", new NYStylePepperonie()}
            };

            return dictionary[type];
        }
    }
}