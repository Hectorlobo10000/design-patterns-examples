namespace Patterns.Factory.SimpleFactory
{
    public class CheesePizza : IPizza
    {
        public string Prepare()
        {
            return "Prepare";
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

        public override string ToString()
        {
            return "pizza created";
        }
    }
}