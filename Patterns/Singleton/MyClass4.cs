namespace Patterns.Singleton
{
    public class MyClass4
    {
        private static MyClass4 _uniqueInstance;
        private static readonly object _lock = new();
        
        private MyClass4() {}

        public static MyClass4 GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (_lock)
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new MyClass4();
                    }
                }
            }

            return _uniqueInstance;
        }
    }
}