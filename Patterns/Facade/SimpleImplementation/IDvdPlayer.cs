namespace Patterns.Facade.SimpleImplementation
{
    public interface IDvdPlayer
    {
        void On();
        void Play(string movie);
        void Stop();
        void Eject();
        void Off();
    }
}