using System;

namespace Patterns.State.ComplexImplementation
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("please wait, we're already gibing you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("turning twice doesn't get you another gumabl!");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.GetCount() > 0)
            {
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("oops, out of gumball");
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
        }
    }
}