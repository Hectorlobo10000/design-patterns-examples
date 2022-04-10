using System.Collections.Generic;

namespace Patterns.Factory.FrameworkForThePizzaStore
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var dictionary = new Dictionary<string, Pizza>()
            {
                {"cheese", new ChicagoStyleCheesePizza()},
                {"pepperonie", new ChicagoStylePepperoniePizza()}
            };

            return dictionary[type];
        }
    }
}