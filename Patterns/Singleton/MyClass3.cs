namespace Patterns.Singleton
{
    public class MyClass3
    {
        private static MyClass3 _uniqueInstance = new MyClass3();

        private MyClass3(){}

        public static MyClass3 GetInstance()
        {
            return _uniqueInstance;
        }
    }
}