using System;

namespace Patterns.PatternsOfPatterns
{
    public class Quackologists : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"quackologist: {duck} justo quacked");
        }
    }
}