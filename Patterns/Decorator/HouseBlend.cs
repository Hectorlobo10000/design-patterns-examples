namespace Patterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House blend coffee";
        }
        
        public override double Cost()
        {
            return 0.89;
        }
    }
}