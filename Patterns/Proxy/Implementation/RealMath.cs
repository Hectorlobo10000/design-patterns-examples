using System;

namespace Patterns.Proxy.Implementation
{
    public class RealMath : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }
    }
}