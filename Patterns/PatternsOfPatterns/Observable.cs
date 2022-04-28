using System.Collections.Generic;

namespace Patterns.PatternsOfPatterns
{
    public class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}