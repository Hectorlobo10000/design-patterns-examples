namespace Patterns.Command.ComplexCommandImplementation
{
    public interface IStereo
    {
        void On();
        void Off();
        void SetCd();
        void SetDvd();
        void SetRadio();
        void SetVolume(int value);
    }
}