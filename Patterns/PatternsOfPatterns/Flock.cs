using System;
using System.Collections.Generic;

namespace Patterns.PatternsOfPatterns
{
    public class Flock : IQuackable
    {
        private List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable duck)
        {
            _quackers.Add(duck);
        }
        
        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var quacker in _quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
            throw new ArgumentException("nothing");
        }
    }
}