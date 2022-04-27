using System;

namespace Patterns.PatternsOfPatterns
{
    public class DuckSimulator
    {
        public void Simulate()
        {
            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var duckCall = new DuckCall();
            var rubberDuck = new RubberDuck();
            var gooseDuck = new GooseAdapter(new Goose());
            
            Console.WriteLine("\nDuck Simulator");
            
            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}