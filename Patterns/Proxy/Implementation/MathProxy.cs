namespace Patterns.Proxy.Implementation
{
    public class MathProxy : IMath
    {
        private readonly RealMath _realMath;

        public MathProxy(RealMath realMath)
        {
            _realMath = realMath;
        }

        public double Add(double x, double y)
        {
            return _realMath.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            return _realMath.Sub(x, y);
        }
    }
}