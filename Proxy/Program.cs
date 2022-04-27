using System;
using Patterns.Proxy.Implementation;

// the proxy pattern: provide a surrogate or placeholder for another object to control access to it.

// here are a few ways proxies controls access

// 1 as we know, a remote proxy controls access to a remote object.
// 2 a virtual proxy controls access to a resource that is expensive.
// 3 a protection proxy controls access to a resource based on access rights.

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new RealMath();
            var mathProxy = new MathProxy(math);
            
            Console.WriteLine($"adding 5 + 2 = {math.Add(5, 2)}");
        }
    }
}