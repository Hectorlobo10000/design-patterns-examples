using System;

namespace Patterns.PatternsOfPatterns
{
    public class DuckSimulator
    {
        public void Simulate()
        {
            var mallardDuck = new QuackCounter(new MallardDuck());
            var redheadDuck = new QuackCounter(new RedheadDuck());
            var duckCall = new QuackCounter(new DuckCall());
            var rubberDuck = new QuackCounter(new RubberDuck());
            var gooseDuck = new GooseAdapter(new Goose());
            
            Console.WriteLine("\nDuck Simulator");
            
            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
            
            Console.WriteLine($"the ducks quacked {QuackCounter.GetQuacks()} times");
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}