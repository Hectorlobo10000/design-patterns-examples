namespace Patterns.Factory.IoC
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}