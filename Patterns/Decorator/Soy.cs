namespace Patterns.Decorator
{
    public class Soy : CondimentDecorator
    {
        protected Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescriptionCondimentDecorator()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }
    }
}