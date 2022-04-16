using Patterns.Facade.SimpleImplementation;

// the facade pattern provides a unified interface to a set of interfaces in a subsystem. facade defines a 
// higher-level interface that makes the subsystem easier to use.

// design principle
// principle of least knowledge: talk only to your immediate friends.

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IAmplifier amp = new Amplifier();
            ITuner tuner = new Tuner();
            IDvdPlayer dvd = new Dvd();
            ICdPlayer cd = new Cd();
            IProjector pro = new Projector();
            IScree scre = new Screen();
            ITheaterLights li = new Light();
            IPopcornPopper popper = new Popper();

            var homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, pro, li, scre, popper);
            
            homeTheater.WatchMOvie("lord of rings");
            homeTheater.EndMovie();
        }
    }
}