namespace Patterns.Decorator
{
    public abstract class Beverage
    {
        protected string description = "Unknow beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
} 