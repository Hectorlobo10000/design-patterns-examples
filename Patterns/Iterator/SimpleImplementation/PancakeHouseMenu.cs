using System.Collections.Generic;

namespace Patterns.Iterator.SimpleImplementation
{
    public class PancakeHouseMenu
    {
        private List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            
            AddMenuItem("Regular pancake breakfast", "pancakes with fried eggs, sausage", false, 3.99);
        }
        
        public void AddMenuItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }
}