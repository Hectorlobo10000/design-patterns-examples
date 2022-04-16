using System;

namespace Patterns.Iterator.SimpleImplementation
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem next();
    }
}