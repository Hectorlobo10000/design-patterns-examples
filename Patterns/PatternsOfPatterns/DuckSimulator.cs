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
            
            Console.WriteLine("\nDuck Simulator: with composite - flocks");

            var flockOfDucks = new Flock();
            
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            var flockOfMallards = new Flock();

            var mallardOne = duckFactory.CreateMallardDuck();
            var mallardTwo = duckFactory.CreateMallardDuck();
            var mallardThree = duckFactory.CreateMallardDuck();
            var mallardFour = duckFactory.CreateMallardDuck();
            
            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);
            
            flockOfDucks.Add(flockOfMallards);
            
            Console.WriteLine("\nDuck SImulator: whole flock simulation");
            Simulate(flockOfDucks);
            
            Console.WriteLine("\nDuck Simulator: Mallard flock simulation");
            Simulate(flockOfMallards);
            
            Console.WriteLine($"the ducks quacked {QuackCounter.GetQuacks()} times");
        }

        public void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}