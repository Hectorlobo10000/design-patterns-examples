using System;
using System.Text;

namespace Patterns.State.ComplexImplementation
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;

        private IState _state;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);

            _count = numberGumballs;
            if (numberGumballs > 0)
            {
                _state = _noQuarterState;
            }
            else
            {
                _state = _soldState;
            }
        }
        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public int GetCount()
        {
            return _count;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("a gumball comes rolling out the slot...");

            if (_count != 0) _count -= 1;
        }

        public IState GetWinnerState()
        {
            return _winnerState;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(
                $"mighty gumabll, inc. \ngumball model #2004 \nInventory: {_count} gumballs \nmachine is waiting for quarter.\n");

            return stringBuilder.ToString();
        }
    }
}