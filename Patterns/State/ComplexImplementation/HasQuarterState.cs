using System;

namespace Patterns.State.ComplexImplementation
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        private Random randomWinner = new Random(DateTime.Today.Millisecond);
        
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("you can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("you turned...");
            var winner = randomWinner.Next(10);
            if ((winner == 0) && (_gumballMachine.GetCount() > 1))
            {
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.GetSoldState()); 
            }
        }

        public void Dispense()
        {
            Console.WriteLine("no gumball dispensed");
        }
    }
}