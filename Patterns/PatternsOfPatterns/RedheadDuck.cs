using System;

namespace Patterns.PatternsOfPatterns
{
    public class RedheadDuck : IQuackable
    {
        private readonly Observable _observable;

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Redhead";
        }
    }
}