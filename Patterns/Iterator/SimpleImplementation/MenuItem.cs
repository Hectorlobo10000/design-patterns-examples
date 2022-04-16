namespace Patterns.Iterator.SimpleImplementation
{
    public class MenuItem
    {
        public string Name;
        public string Description;
        public bool Vegetarian;
        public double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            this.price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public double GetPrice()
        {
            return price;
        }

        public bool IsVegetarian()
        {
            return Vegetarian;
        }
        
    }
}