using System.Collections.Generic;

namespace Patterns.Factory.SimpleFactory
{
    public class PizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            var dictionary = new Dictionary<string, IPizza>()
            {
                {"CheesePizza", new CheesePizza()},
                {"PepperoniePizza", new PepperoniePizza()}
            };

            return dictionary[type];
        }
    }
}