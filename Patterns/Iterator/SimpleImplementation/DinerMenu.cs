using System;
using System.Linq;

namespace Patterns.Iterator.SimpleImplementation
{
    public class DinerMenu
    {
        private static int MAX_ITEMS = 6;
        private int numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];
            
            AddItem("vegetarina btl", "faking", true, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("sorry, menu is full, can't add item to menu");
            }

            _menuItems[numberOfItems] = menuItem;
            numberOfItems += 1;
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}