using System;
using Patterns.Iterator.SimpleImplementation;

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