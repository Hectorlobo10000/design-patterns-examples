using System;

namespace Patterns.Factory.FrameworkForThePizzaStore
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style deep dish cheese pizza";
            Dough = "extra thick crust dough";
            Sauce = "plum tomato sauce";
            
            Toppings.Add("shredded mozzarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("cutting the pizza into square slices");
        }
    }
}