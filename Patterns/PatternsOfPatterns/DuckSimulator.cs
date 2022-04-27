using System;

namespace Patterns.PatternsOfPatterns
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            var mallardDuck = duckFactory.CreateMallardDuck();
            var redheadDuck = duckFactory.CreateRedheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
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