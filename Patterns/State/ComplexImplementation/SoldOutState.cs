using System;

namespace Patterns.State.ComplexImplementation
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("you can not insert another quarter.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("you can not eject, you have not inserted a quarter yet.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("you turned but there are not gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("no gumball dispensed.");
        }
    }
}