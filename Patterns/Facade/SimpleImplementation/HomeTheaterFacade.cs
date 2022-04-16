using System;

namespace Patterns.Facade.SimpleImplementation
{
    public class HomeTheaterFacade
    {
        private readonly IAmplifier _amplifier;
        private readonly ITuner _tuner;
        private readonly IDvdPlayer _dvdPlayer;
        private readonly ICdPlayer _cdPlayer;
        private readonly IProjector _projector;
        private readonly ITheaterLights _theaterLights;
        private readonly IScree _scree;
        private readonly IPopcornPopper _popcornPopper;

        public HomeTheaterFacade(IAmplifier amplifier, ITuner tuner, IDvdPlayer dvdPlayer, ICdPlayer cdPlayer, IProjector projector, ITheaterLights theaterLights, IScree scree, IPopcornPopper popcornPopper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
            _scree = scree;
            _popcornPopper = popcornPopper;
        }


        public void WatchMOvie(string movie)
        {
            Console.WriteLine("get ready to watch a movie...");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _scree.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("shutting movie theater down...");
            _popcornPopper.Off();
            _theaterLights.On();
            _scree.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}