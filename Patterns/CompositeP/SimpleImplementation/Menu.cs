using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.CompositeP.SimpleImplementation
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.WriteLine($"\n {GetName()}, {GetDescription()}--------------------------");
            foreach (var menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}