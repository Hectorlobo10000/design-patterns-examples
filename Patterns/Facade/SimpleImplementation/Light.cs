namespace Patterns.Facade.SimpleImplementation
{
    public class Light : ITheaterLights
    {
        public void Dim(int i)
        {
            throw new System.NotImplementedException();
        }

        public void On()
        {
            throw new System.NotImplementedException();
        }
    }
}