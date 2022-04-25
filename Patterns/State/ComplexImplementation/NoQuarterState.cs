using System;

namespace Patterns.State.ComplexImplementation
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("your inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("you have not inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("you turned, but there is no quarted");
        }

        public void Dispense()
        {
            Console.WriteLine("you need to pay first");
        }
    }
}