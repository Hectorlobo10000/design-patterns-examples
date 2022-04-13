namespace Patterns.Command.ComplexCommandImplementation
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly IStereo _stereo;

        public StereoOnWithCDCommand(IStereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(15);
        }
    }
}