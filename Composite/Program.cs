using System;
using Patterns.CompositeP.SimpleImplementation;

// the composite pattern allows you to compose objects into tree structures to represent part-whole
// hierarchies. composite lets clients treat individual objects and compositions of objects uniformly.

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new Menu("pancake house menu", "breakfast");
            var dinerMenu = new Menu("diner menu", "lunch");
            var cafeMenu = new Menu("cafe menu", "dinner");
            var dessertMenu = new Menu("dessert menu", "dessert of course!");

            var allMenus = new Menu("all menus", "all menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("pasta", "spaghetti with marinara sauce, and a slice of sourdough bread", true,
                3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("apple pie", "apple pie with a flakey crust, topped with vanilla icecream",
                true, 1.59));

            var waitress = new Waitress(allMenus);
            
            waitress.PrintMenu();
        }
    }
}