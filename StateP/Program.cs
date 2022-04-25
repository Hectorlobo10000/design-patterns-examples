using System;
using Patterns.State.ComplexImplementation;

// the state pattern: allows an object to alter its behavior when its internal state changes. the object will
// appear to change its class

namespace StateP
{
    class Program
    {
        static void Main(string[] args)
        {
            // var gumballMachine = new GumballMachine(5);
            //
            // Console.WriteLine(gumballMachine);
            //
            // gumballMachine.InsertQuarte();
            // gumballMachine.TurnCrank();
            //
            // Console.WriteLine(gumballMachine);
            //
            // gumballMachine.InsertQuarte();
            // gumballMachine.EjectQuarter();
            // gumballMachine.TurnCrank();
            //
            // Console.WriteLine(gumballMachine);
            //
            // gumballMachine.InsertQuarte();
            // gumballMachine.TurnCrank();
            // gumballMachine.InsertQuarte();
            // gumballMachine.TurnCrank();
            // gumballMachine.EjectQuarter();
            //
            // Console.WriteLine(gumballMachine);
            //
            // gumballMachine.InsertQuarte();
            // gumballMachine.InsertQuarte();
            // gumballMachine.TurnCrank();
            // gumballMachine.InsertQuarte();
            // gumballMachine.TurnCrank();
            // gumballMachine.InsertQuarte();
            // gumballMachine.TurnCrank();
            //
            // Console.WriteLine(gumballMachine);

            var gumballMachine = new GumballMachine(5);
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            
            Console.WriteLine(gumballMachine);
        }
    }
}