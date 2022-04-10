namespace Patterns.Factory.SimpleFactory
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}