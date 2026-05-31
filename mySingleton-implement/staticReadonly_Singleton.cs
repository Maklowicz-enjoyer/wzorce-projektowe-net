using System;
using System.Collections.Generic;
using System.Text;

namespace mySingleton_implement
{
    internal class staticReadonly_Singleton
    {
        private static readonly staticReadonly_Singleton instance = new staticReadonly_Singleton();
        private staticReadonly_Singleton() { }

        public static staticReadonly_Singleton GetInstance() => instance;
        public void Log(string message) => Console.WriteLine($"[Simple] {message}");
    }
}

