namespace Patterns.Factory.SimpleFactory
{
    public interface IPizza
    {
        string Prepare();
        string Bake();
        string Cut();
        string Box();
    }
}