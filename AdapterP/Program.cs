using System;
using Patterns.Adapter.SimpleAdapter;

namespace AdapterP
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();

            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);
            
            Console.WriteLine("the turkey says...");
            turkey.Gobble();
            turkey.Fly();
            
            Console.WriteLine("\n the duck says...");
            mallardDuck.Quack();
            mallardDuck.Fly();
            
            Console.WriteLine("\nthe turkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}