namespace Patterns.Factory.FrameworkForThePizzaStore
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style sauce and cheese pizza";
            Dough = "thin crust dough";
            Sauce = "marinara sauce";
            
            Toppings.Add("Grated reggiano cheese");
        }
    }
}