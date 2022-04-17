using System;
using Patterns.Iterator.SimpleImplementation;

// the iterator pattern provides a way to access the elements of an aggregate object sequentially without
// exposing its underlying repsentation.

// Single Responsability: A class should have only one reason to change.

namespace IteratorP
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            var waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            
            waitress.PrintMenu();
        }
    }
}