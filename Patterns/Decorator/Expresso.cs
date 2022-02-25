namespace Patterns.Decorator
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Espresso";
        }
    
        public override double Cost()
        {
            return 1.99;
        }
    }
}