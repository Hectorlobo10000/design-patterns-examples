namespace Patterns.Factory.SimpleFactory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(string type);
    }
}