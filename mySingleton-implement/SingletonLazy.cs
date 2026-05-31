using System;
using System.Collections.Generic;
using System.Text;

namespace mySingleton_implement
{
    internal class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> lazy = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy() { } // private constructor

        public static SingletonLazy Instance => lazy.Value; // property instead of method
        public void Log(String message) => Console.WriteLine($"[LAZY] {message}");
    }
}
