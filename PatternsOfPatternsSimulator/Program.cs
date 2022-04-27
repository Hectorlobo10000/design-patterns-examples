using System;
using Patterns.PatternsOfPatterns;

namespace PatternsOfPatternsSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var simulator = new DuckSimulator();
            simulator.Simulate();
        }
    }
}