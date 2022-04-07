using System;
using System.Linq.Expressions;
using Patterns.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Beverage beverage = new Expresso();
            // Console.WriteLine($"{beverage.GetDescription()}$ {beverage.Cost()}");

            Beverage beverage2 = new Expresso();
            beverage2 = new Mocha(beverage2);
            // beverage2 = new Mocha(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()}$ {beverage2.Cost()}");
        }
    }
}