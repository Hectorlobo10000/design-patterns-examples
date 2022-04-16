using System;

namespace Patterns.Iterator.SimpleImplementation
{
    public class Waitress
    {
        private readonly PancakeHouseMenu _pancakeHouseMenu;
        private readonly DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();
            
            Console.WriteLine("\nmenu     \nbreakfast");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nlunch");
            PrintMenu(dinerIterator);
        }

        public void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = iterator.next();
                Console.WriteLine(menuItem.GetName());
                Console.WriteLine(menuItem.GetPrice());
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}