using System;

// the singleton pattern ensures a class has only one instance, and provides a global pint of access to it.

// can we improve multithreading

//1. do nothing if the performance of getInstance() is not critical to your application
//2. move to an eagerly created instance rather than a lazily created one
//3. use double-checked locking to reduce the use of synchronization in getInstanced()

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}