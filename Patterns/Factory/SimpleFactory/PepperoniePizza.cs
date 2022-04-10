namespace Patterns.Factory.SimpleFactory
{
    public class PepperoniePizza : IPizza
    {
        public string Prepare()
        {
            return "prepare";
        }

        public string Bake()
        {
            return "bake";
        }

        public string Cut()
        {
            return "cut";
        }

        public string Box()
        {
            return "box";
        }
    }
}