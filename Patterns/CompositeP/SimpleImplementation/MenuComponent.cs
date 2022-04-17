using System;

namespace Patterns.CompositeP.SimpleImplementation
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new ArgumentException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new ArgumentException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new ArgumentException();
        }

        public virtual string GetName()
        {
            throw new ArgumentException();
        }

        public virtual string GetDescription()
        {
            throw new ArgumentException();
        }

        public virtual double GetPrice()
        {
            throw new ArgumentException();
        }

        public virtual bool IsVegetarian()
        {
            throw new ArgumentException();
        }

        public virtual void Print()
        {
            throw new ArgumentException();
        }
    }
}