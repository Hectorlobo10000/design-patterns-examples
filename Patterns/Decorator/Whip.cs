namespace Patterns.Decorator
{
    public class Whip : CondimentDecorator
    {
        protected Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescriptionCondimentDecorator()
        {
            return _beverage.GetDescription() + ", whip";
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }
    }
}