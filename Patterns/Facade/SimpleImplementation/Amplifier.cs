using System;

namespace Patterns.Facade.SimpleImplementation
{
    public class Amplifier : IAmplifier
    {
        public void On()
        {
            throw new NotImplementedException();
        }

        public void SetDvd(IDvdPlayer dvdPlayer)
        {
            throw new NotImplementedException();
        }

        public void SetSurroundSound()
        {
            throw new NotImplementedException();
        }

        public void SetVolume(int i)
        {
            throw new NotImplementedException();
        }

        public void Off()
        {
            throw new NotImplementedException();
        }
    }
}