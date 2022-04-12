using System;

namespace Patterns.Factory.IoC
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _factory;

        public CheesePizza(IPizzaIngredientFactory factory, string name)
        {
            _factory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"preparing {Name}");
            Dough = _factory.CreateDough();
            Sauce = _factory.CreateSauce();
            Cheese = _factory.CreateCheese();
        }
    }
}