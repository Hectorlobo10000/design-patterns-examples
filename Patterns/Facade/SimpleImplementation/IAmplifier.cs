namespace Patterns.Facade.SimpleImplementation
{
    public interface IAmplifier
    {
        void On();
        void SetDvd(IDvdPlayer dvdPlayer);
        void SetSurroundSound();
        void SetVolume(int i);
        void Off();
    }
}