using System;

namespace mySingleton_implement
{
    internal class SingletonThreadLock
    {
        private static SingletonThreadLock instance;
        private static readonly object _lock = new object(); // Lock object for thread safety

        private SingletonThreadLock() { } // Private constructor to prevent instantiation

        public static SingletonThreadLock GetInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new SingletonThreadLock();
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOCK] {message}");
        }
    }
}
