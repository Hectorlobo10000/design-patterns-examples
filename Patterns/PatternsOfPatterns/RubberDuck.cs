using System;

namespace Patterns.PatternsOfPatterns
{
    public class RubberDuck : IQuackable
    {
        private readonly Observable _observable;

        public RubberDuck()
        {
            _observable = new Observable(this);
        }
        
        public void Quack()
        {
            Console.WriteLine("squeak");
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
            return "Rubber";
        }
    }
}