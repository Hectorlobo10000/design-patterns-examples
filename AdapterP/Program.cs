using System;
using Patterns.Adapter.SimpleAdapter;

//the adapter pattern converts the interface of a class into another interface the clients expect.
// adapter lets classes work together that couldn't otherwise because of incompatible interfaces

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