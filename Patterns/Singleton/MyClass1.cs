namespace Patterns.Singleton
{
    public class MyClass1
    {
        private static MyClass1 _uniqueInstance;
        
        private MyClass1(){}

        public static MyClass1 GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new MyClass1();
            }

            return _uniqueInstance;
        }
    }
}