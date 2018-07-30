using System;

namespace SingletonSample
{
    /// <summary>
    /// sealed class
    /// </summary>
    public sealed class SingletonClass
    {
        private int i = 0;

        private static SingletonClass _singletonObject;
        private static object _syncRoot = new object();

        /// <summary>
        /// private constructor
        /// </summary>
        private SingletonClass()
        { }

        public void Show()
        {
            Console.WriteLine("Hello " + i.ToString());
            i += 1;
        }

        public static object SingletonObject
        {
            get
            {
                if (_singletonObject == null)
                {
                    lock (_syncRoot)
                    {
                        if (_singletonObject == null)
                        {
                            GetSingleton();

                        }
                    }
                }

                return _singletonObject;
            }
        }

        private static void GetSingleton()
        {
            _singletonObject = new SingletonClass();
        }
    }
}