namespace Patterns.Iterator.SimpleImplementation
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (_position >= items.Length || items[_position] == null)
            {
                return false;
            }

            return true;
        }

        public MenuItem next()
        {
            var menuItem = items[_position];
            _position += 1;
            return menuItem;
        }
    }
}