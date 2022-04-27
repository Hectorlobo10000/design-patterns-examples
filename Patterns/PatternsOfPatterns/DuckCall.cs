using System;

namespace Patterns.PatternsOfPatterns
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("kwak");
        }
    }
}