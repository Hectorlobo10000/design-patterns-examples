using System;

namespace Patterns.Factory.IoC
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _factory;

        public PepperoniPizza(IPizzaIngredientFactory factory, string name)
        {
            _factory = factory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"preparing {Name}");
            Dough = _factory.CreateDough();
            Sauce = _factory.CreateSauce();
            Cheese = _factory.CreateCheese();
            Pepperoni = _factory.CreatePepperoni();
        }
    }
}