namespace Patterns.Facade.SimpleImplementation
{
    public class Dvd : IDvdPlayer
    {
        public void On()
        {
            throw new System.NotImplementedException();
        }

        public void Play(string movie)
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public void Eject()
        {
            throw new System.NotImplementedException();
        }

        public void Off()
        {
            throw new System.NotImplementedException();
        }
    }
}