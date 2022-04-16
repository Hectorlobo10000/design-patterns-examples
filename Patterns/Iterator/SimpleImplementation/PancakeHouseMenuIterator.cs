using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator.SimpleImplementation
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<MenuItem> items;
        private int Position;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (Position >= items.Count || items[Position] == null)
            {
                return false;
            }

            return true;
        }

        public MenuItem next()
        {
            var menuItem = items[Position];
            Position += 1;
            return menuItem;
        }
    }
}