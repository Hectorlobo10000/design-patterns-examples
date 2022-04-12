using System.Collections.Generic;

namespace Patterns.Factory.IoC
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var chicagoPizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
            
            var dictionary = new Dictionary<string, Pizza>()
            {
                {"cheese", new CheesePizza(chicagoPizzaIngredientFactory, "chicago style cheese pizza")},
                {"pepperoni", new PepperoniPizza(chicagoPizzaIngredientFactory, "chicago style pepperoni pizza")},
            };

            return dictionary[type];
        }
    }
}