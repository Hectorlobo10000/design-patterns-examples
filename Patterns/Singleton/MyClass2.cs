using System.Runtime.CompilerServices;

namespace Patterns.Singleton
{
    public class MyClass2
    {
        private static MyClass2 _uniqueInstance;
        
        private MyClass2(){}

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static MyClass2 GetInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new MyClass2();
            }

            return _uniqueInstance;
        }
    }
}