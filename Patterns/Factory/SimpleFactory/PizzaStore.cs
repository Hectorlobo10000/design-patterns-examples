namespace Patterns.Factory.SimpleFactory
{
    public class PizzaStore
    {
        private readonly IPizzaFactory _pizzaFactory;

        public PizzaStore(IPizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(string type)
        {
            var pizza = _pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}