using System;
using Patterns.PatternsOfPatterns;

namespace PatternsOfPatternsSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            var duckFactory = new CountingDuckFactory();
            simulator.Simulate(duckFactory);
        }
    }
}