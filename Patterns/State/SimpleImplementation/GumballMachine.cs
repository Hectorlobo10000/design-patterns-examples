using System;

namespace Patterns.State.SimpleImplementation
{
    public class GumballMachine
    {
        private static int SOLD_OUT = 0;
        private static int NO_QUARTER = 1;
        private static int HAS_QUARTER = 2;
        private static int SOLD = 3;

        private int _state = SOLD_OUT;
        private int _count = 0;

        public GumballMachine(int count)
        {
            _count = count;
            if (count > 0)
            {
                _state = NO_QUARTER;
            }
        }


        public void InsertQuarte()
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("you can not insert another quarter");
            }
            
            if (_state == NO_QUARTER)
            {
                _state = HAS_QUARTER;
                Console.WriteLine("you inserted a quarter");
            }
            
            if (_state == SOLD_OUT)
            {
                Console.WriteLine("you can not insert a quarter, the machi");
            }
            
            if (_state == SOLD)
            {
                Console.WriteLine("please wait, we're already giving you a gumball");
            }
        }

        public void EjectQuarter()
        {
            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("quarter returned");
                _state = NO_QUARTER;
            }
            
            if (_state == NO_QUARTER)
            {
                Console.WriteLine("you have not inserted a quarter");
            }
            
            if (_state == SOLD)
            {
                Console.WriteLine("sorry, you already turned the crank");
            }
            
            if (_state == SOLD_OUT)
            {
                Console.WriteLine("you can not eject, you haven't inserted a qurater yet");
            }
        }

        public void TurnCrank()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("turning twice doesn't get you another gumball!");
            }

            if (_state == NO_QUARTER)
            {
                Console.WriteLine("you turned but there's no quarter");
            }

            if (_state == SOLD_OUT)
            {
                Console.WriteLine("you turned but there are no gumballs");
            }

            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("you turned...");
            }
        }

        public void Dispense()
        {
            if (_state == SOLD)
            {
                Console.WriteLine("a gumball comes rolling out the slot");
                _count -= 1;
                if (_count == 0)
                {
                    Console.WriteLine("oops, out of gumballs");
                    _state = SOLD_OUT;
                }
                else
                {
                    _state = NO_QUARTER;
                }
            }

            if (_state == NO_QUARTER)
            {
                Console.WriteLine("you need tyo pay first");
            }

            if (_state == SOLD_OUT)
            {
                Console.WriteLine("no gumball dispensed");
            }

            if (_state == HAS_QUARTER)
            {
                Console.WriteLine("no gumball dispensed");
            }
        }

        public override string ToString()
        {
            return $"Inventory: {_count}";
        }
    }
}